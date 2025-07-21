using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmPhone : Form
    {
        public frmPhone()
        {
            InitializeComponent();
            formFunctionPointer += new functioncall(Replicate);
            uc_ListFiled1.userFunctionPointer = formFunctionPointer;
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

        }

        DAL.DataSet_Phone.SelectPhoneDetialsByValueDataTable dt_P;

        private void generateForm()
        {
            //  x_, xName + ' ' + xFamily AS Name,xPost, xComponyName, xWebSite, xEmail, xFax, xTel, xMob
            BLL.csPhone ph = new BLL.csPhone();

            dt_P = ph.SelectPhoneDetialsByValue(uc_txtBox1.Text);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["Name"].HeaderText = "نام";
            dataGridView1.Columns["xPost"].HeaderText = "سمت";
            dataGridView1.Columns["xComponyName"].HeaderText = "نام شرکت";
            dataGridView1.Columns["xWebSite"].HeaderText = "وب سایت";
            dataGridView1.Columns["xEmail"].HeaderText = "پست الکترونیکی";
            dataGridView1.Columns["xFax"].HeaderText = "نمابر";
            dataGridView1.Columns["xTel"].HeaderText = "تلفن";
            dataGridView1.Columns["xMob"].HeaderText = "همراه";
            dataGridView1.Columns["xAddress"].HeaderText = "آدرس";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xName"].Visible = false;
            dataGridView1.Columns["xFamily"].Visible = false;
            
            
            bindingNavigator1.BindingSource = bindingSource1;
 
        }

        private void frmPhone_Load(object sender, EventArgs e)
        {
            uc_ListFiled1.SendToBack();

        }

        public delegate void functioncall(string message);

        private event functioncall formFunctionPointer;

        private void Replicate(string message)
        {
            uc_txtBox1.Text = message;
            uc_ListFiled1.Visible = false;
            btn_Search_Click(null, null);
        }

        BLL.csPhone cs = new BLL.csPhone();

        private void uc_txtBox1_TextChanged(object sender, EventArgs e)
        {
            uc_ListFiled1.BringToFront();

            uc_ListFiled1.ValueMemmbers = "x_";
            uc_ListFiled1.DisplayMemmbers = "Name";
            uc_ListFiled1.Generate(cs.SelectPhonedetialsFilterByValue(uc_txtBox1.Text));
        }

        private void uc_txtBox1_Enter(object sender, EventArgs e)
        {
            uc_ListFiled1.Visible = true;

        }

        private void uc_txtBox1_Leave(object sender, EventArgs e)
        {
            uc_ListFiled1.Visible = false;
            uc_ListFiled1.SendToBack();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            uc_ListFiled1.Visible = false;
            generateForm();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmPhoneNew frm = new frmPhoneNew();
            frm.NewData = true;
            frm.ShowDialog();
            btn_Search_Click(null, null);
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmPhoneNew frm = new frmPhoneNew();
          //  x_, xName + ' ' + xFamily AS Name,xPost, xComponyName, xWebSite, xEmail, xFax, xTel, xMob
            frm.UpdateData = true;
            frm.DeleteData = true;
            frm.x_ = (int)dataGridView1.Rows[e.RowIndex].Cells["x_"].Value;
            frm.xName = dataGridView1.Rows[e.RowIndex].Cells["xName"].Value.ToString();
            frm.xFamily = dataGridView1.Rows[e.RowIndex].Cells["xFamily"].Value.ToString();
            frm.xComponyName = dataGridView1.Rows[e.RowIndex].Cells["xComponyName"].Value.ToString();
            frm.xWebSite = dataGridView1.Rows[e.RowIndex].Cells["xWebSite"].Value.ToString();
            frm.xEmail = dataGridView1.Rows[e.RowIndex].Cells["xEmail"].Value.ToString();
            frm.xFax = dataGridView1.Rows[e.RowIndex].Cells["xFax"].Value.ToString();
            frm.xTel = dataGridView1.Rows[e.RowIndex].Cells["xTel"].Value.ToString();
            frm.xMob = dataGridView1.Rows[e.RowIndex].Cells["xMob"].Value.ToString();
            frm.xAddress = dataGridView1.Rows[e.RowIndex].Cells["xAddress"].Value.ToString();

            frm.ShowDialog();
            btn_Search_Click(null, null);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            BLL.csPhone cs = new BLL.csPhone();
            this.Validate();
            dataGridView1.EndEdit();
            cs.UpdatePhoneDetials(dt_P);
            MessageBox.Show("ارسال با موفقیت انجام شد");
        }

    }
}
