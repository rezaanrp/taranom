using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.ProductInspection
{
    public partial class frmProductInspectionOnDetailsChart : Form
    {
        public frmProductInspectionOnDetailsChart()
        {
            InitializeComponent();
        }
        DataTable dt_f;
        DataTable dt_T;
        private void frmProductInspectionOnDetailsChart_Load(object sender, EventArgs e)
        {
 
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csQualityControl cs = new BLL.csQualityControl();
            dt_f = cs.SlPruductInspectionflow(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_f;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            System.Data.DataTable dt = dt_f.DefaultView.ToTable(true, "xPiece_", "Pieces");
            treeView1.Nodes.Clear();
            TreeNode trn = new TreeNode("نام قطعه");
            trn.Tag = "-2";
            foreach (DataRow item in dt.Rows)
            {
                TreeNode tr = new TreeNode(item["Pieces"].ToString());
                tr.Tag = item["xPiece_"].ToString();
                trn.Nodes.Add(tr);
            }
            treeView1.Nodes.Add(trn);
         //   Generate();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataRow[] dr;
            if (e.Node.Tag.ToString() == "-2")
                dr = dt_f.Select();
            else
                dr = dt_f.Select("xPiece_ = " + e.Node.Tag.ToString());
            if (dr.Length > 0)
            {
                dt_T = dr.CopyToDataTable();
                bindingSource1.DataSource = dt_T;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            chart1.DataSource = dt_T;
            chart1.Series["Series1"].XValueMember = "xProductionDate";
            chart1.Series["Series1"].YValueMembers = "NumberPieces";
            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            chart1.Series["Series2"].XValueMember = "xProductionDate";
            chart1.Series["Series2"].YValueMembers = "DefectNumber";
            chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            Form frm = new Form();

            chart1.Dock = DockStyle.Fill;
            frm.Controls.Add(chart1);

            frm.ShowDialog();

        }
    }
}
