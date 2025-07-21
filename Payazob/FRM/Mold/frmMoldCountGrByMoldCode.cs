using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.Mold
{
    public partial class frmMoldCountGrByMoldCode : Form
    {
        public frmMoldCountGrByMoldCode()
        {
            InitializeComponent();
        }
        DataTable dt_De = new DataTable("Procurment");
        private void generateForm()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_De.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["xPieces_"].Width = 200;
            dataGridView1.Columns["xDeny"].Width = 30;
            dataGridView1.Columns["xAccept"].Width = 30;
            dataGridView1.Columns["xCount"].Width = 60;
        }
        private void Btn_Show_Click(object sender, EventArgs e)
        {
         
            dt_De.Clear();
            dt_De = new BLL.Mold.csMold().SlMoldCountGrByMoldCode(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;
            generateForm();

            GenChart("xPieces_", "TolalMoldCount", "xPieces_", "LastConfirmMoldCount");
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }
        void GenChart(string XValue1, string YValue1, string XValue2, string YValue2)
        {

            chart1.DataSource = dt_De;
            chart1.Series["Series1"].XValueMember = XValue1;
            chart1.Series["Series1"].YValueMembers = YValue1;
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart1.Series["Series2"].XValueMember = XValue2;
            chart1.Series["Series2"].YValueMembers = YValue2;
            chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
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
