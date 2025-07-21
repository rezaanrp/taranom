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
    public partial class frmInventoryTotal_Report : Form
    {
        public frmInventoryTotal_Report()
        {
            InitializeComponent();
            
            BLL.csInventory cs = new BLL.csInventory();
            dt = cs.SelectInventoryGroupByPieces(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text,Properties.Settings.Default.WorkYear);
            dataGridView1.DataSource = dt;
            bindingSource1.DataSource = dt;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

        }
        DAL.inventory.DataSet_Inventory.SelectInventoryGroupByPiecesDataTable dt;

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csInventory cs = new BLL.csInventory();
            dt = cs.SelectInventoryGroupByPieces(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text,Properties.Settings.Default.WorkYear);
            dataGridView1.DataSource = dt;
            bindingSource1.DataSource = dt;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        void  Generate()
        {
            /*
               xName,
                        BeforPiecesProducts,
                        BeforSendNumber,
                        BeforDefectNumber,
                        AfterPiecesProducts,
                        AfterSendNumber,
                        AfterDefectNumber,
                        inventory
             */
            dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            dataGridView1.Columns["BeforPiecesProducts"].HeaderText = "تعداد تولید قبل از دوره";
            dataGridView1.Columns["BeforSendNumber"].HeaderText = "تعداد ارسال به انبار قبل از دوره";
            dataGridView1.Columns["BeforDefectNumber"].HeaderText = "ضایعات قبل از دوره";
            dataGridView1.Columns["AfterPiecesProducts"].HeaderText = "تعداد قطعه تولید شده در دوره";
            dataGridView1.Columns["AfterSendNumber"].HeaderText = "تعداد ارسال به انبار در دوره";
            dataGridView1.Columns["AfterDefectNumber"].HeaderText = "تعداد ضایعات در دوره";
            dataGridView1.Columns["inventory"].HeaderText = "موجودی در گردش";
            dataGridView1.Columns["Pieceweight"].HeaderText = "وزن قطعه";
            dataGridView1.Columns["PieceweightTotal"].HeaderText = "وزن موجودی در گردش";
            
            dataGridView1.Columns["x_"].Visible = false;
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {


            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
         //   cs.SetParam("DateNow1", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt, "crsInventoryTotal");
            r.ShowDialog();
            r.Dispose();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
