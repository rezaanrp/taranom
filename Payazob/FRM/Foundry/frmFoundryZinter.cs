using System;
using System.Windows.Forms;

namespace Payazob.Foundry
{
    public partial class frmFoundryZinter : Form
    {
        public frmFoundryZinter()
        {
            InitializeComponent();

            toolStripTextBoxDateFrom.Text = BLL.csshamsidate.shamsidate;
            toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;


            BLL.csShift cs_Shift = new BLL.csShift();
            DataGridViewComboBoxColumn combobox_Shift_ = new DataGridViewComboBoxColumn();
            combobox_Shift_.HeaderText = "نام شیفت";
            combobox_Shift_.DataSource = cs_Shift.mShiftDataTable();
            combobox_Shift_.DisplayMember = "xShiftName";
            combobox_Shift_.ValueMember = "x_";
          //  combobox_Shift_.Name = "combobox_Shift_";
            combobox_Shift_.DataPropertyName = "xShift_";
            //combobox_Shift_.DisplayIndex = 3;
            combobox_Shift_.Visible = true;
            combobox_Shift_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Shift_);

        }
        DAL.Foundry.DataSet_Foundry.SlFoundryZinterDataTable dt_I;
        public string DateZinter = "";
        public int? Shift_ = -1;

        void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;

            dataGridView1.Columns["xStartTime"].HeaderText = "زمان شروع";
            dataGridView1.Columns["xEndTime"].HeaderText = "زمان پایان";
            dataGridView1.Columns["xNumberFurnace"].HeaderText = "شماره کوره";
            dataGridView1.Columns["xIsHalfZinter"].HeaderText = "نیم شابلون";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";

            dataGridView1.Columns["xNumberFurnace"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dt_I.Columns["xDate"].DefaultValue = DateZinter;
            dt_I.Columns["xShift_"].DefaultValue = Shift_;
            dt_I.Columns["xIsHalfZinter"].DefaultValue = false;

        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
            BLL.csFoundry cs = new BLL.csFoundry();
            dt_I = cs.SlFoundryZinter(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);

            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dataGridView1.DataSource;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.csFoundry cs = new BLL.csFoundry();
            if (cs.UdFoundryZinter(dt_I))
            {
                dt_I = cs.SlFoundryZinter(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
                dataGridView1.DataSource = dt_I;
                bindingSource1.DataSource = dataGridView1.DataSource;
                uc_bindingNavigator1.BindingSource = bindingSource1;
                Generate();
            }
            else
                MessageBox.Show("خطا در ارسال داده");
        }

        private void frmFoundryZinter_Load(object sender, EventArgs e)
        {


            dt_I = new DAL.Foundry.DataSet_Foundry.SlFoundryZinterDataTable();

            bindingSource1.DataSource = dt_I;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

    }
}
