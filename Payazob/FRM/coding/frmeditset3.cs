using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frmeditset3 : Form
    {
        public frmeditset3()
        {
            InitializeComponent();
        }
      

        private void mdeviceset3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mdeviceset3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payazobnetDataSet);

        }

        private void frmeditset3_Load(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            this.mdeviceset3TableAdapter.Fill(this.payazobnetDataSet.mdeviceset3);
            combo_device_name.DataSource = source.fillcombonamedevice();
            combo_device_name.ValueMember = "xcoddevice";
            combo_device_name.DisplayMember = "xnamedevice";
            mdeviceset3DataGridView.AutoGenerateColumns = true;
            combo_device_name_SelectedIndexChanged(null, null);
           //ustextbox2.Text = source.returnmaxcodset3(combo_set2_name.SelectedValue.ToString()); خودم حذف کردم 
           ustextbox1.Text = "";
            try
            {


   selectedindexset();

            }

            catch { }



        }
        public void selectedindexset()
        {
            combo_device_name.SelectedIndex = Payazob.Program.selectindexnamedevice;
            combo_set1_name.SelectedIndex = Payazob.Program.selectindexnameset1;
            combo_set2_name.SelectedIndex = Payazob.Program.selectindexnameset2;
            
        }

        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
            changsource_comboset1();
           
        }
        private void changsource_comboset1()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            string s = combo_device_name.SelectedValue.ToString().Substring(0,3)+"-"+combo_device_no.Text;
            combo_set1_name.DataSource = source.fillcombo_set1(s);
            combo_set1_name.DisplayMember = "xnameset1";
            combo_set1_name.ValueMember = "xcod";
            try { combo_set1_name_SelectedIndexChanged(null, null); }
            catch { }

        }

        private void combo_set1_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            changsource_comboset2();


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
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            try
            {
   ustextbox2.Text = source.returnmaxcodset3(combo_set2_name.SelectedValue.ToString());
   mdeviceset3BindingSource.Filter = "xparentid ='" + combo_set2_name.SelectedValue.ToString() + "'";
            }
            catch { ustextbox2.Text = "00"; }
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            PAYAIND.csedit cs= new PAYAIND.csedit();
            string coddevice= source.cod_of_device(combo_device_name.Text) +"-"+ combo_device_no.Text;
            cs.insertset3(combo_set2_name.SelectedValue.ToString(), ustextbox1.Text, ustextbox2.Text,txtProNet1.Text,checkBox1.Checked);
            this.mdeviceset3TableAdapter.Fill(this.payazobnetDataSet.mdeviceset3);
            ustextbox2.Text = source.returnmaxcodset3(combo_set2_name.SelectedValue.ToString());
        }

        private void combo_device_no_SelectedIndexChanged(object sender, EventArgs e)
        {

            changsource_comboset1();


        }
        

    }
}
