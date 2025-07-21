using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.MuscleProduct
{
    public partial class frmMuscleSend : Form
    {
        public frmMuscleSend(string Sec)
        {
            InitializeComponent();


            BLL.csPieces cs = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_Muscle_ = new DataGridViewComboBoxColumn();
            combobox_Muscle_.HeaderText = "نام ماهیچه";
            combobox_Muscle_.DataSource = cs.SlMuscle();
            combobox_Muscle_.DisplayMember = "xMuscleName";
            combobox_Muscle_.ValueMember = "x_";
            combobox_Muscle_.Name = "combobox_Muscle_";
            combobox_Muscle_.DataPropertyName = "xPieces_";
            combobox_Muscle_.Visible = true;
            combobox_Muscle_.MaxDropDownItems = 30;
            combobox_Muscle_.Width = 150;
            combobox_Muscle_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Muscle_);


            dt_M = new DAL.MuscleProduct.DataSet_MuscleSend.SlMuscleSendDataTable();
            bindingSource1.DataSource = dt_M;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            Se = Sec;

            if (Se == "PL")
            {
                uc_Filter_Date1.Visible = true;
            }
            else
                uc_Filter_Date1.Visible = false;

            if (Se != "MU")
            {
                dataGridView1.AllowUserToDeleteRows = false;
                bindingNavigatorDeleteItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
                dataGridView1.AllowUserToAddRows = false;
            }

            Generation();
        }
        DAL.MuscleProduct.DataSet_MuscleSend.SlMuscleSendDataTable dt_M;
        string Se = "";
        void dvgColu(string Se)
        {

            if (Se == "MU")
            {
                dataGridView1.Columns["x_"].Visible = false;
                dataGridView1.Columns["xDate"].Visible = false;
                dataGridView1.Columns["xDateSend"].Visible = true;
                // dataGridView1.Columns["xPieces_"].Visible = true;
                dataGridView1.Columns["Pieces"].Visible = true;
                dataGridView1.Columns["MuscleName"].Visible = false;
                dataGridView1.Columns["xCount"].Visible = true;
                dataGridView1.Columns["xSupplier_"].Visible = false;
                dataGridView1.Columns["Supplier"].Visible = true;
                dataGridView1.Columns["Approve"].Visible = false;
                dataGridView1.Columns["xSupplierComment"].Visible = true;
                dataGridView1.Columns["xConfirm"].Visible = false;
                dataGridView1.Columns["xConfirmDate"].Visible = false;
                dataGridView1.Columns["xApprove_"].Visible = false;
                dataGridView1.Columns["xApproveComment"].Visible = false;
                dataGridView1.Columns["xPlanUserConfirmDate"].Visible = false;
                dataGridView1.Columns["xPlanUserConfirm"].Visible = false;
                dataGridView1.Columns["xPlanUserConfirm_"].Visible = false;
                dataGridView1.Columns["xPlanUserConfirmComment"].Visible = false;
            }
            else if (Se == "PR")
            {
                //foreach (DataGridViewColumn item in dataGridView1.Columns)
                //{
                //    item.ReadOnly = true;
                //}
                dataGridView1.Columns["x_"].Visible = false;
                dataGridView1.Columns["xDate"].Visible = false;

                /////////////----------------------------------------

                dataGridView1.Columns["xDateSend"].ReadOnly = true;
                dataGridView1.Columns["Pieces"].ReadOnly = true;
                dataGridView1.Columns["MuscleName"].ReadOnly = true;
                dataGridView1.Columns["xCount"].ReadOnly = true;
                dataGridView1.Columns["xSupplier_"].ReadOnly = false;
                dataGridView1.Columns["Supplier"].ReadOnly = true;
                dataGridView1.Columns["Approve"].ReadOnly = true;
                dataGridView1.Columns["xSupplierComment"].ReadOnly = true;
                dataGridView1.Columns["xConfirmDate"].ReadOnly = true;


                /////////////----------------------------------------
                dataGridView1.Columns["combobox_Muscle_"].Visible = false;

                dataGridView1.Columns["xDateSend"].Visible = true;
                // dataGridView1.Columns["xPieces_"].Visible = true;
                dataGridView1.Columns["Pieces"].Visible = true;
                dataGridView1.Columns["MuscleName"].Visible = true;
                dataGridView1.Columns["xCount"].Visible = true;
                dataGridView1.Columns["xSupplier_"].Visible = false;
                dataGridView1.Columns["Supplier"].Visible = true;
                dataGridView1.Columns["Approve"].Visible = true;
                dataGridView1.Columns["xSupplierComment"].Visible = true;
                dataGridView1.Columns["xConfirm"].Visible = true;
                dataGridView1.Columns["xConfirmDate"].Visible = true;
                dataGridView1.Columns["xApprove_"].Visible = false;
                dataGridView1.Columns["xApproveComment"].Visible = true;
                dataGridView1.Columns["xPlanUserConfirmDate"].Visible = false;
                dataGridView1.Columns["xPlanUserConfirm"].Visible = false;
                dataGridView1.Columns["xPlanUserConfirm_"].Visible = false;
                dataGridView1.Columns["xPlanUserConfirmComment"].Visible = false;
            }
            else if (Se == "PL")
            {
                //foreach (DataGridViewColumn item in dataGridView1.Columns)
                //{
                //    item.ReadOnly = true;
                //}
                //////////--------------------------------------------
                dataGridView1.Columns["xDateSend"].ReadOnly = true;
                dataGridView1.Columns["Pieces"].ReadOnly = true;
                dataGridView1.Columns["MuscleName"].ReadOnly = true;
                dataGridView1.Columns["xCount"].ReadOnly = true;

                dataGridView1.Columns["Supplier"].ReadOnly = true;
                dataGridView1.Columns["Approve"].ReadOnly = true;
                dataGridView1.Columns["xSupplierComment"].ReadOnly = true;
                dataGridView1.Columns["xConfirm"].ReadOnly = true;
                dataGridView1.Columns["xConfirmDate"].ReadOnly = true;

                dataGridView1.Columns["xApproveComment"].ReadOnly = true;

                //////////--------------------------------------------

                dataGridView1.Columns["combobox_Muscle_"].Visible = false;

                dataGridView1.Columns["x_"].Visible = false;
                dataGridView1.Columns["xDate"].Visible = false;
                dataGridView1.Columns["xDateSend"].Visible = true;
                dataGridView1.Columns["Pieces"].Visible = true;
                dataGridView1.Columns["MuscleName"].Visible = true;
                dataGridView1.Columns["xCount"].Visible = true;
                dataGridView1.Columns["xSupplier_"].Visible = false;
                dataGridView1.Columns["Supplier"].Visible = true;
                dataGridView1.Columns["Approve"].Visible = true;
                dataGridView1.Columns["xSupplierComment"].Visible = true;
                dataGridView1.Columns["xConfirm"].Visible = true;
                dataGridView1.Columns["xConfirmDate"].Visible = true;
                dataGridView1.Columns["xApprove_"].Visible = false;
                dataGridView1.Columns["xApproveComment"].Visible = true;
                dataGridView1.Columns["xPlanUserConfirmDate"].Visible = true;
                dataGridView1.Columns["xPlanUserConfirm"].Visible = true;
                dataGridView1.Columns["xPlanUserConfirm_"].Visible = false;
                dataGridView1.Columns["xPlanUserConfirmComment"].Visible = true;
            }



        }

        void Generation()
        {

            dataGridView1.Columns["xDateSend"].HeaderText = "تاریخ ارسال";
            // dataGridView1.Columns["xPieces_"].HeaderText = "شماره سریال قطعه";
            dataGridView1.Columns["Pieces"].HeaderText = "نام قطعه";
            dataGridView1.Columns["MuscleName"].HeaderText = "نام ماهیچه";

            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xSupplier_"].HeaderText = "شماره سریال ثبت کننده";
            dataGridView1.Columns["Supplier"].HeaderText = "نام ثبت کننده";
            dataGridView1.Columns["Approve"].HeaderText = "تحویل گیرند";
            dataGridView1.Columns["xSupplierComment"].HeaderText = "توضیحات تحویل دهنده";
            dataGridView1.Columns["xSupplierComment"].Width = 200;
            dataGridView1.Columns["xConfirm"].HeaderText = "تایید تحویل گیرنده";
            dataGridView1.Columns["xConfirmDate"].HeaderText = "تاریخ تایید تحویل گیرنده ";
            dataGridView1.Columns["xApprove_"].HeaderText = "شماره تایید کننده";
            dataGridView1.Columns["xApproveComment"].HeaderText = "توضیحات تحویل گیرنده";
            dataGridView1.Columns["xPlanUserConfirmDate"].HeaderText = "تاریخ درج در صورت وضعیت";
            dataGridView1.Columns["xPlanUserConfirm"].HeaderText = "تایید درج در صورت وضعیت";
            dataGridView1.Columns["xPlanUserConfirm_"].HeaderText = "شماره سریال کاربر برنامه ریزی";
            dataGridView1.Columns["xPlanUserConfirmComment"].HeaderText = "توضیحات کاریر برنامه ریزی";
            dvgColu(Se);
            if (Se == "PL")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((bool?)item.Cells["xConfirm"].Value == false)
                    {
                        item.ReadOnly = true;
                        item.DefaultCellStyle.BackColor = Color.Pink;
                    }
                }
            }

            dt_M.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_M.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.MuscleProduct.csMuscleProduct cs = new BLL.MuscleProduct.csMuscleProduct();
            dt_M = cs.SlMuscleSend(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, Se);
            bindingSource1.DataSource = dt_M;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generation();

        }
        void SaveData()
        {

            BLL.MuscleProduct.csMuscleProduct cs = new BLL.MuscleProduct.csMuscleProduct();
            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(cs.UdMuscleSend(dt_M), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dt_M = cs.SlMuscleSend(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, Se);
            bindingSource1.DataSource = dt_M;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generation();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (ValidateDataIN())
                SaveData();
        }
        bool ValidateDataIN()
        {

            BLL.MuscleProduct.csMuscleProduct cs = new BLL.MuscleProduct.csMuscleProduct();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (!item.IsNewRow && item.Cells["combobox_Muscle_"].Value != DBNull.Value && item.Cells["combobox_Muscle_"].Value != null && (int)item.Cells["x_"].Value < 0)
                    if (!cs.SlMucsleInvCheak(Payazob.Properties.Settings.Default.WorkYear, (int)item.Cells["combobox_Muscle_"].Value, (int?)item.Cells["xCount"].Value))
                    {
                        MessageBox.Show("مقدار ارسال شده بیشتر از موجودی می باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                //;
            }
            return true;

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xApprove_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xConfirmDate", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xApprove_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xConfirmDate", e.RowIndex].Value = DBNull.Value;

                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "xPlanUserConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xPlanUserConfirm_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xPlanUserConfirmDate", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xPlanUserConfirm_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xPlanUserConfirmDate", e.RowIndex].Value = DBNull.Value;

                }

            }

        }
        int x_ = -1;
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDateSend" || dataGridView1.Columns[e.ColumnIndex].Name == "xPlanUserConfirmDate")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    fr.StartPosition = FormStartPosition.CenterParent;

                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                }
            x_ = (int)dataGridView1["x_", e.RowIndex].Value;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["xCount"].Index == e.ColumnIndex && (int)dataGridView1["x_", e.RowIndex].Value > 0)
            {
                dataGridView1["xCount", e.RowIndex].Value = tm;
            }
            x_ = -1;
        }
        int tm;
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            BLL.MuscleProduct.csMuscleProduct cs = new BLL.MuscleProduct.csMuscleProduct();

            if (dataGridView1.Columns["xCount"].Index == e.ColumnIndex && (int)dataGridView1["x_", e.RowIndex].Value > 0)
            {


                tm = (int)dataGridView1["xCount", e.RowIndex].Value;
                int tmm = int.Parse(dataGridView1["xCount", e.RowIndex].EditedFormattedValue.ToString()) - tm;

                if (!dataGridView1.Rows[e.RowIndex].IsNewRow && dataGridView1["combobox_Muscle_", e.RowIndex].Value != DBNull.Value
                    && dataGridView1["combobox_Muscle_", e.RowIndex].Value != null && (int)dataGridView1["x_", e.RowIndex].Value > 0)

                    if (!cs.SlMucsleInvCheak(Payazob.Properties.Settings.Default.WorkYear,
                        (int)dataGridView1["combobox_Muscle_", e.RowIndex].Value, tmm))
                    {
                        MessageBox.Show("مقدار ارسال شده بیشتر از موجودی می باشد", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        tm = int.Parse(dataGridView1["xCount", e.RowIndex].EditedFormattedValue.ToString());
                        if (x_ > 0)
                        {
                            dataGridView1["xCount", e.RowIndex].ReadOnly = true;
                            dataGridView1.AllowUserToAddRows = false;
                            //       bindingNavigator1.AddNewItem.Enabled = false;
                        }
                    }

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns["xCount"].Index == e.ColumnIndex && (int)dataGridView1["x_", e.RowIndex].Value > 0)

                if (dataGridView1["xCount", e.RowIndex].ReadOnly == true && Se == "MU")
                {
                    MessageBox.Show("شما مجاز به یک بار ویرایش می باشید در صورت نیاز دکمه نمایش را مجددا کلیک کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void toolStripButtonListView_Click(object sender, EventArgs e)
        {
            frmEmpty_Report f = new frmEmpty_Report("MuscleSend_R", "");
            (f as frmEmpty_Report).SetParam("x_", false);
            (f as frmEmpty_Report).SetParam("xDateSend", false);
            (f as frmEmpty_Report).SetParam("Approve", false);
            (f as frmEmpty_Report).SetParam("xSupplierComment", false);
            (f as frmEmpty_Report).SetParam("xApprove_", false);
            (f as frmEmpty_Report).SetParam("xApproveComment", false);
            (f as frmEmpty_Report).SetParam("xPlanUserConfirmDate", false);
            (f as frmEmpty_Report).FilterDate = true;
            (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
            f.ShowDialog();
        }
    }
}
