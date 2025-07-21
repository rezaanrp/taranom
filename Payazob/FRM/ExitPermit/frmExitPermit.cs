using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.ExitPermit
{
    public partial class frmExitPermit : Form
    {
        public frmExitPermit(string section_)
        {
            Se = section_;
            InitializeComponent();
            splitContainer5.Panel2Collapsed = true;

            dt_E = new DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitDataTable();

            //combo noe kala T = امانی M = تعمیرات P = فروش دائم R = عودتی


            DataTable dt_Type = new DataTable();
            dt_Type.Columns.Add("State", typeof(string));
            dt_Type.Columns.Add("Value", typeof(string));

            DataRow dr = dt_Type.NewRow();
            dr["State"] = "امانی";
            dr["Value"] = "T";
            dt_Type.Rows.Add(dr);

            DataRow dr1 = dt_Type.NewRow();
            dr1["State"] = "تعمیرات";
            dr1["Value"] = "M";
            dt_Type.Rows.Add(dr1);

            DataRow dr2 = dt_Type.NewRow();
            dr2["State"] = "فروش دائم";
            dr2["Value"] = "P";
            dt_Type.Rows.Add(dr2);

            DataRow dr3 = dt_Type.NewRow();
            dr3["State"] = "عودتی";
            dr3["Value"] = "R";
            dt_Type.Rows.Add(dr3);

            DataGridViewComboBoxColumn combobox_Type = new DataGridViewComboBoxColumn();
            combobox_Type.HeaderText = "نوع خروج";
            combobox_Type.DataSource = dt_Type;
            combobox_Type.DisplayMember = "State";
            combobox_Type.ValueMember = "Value";
            combobox_Type.DataPropertyName = "xType";
            combobox_Type.Name = "xType";
            combobox_Type.Visible = true;
            dataGridView1.Columns.Add(combobox_Type);

            BLL.Module.Module Md = new BLL.Module.Module();
            DataGridViewComboBoxColumn combobox_xModule_ = new DataGridViewComboBoxColumn();
            combobox_xModule_.DisplayIndex = 11;
            combobox_xModule_.HeaderText = "واحد";
            combobox_xModule_.DataSource = Md.SelectMudole();
            combobox_xModule_.DisplayMember = "xModuleName";
            combobox_xModule_.ValueMember = "x_";
            combobox_xModule_.Name = "xModule_";
            combobox_xModule_.DataPropertyName = "xModule_";
            dataGridView1.Columns.Add(combobox_xModule_);

            BLL.Section.csSection Sec = new BLL.Section.csSection();
            DataGridViewComboBoxColumn combobox_Section = new DataGridViewComboBoxColumn();
            combobox_Section.HeaderText = "واحد درخواست کننده";
            combobox_Section.DataSource = Sec.SlSection();
            combobox_Section.DisplayMember = "xSectionName";
            combobox_Section.ValueMember = "x_";
            combobox_Section.Name = "xSection_";
            combobox_Section.DataPropertyName = "xSection_";
            dataGridView1.Columns.Add(combobox_Section);

            bindingSource1.DataSource = dt_E;
            dt_E.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
           
            Generate();

            if (Se == "US")
                this.Text = "درخواست مجوز خروج";
            else if (Se == "BS")
                this.Text = "تایید مجوز خروج کالا مدیریت کارخانه";

            else if (Se == "SC")
                this.Text = "تایید مجوز خروج کالا - انتظامات";

            else if (Se == "MN")
                this.Text = "تایید مجوز خروج کالا مدیریت";

            else if (Se == "IN")
                this.Text = "تایید مجوز خروج کالا انبار";
        }

        DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitDataTable dt_E;
        DAL.ExitPermit.DataSet_ExitPermit.SlExitPermitBackDataTable dt_P_D;


        private void btn_Show_Click(object sender, EventArgs e)
        {
             BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();

            if (Se == "US")
                dt_E = cs.SlExitPermit(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, BLL.authentication.x_, -1);
            else
                dt_E = cs.SlExitPermit(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1, -1);

            bindingSource1.DataSource = dt_E;
             dataGridView1.DataSource = bindingSource1;
             bindingNavigator1.BindingSource = bindingSource1;
             Generate();
        }

        string Se = "";

        bool Dtable(string Cl, string Ty)
        {
            DataTable dt_AC = new DataTable();
            
            dt_AC.Columns.Add("Name", typeof(String));
            dt_AC.Columns.Add("Type", typeof(String));
            dt_AC.Columns.Add("Allow", typeof(bool));

            dt_AC.Rows.Add("x_", "US", false);
            dt_AC.Rows.Add("xDate", "US", true);
            dt_AC.Rows.Add("xCode", "US", false);
            dt_AC.Rows.Add("xMaterial", "US", true);
            dt_AC.Rows.Add("xType", "US", true);
            dt_AC.Rows.Add("xAmount", "US", true);
            dt_AC.Rows.Add("xModule_", "US", true);
            dt_AC.Rows.Add("xReceiver", "US", true);
            dt_AC.Rows.Add("xDateReturn", "US", true);
            dt_AC.Rows.Add("xOutCause", "US", true);
            dt_AC.Rows.Add("xInventorConfirm", "US", false);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "US", false);
            dt_AC.Rows.Add("xManagerConfirm", "US", false);
            dt_AC.Rows.Add("xBossConfirm", "US", false);
            dt_AC.Rows.Add("xSupplier_", "US", false);
            dt_AC.Rows.Add("Supplier", "US", true);
            dt_AC.Rows.Add("xSection_", "US", true);
            dt_AC.Rows.Add("xInventor_", "US", false);
            dt_AC.Rows.Add("Inventor", "US", false);
            dt_AC.Rows.Add("xSecuritySection_", "US", false);
            dt_AC.Rows.Add("SecuritySection", "US", false);
            dt_AC.Rows.Add("xManager_", "US", false);
            dt_AC.Rows.Add("Manager", "US", false);
            dt_AC.Rows.Add("xBoss_", "US", false);
            dt_AC.Rows.Add("Boss", "US", false);
            dt_AC.Rows.Add("xConfirmBack", "US", false);

            dt_AC.Rows.Add("x_", "IN", false);
            dt_AC.Rows.Add("xDate", "IN", true);
            dt_AC.Rows.Add("xCode", "IN", true);
            dt_AC.Rows.Add("xMaterial", "IN", true);
            dt_AC.Rows.Add("xType", "IN", true);
            dt_AC.Rows.Add("xAmount", "IN", true);
            dt_AC.Rows.Add("xModule_", "IN", true);
            dt_AC.Rows.Add("xReceiver", "IN", true);
            dt_AC.Rows.Add("xDateReturn", "IN", true);
            dt_AC.Rows.Add("xOutCause", "IN", true);
            dt_AC.Rows.Add("xInventorConfirm", "IN", true);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "IN", false);
            dt_AC.Rows.Add("xManagerConfirm", "IN", false);
            dt_AC.Rows.Add("xBossConfirm", "IN", false);
            dt_AC.Rows.Add("xSupplier_", "IN", false);
            dt_AC.Rows.Add("Supplier", "IN", true);
            dt_AC.Rows.Add("xSection_", "IN", true);
            dt_AC.Rows.Add("xInventor_", "IN", false);
            dt_AC.Rows.Add("Inventor", "IN", true);
            dt_AC.Rows.Add("xSecuritySection_", "IN", false);
            dt_AC.Rows.Add("SecuritySection", "IN", false);
            dt_AC.Rows.Add("xManager_", "IN", false);
            dt_AC.Rows.Add("Manager", "IN", false);
            dt_AC.Rows.Add("xBoss_", "IN", false);
            dt_AC.Rows.Add("Boss", "IN", false);
            dt_AC.Rows.Add("xConfirmBack", "IN", false);

            dt_AC.Rows.Add("x_", "MN", false);
            dt_AC.Rows.Add("xDate", "MN", true);
            dt_AC.Rows.Add("xCode", "MN", true);
            dt_AC.Rows.Add("xMaterial", "MN", true);
            dt_AC.Rows.Add("xType", "MN", true);
            dt_AC.Rows.Add("xAmount", "MN", true);
            dt_AC.Rows.Add("xModule_", "MN", true);
            dt_AC.Rows.Add("xReceiver", "MN", true);
            dt_AC.Rows.Add("xDateReturn", "MN", true);
            dt_AC.Rows.Add("xOutCause", "MN", true);
            dt_AC.Rows.Add("xInventorConfirm", "MN", false);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "MN", false);
            dt_AC.Rows.Add("xManagerConfirm", "MN", true);
            dt_AC.Rows.Add("xBossConfirm", "MN", false);
            dt_AC.Rows.Add("xSupplier_", "MN", false);
            dt_AC.Rows.Add("Supplier", "MN", true);
            dt_AC.Rows.Add("xSection_", "MN", true);
            dt_AC.Rows.Add("xInventor_", "MN", false);
            dt_AC.Rows.Add("Inventor", "MN", true);
            dt_AC.Rows.Add("xSecuritySection_", "MN", false);
            dt_AC.Rows.Add("SecuritySection", "MN", false);
            dt_AC.Rows.Add("xManager_", "MN", false);
            dt_AC.Rows.Add("Manager", "MN", true);
            dt_AC.Rows.Add("xBoss_", "MN", false);
            dt_AC.Rows.Add("Boss", "MN", false);
            dt_AC.Rows.Add("xConfirmBack", "MN", false);

            dt_AC.Rows.Add("x_", "BS", false);
            dt_AC.Rows.Add("xDate", "BS", true);
            dt_AC.Rows.Add("xCode", "BS", true);
            dt_AC.Rows.Add("xMaterial", "BS", true);
            dt_AC.Rows.Add("xType", "BS", true);
            dt_AC.Rows.Add("xAmount", "BS", true);
            dt_AC.Rows.Add("xModule_", "BS", true);
            dt_AC.Rows.Add("xReceiver", "BS", true);
            dt_AC.Rows.Add("xDateReturn", "BS", true);
            dt_AC.Rows.Add("xOutCause", "BS", true);
            dt_AC.Rows.Add("xInventorConfirm", "BS", false);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "BS", false);
            dt_AC.Rows.Add("xManagerConfirm", "BS", false);
            dt_AC.Rows.Add("xBossConfirm", "BS", true);
            dt_AC.Rows.Add("xSupplier_", "BS", false);
            dt_AC.Rows.Add("Supplier", "BS", true);
            dt_AC.Rows.Add("xSection_", "BS", true);
            dt_AC.Rows.Add("xInventor_", "BS", false);
            dt_AC.Rows.Add("Inventor", "BS", true);
            dt_AC.Rows.Add("xSecuritySection_", "BS", false);
            dt_AC.Rows.Add("SecuritySection", "BS", false);
            dt_AC.Rows.Add("xManager_", "BS", false);
            dt_AC.Rows.Add("Manager", "BS", true);
            dt_AC.Rows.Add("xBoss_", "BS", false);
            dt_AC.Rows.Add("Boss", "BS", true);
            dt_AC.Rows.Add("xConfirmBack", "BS", false);

            dt_AC.Rows.Add("x_", "SC", false);
            dt_AC.Rows.Add("xDate", "SC", true);
            dt_AC.Rows.Add("xCode", "SC", true);
            dt_AC.Rows.Add("xMaterial", "SC", true);
            dt_AC.Rows.Add("xType", "SC", true);
            dt_AC.Rows.Add("xAmount", "SC", true);
            dt_AC.Rows.Add("xModule_", "SC", true);
            dt_AC.Rows.Add("xReceiver", "SC", true);
            dt_AC.Rows.Add("xDateReturn", "SC", true);
            dt_AC.Rows.Add("xOutCause", "SC", true);
            dt_AC.Rows.Add("xInventorConfirm", "SC", false);
            dt_AC.Rows.Add("xSecuritySectionConfirm", "SC", true);
            dt_AC.Rows.Add("xManagerConfirm", "SC", false);
            dt_AC.Rows.Add("xBossConfirm", "SC", false);
            dt_AC.Rows.Add("xSupplier_", "SC", false);
            dt_AC.Rows.Add("Supplier", "SC", true);
            dt_AC.Rows.Add("xSection_", "SC", true);
            dt_AC.Rows.Add("xInventor_", "SC", false);
            dt_AC.Rows.Add("Inventor", "SC", true);
            dt_AC.Rows.Add("xSecuritySection_", "SC", false);
            dt_AC.Rows.Add("SecuritySection", "SC", false);
            dt_AC.Rows.Add("xManager_", "SC", false);
            dt_AC.Rows.Add("Manager", "SC", true);
            dt_AC.Rows.Add("xBoss_", "SC", false);
            dt_AC.Rows.Add("Boss", "SC", true);
            dt_AC.Rows.Add("xConfirmBack", "SC", true);

            DataRow[] dr = dt_AC.Select("Name = '" + Cl + "' AND Type = '" + Ty + "'");
            if (dr.Length > 0)
                return (bool)dr[0]["Allow"];
            else
                return true;

        }

        void Generate()
        {

            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_E.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].Visible = Dtable(dc.ColumnName, Se);
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
           // dt_E.xInventorConfirmColumn.DefaultValue = dt_E.xManagerConfirmColumn.DefaultValue = dt_E.xBossConfirmColumn.DefaultValue = dt_E.xSecuritySectionConfirmColumn.DefaultValue = dt_E.xManagerConfirmColumn.DefaultValue = false;
            dt_E.xInventorConfirmColumn.DefaultValue = dt_E.xBossConfirmColumn.DefaultValue = dt_E.xSecuritySectionConfirmColumn.DefaultValue = false;
            dataGridView1.Columns["xModule_"].DisplayIndex = dataGridView1.Columns["xMaterial"].DisplayIndex + 1 ;

            dataGridView1.Columns["xSection_"].HeaderText = "واحددرخواست کننده";
            dataGridView1.Columns["xMaterial"].HeaderText = "نام کالا";
            dataGridView1.Columns["Supplier"].HeaderText = "در خواست کننده";
            //dataGridView1.Columns["xConfirmBack"].ReadOnly = true;
            

            if (Se != "US")
            {
                bindingNavigator1.AddNewItem.Visible = false;
                bindingNavigator1.DeleteItem.Visible = false;
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    if (item.CellType.Name == "DataGridViewCheckBoxCell")
                        item.ReadOnly = false;
                    else
                        item.ReadOnly = true;

                }
                //dataGridView1.Columns["xConfirmBack"].ReadOnly = false;

            }
            if (Se == "US")
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((bool)item.Cells["xSecuritySectionConfirm"].Value == true )
                        item.ReadOnly = true;
                    else
                        item.ReadOnly = false;

                }
            }
            if (Se == "IN")
            {
                dataGridView1.Columns["xCode"].ReadOnly = false;
            }
            else
                dataGridView1.Columns["xCode"].ReadOnly = false;

            dt_E.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_E.xDateReturnColumn.DefaultValue = "1397/00/00";
            dt_E.xConfirmBackColumn.DefaultValue = false;
            dt_E.xInventorConfirmColumn.DefaultValue = false;
           // dt_E.xManagerConfirmColumn.DefaultValue = false;
            dt_E.xSecuritySectionConfirmColumn.DefaultValue = false;
            dt_E.xSupplier_Column.DefaultValue = BLL.authentication.x_;

        }

        void Generate_D()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P_D.Columns)
            {
                dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xExitPermit_"].Visible = false;
            dataGridView2.Columns["xCommentBack"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //====================================================================||||||||||||||||
            Validation.VDate v = new Validation.VDate();

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ( (item.Cells["xDateReturn"].Value.ToString() == "" || item.Cells["xDateReturn"].Value.ToString() == "0000/00/00") 
                    && (item.Cells["xDateReturn"].Value == DBNull.Value || (bool)item.Cells["xDateReturn"].Value != false))
                {
                    item.Cells["xDateReturn"].Style.BackColor = Color.Red;
                    MessageBox.Show("خطا در وارد کردن تاریخ");
                    return;
                }
            }

            this.dataGridView1.EndEdit();
            this.Validate();
            BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();
            MessageBox.Show(cs.UdExitPermit(dt_E));

            // dt_P.xSupplierColumn.DefaultValue = BLL.authentication.NameAndFamily;

            bindingSource1.DataSource = dt_E;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xType")
            {

                if (dataGridView1[e.ColumnIndex, e.RowIndex].EditedFormattedValue == "فروش دائم" || dataGridView1[e.ColumnIndex, e.RowIndex].EditedFormattedValue == "عودتی")
                {
                    dataGridView1["xConfirmBack", e.RowIndex].Value = true;
                   // dataGridView1["xDateReturn", e.R2owIndex].Visible = false;
                }
                else
                    dataGridView1["xConfirmBack", e.RowIndex].Value = false;

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xInventorConfirm"].Index)
                if ((bool)dataGridView1["xInventorConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xInventor_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xInventor_", e.RowIndex].Value = DBNull.Value;
            //---------------------------------------------------------------------------------------------------------
            //else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xManagerConfirm"].Index)
            //    if ((bool)dataGridView1["xManagerConfirm", e.RowIndex].Value == true)
            //    {
            //        dataGridView1["xManager_", e.RowIndex].Value = BLL.authentication.x_;
            //    }
            //    else
            //        dataGridView1["xManager_", e.RowIndex].Value = DBNull.Value;
            //---------------------------------------------------------------------------------------------------------

            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xBossConfirm"].Index)
                if ((bool)dataGridView1["xBossConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xBoss_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xBoss_", e.RowIndex].Value = DBNull.Value;
            //---------------------------------------------------------------------------------------------------------

            else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xSecuritySectionConfirm"].Index)
                if ((bool)dataGridView1["xSecuritySectionConfirm", e.RowIndex].Value == true)
                {
                    dataGridView1["xSecuritySection_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xSecuritySection_", e.RowIndex].Value = DBNull.Value;

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate" || dataGridView1.Columns[e.ColumnIndex].Name == "xDateReturn")
            {
                if (dataGridView1["xType", e.RowIndex].EditedFormattedValue == "تعمیرات" || dataGridView1["xType", e.RowIndex].EditedFormattedValue == "امانی")
                {
                    Validation.VDate v = new Validation.VDate();
                    if (e.FormattedValue.ToString() != "")
                        e.Cancel = !v.ValidationDate(e.FormattedValue.ToString());
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Se == "SC")
            {

                splitContainer5.Panel2Collapsed = false;
                BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();
                dt_P_D = cs.SlExitPermitBack((int?)dataGridView1["x_", e.RowIndex].Value);
                dt_P_D.xDateBackColumn.DefaultValue = BLL.csshamsidate.shamsidate;
                bindingSource2.DataSource = dt_P_D;
                dataGridView2.DataSource = bindingSource2;
                bindingNavigator2.BindingSource = bindingSource2;
                dt_P_D.xExitPermit_Column.DefaultValue = (int?)dataGridView1["x_", e.RowIndex].Value;
                Generate_D();

            }
            else
            {
                splitContainer5.Panel2Collapsed = true;
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataGridView2.EndEdit();
            if (dataGridView2["xExitPermit_", 0].Value == null)
                return;
            int? t = (int?)dataGridView2["xExitPermit_", 0].Value;
            BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();
            MessageBox.Show(cs.UdExitPermitBack(dt_P_D));
            dt_P_D = cs.SlExitPermitBack(t);
            bindingSource2.DataSource = dt_P_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            Generate_D();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDateBack"  )
            {
                Validation.VDate v = new Validation.VDate();

                e.Cancel = !v.ValidationDate(e.FormattedValue.ToString());
            }

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
                dataGridView1.BeginEdit(false);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(!dataGridView1[e.ColumnIndex,e.RowIndex].ReadOnly)
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xDate" || dataGridView1.Columns[e.ColumnIndex].Name == "xDateReturn" )
            {
                FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                fr.Location = new Point(cellRectangle.X, cellRectangle.Y);
                fr.ShowDialog();
                if (fr.accept)
                    dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            int inx = -1;
            if (dataGridView1.SelectedRows.Count > 0)
                inx = (int)dataGridView1.SelectedRows[0].Cells["x_"].Value;
            if (inx > 0)
            {
                BLL.ExitPermit.csExitPermit cs = new BLL.ExitPermit.csExitPermit();


                Report.SendReport crs = new Report.SendReport();
                crs.SetParam("DateNow", uc_Filter_Date1.DateTo);

                frmReport r = new frmReport();
                r.GetReport = crs.GetReport(cs.SlExitPermit(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1, inx), "crsExitPermitRequest");
                r.ShowDialog();
                r.Dispose();
            }
        }
    }
}
