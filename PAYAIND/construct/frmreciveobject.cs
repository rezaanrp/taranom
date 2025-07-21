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
    public partial class frmreciveobject : Form
    {
        public frmreciveobject()
        {
            InitializeComponent();
        }
        public int xidrequest;
        public bool editable = true;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmreciveobject_Load(object sender, EventArgs e)
        {allowuser cs = new allowuser();
        if (!cs.allowuserforobject("construct", true))
            editable = false;
            label1.Visible = !editable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (editable)
            {
                if (textcountok.inttext > textcountrecive.inttext) { MessageBox.Show("تعداد قطعه صحیح بزرگتر از تعداد قطعه دریافت شده است"); return; }
                if (!txtrecivedate.accept) { MessageBox.Show("تاریخ دریافت صحیح نیست"); return; }
                PAYAIND.csrequsetconstruct cs = new PAYAIND.csrequsetconstruct();
                cs.insertrequestconstructreciverobject(xidrequest, txtrecivedate.Text, textcountrecive.inttext, textcountok.inttext);
                MessageBox.Show("ذخیره شد");
                Close();
            }
        }
    }
}
