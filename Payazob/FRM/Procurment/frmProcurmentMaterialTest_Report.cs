using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.Procurment
{
    public partial class frmProcurmentMaterialTest_Report : Form
    {
        public frmProcurmentMaterialTest_Report()
        {
            InitializeComponent();
            formFunctionPointer += new functioncall(Replicate);
            uc_ListFiled1.userFunctionPointer = formFunctionPointer;
        }

        DataTable dt;
        public delegate void functioncall(string message);

        private event functioncall formFunctionPointer;

        private void Replicate(string message)
        {
            this.uc_ListFiled1.Visible = false;
            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();

            if (message == "گزارش مواد کمکی ورودی به تفکیک نوع مواد کمکی")
                r.GetReport = cs.GetReport(dt, "crsProcurmentMaterialTestRP");
            else
                r.GetReport = cs.GetReport(dt, "crsProcurmentMaterialTestCo");

            r.ShowDialog();
            r.Dispose();
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.Procurement.csProcurmentMaterialTest cs = new BLL.Procurement.csProcurmentMaterialTest();
            dt = cs.SlProcurmentMaterialTestRp(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            dataGridView1.DataSource = dt;
            bindingSource1.DataSource = dt;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            //   dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            //    dataGridView1.Columns["x_"].Visible = false;

            dataGridView1.Columns["xWeightBeginning"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xWeightDestination"].DefaultCellStyle.Format = "N0";
            dataGridView1.Columns["xRent"].DefaultCellStyle.Format = "N0";
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            uc_ListFiled1.Location = new Point(dataGridView1.Location.X + dataGridView1.Size.Width - 470, dataGridView1.Location.Y + dataGridView1.Size.Height - 100);

            uc_ListFiled1.Visible = true;
            DataTable dt = new DataTable();
            dt.Columns.Add("State", typeof(string));
            dt.Columns.Add("Value", typeof(int));

            DataRow dr = dt.NewRow();
            dr["State"] = "گزارش مواد کمکی ورودی به تفکیک شرکت";
            dr["Value"] = 1;
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["State"] = "گزارش مواد کمکی ورودی به تفکیک نوع مواد کمکی";
            dr1["Value"] = 2;
            dt.Rows.Add(dr1);
            uc_ListFiled1.BringToFront();

            uc_ListFiled1.ValueMemmbers = "Value";
            uc_ListFiled1.DisplayMemmbers = "State";
            uc_ListFiled1.Generate(dt);

            uc_ListFiled1.Focus();


        }
        private void uc_ListFiled1_Leave(object sender, EventArgs e)
        {
            uc_ListFiled1.Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;

        }

        private void frmProcurmentMaterialTest_Report_Resize(object sender, EventArgs e)
        {
            uc_ListFiled1.Visible = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
