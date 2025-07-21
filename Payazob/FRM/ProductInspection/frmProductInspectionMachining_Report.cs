using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.ProductInspection
{
    public partial class frmProductInspectionMachining_Report : Form
    {
        public frmProductInspectionMachining_Report()
        {
            InitializeComponent();
            generateForm();
        }

        DataTable dt_De = new DataTable("Procurment");

        private void generateForm()
        {
            BLL.csDefect pr = new BLL.csDefect();

            //dt_De.Columns.Add("Piece", typeof(string));
            //dt_De.Columns.Add("DefectNumber", typeof(int));

            //dt_De.Columns.Add("DefectPrecent", typeof(decimal));

            
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;

       
            bindingNavigator1.BindingSource = bindingSource1;
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_De.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
            dataGridView1.Columns["DefectPercent"].Visible = false;
            dataGridView1.Columns["Pieces"].Width = 250;

        }
        void ShowData()
        {
            BLL.QualityControl.csProductInspectionMachining cs = new BLL.QualityControl.csProductInspectionMachining();
            dt_De.Clear();
            dt_De = cs.SlProductInspectionMachiningDefectPrecent(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;


            Generate();

            //int SumDefectNumber = 0;
            //double SumDefectNumberweight = 0;
            //int SumControlledNumber = 0;
            //double SumControlledNumberweight = 0;
            //foreach (DataRow item in dt_De.Rows)
            //{
            //    SumDefectNumber += (int)item["DefectNumber"];
            //    SumDefectNumberweight += item["DefectNumberweight"] == DBNull.Value ? 0 : (double)item["DefectNumberweight"];

            //    SumControlledNumber += (int)item["ControlledNumber"];
            //    SumControlledNumberweight += item["CountProductWeight"] == DBNull.Value ? 0 : (double)item["CountProductWeight"];

            //}
            //lbl_ControlledNumbersWeight.Text = " کنترل شده کیلوگرم: " + SumControlledNumberweight.ToString();

            //lbl_DefectWeight.Text = "ضایعات کیلوگرم: " + SumDefectNumberweight.ToString();

            //double temp = ((double)SumDefectNumber / (double)SumControlledNumber) * 100;
            //temp = ((double)SumDefectNumberweight / (double)SumControlledNumberweight) * 100;

            //lbl_DefectWeightPercent.Text = " درصد ضایعات کیلوگرم: " + (System.Math.Round(temp, 2)).ToString();
            ////درصد ضایعات عددی:
            ////درصد ضایعات کیلوگرم:
            GenChart("Pieces", "DefectPercent");
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowData(); 
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

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
            chart1.DataSource = dt_De;
            chart1.Series["Series1"].XValueMember = XValue;
            chart1.Series["Series1"].YValueMembers = YValue;
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.ChartAreas[0].AxisX.IsMarksNextToAxis = false;
            // Solution 1: Setting axis Interval  
            this.chart1.ChartAreas[0].AxisX.Interval = 1;
            // Solution 2: Enable variable interval  
            this.chart1.ChartAreas[0].AxisX.Interval = double.NaN;
            this.chart1.ChartAreas[0].AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
        }
    }
}
