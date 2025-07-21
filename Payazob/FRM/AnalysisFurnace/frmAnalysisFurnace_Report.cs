using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.AnalysisFurnace
{
    public partial class frmAnalysisFurnace_Report : Form
    {
        public frmAnalysisFurnace_Report()
        {
            InitializeComponent();
        }
        System.Data.DataTable dt_A;
        System.Data.DataTable dt_T;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            dt_A = new BLL.AnalyzeFurnace.csAnalyzeFurnace().SlAnalyzeFurnaceDataTable(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            System.Data.DataTable dt = dt_A.DefaultView.ToTable(true, "xPieces_", "xPieces");
            treeView1.Nodes.Clear();
            TreeNode trn = new TreeNode("نام قطعه");
            trn.Tag = "-2";
            foreach (DataRow item in dt.Rows)
            {
   TreeNode tr = new TreeNode(item["xPieces"].ToString());
   tr.Tag = item["xPieces_"].ToString();
   trn.Nodes.Add(tr);
            }
            treeView1.Nodes.Add(trn);
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1; 
            generate();

        }
        void generate()
        {
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xPieces"].HeaderText = "نامه قطعه";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xPieces_"].Visible = false;
            dataGridView1.Columns["xfe"].HeaderText = "fe";
            dataGridView1.Columns["xC"].HeaderText = "C";
            dataGridView1.Columns["xSi"].HeaderText = "Si";
            dataGridView1.Columns["xMn"].HeaderText = "Mn";
            dataGridView1.Columns["xP"].HeaderText = "P";
            dataGridView1.Columns["xS"].HeaderText = "S";
            dataGridView1.Columns["xCr"].HeaderText = "Cr";
            dataGridView1.Columns["xMo"].HeaderText = "Mo";
            dataGridView1.Columns["xNi"].HeaderText = "Ni";
            dataGridView1.Columns["xAl"].HeaderText = "Al";
            dataGridView1.Columns["xCo"].HeaderText = "Co";
            dataGridView1.Columns["xCu"].HeaderText = "Cu";
            dataGridView1.Columns["xMg"].HeaderText = "Mg";
            dataGridView1.Columns["xNb"].HeaderText = "Nb";
            dataGridView1.Columns["xTi"].HeaderText = "Ti";
            dataGridView1.Columns["xV"].HeaderText = "V";
            dataGridView1.Columns["xSn"].HeaderText = "Sn";
            dataGridView1.Columns["xB"].HeaderText = "B";
            dataGridView1.Columns["xZr"].HeaderText = "Zr";
            dataGridView1.Columns["xAs"].HeaderText = "As";
            dataGridView1.Columns["xCe"].HeaderText = "Ce";
            dataGridView1.Columns["xSupplier"].HeaderText = "تهیه کننده";
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Report.SendReport csr = new Report.SendReport();
            csr.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            csr.SetParam("DateTo", uc_Filter_Date1.DateTo);
            csr.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();

            r.GetReport = csr.GetReport(new BLL.AnalyzeFurnace.csAnalyzeFurnace().SlAnalyzeFurnaceSPC(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, int.Parse(treeView1.SelectedNode.Tag.ToString())), "crsAnalysisFurnaceSPC");
            r.ShowDialog();
            r.Dispose();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataRow[] dr;
            if( e.Node.Tag.ToString() == "-2")
 dr  = dt_A.Select();
            else 
             dr = dt_A.Select("xPieces_ = " + e.Node.Tag.ToString());
            if (dr.Length > 0)
            {
   dt_T = dr.CopyToDataTable();
   bindingSource1.DataSource = dt_T;
   dataGridView1.DataSource = bindingSource1;
   bindingNavigator1.BindingSource = bindingSource1;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;

        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }


    }
}
