using System;
using System.Windows.Forms;

namespace Payazob.FRM.DestructionReport
{
    public partial class frmDestructionReport : Form
    {
        public frmDestructionReport()
        {
            InitializeComponent();


            BLL.csPieces cp = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_piece = new DataGridViewComboBoxColumn();
            combobox_piece.DisplayIndex = 1;
            combobox_piece.HeaderText = "نام قطعه";
            dataGridView1.Columns.Add(combobox_piece);
            combobox_piece.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_piece.DisplayMember = "xName";
            combobox_piece.ValueMember = "x_";
            combobox_piece.Name = "xPiceces_";
            combobox_piece.Width = 200;
            combobox_piece.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_piece.DataPropertyName = "xPieces_";
            combobox_piece.Visible = false;


            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = csm.SlGenGroup("DESRPT");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "نتیجه";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xGprResult_";
            combobox_Type_.Name = "xGprResult_";
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_Type_.Visible = false;

            dataGridView1.Columns.Add(combobox_Type_);


        }
        DLQ.DestructionReport.DataClasses_DestructionReportsDataContext db;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {


            db = new DLQ.DestructionReport.DataClasses_DestructionReportsDataContext();

            bindingSource1.DataSource = db.SelectDestructionReportByDate(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = bindingSource1;
            Generate();

        }
        void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xGrindingPlace"].HeaderText = "محل تراش";
            dataGridView1.Columns["xDefect"].HeaderText = "نوع عیوب مشاهده شده";
            dataGridView1.Columns["xDepth"].Visible = false;
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xApprove_"].HeaderText = "ثبت کننده";
            
            dataGridView1.Columns["xTractionTest"].HeaderText = "تعداد تست تنش";
            dataGridView1.Columns["xTensionTest"].HeaderText = "تعداد تست تخریب";

            dataGridView1.Columns["xComment"].Width = 300;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["xPiceces_"].Visible = true;
            dataGridView1.Columns["xGprResult_"].Visible = true;
            dataGridView1.Columns["xDate"].Visible = true;
            dataGridView1.Columns["xDate"].DisplayIndex = 0;
            dataGridView1.Columns["xDateProduction"].Visible = true;



        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            bindingSource1.EndEdit();
            db.SubmitChanges();
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["xApprove_"].Value = BLL.authentication.x_;
        }

        private void frmDestructionReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
                if (dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                    dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
                else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
                    dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;  
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
