using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.OverTime
{
    public partial class frmOverTimeReg : Form
    {
        public frmOverTimeReg()
        {
            InitializeComponent();
            dataGridView2.AllowUserToAddRows = true;
            toolStripButton_Add.Visible = true;
            uc_TextBoxDate1.Text = BLL.csshamsidate.shamsidate;
            
        }
        DAL.OverTime.DataSet_OverTime.mOverTimeDataTable dt_O;
       
        string PerID_ = "0";

        void ShowDataPerson()
        {
            bindingSource3.DataSource = new BLL.Person.csPersonInfo().mPersonInfoSec(BLL.authentication.x_);
            dataGridView3.DataSource = bindingSource3;
        }

        void Show_Data()
        {

            BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
            dt_O = new DAL.OverTime.DataSet_OverTime.mOverTimeDataTable();
            bindingSource2.DataSource = dt_O;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator1.BindingSource = bindingSource2;

            Generate();

        }

        void Generate()
        {
            dt_O.xPerCodeColumn.DefaultValue = int.Parse(PerID_ == "" ? "0" : PerID_);
            dt_O.xSupplierColumn.DefaultValue = false;
            dt_O.xApproveColumn.DefaultValue = false;
       //   dt_O.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_O.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView2.Columns["xApprove"].HeaderText = "تایید نهایی";
            dataGridView2.Columns["xSupplier"].HeaderText = "تایید ثبت";
            dataGridView2.Columns["xReason"].HeaderText = "علت اضافه کاری";
            dataGridView2.Columns["xReason"].Width = 200;
            dataGridView2.Columns["x_"].Visible = false;

            dataGridView2.Columns["xPerCode"].ReadOnly = true;

            dataGridView2.Columns["xBeginTimeOver1"].ReadOnly = true;
            dataGridView2.Columns["xEndTimeOver1"].ReadOnly = true;
            dataGridView2.Columns["xBeginTimeOver2"].ReadOnly = true;
            dataGridView2.Columns["xEndTimeOver2"].ReadOnly = true;

            dataGridView2.Columns["xSupplier"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xApprove"].Visible = false;
            dataGridView2.Columns["xApprove_"].Visible = false;

            dataGridView2.Columns["xManager"].Visible = false;
            dataGridView2.Columns["xManager_"].Visible = false;
            dataGridView2.Columns["xPerCode"].Visible = true;

            BLL.csshamsidate csd = new BLL.csshamsidate();

            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                if (item.Cells["xDate"].Value == DBNull.Value || item.Cells["xDate"].Value == null)
                    continue;
                if (csd.CompareDate(item.Cells["xDate"].Value.ToString(), BLL.csshamsidate.shamsidate))
                {
                    item.Cells["xBeginTimeOver1"].ReadOnly = false;
                    item.Cells["xEndTimeOver1"].ReadOnly = false;
                    item.Cells["xBeginTimeOver1"].Style.BackColor = Color.LightGreen;
                    item.Cells["xEndTimeOver1"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    item.Cells["xBeginTimeOver2"].ReadOnly = false;
                    item.Cells["xEndTimeOver2"].ReadOnly = false;
                    item.Cells["xBeginTimeOver2"].Style.BackColor = Color.LightGreen;
                    item.Cells["xEndTimeOver2"].Style.BackColor = Color.LightGreen;

                }
            }

        }
      
        private void frmOverTime_Load(object sender, EventArgs e)
        {
            BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
            dt_O = new DAL.OverTime.DataSet_OverTime.mOverTimeDataTable();
            bindingSource2.DataSource = dt_O;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator1.BindingSource = bindingSource2;
            Generate();

            bindingSource3.DataSource = new BLL.Person.csPersonInfo().mPersonInfoSec(BLL.authentication.x_);
            dataGridView3.DataSource = bindingSource3;

            ShowDataPerson();

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
            dt_O = new DAL.OverTime.DataSet_OverTime.mOverTimeDataTable();
            bindingSource2.DataSource = dt_O;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator1.BindingSource = bindingSource2;
            Generate();


            ShowDataPerson();

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.Columns["xDate"].Index == e.ColumnIndex)
            {

                Validation.VDate vd = new Validation.VDate();
                if (!vd.ValidationDate(dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString()))
                {
                    dataGridView2["xDate", e.RowIndex].Style.BackColor = Color.Red;
                    dataGridView2["xDate", e.RowIndex].Style.ForeColor = Color.White;
                    //dataGridView2["xDate", e.RowIndex].Value = null;
                }
                else
                {
                    dataGridView2["xDate", e.RowIndex].Style.BackColor = Color.White;
                    dataGridView2["xDate", e.RowIndex].Style.ForeColor = Color.Black;
                }
                dataGridView2["xBeginTimeOver1", e.RowIndex].Value = null;
                dataGridView2["xEndTimeOver1", e.RowIndex].Value = null;
                dataGridView2["xBeginTimeOver2", e.RowIndex].Value = null;
                dataGridView2["xEndTimeOver2", e.RowIndex].Value = null;
                if (dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue == DBNull.Value
                     || dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue == null)
                    return;
                BLL.csshamsidate cs = new BLL.csshamsidate();

                dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString();


                if (cs.CompareDate(dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString()
                     , BLL.csshamsidate.shamsidate))
                {
                    dataGridView2["xBeginTimeOver1", e.RowIndex].ReadOnly = false;
                    dataGridView2["xEndTimeOver1", e.RowIndex].ReadOnly = false;
                    dataGridView2["xBeginTimeOver1", e.RowIndex].Style.BackColor = Color.LightGreen;
                    dataGridView2["xEndTimeOver1", e.RowIndex].Style.BackColor = Color.LightGreen;

                    dataGridView2["xBeginTimeOver2", e.RowIndex].ReadOnly = true;
                    dataGridView2["xEndTimeOver2", e.RowIndex].ReadOnly = true;
                    dataGridView2["xBeginTimeOver2", e.RowIndex].Style.BackColor = Color.White;
                    dataGridView2["xEndTimeOver2", e.RowIndex].Style.BackColor = Color.White;

                }
                else
                {
                    int Ovr = int.Parse(new BLL.GenGroup.csGenGroup().SlGenGroup("OVRT").Rows[0]["xName"].ToString());

                    bool flagDate = false;
                    for (int i = 1; i < Ovr; i++)
                    {
                        if (cs.previousDay(i) == dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString())
                        {
                            flagDate = true;
                        }
                    }
                    if (flagDate
                         
                         || dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString() == BLL.csshamsidate.shamsidate)
                    {
                        dataGridView2["xBeginTimeOver2", e.RowIndex].ReadOnly = false;
                        dataGridView2["xEndTimeOver2", e.RowIndex].ReadOnly = false;
                        dataGridView2["xBeginTimeOver2", e.RowIndex].Style.BackColor = Color.LightGreen;
                        dataGridView2["xEndTimeOver2", e.RowIndex].Style.BackColor = Color.LightGreen;

                        dataGridView2["xBeginTimeOver1", e.RowIndex].ReadOnly = true;
                        dataGridView2["xEndTimeOver1", e.RowIndex].ReadOnly = true;
                        dataGridView2["xBeginTimeOver1", e.RowIndex].Style.BackColor = Color.White;
                        dataGridView2["xEndTimeOver1", e.RowIndex].Style.BackColor = Color.White;


                    }
                    else
                    {
                        dataGridView2["xBeginTimeOver2", e.RowIndex].ReadOnly = true;
                        dataGridView2["xEndTimeOver2", e.RowIndex].ReadOnly = true;
                        dataGridView2["xBeginTimeOver2", e.RowIndex].Style.BackColor = Color.LightGray;
                        dataGridView2["xEndTimeOver2", e.RowIndex].Style.BackColor = Color.LightGray;
                        dataGridView2["xBeginTimeOver1", e.RowIndex].ReadOnly = true;
                        dataGridView2["xEndTimeOver1", e.RowIndex].ReadOnly = true;
                        dataGridView2["xBeginTimeOver1", e.RowIndex].Style.BackColor = Color.White;
                        dataGridView2["xEndTimeOver1", e.RowIndex].Style.BackColor = Color.White;
                    }

                }
            }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView2.Rows[e.RowIndex].IsNewRow && dataGridView2.Columns["xDate"].Index == e.ColumnIndex && (int)dataGridView2["x_", e.RowIndex].Value > 0)
            {
                e.Cancel = true;
            }
            if (!dataGridView2.Rows[e.RowIndex].IsNewRow && dataGridView2.Columns["xApprove"].Index != e.ColumnIndex && dataGridView2["xApprove", e.RowIndex].Value != DBNull.Value
                && (bool?)dataGridView2["xApprove", e.RowIndex].Value == true)
            {
                e.Cancel = true;
            }
        }

        private void frmOverTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView2.IsCurrentCellInEditMode)
                if (dataGridView2.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                    dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width += 5;
                else if (dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
                    dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width -= 5;
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BLL.csshamsidate css = new BLL.csshamsidate();

            if (css.CompareDate(uc_TextBoxDate1.Text, BLL.csshamsidate.shamsidate))
            {
                if (uc_TextBoxDate1.accept)
                {

                    DataRow r1 = dt_O.NewRow();
                   
                    r1["xDate"] = uc_TextBoxDate1.Text;
                    r1["xSupplier"] = true;
                    r1["xSupplier_"] = BLL.authentication.x_;
                    r1["xPerCode"] = dataGridView3["xPerID", e.RowIndex].Value.ToString();

                    r1["xBeginTimeOver1"] = mtxt_From.Text;
                    r1["xEndTimeOver1"] = mtxt_To.Text;

                    r1["xBeginTimeOver2"] = "";
                    r1["xEndTimeOver2"] = "";

                    r1["xSupplier"] = false;
                    r1["xApprove"] = false;
                    r1["xManager"] = false;




                    r1["xReason"] = uc_txtBox1.Text;

                    dataGridView3.Rows.Remove(dataGridView3.Rows[e.RowIndex]);
                    dt_O.Rows.Add(r1);
                    bindingSource2.DataSource = dt_O;
                    dataGridView2.DataSource = bindingSource2;
                    bindingNavigator1.BindingSource = bindingSource2;
                    dt_O.AcceptChanges();

                    dataGridView2.EndEdit();

                    DataTable dt_t = new BLL.Person.csPersonInfo().mPersonInfoSec(BLL.authentication.x_);
                    foreach (DataGridViewRow item in dataGridView2.Rows)
                    {
                        if (item.IsNewRow)
                            continue;
                        item.Cells["NameFamily"].Value = dt_t.Select("xPerID = " + item.Cells["xPerCode"].Value.ToString()) != null ? dt_t.Select("xPerID = " + item.Cells["xPerCode"].Value.ToString())[0]["PerName"].ToString() : "";
                    }
                }
            }
            else
            {
                int Ovr = int.Parse(new BLL.GenGroup.csGenGroup().SlGenGroup("OVRT").Rows[0]["xName"].ToString());

                bool flagDate = false;
                for (int i = 1; i < Ovr; i++)
                {
                    if (css.previousDay(i) == uc_TextBoxDate1.Text)
                    {
                        flagDate = true;
                    }
                }
                if (flagDate
                  
                         || uc_TextBoxDate1.Text == BLL.csshamsidate.shamsidate)
                {
                    if (uc_TextBoxDate1.accept)
                    {

                        DataRow r1 = dt_O.NewRow();
                        r1["xDate"] = uc_TextBoxDate1.Text;
                        r1["xSupplier"] = true;
                        r1["xSupplier_"] = BLL.authentication.x_;
                        r1["xPerCode"] = dataGridView3["xPerID", e.RowIndex].Value.ToString();

                        r1["xBeginTimeOver1"] = "";
                        r1["xEndTimeOver1"] = "";

                        r1["xBeginTimeOver2"] = mtxt_From.Text;
                        r1["xEndTimeOver2"] = mtxt_To.Text;

                        r1["xSupplier"] = false;
                        r1["xApprove"] = false;
                        r1["xManager"] = false;

          
                        r1["xReason"] = uc_txtBox1.Text;

                        dataGridView3.Rows.Remove(dataGridView3.Rows[e.RowIndex]);
                        dt_O.Rows.Add(r1);
                        bindingSource2.DataSource = dt_O;
                        dataGridView2.DataSource = bindingSource2;
                        bindingNavigator1.BindingSource = bindingSource2;
                        dt_O.AcceptChanges();

                        dataGridView2.EndEdit();

                        DataTable dt_t = new BLL.Person.csPersonInfo().mPersonInfoSec(BLL.authentication.x_);
                        foreach (DataGridViewRow item in dataGridView2.Rows)
                        {
                            if (item.IsNewRow)
                                continue;
                            item.Cells["NameFamily"].Value = dt_t.Select("xPerID = " + item.Cells["xPerCode"].Value.ToString()) != null ? dt_t.Select("xPerID = " + item.Cells["xPerCode"].Value.ToString())[0]["PerName"].ToString() : "";
                        }
                    }

                }



            }

        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView2.EndEdit();
            BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
            dt_O.AcceptChanges();
            MessageBox.Show(cs.UdOverTimeReg(dt_O), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }



    }
}
