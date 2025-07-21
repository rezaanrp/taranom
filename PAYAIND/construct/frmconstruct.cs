using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAYAZOBNET.form.construct
{
    public partial class frmconstruct : Form
    {
        public frmconstruct()
        {
            InitializeComponent();
        }
        PAYADATA.DataSetrequestconstruct.requestconstructheaderDataTable datatableheader;
        PAYADATA.DataSetrequestconstruct.requestconstructDataTable datatable;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PAYAIND.csrequsetconstruct cr = new PAYAIND.csrequsetconstruct();
            datatableheader = cr.selectrequestheaderbydate(fromdate.Text,todate.Text);
            bindingSource1.DataSource = datatableheader;
            dataGridView1.DataSource = bindingSource1;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if ((int)r.Cells["xchecked"].Value == 1)
                {
                    r.Cells["xcheck"].Value= false;
                }
                else  r.Cells["xcheck"].Value= true;
            }
        }
        bool editable = true;
        private void frmconstruct_Load(object sender, EventArgs e)
        {
            allowuser cs2 = new allowuser();
            if (!cs2.allowuserforobject("construct", true))
            {
                editable = false;
            }
            PAYAIND.fillcombo csfill = new PAYAIND.fillcombo();
            PAYAIND.csshamsidateandtime cs = new PAYAIND.csshamsidateandtime();
            todate.Text = cs.calcshmsidate();
            fromdate.Text = cs.previousDay(7);
            DataGridViewComboBoxColumn txtapplicator = (DataGridViewComboBoxColumn)dataGridView1.Columns["xidreqester"];
            PAYAIND.cslogin cslogin = new PAYAIND.cslogin();
            txtapplicator.DataSource = cslogin.selectuser();
            txtapplicator.DisplayMember = "name";
            txtapplicator.ValueMember = "xid";
            PAYAIND.csrequsetconstruct c = new PAYAIND.csrequsetconstruct();
            DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)dataGridView1.Columns["xchecked"];
            DataGridViewComboBoxColumn combo2 = (DataGridViewComboBoxColumn)dataGridView2.Columns["xstate"];
            combo.DataSource = c.stateofrequest();            
            combo.DisplayMember = "xname";
            combo.ValueMember = "xid";
            combo2.DataSource = c.stateofrequest();
            combo2.DisplayMember = "xname";
            combo2.ValueMember = "xid";
            DataGridViewComboBoxColumn combodevice = (DataGridViewComboBoxColumn)dataGridView2.Columns["xmasraf"];
            combodevice.DataSource = csfill.fillcombonamedevice();
            combodevice.DisplayMember = "xnamedevice";
            combodevice.ValueMember = "xid";
            DataGridViewComboBoxColumn combo3 = (DataGridViewComboBoxColumn)dataGridView2.Columns["xunit"];
            combo3.DataSource = c.selectunit();
            combo3.DisplayMember = "xname";
            combo3.ValueMember = "xid";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try //if (dataGridView1.Columns[e.ColumnIndex].Name == "xcheck")
            {
                if (!(bool)dataGridView1.CurrentRow.Cells["xcheck"].Value == true)
                {
                    dataGridView1.CurrentRow.Cells["xchecked"].Value = 2;
                    PAYAIND.csactioncenter cc = new PAYAIND.csactioncenter();
                    cc.eventsolved((int)dataGridView1.CurrentRow.Cells["xidreqester"].Value, (int)dataGridView1.CurrentRow.Cells["xid"].Value, (string)dataGridView1.CurrentRow.Cells["xdate"].Value, (string)dataGridView1.CurrentRow.Cells["xtime"].Value);

                }
                else dataGridView1.CurrentRow.Cells["xchecked"].Value = 1;
                int id = (int)dataGridView1.CurrentRow.Cells["xid"].Value;
                PAYAIND.csrequsetconstruct c = new PAYAIND.csrequsetconstruct();
                datatable = c.selectrequestbyidheader(id);
                bindingSource2.DataSource = datatable;
                dataGridView2.DataSource = bindingSource2;
            }
            catch { }
          
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (editable)
            {
                this.Validate();
                PAYAIND.csrequsetconstruct cs = new PAYAIND.csrequsetconstruct();
                cs.saveupdateheader(datatableheader);
            }

        }

        private void saveToolStripButton1_Click(object sender, EventArgs e)
        {
            if (editable)
            {
                this.Validate();
                PAYAIND.csrequsetconstruct cs = new PAYAIND.csrequsetconstruct();
                cs.saveupdaterequest(datatable);
            }
        }

        private void btndetailsconstruct_Click(object sender, EventArgs e)
        {
            if (!editable) { return; }
            if (dataGridView1.Rows.Count < 1) return;
            if (dataGridView2.Rows.Count > 0)
            {
                form.construct.frmconsructdetails f = new frmconsructdetails();
                f.textname.Text = dataGridView2.CurrentRow.Cells["xname"].Value.ToString();
                try
                {
                    f.radioButtoninternalmake.Checked = (bool)dataGridView2.CurrentRow.Cells["xisInternal_build"].Value;
                }
                catch { f.radioButtoninternalmake.Checked = true; }
                f.radioButton.Checked = !f.radioButtoninternalmake.Checked;
                try
                {
                    f.checkBox3ismap.Checked = (bool)dataGridView2.CurrentRow.Cells["xisneedmap"].Value;
                }
                catch { f.checkBox3ismap.Checked = false; }
                try
                {
                    f.checkBoxhistory.Checked = (bool)dataGridView2.CurrentRow.Cells["xisbackwardContractor"].Value;
                }
                catch { f.checkBoxhistory.Checked = false; }
                try
                {
                    f.checkBoxval.Checked = (bool)dataGridView2.CurrentRow.Cells["xisevaluationContractor"].Value;
                }
                catch { f.checkBoxval.Checked = false; }
                if (dataGridView2.CurrentRow.Cells["xadressContractor"].Value != null)
                    f.textBoxadress.Text = dataGridView2.CurrentRow.Cells["xadressContractor"].Value.ToString();
                else f.textBoxadress.Text = "";
                try
                {
                    if (dataGridView2.CurrentRow.Cells["xdateorder"].Value != null)
                        f.textboxdete1.Text = dataGridView2.CurrentRow.Cells["xdateorder"].Value.ToString();
                    else f.textboxdete1.Text = "";
                }
                catch { f.textboxdete1.Text = ""; }
                try
                {
                    f.ucselectdistancetime1.selecteddistansbyday = (int)dataGridView2.CurrentRow.Cells["xdayfordoneorder"].Value;
                }
                catch { f.ucselectdistancetime1.selecteddistansbyday = 7; }
                f.xidrequest = (int)dataGridView2.CurrentRow.Cells["xid_"].Value;
                f.ShowDialog();
                dataGridView1_CellClick(null, null);
            }

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btndetailsconstruct_Click(null,null);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PAYADATA.DataSetrequestconstruct.requestconstructreciveobjectDataTable dt = new PAYADATA.DataSetrequestconstruct.requestconstructreciveobjectDataTable();

            if (dataGridView1.Rows.Count < 1) return;
            if (dataGridView2.Rows.Count > 0)
            {
                form.construct.frmreciveobject f = new frmreciveobject();
                f.xidrequest = (int)dataGridView2.CurrentRow.Cells["xid_"].Value;
                f.textname.Text = dataGridView2.CurrentRow.Cells["xname"].Value.ToString();
                f.textorderdate.Text = dataGridView1.CurrentRow.Cells["xdate"].Value.ToString();
                f.textcountorder.Text = dataGridView2.CurrentRow.Cells["xcount"].Value.ToString();
                PAYAIND.csrequsetconstruct cs = new PAYAIND.csrequsetconstruct();
                dt=  cs.selectconstructreciveobject(f.xidrequest);
                try
                {
                    f.textcountok.text = dt.Select(c => c.xcountobjectok).Single().ToString();
                    f.textcountrecive.text = dt.Select(c => c.xcountreciveobject).Single().ToString();
                    f.txtrecivedate.Text = dt.Select(c => c.xdaterecive).Single().ToString();
                }
                catch {
                    f.textcountok.text = "0";
                    f.textcountrecive.text ="0";
                    f.txtrecivedate.Text = "";
                }
                f.ShowDialog();
            }
        }
    }
}
