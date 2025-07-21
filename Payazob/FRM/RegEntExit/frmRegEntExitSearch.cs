using System;
using System.Windows.Forms;

namespace Payazob.FRM.RegEntExit
{
    public partial class frmRegEntExitSearch : Form
    {
        public frmRegEntExitSearch()
        {
            InitializeComponent();
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = new BLL.RegEntExit.csRegEntExit().SlRegEntExitSearch(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, uc_txtBox1.Text);
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generate();
        }
        void generate()
        {
                        dataGridView1.Columns["TypeName"].HeaderText ="نوع مدرک";
                            dataGridView1.Columns["DetailName"].HeaderText ="تفضیل";
            dataGridView1.Columns["xDescription"].HeaderText = "شرح";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ ثبت";
            dataGridView1.Columns["xDeliverDate"].HeaderText = "تاریخ دریافت";
            dataGridView1.Columns["xPerGiveName"].HeaderText = "تحویل دهنده";
            dataGridView1.Columns["xPerGetName"].HeaderText = "تحویل گیرنده";
            dataGridView1.Columns["xDateRefer"].HeaderText = "تاریخ ارجاع";
            dataGridView1.Columns["xPerReferName"].HeaderText = "ارجاع دهنده";
            dataGridView1.Columns["xPerReferToName"].HeaderText = "تحویل به";
            dataGridView1.Columns["xReceiverName"].HeaderText = "گیرنده";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
        }
    }
}
