using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Procurment
{
    public partial class frmProcurmentMaterialTest : Form
    {

        public frmProcurmentMaterialTest(string Se_)
        {
            Se = Se_;
            InitializeComponent();
            dt_P = new DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestDataTable();
            dt_P.xDateEnterColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xConfirmColumn.DefaultValue = false;
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.csMaterial csm = new BLL.csMaterial();
            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 4;
            combobox_xMaterialType_.HeaderText = "نوع مواد";
            combobox_xMaterialType_.DataSource = csm.SelectMeltName(60,-1,false);
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xMaterial_";
            combobox_xMaterialType_.Name = "cmb_Material";
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_xMaterialType_);


            DataGridViewComboBoxColumn combobox_xState_ = new DataGridViewComboBoxColumn();
            combobox_xState_.DisplayIndex = 4;
            combobox_xState_.HeaderText = "نام استان";
            combobox_xState_.DataSource = new BLL.State.csState().mState();
            combobox_xState_.DisplayMember = "xName";
            combobox_xState_.ValueMember = "x_";
            combobox_xState_.DataPropertyName = "xRegion_";
            combobox_xState_.Name = "cm_xRegion_";
            combobox_xState_.Width = 150;
            combobox_xState_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_xState_);



            BLL.csCompony cm = new BLL.csCompony();
            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 3;
            combobox_xSupplier_.HeaderText = "تامین کننده";
            combobox_xSupplier_.DataSource = cm.SelectSupplier();
            combobox_xSupplier_.DisplayMember = "xComponyName";
            combobox_xSupplier_.ValueMember = "x_";
            combobox_xSupplier_.DataPropertyName = "xSupplierCompany_";
            combobox_xSupplier_.Name = "cmb_Supplier";
            combobox_xSupplier_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_xSupplier_);

            dt_P.xSupplierColumn.DefaultValue = BLL.authentication.NameAndFamily;


            DataTable dt = new DataTable();
            dt.Columns.Add("State", typeof(string));
            dt.Columns.Add("Value", typeof(string));

            DataRow dr = dt.NewRow();
            dr["State"] = "قبول";
            dr["Value"] = "A";
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["State"] = "رد";
            dr1["Value"] = "D";
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["State"] = "مشروط";
            dr2["Value"] = "C";
            dt.Rows.Add(dr2);

            DataGridViewComboBoxColumn combobox_State = new DataGridViewComboBoxColumn();
            combobox_State.HeaderText = "وضعیت";
            combobox_State.DataSource = dt;
            combobox_State.DisplayMember = "State";
            combobox_State.ValueMember = "Value";
            combobox_State.DataPropertyName = "xState";
            combobox_State.Name = "cmb_State";
            combobox_State.DisplayIndex = dataGridView1.Columns["xComment"].DisplayIndex;
            combobox_State.Visible = true;
            dataGridView1.Columns.Add(combobox_State);


            ////////////////////////////////////////////Datagridview2
            BLL.csElement cme = new BLL.csElement();
            DataGridViewComboBoxColumn combobox_xElement = new DataGridViewComboBoxColumn();
            combobox_xElement.HeaderText = "نام عنصر";
            combobox_xElement.DataSource = cme.SelectElement();
            combobox_xElement.DisplayMember = "xNameElement";
            combobox_xElement.ValueMember = "x_";
            combobox_xElement.DataPropertyName = "xElement_";
            combobox_xElement.Name = "xElement_";
            dataGridView2.Columns.Add(combobox_xElement);


            ////////////////////////////////////////////Datagridview3
            DataGridViewComboBoxColumn combobox_xElement_A = new DataGridViewComboBoxColumn();
            combobox_xElement_A.HeaderText = "نام عنصر";
            combobox_xElement_A.DataSource = cme.SelectElement();
            combobox_xElement_A.DisplayMember = "xNameElement";
            combobox_xElement_A.ValueMember = "x_";
            combobox_xElement_A.DataPropertyName = "xElement_";
            combobox_xElement_A.Name = "xElement_";
            dataGridView3.Columns.Add(combobox_xElement_A);

            Generate();

            splitContainer5.Panel2Collapsed = true;

            if(Se == "PR")
                this.Text = "ثبت مواد کمکی ورودی";
            else if(Se == "QC")
                this.Text = "تایید مواد کمکی ورودی";

            else if(Se == "TR")
                this.Text = "تایید نهایی مواد کمکی ورودی";
            BLL.csshamsidate csSham = new BLL.csshamsidate();
            uc_Filter_Date1.DateFrom = csSham.previousDay(7);

            uc_DataGridViewBtn1.ColumnsFilter_ = "xComponyName";
            uc_DataGridViewBtn1.Ds = cm.SelectSupplier();

            uc_DataGridViewBtn1.ParamName = new string[] { "xComponyName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام شرکت" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
               "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;

        }
        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xSupplierCompany_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
                dataGridView1["cmb_Supplier", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }
        string Se = "";
        bool Dtable(string Cl,string Ty)
        {
            DataTable dt_AC = new DataTable();
            dt_AC.Columns.Add("Name",typeof(String));
            dt_AC.Columns.Add("Type",typeof(String));
            dt_AC.Columns.Add("Allow",typeof(bool));

            dt_AC.Rows.Add("x_", "QC", false);
            dt_AC.Rows.Add("xDateTest", "QC", true);
            dt_AC.Rows.Add("xDriverName", "QC", false);
            dt_AC.Rows.Add("xDriverTel", "QC", false);
            dt_AC.Rows.Add("xWeightBeginning", "QC", false);
            dt_AC.Rows.Add("xWeightDestination", "QC", false);
            dt_AC.Rows.Add("cm_xRegion_", "QC", false);
            dt_AC.Rows.Add("xRegion_", "QC", false);
            dt_AC.Rows.Add("xCity", "QC", false);
            dt_AC.Rows.Add("xRent", "QC", false);
            dt_AC.Rows.Add("xState", "QC", true);
            dt_AC.Rows.Add("xUsage", "QC", true);
            dt_AC.Rows.Add("xUsageMeltingAmount", "QC", true);
            dt_AC.Rows.Add("xAbsorptionPercent", "QC", true);
            dt_AC.Rows.Add("xConfirm", "QC", true);
            dt_AC.Rows.Add("xApprove", "QC", true);
            dt_AC.Rows.Add("cmb_State", "QC", true);
            dt_AC.Rows.Add("xTRConfirm", "QC", false);
            dt_AC.Rows.Add("xTRApprove", "QC", false);
            dt_AC.Rows.Add("xCarNumber", "QC", false);
            dt_AC.Rows.Add("xEntranceNumber", "QC", true);
            dt_AC.Rows.Add("xRequestingItem", "QC", true);
            dt_AC.Rows.Add("xTestResults", "QC", true );
            dt_AC.Rows.Add("xQCComment", "QC", true);

            dt_AC.Rows.Add("x_", "FN", false);
            dt_AC.Rows.Add("xDateTest", "FN", false);
            dt_AC.Rows.Add("xDriverName", "FN", true);
            dt_AC.Rows.Add("xDriverTel", "FN", false);
            dt_AC.Rows.Add("xWeightBeginning", "FN", true);
            dt_AC.Rows.Add("xWeightDestination", "FN", true);
            dt_AC.Rows.Add("xRegion_", "FN", false);
            dt_AC.Rows.Add("xCity", "FN", true);
            dt_AC.Rows.Add("xRent", "FN", true);
            dt_AC.Rows.Add("xUsage", "FN", false);
            dt_AC.Rows.Add("xUsageMeltingAmount", "FN", false);
            dt_AC.Rows.Add("xAbsorptionPercent", "FN", false);
            dt_AC.Rows.Add("xState", "FN", false);
            dt_AC.Rows.Add("xConfirm", "FN", false);
            dt_AC.Rows.Add("xApprove", "FN", false);
            dt_AC.Rows.Add("cmb_State", "FN", false);
            dt_AC.Rows.Add("xTRConfirm", "FN", false);
            dt_AC.Rows.Add("xCarNumber", "FN", true);
            dt_AC.Rows.Add("xTRApprove", "FN", false);
            dt_AC.Rows.Add("xEntranceNumber", "FN", false);
            dt_AC.Rows.Add("xRequestingItem", "FN", false);
            dt_AC.Rows.Add("xTestResults", "FN", false);
            dt_AC.Rows.Add("xQCComment", "FN", false);
            dt_AC.Rows.Add("xComment", "FN", false);

            dt_AC.Rows.Add("x_", "PR", false);
            dt_AC.Rows.Add("xDateTest", "PR", false);
            dt_AC.Rows.Add("xDriverName", "PR", true);
            dt_AC.Rows.Add("xDriverTel", "PR", true);
            dt_AC.Rows.Add("xWeightBeginning", "PR", true);
            dt_AC.Rows.Add("xWeightDestination", "PR", true);
            dt_AC.Rows.Add("xRegion_", "PR", false);
            dt_AC.Rows.Add("xCity", "PR", true);
            dt_AC.Rows.Add("xRent", "PR", true);
            dt_AC.Rows.Add("xUsage", "PR", false);
            dt_AC.Rows.Add("xUsageMeltingAmount", "PR", false);
            dt_AC.Rows.Add("xAbsorptionPercent", "PR", false);
            dt_AC.Rows.Add("xState", "PR", false);
            dt_AC.Rows.Add("xConfirm", "PR", false);
            dt_AC.Rows.Add("xApprove", "PR", false);
            dt_AC.Rows.Add("cmb_State", "PR", false);
            dt_AC.Rows.Add("xTRConfirm", "PR", false);
            dt_AC.Rows.Add("xCarNumber", "PR", true);
            dt_AC.Rows.Add("xTRApprove", "PR", false);
            dt_AC.Rows.Add("xEntranceNumber", "PR", false);
            dt_AC.Rows.Add("xRequestingItem", "PR", false);
            dt_AC.Rows.Add("xTestResults", "PR", false);
            dt_AC.Rows.Add("xQCComment", "PR", false);

            dt_AC.Rows.Add("x_", "TR", false);
            dt_AC.Rows.Add("xDateTest", "TR", true);
            dt_AC.Rows.Add("xDriverName", "TR", true);
            dt_AC.Rows.Add("xDriverTel", "TR", true);
            dt_AC.Rows.Add("xWeightBeginning", "TR", true);
            dt_AC.Rows.Add("xWeightDestination", "TR", true);
            dt_AC.Rows.Add("xRegion_", "TR", false);
            dt_AC.Rows.Add("xCity", "TR", true);
            dt_AC.Rows.Add("xRent", "TR", true);
            dt_AC.Rows.Add("xUsage", "TR", true);
            dt_AC.Rows.Add("xUsageMeltingAmount", "TR", true);
            dt_AC.Rows.Add("xAbsorptionPercent", "TR", true);
            dt_AC.Rows.Add("xState", "TR", true);
            dt_AC.Rows.Add("xConfirm", "TR", false);
            dt_AC.Rows.Add("xApprove", "TR", true);
            dt_AC.Rows.Add("cmb_State", "TR", true);
            dt_AC.Rows.Add("xTRConfirm", "TR", true);
            dt_AC.Rows.Add("xTRApprove", "TR", true);
            dt_AC.Rows.Add("xCarNumber", "TR", true);
            dt_AC.Rows.Add("xEntranceNumber", "TR", true);
            dt_AC.Rows.Add("xRequestingItem", "TR", true);
            dt_AC.Rows.Add("xTestResults", "TR", true);
            dt_AC.Rows.Add("xQCComment", "TR", true);

           DataRow[] dr = dt_AC.Select("Name = '" + Cl +  "' AND Type = '" +Ty +"'" );
           if (dr.Length > 0)
               return (bool)dr[0]["Allow"];
           else
               return true;

        }

        void Generate()
        {

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].Visible = Dtable(dc.ColumnName, Se);
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["xComment"].HeaderText = "مشخصات ظاهری و نوع بسته بندی";
            dataGridView1.Columns["xQCComment"].DisplayIndex = dataGridView1.Columns["xRequestingItem"].DisplayIndex = dataGridView1.Columns["xTestResults"].DisplayIndex = dataGridView1.Columns["xComment"].DisplayIndex;
            dataGridView1.Columns["xQCComment"].Width = 150;
            dataGridView1.Columns["xRequestingItem"].Width = 150;
            dataGridView1.Columns["xTestResults"].Width = 150;

            dataGridView1.Columns["xRequestingItem"].ReadOnly = true;

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xMaterial_"].Visible = false;
            dataGridView1.Columns["xSupplierCompany_"].Visible = true;
            dataGridView1.Columns["xSupplierCompany_"].HeaderText = "شماره سریال تامین کننده";
            dataGridView1.Columns["xSupplierCompany_"].DisplayIndex = dataGridView1.Columns["cmb_Supplier"].DisplayIndex;
            dataGridView1.Columns["xState"].Visible = false;
            dataGridView1.Columns["xComment"].Width = 300;
            dataGridView1.Columns["cmb_Supplier"].Width = 200;


            dataGridView1.Columns["xDateEnter"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["xDateTest"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["xConfirm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGridView1.Columns["xWeightBeginning"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xWeightDestination"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xRent"].DefaultCellStyle.Format = "N0";





            if (Se != "PR")
            {
                dataGridView1.Columns["cm_xRegion_"].ReadOnly = true;

                dataGridView1.Columns["xRegion_"].ReadOnly = true;
                ////////
                dataGridView1.Columns["xCity"].ReadOnly = true;
                dataGridView1.Columns["xDateEnter"].ReadOnly = true;
                dataGridView1.Columns["cmb_Supplier"].ReadOnly = true;
                uc_DataGridViewBtn1.Enabled = false;

                dataGridView1.Columns["cmb_Material"].ReadOnly = true;
                dataGridView1.Columns["xSupplier"].ReadOnly = true;
                dataGridView1.Columns["xApprove"].ReadOnly = true;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                toolStripButton_Add.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;

                
            }
            dataGridView1.Columns["xTRApprove"].ReadOnly = true;
            dataGridView1.Columns["xApprove"].ReadOnly = true;
            dataGridView1.Columns["xSupplier"].ReadOnly = true;

            if (Se == "TR")
            {

                foreach (DataColumn dc in dt_P.Columns)
                {
                    dataGridView1.Columns[dc.ColumnName].ReadOnly =true;
                }
                dataGridView1.Columns["xTRConfirm"].ReadOnly = false;
                dataGridView1.Columns["cmb_State"].ReadOnly = true;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((bool)item.Cells["xConfirm"].Value == false)
                    {
                        item.ReadOnly = true;
                        item.DefaultCellStyle.BackColor = Color.Pink;
                    }
                }
                dataGridView1.Columns["xRent"].ReadOnly = true;

                
            }
            if (Se == "PR")
            {
                dataGridView1.Columns["cmb_State"].Visible = false;
            }
            if (Se == "QC")
            {
                dt_P.xDateTestColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            }


            if (Se == "FN")
            {
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    item.ReadOnly = true;
                }

                dataGridView1.Columns["xRent"].ReadOnly = false;
                dataGridView1.Columns["cmb_State"].Visible = false;
                dataGridView1.Columns["xSupplierCompany_"].Visible = false;
                
            }

            if (Se != "TR")
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                if (item.ReadOnly == true)
                {
                    item.DefaultCellStyle.BackColor = Color.LightGray;
                    
                }
            }
            else
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    if (item.ReadOnly == false)
                    {
                        item.DefaultCellStyle.BackColor = Color.LightGreen;

                    }
                }
            dt_P.xConfirmColumn.DefaultValue = false;
            dt_P.xTRconfirmColumn.DefaultValue = false;
        }

        DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestDataTable dt_P;
        DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestAnalysisDataTable dt_P_B;
        DAL.Procurement.DataSet_ProcurmentMaterialTest.SlProcurmentMaterialTestAnalysisDataTable dt_P_A;

        private void btn_Show_Click(object sender, EventArgs e)
        {
//          چون برای qc باید هر دو مقدار برای تایید نشان داده شود مقدار NULL را به سمت سرور می فرستم

            BLL.Procurement.csProcurmentMaterialTest cs = new BLL.Procurement.csProcurmentMaterialTest();
            dt_P = cs.SlProcurmentMaterialTest(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, Se);
            dt_P.xDateEnterColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplierColumn.DefaultValue = BLL.authentication.NameAndFamily;

            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            this.dataGridView1.EndEdit();
            this.Validate();
           
            if (Se == "PR")
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((item.Cells["xWeightBeginning"].Value.ToString() == "" || item.Cells["xWeightDestination"].Value.ToString() == "") &&
                        item.Cells["xDriverName"].Value.ToString() == "" && item.Cells["xCarNumber"].Value.ToString() == "")
                    {
                        MessageBox.Show("اطلاعات ورودی  جهت ذخیره سازی کامل نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            BLL.Procurement.csProcurmentMaterialTest cs = new BLL.Procurement.csProcurmentMaterialTest();
            MessageBox.Show(cs.UdProcurmentMaterialTest(dt_P));
            dt_P = cs.SlProcurmentMaterialTest(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, Se);
            dt_P.xDateEnterColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_P.xSupplierColumn.DefaultValue = BLL.authentication.NameAndFamily;

            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xConfirm"].Index)
                if ((bool)dataGridView1["xConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xApprove", e.RowIndex].Value = BLL.authentication.NameAndFamily;
                }
                else
                    dataGridView1["xApprove", e.RowIndex].Value = "";
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xTRConfirm"].Index)
                if ((bool)dataGridView1["xTRConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xTRApprove", e.RowIndex].Value = BLL.authentication.NameAndFamily;
                }
                else
                    dataGridView1["xTRApprove", e.RowIndex].Value = "";



        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (Se == "QC")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    BLL.Procurement.csProcurmentMaterialTest css = new BLL.Procurement.csProcurmentMaterialTest();
                    DataTable dt = css.SlProcurmentMaterialTestReport((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                    Report.SendReport cs = new Report.SendReport();
                    frmReport r = new frmReport();
                    r.GetReport = cs.GetReport(dt, "crsProcurmentMaterialTest");
                    r.ShowDialog();
                    r.Dispose();
                }
            }
            else if (Se == "TR")
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    BLL.Procurement.csProcurmentMaterialTest css = new BLL.Procurement.csProcurmentMaterialTest();
                    DataTable dt = css.SlProcurmentMaterialTestReportTR((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                    Report.SendReport cs = new Report.SendReport();
                    frmReport r = new frmReport();
                    r.GetReport = cs.GetReport(dt, "crsProcurmentMaterialTestTR");
                    r.ShowDialog();
                    r.Dispose();
                }
            }
        }

        void Generate_D_A( )
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P_A.Columns)
            {
                dataGridView3.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView3.Columns["x_"].Visible = false;
            dataGridView3.Columns["xProcurmentMaterialTest_"].Visible = false;
            dataGridView3.Columns["xIsbefore"].Visible = false;
        }
        void Generate_D_B()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P_B.Columns)
            {
                dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xProcurmentMaterialTest_"].Visible = false;
            dataGridView2.Columns["xIsbefore"].Visible = false;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            splitContainer5.Panel2Collapsed = true;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataGridView2.EndEdit();
            if (dataGridView2["xProcurmentMaterialTest_", 0].Value == null)
                return;
            int? t = (int?)dataGridView2["xProcurmentMaterialTest_", 0].Value;
            BLL.Procurement.csProcurmentMaterialTest cs = new BLL.Procurement.csProcurmentMaterialTest();
            MessageBox.Show(cs.UdProcurmentMaterialTestAnalysis(dt_P_B));
            dt_P_B = cs.SlProcurmentMaterialTestAnalysis(t,true);
            bindingSource2.DataSource = dt_P_B;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            Generate_D_B();



        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Se == "QC")
            {
                dataGridView2.Enabled = true;
                dataGridView3.Enabled = true;
            }
            else
            {
                dataGridView2.Enabled = false;
                dataGridView3.Enabled = false;
            }

            if (Se == "PR")
            {
                splitContainer5.Panel2Collapsed = true;
            }
            else
            {
                splitContainer5.Panel2Collapsed = false;

                BLL.Procurement.csProcurmentMaterialTest cs = new BLL.Procurement.csProcurmentMaterialTest();

                dt_P_B = cs.SlProcurmentMaterialTestAnalysis((int?)dataGridView1["x_", e.RowIndex].Value, true);
                bindingSource2.DataSource = dt_P_B;
                dataGridView2.DataSource = bindingSource2;
                bindingNavigator2.BindingSource = bindingSource2;
                dt_P_B.xProcurmentMaterialTest_Column.DefaultValue = (int?)dataGridView1["x_", e.RowIndex].Value;
                dt_P_B.xIsBeforeColumn.DefaultValue = true;
                Generate_D_B();


                dt_P_A = cs.SlProcurmentMaterialTestAnalysis((int?)dataGridView1["x_", e.RowIndex].Value,false);
                bindingSource3.DataSource = dt_P_A;
                dataGridView3.DataSource = bindingSource3;
                bindingNavigator3.BindingSource = bindingSource3;
                dt_P_A.xProcurmentMaterialTest_Column.DefaultValue = (int?)dataGridView1["x_", e.RowIndex].Value;
                dt_P_A.xIsBeforeColumn.DefaultValue = false;

                Generate_D_A();


            }


        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDateTest")
            {
                bool flag = true;
                BLL.csshamsidate cs = new BLL.csshamsidate();
                Validation.VDate v = new Validation.VDate();
                flag = v.ValidationDate(e.FormattedValue.ToString());
                if(flag)  flag = cs.CompareDate(e.FormattedValue.ToString(), dataGridView1["xDateEnter", e.RowIndex].Value.ToString());
                e.Cancel = !flag;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));
        }

        private void toolStripButton_SaveA_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataGridView3.EndEdit();
            if (dataGridView3["xProcurmentMaterialTest_", 0].Value == null)
                return;
            int? t = (int?)dataGridView3["xProcurmentMaterialTest_", 0].Value;
            BLL.Procurement.csProcurmentMaterialTest cs = new BLL.Procurement.csProcurmentMaterialTest();
            MessageBox.Show(cs.UdProcurmentMaterialTestAnalysis(dt_P_A));
            dt_P_A = cs.SlProcurmentMaterialTestAnalysis(t, false);
            bindingSource3.DataSource = dt_P_A;
            dataGridView3.DataSource = bindingSource3;
            bindingNavigator3.BindingSource = bindingSource3;
            Generate_D_A();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xSupplierCompany_")
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


        }
        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            uc_DataGridViewBtn1.Visible = false;
        }

        private void frmProcurmentScarbTest_Move(object sender, EventArgs e)
        {
            uc_DataGridViewBtn1.Visible = false;
        }

        private void dataGridView1_ColumnDividerWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            uc_DataGridViewBtn1.Visible = false;
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            uc_DataGridViewBtn1.Visible = false;
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDateEnter")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    fr.Location = new Point(cellRectangle.X, cellRectangle.Y);
                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xConfirm")
                if (dataGridView1["cmb_State", e.RowIndex].Value == DBNull.Value)
                {

                    e.Cancel = true;
                }
        }


    }
}
