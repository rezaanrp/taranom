using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Payazob.FRM.KPI
{
    public partial class frmKPIStockPieces : Form
    {
        public frmKPIStockPieces()
        {   
            InitializeComponent();
            chart2.MouseWheel += new MouseEventHandler(Chart2_MouseWheel);
            RectangleAnnotation TA3 = new RectangleAnnotation();
            TA3.Text = "";
            TA3.Name = "Pweight";
            TA3.AnchorX = 50;  // 50% of chart width
            TA3.AnchorY = 20;  // 20% of chart height, from top!
            TA3.Alignment = ContentAlignment.BottomCenter;  // try a few!

            chart2.Annotations.Add(TA3);

        }

        private void Chart2_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0)
                {
                    chart2.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    chart2.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                }

                if (e.Delta > 0)
                {
                    double xMin = chart2.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = chart2.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = chart2.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = chart2.ChartAreas[0].AxisY.ScaleView.ViewMaximum;

                    double posXStart = chart2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    double posXFinish = chart2.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    double posYStart = chart2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    double posYFinish = chart2.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    chart2.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    chart2.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        DataTable dt_De = new DataTable("Procurment");

        private void generateForm()
        {
            dataGridView1.Columns["xPieces"].HeaderText = "نام محصول";
            dataGridView1.Columns["Stock"].HeaderText = "تعداد موجودی انبار";
            dataGridView1.Columns["Pieceweight"].HeaderText = "وزن موجودی";
            dataGridView1.Columns["Pieceweight"].DefaultCellStyle.Format = "N1";
            dataGridView1.Columns["DayANDWeight"].DefaultCellStyle.Format = "N1";
            dataGridView1.Columns["DayANDWeight"].HeaderText = "حاصلضرب وزن در روز";


            dataGridView1.Columns["WellDate"].HeaderText = "میانگین تعداد روز موجود در انبار ";



        }
        private void generateFormINV()
        {
            dataGridView1.Columns["xPieces"].HeaderText = "نام محصول";
            dataGridView1.Columns["Stock"].HeaderText = "تعداد موجودی ";
            dataGridView1.Columns["Pieceweight"].HeaderText = "وزن موجودی";
            dataGridView1.Columns["DayANDWeight"].HeaderText = "حاصلضرب وزن در روز";
            dataGridView1.Columns["Pieceweight"].DefaultCellStyle.Format = "N1";
            dataGridView1.Columns["DayANDWeight"].DefaultCellStyle.Format = "N1";


            dataGridView1.Columns["WellDate"].HeaderText = "میانگین تعداد روز موجود در انبار ";



        }
        void ShowDataKPIWareHousePieces()
        {
            BLL.KPI.csKPI cs = new BLL.KPI.csKPI();
            dt_De.Clear();
            dt_De = cs.SlKPIWareHousePieces(Payazob.Properties.Settings.Default.WorkYear);
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;
        }
        void ShowDataKPIInventoryPieces()
        {
            BLL.KPI.csKPI cs = new BLL.KPI.csKPI();
            dt_De.Clear();
            dt_De = cs.SlKPIInventoryPieces(Payazob.Properties.Settings.Default.WorkYear);
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;
        }
        void ShowDataKPIStockPiecesFlow()
        {
            BLL.KPI.csKPI cs = new BLL.KPI.csKPI();
            dt_De.Clear();
            dt_De = cs.SlKPIStockPiecesFlow(Payazob.Properties.Settings.Default.WorkYear);
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;
        }
        void ShowDataKPIWareHousePiecesMachining()
        {
            BLL.KPI.csKPI cs = new BLL.KPI.csKPI();
            dt_De.Clear();
            dt_De = cs.SlKPIWareHousePiecesMachining(Payazob.Properties.Settings.Default.WorkYear);
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;
        }
        void ShowDataKPIStockPiecesFlowMachinig()
        {
            BLL.KPI.csKPI cs = new BLL.KPI.csKPI();
            dt_De.Clear();
            dt_De = cs.SlKPIStockPiecesFlowMachinig(Payazob.Properties.Settings.Default.WorkYear);
            bindingSource1.DataSource = dt_De;
            dataGridView1.DataSource = bindingSource1;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDataKPIWareHousePieces();
             GenChart("xPieces", "DayANDWeight");
            generateForm();
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

            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));


            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
           // chart2.ChartAreas["ChartArea1"].AxisY.IsLabelAutoFit = false;
        //    chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.Angle = 90;
            int tmpcount = chart2.Series.Count;

            for (int i = 0; i < tmpcount; i++)
            {
                chart2.Series.RemoveAt(0);
            }
            /////////
            System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            chart2.DataSource = dt_De;


            series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series_1.BackSecondaryColor = System.Drawing.Color.LawnGreen;
            series_1.BorderColor = System.Drawing.Color.White;
            series_1.ChartArea = "ChartArea1";
            series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series_1.IsValueShownAsLabel = true;
            series_1.IsVisibleInLegend = false;
            series_1.IsXValueIndexed = true;
            series_1.LabelToolTip = "WareHouse : X=#VALX, Y=#VALY";
            series_1.ShadowOffset = 2;
            series_1.ToolTip = "WareHouse : X=#VALX, Y=#VALY";
            series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            //  series_1.LabelFormat = "##,#";
            this.chart2.Series.Add(series_1);
            chart2.ChartAreas[0].AxisY.IsStartedFromZero = true;
            series_1.SmartLabelStyle.MovingDirection = System.Windows.Forms.DataVisualization.Charting.LabelAlignmentStyles.Top;

            chart2.Titles["Title1"].Text = "میانگین تعداد روز موجودی   ";


            /////////

            chart2.DataSource = dt_De;
            chart2.Series["Series1"].XValueMember = XValue;
            chart2.Series["Series1"].YValueMembers = YValue;
            chart2.ChartAreas[0].AxisX.IsMarksNextToAxis = false;
            this.chart2.ChartAreas[0].AxisX.Interval = 1;
            double SUM_INV = 0;
            int SUM_Inx = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[YValue].Value != DBNull.Value)
                {
                    SUM_INV += (double)item.Cells[YValue].Value;
                    SUM_Inx++;
                }
            }
            ((Border3DAnnotation)chart2.Annotations["B3DAN_AVG"]).Text =Math.Round( (SUM_INV/ SUM_Inx),1).ToString("N0", new System.Globalization.NumberFormatInfo()
            {
                NumberGroupSizes = new[] { 3 },
                NumberGroupSeparator = ","
            }) + " میانگین ";
            ((Border3DAnnotation)chart2.Annotations["B3DAN_AVG"]).Visible = true;
        }

        void GenChartFlow(string XValue, string YValue)
        {

            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));

            chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart2.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            int tmpcount = chart2.Series.Count;

            for (int i = 0; i < tmpcount; i++)
            {
                chart2.Series.RemoveAt(0);
            }
            /////////
            System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            chart2.DataSource = dt_De;

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
            series_1.YValueType= ChartValueType.Int32;
            series_1.BorderWidth = 3;
            // series_1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            this.chart2.Series.Add(series_1);
            chart2.ChartAreas[0].AxisY.IsStartedFromZero = true;

            chart2.Titles["Title1"].Text = "روند میزان کیلوگرم موجودی انبار سایت ریخته گری  ";
            series_1.CustomProperties = "IsXAxisQuantitative=True, DrawingStyle=LightToDark, LabelStyle=Top";
            series_1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series_1.MarkerStep = 31;
            series_1.MarkerSize = 10;
            series_1.MarkerColor = Color.Orange;

            /////////

            chart2.DataSource = dt_De;
            chart2.Series["Series1"].XValueMember = XValue;
            chart2.Series["Series1"].YValueMembers = YValue;
            chart2.ChartAreas[0].AxisX.IsMarksNextToAxis = false;
            this.chart2.ChartAreas[0].AxisX.Interval = 1;


            double SUM_INV = 0;
            int SUM_Inx = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells[YValue].Value != DBNull.Value)
                {
                    double te = 0;
                    double.TryParse(item.Cells[YValue].Value.ToString(), out te);
                    SUM_INV += te ;
                    SUM_Inx++;
                }
            }
            ((Border3DAnnotation)chart2.Annotations["B3DAN_AVG"]).Text = Math.Round((SUM_INV / SUM_Inx), 1).ToString("N0", new System.Globalization.NumberFormatInfo()
            {
                NumberGroupSizes = new[] { 3 },
                NumberGroupSeparator = ","
            }) + " میانگین ";
            ((Border3DAnnotation)chart2.Annotations["B3DAN_AVG"]).Visible = true;


        }
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;

        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            ShowDataKPIStockPiecesFlow();
            GenChartFlow("xDate", "Stock");
            generateFormFlow();
        }

        private void generateFormFlow()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["Stock"].HeaderText = "کیلوگرم موجودی ";
           dataGridView1.Columns["Stock"].DefaultCellStyle.Format = "N1";
        }

        private void chData_MouseWheel(object sender, MouseEventArgs e)
        {
          
        }

        private void chart2_MouseEnter(object sender, EventArgs e)
        {
            this.chart2.Focus();
        }

        private void chart2_MouseLeave(object sender, EventArgs e)
        {
            this.chart2.Parent.Focus();
        }

        private void chart2_MouseDown(object sender, MouseEventArgs e)
        {

          //  Call Hit Test Method
            HitTestResult result = chart2.HitTest(e.X, e.Y);


            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var selectedValue1 = Math.Round( chart2.Series[0].Points[result.PointIndex].YValues[0],0);

                ((RectangleAnnotation)chart2.Annotations["Pweight"]).Text = chart2.Series[0].Points[result.PointIndex].AxisLabel.ToString() +  "\n\n " + selectedValue1.ToString("N0", new System.Globalization.NumberFormatInfo()
                {
                    NumberGroupSizes = new[] { 3 },
                    NumberGroupSeparator = ","
                });

            }
        }

        private void chart2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void glassButton2_Click(object sender, EventArgs e)
        {
            ShowDataKPIWareHousePiecesMachining();
            GenChart("xPieces", "DayANDWeight");
            generateForm();
        }

        private void glassButton3_Click(object sender, EventArgs e)
        {
            ShowDataKPIStockPiecesFlowMachinig();
            GenChartFlow("xDate", "Stock");
            generateFormFlow();
        }

        private void glassButton4_Click(object sender, EventArgs e)
        {
            ShowDataKPIInventoryPieces();
            GenChart("xPieces", "DayANDWeight");
            generateFormINV();
        }
    }
}
