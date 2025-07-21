using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmMoldingDownTimeTtTiGr_Report : Form
    {
        public frmMoldingDownTimeTtTiGr_Report(CS.csEnum.Factory FCT)
        {
            InitializeComponent();
            fct_ = FCT;
            if (FCT == CS.csEnum.Factory.Site3)
            {
                txt_avatime1.Visible = false;
                txt_avatime2.Visible = false;
                lbl_line1.Visible = false;
                lbl_line2.Visible = false;
            }
        }
        CS.csEnum.Factory fct_;
        DataTable dt_D = new DataTable();
        void generate()
        {
            dataGridView1.Columns["DownTime"].HeaderText = "مدت توقف";
            dataGridView1.Columns["NameDownTime"].HeaderText = "نوع توقف";
            dataGridView1.Columns["TotalMoldingDownTime"].HeaderText = "درصد توقف";
            dataGridView1.Columns["StopGeneralratio"].HeaderText = "درصد توقفات به کل زمان دسترس";
            dataGridView1.Columns["DurationLine1"].HeaderText = "مدت توقف خط یک";
            dataGridView1.Columns["DurationLine2"].HeaderText = "مدت توقف خط دو";

            if (fct_ == CS.csEnum.Factory.Site3)
            {
                dataGridView1.Columns["DurationLine2"].Visible = false;
                dataGridView1.Columns["DurationLine1"].Visible =false;
            }




            // dataGridView1.Columns["EfficiencyMolding"].Visible = false;
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            frmMoldingDownTimeType frm = new frmMoldingDownTimeType(false, CS.csEnum.TypeTree.DownTimeType,fct_);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
          //  MessageBox.Show(frm.ChildNode);
            BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
            int? Ava = 0;
            dt_D = cs.SlMoldingDownTimeTtTiGr(ref Ava, frm.ChildNode, uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (int)fct_);
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;

            int sum = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                sum += (int)item.Cells["DownTime"].Value;
            }
            txt_TotalDownTime.Text =  sum.ToString();

             if (Ava != null)
            {
             float te = ( (int)Ava - (float)sum )/ (int)Ava * 100  ;
             txt_EfficiencyMolding.Text = Math.Round(te, 1).ToString() ;
             Efficiency = Math.Round(te, 1).ToString();
            }

             txt_avatime.Text = Ava.ToString();

             int? Line1 = 0;
             int? Line2 = 0;
             cs.SlMoldingDownTimeTotalAvailableTime(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, ref Line1, ref Line2);
             txt_avatime1.Text = Line1.ToString();
             txt_avatime2.Text = Line2.ToString();
            generate();

            GenChart("NameDownTime", "TotalMoldingDownTime");
        }
        string Efficiency;
        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            cs.SetParam("Efficiency", Efficiency.ToString());
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_D, "crsMoldingDownTimeTtTiGr_Report");
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
        void GenChart(string XValue, string YValue)
        {

            chart1.DataSource = dt_D;
            chart1.Series["Series1"].XValueMember = XValue;
            chart1.Series["Series1"].YValueMembers = YValue;
           // chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.ChartAreas[0].AxisX.IsMarksNextToAxis = false;
           // chart1.Series["PieLabelStyle"] = "Outside";
            // Solution 1: Setting axis Interval  
            this.chart1.ChartAreas[0].AxisX.Interval = 1;

            // Solution 2: Enable variable interval  
            this.chart1.ChartAreas[0].AxisX.Interval = double.NaN;
            this.chart1.ChartAreas[0].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
        }
    }
}
