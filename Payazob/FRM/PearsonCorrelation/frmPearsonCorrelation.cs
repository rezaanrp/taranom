using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Payazob.FRM.PearsonCorrelation
{
    public partial class frmPearsonCorrelation : Form
    {
        public frmPearsonCorrelation()
        {
            InitializeComponent();
        }
        DataTable dt_S;
        DataTable dt_D;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDataDefect();
        }
        void Genereate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_S.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
            foreach (DataColumn dc in dt_D.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }

           
        }
        private void ShowData(int x_)
        {
            BLL.PearsonCorrelation.csPearsonCorrelation cs = new BLL.PearsonCorrelation.csPearsonCorrelation();

            dt_S = cs.SlPearsonCorrelationSandAndDefect(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, x_,(int)num_day.Value); ;
            bindingSource1.DataSource = dt_S;
            dataGridView2.DataSource = bindingSource1;
            Genereate();
   

        }
        DataTable dt_sand;
        DataTable dt_defect;

        void GenChartFlowSand(string XValue, string YValue)
        {

            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));

            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
              // chart2.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = StartFromZero.Auto;

            chart2.ChartAreas[0].AxisY.Crossing = 10;
            int tmpcount = chart2.Series.Count;

            for (int i = 0; i < tmpcount; i++)
            {
                chart2.Series.RemoveAt(0);
            }
            /////////
            System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            chart2.DataSource = dt_sand;

            series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            series_1.BackSecondaryColor = System.Drawing.Color.Black;
            series_1.BorderColor = System.Drawing.Color.White;
            series_1.ChartArea = "ChartArea1";
            series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series_1.IsValueShownAsLabel = false;
            series_1.IsVisibleInLegend = false;
            series_1.IsXValueIndexed = true;
            series_1.LabelToolTip = "WareHouse : X=#VALX, Y=#VALY";
            series_1.ShadowOffset = 0;
            series_1.ShadowOffset = 0;
            series_1.ToolTip = "WareHouse : X=#VALX, Y=#VALY";
            //   series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series_1.LabelFormat = "##,#";
            series_1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series_1.BorderWidth = 3;
            // series_1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            this.chart2.Series.Add(series_1);
            chart2.ChartAreas[0].AxisY.IsStartedFromZero = false;

            chart2.Titles["Title1"].Text = "روند آزمایشات ماسه  ";
            series_1.CustomProperties = "IsXAxisQuantitative=True, DrawingStyle=LightToDark, LabelStyle=Top";
            series_1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series_1.MarkerStep = 31;
            series_1.MarkerSize = 10;
            series_1.MarkerColor = Color.Orange;

            /////////

            chart2.DataSource = dt_sand;
            chart2.Series["Series1"].XValueMember = XValue;
            chart2.Series["Series1"].YValueMembers = YValue;
            chart2.ChartAreas[0].AxisX.IsMarksNextToAxis = false;
            this.chart2.ChartAreas[0].AxisX.Interval = 1;



        }


        void GenChartFlowDefect(string XValue, string YValue)
        {

            this.chart2_Defect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));

            chart2_Defect.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart2_Defect.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            // chart2.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = StartFromZero.Auto;

            chart2_Defect.ChartAreas[0].AxisY.Crossing = 10;
            int tmpcount = chart2_Defect.Series.Count;

            for (int i = 0; i < tmpcount; i++)
            {
                chart2_Defect.Series.RemoveAt(0);
            }
            /////////
            System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            chart2_Defect.DataSource = dt_sand;

            series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.None;
            series_1.BackSecondaryColor = System.Drawing.Color.Black;
            series_1.BorderColor = System.Drawing.Color.White;
            series_1.ChartArea = "ChartArea1";
            series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series_1.IsValueShownAsLabel = false;
            series_1.IsVisibleInLegend = false;
            series_1.IsXValueIndexed = true;
            series_1.LabelToolTip = "WareHouse : X=#VALX, Y=#VALY";
            series_1.ShadowOffset = 0;
            series_1.ShadowOffset = 0;
            series_1.ToolTip = "WareHouse : X=#VALX, Y=#VALY";
            //   series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series_1.LabelFormat = "##,#";
            series_1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series_1.BorderWidth = 3;
            // series_1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            this.chart2_Defect.Series.Add(series_1);
            chart2_Defect.ChartAreas[0].AxisY.IsStartedFromZero = false;

            chart2_Defect.Titles["Title1"].Text = "  روند عیوب ضایعات  به کل تولید";
            series_1.CustomProperties = "IsXAxisQuantitative=True, DrawingStyle=LightToDark, LabelStyle=Top";
            series_1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series_1.MarkerStep = 31;
            series_1.MarkerSize = 10;
            series_1.MarkerColor = Color.Orange;

            /////////

            chart2_Defect.DataSource = dt_defect;
            chart2_Defect.Series["Series1"].XValueMember = XValue;
            chart2_Defect.Series["Series1"].YValueMembers = YValue;
            chart2_Defect.ChartAreas[0].AxisX.IsMarksNextToAxis = false;
            this.chart2_Defect.ChartAreas[0].AxisX.Interval = 1;



        }

        private void ShowDataSandChart(int x_)
        {
            BLL.PearsonCorrelation.csPearsonCorrelation cs = new BLL.PearsonCorrelation.csPearsonCorrelation();
            dt_sand = cs.SlPearsonCorrelationSandForChart(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, 1, (int)num_day.Value);
            GenChartFlowSand( "DayOfYearShamsi", "xMoisturePercent");
            

        }
        private void ShowDataDefectChart(int x_)
        {
            BLL.PearsonCorrelation.csPearsonCorrelation cs = new BLL.PearsonCorrelation.csPearsonCorrelation();
            dt_defect = cs.SlPearsonCorrelationDefectForChart(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, 1, (int)num_day.Value);
            GenChartFlowDefect("DayOfYearShamsi", "xDefectNumber");
        }
        private void ShowDataDefect()
        {
            BLL.csDefect cs = new BLL.csDefect();
            dt_D = cs.SelectDefectList();
            dataGridView1.DataSource = dt_D;

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ShowData((int)dataGridView1["x_", e.RowIndex].Value);
                ShowDataSandChart((int)dataGridView1["x_", e.RowIndex].Value);
                ShowDataDefectChart((int)dataGridView1["x_", e.RowIndex].Value);

            }
        }
    }
}
