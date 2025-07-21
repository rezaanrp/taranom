using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAYAZOBNET.form
{
    public partial class frm_all_object : Form
    {
        PAYAIND.fill_datagride fill = new PAYAIND.fill_datagride();
        static int typefilter = 0;
        public frm_all_object()
        {
            InitializeComponent();
        }
        static string filterstring = "";
        PAYAIND.fillcombo source = new PAYAIND.fillcombo();
        PAYAIND.csedit insertsource = new PAYAIND.csedit();
        PAYAIND.fillcombo d = new PAYAIND.fillcombo();
        PAYAIND.fill_datagride fill1 = new PAYAIND.fill_datagride();

        private void frm_all_object_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 100;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Linen; 
        }
        public void coding()
        {
            try
            {
                if (chekbox_showall.Checked) cod = "-";
                else if (checkBox4.Checked)
                {
                    cod_devic = source.cod_of_device(combo_device_name.Text).Trim();
                    cod = cod_devic + "-";
                }
                else if (!checkBox1.Checked)
                {
                    cod_devic = source.cod_of_device(combo_device_name.Text).Trim();
                    cod = cod_devic + "-" + combo_device_no.Text;
                }
                else if (!checkBox2.Checked)
                {
                    cod = combo_set1_name.SelectedValue.ToString().Trim();
                }
               
             else if (!checkBox3.Checked)
                {

                    {
                        cod = combo_set2_name.SelectedValue.ToString().Trim();
                    }
                }
                else
                {
                    cod = comboset3.SelectedValue.ToString().Trim();
                }
     
            }
            catch { }
        }
        DataTable dt = new DataTable();
        private void filldatagrid()
        {
          //  cod = source.finalcod("01", combo_device_name.Text, combo_device_no.Text, combo_set1_name.Text, combo_set2_name.Text, "");
          //  cod = cod.Substring(3, 13);
         bindingSource1.DataSource   = fill.allobject1(checkBox_showkey.Checked, cod, textBoxX1.Text);
         dataGridView1.DataSource =bindingSource1 ;
         bindingNavigator1.BindingSource = bindingSource1;          
         headernamedatagrid();
        filtering(); 
        }
        private void filtering()
        {
            coding();
            if (typefilter == 0)
            {
                bindingSource1.Filter = "  xcod like '%" + cod + "%' ";
                bindingSource1.Filter += " AND xname like '" + textBoxX1.Text + "%'";
            }

            if (typefilter == 1)
            { bindingSource1.Filter = filterstring;
                bindingSource1.Filter += " AND xcod like '%" + cod + "%' ";
            }
            if (typefilter == 2)
            {
                 bindingSource1.Filter = filterstring;
                bindingSource1.Filter += " AND xcod like '%" + cod + "%' ";
                bindingSource1.Filter += " AND xname like '" + textBoxX1.Text + "%'";
            }
            if (checkBox_showkey.Checked)
                bindingSource1.Filter += " AND oloaviyat = 'بالا' ";
            if (comboBoxEx1.SelectedIndex == 1)
            {
                bindingSource1.Filter += " AND xisbuilding = 1";

            }
            if (comboBoxEx1.SelectedIndex == 2)
            {
                bindingSource1.Filter += " AND xisbuilding = 0";
            }
          
            if (comboBoxEx2.SelectedIndex == 1)
            {
                bindingSource1.Filter += " and xcod like '%E'";
            }
            if (comboBoxEx2.SelectedIndex == 2)
            {
                bindingSource1.Filter += " and xcod like '%M'";
            }

            dataGridView1_CellClick(null, null);
            counting();
        }
        private void counting()
        {           
            int sum;
            sum = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                try
                {
                    sum = sum + Convert.ToInt32(r.Cells["count"].Value.ToString());
                }
                catch { }
            }
            label10.Text = sum.ToString();
        }
        private void headernamedatagrid()
        {
           // try
            {
                dataGridView1.Columns["xcod"].HeaderText = "کد قطعه";
                dataGridView1.Columns["xname"].HeaderText = "نام قطعه";                
                dataGridView1.Columns["xdetails"].HeaderText = "جزئیات قطعه";
                dataGridView1.Columns["count"].HeaderText = "تعداد";
                dataGridView1.Columns["xnamedevice"].HeaderText = "نام دستگاه";
                dataGridView1.Columns["xnumber"].HeaderText = "شماره دستگاه";
                dataGridView1.Columns["xnameset1"].HeaderText = "زیر مجموعه اصلی";
                dataGridView1.Columns["xnameset2"].HeaderText = "1زیر مجموعه فرعی";
                dataGridView1.Columns["xnameset3"].HeaderText = "زیر مجموعه فرعی2";
                dataGridView1.Columns["oloaviyat"].HeaderText = "اولویت قطعه";
                dataGridView1.Columns["xrowid"].HeaderText = "شماره قطعه";
                dataGridView1.Columns["xisbuilding"].HeaderText = "ساختنی ؟";               
                dataGridView1.Columns["xnameset1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns["xnameset2"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["xnameset3"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;                
                dataGridView1.Columns["xname"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["xcod"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["xnumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["xrowid"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                dataGridView1.Columns["oloaviyat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns["count"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns["xdetails"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["xnamedevice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
             if (dataGridView1.Columns["xdetails"].Width < 100)
               {
                  dataGridView1.Columns["xdetails"].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                  dataGridView1.Columns["xdetails"].Width = 150;
               }
            }
            //catch { }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void chekbox_showall_CheckedChanged(object sender, EventArgs e)
        {
            if (chekbox_showall.Checked == false)
            {if (!checkBox1.Checked)
                splitContainer1.SplitterDistance = 160;
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
            else { groupBox1.Visible = false;  splitContainer1.SplitterDistance = 100; filtering(); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {if (!checkBox2.Checked)
                splitContainer1.SplitterDistance = 210;
                groupBox2.Visible = true;
                changsource_comboset1();

            }
            else { groupBox2.Visible = false; splitContainer1.SplitterDistance = 160; }
            filtering();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                groupBox3.Visible = true;
                changsource_comboset2(); splitContainer1.SplitterDistance = 260;
            }
            else { groupBox3.Visible = false; splitContainer1.SplitterDistance = 210; }
            filtering();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.frmcodingobjects f = new frmcodingobjects();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                comboBoxEx1.SelectedIndex = 0;
                comboBoxEx2.SelectedIndex = 0;
                btnunfilter_Click(null, null);
                
            }
            catch { }
            filldatagrid();
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////
        /// </summary>
        private void changsource_combono()
        {   combo_device_no.DataSource = source.fillcombono(combo_device_name.Text);
            combo_device_no.SelectedIndex = 0;
        }

        private void combo_device_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            changsource_combono();
            combo_device_no_SelectedIndexChanged(null, null);

        }
        static string     cod_devic;

        static string cod = "";

        private void combo_device_no_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
            checkBox1_CheckedChanged(null, null); 
        }
        private void changsource_comboset1()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            string s = source.cod_of_device(combo_device_name.Text).Trim() + "-" + combo_device_no.Text;
            combo_set1_name.DataSource = source.fillcombo_set1(s);
            combo_set1_name.DisplayMember = "xnameset1";
            combo_set1_name.ValueMember = "xcod";
           try
            {
                combo_set1_name.SelectedIndex = 0;
                combo_set1_name_SelectedIndexChanged(null, null); }
            catch { }

        }

        private void combo_set1_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            checkBox2_CheckedChanged(null, null);
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
             checkBox3_CheckedChanged(null, null);
        }

        private void checkBox_showkey_CheckedChanged(object sender, EventArgs e)
        {
            filtering();
        }

              private void filteringobjects(object sender, EventArgs e)
        {
            if (typefilter == 1) typefilter = 2;
            filtering();
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string cod;
            string name;
            try
            {
                 cod = dataGridView1.CurrentRow.Cells["xcod"].Value.ToString();
                 name = dataGridView1.CurrentRow.Cells["xname"].Value.ToString();
                
                 DialogResult key =FarsiMessageBox.FMessageBox.Show("آیا مطمئنید که می خواهید قطعه "+name + "حذف شود", "حذف؟", FarsiMessageBox.FMessageBoxButtons.YesNo);
                 if (key == DialogResult.Yes)
                 {
                     insertsource.deletfromallobject(cod);
                     bindingSource1.RemoveCurrent();
                 }
            }
            catch { }
            filteringobjects(null, null);
          

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                groupBox4.Visible = true;
                changsource_comboset3(); splitContainer1.SplitterDistance = 310;
            }
            else { groupBox4.Visible = false; splitContainer1.SplitterDistance = 260; }
            filtering();
        }

        private void changsource_comboset3()
        {
            PAYAIND.fillcombo source = new PAYAIND.fillcombo();
            comboset3.DataSource = source.fillcombo_set3(combo_set2_name.SelectedValue.ToString());
            comboset3.DisplayMember = "xnameset3";
            comboset3.ValueMember = "xcodfinalset3";
            try
            {
                comboset3.SelectedIndex = 0;
            }
            catch { }
            combo_set3_name_SelectedIndexChanged(null, null);
        }

        private void combo_set3_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtering();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Report.SendReport c = new Report.SendReport();
            PAYAIND.csshamsidateandtime cs= new PAYAIND.csshamsidateandtime();
            c.SetParam("datenow",cs.calcshmsidate() );
            frmreportviewer f = new frmreportviewer();
            PAYADATA.coding.dsallobject ds= new PAYADATA.coding.dsallobject();
            object[] a= new object[10];
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                for (int i = 1; i <= 10; i++)
                {
                    a[i-1] = r.Cells[i].Value;
                }
                ds.allobject.Rows.Add(a);
            } 
           f.rpt= c.GetReport(ds, "crallobject");
           f.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form.coding.frmeditefinalobject f = new coding.frmeditefinalobject();
            f.lblcod.Text = dataGridView1.Rows[e.RowIndex].Cells["xcod"].Value.ToString();
            f.lblname.Text = dataGridView1.Rows[e.RowIndex].Cells["xname"].Value.ToString();
            f.usnumericupdown1.Value =Convert.ToInt32( dataGridView1.CurrentRow.Cells["count"].Value.ToString());
            f.comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["oloaviyat"].Value.ToString();
         
            DialogResult key = f.ShowDialog();
            if (key == DialogResult.OK)
            {
                dataGridView1.Rows[e.RowIndex].Cells["count"].Value = f.usnumericupdown1.Value.ToString();
                dataGridView1.Rows[e.RowIndex].Cells["oloaviyat"].Value = f.comboBox1.Text;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                labelX1.Text = dataGridView1.Rows[e.RowIndex].Cells["xname"].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["xnameset3"].Value.ToString() != "فاقد مجموعه")
                    labelX1.Text += " از " + dataGridView1.Rows[e.RowIndex].Cells["xnameset3"].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["xnameset2"].Value.ToString() != "فاقد مجموعه")
                    labelX1.Text += " از " + dataGridView1.Rows[e.RowIndex].Cells["xnameset2"].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["xnameset1"].Value.ToString() != "فاقد مجموعه")
                    labelX1.Text += " از " + dataGridView1.Rows[e.RowIndex].Cells["xnameset1"].Value.ToString();
               labelX1.Text+=     " از  " + dataGridView1.Rows[e.RowIndex].Cells["xnamedevice"].Value.ToString() +
                    " شماره  " + dataGridView1.Rows[e.RowIndex].Cells["xnumber"].Value.ToString();
            }
            catch { labelX1.Text = "نام قطعه"; }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            typefilter = 1;
            btnfilter.Enabled = false;
            btnunfilter.Enabled = true;
            filterstring = "xname like '%" + textBoxX1.Text + "%'  ";
            filtering();
        }

        private void btnunfilter_Click(object sender, EventArgs e)
        {
            typefilter = 0;
            btnfilter.Enabled = true;
            btnunfilter.Enabled = false;
           filterstring = "xname like '%" + ""+ "%'  ";
            filtering();
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            form.coding.frm_all_set_for_view f = new coding.frm_all_set_for_view();
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PAYAIND.csexporttoexcell excell = new PAYAIND.csexporttoexcell();

             excell.exportexcel(dataGridView1);
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
           /* Report.SendReport c = new Report.SendReport();
            PAYAIND.csshamsidateandtime cs = new PAYAIND.csshamsidateandtime();
            c.SetParam("datenow", cs.calcshmsidate());
            frmreportviewer f = new frmreportviewer();
            PAYADATA.coding.dsallobject ds = new PAYADATA.coding.dsallobject();
            object[] a = new object[10];
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                for (int i = 1; i <= 10; i++)
                {
                    a[i - 1] = r.Cells[i].Value;
                }

                ds.allobject.Rows.Add(a);
            }
            f.rpt = c.GetReport(ds, "Crp");
            f.ShowDialog();
            */
        }
    }
}
