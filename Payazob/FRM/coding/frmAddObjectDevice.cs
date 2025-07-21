using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.coding
{
    public partial class frmAddObjectDevice : Form
    {
        public frmAddObjectDevice()
        {
            InitializeComponent();

            BLL.GenGroup.csGenGroup csmg = new BLL.GenGroup.csGenGroup();

            DataGridViewComboBoxColumn combobox_TRP_ = new DataGridViewComboBoxColumn();
            combobox_TRP_.DataSource = csmg.SlGenGroup("OBJTYP");
            combobox_TRP_.DisplayMember = "xName";
            combobox_TRP_.HeaderText = "ماهیت قطعه";
            combobox_TRP_.ValueMember = "x_";
            combobox_TRP_.DataPropertyName = "xType_";
            combobox_TRP_.Name = "xType_";
            combobox_TRP_.Width = 100;
            combobox_TRP_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_TRP_.DisplayIndex = 6;
            dataGridView1.Columns.Add(combobox_TRP_);

            Show_Data();
            Generate();
        }

        PAYADATA.ObjectDevice.DataSet_ObjectDevice.mObjectTableDataTable dt_o;

        private void glassButton_Show_Click(object sender, EventArgs e)
        {
           
        }

        void Generate()
        {

            dataGridView1.Columns["xid"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xPartCode"].Visible = false;
            dataGridView1.Columns["xSerialSG"].Visible = false;

            dataGridView1.Columns["xReplacePieces"].HeaderText = "قطعه جایگزین";
         //   dataGridView1.Columns["xDeadlinePurchase"].HeaderText = "مهلت زمان خرید- تعداد روز";
            dataGridView1.Columns["xType_"].HeaderText = "ماهیت قطعه";
            dataGridView1.Columns["xname"].HeaderText = "نام قطعه";
            dataGridView1.Columns["xdetails"].HeaderText = "اطلاعات فنی قطعه";
            dataGridView1.Columns["xisBuilding"].HeaderText = "قطعه ساختی؟";
            dataGridView1.Columns["xname"].Width = 200;
            dataGridView1.Columns["xdetails"].Width = 250;
            dataGridView1.Columns["xisBuilding"].Width = 50;




        }

        void Show_Data()
        {
            dt_o = new PAYAIND.ObjectTable.ObjectTable().objecttable();
            bindingSource1.DataSource = dt_o;
            dataGridView1.DataSource = bindingSource1;
           // bindingNavigator1.BindingSource = bindingSource1;
          //  Generate();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            MessageBox.Show(new PAYAIND.ObjectTable.ObjectTable().Udobjecttable(dt_o), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show_Data();
            Generate();
        }

        private void frmAddObjectDevice_Load(object sender, EventArgs e)
        {

        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            string ColumnFilter = "xname";

            if (dt_o.Select(ColumnFilter + " like  '%" + uc_txtBox_Filter.Text + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ی', 'ي') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ي', 'ی') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ک', 'ك') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ك', 'ک') + "%'").Length > 0)
   dataGridView1.DataSource = dt_o.Select(ColumnFilter + " like  '%" + uc_txtBox_Filter.Text + "%'" +
       "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ی', 'ي') + "%'" + "Or " +
       ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ي', 'ی') + "%'" + "Or " +
       ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ک', 'ك') + "%'" + "Or " +
       ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ك', 'ک') + "%'").CopyToDataTable();
            bindingSource1.DataSource = dt_o;
        }
        public string CodePie = "";
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CodePie = dataGridView1["x_", e.RowIndex].Value.ToString();
            this.Close();
        }

    }
}
