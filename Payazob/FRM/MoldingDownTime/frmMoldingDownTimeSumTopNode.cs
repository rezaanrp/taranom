using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.MoldingDownTime
{
    public partial class frmMoldingDownTimeSumTopNode : Form
    {
        public frmMoldingDownTimeSumTopNode(CS.csEnum.Factory FCT)
        {
            InitializeComponent();
            fct_ = FCT;
        //    frmMoldingDownTimeTtTiGr_Report f = new frmMoldingDownTimeTtTiGr_Report(FCT);
           // f.Show();
        }
        CS.csEnum.Factory fct_;
        DataTable dt_D = new DataTable();
        void generate()
        {
            dataGridView1.Columns["DownTime"].HeaderText = "مدت توقف";
            dataGridView1.Columns["NameDownTime"].HeaderText = "نوع توقف";
            dataGridView1.Columns["Child_id"].Visible = false;
            dataGridView1.Columns["Parent_id"].Visible = false;
          //  dataGridView1.Columns["TotalMoldingDownTime"].HeaderText = "درصد توقف";
            dataGridView1.Columns["xAvailableTime"].HeaderText = "زمان درد دسترس";
            dataGridView1.Columns["PercetDownTime"].HeaderText = "درصد توقف به زمان در دسترس";
            
                
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

        void ShowData()
        {
            frmMoldingDownTimeType frm = new frmMoldingDownTimeType(false, CS.csEnum.TypeTree.DownTimeType,fct_);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
            dt_D = cs.SlMoldingDownTimeSumTopNode(frm.Node_x_ < 0 ?-1:frm.Node_x_,  uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo,(int)fct_);
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            generate();
            GenChart("NameDownTime", "DownTime");
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
