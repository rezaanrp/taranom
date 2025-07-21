using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form.coding
{
    public partial class frm_objectfordisposal : Form
    { 
        PAYAIND.fillcombo source = new PAYAIND.fillcombo();
        public string cod;
        public string name;
        public frm_objectfordisposal()
        {
            InitializeComponent();
            combo_device_name.DataSource = source.fillcombonamedevicebycod();
            combo_device_name.DisplayMember = "xnamedevice";
            combo_device_name.ValueMember = "xcoddevice";
        }

        private void frm_objectfordisposal_Load(object sender, EventArgs e)
        {
            PAYAIND.fill_datagride cs = new PAYAIND.fill_datagride();
            combo_object_name.DataSource = cs.fillobject();
            combo_object_name.DisplayMember = "xname";
            combo_object_name.ValueMember = "xid";

        }

        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            changsource_combono();
           combo_device_no_SelectedIndexChanged(null, null);
        }
        private void changsource_combono()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
        }

        private void combo_device_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
   changsource_comboset1();
            }
            catch { }
        }
        private void changsource_comboset1()
        {
           string s = source.cod_of_device(combo_device_name.Text).Substring(0, 3) + "-" + combo_device_no.Text;
           combo_set1_name.DataSource = source.fillcombo_set1(combo_device_name.SelectedValue.ToString().Trim() + "-" + combo_device_no.Text);
           combo_set1_name.DisplayMember = "xnameset1";
           combo_set1_name.ValueMember = "xcod";
           try { combo_set1_name_SelectedIndexChanged(null, null); }
         catch { }

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
          
          
           cod = comboset3.SelectedValue.ToString() + "-" + combo_object_name.SelectedValue.ToString();
           name = combo_object_name.Text;
           Close();
           Dispose();
        }

        private void combo_set1_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
   changsource_comboset2();
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
            }
            catch { }

        }
        private void changsourse_comboset3()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            comboset3.DataSource = source.fillcombo_set3(combo_set2_name.SelectedValue.ToString());
            comboset3.DisplayMember = "xnameset3";
            comboset3.ValueMember = "xcodfinalset3";
        }

        private void comboset3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //form.frmfilterobject f = new frmfilterobject();
            //f.ShowDialog(); if (f.index != "")
            //    combo_object_name.SelectedValue = f.index;
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
       
     
      

       
       

    }
}
