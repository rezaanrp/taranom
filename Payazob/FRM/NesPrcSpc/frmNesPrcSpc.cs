using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.NesPrcSpc
{
    public partial class frmNesPrcSpc : Form
    {
        public frmNesPrcSpc()
        {
            InitializeComponent();


            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            BLL.csPieces csp = new BLL.csPieces();
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
            combobox_xPieces_.Name = "xPieces_";
            combobox_xPieces_.Width = 200;
            combobox_xPieces_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xPieces_);

            DataGridViewComboBoxColumn combobox_CDPRC_ = new DataGridViewComboBoxColumn();
            combobox_CDPRC_.DataSource = csm.SlGenGroup("CNPRC");
            combobox_CDPRC_.DisplayMember = "xName";
            combobox_CDPRC_.HeaderText = "پارامتر کنترلی";
            combobox_CDPRC_.ValueMember = "x_";
            combobox_CDPRC_.DataPropertyName = "xGenCtrlParameter_";
            combobox_CDPRC_.Name = "cmb_CNPRC";
            combobox_CDPRC_.Width = 100;
            combobox_CDPRC_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_CDPRC_);


            //-----------------------------------------------------------------------

            DataGridViewComboBoxColumn combobox_NMPRC_ = new DataGridViewComboBoxColumn();
            combobox_NMPRC_.DataSource = csm.SlGenGroup("NMPRC");
            combobox_NMPRC_.DisplayMember = "xName";
            combobox_NMPRC_.HeaderText = "نام فرآیند";
            combobox_NMPRC_.ValueMember = "x_";
            combobox_NMPRC_.DataPropertyName = "xGenPrcName_";
            combobox_NMPRC_.Name = "cmb_Type";
            combobox_NMPRC_.Width = 100;
            combobox_NMPRC_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_NMPRC_);


            //-----------------------------------------------------------------------


            DataGridViewComboBoxColumn combobox_SubjectChart_ = new DataGridViewComboBoxColumn();
            combobox_SubjectChart_.DataSource = csm.SlGenGroup("SBJCHR");
            combobox_SubjectChart_.DisplayMember = "xName";
            combobox_SubjectChart_.HeaderText = "عنوان نمودار کنترلی";
            combobox_SubjectChart_.ValueMember = "x_";
            combobox_SubjectChart_.DataPropertyName = "xSubjectChart_";
            combobox_SubjectChart_.Name = "cmb_SubjectChart_";
            combobox_SubjectChart_.Width = 100;
            combobox_SubjectChart_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_SubjectChart_);


            //-----------------------------------------------------------------------


        }


        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xPieces_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }
        DAL.NesPrcSPC.DataSet_NesPrcSpc.mNesPrcSpcDataTable dt_N;
        DAL.NesPrcSPC.DataSet_NesPrcSpc.mNesPrcSpcDetialsDataTable dt_ND;
        void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            //dataGridView1.Columns["xPieces_"].HeaderText = "";
            dataGridView1.Columns["xCodePrc"].HeaderText = "کد فرایند";
            //dataGridView1.Columns["xGenPrcName_"].HeaderText = "";
            //dataGridView1.Columns["xGenCtrlParameter_"].HeaderText = "";
            dataGridView1.Columns["xGenIndxPerf"].HeaderText = "شاخص سنجش عملکرد";
            dataGridView1.Columns["xInxRange"].HeaderText = "اندازه شاخص";
           // dataGridView1.Columns["xSubjectChart_"].HeaderText = "عنوان نمودار کنترل";
            dataGridView1.Columns["xCountSample"].HeaderText = "تعداد نمونه ها";
            dataGridView1.Columns["xSizeSample"].HeaderText = "اندازه هر نمونه";
            dataGridView1.Columns["xPrdSample"].HeaderText = "دوره نمونه گیری";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
        }

        private void frmNesPrcSpc_Load(object sender, EventArgs e)
        {
            BLL.NesPrcSPC.csNesPrcSpc cs = new BLL.NesPrcSPC.csNesPrcSpc();
            dt_N = cs.SlNesPrcSpc();
            bindingSource1.DataSource = dt_N;
            dataGridView1.DataSource = bindingSource1;
            dt_N.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_N.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            uc_bindingNavigator1.BindingSource = bindingSource1;

            Generate();

        }
        void SaveDataGridView()
        {
            this.Validate();
            dataGridView1.EndEdit();
            BLL.NesPrcSPC.csNesPrcSpc cs = new BLL.NesPrcSPC.csNesPrcSpc();
            MessageBox.Show(cs.UdNesPrcSpc(dt_N), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bindingSource1.DataSource = dt_N;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            Generate();

        }
        void SaveDataGridViewDetials()
        {
            this.Validate();
            dataGridView2.EndEdit();
            BLL.NesPrcSPC.csNesPrcSpc cs = new BLL.NesPrcSPC.csNesPrcSpc();
            MessageBox.Show(cs.UdNesPrcSpcDetail(dt_ND), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bindingSource2.DataSource = dt_ND;
            dataGridView2.DataSource = bindingSource2;
            //Generate();

        }
        void GenerateD()
        {
            dataGridView2.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xWCp"].HeaderText = "Within CP";
            dataGridView2.Columns["xWCpk"].HeaderText = "Within CPK";
            dataGridView2.Columns["xWPpm"].HeaderText = "Within PPM";
            dataGridView2.Columns["xOPp"].HeaderText = "Overall PP";
            dataGridView2.Columns["xOppk"].HeaderText =  "Overall PPK";
            dataGridView2.Columns["xOCpm"].HeaderText = "Overall CPM";
            dataGridView2.Columns["xOPpm"].HeaderText = "Overall PPM";
            dataGridView2.Columns["xNp"].HeaderText = "NP";
            dataGridView2.Columns["xLsl"].HeaderText = "LSL";
            dataGridView2.Columns["xUsl"].HeaderText = "USL";
            dataGridView2.Columns["xXBarUcl"].HeaderText = "XBar Ucl";
            dataGridView2.Columns["xXBarLcl"].HeaderText = "XBar Lcl";
            dataGridView2.Columns["xRUcl"].HeaderText = "R Ucl";
            dataGridView2.Columns["xRLcl"].HeaderText = "R Lcl";

        }
        void ShowDataGridViewD(int Index, int? xSubjectChart_)
        {
            BLL.NesPrcSPC.csNesPrcSpc cs = new BLL.NesPrcSPC.csNesPrcSpc();
            dt_ND = cs.SlNesPrcSpcDetail(Index,uc_Filter_Date1.DateFrom,uc_Filter_Date1.DateTo);
            bindingSource2.DataSource = dt_ND;
            dataGridView2.DataSource = bindingSource2;
            dt_ND.xNesPrcSpc_Column.DefaultValue = Index;
            dt_ND.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_ND.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xNesPrcSpc_"].Visible = false;

            if (xSubjectChart_ == 30)
            {
                dataGridView2.Columns["xNP"].Visible = false;
                dataGridView2.Columns["xXBarUcl"].Visible = true;
                dataGridView2.Columns["xXBarLcl"].Visible = true;
                dataGridView2.Columns["xRUcl"].Visible = true;
                dataGridView2.Columns["xRLcl"].Visible = true;
            }
            else if (xSubjectChart_ == 31)
            {
                dataGridView2.Columns["xXBarUcl"].Visible = false;
                dataGridView2.Columns["xXBarLcl"].Visible = false;
                dataGridView2.Columns["xRUcl"].Visible = false;
                dataGridView2.Columns["xRLcl"].Visible = false;
                dataGridView2.Columns["xNP"].Visible = true;

            }
            else if (xSubjectChart_ == 32)
            {
                dataGridView2.Columns["xNP"].Visible = true;
                dataGridView2.Columns["xNP"].Visible = false;
                dataGridView2.Columns["xXBarUcl"].Visible = true;
                dataGridView2.Columns["xXBarLcl"].Visible = true;
                dataGridView2.Columns["xRUcl"].Visible = true;
                dataGridView2.Columns["xRLcl"].Visible = true;
            }
            else
            {
                dataGridView2.Columns["xNP"].Visible = false;
                dataGridView2.Columns["xNP"].Visible = false;
                dataGridView2.Columns["xXBarUcl"].Visible = false;
                dataGridView2.Columns["xXBarLcl"].Visible = false;
                dataGridView2.Columns["xRUcl"].Visible = false;
                dataGridView2.Columns["xRLcl"].Visible = false;
            }
            GenerateD();

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView();
        }
        bool te = false;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (te)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xPieces_")
                {
                    uc_DataGridViewBtn1.Visible = true;
                    var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y);
                    uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
                    uc_DataGridViewBtn1.RI = e.RowIndex;
                    uc_DataGridViewBtn1.CI = e.ColumnIndex;
                }
                else
                    uc_DataGridViewBtn1.Visible = false;
                if(dataGridView1["cmb_SubjectChart_", e.RowIndex].Value != DBNull.Value)
                ShowDataGridViewD((int)dataGridView1["x_", e.RowIndex].Value, (int?)dataGridView1["cmb_SubjectChart_", e.RowIndex].Value);
            }
       
              
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            SaveDataGridViewDetials();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            te = true;
        }

    }
}
