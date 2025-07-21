using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmProductInspectionDefect_Report : Form
    {
        public frmProductInspectionDefect_Report()
        {
            InitializeComponent();
            generateForm();
        }
        DataTable dt_De = new DataTable("Procurment");

        private void generateForm()
        {
            BLL.csDefect pr = new BLL.csDefect();

            dt_De.Columns.Add("Piece", typeof(string));
            dt_De.Columns.Add("DefectNumber", typeof(int));
            dt_De.Columns.Add("DefectNumberweight", typeof(double));
            dt_De.Columns.Add("ControlledNumber", typeof(int));
            dt_De.Columns.Add("ControlledNumberweight", typeof(double));
            dt_De.Columns.Add("PieceProductCount", typeof(int));
            dt_De.Columns.Add("CountProductWeight", typeof(double));
            dt_De.Columns.Add("Inventory", typeof(int));
            
            
            dt_De.Columns.Add("CountPieces", typeof(int));

            dt_De.Columns.Add("DefectPrecent", typeof(decimal));
            
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;
            
            dataGridView1.Columns["DefectNumber"].HeaderText = "تعداد ضایعات";
            dataGridView1.Columns["DefectNumberweight"].HeaderText = "وزن ضایعات";
            dataGridView1.Columns["ControlledNumber"].HeaderText = "تعداد کنترل شده";
            dataGridView1.Columns["ControlledNumberweight"].HeaderText = "وزن قطعات کنترل شده";
            dataGridView1.Columns["DefectPrecent"].HeaderText = "در صد ضایعات";
            dataGridView1.Columns["Piece"].HeaderText = "نوع قطعه";
            dataGridView1.Columns["Piece"].Width = 220;
            dataGridView1.Columns["Inventory"].HeaderText = "در گردش ";

            dataGridView1.Columns["CountPieces"].HeaderText = "تعداد تولید";
            dataGridView1.Columns["PieceProductCount"].Visible = false;
            dataGridView1.Columns["CountProductWeight"].Visible = false;


            dataGridView1.Columns["CountProductWeight"].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns["DefectPrecent"].DefaultCellStyle.Format = "N2";

            dataGridView1.Columns["DefectNumber"].Width = 70;
            dataGridView1.Columns["DefectNumberweight"].Width = 70;
            dataGridView1.Columns["ControlledNumber"].Width = 70;
            dataGridView1.Columns["ControlledNumberweight"].Width = 70;
            dataGridView1.Columns["DefectPrecent"].Width = 70;
            dataGridView1.Columns["Inventory"].Width = 70;


           // dataGridView1.Columns["x_"].Visible = false;
           // dataGridView1.Columns["DefectPrecent"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csDefect cs = new BLL.csDefect();
            dt_De.Clear();
            dt_De = cs.SelectDefectByDateGroupPieces(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;
            int SumDefectNumber = 0;
            float SumDefectNumberweight = 0;
            int SumControlledNumber = 0;
            float SumControlledNumberweight = 0;
            foreach (DataRow item in dt_De.Rows)
            {
                SumDefectNumber += (int)item["DefectNumber"];
                SumDefectNumberweight += item["DefectNumberweight"] == DBNull.Value ? 0 : (float)item["DefectNumberweight"];

                SumControlledNumber += (int)item["ControlledNumber"];
                SumControlledNumberweight += item["CountProductWeight"] == DBNull.Value ? 0 : (float)item["CountProductWeight"];

            }
            lbl_ControlledNumbersWeight.Text = " کنترل شده کیلوگرم: " + SumControlledNumberweight.ToString();

            lbl_DefectWeight.Text = "ضایعات کیلوگرم: " + SumDefectNumberweight.ToString();

            double temp = ( (double)SumDefectNumber / (double)SumControlledNumber ) * 100;
            temp = ((double)SumDefectNumberweight / (double)SumControlledNumberweight) * 100;

            lbl_DefectWeightPercent.Text = " درصد ضایعات کیلوگرم: " + (System.Math.Round(temp, 2)).ToString();
            //درصد ضایعات عددی:
            //درصد ضایعات کیلوگرم:
            GenChart("Piece", "DefectNumberweight");
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {


            BLL.csDefect cs = new BLL.csDefect();
            Report.SendReport crs = new Report.SendReport();
            crs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            crs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            crs.SetParam("DateNow", uc_Filter_Date1.DateTo);

            crs.SetParam("lbl_controledNumbers", "");
            crs.SetParam("lbl_ControlledNumbersWeight", lbl_ControlledNumbersWeight.Text);
            crs.SetParam("lbl_DefectNumber", "");
            crs.SetParam("lbl_DefectWeight", lbl_DefectWeight.Text);
            crs.SetParam("lbl_DefectWeightPercent", lbl_DefectWeightPercent.Text);
            crs.SetParam("lbl_DefectNumbersPercent", "");
            frmReport r = new frmReport();
            r.GetReport = crs.GetReport(cs.SelectDefectByDateGroupPieces(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo), "crsProductInspectionGroupByDate");
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
