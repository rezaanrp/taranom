using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.DestructionReport
{
    public partial class frmDestructionPiecesTurning : Form
    {
        public frmDestructionPiecesTurning()
        {
            InitializeComponent();


            BLL.csPieces pieces = new BLL.csPieces();
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                DisplayIndex = 4,
                HeaderText = "نام قطعه",
                DataSource = pieces.mPiecesDataTable(0x99),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "xPieces_",
                Width = 200,
                MinimumWidth = 30,
                DataPropertyName = "xPieces_",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                MaxDropDownItems = 20
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);
            this.dt_R = new DAL.DestructionReport.DataSet_DestructionPiecesTurning.mDestructionPiecesTurningDataTable();
            this.bindingSource1.DataSource = this.dt_R;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.Generate();

        }
       
        DAL.DestructionReport.DataSet_DestructionPiecesTurning.mDestructionPiecesTurningDataTable dt_R;

        void Generate()
        {
            CS.csDic dic = new CS.csDic();
            foreach (DataColumn column in this.dt_R.Columns)
            {
                this.dataGridView1.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
            }
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xComment"].Width = 300;

        }

        void ShowDataGridView()
        {

            dt_R = new BLL.Destruction.csDestruction().mDestructionPiecesTurning(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            Generate();
        }

        void SaveDataGridView()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                BLL.RequestItService.csRequestItService cs = new BLL.RequestItService.csRequestItService();


                MessageBox.Show(new  BLL.Destruction.csDestruction().UdDestructionPiecesTurning(dt_R), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGridView();
                Generate();

            }
        }

        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new ControlLibrary.uc_ExportExcelFile { Fildvg = dataGridView1 }.RunExcel();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
