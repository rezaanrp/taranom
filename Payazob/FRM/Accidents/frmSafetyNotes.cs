using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Accidents
{
    public partial class frmSafetyNotes : Form
    {
        public frmSafetyNotes()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("SAFNOTE");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "نوع تذکر";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xGenType_";
            combobox_Type_.Name = "xGenType_";
            combobox_Type_.Width = 150;
            // combobox_Type_.DisplayIndex = 5;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Type_);

            BLL.Person.csPersonInfo csp = new BLL.Person.csPersonInfo();
            DataGridViewComboBoxColumn combobox_Per_ = new DataGridViewComboBoxColumn();
            combobox_Per_.DataSource = csp.mPersonInfoBySec(-1);
            combobox_Per_.DisplayMember = "Name";
            combobox_Per_.HeaderText = "";
            combobox_Per_.ValueMember = "x_";
            combobox_Per_.DataPropertyName = "xPerson_";
            combobox_Per_.Name = "xPerson_";
            combobox_Per_.Width = 150;
            combobox_Per_.MaxDropDownItems = 30;
            combobox_Per_.ReadOnly = true;

            combobox_Per_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Per_);


            dt_A = new DAL.AccidentsMinor.DataSet_AccidentsMinor.mSafetyNotesDataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

        int LoadFormSearchUser()
        {
            Form frm = new Form();
            ControlLibrary.uc_SearchData uc = new ControlLibrary.uc_SearchData();
            uc.ColumnFilter = "PerName";
            uc.DataGridViewHeaderText("PerName", "نام و نام خانوادگی");
            uc.DataGridViewHeaderText("xPerID", "شماره پرسنلی");
            uc.DataGridViewClmHide("x_");
            uc.GenDataGridView(new BLL.Person.csPersonInfo().mPersonInfoSec(-1));
            uc.ResultCustom = "PerName";

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.Controls.Add(uc);
            frm.Size = uc.Size;
            frm.Height += 30;
            frm.Width += 30;
            frm.StartPosition = FormStartPosition.CenterParent;

            uc.Dock = DockStyle.Fill;
            frm.ShowDialog();

            // lbl_Comment.Text = uc.ResultCustomValue;

            return int.Parse(uc.ResultID);

        }
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        DAL.AccidentsMinor.DataSet_AccidentsMinor.mSafetyNotesDataTable dt_A;
        void ShowData()
        {
            BLL.AccidentsMinor.Accidents cs = new BLL.AccidentsMinor.Accidents();
            dt_A = cs.mSafetyNotes();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;


            Generate();
        }
        void SaveData()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   this.Validate();
   dataGridView1.EndEdit();
   MessageBox.Show(new BLL.AccidentsMinor.Accidents().UdSafetyNotes(dt_A));
   ShowData();
            }
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_A.Columns)
            {
   if( dataGridView1.Columns[dc.ColumnName] != null)
   dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            dataGridView1.Columns["xPerson_"].HeaderText = "نام شخص";
            dataGridView1.Columns["xGenType_"].HeaderText = "نوع تذکر";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xDescriptionWarning"].Width = 300;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["xPerson_"].Index == e.ColumnIndex)
            {
   int x_ = LoadFormSearchUser();
   dataGridView1[e.ColumnIndex, e.RowIndex].Value = x_;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void frmAccidentsMinor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
   if (dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
       dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
   else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
       dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;
        }
    }
}
