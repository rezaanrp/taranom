using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.CorrectiveAction
{
    public partial class frmCorrectiveActionReceive : Form
    {
        public frmCorrectiveActionReceive()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn combobox_xSupplier2_ = new DataGridViewComboBoxColumn()
            {
   DataSource = new BLL.authentication().NameOfUser(),
   DisplayMember = "NameAndFamily",
   ValueMember = "x_",
   DataPropertyName = "xToUser_",
   Name = "xToUser_",
   Width = 200,
   // ReadOnly = true,
   DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView2.Columns.Add(combobox_xSupplier2_);
        }
        DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionByUserDataTable dt_R;
        DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionDetailsDataTable dt_D;
        void ShowDataGridView()
        {
            BLL.CorrectiveAction.csCorrectiveAction cs = new BLL.CorrectiveAction.csCorrectiveAction();
            dt_R = cs.mCorrectiveActionByUser(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, BLL.authentication.x_);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            Generate();
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

        }
        void SaveDataGridViewDetails()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   this.Validate();
   dataGridView2.EndEdit();
   BLL.CorrectiveAction.csCorrectiveAction cs = new BLL.CorrectiveAction.csCorrectiveAction();
   MessageBox.Show(cs.UdCorrectiveActionDetails(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
   int tt = dataGridView1.SelectedRows.Count > 0 ? (int)dataGridView1.SelectedRows[0].Cells["x_"].Value : -1;
   int pp = dataGridView1.SelectedRows.Count > 0 ? (int)dataGridView1.SelectedRows[0].Cells["xParent_"].Value : -1;
   ShowDataGridViewDetails(tt,pp);
   GenerateDetails();
            }
        }
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }
        void ShowDataGridViewDetails(int x_,int Parent_)
        {
            BLL.CorrectiveAction.csCorrectiveAction cs = new BLL.CorrectiveAction.csCorrectiveAction();
            dt_D = cs.mCorrectiveActionDetails(x_, Parent_);
            bindingSource2.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource2;
            dt_D.xCorrectiveAction_Column.DefaultValue = x_;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_D.xParent_Column.DefaultValue = Parent_;
            GenerateDetails();
        }
        void GenerateDetails()
        {



        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGridViewDetails((int)dataGridView1["x_", e.RowIndex].Value, (int)dataGridView1["x_Details", e.RowIndex].Value);

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            SaveDataGridViewDetails();
        }
         
        private void SavetoolStripButton13_Click(object sender, EventArgs e)
        {
            BLL.CorrectiveAction.csCorrectiveAction cs = new BLL.CorrectiveAction.csCorrectiveAction();

             //dataGridView1[]
            cs.UdCorrectiveActionByUse("","",true,-1);
        }

        private void splitContainer7_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
