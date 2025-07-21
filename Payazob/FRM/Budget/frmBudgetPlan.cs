using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Budget
{
    public partial class frmBudgetPlan : Form
    {
        public frmBudgetPlan(CS.csEnum.Factory FCT,CS.csEnum.GenFactoryGroupPieces PIG)
        {
            InitializeComponent();
            btn_ChangeColor();
            fct_ = (int)FCT;
            pig_ = (int)PIG;
            
            uc_txtBox1.Text = BLL.csshamsidate.shamsidate.Substring(0, 4);

            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn
            {
   HeaderText = "نام قطعه",
   DataSource = new BLL.csPieces().mPiecesDataTable(pig_),
   DisplayMember = "xName",
   ValueMember = "x_",
   Name = "combobox_PiecesLine1_",
   Visible = false,
   DataPropertyName = "xPieces_",
   DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
   Width = 200
            };
            dataGridView1.Columns.Add(combobox_PiecesLine1_);

            BLL.GenGroup.csGenGroup group = new BLL.GenGroup.csGenGroup();
            //DataTable dt = group.SlGenGroup("PCS");
            //dt.Rows.Add();
            DataGridViewComboBoxColumn column4 = new DataGridViewComboBoxColumn
            {
   DataSource = group.SlGenGroup("PCS"),
   HeaderText = "طبقه بندی ",
   DisplayMember = "xName",
   ValueMember = "x_",
   DataPropertyName = "xGrp_",
   Name = "xGrp_",
   Width = 100,
   Visible = false,
   DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
  
            };
            dataGridView1.Columns.Add(column4);


        }
        int fct_;
        int pig_;
        DAL.BudgetPlan.DataSet_BudgetPlan.SlBudgetPlanDataTable dt_R;

        private void button12_MouseHover(object sender, EventArgs e)
        {
          //  (sender as Button).BackColor = Color.Orange;
        }

        private void btn_12_MouseLeave(object sender, EventArgs e)
        {
          //  (sender as Button).BackColor = Color.FromArgb(255, 192, 255);
        }
        
        private void btn_1_Click(object sender, EventArgs e)
        {
            ShowDataGridView(uc_txtBox1.Text, (sender as Button).Tag.ToString());
            btn_ChangeColor();
            (sender as Button).BackColor = Color.LawnGreen;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView();
        }
        void Generate()
        {
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_R.Columns)
            {
   if (dataGridView1.Columns[dc.ColumnName] != null)
   {
       dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
   }
            }
            dataGridView1.Columns["xProductInspectionCount"].Visible = false;
            dataGridView1.Columns["xFactory_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xYear"].Visible = false;
            //  dataGridView1.Columns["xMonth"].Visible = false;
            dataGridView1.Columns["xMonth"].ReadOnly = true;
            dataGridView1.Columns["xMonth"].Width = 50;
            dataGridView1.Columns["xMonth"].DisplayIndex = 1;
            dataGridView1.Columns["PiecesName"].Visible = false;
            dataGridView1.Columns["xCount"].HeaderText = "تعداد برنامه ریزی فروش";

            dataGridView1.Columns["xGrp_"].Visible = true;
            dataGridView1.Columns["xGrp_"].DisplayIndex = 3;
            dataGridView1.Columns["combobox_PiecesLine1_"].Visible = true;
            dataGridView1.Columns["combobox_PiecesLine1_"].DisplayIndex = 2;
            dataGridView1.Columns["xSaleType"].Visible = true;
            dataGridView1.Columns["xSaleType"].DisplayIndex = 4;
            
        }
        void btn_ChangeColor()
        {
            btn_01.BackColor = Color.LightGray;
            btn_2.BackColor = Color.LightGray;
            btn_3.BackColor = Color.LightGray;
            btn_4.BackColor = Color.LightGray;
            btn_5.BackColor = Color.LightGray;
            btn_6.BackColor = Color.LightGray;
            btn_7.BackColor = Color.LightGray;
            btn_8.BackColor = Color.LightGray;
            btn_9.BackColor = Color.LightGray;
            btn_10.BackColor = Color.LightGray;
            btn_11.BackColor = Color.LightGray;
            btn_12.BackColor = Color.LightGray;
        }
        void ShowDataGridView(string xYear, string xMonth)
        {
       
            dt_R = new BLL.BudgetPlan.csBudgetPlan().SlBudgetPlan(xYear,xMonth,fct_) ;
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_; ;
            dt_R.xYearColumn.DefaultValue = xYear;
            dt_R.xMonthColumn.DefaultValue = xMonth;
            dt_R.xFactory_Column.DefaultValue = fct_;
            Generate();
        }

        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   this.Validate();
   dataGridView1.EndEdit();
   MessageBox.Show(new BLL.BudgetPlan.csBudgetPlan().UdBudgetPlan(dt_R), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
   ShowDataGridView(uc_txtBox1.Text,"01");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
