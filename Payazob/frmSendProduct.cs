using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSendProduct : Form
    {
        public frmSendProduct()
        {
            InitializeComponent();
            BLL.csPieces cs = new BLL.csPieces();

            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn();
            combobox_PiecesLine1_.HeaderText = "نام قطعه";
            combobox_PiecesLine1_.DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_PiecesLine1_.DisplayMember = "xName";
            combobox_PiecesLine1_.ValueMember = "x_";
            combobox_PiecesLine1_.Name = "combobox_Pieces";
            combobox_PiecesLine1_.Visible = true;
            combobox_PiecesLine1_.Width = 180;
            combobox_PiecesLine1_.MaxDropDownItems = 30;
            combobox_PiecesLine1_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_PiecesLine1_);

            ShowDataGridView();
            Generate_I();
        //    toolStripTextBoxDateFrom.Text = BLL.csshamsidate.shamsidate;
       //     toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;
        }

        DAL.inventory.DataSet_Inventory.SelectSendProductDataTable dt_I;

        void ShowDataGridView()
        {
            BLL.csInventory cs = new BLL.csInventory();
            dt_I= cs.SelectSendProduct(uc_Filter_Date1.DateFrom,uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dt_I;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            dt_I.Columns["xDate"].DefaultValue = BLL.csshamsidate.shamsidate;
            dt_I.xPieces_Column.AllowDBNull = false;
            dt_I.xSendNumberColumn.AllowDBNull = false;
            dt_I.xReturnCustomerColumn.DefaultValue = false;
            dataGridView1.Columns["xReturnCustomer"].Visible = false;
              
        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
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
            dataGridView1.Columns["xDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["xDate"].DisplayIndex = 0;
            dataGridView1.Columns["xWeight"].Visible = false;
        }


        private bool CheakInventory()
        {
            int inv = 0;
            int r = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Cells["xPieces_"].Value == DBNull.Value || row.Cells["xPieces_"].Value == null)
                    continue;
                inv = new BLL.csInventory().InventoryCheck(TARANOM.Properties.Settings.Default.WorkYear, TARANOM.Properties.Settings.Default.WorkYear.Substring(0,4) + "/12/30", TARANOM.Properties.Settings.Default.WorkYear, (int)row.Cells["xPieces_"].Value);

                if (row.Cells["xSendNumber"].Value != null)                
                 int.TryParse(row.Cells["xSendNumber"].Value.ToString(), out r);
                if (inv - r > 0)
                    return true;
                else
                    return false;
            }
            return true;

        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            //if (!CheakInventory())
            //{
            //    MessageBox.Show("مقدار موجودی در گردش منفی می شود",
            //    "خطا",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Error,
            //    MessageBoxDefaultButton.Button1);
            //    return;
            //}


            BLL.csInventory cs = new BLL.csInventory();
            cs.UpdateSendProduct(dt_I);
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

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message),"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button3);
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();

        }
    }
}
