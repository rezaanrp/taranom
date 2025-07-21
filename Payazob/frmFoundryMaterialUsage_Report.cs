using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmFoundryMaterialUsage_Report : Form
    {
        public frmFoundryMaterialUsage_Report()
        {
            InitializeComponent();
        }
        DataTable dt_f;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csFoundry cs = new BLL.csFoundry();
            string Tp = "B";
            if (rbt_D.Checked)
                Tp = "D";
            else if (rbt_G.Checked)
                Tp = "G";
            else
                Tp = "B";
            dt_f = cs.SlFoundryMaterialUsage(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo,Tp);
            bindingSource1.DataSource = dt_f;
            dataGridView1.DataSource = bindingSource1;
            Generate();
        }
        void Generate()
        {
            dataGridView1.Columns["xMaterialName"].HeaderText = "نام مواد";
            dataGridView1.Columns["Furnace1"].HeaderText = "کوره یک";
            dataGridView1.Columns["Furnace2"].HeaderText = "کوره دو";
            dataGridView1.Columns["Furnace3"].HeaderText = "کوره سه";
            dataGridView1.Columns["Furnace4"].HeaderText = "کوره چهار";
            dataGridView1.Columns["Total"].HeaderText = "مجموع";
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //FoundryMaterialUsage
            Report.SendReport csr = new Report.SendReport();
            csr.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            csr.SetParam("DateTo", uc_Filter_Date1.DateTo);
            csr.SetParam("DateNow", uc_Filter_Date1.DateTo);
            frmReport r = new frmReport();
            r.GetReport = csr.GetReport(dt_f, "crsFoundryMaterialUsage");
            r.ShowDialog();
            r.Dispose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;

        }
    }
}
