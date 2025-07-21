using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmProductInspectionList : Form
    {
        public frmProductInspectionList()
        {
            InitializeComponent();


            toolStripTextBoxDateFrom.Text = new BLL.csshamsidate().previousDay(7);
            toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;

            dt_I = new DAL.DataSet_Defect.SelectPruductInspectionByDateDataTable();
            dt_D = new DAL.DataSet_Defect.SelectDefectNameAndCountByProductInspection_DataTable();
            generateForm_I();
            generateForm_D();


            BLL.csPieces cp = new BLL.csPieces();

            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn();
            combobox_xPieces_.DisplayIndex = 4;
            combobox_xPieces_.HeaderText = "نام قطعه";
            combobox_xPieces_.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_xPieces_.DisplayMember = "xName";
            combobox_xPieces_.ValueMember = "x_";
            combobox_xPieces_.DataPropertyName = "xPiece_";
            combobox_xPieces_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xPieces_);

            BLL.csShift cs_shift = new BLL.csShift();
            DataGridViewComboBoxColumn combobox_xShift_ = new DataGridViewComboBoxColumn();
            combobox_xShift_.DisplayIndex = 4;
            combobox_xShift_.HeaderText = "نام شیفت";
            combobox_xShift_.DataSource = cs_shift.mShiftDataTable();
            combobox_xShift_.DisplayMember = "xShiftName";
            combobox_xShift_.ValueMember = "x_";
            combobox_xShift_.DataPropertyName = "xShift_";
            combobox_xShift_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xShift_);
        }
        DAL.DataSet_Defect.SelectPruductInspectionByDateDataTable dt_I;
        DAL.DataSet_Defect.SelectDefectNameAndCountByProductInspection_DataTable dt_D;

        private void generateForm_I()
        {


            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dataGridView1.DataSource;
            dataGridView1.Columns["xProductionDate"].HeaderText = "تاریخ تولید";
            dataGridView1.Columns["xShiftSuperviser"].HeaderText = "سرپرست شیفت";
            dataGridView1.Columns["xShiftInspector"].HeaderText = "اپراتور بازرس شیفت";
            dataGridView1.Columns["xFernesSuperviser"].HeaderText = "سرپرست کوره";
            dataGridView1.Columns["xSandOperator"].HeaderText = "اپراتور خط ماسه";

            dataGridView1.Columns["xShiftSuperviser"].ReadOnly = true;
            dataGridView1.Columns["xShiftInspector"].ReadOnly = true;
            dataGridView1.Columns["xFernesSuperviser"].ReadOnly = true;
            dataGridView1.Columns["xSandOperator"].ReadOnly = true;

            dataGridView1.Columns["xControlledNumber"].HeaderText = "تعداد کنترل شده";
            dataGridView1.Columns["DefectNumber"].HeaderText = "تعداد ضایع";
            dataGridView1.Columns["DefectNumber"].ReadOnly = true;
            dataGridView1.Columns["xDateInspect"].HeaderText = "تاریخ بازرسی";
            dataGridView1.Columns["xApprove"].HeaderText = "تایید شده";

            dataGridView1.Columns["xPiece_"].Visible = false;
            dataGridView1.Columns["xShift_"].Visible = false;

            dataGridView1.Columns["x_"].Visible = false;
            bindingNavigator1.BindingSource = bindingSource1;
           
            if (BLL.authentication.x_ != BLL.authentication.xApproveby_)
                dataGridView1.Columns["xApprove"].ReadOnly = true;

        }

        private void generateForm_D()
        {


            dataGridView_D.DataSource = dt_D;
            bindingSource_D.DataSource = dataGridView_D.DataSource;
            dataGridView_D.Columns["xDefectName"].HeaderText = "نوع ضایعات ";
            dataGridView_D.Columns["xDefectName"].ReadOnly = true;
            dataGridView_D.Columns["xDefectNumber"].HeaderText = "تعداد ضایعات";
            dataGridView_D.Columns["x_"].Visible = false;
            dataGridView_D.Columns["xDefectList_"].Visible = false;
            dataGridView_D.Columns["xDefectNumber"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bindingNavigator_D.BindingSource = bindingSource_D;
        }

        private void toolStripButton_I_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView1();

        }

        void ShowDataGridView1()
        {
            BLL.csDefect cs = new BLL.csDefect();
            dt_I = cs.SelectPruductInspectionByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;
            generateForm_I();
        }

        private void toolStripButton_I_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ایا می خواهید این اطلاعات ذخیره شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                dataGridView1.EndEdit();
                BLL.csDefect cs = new BLL.csDefect();
                cs.UpdatePruductInspection(dt_I);
            }
        }

        private void toolStripButton_D_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ایا می خواهید این اطلاعات ذخیره شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Validate();
                dataGridView_D.EndEdit();
                BLL.csDefect cs = new BLL.csDefect();
                cs.UpdateDefectNameAndCount(dt_D);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
          foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                                 if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmProductInspection frm = new frmProductInspection();
            frm.ShowDialog();

            BLL.csDefect cs = new BLL.csDefect();

            dt_I = cs.SelectPruductInspectionByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = dt_I;
            bindingSource1.DataSource = dataGridView1.DataSource;

            dt_D = cs.SelectDefectNameAndCountByProductInspection_(-1);
            bindingSource_D.DataSource = dt_D;
            dataGridView_D.DataSource = bindingSource_D;
            bindingNavigator1.BindingSource = bindingSource_D;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                BLL.csDefect cs = new BLL.csDefect();
                dt_D = cs.SelectDefectNameAndCountByProductInspection_((int)dataGridView1["x_", e.RowIndex].Value);
                bindingSource_D.DataSource = dt_D;
                dataGridView_D.DataSource = bindingSource_D;
                bindingNavigator_D.BindingSource = bindingSource_D;
                generateForm_D();
            }
        }

        private void toolStripTextBoxDateFrom_Enter(object sender, EventArgs e)
        {
            string st = new CS.csDateform().DateOutPut((sender as ToolStripTextBox).Owner, (sender as ToolStripTextBox).Owner.Width / 2, 0);
            (sender as ToolStripTextBox).Text = st == "" ? (sender as ToolStripTextBox).Text : st;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.Control | Keys.Enter):
                    ShowDataGridView1();
                    break;


            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
