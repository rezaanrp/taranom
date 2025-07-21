using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmPiecesProducs : Form
    {
        public frmPiecesProducs()
        {
            InitializeComponent();

            BLL.csshamsidate cssham = new BLL.csshamsidate();



            BLL.csShift cs_Shift = new BLL.csShift();
            DataGridViewComboBoxColumn combobox_Shift_ = new DataGridViewComboBoxColumn();
            combobox_Shift_.HeaderText = "نام شیفت";
            combobox_Shift_.DataSource = cs_Shift.mShiftDataTable();
            combobox_Shift_.DisplayMember = "xShiftName";
            combobox_Shift_.ValueMember = "x_";
            combobox_Shift_.Name = "combobox_Shift_";
            combobox_Shift_.Visible = true;
            dataGridView1.Columns.Add(combobox_Shift_);

            BLL.csPieces cs = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn();
            combobox_PiecesLine1_.HeaderText = "نام قطعه";
            combobox_PiecesLine1_.DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_PiecesLine1_.DisplayMember = "xName";
            combobox_PiecesLine1_.ValueMember = "x_";
            combobox_PiecesLine1_.Name = "combobox_PiecesLine1_";
            combobox_PiecesLine1_.Visible = true;
            combobox_PiecesLine1_.Width = 250;
            combobox_PiecesLine1_.MaxDropDownItems = 30;
            dataGridView2.Columns.Add(combobox_PiecesLine1_);

            BLL.GenGroup.csGenGroup group = new BLL.GenGroup.csGenGroup();
            //DataTable dt = group.SlGenGroup("PCS");
            //dt.Rows.Add();
            DataGridViewComboBoxColumn column4 = new DataGridViewComboBoxColumn
            {
                DataSource = group.SlGenGroup("SHIP"),
                HeaderText = " نوع شیفت",
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenDay_",
                Name = "xGenDay_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };
            dataGridView1.Columns.Add(column4);


            DataGridViewComboBoxColumn column5 = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.Mold.csMold().MoldCombo(-1),
                HeaderText = " کد مدل",
                DisplayMember = "CodeMold",
                ValueMember = "x_",
                DataPropertyName = "xMoldList_",
                Name = "xMoldList_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };
            dataGridView2.Columns.Add(column5);

            //DataGridViewTextBoxColumn cr = new DataGridViewTextBoxColumn();
            //cr.Name = "empty";
            //cr.HeaderText = " ";
            //dataGridView1.Columns.Add(cr);

            DataGridViewCheckBoxColumn ch = new DataGridViewCheckBoxColumn();
            ch.Name = "chb";
            ch.HeaderText = " ";
            ch.Visible = false;
            dataGridView1.Columns.Add(ch);

            BLL.csInventory cs_Inventory = new BLL.csInventory();
            dt_I = cs_Inventory.SelectPiecesProuduct(date, date);
            bindingSource1.DataSource = dt_I;
            dataGridView1.DataSource = dt_I;
            uc_bindingNavigator1.BindingSource = bindingSource1;

            dt_I.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;

            generateForm();

        }
        

        string date = BLL.csshamsidate.shamsidate;
        DAL.inventory.DataSet_Inventory.SelectPiecesProuductDataTable dt_I;

        DAL.inventory.DataSet_Inventory.SelectPiecesProductDetialsDataTable dt_D;

        private void generateForm()
        {
            dataGridView1.Columns["combobox_Shift_"].DisplayIndex = 3;
            dataGridView1.Columns["xDate"].DisplayIndex = 2;
            dataGridView1.Columns["xGenDay_"].DisplayIndex = 4;
            //dataGridView1.Columns["xDate"].

            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xGenDay_"].HeaderText = "نوع شیفت";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xShift_"].Visible = false;
            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["x_"].Visible = false;

            dataGridView1.Columns["combobox_Shift_"].DataPropertyName = "xShift_";
            dt_I.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;

        }
        private void generateForm_D()
        {
            dataGridView2.Columns["xLineNumber"].HeaderText = "شماره خط";
            dataGridView2.Columns["xCount"].HeaderText = "تعداد";
            dataGridView2.Columns["xProductMin"].HeaderText = "زمان - دقیقه";
            dataGridView2.Columns["SpeedMolding"].HeaderText = "سرعت قالب گیری";
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xPieces_"].Visible = false;
            dataGridView2.Columns["xPiecesProduct_"].Visible = false;
            dataGridView2.Columns["combobox_PiecesLine1_"].DataPropertyName = "xPieces_";
            

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.csInventory cs = new BLL.csInventory();
            cs.UpdatePiecesProduct(dt_I);
            ShowDataGridView1();
            MessageBox.Show("ارسال با موفقیت انجام شد.");
            dt_I.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
        }



        void ShowDataGridView1()
        {
            BLL.csInventory cs = new BLL.csInventory();
            dt_I = cs.SelectPiecesProuduct(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_I;
            dataGridView1.DataSource = dt_I;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)item.Cells["chb"]).Value = true;
            }

            generateForm();

        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                if (!row.IsNewRow) dataGridView2.Rows.Remove(row);
        }

        private void toolStripButton_Save_D_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                if (item.Cells["xPiecesProduct_"].Value == DBNull.Value)
                    return;
            }
            this.Validate();
            dataGridView2.EndEdit();
            BLL.csInventory cs = new BLL.csInventory();
            cs.UpdatePiecesProductDetails(dt_D);
            MessageBox.Show("ارسال با موفقیت انجام شد.");
        }

        private void toolStripButton_Add_D_Click(object sender, EventArgs e)
        {
           
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

        private void toolStripTextBoxDateFrom_Enter(object sender, EventArgs e)
        {
            string st = new CS.csDateform().DateOutPut((sender as ToolStripTextBox).Owner, (sender as ToolStripTextBox).Owner.Width / 2, 0);
                (sender as ToolStripTextBox).Text =  st == "" ? (sender as ToolStripTextBox).Text : st;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1["chb", e.RowIndex].Value == null)
            {
                dataGridView2.Enabled = false;
                uc_bindingNavigator2.Enabled = false;
                return;
            }
            else
            {
                dataGridView2.Enabled = true;
                uc_bindingNavigator2.Enabled = true;
            }
            if (e.RowIndex > -1)
            {
                BLL.csInventory cs = new BLL.csInventory();
                dt_D = cs.SelectPiecesProuductDetails((int)dataGridView1["x_", e.RowIndex].Value);
                bindingSource2.DataSource = dt_D;
                dataGridView2.DataSource = bindingSource2;
                uc_bindingNavigator2.BindingSource = bindingSource2;
                dt_D.xPiecesProduct_Column.DefaultValue = (int)dataGridView1["x_", e.RowIndex].Value;
                generateForm_D();

                foreach (DataGridViewRow row in this.dataGridView2.Rows)
                {
                    if ((!row.IsNewRow && (row.Cells["combobox_PiecesLine1_"].Value != DBNull.Value)) && (row.Cells["combobox_PiecesLine1_"].Value != null))
                    {
                        (row.Cells["xMoldList_"] as DataGridViewComboBoxCell).DataSource = new BLL.Mold.csMold().MoldCombo((int?)row.Cells["combobox_PiecesLine1_"].Value);
                    }
                }
            }

           
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView1();
            dt_I.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView2.SelectedCells;
        }



        private void DataGridView2_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.dataGridView2.Columns[e.ColumnIndex].Name == "combobox_PiecesLine1_"))
            {
                this.dataGridView2["xMoldList_", e.RowIndex].Value = DBNull.Value;
                if (this.dataGridView2[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    (this.dataGridView2["xMoldList_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.Mold.csMold().MoldCombo((int?)this.dataGridView2[e.ColumnIndex, e.RowIndex].Value);
                }
                else
                {
                    (this.dataGridView2["xMoldList_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.Mold.csMold().MoldCombo((-1));
                }
            }
        }

        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.dataGridView2.Columns[e.ColumnIndex].Name == "xMoldList_"))
            //{
            //    this.dataGridView2["xMoldList_", e.RowIndex].Value = DBNull.Value;
            //    if (this.dataGridView2["combobox_PiecesLine1_", e.RowIndex].Value != DBNull.Value)
            //    {
            //        (this.dataGridView2["xMoldList_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.Mold.csMold().MoldCombo((int?)this.dataGridView2["combobox_PiecesLine1_", e.RowIndex].Value);
            //    }
            //    else
            //    {
            //        (this.dataGridView2["xMoldList_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.Mold.csMold().MoldCombo((-1));
            //    }
            //}
           
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void DataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);

        }
    }
}
