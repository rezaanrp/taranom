using System;
using System.Windows.Forms;

namespace Payazob.FRM.OverTime
{
    public partial class frmOverTimeScu : Form
    {
        public frmOverTimeScu()
        {
            InitializeComponent();

            dt_O = new DAL.OverTime.DataSet_OverTime.mOverTimeScuCkhDataTable();
            bindingSource1.DataSource = dt_O;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generete();

        }
        DAL.OverTime.DataSet_OverTime.mOverTimeScuCkhDataTable dt_O;
        void ShowData()
        {
            BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
            dt_O = cs.OverTimeScuCkh(BLL.csshamsidate.shamsidate);
            bindingSource1.DataSource = dt_O;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generete();
        }
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        void generete()
        {
            //
            dataGridView1.Columns["xPerCode"].HeaderText = "شماره پرسنلی";
            dataGridView1.Columns["NameFamily"].HeaderText = "نام و فامیل";
            dataGridView1.Columns["xBeginTimeOver1"].HeaderText = "شروع اضافه کاری";
            dataGridView1.Columns["xEndTimeOver1"].HeaderText = "پایان ساعت اضافه کاری";
            dataGridView1.Columns["xReason"].HeaderText = "علت اضافه کاری";
            dataGridView1.Columns["xReason"].AutoSizeMode =DataGridViewAutoSizeColumnMode.Fill;


               
        }
    }
}
