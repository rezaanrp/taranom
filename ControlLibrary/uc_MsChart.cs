using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ControlLibrary
{
    public partial class uc_MsChart : UserControl
    {
        public uc_MsChart()
        {
            InitializeComponent();
            chart1.ChartAreas.Add(chartArea1);
           // genchart();
            this.Controls.AddRange(new System.Windows.Forms.Control[] { chart1 });
            chart1.Dock = DockStyle.Fill;
            chartArea1.AxisX.Interval = 1D;

            chartArea1.AxisX.LabelStyle.Angle = 90;
            chart1.Legends.Add(legend1);
            chart1.DoubleClick += new EventHandler(chart1_DoubleClick);
        }

        void chart1_DoubleClick(object sender, EventArgs e)
        {
            #region MyRegion
            //FlowLayoutPanel panel11 = new FlowLayoutPanel();
            //Form form = new Form();
            //Size s = new Size(800, 600);
            //form.Size = s;
            //panel11.Dock = DockStyle.Fill;
            //Chart cha = new Chart();
            //ChartArea chartArea2 = new ChartArea();
            //cha.ChartAreas.Add(chartArea2);

            //System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            //Series series1 = new Series();
            //series1.LegendText = title;

            //foreach (DataPoint item in series1.Points)
            //{
            //    series1.Points.Add(item);
            //}
            //cha.Series.Add(series1);

            //cha.Dock = DockStyle.Fill;

            //chartArea2.AxisX.Interval = 1D;

            //chartArea2.AxisX.LabelStyle.Angle = 90;
            //cha.Legends.Add(legend2);

            //form.StartPosition = FormStartPosition.CenterScreen;
            //form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            ////  panel.Controls.Add(cha);

            ////panel11.Controls.AddRange(new System.Windows.Forms.Control[] { cha });

            //((System.ComponentModel.ISupportInitialize)(cha)).EndInit();

            //panel11.Controls.Add(cha);
            //form.Controls.Add(panel11);

            //form.ShowDialog();
            #endregion

            Form form = new Form();
            Size s = new Size(800, 600);
            form.Size = s;

            Chart ch1 = new Chart();

            ch1.Dock = DockStyle.Fill;

            //if(chart1.Series.Count > 0)
            //se = chart1.Series[0];
            for (int i = 0; i < chart1.Series.Count; i++)
            {
                ch1.Series.Add(chart1.Series[i]);

            }
            for (int i = 0; i < chart1.Series.Count; i++)
            {
                ch1.Series[i].IsValueShownAsLabel = true;

            }

            //foreach (DataPoint item in )
            //{
            //    se.Points.Add(item);
            //}
            ChartArea chrta = new ChartArea();

            chrta = chartArea1;
            ch1.ChartAreas.Add(chrta);
            ch1.Legends.Add(legend1);

            form.Controls.Add(ch1);
            form.ShowDialog();
            for (int i = 0; i < chart1.Series.Count; i++)
            {
                chart1.Series[i].IsValueShownAsLabel = false;

            }

        }

        private Stack<string> stackParamLabel = new Stack<string>();
        private Stack<double> stackParamValue = new Stack<double>();
        Chart chart1 = new Chart();
        ChartArea chartArea1 = new ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();

        public int SeriesIndex = 0;

        public void SetValue(double Value)
        {
            stackParamValue.Push(Value);
        }
        public void SetLabel(string Label)
        {
            stackParamLabel.Push(Label);
        }

        public void Clear()
        {
            foreach (Series item in chart1.Series)
            {
                item.Points.Clear();
              //  item.Dispose();
            }
           
        }
        public string title = "";

        public SeriesChartType seriescharttype = SeriesChartType.Column;
        public void genchart(int SIndex)
        {
            
            Series series1 = new Series();
            series1.LegendText = title;
            series1.ChartType = seriescharttype;
            while (stackParamValue.Count > 0)
            {
                series1.Points.Add(stackParamValue.Pop());
            }

            for (int i = 0; i < series1.Points.Count; i++)
            {
                if (stackParamLabel.Count > 0)
                   series1.Points[i].AxisLabel = stackParamLabel.Pop();                    
            }

            if (chart1.Series.Count >= (SIndex + 1) )
            {
                chart1.Series[SIndex] = series1;

            }
            else
            {
                while (chart1.Series.Count < (SIndex + 1))
                {
                    chart1.Series.Add(series1);
                }
            }

            //if (multiSeries)
            //{
            //    chart1.Series.Add(series1);
            //}
            //else
            //{
            //    if (chart1.Series.Count > 0)
            //    {
            //        chart1.Series[0] = series1;
            //    }
            //    else
            //    {
            //        chart1.Series.Add(series1);
            //    }
            //}
        }

        private bool multiSeries;

        public bool MultiSeries
        {
            get { return multiSeries; }
            set { multiSeries = value; }
        }
        
        private void uc_MsChart_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
