using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frmcodingobjects : Form
    {
        
       
       // PAYAIND.fill_datagride fill = new PAYAIND.fill_datagride();
       //static BindingSource device, device_set1, device_set2, object_set2, object_table, saloon_device, device_no;
       // static string codof_device_in_saloon,codof_set1_in_device,codof_set2_in_set1,codof_object_in_set2;

        public string _CodeLocation = "";
        public int _ObjectCode = -1;
        public string _ObjectName = "";
        public string _ObjectSGCode= "";

        public int CI = 0;
        public int RI = 0;

        public frmcodingobjects()
        {
            InitializeComponent();
        }

        private void frmcodingobjects_Load(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source=new PAYAIND.fillcombo();

            combo_device_name.DataSource = new PAYAIND.DetailDevice.csDetailDevice().DetailDevice();

            comb_saloon.DataSource = source.fillcombolocation();

            combo_device_name.DisplayMember = "xnamedevice";
            combo_device_name.ValueMember = "xcoddevice";
            comb_saloon.DisplayMember = "xcodoflocation";

            combo_object_name.DataSource = new PAYAIND.ObjectTable.ObjectTable().objecttable();
            combo_object_name.DisplayMember = "xname";
            combo_object_name.ValueMember = "x_";
            // combo_olaviyat.SelectedIndex = 0;
            selectedindexset();            

        }
        //public void comboboxfill()
        //{PAYAIND.fillcombo cs= new PAYAIND.fillcombo();
        //      device.DataSource = cs.fillcombonamedevice();
        //       device_no.DataSource = cs.fillcombonamedevice();     
        //       object_table.DataSource = fill.fillobject();
        //      combo_device_name.DataSource = device;
        //      combo_device_no.DataSource = device_no;
        //      combo_set1_name.DataSource=device_set1;
        //      combo_set2_name.DataSource=device_set2;
        //       combo_object_name.DataSource=object_table;


          
        //}

        PAYADATA.ObjectLocation.DataSet_ObjectLocation.SlObjectLocationDataTable dt_l;
        private void changsource_combono()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
 
        }

        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            changsource_combono();
            combo_device_no_SelectedIndexChanged(null, null);

            string cd = "";
            if (chb_1.Checked == false)
   cd = combo_device_name.SelectedValue.ToString().Replace(" ", "") + "-" 
       + combo_device_no.SelectedValue == null ? "00" : combo_device_no.SelectedValue + "-00-00-00";
            else if (chb_2.Checked == false)
   cd = combo_set1_name.SelectedValue.ToString().Replace(" ", "") + "-00-00";
            else if (chb_3.Checked == false)
   cd = combo_set2_name.SelectedValue.ToString().Replace(" ", "") + "-00";
            else
   cd = combo_set3_name.SelectedValue.ToString().Replace(" ", "");
            Show_Data(cd);
        }
       

        private void combo_device_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            try
            {
   changsource_comboset1();
            }
            catch { }
        }
        private void changsource_comboset1()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            string s = source.cod_of_device(combo_device_name.Text).Substring(0,3) + "-" + combo_device_no.Text;
            combo_set1_name.DataSource = source.fillcombo_set1(s);
            combo_set1_name.DisplayMember = "xnameset1";
            combo_set1_name.ValueMember = "xcod";
            try { combo_set1_name_SelectedIndexChanged(null, null); }
            catch { }
            
        }

        private void combo_set1_name_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
   changsource_comboset2();
   string cd = "";
   if (chb_1.Checked == false)
       cd = combo_device_name.SelectedValue.ToString().Replace(" ", "") + "-" + combo_device_no.SelectedValue.ToString() + "-00-00-00";
   else if (chb_2.Checked == false)
       cd = combo_set1_name.SelectedValue.ToString().Replace(" ", "") + "-00-00";
   else if (chb_3.Checked == false)
       cd = combo_set2_name.SelectedValue.ToString().Replace(" ", "") + "-00";
   else
       cd = combo_set3_name.SelectedValue.ToString().Replace(" ", "");
   Show_Data(cd);
            }
            catch { }
            

        }
        private void changsource_comboset2()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_set2_name.DataSource = source.fillcombo_set2(combo_set1_name.SelectedValue.ToString());
            combo_set2_name.DisplayMember = "xnameset2";
            combo_set2_name.ValueMember = "xcodfinalset2";
            combo_set2_name_SelectedIndexChanged(null, null);
        }

        private void combo_set2_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
   changsourse_comboset3();
   string cd = "";
   if (chb_1.Checked == false)
       cd = combo_device_name.SelectedValue.ToString().Replace(" ", "") + "-" + combo_device_no.SelectedValue.ToString() + "-00-00-00";
   else if (chb_2.Checked == false)
       cd = combo_set1_name.SelectedValue.ToString().Replace(" ", "") + "-00-00";
   else if (chb_3.Checked == false)
       cd = combo_set2_name.SelectedValue.ToString().Replace(" ", "") + "-00";
   else
       cd = combo_set3_name.SelectedValue.ToString().Replace(" ", "");
   Show_Data(cd);
            }
            catch { }
            
        }
        private void changsourse_comboset3()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_set3_name.DataSource = source.fillcombo_set3(combo_set2_name.SelectedValue.ToString());
            combo_set3_name.DisplayMember = "xnameset3";
            combo_set3_name.ValueMember = "xcodfinalset3";


        }

        void Show_Data(string code)
        {

           // if (combo_set3_name.SelectedValue != null)
          //  {
   dt_l = new PAYAIND.ObjectLocation.csObjectLoation().mObjectLocation(code);
   dataGridView1.DataSource = dt_l;
   bindingSource1.DataSource = dataGridView1.DataSource;
   bindingNavigator1.BindingSource = bindingSource1;
   Generate();
          //  }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            string cd = "";
            if (chb_1.Checked == false)
   cd = combo_device_name.SelectedValue.ToString().Replace(" ", "") +"-" + combo_device_no.SelectedValue.ToString() + "-00-00-00"; 
            else if (chb_2.Checked == false)
   cd = combo_set1_name.SelectedValue.ToString().Replace(" ", "") + "-00-00";
            else if (chb_3.Checked == false)
   cd = combo_set2_name.SelectedValue.ToString().Replace(" ", "") + "-00";
            else
   cd = combo_set3_name.SelectedValue.ToString().Replace(" ", "") ;
           
             PAYAIND.ObjectLocation.csObjectLoation cs = new PAYAIND.ObjectLocation.csObjectLoation();

            // MessageBox.Show(cd);
             MessageBox.Show(cs.InObjectLocation((int)numericUpDown1.Value, cd, (int)combo_object_name.SelectedValue, checkBox1.Checked,txt_Comment.Text));

             Show_Data(cd);

            //int count;
            //PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            //selectedindexsave();
            //PAYAIND.csedit insertsource = new PAYAIND.csedit();
            //if ( combo_set1_name.Text == "" || combo_set2_name.Text == "") { MessageBox.Show("اگر زحمتی نیست اطلاعات را تکمیل کنید"); return; }
            //string s = comb_saloon.Text+"-"+comboset3.SelectedValue.ToString()+"-"+ combo_object_name.SelectedValue.ToString();
            //try{ count=(int) ( numericUpDown1.Value);
            //}
            //catch { MessageBox.Show("تعداد وارد شده صحیح نیست"); return; }
            //MessageBox.Show(s);
            //DialogResult key;
            //if (!insertsource.insertobject_set2(combo_object_name.SelectedValue.ToString(),count,s,combo_olaviyat.Text))
            //{
            //    key = MessageBox.Show("قطعه تکراری است آیا قصد ویرایش قطغه را دارید", "تکراری", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (key == DialogResult.Yes)
            //    {
            //        insertsource.updateobject_set2( count,s,combo_olaviyat.Text);

            //    }
            //}
        }

        private void btndevice_Click(object sender, EventArgs e)
        {
            form.frmeditedevice f = new frmeditedevice();
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            selectedindexsave();
            f.ShowDialog();
            combo_device_name.DataSource = source.fillcombonamedevice();
            selectedindexset();
        }

        private void btnset1_Click(object sender, EventArgs e)
        {
            form.frm_edite_set1 f = new frm_edite_set1();
            selectedindexsave();
            f.ShowDialog();
            changsource_comboset1();
            selectedindexset();
        }

        private void btnset2_Click(object sender, EventArgs e)
        {
            form.frm_edit_set2 f = new frm_edit_set2();
            selectedindexsave();
            f.ShowDialog();
            changsource_comboset2();
        }
        public void selectedindexsave ()
    {
        Payazob.Program.selectindexnamelocation = comb_saloon.SelectedIndex;
        Payazob.Program.selectindexnamedevice = combo_device_name.SelectedIndex;
        Payazob.Program.selectindexnodevice = combo_device_no.SelectedIndex;
        Payazob.Program.selectindexnameobject = combo_object_name.SelectedIndex;
        Payazob.Program.selectindexnameset1 = combo_set1_name.SelectedIndex;
        Payazob.Program.selectindexnameset2 = combo_set2_name.SelectedIndex;
        Payazob.Program.selectedindexset3 = combo_set3_name.SelectedIndex; 
    }
        public void selectedindexset()
        {
            try
            {
   combo_device_name.SelectedIndex = Payazob.Program.selectindexnamedevice;
   combo_device_no.SelectedIndex = Payazob.Program.selectindexnodevice;
   combo_set1_name.SelectedIndex = Payazob.Program.selectindexnameset1;
   combo_set2_name.SelectedIndex = Payazob.Program.selectindexnameset2;
   combo_object_name.SelectedIndex = Payazob.Program.selectindexnameobject;
   comb_saloon.SelectedIndex = Payazob.Program.selectindexnamelocation;
   combo_set3_name.SelectedIndex = Payazob.Program.selectedindexset3;

            }
            catch { }
        
        }
        private void frmcodingobjects_Activated(object sender, EventArgs e)
        { 
           // selectedindexset(); 
        }

        private void btnobject_Click(object sender, EventArgs e)
        {

            Payazob.FRM.coding.frmAddObjectDevice 
   f = new Payazob.FRM.coding.frmAddObjectDevice();
            f.ShowDialog();
            if(f.CodePie != "")
     combo_object_name.SelectedValue =  int.Parse( f.CodePie);
            //form.frmedit_object f = new frmedit_object();
            //selectedindexsave();
            //f.ShowDialog();
            //PAYAIND.fill_datagride cs = new PAYAIND.fill_datagride();
            //combo_object_name.DataSource = cs.fillobject();
        }

        private void comb_saloon_SelectedIndexChanged(object sender, EventArgs e)
        {            
           


        }

        private void combo_object_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void btnset3_Click(object sender, EventArgs e)
        {
            form.frmeditset3 f = new frmeditset3();
            selectedindexsave();
            f.ShowDialog();
            changsourse_comboset3();
            selectedindexset();
        }

        private void comboset3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
             if (combo_set3_name.SelectedValue != null)
 {
     Show_Data( combo_set3_name.SelectedValue.ToString() );
 }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //form.frmfilterobject f = new frmfilterobject();
         
            //f.ShowDialog();if (f.index!="")
            //combo_object_name.SelectedValue = f.index;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void Generate()
        {
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xCodeParent"].HeaderText = "کد مکان";
            dataGridView1.Columns["xCodeParent"].ReadOnly  = true;
            dataGridView1.Columns["xObjectTable_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xNeedExtra"].HeaderText = "قطعه یدکی داشته باشد";
            dataGridView1.Columns["ObjectName"].HeaderText = "نام قطعه";
            dataGridView1.Columns["xSerialSG"].HeaderText = "کد همکاران";
            dataGridView1.Columns["ObjectName"].DisplayIndex = 0;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new PAYAIND.ObjectLocation.csObjectLoation().UdObjectLocation(dt_l));
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
   _ObjectCode = (int)dataGridView1["x_", e.RowIndex].Value;

   _CodeLocation = dataGridView1["xCodeParent", e.RowIndex].Value != DBNull.Value ? (string)dataGridView1["xCodeParent", e.RowIndex].Value : "";
   _ObjectName = dataGridView1["ObjectName", e.RowIndex].Value != DBNull.Value ? (string)dataGridView1["ObjectName", e.RowIndex].Value : "";
   _ObjectSGCode = dataGridView1["xSerialSG", e.RowIndex].Value != DBNull.Value ? (string)dataGridView1["xSerialSG", e.RowIndex].Value : ""; 
   
   this.Close();

            }
        }

        private void chb_1_CheckedChanged(object sender, EventArgs e)
        {
            combo_set1_name.Enabled = !combo_set1_name.Enabled;
            btnset1.Enabled = !btnset1.Enabled;
            if (chb_1.Checked == false)
            {
   chb_2.Checked = false;
   chb_3.Checked = false;
   chb_2.Enabled = false;
   chb_3.Enabled = false;

            }
            else
            {
   chb_2.Enabled = true;
            }
        }

        private void chb_2_CheckedChanged(object sender, EventArgs e)
        {
            combo_set2_name.Enabled = !combo_set2_name.Enabled;
            btnset2.Enabled = !btnset2.Enabled;

            if (chb_2.Checked == false)
            {
   chb_3.Checked = false;
   chb_3.Enabled = false;

            }
            else
            {
   chb_3.Enabled = true;
            }

        }

        private void chb_3_CheckedChanged(object sender, EventArgs e)
        {
            combo_set3_name.Enabled = !combo_set3_name.Enabled;
            btnset3.Enabled = !btnset3.Enabled;

        }


       

        
             
           
       




    }
}
