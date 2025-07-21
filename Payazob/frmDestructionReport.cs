using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmDestructionReport : Form
    {
        private DAL.DataSet_QualityControl.SelectDestructionReportByDateDataTable dt_Destruction;
        private class State
        {
            public string Name { get; set; }
            public int Value { get; set; }

        }

        private class City { public string Name { get; set; } }

        List<State> States = new List<State>
        {
            new State
            {
                Name = "سالم",
                Value = 1
            },
            new State
            {
                Name = "معیوب",
                Value = 2
            },
            new State
            {
                Name = "سایر",
                Value = 3
            }


        };
        public frmDestructionReport()
        {
            InitializeComponent();
            BLL.csQualityControl cs = new BLL.csQualityControl();
            dt_Destruction = cs.SelectDestructionReportByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);

            bindingSource1.DataSource = dt_Destruction;
            dataGridView1.DataSource = bindingSource1;
            //dataGridView1.Columns["DateOfYear"].HeaderText = "روزشمار";
            //dataGridView1.Columns["Year"].HeaderText = "سال روز شمار";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xGrindingPlace"].HeaderText = "محل تراشکاری";
            dataGridView1.Columns["xDepth"].HeaderText = "عمق";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xPieces"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["xShift_"].Visible = false;
            dataGridView1.Columns["xPiceces_"].Visible = false;
            dataGridView1.Columns["xResult"].Visible = false;
            dataGridView1.Columns["ResultDes"].Visible = false;
            dataGridView1.Columns["Shift"].Visible = false;
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xDateProduction"].HeaderText = "تاریخ تولید";
            dataGridView1.Columns["xDateProduction"].ReadOnly = true;

            dt_Destruction.Columns["xApprove_"].DefaultValue = BLL.authentication.x_;
            dt_Destruction.Columns["xDate"].DefaultValue = date;
            dataGridView1.Columns["xDate"].Visible = false;


            DataGridViewComboBoxColumn cmbShift = new DataGridViewComboBoxColumn();
            cmbShift.DisplayIndex = 0;
            cmbShift.HeaderText = "شیفت";
            dataGridView1.Columns.Add(cmbShift);
            BLL.csShift shift = new BLL.csShift();
            cmbShift.DataSource = shift.mShiftDataTable();
            cmbShift.DisplayMember = "xShiftName";
            cmbShift.ValueMember = "x_";
            cmbShift.Name = "xShift_";
            cmbShift.DataPropertyName = "xShift_";
            cmbShift.ValueType = typeof(int);

            BLL.csPieces cp = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_piece = new DataGridViewComboBoxColumn();
            combobox_piece.DisplayIndex = 1;
            combobox_piece.HeaderText = "نام قطعه";
            dataGridView1.Columns.Add(combobox_piece);
            combobox_piece.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_piece.DisplayMember = "xName";
            combobox_piece.ValueMember = "x_";
            combobox_piece.Name = "xPiceces_";
            combobox_piece.DataPropertyName = "xPiceces_";
            combobox_piece.ValueType = typeof(int);


            DataGridViewComboBoxColumn cmbResult = new DataGridViewComboBoxColumn();
            cmbResult.DataSource = States;
            cmbResult.DisplayMember = "name";
            cmbResult.ValueMember = "Value";
            cmbResult.HeaderText = "نتیجه";
            cmbResult.Name = "cmbResult";
            dataGridView1.Columns.Add(cmbResult);

            DataGridViewTextBoxColumn txtDayOfYer = new DataGridViewTextBoxColumn();
            txtDayOfYer.ValueType = typeof(int);
            txtDayOfYer.HeaderText = "روز شمار";
            txtDayOfYer.Name = "txtDayOfYer";
            dataGridView1.Columns.Add(txtDayOfYer);


            DataGridViewTextBoxColumn Year = new DataGridViewTextBoxColumn();
            Year.ValueType = typeof(int);
            Year.HeaderText = "سال";
            Year.Name = "Year";

            dataGridView1.Columns.Add(Year);


            //  dataGridView1.Columns["xComment"].DisplayIndex = dataGridView1.Columns.Count - 1;

            uc_bindingNavigator1.BindingSource = bindingSource1;

            toolStripTextBoxDateFrom.Text = date;
            toolStripTextBoxDateTo.Text = date;

        }

        string date = BLL.csshamsidate.shamsidate;

        private void generateForm()
        {
            //"xDate","xSupplier_","xName","xFamily","xEnter","xExit
            dataGridView1.DataSource = dt_Destruction;
            bindingSource1.DataSource = dataGridView1.DataSource;
            dataGridView1.Columns["DateOfYear"].HeaderText = "روزشمار";
            dataGridView1.Columns["Year"].HeaderText = "سال روز شمار";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xGrindingPlace"].HeaderText = "محل تراشکاری";
            dataGridView1.Columns["xDepth"].HeaderText = "عمق";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            toolStripTextBoxDateFrom.Text = date;
            toolStripTextBoxDateTo.Text = date;

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (!item.IsNewRow)
                    foreach (DataGridViewCell t in item.Cells)
                    {
                        if (t is DataGridViewComboBoxCell)
                            if (t.Value == null)
                            {
                                MessageBox.Show("اطلاعات ورودی صحیح نمی باشد");
                                return;
                            }
                    }

            }
            BLL.csQualityControl cs = new BLL.csQualityControl();


            DataTable dt = new DataTable();
            dt.TableName = "MyTable";
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.Name, col.ValueType);
            }
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                if (gridRow.IsNewRow)
                    continue;
                DataRow dtRow = dt.NewRow();
                for (int i1 = 0; i1 < dataGridView1.Columns.Count; i1++)
                {
                    if (gridRow.Cells[i1].ValueType == typeof(int) || gridRow.Cells[i1].ValueType == typeof(decimal))
                        dtRow[i1] = (gridRow.Cells[i1].Value == DBNull.Value ? 0 : gridRow.Cells[i1].Value);
                    else if (gridRow.Cells[i1].ValueType == typeof(string))
                        dtRow[i1] = (gridRow.Cells[i1].Value == DBNull.Value ? "" : gridRow.Cells[i1].Value);
                    else
                        dtRow[i1] = (gridRow.Cells[i1].Value == null ? DBNull.Value : gridRow.Cells[i1].Value);

                }

                dt.Rows.Add(dtRow);
            }
            dt_Destruction.Clear();
            MessageBox.Show("ارسال با موفقیت انجام شد.");
            //   dataGridView1.Rows.Clear();

            cs.InsertDestructionReport(dt);
        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {
            //      RefreshForm();
            BLL.csshamsidate Sham = new BLL.csshamsidate();
            BLL.csQualityControl cs = new BLL.csQualityControl();
            dt_Destruction.Clear();
            dt_Destruction = cs.SelectDestructionReportByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            bindingSource1.DataSource = dt_Destruction;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["cmbResult"].DisplayIndex = 12;

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Cells["ResultDes"].Value == null)
                {
                    item.Cells["cmbResult"].Value = 3;
                }
                else if (item.Cells["ResultDes"].Value.ToString() == "سالم")
                {
                    item.Cells["cmbResult"].Value = 1;
                }
                else if (item.Cells["ResultDes"].Value.ToString() == "معيوب")
                {
                    item.Cells["cmbResult"].Value = 2;

                }
                else
                {
                    item.Cells["cmbResult"].Value = 3;

                }
                //پر کردن روز شمار و سال تولید
                if (item.Cells["xDateProduction"].Value != null)
                {
                    item.Cells["txtDayOfYer"].Value = Sham.DayOfYearShamsi(item.Cells["xDateProduction"].Value.ToString());
                    item.Cells["Year"].Value = item.Cells["xDateProduction"].Value.ToString().Substring(0, 4); 
                }

                
            }
            DisableWhileShow();
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            // dataGridView1.EndEdit();

            BLL.csQualityControl cs = new BLL.csQualityControl();
            cs.UpdateDestructionReport(dt_Destruction);

            MessageBox.Show("ارسال با موفقیت انجام شد.");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //برای مقدار دهی با بول به xresult
            if (e.ColumnIndex == dataGridView1.Columns["cmbResult"].Index)
            {
                if (dataGridView1["cmbResult", e.RowIndex].Value != null && (int)dataGridView1["cmbResult", e.RowIndex].Value < 3)
                {
                    if ((int)dataGridView1["cmbResult", e.RowIndex].Value == 1)
                        dataGridView1["xResult", e.RowIndex].Value = true;
                    else
                        dataGridView1["xResult", e.RowIndex].Value = false;
                }
                else
                {
                    dataGridView1["xResult", e.RowIndex].Value = DBNull.Value;
                }
            }

        }

        private void frmDestructionReport_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["cmbResult"].DisplayIndex = 12;

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["txtDayOfYer"].Index || e.ColumnIndex == dataGridView1.Columns["Year"].Index)
            {
                if (dataGridView1["Year", e.RowIndex].EditedFormattedValue.ToString() != "" && dataGridView1["txtDayOfYer", e.RowIndex].EditedFormattedValue.ToString() != "" )
                {
                  dataGridView1["xDateProduction", e.RowIndex].Value =  BLL.csshamsidate.ShamsiDateAndDayOfYear(int.Parse(dataGridView1["Year", e.RowIndex].EditedFormattedValue.ToString()),int.Parse(dataGridView1["txtDayOfYer", e.RowIndex].EditedFormattedValue.ToString()));
                  
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["txtDayOfYer"].Index || e.ColumnIndex == dataGridView1.Columns["Year"].Index)
            {
                if (dataGridView1["Year", e.RowIndex].EditedFormattedValue.ToString() != "")
                    if (int.Parse(dataGridView1["Year", e.RowIndex].EditedFormattedValue.ToString()) < 1370 || int.Parse(dataGridView1["Year", e.RowIndex].EditedFormattedValue.ToString()) > 1399)
                    {
                        e.Cancel = true;
                    }
                if (dataGridView1["txtDayOfYer", e.RowIndex].EditedFormattedValue.ToString() != "")
                    if (int.Parse(dataGridView1["txtDayOfYer", e.RowIndex].EditedFormattedValue.ToString()) < 1 || int.Parse(dataGridView1["txtDayOfYer", e.RowIndex].EditedFormattedValue.ToString()) > 366)
                    {
                        e.Cancel = true;
                    }
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            dt_Destruction.Clear();
            bindingSource1.DataSource = dt_Destruction;
            dataGridView1.DataSource = bindingSource1;
            EnableWhileNew();
        }
        private void DisableWhileShow()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void EnableWhileNew()
        {
            bindingNavigatorAddNewItem.Enabled = true;
            dataGridView1.AllowUserToAddRows = true;
        }


        //private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["cmbResult"].Index && e.Control is ComboBox)
        //    {
        //        ComboBox comboBox = e.Control as ComboBox;
        //        comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
        //    }
        //}

        //private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        //{
        //    var currentcell = dataGridView1.CurrentCellAddress;
        //    var sendingCB = sender as DataGridViewComboBoxEditingControl;
        //    DataGridViewTextBoxCell cel = (DataGridViewTextBoxCell)dataGridView1.Rows[currentcell.Y].Cells[dataGridView1.Columns["ResultDes"].Index];
        //    cel.Value = sendingCB.EditingControlFormattedValue.ToString();
        //}


    }
}
