using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.ProductRepairRequest
{
    public partial class frmProductRepairRequest : Form
    {
        public frmProductRepairRequest(string Sec)
        {
            InitializeComponent();

            BLL.Module.Module Md = new BLL.Module.Module();
            DataGridViewComboBoxColumn combobox_xModule_ = new DataGridViewComboBoxColumn();
            combobox_xModule_.DisplayIndex = 11;
            combobox_xModule_.HeaderText = "واحد شمارش";
            combobox_xModule_.DataSource = Md.SelectMudole();
            combobox_xModule_.DisplayMember = "xModuleName";
            combobox_xModule_.ValueMember = "x_";
            combobox_xModule_.Name = "xUnit_";
            combobox_xModule_.DataPropertyName = "xUnit_";
            //combobox_xModule_.DisplayIndex = 4;

            dataGridView1.Columns.Add(combobox_xModule_);

            Section = Sec;
            dt_P = new DAL.ProductRepairRequest.DataSet_ProductRepairRequest.SlProductRepairRequestDataTable();
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xDateSupplierColumn.DefaultValue = BLL.csshamsidate.shamsidate;



            Generate();
           
        }
        string Section = "";
        DAL.ProductRepairRequest.DataSet_ProductRepairRequest.SlProductRepairRequestDataTable dt_P;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowDataGridView();

        }
        void ShowDataGridView()
        {
            BLL.ProductRepairRequest.csProductRepairRequest cs = new BLL.ProductRepairRequest.csProductRepairRequest();

            if(Section == "US")
                dt_P = cs.SlProductRepairRequest(uc_Filter_Date1.DateFrom,uc_Filter_Date1.DateTo,BLL.authentication.x_,-1);
            else
                dt_P = cs.SlProductRepairRequest(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1,-1);

            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_P.xDateSupplierColumn .DefaultValue = BLL.csshamsidate.shamsidate;

            Generate();

        }
        void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xName"].HeaderText = "شرح کالا"; 
            dataGridView1.Columns["xCount"].HeaderText = "تعداد"; 
            dataGridView1.Columns["xUnit"].HeaderText = "واحد شمارش"; 
            dataGridView1.Columns["xUsagePlace"].HeaderText = "محل نصب / استقرار"; 
            dataGridView1.Columns["xRepairNeeded"].HeaderText = "تعمیرات مورد نیاز"; 
            dataGridView1.Columns["xDestination"].HeaderText = "گیرنده"; 
            dataGridView1.Columns["xDateReturn"].HeaderText = "تاریخ برگشت"; 
            dataGridView1.Columns["xSupplier"].HeaderText = "ثبت کننده"; 
            dataGridView1.Columns["xDateSupplier"].HeaderText = "تاریخ ثبت"; 
            dataGridView1.Columns["xManNet"].HeaderText = "مدیر نت"; 
            dataGridView1.Columns["xManNetApprove"].HeaderText = "تایید مدیر نت"; 
            dataGridView1.Columns["xReturn"].HeaderText = "برگشت شده"; 
            dataGridView1.Columns["xReturnSupplier"].HeaderText = "تایید کننده برگشت";

            dataGridView1.Columns["xUnit_"].DisplayIndex = 4;

            dataGridView1.Columns["xCount"].Visible = false;

            dataGridView1.Columns["xUnit"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xManNet_"].Visible = false;
            dataGridView1.Columns["xReturnSupplier_"].Visible = false;


            if (Section == "US")
            {
                dataGridView1.Columns["xReturn"].ReadOnly = true;
                dataGridView1.Columns["xManNetApprove"].ReadOnly = true;
                dataGridView1.Columns["xDateSupplier"].ReadOnly = true;
                dataGridView1.Columns["xManNetApprove"].ReadOnly = true;

                dataGridView1.Columns["xReturn"].DefaultCellStyle.BackColor = Color.LightPink;
                dataGridView1.Columns["xManNetApprove"].DefaultCellStyle.BackColor = Color.LightPink;
                dataGridView1.Columns["xDateSupplier"].DefaultCellStyle.BackColor = Color.LightPink;
                dataGridView1.Columns["xManNetApprove"].DefaultCellStyle.BackColor = Color.LightPink;

                dataGridView1.Columns["xSupplier"].DefaultCellStyle.BackColor = Color.LightPink;
                dataGridView1.Columns["xManNetApprove"].DefaultCellStyle.BackColor = Color.LightPink;
                dataGridView1.Columns["xReturnSupplier"].DefaultCellStyle.BackColor = Color.LightPink;
                dataGridView1.Columns["xManNet"].DefaultCellStyle.BackColor = Color.LightPink;

            }



        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {

                BLL.ProductRepairRequest.csProductRepairRequest cs = new BLL.ProductRepairRequest.csProductRepairRequest();
                MessageBox.Show(cs.UdProductRepairRequest(dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDataGridView();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xManNetApprove"].Index)
                if ((bool)dataGridView1["xManNetApprove", e.RowIndex].Value == true)
                {
                    dataGridView1["xManNet_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xManNet_", e.RowIndex].Value = DBNull.Value;
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridView1.Columns["xReturn"].Index)
                if ((bool)dataGridView1["xReturn", e.RowIndex].Value == true)
                {
                    dataGridView1["xReturnSupplier_", e.RowIndex].Value = BLL.authentication.x_;
                }
                else
                    dataGridView1["xReturnSupplier_", e.RowIndex].Value = DBNull.Value;
        }

        private void frmProductRepairRequest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
                if (dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                    dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
                else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
                    dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;  
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (!dataGridView1[e.ColumnIndex, e.RowIndex].ReadOnly)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "xDateReturn")
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
            if(dataGridView1.SelectedRows.Count > 0)
             inx = (int)dataGridView1.SelectedRows[0].Cells["x_"].Value;
            if(inx > 0)
            {
                BLL.ProductRepairRequest.csProductRepairRequest cs = new BLL.ProductRepairRequest.csProductRepairRequest();
         

                Report.SendReport crs = new Report.SendReport();
                crs.SetParam("DateNow", uc_Filter_Date1.DateTo);

                frmReport r = new frmReport();
                r.GetReport = crs.GetReport(cs.SlProductRepairRequest(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1,inx), "crsProductRepairRequest");
                r.ShowDialog();
                r.Dispose();
            }
           
        }
    }
}
