using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frm_edite_set1 : Form
    {
        static string codof_device_in_saloon, codof_set1_in_device, codof_set2_in_set1, codof_object_in_set2;
       
       
        public frm_edite_set1()
        {
            InitializeComponent();
        }
      
        private void frm_edite_set1_Load(object sender, EventArgs e)
        {
            
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            ustextbox1.Text = "";
            combo_device_name.DataSource = source.fillcombonamedevice();
            combo_device_name.ValueMember = "xcoddevice";
            combo_device_name.DisplayMember = "xnamedevice";
            combo_device_name.SelectedIndex = Payazob.Program.selectindexnamedevice;
            combo_device_name_SelectedIndexChanged(null, null);           
            ustextbox2.Text = source.returnmaxcodset1(combo_device_name.Text,combo_device_no.Text);
            dataGridView1.AutoGenerateColumns = true;
            fillgrid();

           
           
           
        }
        public void  fillgrid()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            PAYAIND.fill_datagride fill = new PAYAIND.fill_datagride();
            bindingSource1.DataSource = fill.filldataset1((combo_device_name.SelectedValue.ToString().Substring(0,3))+"-"+combo_device_no.Text);
           
        }

       
       
        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
            try
            {
   combo_device_no.SelectedIndex = 0;
            }
            catch { }
           
           ustextbox2.Text = source.returnmaxcodset1(combo_device_name.Text,combo_device_no.Text);
           fillgrid();
            //dataGridView1.Columns["xnameset1"].HeaderText = "نام مجموعه";
            //dataGridView1.Columns["xiddevice"].HeaderText = "کد دستگاه";
            //dataGridView1.Columns["xid"].HeaderText = "کد دو رقمی مجموعه ";
            //dataGridView1.Columns["xcod"].HeaderText = " کد مجموعه";
            dataGridView1.Columns["xnameset1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
        // try
            {
   if ((ustextbox1.Text == "") || (ustextbox2.Text.Length < 2)) { MessageBox.Show("اطلاعات را کامل کنید،کد مجموعه  باید دورقمی باشد"); return; }
  
   PAYAIND.csedit insertsource = new PAYAIND.csedit();
  /////////////////////////////////
   insertsource.minserset1(ustextbox1.Text, combo_device_name.Text,combo_device_no.Text, ustextbox2.Text,txtProNet1.Text,checkBox1.Checked);
  
  
   
   ustextbox2.Text = source.returnmaxcodset1(combo_device_name.Text,combo_device_no.Text);
   fillgrid();


            }
       //   catch { MessageBox.Show("خطا رخ داد"); }

        }
        public void inserdevice_in_saloon()
    {
     
    }

       
       

        private void frm_edite_set1_Activated(object sender, EventArgs e)
        {
           
    }

        private void btndelete_Click(object sender, EventArgs e)
        {
            PAYAIND.csedit insertsource = new PAYAIND.csedit();
            if (MessageBox.Show("حذف شود؟؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
   
   insertsource.deletefromset1(dataGridView1.CurrentRow.Cells["xcod"].Value.ToString());
   bindingSource1.RemoveCurrent();
  // combo_device_name_SelectedIndexChanged(null, null);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            PAYAIND.csedit insertsource = new PAYAIND.csedit();
            dataGridView1.EndEdit();
            this.Validate();          
            foreach (DataGridViewRow table in dataGridView1.Rows)
            {
   string details;
   bool m;
   string name = table.Cells["xnameset1"].Value.ToString();
   string cod = table.Cells["xcod"].Value.ToString();
   try
   {
        details = table.Cells["xdetails"].Value.ToString();
   }
   catch { details = ""; }

   try
   {
       m = (bool)table.Cells["xismecanical"].Value;
   }
   catch { m = false; }
           
   insertsource.updateset1(name, details, m, cod);
            }
            MessageBox.Show("ذخیره شد!");}

       
        private void combo_device_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            ustextbox2.Text = source.returnmaxcodset1(combo_device_name.Text, combo_device_no.Text);
            fillgrid();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
