using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.ControlPrj
{
    public partial class frmControlPrj : Form
    {
        /// <summary>
        /// admin = adm
        /// report = rep
        /// </summary>
        /// <param name="TypeUser"></param>
        public frmControlPrj(string TypeUser)
        {
            InitializeComponent();
            TpeUsr = TypeUser;
            if (TypeUser != "adm")
            {
                dataGridView1.ReadOnly = true;
                saveToolStripButton.Enabled = false;

            }
            if (TypeUser == "rep")
            {
                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;
                saveToolStripButton.Enabled = false;
                toolStripButton11.Enabled = false;
            }

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = csm.SlGenGroup("PRJTYP");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "نوع پروژه";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xType_";
            combobox_Type_.Name = "cmb_TypeProblem";
            //combobox_Type_.Width = 100;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Type_);


            DataGridViewComboBoxColumn combobox_xMan_ = new DataGridViewComboBoxColumn();
            combobox_xMan_.DisplayIndex = 4;
            combobox_xMan_.HeaderText = "مدیر پروژه";
            combobox_xMan_.DataSource = new BLL.authentication().NameOfUser();
            combobox_xMan_.DisplayMember = "NameAndFamily";
            combobox_xMan_.ValueMember = "x_";
            combobox_xMan_.DataPropertyName = "xMan_";
            combobox_xMan_.Name = "xMan_";
            combobox_xMan_.Width = 150;
            //   combobox_xSupplier_.ReadOnly = true;
            combobox_xMan_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_xMan_);


            dt_C = new DAL.ControlPrj.DataSet_ControlPrj.SlControlPrjDataTable();
            bindingSource1.DataSource = dt_C;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
            ShowDataD(-1);

        }

        string TpeUsr = "";
        DAL.ControlPrj.DataSet_ControlPrj.SlControlPrjDataTable dt_C;
        DAL.ControlPrj.DataSet_ControlPrj.SlControlPrjDetailsDataTable dt_D;

        void Generate()
        {
            dt_C.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_C.xDateStartColumn.DefaultValue = BLL.csshamsidate.shamsidate;

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;

            dataGridView1.Columns["xName"].HeaderText = "شرح پروژه";
            dataGridView1.Columns["xName"].Width = 200;
            //  dataGridView1.Columns["xType_"].HeaderText = "نوع پروژه";
            //  dataGridView1.Columns["xMan_"].HeaderText = "مدیر پروژه";
            //dataGridView1.Columns["xDateStart"].HeaderText = "تاریخ شروع";
            //dataGridView1.Columns["xDateEnd"].HeaderText = "تاریخ پایان";
            dataGridView1.Columns["xDateStartReal"].HeaderText = "تاریخ شروع واقعی";
            dataGridView1.Columns["xDateEndReal"].HeaderText = "تاریخ پایان واقعی";
            dataGridView1.Columns["xDatePredict"].HeaderText = "تاریخ پیشبینی پایان پروژه";
            dataGridView1.Columns["xDatePredict"].ReadOnly = true;
            dataGridView1.Columns["xDayDelay"].HeaderText = "تعداد روزتاخیر";
            dataGridView1.Columns["xPerformanceP"].HeaderText = "شاخص عملکرد P";
            dataGridView1.Columns["xSupplier_"].HeaderText = "ثبت کننده";
            dataGridView1.Columns["xEnd"].HeaderText = "پایان پروژه";

            dataGridView1.Columns["xDateStart"].DisplayIndex = 6;
            dataGridView1.Columns["xDateEnd"].DisplayIndex = 6;
            dataGridView1.Columns["xDateStartReal"].DisplayIndex = 6;
            dataGridView1.Columns["xDateEndReal"].DisplayIndex = 6;

        }

        void GenerateD()
        {
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xCntD_"].Visible = false;
            //dataGridView2.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView2.Columns["xDescription"].HeaderText = "شرح اقدامات";
            dataGridView2.Columns["xDescription"].Width = 400;
            dataGridView2.Columns["xPercent"].HeaderText = "درصد پیشرفت";
            dataGridView2.Columns["xRelationChart"].HeaderText = "بند مربوط به گانت چارت";
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            BLL.ControlPrj.csControlPrj css = new BLL.ControlPrj.csControlPrj();
            if (TpeUsr == "adm" || TpeUsr == "rep")
                dt_C = css.SlControlPrj(-1, uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            else
                dt_C = css.SlControlPrj(BLL.authentication.x_, uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);

            bindingSource1.DataSource = dt_C;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            if (TpeUsr != "adm")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells["xEnd"].Value != null && item.Cells["xEnd"].Value != DBNull.Value
                        && (bool)item.Cells["xEnd"].Value == true)
                    {
                        item.DefaultCellStyle.BackColor = Color.LawnGreen;
                        item.ReadOnly = true;
                    }
                }
            }
            Generate();
        }

        void ShowDataD(int x_)
        {
            BLL.ControlPrj.csControlPrj css = new BLL.ControlPrj.csControlPrj();
            dt_D = css.SlControlPrjDetails(x_);
            bindingSource2.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            dt_D.xCntD_Column.DefaultValue = x_;

            GenerateD();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (TpeUsr == "adm")
            {

                this.Validate();
                dataGridView1.EndEdit();
                BLL.ControlPrj.csControlPrj css = new BLL.ControlPrj.csControlPrj();
                if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(css.UdControlPrj(dt_C), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ShowDataD();
            }

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView2.EndEdit();
            BLL.ControlPrj.csControlPrj css = new BLL.ControlPrj.csControlPrj();
            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(css.UdControlPrjDetails(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string st = "";
            if (dataGridView1[e.ColumnIndex, e.RowIndex].Value != null)
                st = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (dataGridView1["xEnd", e.RowIndex].Value != null &&
                    dataGridView1["xEnd", e.RowIndex].Value != DBNull.Value &&
                    (bool?)dataGridView1["xEnd", e.RowIndex].Value == true)
                {
                    dataGridView2.ReadOnly = true;
                }

                else
                    dataGridView2.ReadOnly = false;

                ShowDataD((int)dataGridView1["x_", e.RowIndex].Value);
            }

        }

        private void frmControlPrj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView2.IsCurrentCellInEditMode)
                if (dataGridView2.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                    dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width += 5;
                else if (dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
                    dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width -= 5;
            if (dataGridView1.IsCurrentCellInEditMode)
                if (dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                    dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
                else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
                    dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xEnd")
            {
                BLL.csshamsidate cs = new BLL.csshamsidate();

                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    if (dataGridView1["xDayDelay", e.RowIndex].Value != null &&
                        dataGridView1["xDayDelay", e.RowIndex].Value != DBNull.Value &&
                        dataGridView1["xDateStartReal", e.RowIndex].Value != null &&
                        dataGridView1["xDateStartReal", e.RowIndex].Value != DBNull.Value)

                        dataGridView1["xDatePredict", e.RowIndex].Value = cs.previousDay(dataGridView1["xDateStartReal", e.RowIndex].Value.ToString(),
                            int.Parse(dataGridView1["xDayDelay", e.RowIndex].Value.ToString()), BLL.csshamsidate.Ravand.down);
                }
                else
                {
                    dataGridView1["xDatePredict", e.RowIndex].Value = DBNull.Value;

                }

            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
