using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmMeltTestResult : Form
    {
        public frmMeltTestResult()
        {
            InitializeComponent();
        }

        private void frmMeltTestResult_Load(object sender, EventArgs e)
        {
            BLL.csElement el = new BLL.csElement();
            filldatagirdView(el.SelectElement());
            BLL.csMaterial melt = new BLL.csMaterial();
            uc_cmbAuto_meltname.DataSource = melt.SelectMeltName(chb_scrab.Checked);
            uc_cmbAuto_meltname.DisplayMember = "xMaterialName";
            uc_cmbAuto_meltname.ValueMember = "x_";
            uc_cmbAuto_meltname.SelectedIndex = -1;

            BLL.csCompony cm = new BLL.csCompony();
            uc_cmbAutoxSupplier.uc_cmbAuto1.DataSource = cm.SelectSupplier();
            uc_cmbAutoxSupplier.uc_cmbAuto1.DisplayMember = "xComponyName";
            uc_cmbAutoxSupplier.uc_cmbAuto1.ValueMember = "x_";
            uc_cmbAutoxSupplier.uc_cmbAuto1.SelectedIndex = -1;

            uc_cmbAutoxSupplier.ParamName = new string[] { "xComponyName" };
            uc_cmbAutoxSupplier.ParamValue = new string[] { "نام شرکت" };
            uc_cmbAutoxSupplier.ParamHide = new string[] { "x_", "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
               "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};

            }

        void filldatagirdView(DataTable dt)
        {
            dataGridView_Befor.DataSource = dt;
            this.dataGridView_Befor.Columns.Add("ElementNumber", "مقدار");
            this.dataGridView_Befor.Columns["ElementNumber"].ValueType = typeof(string);
            this.dataGridView_Befor.Columns["xNameElement"].ReadOnly = true;
            this.dataGridView_Befor.Columns["xNameElement"].HeaderText = "عنصر";
            this.dataGridView_Befor.Columns["x_"].Visible = false;
            dataGridView2.DataSource = dt;
            this.dataGridView2.Columns.Add("ElementNumber", "مقدار");
            this.dataGridView2.Columns["ElementNumber"].ValueType = typeof(string);
            this.dataGridView2.Columns["xNameElement"].ReadOnly = true;
            this.dataGridView2.Columns["xNameElement"].HeaderText = "عنصر";
            this.dataGridView2.Columns["x_"].Visible = false;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (mtxt_dateinspection.Text.Length < 10 || mtxt_EnterMelt.Text.Length < 10 || mtxt_MeltTest.Text.Length < 10)
            {
                MessageBox.Show("تاریخ ها را کامل وارد کنید.");
                return;
            }
            if (chb_scrab.Checked == true && (mtxt_ExperimentalScore.Text == "" || mtxt_maximumScore.Text == "" || mtxt_VisualScore.Text == "" || mtxt_gradeproduct.Text==""))
            {
                MessageBox.Show("فیلد ها کامل وارد کنید");
                    return;
            }
            if (chb_scrab.Checked == false && (mtxt_usage.Text == "" || mtxt_meltusage.Text == "" || txt_absorptionPrecent.Text == "")    )
            {
                MessageBox.Show("فیلد ها کامل وارد کنید");
                return;
            }
            if (uc_cmbAutoxSupplier.uc_cmbAuto1.SelectedIndex < 0 || uc_cmbAuto_meltname.SelectedIndex < 0)
            {
                MessageBox.Show("فیلد ها کامل وارد کنید");
                return;
            }
            
            byte accept = 0;
            if (rdb_accept.Checked)
                accept = 1;
            else if (rdb_conditioned.Checked)
                accept = 2;
            else if (rdb_deny.Checked)
                accept = 0;
            else
            {
                MessageBox.Show("نتیجه بررسی خود را وارد کنید");
                return;
            }
            csCheakTextbox ch = new csCheakTextbox();
            DataTable dt = new DataTable();
            dt.TableName = "MyTable";
            foreach (DataGridViewColumn col in dataGridView_Befor.Columns)
            {
                dt.Columns.Add(col.Name, col.ValueType);
            }
            foreach (DataGridViewRow gridRow in dataGridView_Befor.Rows)
            {
                if (gridRow.IsNewRow ||  gridRow.Cells["ElementNumber"].Value == null)
                    continue;

                DataRow dtRow = dt.NewRow();
                for (int i1 = 0; i1 < dataGridView_Befor.Columns.Count; i1++)
                {
                    dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);
                }
                gridRow.Cells["ElementNumber"].Value = null;
                dt.Rows.Add(dtRow);
            }
            DataTable dt2 = new DataTable();
            dt2.TableName = "MyTable2";
            if (!chb_scrab.Checked)
            {
                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {
                    dt2.Columns.Add(col.Name, col.ValueType);
                }
                foreach (DataGridViewRow gridRow in dataGridView2.Rows)
                {
                    if (gridRow.IsNewRow || gridRow.Cells["ElementNumber"].Value == null)
                        continue;
                    DataRow dtRow = dt2.NewRow();
                    for (int i1 = 0; i1 < dataGridView2.Columns.Count; i1++)
                    {
                        dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);
                    }
                    gridRow.Cells["ElementNumber"].Value = null;
                    dt2.Rows.Add(dtRow);
                }
            }
            BLL.csMeltTestResult me = new BLL.csMeltTestResult();
            int xscrabname_ =  (int)uc_cmbAuto_meltname.SelectedValue;
            int xsupplier_ = (int)uc_cmbAutoxSupplier.uc_cmbAuto1.SelectedValue;



            BLL.csRegisteringGroup rg = new BLL.csRegisteringGroup();

            bool approve = false;
            if (BLL.authentication.xApproveby_ == BLL.authentication.x_)
                approve = true;



            if (chb_scrab.Checked == true)

                 me.InsertMeltTestResult(xscrabname_, mtxt_EnterMelt.Text, mtxt_dateinspection.Text, mtxt_MeltTest.Text, txt_VisualCharacteristics.Text,
                     short.Parse(mtxt_VisualScore.textWithoutcomma == null ?"0": mtxt_VisualScore.textWithoutcomma ), short.Parse(mtxt_ExperimentalScore.textWithoutcomma == null ?"0":mtxt_ExperimentalScore.textWithoutcomma), short.Parse(mtxt_maximumScore.textWithoutcomma == null ?"0":mtxt_maximumScore.textWithoutcomma), accept,
                byte.Parse(mtxt_gradeproduct.textWithoutcomma == null ?"0":mtxt_gradeproduct.textWithoutcomma), true, approve, xsupplier_, 3, 0, 0, 0, chb_scrab.Checked, dt, dt2);

            else
                me.InsertMeltTestResult(xscrabname_, mtxt_EnterMelt.Text, mtxt_dateinspection.Text, mtxt_MeltTest.Text, txt_VisualCharacteristics.Text,
                               0, 0, 0, accept, 0, true, approve, xsupplier_, 3, int.Parse(mtxt_usage.textWithoutcomma == null ?"0":mtxt_usage.textWithoutcomma), int.Parse(mtxt_meltusage.textWithoutcomma == null ?"0":mtxt_meltusage.textWithoutcomma), decimal.Parse(txt_absorptionPrecent.Text), chb_scrab.Checked, dt, dt2);


            MessageBox.Show("ارسال با موفقیت انجام شد");
            mtxt_ExperimentalScore.Text = ""; mtxt_maximumScore.Text = ""; mtxt_VisualScore.Text = ""; mtxt_gradeproduct.Text = "";
            mtxt_usage.Text = ""; mtxt_meltusage.Text = ""; txt_absorptionPrecent.Text = "";
            txt_VisualCharacteristics.Text = "";

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            csCheakTextbox ch = new csCheakTextbox();
           if( ((System.Windows.Forms.DataGridView)(sender))[e.ColumnIndex, e.RowIndex].Value != null)
            if (!ch.IsNumber(((System.Windows.Forms.DataGridView)(sender))[e.ColumnIndex, e.RowIndex].Value.ToString()))
            { ((System.Windows.Forms.DataGridView)(sender))[e.ColumnIndex, e.RowIndex].Value = DBNull.Value; }
        }

        private void mtxt_VisualScore_Leave(object sender, EventArgs e)
        {
            if(mtxt_VisualScore.Text != "" && mtxt_ExperimentalScore.Text != "")
                lbl_sum.Text = "مجموع: " + (int.Parse(mtxt_VisualScore.textWithoutcomma == null ?"0":mtxt_VisualScore.textWithoutcomma) + int.Parse(mtxt_ExperimentalScore.textWithoutcomma == null ?"0":mtxt_ExperimentalScore.textWithoutcomma)).ToString();
        }

        private void chb_scrab_CheckedChanged(object sender, EventArgs e)
        {
            BLL.csMaterial meln = new BLL.csMaterial();
            uc_cmbAuto_meltname.DataSource = meln.SelectMeltName(chb_scrab.Checked);
            uc_cmbAuto_meltname.DisplayMember = "xMaterialName";
            uc_cmbAuto_meltname.ValueMember = "x_";
            pnl_m1.Enabled = !chb_scrab.Checked;
            dataGridView2.Enabled = !chb_scrab.Checked;
            pnl_s.Enabled = chb_scrab.Checked;
            mtxt_ExperimentalScore.Text = ""; mtxt_maximumScore.Text = ""; mtxt_VisualScore.Text = ""; mtxt_gradeproduct.Text = "";
            mtxt_usage.Text = ""; mtxt_meltusage.Text = ""; txt_absorptionPrecent.Text = "";
        }
    }
}
