using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSandWeeklyTestList : Form
    {
        public frmSandWeeklyTestList()
        {
            InitializeComponent();

            BLL.csshamsidate cs = new BLL.csshamsidate();

        }
        DAL.Sand.DataSet_SandWeeklyTest.SelectSandWeeklyTestSummaryByDateDataTable dt_sand;

        void generate()
        {

            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xAfsBefore"].HeaderText = "دانه بندی قبل از شستشو";
            dataGridView1.Columns["xAfsAfter"].HeaderText = "دانه بندی بعد از شستشو";
            dataGridView1.Columns["xVolatilePercent"].HeaderText = "درصد مواد فرار";
            dataGridView1.Columns["xBurningPercent"].HeaderText = "درصد مواد سوختنی";
            dataGridView1.Columns["xGlayPercent"].HeaderText = "درصد خاک";
            dataGridView1.Columns["xActiveBentnitePercent"].HeaderText = "درصد بنتونیت فعال";
            dataGridView1.Columns["xPermeability"].HeaderText = "عبور گاز";
            dataGridView1.Columns["Approve"].HeaderText = "تایید کننده";
            dataGridView1.Columns["xSupplier"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";

            dataGridView1.Columns["xGenGroup_"].Visible = false;
            dataGridView1.Columns["xGenGroup"].HeaderText = "نوع خط";


            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;


        }

        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
            ShowDataGridView1();
            lbl_help.Visible = true;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmSandWeeklyTest frm = new frmSandWeeklyTest();
            frm.Getx_ = -1;
            frm.ShowDialog();
            BLL.csSand cs = new BLL.csSand();
            dt_sand = cs.SelectSandWeeklyTestSummaryByDate(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = dt_sand;
            bindingSource1.DataSource = dataGridView1.DataSource;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            generate();
        }
        
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.csSand cs = new BLL.csSand();
                MessageBox.Show(cs.UpdateSandWeeklyTestSummaryByDate(dt_sand));
                ShowDataGridView1();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1["x_",e.RowIndex].Value != null)
            {
                lbl_help.Visible = false;
                frmSandWeeklyTest frm = new frmSandWeeklyTest();
                frm.Getx_ = (int)dataGridView1["x_", e.RowIndex].Value;
                frm.ShowDialog();
                BLL.csSand cs = new BLL.csSand();
                dt_sand = cs.SelectSandWeeklyTestSummaryByDate(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                dataGridView1.DataSource = dt_sand;
                bindingSource1.DataSource = dataGridView1.DataSource;
                uc_bindingNavigator1.BindingSource = bindingSource1;
                generate();
            }
        }
        void DataGridViewPrint()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Report.SendReport cs = new Report.SendReport();
                cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(new BLL.csSand().SandWeeklyTestByx_((int)dataGridView1.Rows[(dataGridView1.SelectedCells[0].RowIndex)].Cells["x_"].Value), "crsSandWeeklyTest");
                r.ShowDialog();
                r.Dispose();
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            DataGridViewPrint();
        }

        private void toolStripTextBoxDateFrom_Enter(object sender, EventArgs e)
        {
            string st = new CS.csDateform().DateOutPut((sender as ToolStripTextBox).Owner, (sender as ToolStripTextBox).Owner.Width / 2, 0);
            (sender as ToolStripTextBox).Text = st == "" ? (sender as ToolStripTextBox).Text : st;
        }
        void ShowDataGridView1()
        {
            BLL.csSand cs = new BLL.csSand();
            dt_sand = cs.SelectSandWeeklyTestSummaryByDate(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = dt_sand;
            bindingSource1.DataSource = dataGridView1.DataSource;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            generate();

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.Control | Keys.Enter):
                    ShowDataGridView1();
                    break;
                case (System.Windows.Forms.Keys.Control | Keys.P):
                    DataGridViewPrint();
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

     //       dataGridView1["xSupplier_", e.RowIndex].Value = BLL.authentication.x_;
              
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                   dataGridView1["xSupplier_", e.RowIndex].Value = BLL.authentication.x_;

        }
    }
}
