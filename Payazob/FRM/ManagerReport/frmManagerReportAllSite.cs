using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.ManagerReport
{
    public partial class frmManagerReportAllSite : Form
    {
        public frmManagerReportAllSite()
        {
            InitializeComponent();
        }

        private void frmManagerReportAllSite_Load(object sender, EventArgs e)
        {
            ShowData();
        }


        DataTable dt_s1;
        DataTable dt_s3;
        DataTable dt_s3_trading;
        private void ShowData()
        {
            BLL.csshamsidate csDate = new BLL.csshamsidate();

            dataGridView_dwn.DataSource = dt_s1 =
                new BLL.ManagerReport.csManagerReport().SlInventoryPiecesForManager_S1
                    (uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, Payazob.Properties.Settings.Default.WorkYear);
            dataGridView1.DataSource = dt_s3 = new BLL.ManagerReport.csManagerReport().SlInventoryPiecesForManager_S3
                 (uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, Payazob.Properties.Settings.Default.WorkYear);
            dataGridView2.DataSource = dt_s3_trading = new BLL.ManagerReport.csManagerReport().SlInventoryPiecesForManager_S3_trading
                (uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, Payazob.Properties.Settings.Default.WorkYear);
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_s1.Columns)
            {
                dataGridView_dwn.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            CS.csDataGridView csdgv = new CS.csDataGridView();
            csdgv.ColumnsCommaAllDecimal(ref dataGridView_dwn);

            foreach (DataColumn dc in dt_s3.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            csdgv.ColumnsCommaAllDecimal(ref dataGridView1);

            foreach (DataColumn dc in dt_s3_trading.Columns)
            {
                dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            csdgv.ColumnsCommaAllDecimal(ref dataGridView2);
            generate();
        }

        void generate()
        {
            dataGridView_dwn.Columns["xPieces_"].Visible = false;
            dataGridView1.Columns["xPieces_"].Visible = false;
            dataGridView2.Columns["xPieces_"].Visible = false;
            dataGridView_dwn.Columns["xPieceweight"].Visible = false;
            double SumInv=0;
            double item1 = 0;
            double item2 = 0;
            foreach (DataGridViewRow dtr in dataGridView_dwn.Rows)
            {
                item1 = (double)dtr.Cells["xPieceweight"].Value;
                item2 = (int)dtr.Cells["Inventory"].Value;
                SumInv += item1 * item2;
            }
            txtbox_rt.Text = "مجموع موجودی انبار نیمه ساخته : " + Math.Round(SumInv, 0).ToString("#,##0") + " (kg)";
            SumInv = 0;
            foreach (DataGridViewRow dtr in dataGridView_dwn.Rows)
            {
                item1 = (double)dtr.Cells["xPieceweight"].Value;
                item2 = (int)dtr.Cells["CountKanban"].Value;
                SumInv += item1 * item2;
            }
            txtbox_lt.Text = "مجموع ارسالی طی دوره : " + Math.Round(SumInv, 0).ToString("#,##0") + " (kg)";
            SumInv = 0;

            foreach (DataGridViewRow dtr in dataGridView_dwn.Rows)
            {
                item1 = (double)dtr.Cells["xPieceweight"].Value;
                item2 = (int)dtr.Cells["NumberPieces"].Value;
                SumInv += item1 * item2;
            }
            txtbox_rb.Text = "مجموع تناژ تولید طی دوره : " + Math.Round(SumInv, 0).ToString("#,##0") + " (kg)";
            SumInv = 0;

            foreach (DataGridViewRow dtr in dataGridView_dwn.Rows)
            {
                item1 = (double)dtr.Cells["xPieceweight"].Value;
                item2 = (int)dtr.Cells["Stock"].Value;
                SumInv += item1 * item2;
            }
            txtbox_lb.Text = "موجودی انبار محصول : " + Math.Round(SumInv, 0).ToString("#,##0") + " (kg)";

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView2.SelectedCells;

        }

        private void dataGridView_dwn_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView_dwn.SelectedCells;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_sum.Visible = false;

            if (tabControl1.SelectedIndex == 0)
            {
                panel_sum.Visible = true;
            }  
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {

            new FRM.ManagerReport.frmSalePlanForManager
            {
               Text  = btn_Sale.Text
            }.ShowDialog();
        }

        private void btn_pr_Click(object sender, EventArgs e)
        {
            new FRM.ManagerReport.frmPiecesProuductForManager_R
            {
                Text = btn_pr.Text
            }.ShowDialog();

        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            Form f;
                    f = new frmEmpty_Report("InventoryMaterialTurning", "");
                    (f as frmEmpty_Report).ReportHaveDateDetails = true;
                    (f as frmEmpty_Report).FilterDate = true;
                    (f as frmEmpty_Report).SetParamColor("InventoryCount", Color.LightBlue);

                    (f as frmEmpty_Report).SetParamColor("xMaterial_", Color.LightSteelBlue);

                    (f as frmEmpty_Report).SetParamColor("ProductTurningCountB", Color.LimeGreen);
                    (f as frmEmpty_Report).SetParamColor("ProductToTurningCountB", Color.LimeGreen);
                    (f as frmEmpty_Report).SetParamColor("BeforDefectNumber", Color.LimeGreen);
                    (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
                    f.WindowState = FormWindowState.Maximized;
                    f.Show();

            /*
             * xMaterial_
              EndF.ProductTurningCountB,EndF.ProductToTurningCountB,BeforDefectNumber
             */
        }
    }
}
