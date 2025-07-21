using System;
using System.Data;
using System.Windows.Forms;
using DAL.inventory;
using BLL;
using BLL.ProductOperation;
using Validation;

namespace Payazob.FRM.Product
{
    public partial class frmPiecesProducsMachining : Form
    {
        public frmPiecesProducsMachining()
        {
            this.date = BLL.csshamsidate.shamsidate;
            this.Cell_x_ = -1;

            InitializeComponent();
            //new csshamsidate();
            BLL.csShift shift = new BLL.csShift();
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام شیفت",
                DataSource = shift.mShiftDataTable(),
                DisplayMember = "xShiftName",
                ValueMember = "x_",
                Name = "combobox_Shift_",
                Visible = true
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام دستگاه",
                DataSource = new BLL.Machine.csMachine().mMachine((int)CS.csEnum.Factory.Site3),
                DisplayMember = "CodeName",
                ValueMember = "x_",
                DataPropertyName = "xMachine_",
                Name = "MachineName",
                Visible = true
            };
            this.dataGridView2.Columns.Add(column2);
            DataGridViewComboBoxColumn column3 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام اپراتور",
                DataSource = new BLL.Person.csPersonInfo().mPersonInfoBySec(154),
                DisplayMember = "name",
                ValueMember = "x_",
                DataPropertyName = "xPerId_",
                Name = "cmb_xPerId_",
                Visible = true,
                Width = 150
            };
            this.dataGridView2.Columns.Add(column3);
            BLL.csPieces pieces = new BLL.csPieces();
            DataGridViewComboBoxColumn column4 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام قطعه",
                DataSource = pieces.mPiecesDataTable(0x99),
                DisplayMember = "Piece",
                ValueMember = "x_",
                Name = "combobox_PiecesLine1_",
                Visible = true,
                Width = 200
            };
            this.dataGridView2.Columns.Add(column4);
            DataGridViewComboBoxColumn column5 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام OP",
                DataSource = new BLL.ProductOperation.csProductOperation().ProductOperationOpName(-1),
                DisplayMember = "xOpName",
                ValueMember = "x_",
                Name = "xProductOperation_",
                DataPropertyName = "xProductOperation_",
                Visible = true
            };
            this.dataGridView2.Columns.Add(column5);
            DataGridViewCheckBoxColumn column6 = new DataGridViewCheckBoxColumn
            {
                Name = "chb",
                HeaderText = " ",
                Visible = false
            };
            this.dataGridView1.Columns.Add(column6);
            this.dt_I = new csInventory().SelectPiecesProuductMachining(this.date, this.date);
            this.bindingSource1.DataSource = this.dt_I;
            this.dataGridView1.DataSource = this.dt_I;
            this.uc_bindingNavigator1.BindingSource = this.bindingSource1;
            this.dt_I.xDateColumn.DefaultValue = csshamsidate.shamsidate;
            this.generateForm();


        }
        private int Cell_x_;
        private string date;
        private DataSet_Inventory.SelectPiecesProductDetialsMachiningDataTable dt_D;
        private DataSet_Inventory.SelectPiecesProuductMachiningDataTable dt_I;

        private void btn_Show_Click(object sender, EventArgs e)
        {
            this.ShowDataGridView1();
            this.dt_I.xDateColumn.DefaultValue = csshamsidate.shamsidate;
        }




        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    this.dataGridView1.Rows.Remove(row);
                }
            }

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!this.dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly && (this.dataGridView1.Columns[e.ColumnIndex].Name == "xDate"))
            {
                Payazob.FRM.frmDate.frmDate date = new Payazob.FRM.frmDate.frmDate
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                date.ShowDialog();
                if (date.accept)
                {
                    this.dataGridView1[e.ColumnIndex, e.RowIndex].Value = date.fDate;
                }
            }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Focused)
            {
                if (this.dataGridView1["chb", e.RowIndex].Value == null)
                {
                    this.dataGridView2.Enabled = false;
                    this.uc_bindingNavigator2.Enabled = false;
                }
                else
                {
                    this.dataGridView2.Enabled = true;
                    this.uc_bindingNavigator2.Enabled = true;
                    if ((e.RowIndex > -1) && (this.Cell_x_ != ((int)this.dataGridView1["x_", e.RowIndex].Value)))
                    {
                        this.ShowDataGridViewDetials((int)this.dataGridView1["x_", e.RowIndex].Value);
                        this.Cell_x_ = (int)this.dataGridView1["x_", e.RowIndex].Value;
                    }
                }
            }

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
            {
                VDate date = new VDate();
                e.Cancel = !date.ValidationDate(e.FormattedValue.ToString());
            }

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);

        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool flag = (e.RowIndex != -1) && (e.ColumnIndex != -1);
            DataGridView view = sender as DataGridView;
            if ((view.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn) && flag)
            {
                view.BeginEdit(true);
                ((ComboBox)view.EditingControl).DroppedDown = true;
            }

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.dataGridView2.Columns[e.ColumnIndex].Name == "combobox_PiecesLine1_"))
            {
                this.dataGridView2["xProductOperation_", e.RowIndex].Value = DBNull.Value;
                if (this.dataGridView2[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    (this.dataGridView2["xProductOperation_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new csProductOperation().ProductOperationOpName((int?)this.dataGridView2[e.ColumnIndex, e.RowIndex].Value);
                }
                else
                {
                    (this.dataGridView2["xProductOperation_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new csProductOperation().ProductOperationOpName(-1);
                }
            }

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);

        }
        private void generateForm()
        {
            Payazob.CS.csDic dic = new Payazob.CS.csDic();
            foreach (DataColumn column in this.dt_I.Columns)
            {
                if (this.dataGridView1.Columns[column.ColumnName] != null)
                {
                    this.dataGridView1.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
                }
            }
            this.dataGridView1.Columns["combobox_Shift_"].DisplayIndex = 3;
            this.dataGridView1.Columns["xDate"].DisplayIndex = 2;
            this.dataGridView1.Columns["xShift_"].Visible = false;
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView1.Columns["combobox_Shift_"].DataPropertyName = "xShift_";
            this.dt_I.xDateColumn.DefaultValue = csshamsidate.shamsidate;
        }
        bool flagGen_D =true;
        private void generateForm_D()
        {
            if (flagGen_D)
            {
                flagGen_D = false;
                Payazob.CS.csDic dic = new Payazob.CS.csDic();
                foreach (DataColumn column in this.dt_D.Columns)
                {
                    if (this.dataGridView2.Columns[column.ColumnName] != null)
                    {
                        this.dataGridView2.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
                    }
                }
                this.dataGridView2.Columns["x_"].Visible = false;
                this.dataGridView2.Columns["xPieces_"].Visible = false;
                this.dataGridView2.Columns["xPiecesProduct_"].Visible = false;
                this.dataGridView2.Columns["combobox_PiecesLine1_"].DataPropertyName = "xPieces_";
                this.dataGridView2.Columns["cmb_xPerId_"].HeaderText = "نام اپراتور";
                this.dataGridView2.Columns["xSupplier_"].Visible = false;
                this.dataGridView2.Columns["xProductOperation_"].DisplayIndex = 4;
                this.dataGridView2.Columns["xStartTime"].DisplayIndex = 11;
                this.dataGridView2.Columns["xEndTime"].DisplayIndex = 12;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            base.Validate();
            this.dataGridView1.EndEdit();
            new csInventory().UpdatePiecesProductMachining(this.dt_I);
            this.ShowDataGridView1();
            MessageBox.Show("ارسال با موفقیت انجام شد.");
            this.dt_I.xDateColumn.DefaultValue = csshamsidate.shamsidate;

        }
        private void ShowDataGridView1()
        {
            this.dt_I = new csInventory().SelectPiecesProuductMachining(this.uc_Filter_Date1.DateFrom, this.uc_Filter_Date1.DateTo);
            this.bindingSource1.DataSource = this.dt_I;
            this.dataGridView1.DataSource = this.dt_I;
            this.uc_bindingNavigator1.BindingSource = this.bindingSource1;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)row.Cells["chb"]).Value = true;
            }
            this.generateForm();
        }
        private void ShowDataGridViewDetials(int x_)
        {
            this.dt_D = new csInventory().SelectPiecesProuductDetailsMachining(x_);
            this.dataGridView2.DataSource = this.dt_D;
            this.bindingSource2.DataSource = this.dt_D;
            this.uc_bindingNavigator2.BindingSource = this.bindingSource2;
            this.dt_D.xPiecesProduct_Column.DefaultValue = x_;
            this.dt_D.xSupplier_Column.DefaultValue = authentication.x_;
            this.generateForm_D();
            foreach (DataGridViewRow row in this.dataGridView2.Rows)
            {
                if ((!row.IsNewRow && (row.Cells["combobox_PiecesLine1_"].Value != DBNull.Value)) && (row.Cells["combobox_PiecesLine1_"].Value != null))
                {
                    (row.Cells["xProductOperation_"] as DataGridViewComboBoxCell).DataSource = new csProductOperation().ProductOperationOpName((int?)row.Cells["combobox_PiecesLine1_"].Value);
                }
            }
        }

        private void toolStripButton_Save_D_Click_1(object sender, EventArgs e)
        {
            int num = -1;
            foreach (DataGridViewRow row in this.dataGridView2.Rows)
            {
                if (row.Cells["xPiecesProduct_"].Value == DBNull.Value)
                {
                    return;
                }
            }
            if (this.dataGridView2.Rows.Count > 0)
            {
                num = (int)this.dataGridView2["xPiecesProduct_", 0].Value;
            }
            base.Validate();
            this.dataGridView2.EndEdit();
            new csInventory().UpdatePiecesProductDetailsMachining(this.dt_D);
            this.ShowDataGridViewDetials(num);
            MessageBox.Show("ارسال با موفقیت انجام شد.");
            this.Cell_x_ = -2;

        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView2.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    this.dataGridView2.Rows.Remove(row);
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView2;
            uc.RunExcel();
        }
    }
}
