using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Site3.ProductInspection
{
    public partial class frmPiecesCorrectiveMachining : Form
    {
        public frmPiecesCorrectiveMachining()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 3,
                HeaderText = "نام قطعه",
                DataSource = new BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site3),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xPieces_",
                Name = "xPieces_",
                Width = 200,
                MaxDropDownItems = 30,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(combobox_xPieces_);


            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام OP",
                DataSource = new BLL.ProductOperation.csProductOperation().ProductOperationOpName(-1),
                DisplayMember = "xOpName",
                ValueMember = "x_",
                Name = "xOp_",
                DataPropertyName = "xOp_",
                Visible = true,
                Width = 70,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column2);


            DataGridViewComboBoxColumn column5 = new DataGridViewComboBoxColumn
            {
                HeaderText = "علت ضایعات",
                DataSource = new BLL.Defect.csDefect().mDefectListCauseMachining(-1),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "combobox_DefectListCauseMachining_",
                DataPropertyName = "xDefectListCauseMachining_",
                Visible = true,
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(column5);


            DataGridViewComboBoxColumn combobox_Per_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.Person.csPersonInfo().mPersonInfoBySec(154),
                DisplayMember = "Name",
                HeaderText = "اپراتور",
                ValueMember = "x_",
                DataPropertyName = "xPerID_",
                Name = "xPerID_",
                Width = 150,
                MaxDropDownItems = 30,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_Per_);

            ShowDataGridView();
        }

        DAL.PiecesCorrectiveMachining.PiecesCorrectiveMachining.mPiecesCorrectiveMachiningDataTable dt_R;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.dataGridView1.Columns[e.ColumnIndex].Name == "xPieces_"))
            {
                this.dataGridView1["xOp_", e.RowIndex].Value = DBNull.Value;
                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    (this.dataGridView1["xOp_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.ProductOperation.csProductOperation().ProductOperationOpName((int?)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                }
                else
                {
                    (this.dataGridView1["xOp_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.ProductOperation.csProductOperation().ProductOperationOpName(-1);
                }
            }

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);

        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_R.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xComment"].Width = 300;
            dataGridView1.Columns["xPerID_"].HeaderText = "اپراتور";


        }

        void ShowDataGridView()
        {
            dt_R = new BLL.PiecesCorrectiveMachining.csPiecesCorrectiveMachining().mPiecesCorrectiveMachining(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            Generate();
        }

        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                MessageBox.Show(new BLL.PiecesCorrectiveMachining.csPiecesCorrectiveMachining().UdPiecesCorrectiveMachining(dt_R), 
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGridView();
                Generate();

            }
        }

        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string cln = dataGridView1.Columns[e.ColumnIndex].Name;

            if (cln == "xDate")
            {

                FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                fr.StartPosition = FormStartPosition.CenterParent;
                fr.SetDate( dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() );
                fr.ShowDialog();
                if (fr.accept)
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                dataGridView1.ClearSelection();
             //   dataGridView1.CurrentCell = dataGridView1[1, e.RowIndex];
                //dataGridView1.CurrentCell = null;
                dataGridView1.Columns["xDate"].ReadOnly = true;
                dataGridView1[e.ColumnIndex + 1, e.RowIndex].Selected = true;

            }
        }


        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            SaveDataGridView();
        }
    }
}
