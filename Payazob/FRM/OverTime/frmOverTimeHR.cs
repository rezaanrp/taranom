using System;
using System.Windows.Forms;

namespace Payazob.FRM.OverTime
{
    public partial class frmOverTimeHR : Form
    {
        public frmOverTimeHR()
        {
            InitializeComponent();


            dt_h = new DAL.OverTime.DataSet_OverTime.SlOverTimeDataTable();
            bindingSource1.DataSource = dt_h;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generate();
        }
        DAL.OverTime.DataSet_OverTime.SlOverTimeDataTable dt_h;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
            dt_h = cs.SlOverTime(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1, "CNF.TO.HR",-1);
            bindingSource1.DataSource = dt_h;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generate();

        }
        void generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = true;
            dataGridView1.Columns["xDateOverTime"].Visible = false;
            dataGridView1.Columns["xPerCode"].Visible = true;
            dataGridView1.Columns["xBeginTimeOver1"].Visible = true;
            dataGridView1.Columns["xEndTimeOver1"].Visible = true;
            dataGridView1.Columns["xBeginTimeOver2"].Visible = true;
            dataGridView1.Columns["xEndTimeOver2"].Visible = true;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xSupplier"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["xApprove"].Visible = true;
            dataGridView1.Columns["xManager_"].Visible = false;
            dataGridView1.Columns["xManager"].Visible = false;
            dataGridView1.Columns["xReason"].Visible = true;


            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xPerCode"].HeaderText = "شماره پرسنلی";
            dataGridView1.Columns["xBeginTimeOver1"].HeaderText = "شروع اضافه کاری";
            dataGridView1.Columns["xEndTimeOver1"].HeaderText = "پایان اضافه کاری";
            dataGridView1.Columns["xBeginTimeOver2"].HeaderText = "شروع اضافه کاری - بازنگری";
            dataGridView1.Columns["xEndTimeOver2"].HeaderText = "پایان اضافه کاری - بازنگری";
            dataGridView1.Columns["xReason"].HeaderText = "علت اضافه کاری";

            dataGridView1.Columns["Approve"].HeaderText = " نام تایید کننده اداری";


            dataGridView1.Columns["Supplier"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["xApprove"].HeaderText = "تایید اداری ";
            dataGridView1.Columns["Manager"].HeaderText = "تایید مدیر";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

    }
}
