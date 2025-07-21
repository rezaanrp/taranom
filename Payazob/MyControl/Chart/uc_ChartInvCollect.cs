using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace Payazob.MyControl.Chart
{
    public partial class uc_ChartInvCollect : UserControl
    {

        Color bk_chart = Color.GhostWhite;
        public uc_ChartInvCollect()
        {
            InitializeComponent();

            Thread thread_SlInventoryForManager = new Thread(new ThreadStart(SlInventoryForManager));
            thread_SlInventoryForManager.Start();

            Thread thread_SlStockPiecesGrp = new Thread(new ThreadStart(SlStockPiecesGrp));
            thread_SlStockPiecesGrp.Start();

            Thread thread_SlInventoryScrab = new Thread(new ThreadStart(SlInventoryScrab));
            thread_SlInventoryScrab.Start();

            Thread thread_SlInventoryAllMaterial = new Thread(new ThreadStart(SlInventoryAllMaterial));
            thread_SlInventoryAllMaterial.Start();

            ChartGenerate_5();
            ChartGenerate_BL();
            ChartGenerate_BR();
            ChartGenerate_TR();
        }

        int chart5_switch = 3;
        int chart_BL_switch = 3;
        int chart_BR_switch = 3;
        int chart_TR_switch = 3;
        DataTable dt_SlInventoryForManager;
        DataTable dt_SlStockPiecesGrp;
        DataTable dt_SlInventoryScrab;
        DataTable dt_SlInventoryAllMaterial;

        bool flg_SlInventoryForManager =false;
        bool flg_SlStockPiecesGrp = false;
        bool flg_SlInventoryScrab = false;
        bool flg_SlInventoryAllMaterial = false;

        void SlInventoryForManager()
        {
            BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();
           dt_SlInventoryForManager = cs.SlInventoryForManager(TARANOM.Properties.Settings.Default.WorkYear);
         //  progressBar_TL.Visible = false;
          // MessageBox.Show("Finish");
           flg_SlInventoryForManager = true;
        }
        void SlStockPiecesGrp()
        {

            BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();
            dt_SlStockPiecesGrp = cs.SlStockPiecesGrp(TARANOM.Properties.Settings.Default.WorkYear);
            // MessageBox.Show("Finish");
            flg_SlStockPiecesGrp = true;
        }
        void SlInventoryScrab()
        {
            BLL.Inventory.csInventoryScrab cs = new BLL.Inventory.csInventoryScrab();
             dt_SlInventoryScrab = cs.SlInventoryScrab(TARANOM.Properties.Settings.Default.WorkYear, "1400/12/30", TARANOM.Properties.Settings.Default.WorkYear);
            // MessageBox.Show("Finish");
             flg_SlInventoryScrab = true;
        }
        void SlInventoryAllMaterial()
        {
            BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();
             dt_SlInventoryAllMaterial = cs.SlInventoryAllMaterial(TARANOM.Properties.Settings.Default.WorkYear);
            // MessageBox.Show("Finish");
             flg_SlInventoryAllMaterial = true;
        }

        void ChartGenerate_5()
        {

            this.chart5.BackColor = bk_chart;
               //System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            chart5.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart5.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
           // chart5.ChartAreas["ChartArea1"].AxisY2.Minimum = 2D;

            #region ch1

            if (chart5_switch == 1)
            {
                int tmpcount = chart5.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart5.Series.RemoveAt(0);
                }
                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                System.Windows.Forms.DataVisualization.Charting.Series series_2 = new System.Windows.Forms.DataVisualization.Charting.Series();
                System.Windows.Forms.DataVisualization.Charting.Series series_3 = new System.Windows.Forms.DataVisualization.Charting.Series();


                series_1.BorderColor = System.Drawing.Color.White;
                series_1.ChartArea = "ChartArea1";
                series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                series_1.IsValueShownAsLabel = true;
                // series_1.IsVisibleInLegend = false;
                series_1.LegendText = "مجموع تولید در ماه";
                series_1.IsXValueIndexed = true;
                series_1.LabelToolTip = "#VAL";
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_1.LabelFormat = "##,#";

                series_2.BorderColor = System.Drawing.Color.White;
                series_2.ChartArea = "ChartArea1";
                // series_2.IsVisibleInLegend = false;
                series_2.LegendText = "داکتیل";
                series_2.IsXValueIndexed = true;
                series_2.LabelToolTip = "#VAL";
                series_2.ToolTip = "#VAL";
                series_2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;


                series_3.BorderColor = System.Drawing.Color.White;
                series_3.ChartArea = "ChartArea1";
                //  series_3.IsVisibleInLegend = false;
                series_3.LegendText = "خاکسنری";
                series_3.IsXValueIndexed = true;
                series_3.LabelToolTip = "#VAL";
                series_3.ToolTip = "#VAL";
                series_3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();


                DataTable dt = cs.SlPruductPiecesByMonth(TARANOM.Properties.Settings.Default.WorkYear);
                progressBar_TL.Visible = false;

                chart5.DataSource = dt;

                series_1.XValueMember = "NameMonthProduct";
                series_1.YValueMembers = "PiecesWeightTotal";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                series_2.XValueMember = "NameMonthProduct";
                series_2.YValueMembers = "PiecesWeightD";
                series_2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                series_3.XValueMember = "NameMonthProduct";
                series_3.YValueMembers = "PiecesWeightk";
                series_3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart5.ChartAreas[0].AxisY.IsStartedFromZero = true;

                this.chart5.Series.Add(series_1);
                this.chart5.Series.Add(series_2);
                this.chart5.Series.Add(series_3);
                chart5_switch = 2;
                splitContainer5.Panel2Collapsed = true;

                chart5.Titles["Title1"].Text = "تناژ تولید محصول نا خالص- تن";
                chart5.Legends[0].Enabled = false;

            }
            #endregion

            #region ch2
            
          
            else if (chart5_switch == 2)
            {
                int tmpcount = chart5.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart5.Series.RemoveAt(0);
                }
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                BLL.GenGroup.csGenGroup csss = new BLL.GenGroup.csGenGroup();
                DataTable dt_Id = csss.mGenGroup("MNGCHART");
                DataRow[] drr = dt_Id.Select("x_ = 141");
                int tree_id = -1;
                int.TryParse(drr[0][3].ToString(),out tree_id);
                DataTable dt = cs.SlMoldingDownTimeSumNodeByMonth(TARANOM.Properties.Settings.Default.WorkYear, tree_id,(int)CS.csEnum.Factory.Site1);
                progressBar_TL.Visible = false;

                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

                chart5.DataSource = dt;

                series_1.XValueMember = "MonthProduct";
                series_1.YValueMembers = "xDuration";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
           
                series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
                series_1.BackSecondaryColor = System.Drawing.Color.LawnGreen;
                series_1.BorderColor = System.Drawing.Color.White;
                series_1.BorderWidth = 3;
                series_1.ChartArea = "ChartArea1";
                series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_1.IsValueShownAsLabel = true;
                series_1.IsVisibleInLegend = false;
                series_1.IsXValueIndexed = false;
                series_1.LabelToolTip = "#VAL";
                series_1.ShadowOffset = 0;
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                series_1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_1.LabelFormat = "##,#";
                chart5.ChartAreas[0].AxisY.IsStartedFromZero = true;

                //  series_1.LabelFormat = "##,#";
                this.chart5.Series.Add(series_1);
                chart5_switch = 3;


                splitContainer5.Panel2Collapsed = true;
                
                string ti =  dt.Rows.Count > 0 ? dt.Rows[0]["DownTimeType"].ToString() : "توقفات";
                if (tree_id < 0)
                    ti = "توقفات کل";
                chart5.Titles["Title1"].Text = ti;
            }
            #endregion

            #region ch3
            else if (chart5_switch == 3)
            {
                int tmpcount = chart5.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart5.Series.RemoveAt(0);
                }

                BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();
                //DataTable dt = cs.SlInventoryForManager(TARANOM.Properties.Settings.Default.WorkYear);
                DataTable dt;
                if (dt_SlInventoryForManager == null)
                {
                    dt = new DAL.ManagerReport.DataSet_ManagerReport.SlInventoryForManagerDataTable();
                    progressBar_TL.Visible = true;
                }
                else
                {
                    dt = dt_SlInventoryForManager;
                    progressBar_TL.Visible = false;

                }
                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

                chart5.DataSource = dt;

                series_1.XValueMember = "PiecesName";
                series_1.YValueMembers = "PieceweightTotal";
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
                series_1.LabelToolTip = "#VAL";
                series_1.ShadowOffset = 2;
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_1.LabelFormat = "##,#";

                //  series_1.LabelFormat = "##,#";
                this.chart5.Series.Add(series_1);
                chart5_switch = 1;
                chart5.ChartAreas[0].AxisY.IsStartedFromZero = true;

                dataGridView1.DataSource = dt;

                CS.csDic css = new CS.csDic();

                foreach (DataColumn dc in dt.Columns)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
                dataGridView1.Columns["StandardINV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["PieceweightTotal"].DefaultCellStyle.Format = "##,#";
                splitContainer5.Panel2Collapsed = true;
                chart5.Titles["Title1"].Text = "محصول در گردش/کیلوگرم";
            }
            #endregion
 
            else
            {
                chart5_switch = 1;
            }

        }

        void ChartGenerate_BL()
        {

            this.chart_BL.BackColor = bk_chart;
                //System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            chart_BL.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart_BL.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
           // chart_BL.ChartAreas["ChartArea1"].AxisY2.Minimum = 2D;

            #region ch1
            if (chart_BL_switch == 1)
            {
                int tmpcount = chart_BL.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart_BL.Series.RemoveAt(0);
                }
                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();


                series_1.BorderColor = System.Drawing.Color.White;
                series_1.ChartArea = "ChartArea1";
                series_1.IsValueShownAsLabel = true;
                // series_1.IsVisibleInLegend = false;
                series_1.LegendText = "ذوب تولیدی در ماه";
                series_1.IsXValueIndexed = true;
                series_1.LabelToolTip = "#VAL";
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_1.LabelFormat = "##,#";
                series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
                series_1.BackSecondaryColor = System.Drawing.Color.Yellow;
                series_1.BorderColor = System.Drawing.Color.White;
                series_1.Color = System.Drawing.Color.Orange;
                series_1.ShadowOffset = 2;


                BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();
                DataTable dt = cs.SlMeltWeightByMonth(TARANOM.Properties.Settings.Default.WorkYear);
                progressBar_BL.Visible = false;

                chart_BL.DataSource = dt;

                series_1.XValueMember = "NameMonthProduct";
                series_1.YValueMembers = "MeltWeight";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart_BL.ChartAreas[0].AxisY.IsStartedFromZero = true;

                this.chart_BL.Series.Add(series_1);

                chart_BL_switch = 2;
                splitContainer_BL.Panel2Collapsed = true;

                chart_BL.Titles["Title1"].Text = "تناژ ذوب ریختگری- تن";
                chart_BL.Legends[0].Enabled = false;

            }
            #endregion

            #region ch2
            
            else if (chart_BL_switch == 2)
            {
                int tmpcount = chart_BL.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart_BL.Series.RemoveAt(0);
                }
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                BLL.GenGroup.csGenGroup csss = new BLL.GenGroup.csGenGroup();
                DataTable dt_Id = csss.mGenGroup("MNGCHART");
                DataRow[] drr = dt_Id.Select("x_ = 142");
                int tree_id = -1;
                int.TryParse(drr[0][3].ToString(), out tree_id);
                DataTable dt = cs.SlMoldingDownTimeSumNodeByMonth(TARANOM.Properties.Settings.Default.WorkYear, tree_id,(int)CS.csEnum.Factory.Site1);
                progressBar_BL.Visible = false;

                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

                chart_BL.DataSource = dt;

                series_1.XValueMember = "MonthProduct";
                series_1.YValueMembers = "xDuration";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
                series_1.BackSecondaryColor = System.Drawing.Color.Yellow;
                series_1.BorderColor = System.Drawing.Color.White;
                series_1.Color = System.Drawing.Color.Orange;
               // series_1.ShadowOffset = 2;
               
                series_1.ChartArea = "ChartArea1";
                //  series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_1.IsVisibleInLegend = true;
                series_1.IsXValueIndexed = false;
                series_1.LabelToolTip = "#VAL";
                series_1.ShadowOffset = 0;
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                series_1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Auto;
                chart_BL.ChartAreas[0].AxisY.IsStartedFromZero = true;
                //chart_BL.ChartAreas[0].AxisY;
                series_1.IsValueShownAsLabel = true;

                series_1.BorderWidth = 3;
                // series_1.LabelFormat = "##,#";
                series_1.IsVisibleInLegend = false;

                //  series_1.LabelFormat = "##,#";
                this.chart_BL.Series.Add(series_1);
                chart_BL_switch = 3;

        
                //  dataGridView_Stock.Columns["StandardSTC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //   dataGridView_Stock.Columns["PieceweightTotal"].DefaultCellStyle.Format = "##,#";
                splitContainer5.Panel2Collapsed = true;
               //    chart_BL.Titles["Title1"].Text = "رطوبت ماسه";
                   string ti = dt.Rows.Count > 0 ? dt.Rows[0]["DownTimeType"].ToString() : "توقفات";
                   if (tree_id < 0)
                       ti = "توقفات کل";
                   chart_BL.Titles["Title1"].Text = ti;
                splitContainer_BL.Panel2Collapsed = true;

            }
            #endregion

            #region ch3
            
            else if (chart_BL_switch == 3)
            {
                int tmpcount = chart_BL.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart_BL.Series.RemoveAt(0);
                }
                BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();
               // DataTable dt = cs.SlStockPiecesGrp(TARANOM.Properties.Settings.Default.WorkYear);
                 DataTable dt;
                 if (dt_SlStockPiecesGrp == null)
                 {
                     dt = new DAL.ManagerReport.DataSet_ManagerReport.SlStockPiecesGrpDataTable();
                     progressBar_BL.Visible = true;

                 }
                 else
                 {
                     dt = dt_SlStockPiecesGrp;
                     progressBar_BL.Visible = false;

                 }
                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                

                chart_BL.DataSource = dt;

                series_1.XValueMember = "PiecesName";
                series_1.YValueMembers = "PieceweightTotal";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
                series_1.BackSecondaryColor = System.Drawing.Color.Yellow;
                series_1.BorderColor = System.Drawing.Color.White;
                series_1.Color = System.Drawing.Color.Orange;
                series_1.ShadowOffset = 2;
                series_1.ChartArea = "ChartArea1";
              //  series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_1.IsValueShownAsLabel = true;
                series_1.IsVisibleInLegend = false;
                series_1.IsXValueIndexed = true;
                series_1.LabelToolTip = "#VAL";
                series_1.ShadowOffset = 2;
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_1.LabelFormat = "##,#";

                //  series_1.LabelFormat = "##,#";
                this.chart_BL.Series.Add(series_1);
                chart_BL_switch = 1;
                chart_BL.ChartAreas[0].AxisY.IsStartedFromZero = true;

                dataGridView_Stock.DataSource = dt;

                CS.csDic css = new CS.csDic();

                foreach (DataColumn dc in dt.Columns)
                {
                    dataGridView_Stock.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
                dataGridView_Stock.Columns["StandardSTC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView_Stock.Columns["PieceweightTotal"].DefaultCellStyle.Format = "##,#";
                splitContainer5.Panel2Collapsed = true;
                chart_BL.Titles["Title1"].Text = "انبار محصول/کیلوگرم";
                splitContainer_BL.Panel2Collapsed = true;

            }

            #endregion


            else
            {
                chart_BL_switch = 1;
            }

        }

        void ChartGenerate_BR()
        {

            this.chart_BR.BackColor = bk_chart;
                //System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            chart_BR.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart_BR.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
           // chart_BR.ChartAreas["ChartArea1"].AxisY2.Minimum = 2D;


            #region ch1
            
            if (chart_BR_switch == 1)
            {
                int tmpcount = chart_BR.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart_BR.Series.RemoveAt(0);
                }
                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

              


                series_1.BorderColor = System.Drawing.Color.White;
                series_1.Name = "series_1";
                series_1.Legend = "Legend1";
                series_1.ChartArea = "ChartArea1";
                series_1.IsValueShownAsLabel = true;
                series_1.IsVisibleInLegend = true;
                series_1.LegendText = "تولید";
                series_1.IsXValueIndexed = true;
                series_1.LabelToolTip = "#VAL";
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_1.LabelFormat = "##,#";
                series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
                series_1.BackSecondaryColor = System.Drawing.Color.Black;
                series_1.BorderColor = System.Drawing.Color.White;
                series_1.ShadowOffset = 2;
                

                //series_1. = 2;
                chart_BR.Legends[0].Enabled = true;
                chart_BR.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
                chart_BR.Legends[0].Alignment = StringAlignment.Far;
                chart_BR.Legends[0].TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;



                System.Windows.Forms.DataVisualization.Charting.Series series_2 = new System.Windows.Forms.DataVisualization.Charting.Series();

                series_2.Name = "series_2";
                series_2.Legend = "Legend1";
                series_2.BorderColor = System.Drawing.Color.White;
                series_2.ChartArea = "ChartArea1";
                series_2.IsValueShownAsLabel = true;
                series_2.IsVisibleInLegend = true;
                series_2.LegendText = "برنامه";
                series_2.IsXValueIndexed = true;
                series_2.LabelToolTip = "#VAL";
                series_2.ToolTip = "#AXISLABEL";
                series_2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_2.LabelFormat = "##,#";
                series_2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
                series_2.BackSecondaryColor = System.Drawing.Color.Black;
                series_2.BorderColor = System.Drawing.Color.White;
                series_2.ShadowOffset = 2;


                BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();
                DataTable dt = cs.SlMeltWeightByMonth(TARANOM.Properties.Settings.Default.WorkYear);
                progressBar_BR.Visible = false;

                chart_BR.DataSource = dt;

                series_2.XValueMember = "NameMonthProduct";
                series_2.YValueMembers = "MeltWeightDayP";
                series_2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                //chart_BR.ChartAreas[0].AxisY.IsStartedFromZero = true;


                series_1.XValueMember = "NameMonthProduct";
                series_1.YValueMembers = "MeltWeightDay";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart_BR.ChartAreas[0].AxisY.IsStartedFromZero = true;
                
                this.chart_BR.Series.Add(series_1);
                this.chart_BR.Series.Add(series_2);

                chart_BR_switch = 2;
                splitContainer_BR.Panel2Collapsed = true;

                chart_BR.Titles["Title1"].Text = "میانگین ذوب ریختگری شده در روز  - تن";
                //chart_BR.Legends[0].Enabled = false;

            }
            #endregion

            #region ch2
            
            else if (chart_BR_switch == 2)
            {
                int tmpcount = chart_BR.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart_BR.Series.RemoveAt(0);
                }
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                BLL.GenGroup.csGenGroup csss = new BLL.GenGroup.csGenGroup();
                DataTable dt_Id = csss.mGenGroup("MNGCHART");
                DataRow[] drr = dt_Id.Select("x_ = 143");
                int tree_id = -1;
                int.TryParse(drr[0][3].ToString(), out tree_id);
                DataTable dt = cs.SlMoldingDownTimeSumNodeByMonth(TARANOM.Properties.Settings.Default.WorkYear, tree_id,(int)CS.csEnum.Factory.Site1);
                progressBar_BR.Visible = false;

                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

                chart_BR.DataSource = dt;

                series_1.XValueMember = "MonthProduct";
                series_1.YValueMembers = "xDuration";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                series_1.BorderColor = System.Drawing.Color.White;
                series_1.ChartArea = "ChartArea1";
                //series_1.IsValueShownAsLabel = true;
                // series_1.IsVisibleInLegend = false;
              // series_1.LegendText = "استحکام فشاری";
                series_1.IsXValueIndexed = true;
                series_1.IsValueShownAsLabel = true;
                series_1.LabelToolTip = "#VAL";
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_1.LabelFormat = "##,#";
                series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
                series_1.BackSecondaryColor = System.Drawing.Color.Black;
                series_1.BorderColor = System.Drawing.Color.White;
                series_1.BorderWidth = 3;
                chart_BR.ChartAreas[0].AxisY.IsStartedFromZero =true;
                series_1.IsValueShownAsLabel = true;

                this.chart_BR.Series.Add(series_1);

                chart_BR_switch = 3;
                splitContainer_BR.Panel2Collapsed = true;

                //chart_BR.Titles["Title1"].Text = "تراکم پذیری";
                chart_BR.Legends[0].Enabled = false;
                string ti = dt.Rows.Count > 0 ? dt.Rows[0]["DownTimeType"].ToString() : "توقفات";
                if (tree_id < 0)
                    ti = "توقفات کل";
                chart_BR.Titles["Title1"].Text = ti;
            }
            #endregion
            #region ch3
            
            else if (chart_BR_switch == 3)
            {
                int tmpcount = chart_BR.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart_BR.Series.RemoveAt(0);
                }
                //BLL.Inventory.csInventoryScrab cs = new BLL.Inventory.csInventoryScrab();
               // DataTable dt = cs.SlInventoryScrab(TARANOM.Properties.Settings.Default.WorkYear, "1400/12/30", TARANOM.Properties.Settings.Default.WorkYear);
                DataTable dt;
                if (dt_SlInventoryScrab == null)
                {
                    dt = new DAL.inventory.DataSet_InventoryScrab.SlInventoryScrabDataTable();
                    progressBar_BR.Visible = true;
                }
                else
                {
                    dt = dt_SlInventoryScrab;
                    progressBar_BR.Visible = false;

                }
                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();
                

                chart_BR.DataSource = dt;

                series_1.XValueMember = "xMaterialName";
                series_1.YValueMembers = "inventoryScrab";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
                series_1.BackSecondaryColor = System.Drawing.Color.Magenta;
                series_1.BorderColor = System.Drawing.Color.White;
                series_1.ShadowOffset = 2;
                series_1.ChartArea = "ChartArea1";
                //  series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
                series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_1.IsValueShownAsLabel = true;
                series_1.IsVisibleInLegend = false;
                series_1.IsXValueIndexed = true;
                series_1.LabelToolTip = "#VAL";
                series_1.ShadowOffset = 2;
                series_1.ToolTip = "#AXISLABEL";
                series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                series_1.LabelFormat = "##,#";
                chart_BR.ChartAreas[0].AxisY.IsStartedFromZero = true;

                //  series_1.LabelFormat = "##,#";
                this.chart_BR.Series.Add(series_1);
                chart_BR_switch = 1;

                CS.csDic css = new CS.csDic();

                dataGridView_Scarb.DataSource = dt;

                foreach (DataColumn dc in dt.Columns)
                {
                    dataGridView_Scarb.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }

                chart_BR.Titles["Title1"].Text = "موجودی قراضه/کیلوگرم";
                splitContainer_BR.Panel2Collapsed = true;
                //------------------------------------------------
            }
            #endregion

            else
            {
                chart_BR_switch = 1;
            }

        }

        void ChartGenerate_TR()
        {
            this.chart_T_R.BackColor = bk_chart;
            this.chart2.BackColor = bk_chart;

            chart_T_R.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart_T_R.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            //System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            #region ch1
            if (chart_TR_switch == 1)
            {
                splitContainer_TR.Visible = false;
                chart_T_R.ChartAreas[0].AxisY.IsStartedFromZero = true;
                progressBar_TR.Visible = false;

                chart_TR_switch = 2;

            }
            #endregion
            #region ch2
            
            else if (chart_TR_switch == 2)
            {
           
               // chart_T_R.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
                //chart_T_R.ChartAreas["ChartArea1"].AxisY2.Minimum = 2D;

                splitContainer_TR.Visible = true;

                int tmpcount = chart_T_R.Series.Count;
                for (int i = 0; i < tmpcount; i++)
                {
                    chart_T_R.Series.RemoveAt(0);
                }
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                BLL.GenGroup.csGenGroup csss = new BLL.GenGroup.csGenGroup();
                DataTable dt_Id = csss.mGenGroup("MNGCHART");
                DataRow[] drr = dt_Id.Select("x_ = 144");
                int tree_id = -1;
                int.TryParse(drr[0][3].ToString(), out tree_id);
                DataTable dt = cs.SlMoldingDownTimeSumNodeByMonth(TARANOM.Properties.Settings.Default.WorkYear, tree_id,(int)CS.csEnum.Factory.Site1);
                progressBar_TR.Visible = false;

                System.Windows.Forms.DataVisualization.Charting.Series series_1 = new System.Windows.Forms.DataVisualization.Charting.Series();

                chart_T_R.DataSource = dt;

                series_1.XValueMember = "MonthProduct";
                series_1.YValueMembers = "xDuration";
                series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                series_1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
                series_1.BackSecondaryColor = System.Drawing.Color.Red;
                series_1.BorderColor = System.Drawing.Color.White;
                series_1.BorderWidth = 3;
                series_1.ChartArea = "ChartArea1";
                series_1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
                series_1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                series_1.IsValueShownAsLabel = true;
                series_1.IsVisibleInLegend = false;
                series_1.ShadowOffset = 0;
                //series_1.ToolTip = "#AXISLABEL";
                //series_1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                //series_1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            // series_1.LabelFormat = "##,#";
               chart_T_R.ChartAreas[0].AxisY.IsStartedFromZero = true;
               // chart_T_R.AlignDataPointsByAxisLabel();
                //  series_1.LabelFormat = "##,#";
                this.chart_T_R.Series.Add(series_1);

                splitContainer_TR.Panel2Collapsed = true;
               // chart_T_R.Titles["Title1"].Text = "استحکام فشاری";
                string ti = dt.Rows.Count > 0 ? dt.Rows[0]["DownTimeType"].ToString() : "توقفات";
                if (tree_id < 0)
                    ti = "توقفات کل";
                chart_T_R.Titles["Title1"].Text = ti;
                chart2.Visible = false;
                chart_T_R.Visible = true;
                
                chart_TR_switch = 3;
            }
            #endregion
            #region ch3
            
            else if (chart_TR_switch == 3)
            {
                splitContainer_TR.Visible = true;
                splitContainer_TR.Panel2Collapsed = true;
                chart_T_R.ChartAreas[0].AxisY.IsStartedFromZero = true;

                chart_TR_switch = 1;
                Chart_All();


            }
            #endregion

            else
            {
                chart_TR_switch = 1;
            }

        }

        void Chart_All()
        {

            if (dt_SlInventoryAllMaterial != null)
            {
                //BLL.ManagerReport.csManagerReport cs = new BLL.ManagerReport.csManagerReport();
                 DataTable dt;
                if (dt_SlInventoryAllMaterial == null)
                {
                    dt = new DAL.ManagerReport.DataSet_ManagerReport.SlInventoryAllMaterialDataTable();
                    progressBar_TR.Visible = true;

                }
                else
                {
                  dt  = dt_SlInventoryAllMaterial;
                    progressBar_TR.Visible = false;

                }
                Dictionary<string, decimal> dictionary = new Dictionary<string, decimal>();
                dictionary.Add("گردش قراضه", (int)dt.Rows[0]["InventoryScrab"]);
                uc_txtBox_S.Text = dt.Rows[0]["InventoryScrab"].ToString();

                dictionary.Add("گردش محصول", (int)dt.Rows[0]["InventoryPieces"]);
                uc_txtBox_I.Text = dt.Rows[0]["InventoryPieces"].ToString();

                dictionary.Add("موجودی انبار", (int)dt.Rows[0]["StockPieces"]);
                uc_txtBox_P.Text = dt.Rows[0]["StockPieces"].ToString();

                dictionary.Add("مجموع", (int)dt.Rows[0]["total"]);


                chart2.DataSource = dt;
                chart2.Series["Series1"].Points.DataBindXY(dictionary.Keys, dictionary.Values);
                chart2.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart2.Series["Series1"].LabelFormat = "##,#";

                          chart2.Titles["Title1"].Text = " مجموع موجودی ها / کیلوگرم";

                chart2.Visible = true;
                chart_T_R.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count < 2 && this.ParentForm != null && this.ParentForm.WindowState == FormWindowState.Maximized)
            {

                DAL.csConnectionTest t = new DAL.csConnectionTest();
                if (!t.testConnection())
                {
                    return;
                }

                if (chart_BL_switch == 1)
                {
                    splitContainer_TR.Visible = true;
                    ChartGenerate_TR();
                    ChartGenerate_5();
                    ChartGenerate_BL();
                    ChartGenerate_BR();
                    btn_PrS1.BackColor = Color.FromArgb(192,255,192);
                    btn_StockS1.BackColor = Color.SpringGreen;
                }
                else if (chart_BL_switch == 2)
                {
                    splitContainer_TR.Visible = false;
                    ChartGenerate_TR();
                    ChartGenerate_5();
                    ChartGenerate_BL();
                    ChartGenerate_BR();
                    btn_PrS1.BackColor = Color.SpringGreen;
                    btn_StockS1.BackColor = Color.White;
                }
                else if (chart_BL_switch == 3)
                {
                    splitContainer_TR.Visible = false;
                    ChartGenerate_TR();
                    ChartGenerate_5();
                    ChartGenerate_BL();
                    ChartGenerate_BR();
                    btn_PrS1.BackColor = Color.SpringGreen;
                    btn_StockS1.BackColor = Color.White;
                }
                else
                {


                }

            }
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            DAL.csConnectionTest t = new DAL.csConnectionTest();

            if (!t.testConnection())
            {
                return;
            }
            chart5_switch = 3;
            chart_BL_switch = 3;
            chart_BR_switch = 3;
            chart_TR_switch = 3;
            splitContainer_TR.Visible = true;
            btn_PrS1.BackColor = Color.FromArgb(192, 255, 192);
            btn_StockS1.BackColor = Color.SpringGreen;
            btn_DownS1.BackColor = Color.White;

            ChartGenerate_TR();
           // Chart_Scrab();
            ChartGenerate_5();
            ChartGenerate_BL();
            ChartGenerate_BR();
        }

        private void btn_Pr_Click(object sender, EventArgs e)
        {
            DAL.csConnectionTest t = new DAL.csConnectionTest();

            if (!t.testConnection())
            {
                return;
            }
            chart5_switch = 1;
            chart_BL_switch = 1;
            chart_BR_switch = 1;
            chart_TR_switch = 1;
            splitContainer_TR.Visible = false;

            btn_PrS1.BackColor = Color.SpringGreen;
            btn_StockS1.BackColor = Color.White;
            btn_DownS1.BackColor = Color.White;

            ChartGenerate_TR();
            //Chart_Scrab();
            ChartGenerate_5();
            ChartGenerate_BL();
            ChartGenerate_BR();
        }

        private void btn_Sand_Click(object sender, EventArgs e)
        {
            DAL.csConnectionTest t = new DAL.csConnectionTest();

            if (!t.testConnection())
            {
                return;
            }
            chart5_switch =2;
            chart_BL_switch = 2;
            chart_BR_switch = 2;
            chart_TR_switch = 2;
            splitContainer_TR.Visible = false;

            btn_PrS1.BackColor = Color.White;
            btn_StockS1.BackColor = Color.White;
            btn_DownS1.BackColor = Color.SpringGreen;
            ChartGenerate_TR();
            //Chart_Scrab();
            ChartGenerate_5();
            ChartGenerate_BL();
            ChartGenerate_BR();
        }

        private void timer_dtCheck_Tick(object sender, EventArgs e)
        {
            if (chart_BL_switch == 1)
            {
                if (flg_SlInventoryAllMaterial == true)
                {
                    flg_SlInventoryAllMaterial = false;
                    chart5_switch = 3;
                    ChartGenerate_5();
                }
                if (flg_SlInventoryForManager == true)
                {
                    flg_SlInventoryForManager = false;
                    chart_TR_switch = 3;
                    ChartGenerate_TR();
                }
                if (flg_SlInventoryScrab == true)
                {
                    flg_SlInventoryScrab = false;
                    chart_BR_switch = 3;
                    ChartGenerate_BR();
                }
                if (flg_SlStockPiecesGrp == true)
                {
                    flg_SlStockPiecesGrp = false;
                    chart_BL_switch = 3;
                    ChartGenerate_BL();
                }
            }
        }
    }
}
