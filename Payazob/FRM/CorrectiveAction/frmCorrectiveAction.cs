using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.CorrectiveAction
{
    public partial class frmCorrectiveAction : Form
    {
        public frmCorrectiveAction(CS.csEnum.Factory fct, CS.csEnum.GenFactoryGroupPieces fctP)
        {
            InitializeComponent();

            fct_ = fct;
            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 3,
                HeaderText = "نام قطعه",
                DataSource = new BLL.csPieces().mPiecesDataTable((int)fctP),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xPieces_",
                Name = "xPieces_",
                Width = 200,
                MaxDropDownItems = 30,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(combobox_xPieces_);
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
        DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionDataTable dt_R;
        DAL.CorrectiveAction.DataSet_CorrectiveAction.mCorrectiveActionDetailsDataTable dt_D;
        CS.csEnum.GenFactoryGroupPieces fctP_;
        CS.csEnum.Factory fct_;
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }
        void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_R.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }

        }
        void GenerateDetails()
        {



        }
        void ShowDataGridView()
        {
            BLL.CorrectiveAction.csCorrectiveAction cs = new BLL.CorrectiveAction.csCorrectiveAction();
            dt_R = cs.mCorrectiveAction(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (int)fct_);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xGenFactory_Column.DefaultValue = fct_;
            Generate();
        }
        void ShowDataGridViewDetails(int x_)
        {
            BLL.CorrectiveAction.csCorrectiveAction cs = new BLL.CorrectiveAction.csCorrectiveAction();
            dt_D = cs.mCorrectiveActionDetails(x_, -1);
            bindingSource2.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource2;
            dt_D.xCorrectiveAction_Column.DefaultValue = x_;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_D.xParent_Column.DefaultValue = -1;
            GenerateDetails();
        }
        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                BLL.CorrectiveAction.csCorrectiveAction cs = new BLL.CorrectiveAction.csCorrectiveAction();
                MessageBox.Show(cs.UdCorrectiveAction(dt_R), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGridView();
                Generate();
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
                ShowDataGridViewDetails(tt);
                GenerateDetails();
            }
        }

        private void SavetoolStripButton13_Click(object sender, EventArgs e)
        {
            SaveDataGridView();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataGridViewDetails((int)dataGridView1["x_", e.RowIndex].Value);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            SaveDataGridViewDetails();
        }
    }
}
