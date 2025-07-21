using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.SalePlan
{
    public partial class frmSalePlan : Form
    {
        public frmSalePlan(string Section)
        {
            Se = Section;
            InitializeComponent();
            //if (Se == "TR")
            //    uc_Month1.Mo = int.Parse(BLL.csshamsidate.shamsidate.Substring(5, 2)) > 11 ? 1 : int.Parse(BLL.csshamsidate.shamsidate.Substring(5, 2)) + 1;
            //else
                uc_Month1.Mo = int.Parse(BLL.csshamsidate.shamsidate.Substring(5, 2));

            
            uc_Month1.Ye = int.Parse(BLL.csshamsidate.shamsidate.Substring(0, 4));
            uc_Month1.GenBtn();
            uc_Month1.PupapActive = true;
            uc_Month1.ClickActive = true;

            dt_S = new DAL.SalePlan.DataSet_SalePlan.SlSalePlanDataTable();
            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;


            formFunctionPointer += new functioncall(Replicate);
            uc_Month1.userFunctionPointer = formFunctionPointer;

            BLL.csCompony cm = new BLL.csCompony();
            BLL.csPieces cp = new BLL.csPieces();

            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 2;
            combobox_xSupplier_.HeaderText = "نام مشتری";
            combobox_xSupplier_.DataSource = cm.SelectCustomer();
            combobox_xSupplier_.DisplayMember = "xComponyName";
            combobox_xSupplier_.ValueMember = "x_";
            combobox_xSupplier_.DataPropertyName = "xCustomer_";
            combobox_xSupplier_.Name = "xCustomer";
            combobox_xSupplier_.Width = 150;
            combobox_xSupplier_.MaxDropDownItems = 30 ;
            combobox_xSupplier_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xSupplier_);

            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn();
            combobox_xPieces_.DisplayIndex = 3;
            combobox_xPieces_.HeaderText = "نام قطعه";
            combobox_xPieces_.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_xPieces_.DisplayMember = "xName";
            combobox_xPieces_.ValueMember = "x_";
            combobox_xPieces_.DataPropertyName = "xPieces_";
            combobox_xPieces_.Name = "xPieces";
            combobox_xPieces_.Width = 150;
            combobox_xPieces_.MaxDropDownItems = 30;
            combobox_xPieces_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_xPieces_);

            uc_DataGridViewBtn1.ColumnsFilter_ = "xComponyName";
            uc_DataGridViewBtn1.Ds = cm.SelectCustomer();

            uc_DataGridViewBtn1.ParamName = new string[] { "xComponyName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام شرکت" };
            uc_DataGridViewBtn1.ParamHide = new string[] {"x_" , "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
               "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};



            uc_Month1.ChangeMonthActive = true;
            uc_DataGridViewBtn1Pointer += new functioncallDataGridViewBtn(Replicatecmb);
            uc_DataGridViewBtn1.userFunctionPointer = uc_DataGridViewBtn1Pointer;

            functioncalluc_Month1PopPupPointer += new functioncalluc_Month1PopPup(ReplicateBtn);
            uc_Month1.PoPupMsg = functioncalluc_Month1PopPupPointer;


            functioncalluc_Month1Pointer += new functioncalluc_Month1C(RepChangeMonth);
            uc_Month1.ChangeMonth = functioncalluc_Month1Pointer;

            //--------------------------------------------------------
            Generate();
            SalePlanTime();

        }


        public delegate void functioncalluc_Month1C();

        private event functioncalluc_Month1C functioncalluc_Month1Pointer;


        private void RepChangeMonth()
        {
            SalePlanTime();


        }



        private void SalePlanTime()
        {
            string Dateform = uc_Month1.Ye.ToString() + "/" 
                + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo.ToString() : uc_Month1.Mo.ToString()  )  + "/"  +  "01";
            string DateTo = uc_Month1.Ye.ToString() + "/"
                + (uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo.ToString() : uc_Month1.Mo.ToString()) + "/" + "31";
            DataTable dt = new BLL.SalePlan.csSalePlan().SlSalePlanNessaryTimeTableAdapter(Dateform, DateTo);
            uc_txtBoxSalePlanDay.Text = dt.Rows[0]["DayAccess"].ToString();
            uc_txtBoxSalePlanNessery.Text = dt.Rows[0]["SaleNesseryTime"].ToString();
            uc_txtBoxSalePlanAccessDay.Text = dt.Rows[0]["SaleAccessTime"].ToString();
            int si1, si2;
            si1 = dt.Rows[0]["SaleAccessTime"] == DBNull.Value || dt.Rows[0]["SaleAccessTime"] == null ? 0 : (int)dt.Rows[0]["SaleAccessTime"];
            si2 = dt.Rows[0]["SaleNesseryTime"] == DBNull.Value || dt.Rows[0]["SaleNesseryTime"] == null ? 0 : (int)dt.Rows[0]["SaleNesseryTime"];
            int si = si1 - si2;

            if (si < 0)
            {
                uc_txtBox_Sum.BackColor = Color.Red;
                uc_txtBox_Sum.Text = si.ToString();
            }
            else
            {
                uc_txtBox_Sum.BackColor = Color.Green;
                uc_txtBox_Sum.Text = si.ToString();

            }
            //uc_txtBox_Sum.Text = ().ToString();

            if (int.Parse(BLL.csshamsidate.shamsidate.Substring(0, 4)) <= int.Parse(DateTo.Substring(0, 4))
                 && int.Parse(BLL.csshamsidate.shamsidate.Substring(5, 2)) <= int.Parse(DateTo.Substring(5, 2)))
            {
                dt = new BLL.SalePlan.csSalePlan().SlSalePlanNessaryTimeTableAdapter(BLL.csshamsidate.shamsidate, DateTo);
                uc_txtBoxSalePlanDay_R.Text = dt.Rows[0]["DayAccess"].ToString();
                uc_txtBoxSalePlanNessery_R.Text = dt.Rows[0]["SaleNesseryTime"].ToString();
                uc_txtBoxSalePlanAccessDay_R.Text = dt.Rows[0]["SaleAccessTime"].ToString();

                si1 = dt.Rows[0]["SaleAccessTime"] == DBNull.Value || dt.Rows[0]["SaleAccessTime"] == null ? 0 : (int)dt.Rows[0]["SaleAccessTime"];
                si2 = dt.Rows[0]["SaleNesseryTime"] == DBNull.Value || dt.Rows[0]["SaleNesseryTime"] == null ? 0 : (int)dt.Rows[0]["SaleNesseryTime"];
                 si = si1 - si2;
                 if (si < 0)
                 {
                     uc_txtBox_Sum_R.BackColor = Color.Red;
                     uc_txtBox_Sum_R.Text = si.ToString();
                 }
                 else
                 {
                     uc_txtBox_Sum_R.BackColor = Color.Green;
                     uc_txtBox_Sum_R.Text = si.ToString();

                 }

            }
            else
            {
                uc_txtBoxSalePlanDay_R.Text = "0";
                uc_txtBoxSalePlanNessery_R.Text = "0";
                uc_txtBoxSalePlanAccessDay_R.Text = "0";
            }
            // taghir rang dokme ha
            string mo_ = uc_Month1.Mo < 10 ? "0" + uc_Month1.Mo.ToString() : uc_Month1.Mo.ToString();
            uc_Month1.GenColor(new BLL.SalePlan.csSalePlan().SlSalePlanNotConfirm(uc_Month1.Ye.ToString(), mo_), Color.BurlyWood);
        }

        public delegate void functioncall(string message);

        private event functioncall formFunctionPointer;

        //-------------------------------------------------------------------------
        /// <summary>
        /// uc_DataGridViewBtn1
        /// </summary>
        /// <param name="message"></param>
        public delegate void functioncallDataGridViewBtn(string Display, string value);

        private event functioncallDataGridViewBtn uc_DataGridViewBtn1Pointer;


        private void Replicatecmb(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xCustomer_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }
        //-----------------------------------------------------------------------


        public delegate void functioncalluc_Month1PopPup(Control Se, string Text);

        private event functioncalluc_Month1PopPup functioncalluc_Month1PopPupPointer;


        private void ReplicateBtn(Control Se, string Text)
        {

           uc_Month1.ShowPopUp(Se, new BLL.SalePlan.csSalePlan().SlSalePlanPopUp(Text, Text));
          


        }
        //-----------------------------------------------------------------------


        private DAL.SalePlan.DataSet_SalePlan.SlSalePlanDataTable dt_S;

        private void Replicate(string message)
        {
            lbl_Date.Text = message;
            ShowInDataGridView();
            ShowInDatagridViewSummarize();

        }

        private void ShowInDataGridView()
        {
            dt_S = new DAL.SalePlan.DataSet_SalePlan.SlSalePlanDataTable();



            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.SalePlan.csSalePlan cs = new BLL.SalePlan.csSalePlan();
            dt_S = cs.SlSalePlan(lbl_Date.Text, lbl_Date.Text, Se);



            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            Generate();
        }

        bool Dtable(string Cl, string Ty)
        {
            DataTable dt_AC = new DataTable();
            dt_AC.Columns.Add("Name", typeof(String));
            dt_AC.Columns.Add("Type", typeof(String));
            dt_AC.Columns.Add("Allow", typeof(bool));

            dt_AC.Rows.Add("x_", "TE", false);
            dt_AC.Rows.Add("xDate", "TE", true);
            dt_AC.Rows.Add("xPieces_", "TE", false);
            dt_AC.Rows.Add("Pieces", "TE", true);
            dt_AC.Rows.Add("Company", "TE", true);
            dt_AC.Rows.Add("xCount", "TE", true);
            dt_AC.Rows.Add("xCustomer_", "TE", false);
            dt_AC.Rows.Add("xSaleType", "TE", false);
            dt_AC.Rows.Add("xSendKanban", "TE", false);
            dt_AC.Rows.Add("xCarType", "TE", false);
            dt_AC.Rows.Add("xTradeComment", "TE", false);
            dt_AC.Rows.Add("xPlanComment", "TE", false);
            dt_AC.Rows.Add("xPlanUserConfirm_", "TE", false);
            dt_AC.Rows.Add("xConfirmDate", "TE", false);
            dt_AC.Rows.Add("xConfirmKanban", "TE", false);
            dt_AC.Rows.Add("xDraftNumber", "TE", false);
            dt_AC.Rows.Add("xQcComment", "TE", false);
            dt_AC.Rows.Add("xQcUserConfirm_", "TE", false);
            dt_AC.Rows.Add("xDayNumber", "TE", false);
            dt_AC.Rows.Add("xScUserConfirm_", "TE", false);
            dt_AC.Rows.Add("xWeight", "TE", false);
            dt_AC.Rows.Add("xNumberLading", "TE", false);
            dt_AC.Rows.Add("xDriverName", "TE", false);
            dt_AC.Rows.Add("xDriverTel", "TE", false);
            dt_AC.Rows.Add("xCarNumber", "TE", false);
            dt_AC.Rows.Add("xFreightName", "TE", false);
            dt_AC.Rows.Add("xReceptionConfirm", "TE", false);
            dt_AC.Rows.Add("xFinalConfirm", "TE", false);
            dt_AC.Rows.Add("xSupplier_", "TE", false);
            dt_AC.Rows.Add("xQcConfirm", "TE", false);

            dt_AC.Rows.Add("xTradeExitUser", "TE", false);
            dt_AC.Rows.Add("xTradeExitConfirm_", "TE", false);
            dt_AC.Rows.Add("xTradeExitConfirm", "TE", true);


            dt_AC.Rows.Add("x_", "TR", false);
            dt_AC.Rows.Add("xDate", "TR", true);
            dt_AC.Rows.Add("xPieces_", "TR", true);
            dt_AC.Rows.Add("Pieces", "TR", false);
            dt_AC.Rows.Add("Company", "TR", false);
            dt_AC.Rows.Add("xCount", "TR", true);
            dt_AC.Rows.Add("xCustomer_", "TR", true);
            dt_AC.Rows.Add("xSaleType", "TR", true);
            dt_AC.Rows.Add("xSendKanban", "TR", true);
            dt_AC.Rows.Add("xCarType", "TR", true);
            dt_AC.Rows.Add("xTradeComment", "TR", true);
            dt_AC.Rows.Add("xPlanComment", "TR", false);
            dt_AC.Rows.Add("xPlanUserConfirm_", "TR", false);
            dt_AC.Rows.Add("xConfirmDate", "TR", false);
            dt_AC.Rows.Add("xConfirmKanban", "TR", false);
            dt_AC.Rows.Add("xDraftNumber", "TR", false);
            dt_AC.Rows.Add("xQcComment", "TR", false);
            dt_AC.Rows.Add("xQcUserConfirm_", "TR", false);
            dt_AC.Rows.Add("xDayNumber", "TR", false);
            dt_AC.Rows.Add("xScUserConfirm_", "TR", false);
            dt_AC.Rows.Add("xWeight", "TR", false);
            dt_AC.Rows.Add("xNumberLading", "TR", false);
            dt_AC.Rows.Add("xDriverName", "TR", false);
            dt_AC.Rows.Add("xDriverTel", "TR", false);
            dt_AC.Rows.Add("xCarNumber", "TR", false);
            dt_AC.Rows.Add("xFreightName", "TR", false);
            dt_AC.Rows.Add("xReceptionConfirm", "TR", false);
            dt_AC.Rows.Add("xFinalConfirm", "TR", false);
            dt_AC.Rows.Add("xSupplier_", "TR", false);
            dt_AC.Rows.Add("xQcConfirm", "TR", false);

            dt_AC.Rows.Add("xTradeExitUser", "TR", false);
            dt_AC.Rows.Add("xTradeExitConfirm_", "TR", false);
            dt_AC.Rows.Add("xTradeExitConfirm", "TR", false);
            // dt_AC.Rows.Add("xScConfirm", "TR", false);

            dt_AC.Rows.Add("x_", "PL", false);
            dt_AC.Rows.Add("xDate", "PL", true);
            dt_AC.Rows.Add("xPieces_", "PL", false);
            dt_AC.Rows.Add("xCount", "PL", true);
            dt_AC.Rows.Add("xCustomer_", "PL", false);
            dt_AC.Rows.Add("xSaleType", "PL", true);
            dt_AC.Rows.Add("xSendKanban", "PL", false);
            dt_AC.Rows.Add("xCarType", "PL", true);
            dt_AC.Rows.Add("xTradeComment", "PL", true);
            dt_AC.Rows.Add("xPlanComment", "PL", true);
            dt_AC.Rows.Add("xPlanUserConfirm_", "PL", false);
            dt_AC.Rows.Add("xConfirmDate", "PL", true);
            dt_AC.Rows.Add("xConfirmKanban", "PL", true);
            dt_AC.Rows.Add("xDraftNumber", "PL", false);
            dt_AC.Rows.Add("xQcComment", "PL", true);
            dt_AC.Rows.Add("xQcUserConfirm_", "PL", false);
            dt_AC.Rows.Add("xDayNumber", "PL", false);
            dt_AC.Rows.Add("xScUserConfirm_", "PL", false);
            dt_AC.Rows.Add("xWeight", "PL", false);
            dt_AC.Rows.Add("xNumberLading", "PL", false);
            dt_AC.Rows.Add("xDriverName", "PL", false);
            dt_AC.Rows.Add("xDriverTel", "PL", false);
            dt_AC.Rows.Add("xCarNumber", "PL", false);
            dt_AC.Rows.Add("xFreightName", "PL", false);
            dt_AC.Rows.Add("xReceptionConfirm", "PL", false);
            dt_AC.Rows.Add("xFinalConfirm", "PL", false);
            dt_AC.Rows.Add("xSupplier_", "PL", false);
            dt_AC.Rows.Add("xQcConfirm", "PL", false);
            dt_AC.Rows.Add("Pieces", "PL", false);
            dt_AC.Rows.Add("Company", "PL", false);
            dt_AC.Rows.Add("xTradeExitUser", "PL", false);
            dt_AC.Rows.Add("xTradeExitConfirm_", "PL", false);
            dt_AC.Rows.Add("xTradeExitConfirm", "PL", false);
            // dt_AC.Rows.Add("xScConfirm", "PL", true);

            dt_AC.Rows.Add("x_", "QC", false);
            dt_AC.Rows.Add("xDate", "QC", true);
            dt_AC.Rows.Add("xPieces_", "QC", false);
            dt_AC.Rows.Add("xCount", "QC", true);
            dt_AC.Rows.Add("xCustomer_", "QC", false);
            dt_AC.Rows.Add("xSaleType", "QC", true);
            dt_AC.Rows.Add("xSendKanban", "QC", false);
            dt_AC.Rows.Add("xCarType", "QC", true);
            dt_AC.Rows.Add("xTradeComment", "QC", true);
            dt_AC.Rows.Add("xPlanComment", "QC", false);
            dt_AC.Rows.Add("xPlanUserConfirm_", "QC", true);
            dt_AC.Rows.Add("xConfirmDate", "QC", true);
            dt_AC.Rows.Add("xConfirmKanban", "QC", false);
            dt_AC.Rows.Add("xDraftNumber", "QC", false);
            dt_AC.Rows.Add("xQcComment", "QC", true);
            dt_AC.Rows.Add("xQcUserConfirm_", "QC", false);
            dt_AC.Rows.Add("xDayNumber", "QC", true);
            dt_AC.Rows.Add("xScUserConfirm_", "QC", false);
            dt_AC.Rows.Add("xWeight", "QC", false);
            dt_AC.Rows.Add("xNumberLading", "QC", false);
            dt_AC.Rows.Add("xDriverName", "QC", false);
            dt_AC.Rows.Add("xDriverTel", "QC", false);
            dt_AC.Rows.Add("xCarNumber", "QC", false);
            dt_AC.Rows.Add("xFreightName", "QC", false);
            dt_AC.Rows.Add("xReceptionConfirm", "QC", false);
            dt_AC.Rows.Add("xFinalConfirm", "QC", false);
            dt_AC.Rows.Add("xSupplier_", "QC", false);
            dt_AC.Rows.Add("xQcConfirm", "QC", true);
            dt_AC.Rows.Add("Pieces", "QC", false);
            dt_AC.Rows.Add("Company", "QC", false);
            dt_AC.Rows.Add("xTradeExitUser", "QC", false);
            dt_AC.Rows.Add("xTradeExitConfirm_", "QC", false);
            dt_AC.Rows.Add("xTradeExitConfirm", "QC", false);
            //       dt_AC.Rows.Add("xScConfirm", "QC", false);

            dt_AC.Rows.Add("x_", "SC", false);
            dt_AC.Rows.Add("xDate", "SC", true);
            dt_AC.Rows.Add("xPieces_", "SC", false);
            dt_AC.Rows.Add("xCount", "SC", true);
            dt_AC.Rows.Add("xCustomer_", "SC", false);
            dt_AC.Rows.Add("xSaleType", "SC", true);
            dt_AC.Rows.Add("xSendKanban", "SC", false);
            dt_AC.Rows.Add("xCarType", "SC", true);
            dt_AC.Rows.Add("xTradeComment", "SC", true);
            dt_AC.Rows.Add("xPlanComment", "SC", true);
            dt_AC.Rows.Add("xPlanUserConfirm_", "SC", false);
            dt_AC.Rows.Add("xConfirmDate", "SC", true);
            dt_AC.Rows.Add("xConfirmKanban", "SC", false);
            dt_AC.Rows.Add("xDraftNumber", "SC", false);
            dt_AC.Rows.Add("xQcComment", "SC", true);
            dt_AC.Rows.Add("xQcUserConfirm_", "SC", false);
            dt_AC.Rows.Add("xDayNumber", "SC", false);
            dt_AC.Rows.Add("xScUserConfirm_", "SC", false);
            dt_AC.Rows.Add("xWeight", "SC", true);
            dt_AC.Rows.Add("xNumberLading", "SC", true);
            dt_AC.Rows.Add("xDriverName", "SC", true);
            dt_AC.Rows.Add("xDriverTel", "SC", true);
            dt_AC.Rows.Add("xCarNumber", "SC", true);
            dt_AC.Rows.Add("xFreightName", "SC", true);
            dt_AC.Rows.Add("xReceptionConfirm", "SC", true);
            dt_AC.Rows.Add("xFinalConfirm", "SC", true);
            dt_AC.Rows.Add("xSupplier_", "SC", false);
            dt_AC.Rows.Add("xQcConfirm", "SC", false);
            dt_AC.Rows.Add("Pieces", "SC", false);
            dt_AC.Rows.Add("Company", "SC", false);
            dt_AC.Rows.Add("xTradeExitUser", "SC", false);
            dt_AC.Rows.Add("xTradeExitConfirm_", "SC", false);
            dt_AC.Rows.Add("xTradeExitConfirm", "SC", false);
            //   dt_AC.Rows.Add("xScConfirm", "SC", true);

            DataRow[] dr = dt_AC.Select("Name = '" + Cl + "' AND Type = '" + Ty + "'");
            if (dr.Length > 0)
                return (bool)dr[0]["Allow"];
            else
                return true;

        }

        private string Se = "QC";

        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_S.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].Visible = Dtable(dc.ColumnName, Se);
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }


            dataGridView1.Columns["xTradeExitConfirm"].HeaderText = "تایید خروج";
            dataGridView1.Columns["xCustomer_"].HeaderText = "سریال مشتری";
            dataGridView1.Columns["xPieces_"].HeaderText = "سریال قطعه";

            dataGridView1.Columns["xTradeComment"].MinimumWidth = 100;
            dataGridView1.Columns["xQcComment"].MinimumWidth = 100;
            dataGridView1.Columns["xPlanComment"].MinimumWidth = 100;

            dataGridView1.Columns["xTradeComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["xQcComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["xPlanComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.Columns["xDate"].DisplayIndex = 0;
            dataGridView1.Columns["xCarType"].DisplayIndex = 6;
            dataGridView1.Columns["xCustomer_"].DisplayIndex = dataGridView1.Columns["xCustomer"].DisplayIndex;
            dataGridView1.Columns["xPieces_"].DisplayIndex = dataGridView1.Columns["xPieces"].DisplayIndex;
            dataGridView1.Columns["xPieces_"].Width = 50;
            dataGridView1.Columns["xCustomer_"].Width = 50;
            // dataGridView1.Columns["xTradeComment"].Width = 250;
            dt_S.xDateColumn.DefaultValue = lbl_Date.Text;
            dt_S.xSendKanbanColumn.DefaultValue = false;
            dataGridView1.Columns["xDate"].ReadOnly = true;
            dataGridView1.Columns["xDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            if (Se != "TR")
            {
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    item.ReadOnly = true;
                }

            }
            if (Se == "TE")
            {
            dataGridView1.Columns["xTradeExitConfirm"].ReadOnly = false;

            }

            if (Se == "TR")
            {
                dt_S.xSupplier_Column.DefaultValue = BLL.authentication.x_;
                dataGridView1.Columns["xDate"].ReadOnly = false;

            }

            else if (Se == "PL")
            {
                toolStripButton_Add.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;

                dataGridView1.Columns["xPlanComment"].ReadOnly = false;
                dataGridView1.Columns["xConfirmKanban"].ReadOnly = false;
                dataGridView1.Columns["xDraftNumber"].ReadOnly = false;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
            }
            else if (Se == "QC")
            {
                toolStripButton_Add.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;

                dataGridView1.Columns["xQcComment"].ReadOnly = false;
                dataGridView1.Columns["xDayNumber"].ReadOnly = false;
                dataGridView1.Columns["xQcConfirm"].ReadOnly = false;


                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
            }
            else if (Se == "SC")
            {
                toolStripButton_Add.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;

                dataGridView1.Columns["xWeight"].ReadOnly = false;
                dataGridView1.Columns["xNumberLading"].ReadOnly = false;
                dataGridView1.Columns["xWeight"].ReadOnly = false;
                dataGridView1.Columns["xDriverName"].ReadOnly = false;
                dataGridView1.Columns["xDriverTel"].ReadOnly = false;
                dataGridView1.Columns["xCarNumber"].ReadOnly = false;
                dataGridView1.Columns["xFreightName"].ReadOnly = false;
                dataGridView1.Columns["xReceptionConfirm"].ReadOnly = false;
                dataGridView1.Columns["xFinalConfirm"].ReadOnly = false;

                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;

            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Se == "TR")
                {
                    if ((bool?)item.Cells["xConfirmKanban"].Value == true)
                    {
                        item.Cells["xSendKanban"].ReadOnly = true;
                    }
                }
                else if (Se == "PL")
                {
                    if ((bool?)item.Cells["xQcConfirm"].Value == true || (bool?)item.Cells["xFinalConfirm"].Value == true)
                    {
                        item.Cells["xConfirmKanban"].ReadOnly = true;
                    }
                }

            }
            dataGridView1.EndEdit();

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            this.Validate();


            BLL.SalePlan.csSalePlan cs = new BLL.SalePlan.csSalePlan();

            MessageBox.Show(cs.UdSalePlan(dt_S));

            dt_S = new DAL.SalePlan.DataSet_SalePlan.SlSalePlanDataTable();

            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            dt_S = cs.SlSalePlan(lbl_Date.Text, lbl_Date.Text, Se);

            bindingSource1.DataSource = dt_S;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((this.dataGridView1.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn) || (this.dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn))
            {
                this.dataGridView1.BeginEdit(false);
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xCustomer_")
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

        void ShowInDatagridViewSummarize()
        {
            BLL.SalePlan.csSalePlan cs = new BLL.SalePlan.csSalePlan();

            dataGridView2.DataSource = cs.SlSalePlanSummarize(lbl_Date.Text.Substring(0, 8) + "01", lbl_Date.Text.Substring(0, 8) + "31",Payazob.Properties.Settings.Default.WorkYear);

            GenerateSummarize();
        }

        void GenerateSummarize()
        {
            dataGridView2.Columns["inventory"].HeaderText = "موجودی در گردش";
            dataGridView2.Columns["CountKanban"].HeaderText = "تعداد کانبان ارسال شده";
            dataGridView2.Columns["xPieces_"].Visible = false;
            dataGridView2.Columns["Pieces"].HeaderText = "نام قطعه";
            dataGridView2.Columns["Stock"].HeaderText = "موجودی انبار";
            dataGridView2.Columns["total"].HeaderText = "موجودی کل";
            dataGridView2.Columns["CountKanbanUnSend"].HeaderText = "تعداد کانبان ارسال نشده";
            dataGridView2.Columns["NesseryToPlan"].HeaderText = "مانده ظرفیت برنامه فروش";
            dataGridView2.Columns["NesseryToPlanTime"].HeaderText = "ظرفیت قابل برنامه ریزی- دقیقه";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xConfirmKanban")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xPlanUserConfirm_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xConfirmDate", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xPlanUserConfirm_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xConfirmDate", e.RowIndex].Value = DBNull.Value;

                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "xQcConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xQcUserConfirm_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xQcUserConfirm_", e.RowIndex].Value = DBNull.Value;
            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "xTradeExitConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xTradeExitConfirm_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xTradeExitConfirm_", e.RowIndex].Value = DBNull.Value;
            }


            else if (dataGridView1.Columns[e.ColumnIndex].Name == "xFinalConfirm" || dataGridView1.Columns[e.ColumnIndex].Name == "xReceptionConfirm")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xScUserConfirm_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xScUserConfirm_", e.RowIndex].Value = DBNull.Value;
            }

        }

        private void toolStripButtonListView_Click(object sender, EventArgs e)
        {
            frmEmpty_Report f = new frmEmpty_Report("SalePlan", "crsSalePlan");
            (f as frmEmpty_Report).SetParam("x_", false);
            (f as frmEmpty_Report).SetParam("xPieces_", false);
            (f as frmEmpty_Report).SetParam("xCustomer_", false);
            (f as frmEmpty_Report).SetParam("xSupplier_", false);
            (f as frmEmpty_Report).SetParam("xPlanUserConfirm_", false);
            (f as frmEmpty_Report).SetParam("xQcUserConfirm_", false);
            (f as frmEmpty_Report).SetParam("xScUserConfirm_", false);
            (f as frmEmpty_Report).FilterDate = true;
            (f as frmEmpty_Report).dataGridViewAutoSizeEndColumnMode = true;
            f.ShowDialog();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex > -1)
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    var cellRectangle = this.RectangleToScreen(new Rectangle(0,0,0,0));
                    cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    fr.Location = new Point(cellRectangle.X, cellRectangle.Y);
                    fr.ShowDialog();
                    if (fr.accept)
                    {
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;

                    }
                    dataGridView1.CurrentCell = dataGridView1["xCustomer_", e.RowIndex];
                    dataGridView1.BeginEdit(false);
                }
        }






    }
}
