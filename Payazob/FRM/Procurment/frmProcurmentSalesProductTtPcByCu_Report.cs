using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmProcurmentSalesProductTtPcByCu_Report : Form
    {
        public frmProcurmentSalesProductTtPcByCu_Report()
        {
            InitializeComponent();
            dt_p = new DAL.Procurement.DataSet_ProcurmentSalesProduct.SlProcurmentSalesProductTtPcByCuDataTable();
            bindingSource1.DataSource = dt_p;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        DAL.Procurement.DataSet_ProcurmentSalesProduct.SlProcurmentSalesProductTtPcByCuDataTable dt_p;
        void Generate()
        {
            dataGridView1.Columns["xComponyName"].HeaderText = "نام شرکت";
            dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            dataGridView1.Columns["PiecesCount"].HeaderText = "تعداد";
            dataGridView1.Columns["Productweight"].HeaderText = "وزن";
            dataGridView1.Columns["xComponyName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["xName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["PiecesCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["Productweight"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.Procurement.ProcurementSalesProducts cs = new BLL.Procurement.ProcurementSalesProducts();
            dt_p = cs.SlProcurmentSalesProductTtPcByCu(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);
            bindingSource1.DataSource = dt_p;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
           // crsProcurmentSalesProductTtPcByCu
            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_p, "crsProcurmentSalesProductTtPcByCu");
            r.ShowDialog();
            r.Dispose();
        }
    }
}
