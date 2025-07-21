using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.SendProductInspectionMachining
{
    public partial class frmSendProductInspectionMachining : Form
    {
        public frmSendProductInspectionMachining()
        {
            InitializeComponent();

            BLL.csMaterial csm = new BLL.csMaterial();
            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 4;
            combobox_xMaterialType_.HeaderText = "نوع مواد";
            combobox_xMaterialType_.DataSource = csm.SelectMeltName(160, -1, false);
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xMaterial_";
            combobox_xMaterialType_.Name = "xMaterial_";
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xMaterialType_);


            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("SPIMD");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "ضایعات";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xGenDefect_";
            combobox_Type_.Name = "xGenDefect_";
            combobox_Type_.Width = 150;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Type_);


            ShowDataGridView();
            Generate_I();
        }

        DAL.SendProductInspectionMachining.DataSet_SendProductInspectionMachining.mSendProductInspectionMachiningDataTable dt_I;

        void ShowDataGridView()
        {
            dt_I = new BLL.SendProductInspectionMachining.csSendProductInspectionMachining().mSendProductInspectionMachining(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
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
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_I.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
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
                MessageBox.Show(new BLL.SendProductInspectionMachining.csSendProductInspectionMachining().UdSendProductInspectionMachining(this.dt_I)
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



     


    }
}
