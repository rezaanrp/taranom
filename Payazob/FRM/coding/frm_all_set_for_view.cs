using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAYAZOBNET.form.coding
{
    public partial class frm_all_set_for_view : Form
    {
        public frm_all_set_for_view()
        {
            InitializeComponent();
        } PAYAIND.fillcombo source = new PAYAIND.fillcombo();
        public void coding()
        {
            try
            {
                string cod_devic;
                if (chekbox_showall.Checked) cod = "-";
                else if (checkBox4.Checked)
                {
                    cod_devic = source.cod_of_device(combo_device_name.Text);
                    cod = cod_devic + "-";
                }
                else if (!checkBox1.Checked)
                {
                    cod_devic = source.cod_of_device(combo_device_name.Text);
                    cod = cod_devic + "-" + combo_device_no.Text;
                }
                else if (!checkBox2.Checked)
                {
                    cod = combo_set1_name.SelectedValue.ToString();
                }
                else if (checkBox2.Checked)
                {
                    cod = combo_set2_name.SelectedValue.ToString();
                }
            }
            catch { }
        }
        private void chekbox_showall_CheckedChanged(object sender, EventArgs e)
        {
             if (chekbox_showall.Checked == false)
            {if (!checkBox1.Checked)
                splitContainer1.SplitterDistance = 100;
               // splitContainer1.Panel1.Height = 100;
                groupBox1.Visible = true;
                combo_device_name.DataSource = source.fillcombonamedevice();
                combo_device_name.DisplayMember = "xnamedevice";
                combo_device_name.ValueMember = "xcoddevice";     
                try
                {
                    combo_device_name.SelectedIndex = 0;
                }
                catch { }
                combo_device_name_SelectedIndexChanged(null, null);
                checkBox4_CheckedChanged(null, null);
            }
            else { groupBox1.Visible = false;  splitContainer1.SplitterDistance = 50; filtering(); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {if (!checkBox2.Checked)
                splitContainer1.SplitterDistance = 130;
                groupBox2.Visible = true;
                label6.Text = "جستجو در نام مجموعه فرعی1";
                changsource_comboset1();
            }
            else { groupBox2.Visible = false; splitContainer1.SplitterDistance = 70; label6.Text = "جستجو در نام مجموعه اصلی"; }
            filtering();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                groupBox3.Visible = true;
                changsource_comboset2(); splitContainer1.SplitterDistance = 170;
                label6.Text = "جستجو در نام مجموعه فرعی2";
            }
            else { groupBox3.Visible = false; splitContainer1.SplitterDistance = 130; label6.Text = "جستجو در نام مجموعه فرعی1"; }
            filtering();
        }
        private void changsource_combono()
        {
            combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
            combo_device_no.SelectedIndex = 0;
        }
        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            changsource_combono();
            combo_device_no_SelectedIndexChanged(null, null);
        }
        static string cod = "";

        private void combo_device_no_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(null, null);
            filtering();
        }
        private void changsource_comboset1()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            string s = source.cod_of_device(combo_device_name.Text).Substring(0,3) + "-" + combo_device_no.Text;
            combo_set1_name.DataSource = source.fillcombo_set1(s);
            combo_set1_name.DisplayMember = "xnameset1";
            combo_set1_name.ValueMember = "xcod";
            try
            {
                combo_set1_name.SelectedIndex = 0;
                combo_set1_name_SelectedIndexChanged(null, null);
            }
            catch { }
        }

        private void combo_set1_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox2_CheckedChanged(null, null);
            filtering();
        }
        private void changsource_comboset2()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            combo_set2_name.DataSource = source.fillcombo_set2(combo_set1_name.SelectedValue.ToString());
            combo_set2_name.DisplayMember = "xnameset2";
            combo_set2_name.ValueMember = "xcodfinalset2";
            try
            {
                combo_set2_name.SelectedIndex = 0;
            }
            catch { }
            combo_set2_name_SelectedIndexChanged(null, null);
        }

        private void combo_set2_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtering();
        }
       
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox1.Enabled = false;
                combo_device_no.Enabled = false;
                groupBox2.Enabled = false;
            }
            else { checkBox1.Enabled = true; combo_device_no.Enabled = true; groupBox2.Enabled = true; }
            filtering();
        }
         private void filldatagrid()
        {
             PAYAIND.fill_datagride cs = new PAYAIND.fill_datagride();
             bindingSource1.DataSource = cs.fillallsetforview();
             dataGridView1.DataSource = bindingSource1;
             dataGridView1.AutoGenerateColumns = true;
             bindingNavigator1.BindingSource = bindingSource1;   
             filtering();
        }
        private void filtering()
        {
            coding();
            if (chekbox_showall.Checked)
            {
                bindingSource1.Filter = "  xnameset1 like '%" + textBoxX1.Text + "%'";
            }
            else if (!checkBox1.Checked)
            {
                bindingSource1.Filter = "  xcod like '%" + cod + "%' ";
                bindingSource1.Filter += "  And  xnameset1 like '%" + textBoxX1.Text + "%'";
            }
            else if (!checkBox2.Checked)
            {
                bindingSource1.Filter = "  xcodfinalset2 like '%" + cod + "%' ";
                bindingSource1.Filter += " and xnameset2 like '%" + textBoxX1.Text + "%'";

            }
            else
            {
                bindingSource1.Filter = "  xcodfinalset3 like '%" + cod + "%' ";
                bindingSource1.Filter += " and xnameset3 like '%" + textBoxX1.Text + "%'";

            }
        }

        private void frm_all_set_for_view_Load(object sender, EventArgs e)
        {

            splitContainer1.SplitterDistance = 50;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Linen;
            filldatagrid();
            dataGridView1.Columns["xcod"].HeaderText = "کد مجموعه اصلی";
            dataGridView1.Columns["xcodfinalset2"].HeaderText = "کد مجموعه فرعی1";
            dataGridView1.Columns["xcodfinalset3"].HeaderText = "کد مجموعه فرعی2";
            dataGridView1.Columns["xnamedevice"].HeaderText = "نام دستگاه";
            dataGridView1.Columns["xnumber"].HeaderText = "شماره دستگاه";
            dataGridView1.Columns["xnameset1"].HeaderText = "زیر مجموعه اصلی";
            dataGridView1.Columns["xnameset2"].HeaderText = "1زیر مجموعه فرعی";
            dataGridView1.Columns["xnameset3"].HeaderText = "زیر مجموعه فرعی2";
            dataGridView1.Columns["xnameset1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["xnameset2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["xnameset3"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["xcod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["xnumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["xnamedevice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            filtering();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Stimulsoft.Report.StiReport rpt = new Stimulsoft.Report.StiReport();
            rpt.Load(Properties.Resources.reportsetofdevice);           
             string  mainheader = "لیست مجموعه ها و قطعات دستگاه ها";
             DataTable dt = new DataTable();
             dt.Columns.Add("xnamedevice");
             dt.Columns.Add("xnumber");
             dt.Columns.Add("xnameset1");
             dt.Columns.Add("xcod");
             dt.Columns.Add("xnameset2");
             dt.Columns.Add("xcodfinalset2");
             dt.Columns.Add("xnameset3");
             dt.Columns.Add("xcodfinalset3");
             int j = 0;
             foreach (DataGridViewRow r in dataGridView1.Rows)
             {
                 dt.Rows.Add();
                 for (int i = 0; i < 8; i++)
                 {
                     dt.Rows[j].SetField(i,dataGridView1.Rows[j].Cells[i].Value); 
                 }
                 j++;
             }
             PAYAIND.fill_datagride cs = new PAYAIND.fill_datagride();
            PAYAIND.csshamsidateandtime csh = new PAYAIND.csshamsidateandtime();
            rpt.Dictionary.Variables.Add("reportheader","تاریخ: "+ csh.calcshmsidate());
            rpt.Dictionary.Variables.Add("reportmainheader", mainheader);
            rpt.RegBusinessObject("setofdevice", "setofdevice", dt);
            rpt.Show();
        }
    }
}
