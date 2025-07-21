using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.SendProductToTurning
{
    public partial class frmSendProductToTurning : Form
    {
        public frmSendProductToTurning()
        {
            InitializeComponent();

            BLL.csMaterial csm = new BLL.csMaterial();
            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 4;
            combobox_xMaterialType_.HeaderText = "نوع مواد";
            combobox_xMaterialType_.DataSource = csm.SelectMeltName(160, -1, false);
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xPieces_";
            combobox_xMaterialType_.Name = "cmb_Material";
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xMaterialType_);


            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("SHIP");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "شیفت";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xGenTime_";
            combobox_Type_.Name = "cmb_Type";
            combobox_Type_.Width = 150;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Type_);

            ShowDataGridView();
            Generate_I();
        }
        DAL.SendProductToTurning.DataSet_SendProductToTurning.mSendProductToTurningDataTable dt_I;

        void ShowDataGridView()
        {
            dt_I = new BLL.SendProductToTurning.csSendProductToTurning().mSendProductToTurning(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dt_I;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_I.Columns["xDate"].DefaultValue = BLL.csshamsidate.shamsidate;
            dt_I.Columns["xSupplier_"].DefaultValue = BLL.authentication.x_;
            
        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        void Generate_I()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xTransferee"].HeaderText = "تحویل گیرنده";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["xDate"].Width = 80;
            dataGridView1.Columns["xDate"].DisplayIndex = 0;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                base.Validate();
                this.dataGridView1.EndEdit();
                MessageBox.Show(new BLL.SendProductToTurning.csSendProductToTurning().UdSendProductToTurning(this.dt_I)
                    , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ShowDataGridView();
                this.Generate_I();
                MessageBox.Show("ارسال با موفقیت انجام شد");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
            {
                Validation.VDate v = new Validation.VDate();
                e.Cancel = !v.ValidationDate(e.FormattedValue.ToString());
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    //    var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    //   fr.Location = new Point(cellRectangle.X, cellRectangle.Y);
                    fr.StartPosition = FormStartPosition.CenterParent;
                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            DataTable data = new BLL.SendProductToTurning.csSendProductToTurning().SlSendProductToTurning_R(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (this.dataGridView1.SelectedRows.Count < 1)
                {
                    break;
                }
                if (!row.Selected)
                {
                    foreach (DataRow row2 in data.Rows)
                    {
                        if ((row.Cells["x_"].Value != null) && (((int)row.Cells["x_"].Value) == ((int)row2["x_"])))
                        {
                            row2.Delete();
                            break;
                        }
                    }
                }
                data.AcceptChanges();
            }
            Report.SendReport report = new Report.SendReport();
            report.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport report2 = new frmReport
            {
                GetReport = report.GetReport(data, "SendProductToTurning")
            };
            report2.ShowDialog();
            report2.Dispose();

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void dataGridView1_CellBeginEdit_1(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!this.dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly && (this.dataGridView1.Columns[e.ColumnIndex].Name == "xDate"))
            {
                Payazob.FRM.frmDate.frmDate date = new Payazob.FRM.frmDate.frmDate();
                Rectangle rectangle = this.dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                date.Location = new Point(rectangle.X, rectangle.Y);
                date.ShowDialog();
                if (date.accept)
                {
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = date.fDate;
                }
            }

        }
    }
}
