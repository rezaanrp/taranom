using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Budget
{
    public partial class frmBudgetPlan_SalesPerformance : Form
    {
        public frmBudgetPlan_SalesPerformance(CS.csEnum.Factory FCT, CS.csEnum.GenFactoryGroupPieces PIG)
        {
            InitializeComponent();
            btn_ChangeColor();
            fct_ = (int)FCT;
            pig_ = (int)PIG;
            uc_txtBox1.Text = BLL.csshamsidate.shamsidate.Substring(0, 4);

        }
        int fct_;
        int pig_;
        DAL.BudgetPlan.DataSet_BudgetPlan.SlBudgetPlan_SalesPerformance_RDataTable dt_R;
         DataTable dt_S;

        void btn_ChangeColor()
        {
            btn_01.BackColor = Color.White;
            btn_2.BackColor = Color.White;
            btn_3.BackColor = Color.White;
            btn_4.BackColor = Color.White;
            btn_5.BackColor = Color.White;
            btn_6.BackColor = Color.White;
            btn_7.BackColor = Color.White;
            btn_8.BackColor = Color.White;
            btn_9.BackColor = Color.White;
            btn_10.BackColor = Color.White;
            btn_11.BackColor = Color.White;
            btn_12.BackColor = Color.White;
        }

        void ShowDataGridView(string xYear, string xMonth)
        {

            dt_R = new BLL.BudgetPlan.csBudgetPlan().SlBudgetPlan_SalesPerformance_R(xYear, xMonth, fct_);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;


            dt_S = new BLL.BudgetPlan.csBudgetPlan().SlBudgetPlan_SalesPerformance_BySaleType(xYear, xMonth, fct_);
            dt_S.NewRow();
            dataGridView2.DataSource = dt_S;
            Generate();
            int? SumB = 0;
            int? SumS = 0;

            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
   SumB += (int?)item.Cells["BudgetPlanCountWeight"].Value;
   SumS += (int?)item.Cells["mSalePlanCountWeight"].Value;
            }
            DataRow dr = dt_S.NewRow();
            dr["xSaleType"] = "مجموع ";
            dr["SalePlanSaleType"] = "مجموع ";
            dr["BudgetPlanCountWeight"] = SumB;
            dr["mSalePlanCountWeight"] = SumS;
            dr["BudgetPlanPercent"] = ((int?)(((float?)SumS /(float?)SumB) * 100)).ToString() + "%";
            dt_S.Rows.Add(dr);

            dataGridView2.Rows[dataGridView2.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
          
            
        }

        void Generate()
        {

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_R.Columns)
            {
   if (dataGridView1.Columns[dc.ColumnName] != null)
   {
       dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
   }
            }

            foreach (DataColumn dc in dt_S.Columns)
            {
   if (dataGridView2.Columns[dc.ColumnName] != null)
   {
       dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
   }
            }

            CS.csDataGridView csdgv = new CS.csDataGridView();
            csdgv.ColumnsCommaAllDecimal(ref dataGridView1);
            csdgv.ColumnsCommaAllDecimal(ref dataGridView2);

        //    dataGridView1.Columns["xGrp_"].DefaultCellStyle.BackColor = Color.Aqua;
         //   dataGridView1.Columns["xGrp_"].Width = 150;

            dataGridView1.Columns["BudgetPlanPieces"].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.Columns["BudgetPlanPieces"].Width = 200;
            dataGridView1.Columns["SalePlanPieces"].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.Columns["SalePlanPieces"].Width = 200;

            dataGridView1.Columns["BudgetPlanCount"].Width = 70;
            dataGridView1.Columns["BudgetPlanCountWeight"].Width = 70;
            dataGridView1.Columns["SaleCount"].Width = 70;
            dataGridView1.Columns["mSalePlanCountWeight"].Width = 70;

            dataGridView1.Columns["SalePlanSaleType"].Width = 50;
            dataGridView1.Columns["xSaleType"].Width = 50;

            dataGridView2.Columns["SalePlanSaleType"].Width = 50;
            dataGridView2.Columns["xSaleType"].Width = 50;

            dataGridView2.Columns["SalePlanSaleType"].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView2.Columns["mSalePlanCountWeight"].DefaultCellStyle.BackColor = Color.LightGreen;

            dataGridView2.Columns["BudgetPlanCountWeight"].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView2.Columns["xSaleType"].DefaultCellStyle.BackColor = Color.LightBlue;

            dataGridView2.Columns["BudgetPlanCountWeight"].HeaderText = "مقدار بودجه فروش /تن";
            dataGridView2.Columns["BudgetPlanCountWeight"].Width = 70;
            dataGridView2.Columns["mSalePlanCountWeight"].HeaderText = "مقدار تحقق شده فروش /تن";
            dataGridView2.Columns["mSalePlanCountWeight"].Width = 70;

            dataGridView1.Columns["BudgetPlanPercent"].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView2.Columns["BudgetPlanPercent"].DefaultCellStyle.BackColor = Color.LightCoral;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;





        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            ShowDataGridView(uc_txtBox1.Text, (sender as Button).Tag.ToString());
            ChartGenerate_TR(uc_txtBox1.Text, (sender as Button).Tag.ToString());
            btn_ChangeColor();
            (sender as Button).BackColor = Color.LawnGreen;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

    
        void ChartGenerate_TR(string xYear, string xMonth)
        {

            this.chart_BR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));

            chart_BR.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart_BR.ChartAreas["ChartArea1"].AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.No;
            // chart_BR.ChartAreas["ChartArea1"].AxisY2.Minimum = 2D;


            #region ch1

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
   series_1.LegendText = "بودجه";
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
   series_2.LegendText = "فروش";
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


   DataTable dt = new BLL.BudgetPlan.csBudgetPlan().SlBudgetPlan_SalesPerformance_BySaleType(xYear, xMonth, fct_);

   chart_BR.DataSource = dt;

   series_2.XValueMember = "xSaleType";
   series_2.YValueMembers = "mSalePlanCountWeight";
   series_2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
   //chart_BR.ChartAreas[0].AxisY.IsStartedFromZero = true;


   series_1.XValueMember = "xSaleType";
   series_1.YValueMembers = "BudgetPlanCountWeight";
   series_1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
   chart_BR.ChartAreas[0].AxisY.IsStartedFromZero = true;

   this.chart_BR.Series.Add(series_1);
   this.chart_BR.Series.Add(series_2);


   chart_BR.Titles["Title1"].Text = "خلاصه عملکرد فروش و بودجه";
   //chart_BR.Legends[0].Enabled = false;

            #endregion

 

        }
    }
}
