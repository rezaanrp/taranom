using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSandMaterialAndDaily_Report : Form
    {
        public frmSandMaterialAndDaily_Report()
        {
            InitializeComponent();
            BLL.csPieces cp = new BLL.csPieces();
            uc_cmbAutoPieces.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            uc_cmbAutoPieces.DisplayMember = "xName";
            uc_cmbAutoPieces.ValueMember = "x_";
            uc_cmbAutoPieces.SelectedIndex = -1;
        }
        DataTable dt_Sand = new DataTable();

        private void generateForm()
        {

            BLL.csSand cs = new BLL.csSand();
            dt_Sand.Clear();

            dt_Sand = cs.SelectSandMaterialAndDaily((int?)uc_cmbAutoPieces.SelectedValue, uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);

            bindingSource1.DataSource = dt_Sand;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["shift"].HeaderText = "شیفت";
            dataGridView1.Columns["Bantonit"].HeaderText = "بنتونیت";
            dataGridView1.Columns["SandNew"].HeaderText = "ماسه نو";
            dataGridView1.Columns["CoalDust"].HeaderText = "گرد زغال";
            dataGridView1.Columns["Water"].HeaderText = "آب";
            dataGridView1.Columns["SandReturn"].HeaderText = "ماسه برگشتی";
            dataGridView1.Columns["BatchCount"].HeaderText = " تعداد بچ ساخته شده";
            dataGridView1.Columns["AVGBantonit"].HeaderText = " بنتونیت به ازای هر بچ";
            dataGridView1.Columns["AVGSandNew"].HeaderText = "  ماسه نو به ازای هر بچ";
            dataGridView1.Columns["AVGCoalDust"].HeaderText = " گرد زغال به ازای هر بچ";
            dataGridView1.Columns["AVGWater"].HeaderText = " آب به ازای هر بچ";
            dataGridView1.Columns["AVGSandReturn"].HeaderText = " ماسه برگشتی به ازای هر بچ ";
            dataGridView1.Columns["AVGPermeability"].HeaderText = "میانگین عبور گاز ";
            dataGridView1.Columns["AVGCompactibility"].HeaderText = "میانگین تراکم پذیری";
            dataGridView1.Columns["AVGCompresiveStrength"].HeaderText = "میانگین استحکام فشاری";
            dataGridView1.Columns["AVGMoisturePercent"].HeaderText = "میانگین درصد رطوبت ";
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            Report.SendReport csr = new Report.SendReport();
            frmReport r = new frmReport();
            csr.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            csr.SetParam("DateTo", uc_Filter_Date1.DateTo);
            csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            csr.SetParam("Pieces", uc_cmbAutoPieces.Text);
            r.GetReport = csr.GetReport(dt_Sand, "crsSandMaterialAndDaily");
            r.ShowDialog();
            r.Dispose();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            generateForm();
        }
    }
}
