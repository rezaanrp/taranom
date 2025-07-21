using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmCompanyList : Form
    {
        public frmCompanyList()
        {
            InitializeComponent();
        }
        DAL.DataSet_Compony.SlCompanyByNameDataTable dt_C;
        private void Generate()
        {
            dataGridView1.Columns["x_"].HeaderText = "سریال";
            dataGridView1.Columns["xComponyName"].HeaderText = "نام شرکت";
            dataGridView1.Columns["xAddress"].HeaderText = "آدرس";
            dataGridView1.Columns["xTel"].HeaderText = "تلفن";
            dataGridView1.Columns["xFax"].HeaderText = "فکس";
            dataGridView1.Columns["xEmail"].HeaderText = "ایمیل";
            dataGridView1.Columns["xWebsite"].HeaderText = "وب سایت";
            dataGridView1.Columns["xSupplyManager"].HeaderText = "مدیر تامین";
            dataGridView1.Columns["xSupplyManagerTel"].HeaderText = "شماره مدیر تامین";
            dataGridView1.Columns["xDirectorFactor"].HeaderText = "مدیر عامل";
            dataGridView1.Columns["xDirectorFactorTel"].HeaderText = "شماره مدیر عامل";
            dataGridView1.Columns["xIsCustomer"].HeaderText = "مشتری";
            dataGridView1.Columns["xIsSupplier"].HeaderText = "تامین کننده";
            dataGridView1.Columns["xActive"].HeaderText = "فعال";

            
            dataGridView1.Columns["x_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns["xComponyName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns["xSerial"].Visible = false; ;
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView1();
        }
        void  SaveDataGridView1()
        {
            this.Validate();
            dataGridView1.EndEdit();
            CS.csMessage cm = new CS.csMessage();
            if (cm.ShowMessageSaveYesNo())
            {
                BLL.csCompony cs = new BLL.csCompony();
                if (cs.UdCompanyByName(dt_C))
                {
                    ShowData();
                    MessageBox.Show("تغییرات با موفقیت انجام شد");
                }

                else
                    MessageBox.Show("خطا");

            }
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }
        private void ShowData()
        {
            BLL.csCompony cs = new BLL.csCompony();

            dt_C = cs.SlCompanyByName(toolStripTextBoxName.Text);

            bindingSource1.DataSource = dt_C;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                    if(dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)
                        lbl_Comment.Text = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.Control | Keys.Enter):
                    ShowData();
                    break;
                case (System.Windows.Forms.Keys.Control | Keys.S):
                    SaveDataGridView1();
                    break;


            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
