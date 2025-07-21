using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.FIFO
{
    public partial class frmInvMaterialInput : Form
    {
        public frmInvMaterialInput()
        {
            InitializeComponent();
            //BLL.csshamsidate cs = new BLL.csshamsidate();
            //cs.DayOfYearShamsi("1392/08/05");

            BLL.FIFO.csInvMaterial cs = new BLL.FIFO.csInvMaterial();
            dt_P = new DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialInputDataTable();
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.csMaterial csm = new BLL.csMaterial();
            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing ;
            combobox_xMaterialType_.DisplayIndex = 2;
            combobox_xMaterialType_.HeaderText = "نوع مواد";
            combobox_xMaterialType_.DataSource = csm.SlMaterial("A",0);
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xMaterial_";
            combobox_xMaterialType_.Name = "xMaterial";
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.MaxDropDownItems = 30;


            dataGridView1.Columns.Add(combobox_xMaterialType_);


            uc_DataGridViewBtn1.ColumnsFilter_ = "xMaterialName";
            uc_DataGridViewBtn1.Ds = csm.SlMaterial("A",0);

            uc_DataGridViewBtn1.ParamName = new string[] { "xMaterialName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام مواد" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xType", "xModule_","xGenType_", "Module","xConditionMaintenance",
                        "xFeature",
                        "xAcceptCriteria",
                        "xControlTools",
                        "xSupplier_",
                        "xSupplier",
                        "xDateEdit" };

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;

            dt_P_D = new DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialMinusDataTable();
            dt_P.xAmountColumn.DefaultValue = 0;
            bindingSource2.DataSource = dt_P_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            Genrate_D();
            Generate();



        }
        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
                dataGridView1["xMaterial_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
            }
        }

        DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialInputDataTable dt_P;
        DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialMinusDataTable dt_P_D;
        void Generate()
        {
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName); 
            }
            //dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["MaterialName"].Visible = false;
            dataGridView1.Columns["xSendAlarm"].Visible = false;
            dataGridView1.Columns["xMaterial_"].HeaderText = "شماره سریال ماده";
            BLL.csshamsidate cs = new BLL.csshamsidate();
            bool flag = false;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                flag = cs.CompareDate(cs.previousDay(-int.Parse(item.Cells["xDateAlarm"].Value.ToString())), item.Cells["xDateExp"].Value.ToString());
                if (flag)
                {
                    item.DefaultCellStyle.BackColor = Color.MediumVioletRed;
                }
            }

            dataGridView1.Columns["xRemain"].ReadOnly = true;

            dataGridView1.Columns["xMaterial"].ReadOnly = true;
            dataGridView1.Columns["x_"].ReadOnly = true;
            dataGridView1.Columns["x_"].Width = 0;
            dataGridView1.Columns["x_"].HeaderText = "سریال";

        }
        void Genrate_D()
        {
            CS.csDic css = new CS.csDic();
            foreach (DataColumn dc in dt_P_D.Columns)
            {
                dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView2.Columns["xAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xInvMaterialInput_"].Visible = false;


        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();
        }

        void ShowDataGridView()
        {
            dt_P = new DAL.FIFO.DataSet_InvMaterialInput.SlInvMaterialInputDataTable();
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.FIFO.csInvMaterial cs = new BLL.FIFO.csInvMaterial();
            dt_P = cs.SlInvMaterialInput(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_P.xAmountColumn.DefaultValue = 0;

            //dt_P.xDatePrdColumn.DefaultValue = " ";
            //dt_P.xDateEnterColumn.DefaultValue = " ";
            //dt_P.xDateExpColumn.DefaultValue = " ";
            //dt_P.xDateAlarmColumn.DefaultValue = "0";
            //dt_P.xSystemCodeColumn.DefaultValue = "0";
            //dt_P.xRemainColumn.DefaultValue = 0;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridView();
        }

        void SaveDataGridView()
        {
            this.dataGridView1.EndEdit();
            this.Validate();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
               if(!item.IsNewRow)
                if (item.Cells["xDateAlarm"].Value == DBNull.Value || item.Cells["xDateAlarm"].Value == null)
                {
                    MessageBox.Show("مقدار هشدار تعیین نشده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }


            BLL.FIFO.csInvMaterial cs = new BLL.FIFO.csInvMaterial();
            if (new CS.csMessage().ShowMessageSaveYesNo())
                MessageBox.Show(cs.UdInvMaterialInput(dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dt_P = cs.SlInvMaterialInput(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_P.xAmountColumn.DefaultValue = 0;

            Generate();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string cln = dataGridView1.Columns[e.ColumnIndex].Name;

            if ((cln != "xDatePrd" && cln != "xDateEnter" && cln != "xDateExp" && cln != "xLocation") && 
               ( (this.dataGridView1.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn) || (this.dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)))
            {
                try
                {
                    this.dataGridView1.BeginEdit(false);
                }
                catch
                {
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xMaterial_")
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

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.dataGridView2.EndEdit();
            this.Validate();
            BLL.FIFO.csInvMaterial cs = new BLL.FIFO.csInvMaterial();
            if (new CS.csMessage().ShowMessageSaveYesNo())
                MessageBox.Show(cs.UdInvMaterialMinus(dt_P_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string cln = dataGridView1.Columns[e.ColumnIndex].Name;
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (cln == "xLocation")
                {
                    FRM.FIFO.FrmInvLocation fr = new FRM.FIFO.FrmInvLocation();
                    fr.StartPosition = FormStartPosition.CenterParent;
                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
               //    dataGridView1.CurrentCell = null;

                    dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex + 1, e.RowIndex];
                    FRM.frmDate.frmDate frr = new FRM.frmDate.frmDate();
                    frr.StartPosition = FormStartPosition.CenterParent;

                    frr.ShowDialog();
                    if (frr.accept)
                        dataGridView1[e.ColumnIndex + 1, e.RowIndex].Value = frr.fDate;
                    else
                           dataGridView1.CurrentCell = null;


                    dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex + 2, e.RowIndex];
                    frr.ShowDialog();
                    if (frr.accept)
                        dataGridView1[e.ColumnIndex + 2, e.RowIndex].Value = frr.fDate;
                    else
                            dataGridView1.CurrentCell = null;


                    dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex + 3, e.RowIndex];
                    frr.ShowDialog();
                    if (frr.accept)
                        dataGridView1[e.ColumnIndex + 3, e.RowIndex].Value = frr.fDate;
                    else
                           dataGridView1.CurrentCell = null;

                ///    dataGridView1[e.ColumnIndex + 4, e.RowIndex].Value = frr.fDate;


                    dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex + 4, e.RowIndex];

                   //if (dataGridView1.Rows.Count > e.RowIndex)
                   //    dataGridView1.Rows[e.RowIndex].Selected = true;
                    //dataGridView1.ClearSelection();
                  // dataGridView1[e.ColumnIndex + 1, e.RowIndex].Selected = true;

                }
                else if (cln == "xDatePrd" || cln == "xDateEnter" || cln == "xDateExp") 
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    fr.StartPosition = FormStartPosition.CenterParent;

                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView1[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                    //dataGridView1.CurrentCell = null;
                   // dataGridView1.Rows[e.RowIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex +1, e.RowIndex];

                    //dataGridView1.ClearSelection();
                    dataGridView1[e.ColumnIndex + 1, e.RowIndex].Selected = true;
                }

        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string cln = dataGridView2.Columns[e.ColumnIndex].Name;
            if (!dataGridView2[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (cln == "xDate")
                {
                    FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();
                    fr.StartPosition = FormStartPosition.CenterParent;

                    fr.ShowDialog();
                    if (fr.accept)
                        dataGridView2[e.ColumnIndex, e.RowIndex].Value = fr.fDate;
                    dataGridView2.CurrentCell = dataGridView2["xAmount", e.RowIndex];
                }
        }

        private void frmInvMaterialInput_Resize(object sender, EventArgs e)
        {
            uc_DataGridViewBtn1.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         //   dataGridView1.CurrentCell = dataGridView1[e.ColumnIndex, e.RowIndex];
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int inx = (int)dataGridView1.SelectedRows[0].Cells["x_"].Value;
                DataRow[] dr = dt_P.Select("x_ = " + inx.ToString());
                //dt_P.Select("x_ = " + dataGridView1.SelectedRows[0].Cells["x_"].Value.ToString() );
                Report.SendReport cs = new Report.SendReport();
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(dr.CopyToDataTable(), "crsInvMaterialInputLabel");
                r.ShowDialog();
                r.Dispose();
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            BLL.FIFO.csInvMaterial cs = new BLL.FIFO.csInvMaterial();
            dt_P_D = cs.SlInvMaterialMinus((int?)dataGridView1["x_", e.RowIndex].Value);
            bindingSource2.DataSource = dt_P_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            dt_P_D.xInvMaterialInput_Column.DefaultValue = (int?)dataGridView1["x_", e.RowIndex].Value;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.Control | Keys.Enter):
                    ShowDataGridView();
                    break;
                case (System.Windows.Forms.Keys.Control | Keys.S):
                    SaveDataGridView();
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));
        }

    }
}
