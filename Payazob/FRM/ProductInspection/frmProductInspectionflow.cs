using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.ProductInspection
{
    public partial class frmProductInspectionflow : Form
    {
        public frmProductInspectionflow()
        {
            InitializeComponent();
        }
        DataTable dt_f;
        DataTable dt_T;

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
            Generate();
        }
        void Generate()
        {


            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_f.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["xPiece_"].Visible = false;
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

        void SaveFileDialog()
        {
            try
            {

                SaveFileDialog dlgOpen = new SaveFileDialog();

                dlgOpen.Filter =

          "Image Files(*.PNG)|*.PNG";

              //  dlgOpen.Title = "انتخاب تصوير";

                if (dlgOpen.ShowDialog() == DialogResult.OK)
                    this.chart1.SaveImage(dlgOpen.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);

            }

            catch (SystemException ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }

        private void ToolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog();

        }


    }
}
