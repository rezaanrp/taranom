using System;
using System.Data;
using System.Windows.Forms;

namespace PAYAZOBNET.form.indicator
{
    public partial class frm_mttr : Form
    {
        string type;
        PAYAIND.fillcombo source = new PAYAIND.fillcombo();
        PAYAIND.cstrubleshooting cs = new PAYAIND.cstrubleshooting();
        public frm_mttr()
     
        {
            InitializeComponent();
            splitContainer2.Panel1Collapsed = true;
        }

        private void combo_device_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
        }

        private void combo_truble_sloution_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combo_truble_sloution.DataSource = cs.selectsolution(cs.selectcodtruble_bytrublename(combo_truble_name.Text), "all");
        }

        private void frm_mttr_Load(object sender, EventArgs e)
        {
            //-------------------

            //PAYAIND.csshamsidateandtime csdate = new PAYAIND.csshamsidateandtime();
            //uc_Filter_Date1.DateTo = csdate.calcshmsidate();

            ////**************************************************
            //int day = int.Parse(csdate.calcshmsidate().Substring(8, 2));
            ////**************************************************
            //string t = csdate.previousDay(day - 1);
            //uc_Filter_Date1.DateFrom = t;
            ////-------------------
            //***********************  intilize combobox_device
            combo_device_name.DataSource = source.fillcombonamedevicebycod();
            combo_device_name.DisplayMember = "xnamedevice";
            combo_device_name.ValueMember = "xcoddevice";
            combo_device_name.SelectedIndex = -1;
            //********************
            combo_truble_name.DataSource = cs.selecttrublebycoddevice(source.cod_of_device(combo_truble_name.Text));
            combo_truble_name.DisplayMember = "xtruble";
            combo_truble_name.ValueMember = "xid";
            combo_truble_name.SelectedIndex = -1;
            //************************
        }

        private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                splitContainer2.Panel1Collapsed = false;
                grp_Search.Visible = true;
            }
            else
            {
                splitContainer2.Panel1Collapsed = true;
                grp_Search.Visible = false;
            }
        }
        DataTable dt_P;
        private void button1_Click(object sender, EventArgs e)
        {
            string coddevice;
            PAYAIND.csmtbf bs = new PAYAIND.csmtbf();
            PAYAIND.csshamsidateandtime csh = new PAYAIND.csshamsidateandtime();
            txtallhours.Text = (csh.distansebetween(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo) * 24).ToString();
            
            if (checkBox1.Checked == false)//جستجو 
            {
                coddevice = "All";
                txt_countintrupt.Text = bs.calccountmtbf(coddevice, "", uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type,txt_Trouble.Text).ToString();
                txt_timeSuminterupt.Text = bs.calsumtmtbf(coddevice, "", uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text).ToString();
                txtnotavail.Text = (bs.calcinteruptcomptime(coddevice, "", uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text) / 60).ToString();
                txtavail.Text = (Convert.ToDouble(txtallhours.Text) - (Convert.ToDouble(txt_timeSuminterupt.Text) / 60)).ToString();
                dataGridViewX2.DataSource = bs.Interupt_mselectedtrubleshooting(coddevice, "", uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text);
                txtmttr.Text = ((Convert.ToDouble(txt_timeSuminterupt.Text)) / (Convert.ToDouble(txt_countintrupt.Text))).ToString();
                dt_P = new PAYAIND.MTTR.csMTTR_R().SlInterupTrublingChart(coddevice, "", uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text);
            }
            else
            {

                coddevice = source.cod_of_deviceforinterupt(combo_device_name.Text, combo_device_no.Text);
                int? tmp = bs.calccountmtbf(coddevice, combo_truble_name.SelectedValue == null ? "" : combo_truble_name.SelectedValue.ToString(), uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text);
                txt_countintrupt.Text = tmp == null ? "0" : tmp.ToString();

                tmp = bs.calsumtmtbf(coddevice, combo_truble_name.SelectedValue == null ? "" : combo_truble_name.SelectedValue.ToString(), uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text);
                txt_timeSuminterupt.Text = tmp == null ? "0" : tmp.ToString();

                double? tmpd = (bs.calcinteruptcomptime(coddevice, combo_truble_name.SelectedValue == null ? "" : combo_truble_name.SelectedValue.ToString(), uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text) / 60);
                txtnotavail.Text = tmp == null ? "0" : tmp.ToString();

                txtavail.Text = (Convert.ToDouble(txtallhours.Text) - (Convert.ToDouble(txt_timeSuminterupt.Text) / 60)).ToString();

                dataGridViewX2.DataSource = bs.Interupt_mselectedtrubleshooting(coddevice, combo_truble_name.SelectedValue == null ? "" : combo_truble_name.SelectedValue.ToString(), uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text);
                txtmttr.Text = ((Convert.ToDouble(txt_timeSuminterupt.Text)) / (Convert.ToDouble(txt_countintrupt.Text))).ToString();
                dt_P = new PAYAIND.MTTR.csMTTR_R().SlInterupTrublingChart(coddevice, combo_truble_name.SelectedValue == null ? "" : combo_truble_name.SelectedValue.ToString(), uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, type, txt_Trouble.Text);

            }
        }

       

        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* combo_device_name.DataSource = source.fillcombonamedevice();
            combo_device_name.DisplayMember = "xnamedevice";
            combo_device_name.ValueMember = "xcoddevice";
            combo_device_name.SelectedIndex = -1;*/
            combo_device_no_SelectedIndexChanged(null, null);
            combo_truble_sloution_SelectedIndexChanged(null, null);
            combo_type.SelectedIndex = 0;
            combo_truble_name.DataSource = cs.selecttrublebycoddevice(source.cod_of_device(combo_device_name.Text));
            combo_truble_name.DisplayMember = "xtruble";
            combo_truble_name.ValueMember = "xid";
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
        }

        private void combo_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = "all";
            if (combo_type.Text == "الکتریکی") type = "E"; if (combo_type.Text == "مکانیکی") type = "M"; if (combo_type.Text == "همه") type = "all";
            combo_truble_sloution.DataSource = cs.selectsolution(cs.selectcodtruble_bytrublename(combo_truble_name.Text), type);
            combo_truble_sloution.DisplayMember = "xcause";
        }

        private void combo_truble_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_type_SelectedIndexChanged(null, null);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            //Report.SendReport csr = new Report.SendReport();
            //form.frmreportviewer r = new form.frmreportviewer();
            //csr.SetParam("Troubling", txt_Trouble.Text);
            //r.rpt = csr.GetReport(dt_P, "CrpMTTR");
            //r.ShowDialog();
            //r.Dispose();
        }


     

       

    

    }
}
