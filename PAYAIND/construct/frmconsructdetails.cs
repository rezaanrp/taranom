using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAYAZOBNET.form.construct
{
    public partial class frmconsructdetails : Form
    {
        public frmconsructdetails()
        {
            InitializeComponent();
        }
        public int xidrequest;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           panel2.Visible = radioButton.Checked;
           this.Height = 170 + button1.Bounds.Bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ucselectdistancetime1.selecteddistansbyday.ToString());
        }

        private void frmconsructdetails_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((!radioButtoninternalmake.Checked) && (!radioButton.Checked))
            {
                MessageBox.Show("نوع ساخت را مشخص کنید");
                return;
            }
            if (radioButton.Checked)
            if (!textboxdete1.accept)
            {
                MessageBox.Show("تاریخ وارد شده صحیح نیست");
                return;
            }

            PAYAIND.csrequsetconstruct cs = new PAYAIND.csrequsetconstruct();
            cs.savedatailsforrequest(xidrequest, checkBox3ismap.Checked, radioButtoninternalmake.Checked, checkBoxhistory.Checked, checkBoxval.Checked, textBoxadress.Text, textboxdete1.Text, ucselectdistancetime1.selecteddistansbyday);
            MessageBox.Show("اطلاعات با موفقیت ارسال شد");
            Close();
        }

        private void radioButtoninternalmake_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
