using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form.coding
{
    public partial class frmdetailsofdevice : Form
    {
        public frmdetailsofdevice()
        {
            InitializeComponent();
        //    xselcetmap.Click += new EventHandler<EventArgs>(selectmap);
    
        }
        private void selectmap(object sender, EventArgs e)


        { 
        //    form.frmselectmap f = new frmselectmap();
        //f.ShowDialog(); int id; bool type;
        //if (f.mapname != "")
        //{
        //    id = (int)dataGridView1.CurrentRow.Cells["xid"].Value;
        //    if ((f.mapname.EndsWith("pdf")) || (f.mapname.EndsWith("PDF")))
        //        type = true;
        //    else type = false;
        //    PAYAIND.csedit cs = new PAYAIND.csedit();
        //    if (cs.insermapfordevice(f.mapname, id, type))
        //    {
        //        fillgrid();
        //        MessageBox.Show("ذخیره شد");
        //    }
        //}
        }

        private void frmdetailsofdevice_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = datatable;
            dataGridView1.AutoGenerateColumns = true;
            fillgrid();
        }
        PAYADATA.coding.DataSetcoding.mdetailsdeviceDataTable datatable;
        private void fillgrid()
        {
            PAYAIND.fill_datagride cs = new PAYAIND.fill_datagride();
            datatable = cs.selectdetailsdevice(); bindingSource1.DataSource = datatable;
            dataGridView1.AutoGenerateColumns = true;
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            PAYAIND.csedit cs = new PAYAIND.csedit();
            cs.updatedevicedetails(datatable);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("حذف شود؟؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
   if (MessageBox.Show("در صورت حذف کلیه دستگاه ها با این کد حذف خواهند شد!! مطمئن هستید؟؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
          
            {
   PAYAIND.csedit cs = new PAYAIND.csedit();
   cs.deletefromdevicedetails((int)dataGridView1.CurrentRow.Cells["xid"].Value);
   bindingSource1.RemoveCurrent();
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9) selectmap(null,null); 
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtProNet1.Text == "") || (txtProNet2.Text.Length < 3)) return;
            PAYAIND.csedit cs = new PAYAIND.csedit();
            float f1, f2;
            try
            {
   f1 = Convert.ToSingle(txtProNet5.Text);
            }
            catch { f1 = 0; }
            try
            {
   f2 = Convert.ToSingle(txtProNet4.Text);
            }
            catch { f2 = 0; }
            cs.insertdevicedetails(txtProNet1.Text, txtProNet2.Text, txtProNet3.Text, (int)numericUpDown2.Value, (int)numericUpDown1.Value, f1, f2);
            splitContainer1.Panel1Collapsed = true; fillgrid();
        }


        
         

        
    }
}
