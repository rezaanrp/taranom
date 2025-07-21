using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frmedit_cod_objects : Form
    {
        public frmedit_cod_objects()
        {
            InitializeComponent();
        }

        private void mobjectcodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mobjectcodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payazobnetDataSet);

        }

        private void frmedit_cod_objects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payazobnetDataSet.mobjectcod' table. You can move, or remove it, as needed.
            this.mobjectcodTableAdapter.Fill(this.payazobnetDataSet.mobjectcod);
            // TODO: This line of code loads data into the 'payazobnetDataSet.mobjectcod' table. You can move, or remove it, as needed.
            this.mobjectcodTableAdapter.Fill(this.payazobnetDataSet.mobjectcod);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if ((ustextbox1.Text == "") || (ustextbox2.Text == "") || (comboBox1.Text == "") || (comboBox2.Text == "")) { MessageBox.Show("اطلاعات را تکمیل کنید"); return; }
            PAYAIND.csedit cs = new PAYAIND.csedit();
            if (cs.exitcodobject(ustextbox1.Text)) { MessageBox.Show("کد قطعه وارد شده قبلا استفاده شده است "); return; }
            cs.insertcodobject(ustextbox2.Text, ustextbox1.Text, comboBox2.Text, comboBox1.Text,txteng.Text);
            this.mobjectcodTableAdapter.Fill(this.payazobnetDataSet.mobjectcod); 

        }

        private void mobjectcodBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mobjectcodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payazobnetDataSet);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
