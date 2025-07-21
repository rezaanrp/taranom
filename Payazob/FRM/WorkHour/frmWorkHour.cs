using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.WorkHour
{
    public partial class frmWorkHour : Form
    {
        public frmWorkHour(string Section)
        {
            InitializeComponent();
            Sec = Section;
        }
        string Sec = "";
        DAL.WorkHour.DataSet_WorkHour.SlWorkHourDataTable dt_W;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            dt_W = new BLL.WorkHour.csWorkHour().SlWorkHour(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_W;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator_D.BindingSource = bindingSource1;
            generate();
        }

        private void toolStripButton_D_Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.WorkHour.csWorkHour cs = new BLL.WorkHour.csWorkHour();
                MessageBox.Show(cs.UdWorkHour(dt_W), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt_W = cs.SlWorkHour(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                bindingSource1.DataSource = dt_W;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator_D.BindingSource = bindingSource1;
                generate();
            }
        }
        void generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_W.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
           
            dt_W.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView1.Columns["x_"].Visible = false;
            if (Sec == "PL")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {

                    item.ReadOnly = true;
                    item.Cells["xConfirm"].ReadOnly = false;
                }
            }
            else if (Sec == "HR")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((bool)item.Cells["xConfirm"].Value == true)
                            item.ReadOnly = true;

                }
            }

            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
           // dataGridView1.Columns["xPerCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    fr.StartPosition = FormStartPosition.CenterParent;
                    fr.ShowDialog();
                    if (fr.accept)
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                        dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex + 1, e.RowIndex];
                    }

                }

            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xConfirm"].Index)
                if ((bool)dataGridView1["xConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xApprove_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xApprove_", e.RowIndex].Value = DBNull.Value;
        }
    }
}
