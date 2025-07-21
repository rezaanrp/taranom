using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Procurment
{
    public partial class frmProcurmentMaterialSample : Form
    {
        public frmProcurmentMaterialSample(string Section)
        {
            InitializeComponent();
            sec_ = Section;

            BLL.GenGroup.csGenGroup csmg = new BLL.GenGroup.csGenGroup();

            dt_S = new DAL.Procurement.DataSet_ProcurmentMaterialSample.SlProcurmentMaterialSampleDataTable();
            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            DataGridViewComboBoxColumn combobox_CDPRC_ = new DataGridViewComboBoxColumn();
            combobox_CDPRC_.DataSource = csmg.SlGenGroup("PRSTAT");
            combobox_CDPRC_.DisplayMember = "xName";
            combobox_CDPRC_.HeaderText = "وضعیت";
            combobox_CDPRC_.ValueMember = "x_";
            combobox_CDPRC_.DataPropertyName = "xState_";
            combobox_CDPRC_.Name = "cmb_xState_";
            combobox_CDPRC_.Width = 100;
            combobox_CDPRC_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_CDPRC_);


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


            uc_DataGridViewBtn1.ColumnsFilter_ = "xComponyName";
            uc_DataGridViewBtn1.Ds = cm.SelectSupplier();

            uc_DataGridViewBtn1.ParamName = new string[] { "xComponyName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام شرکت" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
               "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;

            generate();
            ColorDataGridViewColumns();
            toolStripButton_Add.Click += new EventHandler(toolStripButton_Add_Click);

            dataGridView1.Columns["xDateTransfer"].DisplayIndex = dataGridView1.Columns["xTimeTransfer"].DisplayIndex;

        }

        void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            if (sec_ == "ST")
            {
                
                dt_S.xBaseColumn.DefaultValue = false;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((int)item.Cells["x_"].Value < 0)
                    {
                        item.ReadOnly = false;
                        item.Cells["xDateEnter"].ReadOnly = false;
                        item.Cells["cmb_Material"].ReadOnly = false;
                        item.Cells["xSupplierCompany_"].ReadOnly = false;
                        item.Cells["xDriverName"].ReadOnly = false;
                        item.Cells["xDriverTel"].ReadOnly = false;
                        item.Cells["xCarNumber"].ReadOnly = false;
                        item.Cells["xWeightBeginning"].ReadOnly = false;
                        item.Cells["xWeightDestination"].ReadOnly = false;
                        item.Cells["xSCConfirm"].ReadOnly = false;
                        
                    }
   
                }
            }

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

        public string sec_;

        DAL.Procurement.DataSet_ProcurmentMaterialSample.SlProcurmentMaterialSampleDataTable dt_S;

        void ColorDataGridViewColumns()
        {
            dataGridView1.EnableHeadersVisualStyles = false;

            //DataGridViewColumn dataGridViewColumn = dataGridView1.Columns["xDriverName"];
            //dataGridViewColumn.HeaderCell.Style.BackColor = Color.Magenta;
            Color SC_Color = Color.PowderBlue;
            Color QC_Color = Color.FromArgb(192, 255, 192);
            Color ST_Color = Color.Cyan;
            Color TR_Color = Color.Salmon;
            dataGridView1.Columns["cmb_Material"].HeaderCell.Style.BackColor =SC_Color; 
            dataGridView1.Columns["cmb_Supplier"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["cmb_xState_"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xDateEnter"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xDateTest"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xMaterial_"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xSupplierCompany_"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xDriverName"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xDriverTel"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xCarNumber"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xWeightBeginning"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xWeightDestination"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xSCUser_"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xSCConfirm"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xWeightSend"].HeaderCell.Style.BackColor = ST_Color;
            dataGridView1.Columns["xReceiverName"].HeaderCell.Style.BackColor = ST_Color;
            dataGridView1.Columns["xQuarantineWarehouseReceipt"].HeaderCell.Style.BackColor = ST_Color;
            dataGridView1.Columns["xTransfersFromQuarantine"].HeaderCell.Style.BackColor = ST_Color;
            dataGridView1.Columns["xDateTransfer"].HeaderCell.Style.BackColor = ST_Color;
            dataGridView1.Columns["xTimeTransfer"].HeaderCell.Style.BackColor = ST_Color;
            dataGridView1.Columns["xStockUser_"].HeaderCell.Style.BackColor =SC_Color;
            //dataGridView1.Columns["xStockConfirm"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xStockComment"].HeaderCell.Style.BackColor = ST_Color;
            dataGridView1.Columns["xUsage"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xUsageMeltingAmount"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xAbsorptionPercent"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xTestResults"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xQCComment"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xState_"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xQCConfirm"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xQCUser_"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xTRconfirm"].HeaderCell.Style.BackColor = TR_Color;
            dataGridView1.Columns["xTRUser_"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xQCUser"].HeaderCell.Style.BackColor =QC_Color;
            dataGridView1.Columns["xTRUser"].HeaderCell.Style.BackColor = TR_Color;
            dataGridView1.Columns["xSCUser"].HeaderCell.Style.BackColor =SC_Color;
            dataGridView1.Columns["xStockUser"].HeaderCell.Style.BackColor = ST_Color;
        }

        bool Dtable(string Cl, string Ty)
        {
            DataTable dt_AC = new DataTable();
            dt_AC.Columns.Add("Name", typeof(String));
            dt_AC.Columns.Add("Type", typeof(String));
            dt_AC.Columns.Add("Allow", typeof(bool));

            dt_AC.Rows.Add("x_", "SC", false);
            dt_AC.Rows.Add("xDateEnter","SC",true);
            dt_AC.Rows.Add("xDateTest","SC",false);
            dt_AC.Rows.Add("xMaterial_", "SC", false);
            dt_AC.Rows.Add("xSupplierCompany_", "SC", true);
            dt_AC.Rows.Add("xDriverName", "SC", true);
            dt_AC.Rows.Add("xDriverTel", "SC", true);
            dt_AC.Rows.Add("xCarNumber", "SC", true);
            dt_AC.Rows.Add("xWeightBeginning", "SC", true);
            dt_AC.Rows.Add("xWeightDestination", "SC", true);
            dt_AC.Rows.Add("xSCUser_","SC",false);
            dt_AC.Rows.Add("xSCConfirm", "SC", true);
            dt_AC.Rows.Add("xWeightSend","SC",false);
            dt_AC.Rows.Add("xReceiverName","SC",false);
            dt_AC.Rows.Add("xQuarantineWarehouseReceipt","SC",false);
            dt_AC.Rows.Add("xTransfersFromQuarantine","SC",false);
            dt_AC.Rows.Add("xDateTransfer","SC",false);
            dt_AC.Rows.Add("xTimeTransfer","SC",false);
            dt_AC.Rows.Add("xStockUser_","SC",false);
            dt_AC.Rows.Add("xStockConfirm","SC",false);
            dt_AC.Rows.Add("xStockComment","SC",false);
            dt_AC.Rows.Add("xUsage","SC",false);
            dt_AC.Rows.Add("xUsageMeltingAmount","SC",false);
            dt_AC.Rows.Add("xAbsorptionPercent","SC",false);
            dt_AC.Rows.Add("xTestResults","SC",false);
            dt_AC.Rows.Add("xQCComment","SC",false);
            dt_AC.Rows.Add("xState_","SC",false);
            dt_AC.Rows.Add("xQCConfirm","SC",false);
            dt_AC.Rows.Add("xQCUser_","SC",false);
            dt_AC.Rows.Add("xTRconfirm","SC",false);
            dt_AC.Rows.Add("xTRUser_","SC",false);

            dt_AC.Rows.Add("xQCUser", "SC", false);
            dt_AC.Rows.Add("xTRUser", "SC", false);
            dt_AC.Rows.Add("xSCUser", "SC", true);
            dt_AC.Rows.Add("xStockUser", "SC", false);
            dt_AC.Rows.Add("xBase", "SC", false);

            dt_AC.Rows.Add("x_", "ST", false);
            dt_AC.Rows.Add("xDateEnter", "ST", true);
            dt_AC.Rows.Add("xDateTest", "ST", false);
            dt_AC.Rows.Add("xMaterial_", "ST", false);
            dt_AC.Rows.Add("xSupplierCompany_", "ST", true);
            dt_AC.Rows.Add("xDriverName", "ST", true);
            dt_AC.Rows.Add("xDriverTel", "ST", false);
            dt_AC.Rows.Add("xCarNumber", "ST", false);
            dt_AC.Rows.Add("xWeightBeginning", "ST", true);
            dt_AC.Rows.Add("xWeightDestination", "ST", true);
            dt_AC.Rows.Add("xSCUser_", "ST", false);
            dt_AC.Rows.Add("xSCConfirm", "ST", false);
            dt_AC.Rows.Add("xWeightSend", "ST", true);
            dt_AC.Rows.Add("xReceiverName", "ST", true);
            dt_AC.Rows.Add("xQuarantineWarehouseReceipt", "ST", true);
            dt_AC.Rows.Add("xTransfersFromQuarantine", "ST", true);
            dt_AC.Rows.Add("xDateTransfer", "ST", true);
            dt_AC.Rows.Add("xTimeTransfer", "ST", true);
            dt_AC.Rows.Add("xStockUser_", "ST", false);
            dt_AC.Rows.Add("xStockConfirm", "ST", true);
            dt_AC.Rows.Add("xStockComment", "ST", true);
            dt_AC.Rows.Add("xUsage", "ST", false);
            dt_AC.Rows.Add("xUsageMeltingAmount", "ST", false);
            dt_AC.Rows.Add("xAbsorptionPercent", "ST", false);
            dt_AC.Rows.Add("xTestResults", "ST", false);
            dt_AC.Rows.Add("xQCComment", "ST", false);
            dt_AC.Rows.Add("xState_", "ST", false);
            dt_AC.Rows.Add("xQCConfirm", "ST", false);
            dt_AC.Rows.Add("xQCUser_", "ST", false);
            dt_AC.Rows.Add("xTRconfirm", "ST", false);
            dt_AC.Rows.Add("xTRUser_", "ST", false);

            dt_AC.Rows.Add("xQCUser", "ST", false);
            dt_AC.Rows.Add("xTRUser", "ST", false);
            dt_AC.Rows.Add("xSCUser", "ST", true);
            dt_AC.Rows.Add("xStockUser", "ST", true);
            dt_AC.Rows.Add("xBase", "ST", true);

            dt_AC.Rows.Add("x_", "QC", false);
            dt_AC.Rows.Add("xDateEnter", "QC", true);
            dt_AC.Rows.Add("xDateTest", "QC", true);
            dt_AC.Rows.Add("xMaterial_", "QC", false);
            dt_AC.Rows.Add("xSupplierCompany_", "QC", true);
            dt_AC.Rows.Add("xDriverName", "QC", false);
            dt_AC.Rows.Add("xDriverTel", "QC", false);
            dt_AC.Rows.Add("xCarNumber", "QC", false);
            dt_AC.Rows.Add("xWeightBeginning", "QC", true);
            dt_AC.Rows.Add("xWeightDestination", "QC", true);
            dt_AC.Rows.Add("xSCUser_", "QC", false);
            dt_AC.Rows.Add("xSCConfirm", "QC", false);
            dt_AC.Rows.Add("xWeightSend", "QC", true);
            dt_AC.Rows.Add("xReceiverName", "QC", true);
            dt_AC.Rows.Add("xQuarantineWarehouseReceipt", "QC", false);
            dt_AC.Rows.Add("xTransfersFromQuarantine", "QC", false);
            dt_AC.Rows.Add("xDateTransfer", "QC", false);
            dt_AC.Rows.Add("xTimeTransfer", "QC", false);
            dt_AC.Rows.Add("xStockUser_", "QC", false);
            dt_AC.Rows.Add("xStockConfirm", "QC", false);
            dt_AC.Rows.Add("xStockComment", "QC", true);
            dt_AC.Rows.Add("xUsage", "QC", true);
            dt_AC.Rows.Add("xUsageMeltingAmount", "QC", true);
            dt_AC.Rows.Add("xAbsorptionPercent", "QC", true);
            dt_AC.Rows.Add("xTestResults", "QC", true);
            dt_AC.Rows.Add("xQCComment", "QC", true);
            dt_AC.Rows.Add("xState_", "QC", false);
            dt_AC.Rows.Add("xQCConfirm", "QC", true);
            dt_AC.Rows.Add("xQCUser_", "QC", false);
            dt_AC.Rows.Add("xTRconfirm", "QC", false);
            dt_AC.Rows.Add("xTRUser_", "QC", false);

            dt_AC.Rows.Add("xQCUser", "QC", true);
            dt_AC.Rows.Add("xTRUser", "QC", false);
            dt_AC.Rows.Add("xSCUser", "QC", true);
            dt_AC.Rows.Add("xStockUser", "QC", true);
            dt_AC.Rows.Add("xBase", "QC", false);

            dt_AC.Rows.Add("x_", "TR", false);
            dt_AC.Rows.Add("xDateEnter", "TR", true);
            dt_AC.Rows.Add("xDateTest", "TR", true);
            dt_AC.Rows.Add("xMaterial_", "TR", false);
            dt_AC.Rows.Add("xSupplierCompany_", "TR", true);
            dt_AC.Rows.Add("xDriverName", "TR", true);
            dt_AC.Rows.Add("xDriverTel", "TR", true);
            dt_AC.Rows.Add("xCarNumber", "TR", true);
            dt_AC.Rows.Add("xWeightBeginning", "TR", true);
            dt_AC.Rows.Add("xWeightDestination", "TR", true);
            dt_AC.Rows.Add("xSCUser_", "TR", false);
            dt_AC.Rows.Add("xSCConfirm", "TR", true);
            dt_AC.Rows.Add("xWeightSend", "TR", true);
            dt_AC.Rows.Add("xReceiverName", "TR", true);
            dt_AC.Rows.Add("xQuarantineWarehouseReceipt", "TR", true);
            dt_AC.Rows.Add("xTransfersFromQuarantine", "TR", true);
            dt_AC.Rows.Add("xDateTransfer", "TR", true);
            dt_AC.Rows.Add("xTimeTransfer", "TR", true);
            dt_AC.Rows.Add("xStockUser_", "TR", false);
            dt_AC.Rows.Add("xStockConfirm", "TR", true);
            dt_AC.Rows.Add("xStockComment", "TR", true);
            dt_AC.Rows.Add("xUsage", "TR", true);
            dt_AC.Rows.Add("xUsageMeltingAmount", "TR", true);
            dt_AC.Rows.Add("xAbsorptionPercent", "TR", true);
            dt_AC.Rows.Add("xTestResults", "TR", true);
            dt_AC.Rows.Add("xQCComment", "TR", true);
            dt_AC.Rows.Add("xState_", "TR", false);
            dt_AC.Rows.Add("xQCConfirm", "TR", true);
            dt_AC.Rows.Add("xQCUser_", "TR", false);
            dt_AC.Rows.Add("xTRconfirm", "TR", true);
            dt_AC.Rows.Add("xTRUser_", "TR", false);
            dt_AC.Rows.Add("xBase", "TR", false);


            dt_AC.Rows.Add("xQCUser","TR",true);
            dt_AC.Rows.Add("xTRUser","TR",true);
            dt_AC.Rows.Add("xSCUser","TR",true);
            dt_AC.Rows.Add("xStockUser", "TR", true);

            DataRow[] dr = dt_AC.Select("Name = '" + Cl + "' AND Type = '" + Ty + "'");
            if (dr.Length > 0)
                return (bool)dr[0]["Allow"];
            else
                return true;

        }

        void generate()
        {

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_S.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].Visible = Dtable(dc.ColumnName, sec_);
                if( css.EnToFarsiCatalog(dc.ColumnName) != "")
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.ReadOnly = true;
            }
            CS.csDataGridView csdgv = new CS.csDataGridView();
            csdgv.ColumnsCommaAllDecimal(ref dataGridView1);
            dataGridView1.Columns["xWeightBeginning"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xWeightDestination"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xWeightSend"].DefaultCellStyle.Format = "N0";

            dataGridView1.Columns["cmb_xState_"].Visible = false;

            dataGridView1.Columns["xQCUser"].HeaderText = "تایید - کنترل کیفیت";

            dataGridView1.Columns["xSCConfirm"].HeaderText = "تایید - انتظامات";

            dataGridView1.Columns["xTRUser"].HeaderText = "کاربر - بازرگانی";
            dataGridView1.Columns["xSCUser"].HeaderText = "تایید - انتظامات";
            dataGridView1.Columns["xStockUser"].HeaderText = "تایید - انبار";
            dataGridView1.Columns["xBase"].HeaderText = "مبنا";


            dataGridView1.Columns["cmb_Supplier"].DisplayIndex = dataGridView1.Columns["xSupplierCompany_"].DisplayIndex;

            if (sec_ == "SC")
            {
                bindingNavigator1.AddNewItem.Enabled = true;
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;

            dataGridView1.Columns["xDateEnter"].ReadOnly = false;
            dataGridView1.Columns["cmb_Material"].ReadOnly = false;
            dataGridView1.Columns["xSupplierCompany_"].ReadOnly = false;
            dataGridView1.Columns["xDriverName"].ReadOnly = false;
            dataGridView1.Columns["xDriverTel"].ReadOnly = false;
            dataGridView1.Columns["xCarNumber"].ReadOnly = false;
            dataGridView1.Columns["xWeightBeginning"].ReadOnly = false;
            dataGridView1.Columns["xWeightDestination"].ReadOnly = false;
            dataGridView1.Columns["xSCConfirm"].ReadOnly = false;
            dataGridView1.Columns["cmb_xState_"].ReadOnly = true;
            uc_DataGridViewBtn1.Enabled = true;
            dt_S.xBaseColumn.DefaultValue = true;

            }
            else if (sec_ == "QC")
            {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.Columns["xDateTest"].ReadOnly = false;
            dataGridView1.Columns["xUsage"].ReadOnly = false;
            dataGridView1.Columns["xUsageMeltingAmount"].ReadOnly = false;
            dataGridView1.Columns["xAbsorptionPercent"].ReadOnly = false;
            dataGridView1.Columns["xTestResults"].ReadOnly = false;
            dataGridView1.Columns["xQCComment"].ReadOnly = false;
            dataGridView1.Columns["xState_"].ReadOnly = false;
            dataGridView1.Columns["xQCConfirm"].ReadOnly = false;
            dataGridView1.Columns["cmb_xState_"].Visible = true;
            dataGridView1.Columns["cmb_xState_"].ReadOnly = false;


            }
            else if (sec_ == "TR")
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.Columns["xTRconfirm"].ReadOnly = false;
            dataGridView1.Columns["cmb_xState_"].Visible = true;
            dataGridView1.Columns["cmb_xState_"].ReadOnly = true;


           
            }
            else if (sec_ == "ST")
            {

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                bindingNavigator1.AddNewItem.Enabled = true;
                dt_S.xBaseColumn.DefaultValue = false;
                uc_DataGridViewBtn1.Enabled = true;

                dataGridView1.Columns["xDateEnter"].ReadOnly = true;
                dataGridView1.Columns["xSupplierCompany_"].ReadOnly = true;
                dataGridView1.Columns["xWeightBeginning"].ReadOnly = true;
                dataGridView1.Columns["cmb_xState_"].ReadOnly = true;
                dataGridView1.Columns["xWeightDestination"].ReadOnly = true;
                dataGridView1.Columns["xSCUser_"].ReadOnly = false;
                dataGridView1.Columns["xWeightSend"].ReadOnly = false;
                dataGridView1.Columns["xReceiverName"].ReadOnly = false;
                dataGridView1.Columns["xQuarantineWarehouseReceipt"].ReadOnly = false;
                dataGridView1.Columns["xTransfersFromQuarantine"].ReadOnly = false;
                dataGridView1.Columns["xDateTransfer"].ReadOnly = false;
                dataGridView1.Columns["xTimeTransfer"].ReadOnly = false;
                dataGridView1.Columns["xStockComment"].ReadOnly = false;
             
            }



        }

        void ShowDataGridView()
        {
            BLL.Procurement.csProcurmentMaterialSample cs = new BLL.Procurement.csProcurmentMaterialSample();
            dt_S = cs.SLProcurmentMaterialSample(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, sec_);
            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            
            generate();
            dataGridView1.Columns["xDateTransfer"].DisplayIndex = dataGridView1.Columns["xTimeTransfer"].DisplayIndex;
        }

        void SaveDataGridView()
        {
            this.Validate();
            dataGridView1.EndEdit();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if(!item.IsNewRow)
                    if (item.Cells[ "xDateEnter"].Value == null || item.Cells[ "xDateEnter"].Value == DBNull.Value || !new Validation.VDate().ValidationDate(item.Cells["xDateEnter"].Value.ToString()))
                    {
                        MessageBox.Show("تاریخ به درستی ثبت نشده");
                        return;
                    }

            }

            if (new  CS.csMessage().ShowMessageSaveYesNo())
            {

                BLL.Procurement.csProcurmentMaterialSample cs = new BLL.Procurement.csProcurmentMaterialSample();
                MessageBox.Show(   cs.UdProcurmentMaterialSample(dt_S) );
                ShowDataGridView();

               
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((dataGridView1.Columns[e.ColumnIndex].Name == "xSupplierCompany_" && sec_ == "SC" ) || 
                dataGridView1.Columns[e.ColumnIndex].Name == "xSupplierCompany_" && sec_ == "ST" &&  (int)dataGridView1["x_",e.RowIndex].Value < 0)
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

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDateEnter" || dataGridView1.Columns[e.ColumnIndex].Name == "xDateTest")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                  //  var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                  //  fr.Location = new Point(cellRectangle.X, cellRectangle.Y);
                    fr.StartPosition = FormStartPosition.CenterParent;
                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xSCConfirm"].Index)
                if ((bool)dataGridView1["xSCConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xSCUser_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xSCUser_", e.RowIndex].Value = DBNull.Value;
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xTransfersFromQuarantine"].Index)
                if ((bool)dataGridView1["xTransfersFromQuarantine", e.RowIndex].Value == true)
                {
                    dataGridView1["xStockUser_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xStockUser_", e.RowIndex].Value = DBNull.Value;
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xQCConfirm"].Index)
                if ((bool)dataGridView1["xQCConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xQCUser_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xQCUser_", e.RowIndex].Value = DBNull.Value;
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xTRconfirm"].Index)
                if ((bool)dataGridView1["xTRconfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xTRUser_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xTRUser_", e.RowIndex].Value = DBNull.Value;

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if ((int)dataGridView1.SelectedRows.Count > 0)
            {
                Report.SendReport cs = new Report.SendReport();
                //cs.SetParam("xApprove", txtBoxapproveby.Text);
                BLL.Procurement.csProcurmentMaterialSample css =
                    new BLL.Procurement.csProcurmentMaterialSample();
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(css.SlProcurmentMaterialSampleReceipt((int)dataGridView1.SelectedRows[0].Cells["x_"].Value)
                    , "crsProcurmentMaterialSampleReceipt");
                r.ShowDialog();
                r.Dispose();
            }
        }

        private void frmProcurmentMaterialSample_Load(object sender, EventArgs e)
        {

        }
    }
}
