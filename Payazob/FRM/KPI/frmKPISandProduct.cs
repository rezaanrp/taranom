using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Payazob.FRM.KPI
{
    public partial class frmKPISandProduct : Form
    {
        public frmKPISandProduct(string DateFrom, string DateTo)
        {
            InitializeComponent();

            BLL.KPI.csKPI cs = new BLL.KPI.csKPI();

                dt_D = cs.SlKPISandMaterialOnMelts(DateFrom, DateTo);


            if (dt_D.Rows.Count < 0)
                this.Close();

            GenChart_T_R("BantonitOnMeltWeight","","","نسبت مصرق بنتونیت در هر تن ذوب به کیلو گرم");
            GenChart_T_L("CoalDustOnMeltWeight", "","","گرد زغال");
            GenChart_B_R("SandNewOnMeltWeight", "","","ماسه جدید");
            GenChart_B_L("WaterOnMeltWeight", "","", "آب");
      //      GenChart_T_L("xBar" + SandChart, "UCL_XBAR" + SandChart, "LCL_XBAR" + SandChart);
      //      GenChart_B_R("xRBAR" + SandChart, "UCL_RBAR" + SandChart, "LCL_XBAR" + SandChart, "R CHART");

        }
        DataTable dt_D;

        void GenChart_T_R(string S1, string S2, string S3, string Titl)
        {

            chart_T_R.DataSource = dt_D.Select(S1 + " > 0", " xDate ASC  ");
            chart_T_R.Series["Series1"].XValueMember = "xDate";
            chart_T_R.Series["Series1"].YValueMembers = S1;

            //chart_T_R.Series["Series2"].XValueMember = "xDate";
            //chart_T_R.Series["Series2"].YValueMembers = S2;
            //chart_T_R.Series["Series2"].LegendText = "UCL";


            //chart_T_R.Series["Series3"].XValueMember = "xDate";
            //chart_T_R.Series["Series3"].YValueMembers = S3;
            //chart_T_R.Series["Series3"].LegendText = "LCL";
            chart_T_R.Titles[0].Text = Titl;

            chart_T_R.Series.Add("TrendLine");
            chart_T_R.Series["TrendLine"].ChartType = SeriesChartType.Line;
            chart_T_R.Series["TrendLine"].BorderWidth = 3;
            chart_T_R.Series["TrendLine"].Color = Color.Red;
            // Line of best fit is linear
            string typeRegression = "Linear";//"Exponential";//
                                             // The number of days for Forecasting
            string forecasting = "1";
            // Show Error as a range chart.
            string error = "false";
            // Show Forecasting Error as a range chart.
            string forecastingError = "false";
            // Formula parameters
            string parameters = typeRegression + ',' + forecasting + ',' + error + ',' + forecastingError;
            chart_T_R.Series[0].Sort(PointSortOrder.Ascending, "X");
            // Create Forecasting Series.
           // chart_T_R.DataManipulator.FinancialFormula(FinancialFormula.Forecasting, chart_T_R.Series[0], chart_T_R.Series["TrendLine"]);
        }

        void GenChart_T_L(string S1, string S2, string S3, string Titl)
        {

            chart_T_L.DataSource = dt_D.Select(S1 + " > 0", " xDate ASC ");
            chart_T_L.Series["Series1"].XValueMember = "xDate";
            chart_T_L.Series["Series1"].YValueMembers = S1;

            //chart_T_L.Series["Series2"].XValueMember = "xDate";
            //chart_T_L.Series["Series2"].YValueMembers = S2;
            //chart_T_L.Series["Series2"].LegendText = "UCL";


            //chart_T_L.Series["Series3"].XValueMember = "xDate";
            //chart_T_L.Series["Series3"].YValueMembers = S3;
            //chart_T_L.Series["Series3"].LegendText = "LCL";

            chart_T_L.Titles[0].Text = Titl;
        }

        void GenChart_B_R(string S1, string S2, string S3, string Tile)
        {


            chart_B_R.DataSource = dt_D.Select(S1 + " IS NOT NULL ", " xDate ASC ");
            chart_B_R.Series["Series1"].XValueMember = "xDate";
            chart_B_R.Series["Series1"].YValueMembers = S1;

            //chart_B_R.Series["Series2"].XValueMember = "xDate";
            //chart_B_R.Series["Series2"].YValueMembers = S2;
            //chart_B_R.Series["Series2"].LegendText = "UCL";

            chart_B_R.Titles[0].Text = Tile;
        }
        void GenChart_B_L(string S1, string S2, string S3, string Tile)
        {


            chart_B_L.DataSource = dt_D.Select(S1 + " IS NOT NULL ", " xDate ASC ");
            chart_B_L.Series["Series1"].XValueMember = "xDate";
            chart_B_L.Series["Series1"].YValueMembers = S1;

            //chart_B_R.Series["Series2"].XValueMember = "xDate";
            //chart_B_R.Series["Series2"].YValueMembers = S2;
            //chart_B_R.Series["Series2"].LegendText = "UCL";

            chart_B_L.Titles[0].Text = Tile;
        }


        private void frmSpc_Load(object sender, EventArgs e)
        {

        }
    }
}
