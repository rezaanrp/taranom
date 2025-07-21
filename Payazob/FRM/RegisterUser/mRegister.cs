using System;
using System.Windows.Forms;

namespace Payazob.FRM.RegisterUser
{
    public partial class mRegister : Form
    {
        public mRegister()
        {
            InitializeComponent();


            BLL.Person.csPersonInfo csp = new BLL.Person.csPersonInfo();
            DataGridViewComboBoxColumn combobox_Per_ = new DataGridViewComboBoxColumn();
            combobox_Per_.DataSource = csp.mPersonInfoBySec(-1);
            combobox_Per_.DisplayMember = "Name";
            combobox_Per_.HeaderText = "نام و نام خانوادگی WINKART";
            combobox_Per_.ValueMember = "x_";
            combobox_Per_.DataPropertyName = "xPerInfo_";
            combobox_Per_.Name = "cmb_Person";
            combobox_Per_.Width = 150;
            combobox_Per_.MaxDropDownItems = 30;

            combobox_Per_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Per_);

            DataShow();
        }
        void DataShow()
        {
            dt_U = new BLL.Register.csRegister().mUser();
            bindingSource1.DataSource = dt_U;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

   
           // dt_U.xPasswodColumn.DefaultValue = txt_pass.Text;
            dt_U.xActiveColumn.DefaultValue = true;
            dt_U.xGroup_Column.DefaultValue = 12;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == dataGridView1.Columns["xPasswod"].Index ) && e.Value != null)
            {
                dataGridView1.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["xPasswod"].Index)//select target column
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
            else
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
            //var txtBox = e.Control as TextBox;
            //txtBox.KeyDown -= new KeyEventHandler(underlyingTextBox_KeyDown);
            //txtBox.KeyDown += new KeyEventHandler(underlyingTextBox_KeyDown);
        }
        void Generate()
        {
            dataGridView1.Columns["xUserName"].Width = 300;
            dataGridView1.Columns["xUserName"].HeaderText = "نام کاربری";
            dataGridView1.Columns["xPasswod"].HeaderText = "پسورد";
            dataGridView1.Columns["xName"].HeaderText = "نام";
            dataGridView1.Columns["xFamily"].HeaderText = "نام خانوادگی";
            dataGridView1.Columns["xActive"].HeaderText = "فعال باشد؟";
            dataGridView1.Columns["xActive"].Width = 50;
            dataGridView1.Columns["x_"].Visible = false;
          //  dataGridView1.Columns["xPasswod"].Visible = false;
            dataGridView1.Columns["xGroup_"].Visible = false;

        }
        DAL.Register.DataSet_User.mUserDataTable dt_U;
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            this.Validate();
            dataGridView1.EndEdit();


            BLL.Register.csRegister css = new BLL.Register.csRegister();

            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(css.UdmUser(dt_U), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DataShow();

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
