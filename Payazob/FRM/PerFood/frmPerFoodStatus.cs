using System;
using System.Data;
using System.Windows.Forms;
using BLL.PerFoodStatus;

namespace Payazob.FRM.PerFood
{
    public partial class frmPerFoodStatus : Form
    {
        public frmPerFoodStatus()
        {
            InitializeComponent();
            ShowOnDataGridView();

            dt_w.TableNewRow += new DataTableNewRowEventHandler(dt_w_TableNewRow);

            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 3;
            combobox_xSupplier_.HeaderText = "نام و نام خانوادگی";
            combobox_xSupplier_.DataSource = new BLL.PerFoodStatus.csPerFoodStatus().SlPerson();
            combobox_xSupplier_.DisplayMember = "Name";
            combobox_xSupplier_.ValueMember = "PERNO";
            combobox_xSupplier_.DataPropertyName = "xPerCode";
            combobox_xSupplier_.Width = 200;
            combobox_xSupplier_.DropDownWidth = 20;
            combobox_xSupplier_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xSupplier_);

            uc_TextBoxDate1.Text = BLL.csshamsidate.shamsidate;
        }

        void dt_w_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            uc_txtBox_Present.Text = dt_w.Rows.Count.ToString();

        }
        
        DAL.WinKart.DataSet_PerFoodStatus.SlPerFoodStatusDataTable dt_w;
        private void ShowOnDataGridView()
        {
            csPerFoodStatus status = new csPerFoodStatus();
            this.dt_w = status.SlPerFoodStatus(BLL.csshamsidate.shamsidate, BLL.csshamsidate.shamsidate);
            DataTable table = status.SlIOInfo();
            DataTable table2 = new BLL.Person.csPersonInfo().SlPersonInfo("$$", "");
            foreach (DataRow row in table.Rows)
            {
                if (this.dt_w.Select("xPerCode = " + row["PERNO"].ToString()).Length == 0)
                {
                    DataRow[] rowArray = table2.Select("xPerID = '" + row["PERNO"].ToString().Replace(" ", "") + "'");
                    if ((rowArray.Length > 0) && (((int)rowArray[0]["xSection_"]) != 80))
                    {
                        DataRow row2 = this.dt_w.NewRow();
                        row2["xPerCode"] = row["PERNO"].ToString();
                        row2["xDate"] = BLL.csshamsidate.shamsidate;
                        row2["xSupplier_"] = BLL.authentication.x_;
                        row2["xLunch"] = true;
                        this.dt_w.Rows.Add(row2);
                    }
                }
            }
            this.dataGridView1.DataSource = this.dt_w;
            this.bindingSource1.DataSource = this.dt_w;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.dt_w.Columns["xDate"].DefaultValue = BLL.csshamsidate.shamsidate;
            this.dt_w.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xSupplier_"].Visible = false;
            this.dataGridView1.Columns["xPerName"].Visible = false;
            this.dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            this.dataGridView1.Columns["xLunch"].HeaderText = "نهار";
            this.dataGridView1.Columns["xPerCode"].HeaderText = "شماره پرسنلی";
            this.dataGridView1.Columns["xDinner"].HeaderText = "شام";
            this.uc_txtBox_Present.Text = this.dt_w.Rows.Count.ToString();

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowOnDataGridView();

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                        DataView view = new DataView(dt_w);
                        DataTable distinctValues = view.ToTable(true, "xPerCode");
                   if (distinctValues.Rows.Count == dt_w.Rows.Count)
                   {

                       BLL.PerFoodStatus.csPerFoodStatus cs = new BLL.PerFoodStatus.csPerFoodStatus();
                       MessageBox.Show(cs.UdPerFoodStatus(dt_w));
                       PrintData();
                   }
                   else
                   MessageBox.Show("اطلاعات وارده تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            countFood();
        }

        void countFood()
        {
            int SumL = 0;
            int SumD = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {

                if (item.Cells["xLunch"].Value != null && item.Cells["xLunch"].Value != DBNull.Value && (bool)item.Cells["xLunch"].Value)
                {
                    SumL++;
                }
                if (item.Cells["xDinner"].Value != null && item.Cells["xDinner"].Value != DBNull.Value && (bool)item.Cells["xDinner"].Value)
                {
                    SumD++;
                }

            }
            uc_txtBox_Dinner.Text = SumD.ToString();
            uc_txtBox_Lunch.Text = SumL.ToString();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }

        void PrintData()
        {
            base.Validate();
            this.dataGridView1.EndEdit();
            Report.SendReport report = new Report.SendReport();
            report.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport report2 = new frmReport
            {
                GetReport = report.GetReport(new csPerFoodStatus().SlPerFoodStatusList(BLL.csshamsidate.shamsidate, BLL.csshamsidate.shamsidate), "crsPerFoodStatus")
            };
            report2.ShowDialog();
            report2.Dispose();

        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //PrintData();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Selected = false;
            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                foreach (DataGridViewCell itemCell in item.Cells)
                {

                    if (
                        itemCell.Visible == true && itemCell.Value != DBNull.Value && itemCell.Value != null && 
                        ( itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text) ||
                         itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text.Replace('ی', 'ي'))  ||
                          itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text.Replace('ي', 'ی')) ||
                           itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text.Replace('ک', 'ك')) ||
                            itemCell.FormattedValue.ToString().Contains(toolStripTextBox1.Text.Replace('ك', 'ک'))  )
                        )
                    {
                        item.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = item.Index > 1 ? item.Index - 2 : item.Index;
                        return;
                    }
                   
                    
                }
            }
        }
        bool flag = true;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if(!item.IsNewRow)
                (item.Cells["xLunch"] as DataGridViewCheckBoxCell).Value = flag;
                
            }
            flag = !flag;
        }

        private void toolStripButtonListView_Click(object sender, EventArgs e)
        {
            //Form f;
            //f = new frmEmpty_Report("PerFoodStatus", "");
            //(f as frmEmpty_Report).ReportHaveDateDetails = true;
            //(f as frmEmpty_Report).FilterDate = true;
            //(f as frmEmpty_Report).SetParam("x_", false);
            //(f as frmEmpty_Report).SetParam("xSupplier_", false);
            //f.ShowDialog();

        }
    }
}
