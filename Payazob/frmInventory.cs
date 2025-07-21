using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();

            /*  PiecesProductBefore,
                        PiecesSendBefore,
                        DefectBefore,
                        ProductPiecesAfter,
                        DefectNumberAfter,
                        ProductPiecesSent*/

            BLL.csPieces cp = new BLL.csPieces();

            dataGridView1.DataSource = cp.mPiecesDataTable();
            Generate();


        }
        void Generate()
        {
            dataGridView1.Columns["xKind"].Visible = false;
            dataGridView1.Columns["xStandard"].Visible = false;
            dataGridView1.Columns["xSolutionweight"].Visible = false;
            dataGridView1.Columns["xImage"].Visible = false;
            dataGridView1.Columns["xMarkettype"].Visible = false;
            dataGridView1.Columns["xMusclekhoury"].Visible = false;
            dataGridView1.Columns["xTechnicalname"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;

            dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            dataGridView1.Columns["xPieceweight"].HeaderText = "وزن قطعه";
            dataGridView1.Columns["xKbythtotal"].HeaderText = "تعداد کبیته";
            dataGridView1.Columns["xKbythtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["xName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            /*
              xName,
                        xKind,
                        xStandard,
                        xPieceweight,
                        xTechnicalname,
                        xSolutionweight,
                        xKbythtotal,
                        xImage,
                        xMarkettype,
                        xMusclekhoury
             */

        }
    //    DAL.inventory.DataSet_Inventory.SelectInventoryDataTable dt;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //BLL.csInventory cs = new BLL.csInventory();
            if (e.RowIndex < 0)
                return;
            int DefectBefore = 0;
            int DefectNumberAfter = 0;
            int PiecesProductBefore = 0;
            int PiecesSendBefore = 0;
            int ProductPiecesAfter = 0;
            int ProductPiecesSent = 0;

            BLL.csInventory cs = new BLL.csInventory();
            dt = cs.SelectInventory(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, (int)dataGridView1["x_", e.RowIndex].Value);
            if (dt.Rows.Count > 0)
            {
                DAL.inventory.DataSet_Inventory.SelectInventoryRow dr = dt[0];

                if (dr["DefectBefore"] == DBNull.Value)
                    DefectBefore = 0;
                else
                    DefectBefore = (int)dr["DefectBefore"];

                if (dr["DefectNumberAfter"] == DBNull.Value)
                    DefectNumberAfter = 0;
                else
                    DefectNumberAfter = (int)dr["DefectNumberAfter"];

                if (dr["PiecesProductBefore"] == DBNull.Value)
                    PiecesProductBefore = 0;
                else
                    PiecesProductBefore = (int)dr["PiecesProductBefore"];

                if (dr["PiecesSendBefore"] == DBNull.Value)
                    PiecesSendBefore = 0;
                else
                    PiecesSendBefore = (int)dr["PiecesSendBefore"];

                if (dr["ProductPiecesAfter"] == DBNull.Value)
                    ProductPiecesAfter = 0;
                else
                    ProductPiecesAfter = (int)dr["ProductPiecesAfter"];

                if (dr["ProductPiecesSent"] == DBNull.Value)
                    ProductPiecesSent = 0;
                else
                    ProductPiecesSent = (int)dr["ProductPiecesSent"];

                int In = ( PiecesProductBefore - (DefectBefore + PiecesSendBefore) ) + ( ProductPiecesAfter ) - (DefectNumberAfter + ProductPiecesSent);

                txt_Inventory.Text = In.ToString();

                txt_DefectBefore.Text = DefectBefore.ToString();
                txt_DefectNumberAfter.Text = DefectNumberAfter.ToString();
                txt_PiecesProductBefore.Text = PiecesProductBefore.ToString();
                txt_PiecesSendBefore.Text = PiecesSendBefore.ToString();
                txt_ProductPiecesAfter.Text = ProductPiecesAfter.ToString();
                txt_ProductPiecesSent.Text = ProductPiecesSent.ToString();


            }



        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            cs.SetParam("DateNow", uc_Filter_Date1.uc_txtDateTo.Text);
            cs.SetParam("txt_Inventory", txt_Inventory.Text);
            cs.SetParam("txt_Pieces", dataGridView1.SelectedRows[0].Cells["xName"].Value.ToString());
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt, "crsInventory");
            r.ShowDialog();
            r.Dispose();
        }

    }
}
