using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Foundry
{
    public partial class frmFoundryMaterialUsageCheck : Form
    {
        public frmFoundryMaterialUsageCheck()
        {
            InitializeComponent();
           // BLL.csMaterial csm = new BLL.csMaterial();


            dt_F = new DAL.Foundry.DataSet_Foundry.SlFoundryMaterialUsageCheckDataTable();
        }
        DAL.Foundry.DataSet_Foundry.SlFoundryMaterialUsageCheckDataTable dt_F;
        private void frmFoundryMaterialUsageCheck_Load(object sender, EventArgs e)
        {


        }



        private void btn_Show_Click_1(object sender, EventArgs e)
        {


        }
        void Generate()
        {
            dataGridView1.Columns["xMaterial_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;


            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["ShiftName"].HeaderText = "نام شیفت";
            dataGridView1.Columns["xMaterial"].HeaderText = "نام مواد";
            dataGridView1.Columns["Furnace1"].HeaderText = "کوره یک";
            dataGridView1.Columns["Furnace2"].HeaderText = "کوره دو";
            dataGridView1.Columns["Furnace3"].HeaderText = "کوره سه";
            dataGridView1.Columns["Furnace4"].HeaderText = "کوره چهار";
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataRow[] dr = dt_F.Select("xMaterial_ = " + ((System.Windows.Forms.TreeView)(sender)).SelectedNode.Tag);
            DataTable dt1 ;
            if (dr.Length > 0)
            {
                dt1 = dr.CopyToDataTable();
                dataGridView1.DataSource = dt1;
                Generate();

            }

            else
                dt1 = new DataTable();
                 dataGridView1.DataSource = dt1;
                
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            dt_F = new BLL.csFoundry().SlFoundryMaterialUsageCheck(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);

          //  treeView1 = new TreeView();
            DataView view = new DataView(dt_F);
            DataTable distinctValues = view.ToTable(true, "xMaterial", "xMaterial_" );

                        TreeNode trn = new TreeNode("لیست مواد");
                        trn.Tag = -1;

            foreach (DataRow item in distinctValues.Rows)
            {
                TreeNode tr = new TreeNode(item["xMaterial"].ToString());
                tr.Tag = item["xMaterial_"].ToString();
                 trn.Nodes.Add(tr);
            }
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(trn);

           dataGridView1.DataSource = dt_F;
           Generate();

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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
