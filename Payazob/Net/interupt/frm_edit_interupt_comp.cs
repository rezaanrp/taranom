using System;
using System.Windows.Forms;

namespace PAYAZOBNET.form.interupt
{
    public partial class frm_edit_interupt_comp : Form
    {
        PAYAIND.fillcombo source = new PAYAIND.fillcombo();
        PAYAIND.cs_interupt_comp s = new PAYAIND.cs_interupt_comp();
        public bool edit = false;
        public string  id;
        public int idrequester;
        public  string timerequest, daterequest;
        public frm_edit_interupt_comp()
        {
            InitializeComponent();
            PAYAIND.fillcombo source1 = new PAYAIND.fillcombo();
            combo_device_name.DataSource =source1.fillcombonamedevicebycod();
            combo_device_name.DisplayMember = "xnamedevice";
            combo_device_name.ValueMember = "xcoddevice";
            
            if (!edit) combo_device_name.SelectedIndex = 0;
           //combo_device_name_SelectedIndexChanged(null, null);
            combo_operator_name_first.DataSource = s.operator_name();
            combo_operator_name_last.DataSource = s.operator_name();
            combo_operator_name_first.DisplayMember = "xname";
            combo_operator_name_first.ValueMember="xid";
            combo_operator_name_last.DisplayMember = "xname";
            combo_operator_name_last.ValueMember = "xid";

            {
                PAYAIND.cs_interupt_comp cs1 = new PAYAIND.cs_interupt_comp();                
               dataGridView1.DataSource = cs1.datasourcecheckbox();
               
            }

        }
        private void frm_edit_interupt_comp_Load(object sender, EventArgs e)
        {

            if (!edit)
                initilize();
            else combo_device_name.Enabled = false;
            txth1_Leave(null, null);
            try
            {
                PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
                foreach (DataGridViewRow rr in dataGridView1.Rows)
                {
                 
                    if (cs.selectdemuerofinterupt(Convert.ToInt32(id), (int)rr.Cells["xid"].Value))
                   
                    { rr.Cells["select"].Value = "1"; }

                }
            }
            catch { }

        }

        private void initilize()
        {   
            PAYAIND.csshamsidateandtime cs= new PAYAIND.csshamsidateandtime();
       
        {

            txtdate1.Text = cs.calcshmsidate();
            txtdatedelivertonet.Text = txtdate1.Text;
            txtdatedelivertopro.Text = txtdate1.Text;
            txtdatestartrepair.Text = txtdate1.Text;
            txtdateendrepair.Text = txtdate1.Text;
            txth1.Text = cs.calctime();
            txthdelivertonet.Text = txth1.Text;
            txthendrepair.Text = txth1.Text;
            txthdelivertonet.Text = txth1.Text;
            txthdelivertopro.Text = txth1.Text;
            txthstartrepair.Text = txth1.Text;

        }

        }
        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
           
          // combo_device_no.SelectedIndex = 0;           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            PAYAIND.csshamsidateandtime cc = new PAYAIND.csshamsidateandtime();
            if (cc.distansebetweendayandtime(txtdate1.Text, txtdatedelivertonet.Text, txth1.Text, txthdelivertonet.Text) < 0)
            { FarsiMessageBox.FMessageBox.Show(" تحویل به نت نمی تواند قبل از خرابی باشد!!!"); return; }
            if (cc.distansebetweendayandtime(txtdatedelivertonet.Text,txtdatestartrepair.Text ,txthdelivertonet.Text ,txthstartrepair.Text )<0)
            { FarsiMessageBox.FMessageBox.Show("شروع تعمیرات نمی تواند قبل از تحویل به نت باشد"); return; }
            if (cc.distansebetweendayandtime(txtdatestartrepair.Text ,txtdateendrepair.Text ,txthstartrepair.Text ,txthendrepair.Text )<3)
            { FarsiMessageBox.FMessageBox.Show("مدت زمان تعمیرات صحیح نیست"); return; }
            if(cc.distansebetweendayandtime(txtdateendrepair.Text ,txtdatedelivertopro.Text ,txthendrepair.Text ,txthdelivertopro.Text )<0)
            { FarsiMessageBox.FMessageBox.Show("تحویل به تولید نمی تواند قبل از اتمام تعمیرات باشد"); return; }

            PAYAIND.cs_interupt_comp cs = new PAYAIND.cs_interupt_comp();
            PAYAIND.fillcombo cod= new PAYAIND.fillcombo();
            if (groupBox1.Visible)
            {
                bool flag = false;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.Cells["select"].Value=="1")
                        flag = true;

                }
                if (!flag) { FarsiMessageBox.FMessageBox.Show("علت تاخیر در تعمیرات را انتخاب کنید"); return; }
            }
    
           // try
            {string coddevice ;
                coddevice = cod.cod_of_deviceforinterupt(combo_device_name.Text, combo_device_no.Text);
                if (combo_device_no.Text == "")
                    coddevice = cod.cod_of_deviceforinterupt(combo_device_name.Text, "01");
                if (!edit)
                {
                    //cs.inserinterupt(coddevice, combo_operator_name_first.Text, txtdate1.Text, txth1.Text, txtelat.Text, txtdatestartrepair.Text, txthstartrepair.Text, txtactivity.Text,
                    //     txtdateendrepair.Text, txthendrepair.Text, combo_operator_name_last.Text, txtdatedelivertonet.Text, txthdelivertonet.Text,
                    //     txtdatedelivertopro.Text, txthdelivertopro.Text, txthtimerepairing.Text, txttimeinterupt.Text, t.ToString());
       
                }
             
                
                else
                {
                    
                    cs.updateinteruptcomp((int)combo_operator_name_first.SelectedValue,(int)combo_operator_name_last.SelectedValue , txtdate1.Text, txth1.Text, txtelat.Text, txtdatestartrepair.Text, txthstartrepair.Text, txtactivity.Text,
                    txtdateendrepair.Text, txthendrepair.Text, txtdatedelivertonet.Text, txthdelivertonet.Text,
                    txtdatedelivertopro.Text, txthdelivertopro.Text, txthtimerepairing.Text, txttimeinterupt.Text, t.ToString(), Convert.ToInt32(id),radioButton1.Checked);
                    PAYAIND.csactioncenter csaction = new PAYAIND.csactioncenter(BLL.authentication.userid);
                    csaction.eventrequestrenovationsolved(timerequest, daterequest);
                    cs.deletalldemuerofinterupt(Convert.ToInt32(id));

                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            if ((r.Cells["select"].Value == "1"))
                            {
                                cs.insertdemuerforinterupt((int)r.Cells["xid"].Value, Convert.ToInt32(id));
                            }
                        }

                    FarsiMessageBox.FMessageBox.Show("اطلاعات ذخیره شد", "", FarsiMessageBox.FMessageBoxIcons.Information, 5000); Close();
                }
               
            }
          //  catch { MessageBox.Show("در ذخیره اطلاعات مشکلی بوجود آمد ،لطفا مقادیر ورودی را چک کنید"); }
        }

        private void txth1_TextChanged(object sender, EventArgs e)
        {           
        }
        double t;
        private void txth1_Leave(object sender, EventArgs e)
        {
            Validation.time cs = new Validation.time();
            PAYAIND.csshamsidateandtime cc = new PAYAIND.csshamsidateandtime();
            try
            {
                txtleave((System.Windows.Forms.TextBox)(sender));
            }

            catch { }


           try
            {
               
                t =cc.distansebetweendayandtime(txtdate1.Text, txtdatestartrepair.Text, txth1.Text, txthstartrepair.Text);
                txthtimerepairing.Text = cc.distansebetweendayandtime(txtdatestartrepair.Text, txtdateendrepair.Text, txthstartrepair.Text, txthendrepair.Text).ToString();
                txttimeinterupt.Text = cc.distansebetweendayandtime(txtdate1.Text, txtdatedelivertopro.Text, txth1.Text, txthdelivertopro.Text).ToString();
                labletimebetweenhavoktorepair.Text = "     فاصله زمانی بین  وقوع خرابی تا شروع تعمیرات  " + t.ToString() + "  دقیقه ";
                if (t > 15)
                {
                    groupBox1.Visible = true;
                }
                else
                {
                    groupBox1.Visible = false;
                }               
            }
            catch { }
        }
        
        public void txtleave(TextBox sender)
        {
            Validation.time cs = new Validation.time();
            if (!cs.validtime(sender.Text))
            {
                sender.Text = "";
            }           
        }

        private void txtdate1_Leave(object sender, EventArgs e)
        {
            txth1_Leave(null, null);
        }

      

    }
}
