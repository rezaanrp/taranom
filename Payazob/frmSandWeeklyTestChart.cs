using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSandWeeklyTestChart : Form
    {
        public frmSandWeeklyTestChart(CS.csEnum.TypeLineMachine Lmn)
        {
            InitializeComponent();
            Lmn_ = Lmn;
        }
        DataTable dt_spc;
        CS.csEnum.TypeLineMachine Lmn_;
        private void button1_Click(object sender, EventArgs e)
        {
  

        }

        private void btn_SandTestChart_Click(object sender, EventArgs e)
        {
            frmSendReport frm = new frmSendReport();
            frm.ShowDialog();
        }

        private void printToolStripButton_Click_1(object sender, EventArgs e)
        {
            BLL.csSand csd = new BLL.csSand();
            dt_spc = csd.SelectSandWeeklyTestSummaryByDate(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            Report.SendReport csr = new Report.SendReport();
            frmReport r = new frmReport();
            DataTable dt = new BLL.csSand().SlSandWeeklyTestSpc("", "");
            foreach (DataColumn item in dt.Columns)
            {
                
                csr.SetParam(item.ColumnName, dt.Rows[0][item.ColumnName].ToString());

            }
            csr.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            csr.SetParam("DateTo", uc_Filter_Date1.DateTo);
            csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            r.GetReport = csr.GetReport(dt_spc, "crsSlSandWeeklyTestSpc");
            r.ShowDialog();
            r.Dispose();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csSand csd = new BLL.csSand();
            dt_spc = csd.SelectSandWeeklyTestSummaryByDate(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_spc;
            dataGridView1.DataSource = bindingSource1;
            generate();
        }

        void generate()
        {

            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xAfsBefore"].HeaderText = "دانه بندی قبل از شستشو";
            dataGridView1.Columns["xAfsAfter"].HeaderText = "دانه بندی بعد از شستشو";
            dataGridView1.Columns["xVolatilePercent"].HeaderText = "درصد مواد فرار";
            dataGridView1.Columns["xBurningPercent"].HeaderText = "درصد مواد سوختنی";
            dataGridView1.Columns["xGlayPercent"].HeaderText = "درصد خاک";
            dataGridView1.Columns["xActiveBentnitePercent"].HeaderText = "درصد بنتونیت فعال";
            dataGridView1.Columns["xPermeability"].HeaderText = "عبور گاز";
            dataGridView1.Columns["Approve"].HeaderText = "تایید کننده";
            dataGridView1.Columns["xSupplier"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xGenGroup_"].Visible = false;
            dataGridView1.Columns["xGenGroup"].HeaderText = "نوع خط";

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;

        }
        void GenChart(string XValue, string YValue)
        {

            chart1.DataSource = dt_spc.Select("xGenGroup_ = 90 AND " + YValue + " > 0"," xDate ASC "); 
            chart1.Series["Series1"].XValueMember = XValue;
            chart1.Series["Series1"].YValueMembers = YValue;
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            chart2.DataSource = dt_spc.Select("xGenGroup_ = 91 AND " + YValue + " > 0"," xDate ASC ");
            chart2.Series["Series1"].XValueMember = XValue;
            chart2.Series["Series1"].YValueMembers = YValue;
            chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            string dtn = dataGridView1.Columns[ e.ColumnIndex].Name;
            if (dtn == "xAfsBefore" || dtn == "xAfsAfter" ||
                dtn == "xVolatilePercent" || dtn == "xBurningPercent" ||
                dtn == "xGlayPercent" || dtn == "xActiveBentnitePercent" ||
                dtn == "xPermeability")
            {
                lbl_Line.Text = dataGridView1["xGenGroup", e.RowIndex].Value.ToString();
                btn_Chart.Enabled = true;
                btn_Chart.Text = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                GenChart("xDate", dataGridView1.Columns[e.ColumnIndex].Name);
            }
            else
            {
                btn_Chart.Text ="...";
                lbl_Line.Text = ".";
                btn_Chart.Enabled = false;
            }


        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            //if (btn_Chart.Text == "...")
            //    MessageBox.Show("جهت نمایش نمودار مربوط بر روی یکی دادهای پایین کلیک کنید");
            //else
            //{
            //    int Dvg_R = dataGridView1.SelectedCells[0].RowIndex;

            //    Form f = new
            //    FRM.Sand.frmSpc(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, dataGridView1.SelectedCells[0].OwningColumn.Name, " ", "SlSandWeeklyTest_RChar_SPC", (int)dataGridView1["xGenGroup_", Dvg_R].Value,Lmn_);
            //    f.Text = (sender as Button).Text;
            //    f.Show();
            //}
        }
    }
}
