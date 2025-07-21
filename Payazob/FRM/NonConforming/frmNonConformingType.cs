using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.NonConforming
{
    public partial class frmNonConformingType : Form
    {
        public frmNonConformingType()
        {
            InitializeComponent();
            Generate();
        }
        DAL.NonConforming.DataSet_NonConforming.SlNonconformingTypeDataTable dt_D;
        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();
        public bool IsUpdate = false;
        void Generate()
        {
            treeView_DownTime.Nodes.Clear();
            TreeNode trn = new TreeNode("نوع عدم تطابق");
            trn.Tag = "-2";
            dt_D = new BLL.Nonconforming.csNonconforming().SlNonconformingType();
            DataRow[] drR = dt_D.Select("xParentId = -1");
            foreach (DataRow item in drR)
            {
                TreeNode tr = new TreeNode(item["xNonConformingName"].ToString());
                tr.Tag = item["x_"].ToString();
                trn.Nodes.Add(tr);
                Stack_tree.Push(tr);
            }
            treeView_DownTime.Nodes.Add(trn);
            while (Stack_tree.Count != 0)
            {
                TreeNode S_tr = Stack_tree.Pop();
                drR = dt_D.Select("xParentId = " + S_tr.Tag);
                foreach (DataRow item in drR)
                {
                    TreeNode tr = new TreeNode(item["xNonConformingName"].ToString()) { Name = "i" + item["x_"].ToString() };
                    tr.Tag = item["x_"].ToString();
                    S_tr.Nodes.Add(tr);
                    Stack_tree.Push(tr);
                }
            }
        }

        private void btn_Tree_Click(object sender, EventArgs e)
        {
            Generate();
        }

        public int Node_x_ = -1;
        public string ChildNode = "";
        private void treeView_DownTime_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Node_x_ = int.Parse(e.Node.Tag.ToString());
            CallRecursive(treeView_DownTime);
            ChildNode += '+' + Node_x_.ToString() + '+';
            this.Close();
        }
        private void PrintRecursive(TreeNode treeNode)
        {
            // Print the node.
            // System.Diagnostics.Debug.WriteLine(treeNode.Text);
            ChildNode += '+' + treeNode.Tag.ToString();
            // Print each node recursively.
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        // Call the procedure using the TreeView.
        private void CallRecursive(TreeView treeView)
        {
            // Print each node recursively.
            TreeNodeCollection nodes = treeView.SelectedNode.Nodes;
            foreach (TreeNode n in nodes)
            {
                PrintRecursive(n);
            }
        }
    }
}
