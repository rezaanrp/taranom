using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.SendProductTurning
{
    public partial class frmSendProductTurning : Form
    {
        public frmSendProductTurning()
        {
            InitializeComponent();

            ShowDataGridView();

            BLL.csCompony cm = new BLL.csCompony();
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 3;
            combobox_xSupplier_.HeaderText = "نام مشتری";
            combobox_xSupplier_.DataSource = cm.SelectCustomer();
            combobox_xSupplier_.DisplayMember = "xComponyName";
            combobox_xSupplier_.ValueMember = "x_";
            combobox_xSupplier_.DataPropertyName = "xCustomer_";
            combobox_xSupplier_.Name = "cmb_Supplier";
            combobox_xSupplier_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_xSupplier_.DisplayIndex = dataGridView1.Columns["xCustomer_"].DisplayIndex = 2;
            dataGridView1.Columns.Add(combobox_xSupplier_);


            BLL.csPieces cs = new BLL.csPieces();

            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn();
            combobox_PiecesLine1_.HeaderText = "نام قطعه";
            combobox_PiecesLine1_.DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site3);
            combobox_PiecesLine1_.DisplayMember = "xName";
            combobox_PiecesLine1_.ValueMember = "x_";
            combobox_PiecesLine1_.Name = "combobox_Pieces";
            combobox_PiecesLine1_.Visible = true;
            combobox_PiecesLine1_.Width = 180;
            combobox_PiecesLine1_.DisplayIndex = 3;
            combobox_PiecesLine1_.MaxDropDownItems = 30;
            combobox_PiecesLine1_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_PiecesLine1_);

            uc_DataGridViewBtn1.ColumnsFilter_ = "xComponyName";
            uc_DataGridViewBtn1.Ds = cm.SelectCustomer();

            uc_DataGridViewBtn1.ParamName = new string[] { "xComponyName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام شرکت" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
               "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;



            Generate_I();

        }
        DAL.inventory.DataSet_SendProductTurning.SlSendProductTurningDataTable dt_I;

        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xCustomer_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
                dataGridView1["cmb_Supplier", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }

        void ShowDataGridView()
        {
            BLL.Inventory.csSendProductTurning cs = new BLL.Inventory.csSendProductTurning();
            dt_I = cs.SlSendProductTurning(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dt_I;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            dt_I.Columns["xDate"].DefaultValue = BLL.csshamsidate.shamsidate;
            dt_I.xPieces_Column.AllowDBNull = false;
            dt_I.xSendNumberColumn.AllowDBNull = false;
        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        void Generate_I()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xSendNumber"].HeaderText = " تعداد ارسالی به انبار";
            dataGridView1.Columns["xSendNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["combobox_Pieces"].DataPropertyName = "xPieces_";
            dataGridView1.Columns["xPieces_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["PiecesName"].Visible = false;
            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["xDate"].Width = 80;
            dataGridView1.Columns["xDate"].DisplayIndex = 0;
            dataGridView1.Columns["cmb_Supplier"].DisplayIndex = 5;
            dataGridView1.Columns["xCustomer_"].DisplayIndex = 6;
            dataGridView1.Columns["xCustomer_"].HeaderText = "کد شرکت";
            dataGridView1.Columns["Customer"].Visible = false;


      
        }


        private bool CheakInventory()
        {
            //int inv = 0;
            //int r = 0;
            //foreach (DataGridViewRow row in this.dataGridView1.Rows)
            //{
            //    if (row.Cells["xPieces_"].Value == DBNull.Value || row.Cells["xPieces_"].Value == null)
            //        continue;
            //    inv = new BLL.csInventory().InventoryCheck(Properties.Settings.Default.WorkYear, Properties.Settings.Default.WorkYear.Substring(0, 4) + "/12/30", Properties.Settings.Default.WorkYear, (int)row.Cells["xPieces_"].Value);

            //    if (row.Cells["xSendNumber"].Value != null)
            //        int.TryParse(row.Cells["xSendNumber"].Value.ToString(), out r);
            //    if (inv - r > 0)
            //        return true;
            //    else
            //        return false;
            //}
            return true;

        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.Inventory.csSendProductTurning cs = new BLL.Inventory.csSendProductTurning();
            cs.UdSendProductTurning(dt_I);
            ShowDataGridView();
            Generate_I();
            MessageBox.Show("ارسال با موفقیت انجام شد");
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xCustomer_")
            {
                uc_DataGridViewBtn1.Visible = true;
                var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y); ;
                uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
                uc_DataGridViewBtn1.RI = e.RowIndex;
                uc_DataGridViewBtn1.CI = e.ColumnIndex;
            }

            else
                uc_DataGridViewBtn1.Visible = false;
        }
    }
}
