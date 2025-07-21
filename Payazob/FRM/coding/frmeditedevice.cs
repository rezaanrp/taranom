using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frmeditedevice : Form
    {
        public frmeditedevice()
        {
            InitializeComponent();
        }
        private bool edite;
        PAYADATA.coding.DataSetcoding.deviceDataTable datatable;
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmeditedevice_Load(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            comboBoxdevicename.DataSource = source.fillcombonamedevice();
            comboBoxdevicename.SelectedIndex = 0;
            comboBoxdevicename.DisplayMember = "xnamedevice";
            comboBoxdevicename.ValueMember = "xcoddevice";
            comboBoxlocation.DataSource = source.fillcombolocation();
            comboBoxlocation.DisplayMember = "xnameoflocation";
            comboBoxlocation.ValueMember = "xcodoflocation";
            comboBoxperiod.DataSource = source.fillperiod();
            comboBoxperiod.DisplayMember = "xname";
            comboBoxperiod.ValueMember = "xid";
            comboBoxstate.DataSource = source.filldevice_state();
            comboBoxstate.DisplayMember = "xstate";
            comboBoxstate.ValueMember = "xid";
            comboBoxlevel.DataSource = source.filllevelautomation();
            comboBoxlevel.DisplayMember = "xlevelautomation";
            comboBoxlevel.ValueMember = "xid";
            dataGridView1.AutoGenerateColumns = true;
            fillgrid();      
        }
        
        
        PAYAIND.fill_datagride fill = new PAYAIND.fill_datagride();

        string cod;
        private void btn_save_device_Click(object sender, EventArgs e)
        {
           
            
            PAYAIND.csedit insertsource = new PAYAIND.csedit();

        //    try
         //   {

   if (!edite)
   {
       if ((txtnameno.Text.Length < 2))
       {
           MessageBox.Show("شماره دستگاه نمی تواند خالی باشد و حتما باید دو رقمی باشد");
           return;
       }
       cod = comboBoxdevicename.SelectedValue.ToString().Substring(0,3) + "-" + txtnameno.Text;
       string id = (string)comboBoxdevicename.SelectedValue;
       //  insertsource.insertdevice(cod, id, txtnameno.Text, (int)comboBoxlocation.SelectedValue, txtserial.Text, txtdatemake.Text, txtdatestart.Text, (int)comboBoxstate.SelectedValue, (int)comboBoxlevel.SelectedValue, (int)comboBoxperiod.SelectedValue);
       insertsource.insertdevice(cod, id, txtnameno.Text, (string)comboBoxlocation.SelectedValue, txtserial.Text, txtdatemake.Text, txtdatestart.Text, (int?)comboBoxstate.SelectedValue, (int?)comboBoxlevel.SelectedValue, (int?)comboBoxperiod.SelectedValue);


   }
   else
   {
       insertsource.updatedevicebydataset(cod, txtserial.Text, txtdatemake.Text, txtdatestart.Text, (int)comboBoxstate.SelectedValue, (int)comboBoxlevel.SelectedValue, (int)comboBoxperiod.SelectedValue);

   }
   MessageBox.Show("ذخیره شد");
  // splitContainer1.Panel1Collapsed = true;
   fillgrid();
        //    }
        //    catch { MessageBox.Show("خطا در ذخیره اطلاعات"); }
           
         //   groupBox1.Visible = false;
        }

        private void ustextbox1_Load(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            PAYAIND.csedit insertsource = new PAYAIND.csedit();
            DialogResult key = MessageBox.Show("حذف شود؟؟؟", "", MessageBoxButtons.YesNo);
            if (key == DialogResult.Yes)
            {
   string cod = dataGridView1.CurrentRow.Cells["xcod"].Value.ToString();
   insertsource.deletefromdevice(cod);
   bindingSource1.RemoveCurrent();   
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          //  splitContainer1.Panel1Collapsed = false;
            edite = false;
          //  groupBox1.Visible = true;
            comboBoxdevicename.Enabled = true;
            txtnameno.Enabled = true;
            comboBoxlocation.Enabled = true;
            comboBoxlevel.SelectedValue = 0;
            comboBoxperiod.SelectedValue = 0;
            comboBoxstate.SelectedValue = 0;
            comboBoxlocation.SelectedValue = 0;
            txtnameno.Clear();           
            txtserial.Clear();
            
        }

       

        private void btnsaveedite_Click(object sender, EventArgs e)
        {
          
        }
        private void fillgrid()
        {
  PAYAIND.fill_datagride fill2 = new PAYAIND.fill_datagride();            
  datatable = fill2.fill_datagrid_device();
  bindingSource1.DataSource = datatable;           
          
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            form.coding.frmdetailsofdevice f = new coding.frmdetailsofdevice();
            f.Show();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // splitContainer1.Panel1Collapsed = false;
            edite = true;
            DataGridViewRow r = dataGridView1.CurrentRow;
         //   groupBox1.Visible = true;
            comboBoxdevicename.SelectedValue=r.Cells["xiddevice"].Value;
            comboBoxdevicename.Enabled = false;
            txtnameno.Enabled = false;
            comboBoxlocation.Enabled = false;
            comboBoxlevel.SelectedValue = r.Cells["xautomation"].Value;
            comboBoxperiod.SelectedValue = r.Cells["xperiodid"].Value; ;
            comboBoxstate.SelectedValue = r.Cells["xstatepurchase"].Value;
            comboBoxlocation.SelectedValue = r.Cells["xcodoflocation"].Value;
            txtnameno.Text =(string) r.Cells["xnumber"].Value; 

            try
            {
   txtdatemake.Text = (string)r.Cells["xdateofmaking"].Value;
            }
            catch { }
            try
            {
   txtdatestart.Text = (string)r.Cells["xdatestart"].Value;
            }
            catch { }
             try
            {
            txtserial.Text = (string)r.Cells["xmanufactur_serial_number"].Value;
            }
             catch { }
            cod = (string)r.Cells["xcod"].Value; 


        }

        private void button1_Click(object sender, EventArgs e)
        {
           // splitContainer1.Panel1Collapsed = true;  
          //  groupBox1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
