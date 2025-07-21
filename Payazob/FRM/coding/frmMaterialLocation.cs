using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.coding
{
    public partial class frmMaterialLocation : Form
    {
        public frmMaterialLocation()
        {
            InitializeComponent();
        }

        void Generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xMaterialName"].HeaderText = "نام قطعه";

            BLL.Object.csObject cs = new BLL.Object.csObject();
            DataTable dt_D = cs.SlObjectTree();

            //foreach (DataRow item in dt_D.Rows)
            //{
            //    foreach (DataGridViewRow ItemGrid in dataGridView1.Rows)
            //    {
            //        if (ItemGrid.Cells["x_"].Value.ToString() == item["xObject_"].ToString())
            //            ItemGrid.DefaultCellStyle.BackColor = Color.Green;
            //    }
            //}

        }
        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();

        DAL.MaterialLocation.DataSet_MaterialLocation.mMaterialLocationDataTable dt_M;
        DataTable dt_O;
        DAL.Object.DataSet_Object.mObjectTreeDataTable dt_T = new DAL.Object.DataSet_Object.mObjectTreeDataTable();

        void GenerateTree()
        {
            treeView1.Nodes.Clear();
           // BLL.MaterialLocation.csMatarialLocation cs = new BLL.MaterialLocation.csMatarialLocation();
            PAYAIND.DeviceTree.DeviceTree cs = new PAYAIND.DeviceTree.DeviceTree();
            DataTable dt_D = cs.SlDeviceTreeData();
            //   tag_ = Convert.ToInt32(dt_D.Compute("min(xParentId_)", string.Empty));
            DataRow[] drR = dt_D.Select("xparentid IS NULL");
            foreach (DataRow item in drR)
            {
   //xcod,  xnameset1 as xnameset
   TreeNode tr = new TreeNode(item["xcod"].ToString() + " " + item["xnameset"].ToString() + "   ");
   tr.Tag = item["xcod"].ToString();
   treeView1.Nodes.Add(tr);
   Stack_tree.Push(tr);
            }
            while (Stack_tree.Count != 0)
            {
   TreeNode S_tr = Stack_tree.Pop();
 //  if (int.Parse(S_tr.Tag.ToString()) > 0)
 //  {
       //  S_tr.ForeColor = Color.Yellow;
       S_tr.NodeFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
  // }
   drR = dt_D.Select("xparentid = '" + S_tr.Tag.ToString()+"'");
   foreach (DataRow item in drR)
   {
       TreeNode tr = new TreeNode(item["xcod"].ToString() + " " + item["xnameset"].ToString() + "   ") { Name = "i" + item["xcod"].ToString() };
       tr.Tag = item["xcod"].ToString() ;
       S_tr.Nodes.Add(tr);
       Stack_tree.Push(tr);
   }
            }

            // gentree();
            treeView1.ExpandAll();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (treeView1.SelectedNode != null
   // && dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.WhiteSmoke
   )
            {
   //   dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);

   string yourChildNode;
   yourChildNode = dataGridView1["xObjectFarsiName", e.RowIndex].Value.ToString();
   TreeNode nd = new TreeNode(yourChildNode);
   nd.Tag = dataGridView1["x_", e.RowIndex].Value.ToString();
   treeView1.SelectedNode.Nodes.Add(nd);
   //treeView1.ExpandAll();
   dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

            }
        }
        int tag_ = 0;



        private void RemoveRecursive(TreeNode treeNode)
        {

            if (int.Parse(treeNode.Tag.ToString()) > 0)
   foreach (DataGridViewRow item in dataGridView1.Rows)
   {
       if ((int)item.Cells["x_"].Value == int.Parse(treeNode.Tag.ToString()))
       {
           item.DefaultCellStyle.BackColor = Color.WhiteSmoke;
       }
   }
            // Print each node recursively.
            foreach (TreeNode tn in treeNode.Nodes)
            {
   RemoveRecursive(tn);
            }
        }

        private void CallRecursive(TreeNodeCollection treeView)
        {
            // Print each node recursively.
            //TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in treeView)
            {
   RemoveRecursive(n);
            }
        }

        private void FillDataTableRecursive(TreeNode treeNode)
        {
            DataRow dr = dt_T.NewRow();
            dr["xObject_"] = treeNode.Tag;
            if (treeNode.Parent != null)
   dr["xParent_"] = treeNode.Parent.Tag;
            dr["xName"] = treeNode.Text;
            dt_T.Rows.Add(dr);
            foreach (TreeNode tn in treeNode.Nodes)
            {
   FillDataTableRecursive(tn);
            }
        }

        private void CallRecursiveTreeView(TreeView treeView)
        {
            // Print each node recursively.
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
   FillDataTableRecursive(n);
            }
        }
        private void frmMaterilLocation_Load(object sender, EventArgs e)
        {
            GenerateTree();
            treeView1.CollapseAll();
          //  ShowMatrial();
        }

        void ShowMatrial()
        {
            BLL.csMaterial cs = new BLL.csMaterial();
            dt_O = cs.mMaterialForLocation();
            dataGridView1.DataSource = dt_O;
            bindingSource1.DataSource = dt_O;
            Generate();
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.Tag.ToString());
        }



  
    }
}
