using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Payazob.FRM.CustomerReturn
{
    public partial class frmCustomerReturn : Form
    {
        public frmCustomerReturn(string Section)
        {
            InitializeComponent();

            BLL.csPieces csp = new BLL.csPieces();

            Sec = Section;

            dt_c = new DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnDataTable();
            bindingSource1.DataSource = dt_c;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;


            BLL.csCompony cm = new BLL.csCompony();
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 3;
            combobox_xSupplier_.HeaderText = "نام مشتری";
            combobox_xSupplier_.DataSource = cm.SelectCustomer();
            combobox_xSupplier_.DisplayMember = "xComponyName";
            combobox_xSupplier_.ValueMember = "x_";
            combobox_xSupplier_.DataPropertyName = "xCustomer_";
            combobox_xSupplier_.Name = "cmb_Supplier";
            combobox_xSupplier_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox_xSupplier_.DisplayIndex = dataGridView1.Columns["xCustomer_"].DisplayIndex = 2;
            dataGridView1.Columns.Add(combobox_xSupplier_);

            dt_P = new DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnPiecesDataTable();
            bindingSource2.DataSource = dt_P;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;

            dt_S = new DAL.CustomerReturn.DataSet_CustomerReturn.SlCustomerReturnScrapDataTable();
            bindingSource3.DataSource = dt_S;
            dataGridView3.DataSource = bindingSource3;
            bindingNavigator3.BindingSource = bindingSource3;


            BLL.GenGroup.csGenGroup csmg = new BLL.GenGroup.csGenGroup();

            DataGridViewComboBoxColumn combobox_TRP_ = new DataGridViewComboBoxColumn();
            combobox_TRP_.DataSource = csmg.SlGenGroup("TRP");
            combobox_TRP_.DisplayMember = "xName";
            combobox_TRP_.HeaderText = "نوع برگشتی";
            combobox_TRP_.ValueMember = "x_";
            combobox_TRP_.DataPropertyName = "xTypeReturn_";
            combobox_TRP_.Name = "cmb_TypeReturn_";
            combobox_TRP_.Width = 100;
            combobox_TRP_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView2.Columns.Add(combobox_TRP_);


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
            dataGridView2.Columns.Add(combobox_xPieces_);

            DataGridViewComboBoxColumn combobox_xSupplier2_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier2_.DisplayIndex = 8;
            combobox_xSupplier2_.HeaderText = "نام کاربر";
            combobox_xSupplier2_.DataSource = new BLL.authentication().NameOfUser();
            combobox_xSupplier2_.DisplayMember = "NameAndFamily";
            combobox_xSupplier2_.ValueMember = "x_";
            combobox_xSupplier2_.DataPropertyName = "xSupplier_";
            combobox_xSupplier2_.Name = "cmb_xSupplier2_";
            combobox_xSupplier2_.Width = 200;
            combobox_xSupplier2_.ReadOnly = true;

            combobox_xSupplier2_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView2.Columns.Add(combobox_xSupplier2_);



            DataGridViewComboBoxColumn combobox_Defect_ = new DataGridViewComboBoxColumn();
            combobox_Defect_.DisplayIndex = 3;
            combobox_Defect_.HeaderText = "نوع ضایعه";
            combobox_Defect_.DataSource = new BLL.csDefect().SelectDefectList();
            combobox_Defect_.DisplayMember = "xDefectName";
            combobox_Defect_.ValueMember = "x_";
            combobox_Defect_.DataPropertyName = "xScrapType_";
            combobox_Defect_.Name = "cmb_xScrapType_";
            combobox_Defect_.Width = 100;
            combobox_Defect_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView3.Columns.Add(combobox_Defect_);

            


            uc_DataGridViewBtn1.ColumnsFilter_ = "xComponyName";
            uc_DataGridViewBtn1.Ds = cm.SelectCustomer();

            uc_DataGridViewBtn1.ParamName = new string[] { "xComponyName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام شرکت" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
  "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;

            //****************************************************************************************************

            uc_DataGridViewBtn2.ColumnsFilter_ = "xName";
            uc_DataGridViewBtn2.Ds = csp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);

            uc_DataGridViewBtn2.ParamName = new string[] { "xName" };
            uc_DataGridViewBtn2.ParamValue = new string[] { "نام قطعه" };
            uc_DataGridViewBtn2.ParamHide = new string[] { "x_" };

            formFunctionPointer1 += new functioncall1(Replicate1);
            uc_DataGridViewBtn2.userFunctionPointer = formFunctionPointer1;


            //*****************************************************************************************************
            Generate();
            GenerateP();
            GenerateS();


            
         // dataGridView1.Columns["dvgUploadFile"].DisplayIndex = 10;
         // dataGridView1.Columns["dvgSaveFile"].DisplayIndex = 10;
         // dataGridView1.Columns["dvgDeleteFile"].DisplayIndex = 10;
            System.Windows.Forms.DataGridViewButtonColumn dvgUploadFile = new DataGridViewButtonColumn();
            System.Windows.Forms.DataGridViewButtonColumn dvgSaveFile = new DataGridViewButtonColumn();
            System.Windows.Forms.DataGridViewButtonColumn dvgDeleteFile = new DataGridViewButtonColumn();
         // private System.Windows.Forms.DataGridViewButtonColumn dvgSaveFile;
         // private System.Windows.Forms.DataGridViewButtonColumn dvgDeleteFile;
            dvgUploadFile.HeaderText = "بارگزاری";
            dvgUploadFile.Name = "dvgUploadFile";
            dvgUploadFile.Text = "بارگزاری";
            dvgUploadFile.UseColumnTextForButtonValue = true;
            dvgUploadFile.Width = 50;
            dvgUploadFile.Visible = false;

          //  dvgUploadFile.DisplayIndex = 10;
            dataGridView1.Columns.Add(dvgUploadFile);

            dvgSaveFile.HeaderText = "باز کردن سند";
            dvgSaveFile.Name = "dvgSaveFile";
            dvgSaveFile.Text = "بازکردن";
            dvgSaveFile.UseColumnTextForButtonValue = true;
            dvgSaveFile.Width = 50;
            dvgSaveFile.Visible = true;
           // dvgSaveFile.DisplayIndex = 9;
            dataGridView1.Columns.Add(dvgSaveFile);

            dvgDeleteFile.HeaderText = "خذف سند";
            dvgDeleteFile.Name = "dvgDeleteFile";
            dvgDeleteFile.Text = "حذف";
            dvgDeleteFile.UseColumnTextForButtonValue = true;
            dvgDeleteFile.Width = 50;
            dvgDeleteFile.Visible = false;
         //   dvgDeleteFile.DisplayIndex = 8;
            dataGridView1.Columns.Add(dvgDeleteFile);

            if (Sec == "PR")
            {
   splitContainer6.Panel2Collapsed = true;
   dvgSaveFile.Visible = false;
            }
            else if (Sec == "QC")
            {
   dataGridView1.AllowUserToAddRows = false;
   dataGridView1.AllowUserToDeleteRows = false;
   dataGridView2.AllowUserToAddRows = false;
   dataGridView2.AllowUserToDeleteRows = false;
   dataGridView1.ReadOnly = true;
   dataGridView2.ReadOnly = true;
   uc_DataGridViewBtn1.Enabled = false;
   uc_DataGridViewBtn2.Enabled = false;
   dvgDeleteFile.Visible = true;
   dvgSaveFile.Visible = true;
   dvgUploadFile.Visible = true;
   //dataGridView1.
            }
            else if (Sec == "PL")
            {
   dataGridView1.AllowUserToAddRows = false;
   dataGridView1.AllowUserToDeleteRows = false;
   dataGridView2.AllowUserToAddRows = false;
   dataGridView2.AllowUserToDeleteRows = false;
   dataGridView1.ReadOnly = true;
   dataGridView2.ReadOnly = true;
   uc_DataGridViewBtn1.Enabled = false;
   uc_DataGridViewBtn2.Enabled = false;

            }
            else if (Sec == "TR")
            {
   dataGridView1.AllowUserToAddRows = false;
   dataGridView1.AllowUserToDeleteRows = false;
   dataGridView2.AllowUserToAddRows = false;
   dataGridView2.AllowUserToDeleteRows = false;
   dataGridView1.ReadOnly = true;
   dataGridView2.ReadOnly = true;
   uc_DataGridViewBtn1.Enabled = false;
   uc_DataGridViewBtn2.Enabled = false;
            }

            else
            {
   dataGridView1.AllowUserToAddRows = false;
   dataGridView1.AllowUserToDeleteRows = false;
   dataGridView2.AllowUserToAddRows = false;
   dataGridView2.AllowUserToDeleteRows = false;
   dataGridView3.AllowUserToAddRows = false;
   dataGridView3.AllowUserToDeleteRows = false;
   dataGridView1.ReadOnly = true;
   dataGridView2.ReadOnly = true;
   dataGridView3.ReadOnly = true;
   uc_DataGridViewBtn1.Enabled = false;
   uc_DataGridViewBtn2.Enabled = false;
   saveToolStripButton.Visible = false;
   SavetoolStripButton_Pieces.Visible = false;
   toolStripButton_SaveScarp.Visible = false;
            }

        }

        string Sec = "";

        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
   dataGridView1["xCustomer_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
   dataGridView1["cmb_Supplier", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }

        public delegate void functioncall1(string Display, string value);

        private event functioncall1 formFunctionPointer1;

        private void Replicate1(string Display, string value)
        {
            if (value != "-1")
            {
   dataGridView2["xPieces_", uc_DataGridViewBtn2.RI].Value = int.Parse(value);
   dataGridView2["cmb_xPieces_", uc_DataGridViewBtn2.RI].Value = int.Parse(value);
            }
        }


        DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnDataTable dt_c;
        DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnPiecesDataTable dt_P;
        DAL.CustomerReturn.DataSet_CustomerReturn.SlCustomerReturnScrapDataTable dt_S;

        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        void SaveDataCustomerReturn()
        {

            this.Validate();
            dataGridView1.EndEdit();
           

            BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
            MessageBox.Show(cs.UdCustomerReturn(dt_c), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SaveDataCustomerReturnPieces()
        {
            this.Validate();
            dataGridView2.EndEdit();
            BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
            MessageBox.Show(cs.UdCustomerReturnPieces(dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SaveDataCustomerReturnScrap()
        {
            this.Validate();
            dataGridView3.EndEdit();
            BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
            int? C1 = pCountPieces;
            int? C2 = 0;
            foreach (DataGridViewRow item in dataGridView3.Rows)
            {
   C2 += (int?)item.Cells["xCount"].Value == null ? 0 : (int?)item.Cells["xCount"].Value; 
            }
            if (C2 != C1)
            {
   MessageBox.Show("تعداد با محصول برگشتی مطابقت ندارد");
            }
            else
            MessageBox.Show(cs.UdCustomerReturnScrap(dt_S), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ShowData()
        {
            BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
            dt_c = cs.mCustomerReturn(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_c;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            dataGridView1.Columns["dvgUploadFile"].DisplayIndex = 11;
            dataGridView1.Columns["dvgSaveFile"].DisplayIndex = 11;
            dataGridView1.Columns["dvgDeleteFile"].DisplayIndex = 11;
        }

        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_c.Columns)
            {
   if (dataGridView1.Columns[dc.ColumnName] != null)
   dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["x_"].Visible = false;

        }

        void GenerateP()
        {
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xCustomerReturn_"].Visible = false;
            dataGridView2.Columns["xTypeReturn_"].Visible = false;

            dataGridView2.Columns["xPieces_"].HeaderText = "سریال قطعه ";
            dataGridView2.Columns["xCount"].HeaderText = "تعداد";
            dataGridView2.Columns["xSupplier_"].Visible = false;

        }

        void GenerateS()
        {

            foreach (DataColumn dc in dt_S.Columns)
            {
   if (dataGridView3.Columns[dc.ColumnName] != null)
      dataGridView3.Columns[dc.ColumnName].Visible = Dtable(dc.ColumnName, Sec);
            }

            dataGridView3.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView3.Columns["xCount"].HeaderText = "تعداد";
            dataGridView3.Columns["xConfirmQC"].HeaderText = "تایید کیفیت";
            dataGridView3.Columns["xConfirmTR"].HeaderText = "تایید بازرگانی";
            dataGridView3.Columns["xConfirmPL"].HeaderText = "تایید برنامه ریزی";
            dataGridView3.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView3.Columns["xWell"].HeaderText = "سالم";
            dataGridView3.Columns["xWell"].Width = 50;
            dataGridView3.Columns["xConfirmQCUser"].HeaderText = "کاربر کنترل کیفیت";
            dataGridView3.Columns["xConfirmTRUser"].HeaderText = "کاربر بازرگانی";
            dataGridView3.Columns["xConfirmPLUser"].HeaderText = "کاربر برنامه ریزی";
            dataGridView3.Columns["xCommentTR"].HeaderText = "توضیحات بازرگانی";//,xCommentTR  ,xCommentPL 
            dataGridView3.Columns["xCommentPL"].HeaderText = "توضیحات برنامه ریزی";

            if (Sec == "PL")
            {
   dataGridView3.Columns["xCustomerReturnPieces_"].ReadOnly = true;
     dataGridView3.Columns["xDate"].ReadOnly = true;
   dataGridView3.Columns["xScrapType_"].ReadOnly = true;
  dataGridView3.Columns["xWell"].ReadOnly = true;
   dataGridView3.Columns["xScrapType"].ReadOnly = true;
   dataGridView3.Columns["xCount"].ReadOnly = true;
   dataGridView3.Columns["xConfirmQC"].ReadOnly = true;
   dataGridView3.Columns["xConfirmQC_"].ReadOnly = true;
   dataGridView3.Columns["xConfirmQCUser"].ReadOnly = true;
   dataGridView3.Columns["xConfirmTR"].ReadOnly = true;
   dataGridView3.Columns["xConfirmTR_"].ReadOnly = true;
   dataGridView3.Columns["xConfirmPL"].ReadOnly = true;
   dataGridView3.Columns["xConfirmTRUser"].ReadOnly = true;
   dataGridView3.Columns["xAddSendProduct"].ReadOnly = true;//,xCommentTR  ,xCommentPL 
   dataGridView3.Columns["xCommentTR"].ReadOnly = true;//,xCommentTR  ,xCommentPL 
   dataGridView3.Columns["xCommentPL"].ReadOnly = false;//,xCommentTR  ,xCommentPL 
   
   foreach (DataGridViewRow item in dataGridView3.Rows)
   {
       if ((bool?)item.Cells["xConfirmTR"].Value == true && (bool?)item.Cells["xConfirmQC"].Value == true)
       {
           item.Cells["xConfirmPL"].ReadOnly = false;
       }
   }

            }
            else if (Sec == "PR")
            {
   dataGridView3.Columns["xCommentTR"].ReadOnly = true;//,xCommentTR  ,xCommentPL 
   dataGridView3.Columns["xCommentPL"].ReadOnly = true;
            }
            else if (Sec == "QC")
            {
   dataGridView3.Columns["xCustomerReturnPieces_"].ReadOnly = true;
   dataGridView3.Columns["xDate"].ReadOnly = true;
   dataGridView3.Columns["xScrapType_"].ReadOnly = true;
   dataGridView3.Columns["xConfirmTR"].ReadOnly = true;
   dataGridView3.Columns["xConfirmTR_"].ReadOnly = true;
   dataGridView3.Columns["xConfirmTRUser"].ReadOnly = true;
   dataGridView3.Columns["xConfirmPL"].ReadOnly = true;
   dataGridView3.Columns["xConfirmPL_"].ReadOnly = true;
   dataGridView3.Columns["xConfirmPLUser"].ReadOnly = true;
   dataGridView3.Columns["xComment"].ReadOnly = true;
   dataGridView3.Columns["xAddSendProduct"].ReadOnly = true;
   dataGridView3.Columns["xCommentTR"].ReadOnly = true;//,xCommentTR  ,xCommentPL 
   dataGridView3.Columns["xCommentPL"].ReadOnly = true;

            }
            else if (Sec == "TR")
            {
   dataGridView3.Columns["xCustomerReturnPieces_"].ReadOnly = true;
   dataGridView3.Columns["xDate"].ReadOnly = true; 
   dataGridView3.Columns["xScrapType_"].ReadOnly = true; 
   dataGridView3.Columns["xWell"].ReadOnly = true; 
   dataGridView3.Columns["xScrapType"].ReadOnly = true; 
   dataGridView3.Columns["xCount"].ReadOnly = true; 
   dataGridView3.Columns["xConfirmQC"].ReadOnly = true; 
   dataGridView3.Columns["xConfirmQC_"].ReadOnly = true; 
   dataGridView3.Columns["xConfirmQCUser"].ReadOnly = true; 
   dataGridView3.Columns["xConfirmPL"].ReadOnly = true; 
   dataGridView3.Columns["xConfirmPL_"].ReadOnly = true; 
   dataGridView3.Columns["xConfirmPLUser"].ReadOnly = true;
   dataGridView3.Columns["xConfirmTR"].ReadOnly = true;
   dataGridView3.Columns["Pieces_"].ReadOnly = true; 
   dataGridView3.Columns["xAddSendProduct"].ReadOnly = true;
   dataGridView3.Columns["xCommentTR"].ReadOnly = false;//,xCommentTR  ,xCommentPL 
   dataGridView3.Columns["xCommentPL"].ReadOnly = true;

   foreach (DataGridViewRow item in dataGridView3.Rows)
   {
       if ((bool?)item.Cells["xConfirmQC"].Value == true)
       {
           item.Cells["xConfirmTR"].ReadOnly = false;
       }
   }
            }
            else
            {


            }





        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dt_P = new DAL.CustomerReturn.DataSet_CustomerReturn.mCustomerReturnPiecesDataTable();
            // dataGridView2.DataSource = null;
            bindingSource2.DataSource = dt_P;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;


            if ((int?)dataGridView1["x_", e.RowIndex].Value > 0)
            {
   BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();


   dt_P = cs.mCustomerReturnPieces((int)dataGridView1["x_", e.RowIndex].Value);
   bindingSource2.DataSource = dt_P;
   dataGridView2.DataSource = bindingSource2;
   bindingNavigator2.BindingSource = bindingSource2;
   dt_P.xCustomerReturn_Column.DefaultValue = (int)dataGridView1["x_", e.RowIndex].Value;
   dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;

   GenerateP();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xCustomer_")
            {
   uc_DataGridViewBtn1.Visible = true;
   var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
   uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y); ;
   uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
   uc_DataGridViewBtn1.RI = e.RowIndex;
   uc_DataGridViewBtn1.CI = e.ColumnIndex;
            }

            else
   uc_DataGridViewBtn1.Visible = false;
        }

        int? pCountPieces = 0;

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            pCountPieces = dataGridView2["xCount", e.RowIndex].Value == DBNull.Value ? null : (int?)dataGridView2["xCount", e.RowIndex].Value; 
            if ((int?)dataGridView2["x_", e.RowIndex].Value > 0)
            {
   BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
   dt_S = cs.SlCustomerReturnScrap((int)dataGridView2["x_", e.RowIndex].Value, Sec, (int)dataGridView2["xPieces_", e.RowIndex].Value);
   bindingSource3.DataSource = dt_S;
   dataGridView3.DataSource = bindingSource3;
   bindingNavigator3.BindingSource = bindingSource3;
   dt_S.xCustomerReturnPieces_Column.DefaultValue = (int)dataGridView2["x_", e.RowIndex].Value;
   dt_S.xWellColumn.DefaultValue = false;
   dt_S.xConfirmPLColumn.DefaultValue = false;
   dt_S.xConfirmQCColumn.DefaultValue = false;
   dt_S.xConfirmTRColumn.DefaultValue = false;
   GenerateS();
            }
            else
            {
   //bindingSource3.DataSource = null;
   //dataGridView3.DataSource = bindingSource3;
   //bindingNavigator3.BindingSource = bindingSource3;
            }

            if (dataGridView2.Columns[e.ColumnIndex].Name == "xPieces_")
            {
   uc_DataGridViewBtn2.Visible = true;
   var cellRectangle = dataGridView2.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
   uc_DataGridViewBtn2.Location = new Point(cellRectangle.X, cellRectangle.Y); ;
   uc_DataGridViewBtn2.Size = new Size(20, dataGridView2.Rows[e.RowIndex].Height);
   uc_DataGridViewBtn2.RI = e.RowIndex;
   uc_DataGridViewBtn2.CI = e.ColumnIndex;
            }

            else
   uc_DataGridViewBtn2.Visible = false;


        }

        bool Dtable(string Cl, string Ty)
        {
            DataTable dt_AC = new DataTable();
            dt_AC.Columns.Add("Name", typeof(String));
            dt_AC.Columns.Add("Type", typeof(String));
            dt_AC.Columns.Add("Allow", typeof(bool));

            dt_AC.Rows.Add("x_", "QC", false);
            dt_AC.Rows.Add("xCustomerReturnPieces_", "QC", false);
            dt_AC.Rows.Add("xDate", "QC", false);
            dt_AC.Rows.Add("xScrapType_", "QC", false);
            dt_AC.Rows.Add("xScrapType", "QC", false);
            dt_AC.Rows.Add("xCount", "QC", true);
            dt_AC.Rows.Add("xConfirmQC", "QC", true);
            dt_AC.Rows.Add("xConfirmQC_", "QC", false);
            dt_AC.Rows.Add("xConfirmTR", "QC", false);
            dt_AC.Rows.Add("xConfirmTR_", "QC", false);
            dt_AC.Rows.Add("xConfirmPL", "QC", false);
            dt_AC.Rows.Add("xConfirmPL_", "QC", false);
            dt_AC.Rows.Add("xComment", "QC", false);
            dt_AC.Rows.Add("Pieces_", "QC", false);
            dt_AC.Rows.Add("xAddSendProduct", "QC", false);

            dt_AC.Rows.Add("x_", "PL", false);
            dt_AC.Rows.Add("xCustomerReturnPieces_", "PL", false);
            dt_AC.Rows.Add("xDate", "PL", false);
            dt_AC.Rows.Add("xScrapType_", "PL", false);
            dt_AC.Rows.Add("xScrapType", "PL", false);
            dt_AC.Rows.Add("xCount", "PL", true);
            dt_AC.Rows.Add("xConfirmQC", "PL", false);
            dt_AC.Rows.Add("xConfirmQC_", "PL", false);
            dt_AC.Rows.Add("xConfirmTR", "PL", false);
            dt_AC.Rows.Add("xConfirmTR_", "PL", false);
            dt_AC.Rows.Add("xConfirmPL", "PL", true);
            dt_AC.Rows.Add("xConfirmPL_", "PL", false);
            dt_AC.Rows.Add("xComment", "PL", true);
            dt_AC.Rows.Add("Pieces_", "PL", false);
            dt_AC.Rows.Add("xAddSendProduct", "PL", false);


            dt_AC.Rows.Add("x_", "TR", false);
            dt_AC.Rows.Add("xCustomerReturnPieces_", "TR", false);
            dt_AC.Rows.Add("xDate", "TR", false);
            dt_AC.Rows.Add("xScrapType_", "TR", false);
            dt_AC.Rows.Add("xScrapType", "TR", false);
            dt_AC.Rows.Add("xCount", "TR", true);
            dt_AC.Rows.Add("xConfirmQC", "TR", false);
            dt_AC.Rows.Add("xConfirmQC_", "TR", false);
            dt_AC.Rows.Add("xConfirmTR", "TR", true);
            dt_AC.Rows.Add("xConfirmTR_", "TR", false);
            dt_AC.Rows.Add("xConfirmPL", "TR", false);
            dt_AC.Rows.Add("xConfirmPL_", "TR", false);
            dt_AC.Rows.Add("xComment", "TR", false);
            dt_AC.Rows.Add("Pieces_", "TR", false);
            dt_AC.Rows.Add("xAddSendProduct", "TR", false);

            dt_AC.Rows.Add("x_", "$$", false);
            dt_AC.Rows.Add("xCustomerReturnPieces_", "$$", false);
            dt_AC.Rows.Add("xDate", "$$", true);
            dt_AC.Rows.Add("xScrapType_", "$$", false);
            dt_AC.Rows.Add("xScrapType", "$$", false);
            dt_AC.Rows.Add("xCount", "$$", true);
            dt_AC.Rows.Add("xConfirmQC", "$$", true);
            dt_AC.Rows.Add("xConfirmQC_", "$$", false);
            dt_AC.Rows.Add("xConfirmTR", "$$", true);
            dt_AC.Rows.Add("xConfirmTR_", "$$", false);
            dt_AC.Rows.Add("xConfirmPL", "$$", true);
            dt_AC.Rows.Add("xConfirmPL_", "$$", false);
            dt_AC.Rows.Add("xComment", "$$", true);
            dt_AC.Rows.Add("Pieces_", "$$", false);
            dt_AC.Rows.Add("xAddSendProduct", "$$", false);


            DataRow[] dr = dt_AC.Select("Name = '" + Cl + "' AND Type = '" + Ty + "'");
            if (dr.Length > 0)
   return (bool)dr[0]["Allow"];
            else
   return true;

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataCustomerReturn();
        }

        private void SavetoolStripButton_Pieces_Click(object sender, EventArgs e)
        {
            SaveDataCustomerReturnPieces();
        }

        private void toolStripButton_SaveScarp_Click(object sender, EventArgs e)
        {
            SaveDataCustomerReturnScrap();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
   if (dataGridView1.Columns[e.ColumnIndex].Name == "xDateEnter")
   {
       FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
       var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
       fr.StartPosition = FormStartPosition.CenterParent;
       fr.ShowDialog();
       if (fr.accept)
           dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
   }
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            dt_c.xCodeColumn.DefaultValue = BLL.csshamsidate.shamsidate.Substring(2, 2)
         + BLL.csshamsidate.shamsidate.Substring(5, 2);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex > -1 && e.RowIndex > -1 && (dataGridView1.Columns[e.ColumnIndex].Name == "xCustomer_"
   || dataGridView1.Columns[e.ColumnIndex].Name == "cmb_Supplier"))
            {
   dataGridView1["xCode", e.RowIndex].Value = BLL.csshamsidate.shamsidate.Substring(2, 2)
        + BLL.csshamsidate.shamsidate.Substring(5, 2)
       + "-" + new BLL.CustomerReturn.csCustomerReturn().
       GenCode(int.Parse(dataGridView1["xCustomer_", e.RowIndex].FormattedValue.ToString()),
             Payazob.Properties.Settings.Default.WorkYear.ToString());
            }

        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView3.Columns["xConfirmQC"].Index)
   if ((bool)dataGridView3["xConfirmQC", e.RowIndex].Value == true)
   {
       dataGridView3["xConfirmQC_", e.RowIndex].Value = BLL.authentication.x_;
   }
   else
       dataGridView3["xConfirmQC_", e.RowIndex].Value = DBNull.Value;

            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView3.Columns["xConfirmTR"].Index)
   if ((bool)dataGridView3["xConfirmTR", e.RowIndex].Value == true)
   {
       dataGridView3["xConfirmTR_", e.RowIndex].Value = BLL.authentication.x_;
   }
   else
       dataGridView3["xConfirmTR_", e.RowIndex].Value = DBNull.Value;

            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView3.Columns["xConfirmPL"].Index)
   if ((bool)dataGridView3["xConfirmPL", e.RowIndex].Value == true)
   {
       dataGridView3["xConfirmPL_", e.RowIndex].Value = BLL.authentication.x_;
   }
   else
       dataGridView3["xConfirmPL_", e.RowIndex].Value = DBNull.Value;
        }

        private void frmCustomerReturn_LocationChanged(object sender, EventArgs e)
        {
            uc_DataGridViewBtn1.Visible = false;
            uc_DataGridViewBtn2.Visible = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
            try
            {

   OpenFileDialog dlgOpen = new OpenFileDialog();

   dlgOpen.Filter =

      "مستندات(*.zip)|*.zip";

   dlgOpen.Title = "انتخاب فایل";
     System.IO.MemoryStream ms = new System.IO.MemoryStream();
   if (dlgOpen.ShowDialog() == DialogResult.OK)
   {
       //dlgOpen.
       FileStream fs = new FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read);
       byte[] file = new byte[fs.Length];
       fs.Read(file, 0, System.Convert.ToInt32(fs.Length));
       fs.Close();
       cs.INCustomerReturnImage(file,1);   
   }
            }

            catch (SystemException ex)
            {

   MessageBox.Show(ex.Message);

            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
           
            byte[] file = cs.mCustomerReturnImage(1);

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "unknown.zip";
            // set filters - this can be done in properties as well
            savefile.Filter = "مستندات (*.zip)|*.zip";

            if (savefile.ShowDialog() == DialogResult.OK)
            {

   File.WriteAllBytes(savefile.FileName, file);
      
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            uc_DataGridViewBtn2.Visible = false;
  #region upload
            if (e.ColumnIndex > -1 && dataGridView1.Columns[e.ColumnIndex].Name == "dvgUploadFile")
            {
   {
       if ((int)dataGridView1["x_", e.RowIndex].Value > 0)
       {

           BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
           if (cs.CountStore((int)dataGridView1["x_", e.RowIndex].Value) < 1)
           {
  try
  {

      OpenFileDialog dlgOpen = new OpenFileDialog();

      dlgOpen.Filter =

         "مستندات(*.zip)|*.zip";

      dlgOpen.Title = "انتخاب فایل";
      System.IO.MemoryStream ms = new System.IO.MemoryStream();
      if (dlgOpen.ShowDialog() == DialogResult.OK)
      {
          //dlgOpen.
          FileStream fs = new FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read);
          byte[] file = new byte[fs.Length];
          fs.Read(file, 0, System.Convert.ToInt32(fs.Length));
          fs.Close();
          cs.INCustomerReturnImage(file, (int)dataGridView1["x_", e.RowIndex].Value);
      }
  }

  catch (SystemException ex)
  {

      MessageBox.Show(ex.Message);

  }
           }
           else
           {
  MessageBox.Show("قبلا یک سند ذخیره شده");
           }


       }
       else
           MessageBox.Show("ابتدا دکمه ذخیره را زده بعد از ان سند را به رکورد ضمیمه کنید");
   }
            }
            #endregion
      
  #region دانلود

   if (e.ColumnIndex > -1 && dataGridView1.Columns[e.ColumnIndex].Name == "dvgSaveFile")
   {

       if ((int)dataGridView1["x_", e.RowIndex].Value > 0)
       {
           BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();

           byte[] file = cs.mCustomerReturnImage((int)dataGridView1["x_", e.RowIndex].Value);
           if (file == null)
           {
  MessageBox.Show("مستنداتی ذخیره نشده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
  return;
           }
           SaveFileDialog savefile = new SaveFileDialog();
           savefile.FileName = "unknown.zip";
           // set filters - this can be done in properties as well
           savefile.Filter = "مستندات (*.zip)|*.zip";

           if (savefile.ShowDialog() == DialogResult.OK)
           {

  File.WriteAllBytes(savefile.FileName, file);

           }

       }
       else
       {
           MessageBox.Show("ابتدا دکمه ذخیره را زده بعد از ان سند را به رکورد ضمیمه کنید");

       }

   }

   #endregion

  #region delete

     if (e.ColumnIndex > -1 &&  dataGridView1.Columns[e.ColumnIndex].Name == "dvgDeleteFile")
   {

       if ((int)dataGridView1["x_", e.RowIndex].Value > 0)
       {
           BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
           cs.DeleteQueryImage((int)dataGridView1["x_", e.RowIndex].Value );

       }
       else
       {
           MessageBox.Show("ابتدا دکمه ذخیره را زده بعد از ان سند را به رکورد ضمیمه کنید");

       }
     }
   #endregion
            
        }

 


    }
}
