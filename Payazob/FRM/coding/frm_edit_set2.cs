using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frm_edit_set2 : Form
    {
        
        
        
        static string codof_device_in_saloon, codof_set1_in_device, codof_set2_in_set1, codof_object_in_set2;
         
        public frm_edit_set2()
        {
            InitializeComponent();
        }

        private void frm_edit_set2_Load(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            
            
            combo_device_name.DataSource = source.fillcombonamedevice();
            combo_device_name.DisplayMember = "xnamedevice";
            combo_device_name.ValueMember = "xcoddevice";
            changsource_comboset1();
            try
            {
   combo_device_name.SelectedIndex = Payazob.Program.selectindexnamedevice;
   combo_set1_name.SelectedIndex = Payazob.Program.selectindexnameset1;
            }
            catch { }
            

        }
        private void fillgrid()
        {
            dataGridView1.AutoGenerateColumns = true;
            PAYAIND.fill_datagride fill = new PAYAIND.fill_datagride();
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            try
            {
   bindingSource1.DataSource = fill.filldataset2(combo_set1_name.SelectedValue.ToString());
            }
            catch { }
            //dataGridView1.Columns["xnameset2"].HeaderText="نام مجموعه";
            //dataGridView1.Columns["xcoddevice"].HeaderText = "کد دستگاه";
            //dataGridView1.Columns["xcodset2"].HeaderText = "کد دو رقمی مجموعه فرعی";
            //dataGridView1.Columns["xcod"].HeaderText = " کد مجموعه";
          //  dataGridView1.Columns["xnameset2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 

        }
       
        public void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {           
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
            try
            {
   combo_device_no.SelectedIndex = 0;
            }
            catch { }
            changsource_comboset1();
          
            fillgrid();
        }
     
        private void changsource_comboset1()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            string s = source.cod_of_device(combo_device_name.Text)+"-"+combo_device_no.Text;
            combo_set1_name.DataSource = source.fillcombo_set1(s);
            combo_set1_name.DisplayMember = "xnameset1";
            combo_set1_name.ValueMember = "xcod";
            combo_set1_name_SelectedIndexChanged(null, null);
        }

        private void combo_set1_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            fillgrid();
            try
            {
   ustextbox2.Text = source.returnmaxcodset2(combo_set1_name.SelectedValue.ToString());
            }
            catch { }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
   if ((ustextbox1.Text == "") || (ustextbox2.Text.Length < 2)) { MessageBox.Show("اطلاعات را دقیق کامل کنید"); return; }
   //    if (combo_set1_name.Text == "") return;
   //    PAYAIND.csedit insertsource = new PAYAIND.csedit();
   //    combo_set1_name_SelectedIndexChanged(null, null);
   //    codof_set2_in_set1 = codof_set1_in_device + "-" + ustextbox2.Text;
   //  if (!insertsource.insertset2(codof_set1_in_device, ustextbox1.Text, ustextbox2.Text, codof_set2_in_set1)) MessageBox.Show("با مشکلی مواجه شدیم");
   PAYAIND.csedit insertsource = new PAYAIND.csedit();
   PAYAIND.fillcombo source = new PAYAIND.fillcombo();
   insertsource.minsertset2(combo_set1_name.SelectedValue.ToString(), ustextbox2.Text,  ustextbox1.Text,txtProNet1.Text,checkBox1.Checked);
   ustextbox2.Text = source.returnmaxcodset2(combo_set1_name.SelectedValue.ToString());
   fillgrid();
            }
            catch
            {
   MessageBox.Show("خطا");
            }
        }

        
        private void btndelete_Click(object sender, EventArgs e)
        {
         //   try
            {
   DialogResult key = MessageBox.Show("حذف شود", "", MessageBoxButtons.YesNo);
   if (key == DialogResult.Yes)
   {
       PAYAIND.csedit insertsource = new PAYAIND.csedit();
       string cod = dataGridView1.CurrentRow.Cells["xcodfinalset2"].Value.ToString();
       insertsource.deletefromset2(cod);
       bindingSource1.RemoveCurrent();   
   }
            }
           // catch { }

 
        }

      
        
       
       

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {         string details;
            bool m;
            this.Validate();
   PAYAIND.csedit insertsource = new PAYAIND.csedit();
   foreach (DataGridViewRow row in dataGridView1.Rows)
   {try{details=row.Cells["xdetails"].Value.ToString();

   }
       catch{details= "";}
       try{m=(bool)row.Cells["xismecanical"].Value;

   }
       catch{m= false;}

       string name = row.Cells["xnameset2"].Value.ToString();
       string cod = row.Cells["xcodfinalset2"].Value.ToString();

       insertsource.updateset2(name,details,m, cod);
   }
   MessageBox.Show("ذخیره شد");
        }

        private void combo_device_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
   PAYAIND.fillcombo source = new PAYAIND.fillcombo();
   changsource_comboset1();
   ustextbox2.Text = source.returnmaxcodset2(combo_set1_name.SelectedValue.ToString());
            }
            catch { }
        }

    }
}
