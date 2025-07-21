using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frmfilterobject : Form
    {
        public string index = "";
        public frmfilterobject()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmfilterobject_Load(object sender, EventArgs e)
        {
           
            PAYAIND.fill_datagride cs = new PAYAIND.fill_datagride();
            dataGridView1.DataSource =cs.fillobject();// cs.fillobject(textBox1.Text);
            dataGridView1.Columns["xname"].Width = 300;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.Columns[3].Visible = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PAYAIND.fill_datagride cs = new PAYAIND.fill_datagride();
            dataGridView1.DataSource = cs.fillobject(textBox1.Text);
        }

        private void select_Click(object sender, EventArgs e)
        {
          index=  dataGridView1.CurrentRow.Cells["xid"].Value.ToString();
          Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            select_Click(null, null);
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {





        }
    }
}
