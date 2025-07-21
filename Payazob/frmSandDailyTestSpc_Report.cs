using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSandDailyTestSpc_Report : Form
    {
        public frmSandDailyTestSpc_Report(CS.csEnum.TypeLineMachine LnMc)
        {
            InitializeComponent();
            MchL = LnMc;
        }
        DataTable dt_D;
        CS.csEnum.TypeLineMachine MchL = CS.csEnum.TypeLineMachine.Tokyo;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csSand cs = new BLL.csSand();

            dt_D = cs.SlSandDailyTestSpcTable((int)MchL, uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);

            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            Generate();



        }
        void Generate()
        {
            dataGridView1.Columns["xMoisturePercent"].HeaderText = "درصد رطوبت";
            dataGridView1.Columns["xPermeability"].HeaderText = "عبور گاز";
            dataGridView1.Columns["xCompresiveStrength"].HeaderText = "استحکام فشاری";
            dataGridView1.Columns["xCompactibility"].HeaderText = "تراکم پذیری";
            dataGridView1.Columns["CompactOnMoisture"].HeaderText = "نسبت تراکم پذیری به رطوبت";
            dataGridView1.Columns["xWaterHardness"].HeaderText = "سختی آب";

            dataGridView1.Columns["CompactOnMoisture"].DefaultCellStyle.Format = "N2";
            //dataGridView1.Columns["UclxMoisturePercent"].HeaderText = "درصد رطوبت" + " UCL ";
            //dataGridView1.Columns["clxMoisturePercent"].HeaderText = "درصد رطوبت" + " CL ";
            //dataGridView1.Columns["LclxMoisturePercent"].HeaderText = "درصد رطوبت" + " LCL ";
            //dataGridView1.Columns["SigmaxMoisturePercent"].HeaderText = "درصد رطوبت";
            dataGridView1.Columns["SigmaxMoisturePercent"].Visible = false;


            //dataGridView1.Columns["UclxPermeability"].HeaderText = "عبور گاز" + " UCL ";
            //dataGridView1.Columns["clxPermeability"].HeaderText = "عبور گاز" + " CL ";
            //dataGridView1.Columns["LclxPermeability"].HeaderText = "عبور گاز" + "LCL";
            //dataGridView1.Columns["SigmaxPermeability"].HeaderText = "عبور گاز";
            dataGridView1.Columns["SigmaxPermeability"].Visible = false;

            //dataGridView1.Columns["UclxCompresiveStrength"].HeaderText = "استحکام فشاری" + " UCL ";
            //dataGridView1.Columns["clxCompresiveStrength"].HeaderText = "استحکام فشاری" + " CL ";
            //dataGridView1.Columns["LclxCompresiveStrength"].HeaderText = "استحکام فشاری" + "LCL";
            //dataGridView1.Columns["SigmaxCompresiveStrength"].HeaderText = "استحکام فشاری";
            dataGridView1.Columns["SigmaxCompresiveStrength"].Visible = false;

            //dataGridView1.Columns["UclxCompactibility"].HeaderText = "تراکم پذیری" + " UCL ";
            //dataGridView1.Columns["clxCompactibility"].HeaderText = "تراکم پذیری" + " CL ";
            //dataGridView1.Columns["LclxCompactibility"].HeaderText = "تراکم پذیری" + "LCL";
            //dataGridView1.Columns["SigmaxCompactibility"].HeaderText = "تراکم پذیری";
            dataGridView1.Columns["SigmaxCompactibility"].Visible = false;
            dataGridView1.Columns["SigmaxWaterHardness"].Visible = false;
             
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new BLL.csSand().SlSandDailyTestRange();

            DataRow dr = dt.Rows[0];

            Report.SendReport cs = new Report.SendReport();

            cs.SetParam("UclxMoisturePercent", dr["xMoisturePercentUcl"].ToString());
            cs.SetParam("LclxMoisturePercent", dr["xMoisturePercentLcl"].ToString());
            cs.SetParam("clxMoisturePercent", dr["xMoisturePercentcl"].ToString());

            cs.SetParam("UclxPermeability", dr["xPermeabilityUcl"].ToString());
            cs.SetParam("LclxPermeability", dr["xPermeabilityLcl"].ToString());
            cs.SetParam("clxPermeability", dr["xPermeabilitycl"].ToString());

            cs.SetParam("UclxCompresiveStrength", dr["xCompresiveStrengthUcl"].ToString());
            cs.SetParam("LclxCompresiveStrength", dr["xCompresiveStrengthLcl"].ToString());
            cs.SetParam("clxCompresiveStrength", dr["xCompresiveStrengthcl"].ToString());

            cs.SetParam("UclxCompactibility", dr["xCompactibilityUcl"].ToString());
            cs.SetParam("LclxCompactibility", dr["xCompactibilityLcl"].ToString());
            cs.SetParam("clxCompactibility", dr["xCompactibilitycl"].ToString());

            cs.SetParam("UslxMoisturePercent", dr["xMoisturePercentUsl"].ToString());
            cs.SetParam("LslxMoisturePercent", dr["xMoisturePercentLsl"].ToString());
            cs.SetParam("slxMoisturePercent", dr["xMoisturePercentsl"].ToString());

            cs.SetParam("UslxPermeability", dr["xPermeabilityUsl"].ToString());
            cs.SetParam("LslxPermeability", dr["xPermeabilityLsl"].ToString());
            cs.SetParam("slxPermeability", dr["xPermeabilitysl"].ToString());

            cs.SetParam("UslxCompresiveStrength", dr["xCompresiveStrengthUsl"].ToString());
            cs.SetParam("LslxCompresiveStrength", dr["xCompresiveStrengthLsl"].ToString());
            cs.SetParam("slxCompresiveStrength", dr["xCompresiveStrengthsl"].ToString());

            cs.SetParam("UslxCompactibility", dr["xCompactibilityUsl"].ToString());
            cs.SetParam("LslxCompactibility", dr["xCompactibilityLsl"].ToString());
            cs.SetParam("slxCompactibility", dr["xCompactibilitysl"].ToString());

            cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_D, "crsSandDailyTestSpc");
            r.ShowDialog();
            r.Dispose();
        }
        void GenChart(string XValue, string YValue)
        {

            chart1.DataSource = dt_D.Select( YValue + " IS NOT NULL ");
            chart1.Series["Series1"].XValueMember = XValue;
            chart1.Series["Series1"].YValueMembers = YValue;
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            //
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xMoisturePercent")
            {
                GenChart("xDate", "xMoisturePercent");
                
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "xPermeability")
            {
                GenChart("xDate", "xPermeability");
                
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "xCompresiveStrength")
            {
               // GenChart("xDate", "xCompresiveStrength");
                chart1.DataSource = dt_D;
                chart1.Series["Series1"].XValueMember = "xDate";
                chart1.Series["Series1"].YValueMembers = "xCompresiveStrength";
                chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "xCompactibility")
            {
                GenChart("xDate", "xCompactibility");

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "CompactOnMoisture")
            {
                GenChart("xDate", "CompactOnMoisture");

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "xWaterHardness")
            {
                GenChart("xDate", "xWaterHardness");

            }
        }

        private void btn_xMoisturePercent_Click(object sender, EventArgs e)
        {
           //Form f  = new
           // FRM.Sand.frmSpc(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (sender as Button).Name.Substring(4), (sender as Button).Tag.ToString(), "SlSandDailyTest_RChar_SPC", 0, MchL);
           //f.Text = (sender as Button).Tag.ToString();
           //f.Show();
        }
    }
}
