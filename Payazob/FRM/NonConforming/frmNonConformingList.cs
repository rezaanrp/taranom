using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmNonConformingList : Form
    {
        public frmNonConformingList()
        {
            InitializeComponent();
            dt_N = new DAL.NonConforming.DataSet_NonConforming.SlNonconformingDataTable();
            bindingSource1.DataSource = dt_N;
            dataGridView_dwn.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            //-----------------------------------------------------------------------
            BLL.csPieces csp =  new BLL.csPieces();
            uc_DataGridViewBtn1.ColumnsFilter_ = "xName";
            uc_DataGridViewBtn1.Ds = csp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);

            uc_DataGridViewBtn1.ParamName = new string[] { "xName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام قطعه" };
            uc_DataGridViewBtn1.ParamHide = new string[] {"x_"
                //, "xKind" ,"xStandard","xPieceweight","xTechnicalname","xSolutionweight","xKbythtotal",
             //  "xImage","xMarkettype","xMusclekhoury"
                                                            };

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;
            //------------------------------------------------------------------------

            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn();
            combobox_xPieces_.DisplayIndex = 3;
            combobox_xPieces_.HeaderText = "نام قطعه";
            combobox_xPieces_.DataSource = csp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_xPieces_.DisplayMember = "xName";
            combobox_xPieces_.ValueMember = "x_";
            combobox_xPieces_.DataPropertyName = "xPieces_";
            combobox_xPieces_.Name = "cmb_xPieces_";
            combobox_xPieces_.Width = 200;
            combobox_xPieces_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView_dwn.Columns.Add(combobox_xPieces_);

            DataGridViewComboBoxColumn combobox_NonConform_ = new DataGridViewComboBoxColumn();
            combobox_NonConform_.DisplayIndex = dataGridView_dwn.Columns["xNonConformingType_"].DisplayIndex;
            combobox_NonConform_.HeaderText = "نوع عدم تطابق";
            combobox_NonConform_.DataSource = new BLL.Nonconforming.csNonconforming().SlNonconformingType();
            combobox_NonConform_.DisplayMember = "xNonConformingName";
            combobox_NonConform_.ValueMember = "x_";
            combobox_NonConform_.DataPropertyName = "xNonConformingType_";
            combobox_NonConform_.Name = "cmb_xNonConformingType_";
            combobox_NonConform_.Width = 200;
            combobox_NonConform_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView_dwn.Columns.Add(combobox_NonConform_);

            Generate();

        }

        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView_dwn["xPieces_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
             //   dataGridView1["cmb_Supplier", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_dwn.Columns[e.ColumnIndex].Name == "xPieces_")
            {
                uc_DataGridViewBtn1.Visible = true;
                var cellRectangle = dataGridView_dwn.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y);
                uc_DataGridViewBtn1.Size = new Size(20, dataGridView_dwn.Rows[e.RowIndex].Height);
                uc_DataGridViewBtn1.RI = e.RowIndex;
                uc_DataGridViewBtn1.CI = e.ColumnIndex;
            }
            else
                uc_DataGridViewBtn1.Visible = false;

           if (dataGridView_dwn.Columns[e.ColumnIndex].Name == "xNonConformingType_")
            {
                btn_TreeView.Visible = true;
                var cellRectangle = dataGridView_dwn.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                btn_TreeView.Location = new Point(cellRectangle.X, cellRectangle.Y);
                btn_TreeView.Size = new Size(20, dataGridView_dwn.Rows[e.RowIndex].Height);
            }
            else
               btn_TreeView.Visible = false;


           if (dataGridView_dwn.Columns[e.ColumnIndex].Name == "xDateProuduct" || dataGridView_dwn.Columns[e.ColumnIndex].Name == "xNonconformTitleDate" || dataGridView_dwn.Columns[e.ColumnIndex].Name == "xTakenActionDate")
            {
                FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                var cellRectangle = dataGridView_dwn.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                fr.Location = new Point(cellRectangle.X, cellRectangle.Y);
                fr.ShowDialog();
               if(fr.accept)
                dataGridView_dwn[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
            }

        }



        DAL.NonConforming.DataSet_NonConforming.SlNonconformingDataTable dt_N;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            dt_N = new BLL.Nonconforming.csNonconforming().SlNonconforming(uc_Filter_Date1.DateFrom,uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_N;
            dataGridView_dwn.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
            dataGridView_dwn.Columns["x_"].Width = 60;
            dataGridView_dwn.Columns["cmb_xNonConformingType_"].Width = 73;
            dataGridView_dwn.Columns["xPieces_"].Width = 68;
            dataGridView_dwn.Columns["xQuarantineNumber"].Width = 86;
            dataGridView_dwn.Columns["xTime"].Width = 63;
            dataGridView_dwn.Columns["xDateProuduct"].Width = 71;
            dataGridView_dwn.Columns["xFormNo"].Width = 76;
            dataGridView_dwn.Columns["xNonconformTitleDate"].Width = 101;
            dataGridView_dwn.Columns["xNonconformTitle"].Width = 352;
            dataGridView_dwn.Columns["xControllerName"].Width = 70;
            dataGridView_dwn.Columns["xTakenActionDate"].Width = 100;
            dataGridView_dwn.Columns["xTakenAction"].Width = 474;
            dataGridView_dwn.Columns["xResult"].Width = 613;
            dataGridView_dwn.Columns["xQualityComment"].Width = 124;
            dataGridView_dwn.Columns["xNonConformingType_"].Width = 106;
            dataGridView_dwn.Columns["cmb_xPieces_"].Width = 140;
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_N.Columns)
            {
                dataGridView_dwn.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            dt_N.xDateProuductColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_N.xNonconformTitleDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_N.xTakenActionDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
        }

        private void btn_TreeView_Click(object sender, EventArgs e)
        {
            FRM.NonConforming.frmNonConformingType frm = new FRM.NonConforming.frmNonConformingType();
            frm.StartPosition = FormStartPosition.Manual;
            frm.SetDesktopLocation(Cursor.Position.X - frm.Width, Cursor.Position.Y + 10);
            frm.ShowDialog();
            if (frm.Node_x_ != -1)
                dataGridView_dwn["xNonConformingType_", dataGridView_dwn.SelectedCells[0].RowIndex].Value = frm.Node_x_;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.dataGridView_dwn.EndEdit();
                this.Validate();
                BLL.Nonconforming.csNonconforming cs = new BLL.Nonconforming.csNonconforming();
                MessageBox.Show(cs.UdNonconforming(dt_N));
                dt_N = cs.SlNonconforming(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                bindingSource1.DataSource = dt_N;
                dataGridView_dwn.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                Generate();
            }
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmNonConformingList_RegionChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView_dwn;
            uc.RunExcel();
        }
    }
}
