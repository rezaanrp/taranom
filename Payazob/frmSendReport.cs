using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Payazob
{
    public partial class frmSendReport : Form
    {
        public frmSendReport()
        {
            InitializeComponent();
            BLL.csSand ty = new BLL.csSand();
            uc_cmbType.DataSource = ty.SandControlParameter();
            uc_cmbType.DisplayMember = "xParameterName";
            uc_cmbType.ValueMember = "xParamNameUn";
            uc_mtxtDateFrom.Text = BLL.csshamsidate.shamsidate;
            uc_mtxtDateTo.Text = BLL.csshamsidate.shamsidate;

        }

        void chart1_DoubleClick(object sender, EventArgs e)
        {

            Form form = new Form();
            Size s = new Size(800, 600);
            form.Size = s;

            BLL.csSand sd = new BLL.csSand();
            DataTable dt = sd.SelectChartData(uc_mtxtDateFrom.Text, uc_mtxtDateTo.Text);

            BLL.csSand ctrlp = new BLL.csSand();
            DataTable ct = ctrlp.ControlParameter(uc_cmbType.SelectedValue.ToString());

            Chart chart1 = new Chart();
            ChartArea chartArea1 = new ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chart1.Legends.Add(legend1);
            chart1.DoubleClick += new EventHandler(chart1_DoubleClick);
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Line;
            series1.LegendText = uc_cmbType.Text;

            foreach (DataRow item in dt.Rows)
            {
                if (item[uc_cmbType.SelectedValue.ToString()] != null && item[uc_cmbType.SelectedValue.ToString()] != DBNull.Value)
                series1.Points.Add(double.Parse(item[uc_cmbType.SelectedValue.ToString()].ToString()));
            }
            chart1.Series.Add(series1);
            Series seriesH = new Series();
            Series seriesL = new Series();
            Series seriesA = new Series();

            seriesH.LegendText = "حد بالا";
            seriesA.LegendText = "حد وسط";
            seriesL.LegendText = "حد پایین";


            seriesH.ChartType = SeriesChartType.Line;
            seriesL.ChartType = SeriesChartType.Line;
            seriesA.ChartType = SeriesChartType.Line;

            series1.BorderWidth = 2;
            seriesH.BorderWidth = 3;
            seriesA.BorderWidth = 3;
            seriesL.BorderWidth = 3;

            seriesH.Color = Color.Red;
            seriesA.Color = Color.Green;
            seriesL.Color = Color.Orange;

            foreach (var item in series1.Points)
            {
                seriesH.Points.Add(double.Parse(ct.Rows[0]["xHigh"].ToString()));
                seriesA.Points.Add(double.Parse(ct.Rows[0]["xAverage"].ToString()));
                seriesL.Points.Add(double.Parse(ct.Rows[0]["xLow"].ToString()));
            }
            chart1.Series.Add(seriesH);
            chart1.Series.Add(seriesA);
            chart1.Series.Add(seriesL);
            chart1.Dock = DockStyle.Fill;

            form.Controls.Add(chart1);
            form.ShowDialog();

        }
 
        private void frmSendReport_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BLL.csSand sd = new BLL.csSand();
            DataTable dt = sd.SelectChartData(uc_mtxtDateFrom.Text,uc_mtxtDateTo.Text);

            BLL.csSand ctrlp = new BLL.csSand();
            DataTable ct = ctrlp.ControlParameter(uc_cmbType.SelectedValue.ToString());


            if (splitContainer2.Panel1.Controls.Count > 0)
            {
                splitContainer2.Panel1.Controls[0].Dispose();
            }
            Chart chart1 = new Chart();
            ChartArea chartArea1 = new ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            chart1.ChartAreas.Add(chartArea1);
            // genchart();
            splitContainer2.Panel1.Controls.Add(chart1);
            chart1.Dock = DockStyle.Fill;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.LabelStyle.Angle = 90;
            chart1.Legends.Add(legend1);
            chart1.DoubleClick += new EventHandler(chart1_DoubleClick);
            Series series1 = new Series();
            series1.ChartType = SeriesChartType.Line;
            series1.LegendText = uc_cmbType.Text;

            foreach (DataRow item in dt.Rows )
            {
                if (item[uc_cmbType.SelectedValue.ToString()] != DBNull.Value)
                series1.Points.Add(double.Parse( item[uc_cmbType.SelectedValue.ToString()].ToString()));
            }
            chart1.Series.Add(series1);
            Series seriesH = new Series();
            Series seriesL = new Series();
            Series seriesA = new Series();
            seriesH.ChartType = SeriesChartType.Line;
            seriesL.ChartType = SeriesChartType.Line;
            seriesA.ChartType = SeriesChartType.Line;

            series1.BorderWidth = 2;
            seriesH.BorderWidth = 3;
            seriesA.BorderWidth = 3;
            seriesL.BorderWidth = 3;

            seriesH.Color = Color.Red;
            seriesA.Color = Color.Green;
            seriesL.Color = Color.Orange;

            seriesH.LegendText = "حد بالا";
            seriesA.LegendText = "حد وسط";
            seriesL.LegendText = "حد پایین";


            foreach (var item in series1.Points)
            {
                seriesH.Points.Add(double.Parse(ct.Rows[0]["xHigh"].ToString()));
                seriesA.Points.Add(double.Parse(ct.Rows[0]["xAverage"].ToString()));
                seriesL.Points.Add(double.Parse(ct.Rows[0]["xLow"].ToString()));                        
            }
            chart1.Series.Add(seriesH);
            chart1.Series.Add(seriesA);
            chart1.Series.Add(seriesL);

        }
    }
}
