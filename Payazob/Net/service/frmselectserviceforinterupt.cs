using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form.service
{
    public partial class frmselectserviceforinterupt : Form
    {
        public frmselectserviceforinterupt()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            button3_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PAYAIND.csserviceprogram cs = new PAYAIND.csserviceprogram();
            bindingSource1.DataSource = cs.selectserviceforshowininterupt(uCselectyearandmonth1.selecteddate);
            dataGridView1.DataSource = bindingSource1;

        }
        private void frmselectserviceforinterupt_Load(object sender, EventArgs e)
        {
            button3_Click(null, null);
           /* System.Drawing.Drawing2D.GraphicsPath mypath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle r = new Rectangle(12, 11, 609,298);
            mypath.AddRectangle(r);
            System.Drawing.Region MyFormRegion = new System.Drawing.Region(mypath);
            this.Region = MyFormRegion;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

       

    }
}
