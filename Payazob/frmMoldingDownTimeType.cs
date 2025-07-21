using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Payazob
{

    public static class TreeViewExtensions
    {
        public static List<string> GetExpansionState(this TreeNodeCollection nodes)
        {
            return nodes.Descendants()
                        .Where(n => n.IsExpanded)
                        .Select(n => n.FullPath)
                        .ToList();
        }

        public static void SetExpansionState(this TreeNodeCollection nodes, List<string> savedExpansionState)
        {
            foreach (var node in nodes.Descendants()
                                      .Where(n => savedExpansionState.Contains(n.FullPath)))
            {
                node.Expand();
            }
        }

        public static IEnumerable<TreeNode> Descendants(this TreeNodeCollection c)
        {
            foreach (var node in c.OfType<TreeNode>())
            {
                yield return node;

                foreach (var child in node.Nodes.Descendants())
                {
                    yield return child;
                }
            }
        }
    }
    public partial class frmMoldingDownTimeType : Form
    {
        public frmMoldingDownTimeType(bool EditAble,CS.csEnum.TypeTree typ,CS.csEnum.Factory FCT)
        {
            InitializeComponent();
            fct_ = FCT;
            if (!EditAble)
            {
                btn_AddTree.Visible = false;
                btn_edit.Visible = false;
                txt_NodeText.Visible = false;
                txt_Code.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            if (typ == CS.csEnum.TypeTree.DownTimeType)
            { TypeTree = "xNameDownTime";
            TreeName = "توقفات ";
            }

            else if (typ == CS.csEnum.TypeTree.DownTimeObject)
            { TypeTree = "xNameObject";
            TreeName = "مکانیزم ها";
            }
            typT = typ;
            
            Generate();


        }
        CS.csEnum.Factory fct_;
        string TypeTree = "";
        string TreeName = "";
        CS.csEnum.TypeTree typT;
        DAL.MoldingDownTime.DataSet_MoldingDownTime.mMoldingDowntimeTypeDataTable dt_D;
        DAL.MoldingDownTime.DataSet_MoldingDownTime.mMoldingDownTimeObjectDataTable dt_O;
        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();
        public  bool IsUpdate = false;
        void Generate()
        {
            treeView_DownTime.Nodes.Clear();

            TreeNode trn = new TreeNode(TreeName);
            trn.Tag = "-2";
            BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
            DataRow[] drR;
            if (typT == CS.csEnum.TypeTree.DownTimeType)
            {
                dt_D = cs.SelectMoldingDownTimeType((int)fct_,true);
                drR = dt_D.Select("xParentId = -1");
            }
            else
            {
                dt_O = cs.SelectMoldingDownTimeObject();
                drR = dt_O.Select("xParentId = -1");
            }

            foreach (DataRow item in drR)
            {
                string st = item["xCode"] == null || item["xCode"]  == DBNull.Value? "" : item["xCode"].ToString();
                TreeNode tr = new TreeNode("" + st + "-" + "" + "" + item["x_"].ToString() + "-" + "" + item[TypeTree].ToString());
                tr.Tag = item["x_"].ToString();
                trn.Nodes.Add(tr);
                Stack_tree.Push(tr);
            }
            treeView_DownTime.Nodes.Add(trn);
            while (Stack_tree.Count != 0)
            {
                TreeNode S_tr = Stack_tree.Pop();
                if (typT == CS.csEnum.TypeTree.DownTimeType)
                     drR = dt_D.Select("xParentId = " + S_tr.Tag);
                else
                    drR = dt_O.Select("xParentId = " + S_tr.Tag);

                foreach (DataRow item in drR)
                {
                    string st = item["xCode"] == null || item["xCode"] == DBNull.Value ? "" : item["xCode"].ToString();

                    TreeNode tr = new TreeNode("" + st + "-" + "" + "" + item["x_"].ToString() + "-" + "" + item[TypeTree].ToString()) { Name = "i" + item["x_"].ToString() };
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
        Dictionary<string, bool> TreeState_ = new Dictionary<string, bool>();

        private void  SaveTreeState(TreeView tree)
        {
          //  Dictionary<string, bool> nodeStates = new Dictionary<string, bool>();
            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                if (tree.Nodes[i].Nodes.Count > 0)
                {
                    TreeState_.Add(tree.Nodes[i].Name, tree.Nodes[i].IsExpanded);
                }
            }

         //   return nodeStates;
        }
        private void RestoreTreeState(TreeView tree, Dictionary<string, bool> treeState)
        {
            for (int i = 0; i < tree.Nodes.Count; i++)
            {
                if (treeState.ContainsKey(tree.Nodes[i].Name))
                {
                    if (treeState[tree.Nodes[i].Name])
                        tree.Nodes[i].Expand();
                    else
                        tree.Nodes[i].Collapse();
                }
            }
        }


        IEnumerable<TreeNode> Collect(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                yield return node;
                foreach (TreeNode child in Collect(node.Nodes))
                    yield return child;
            }
        }
        private void btn_AddTree_Click(object sender, EventArgs e)
        {

            if (treeView_DownTime.SelectedNode == null)
            {
                MessageBox.Show("هیچ نودی جهت اضافه شدن به ان انتخاب نشده");
                return;
            }

            if (txt_NodeText.Text == "" ||
                  txt_NodeText.Text == " " ||
                  txt_NodeText.Text == "  "  
                )
            {
                return;
            }

            var savedExpansionState = treeView_DownTime.Nodes.GetExpansionState();

            int i = treeView_DownTime.SelectedNode.Index;
      //    int idx = dt_D.Rows.IndexOf(dt_D.Select("x_ = " + treeView_DownTime.SelectedNode.Tag.ToString())[0]);

            if (typT == CS.csEnum.TypeTree.DownTimeType)
            {
                DataRow dr = dt_D.NewRow();
                dr[TypeTree] = txt_NodeText.Text;
                dr["xParentId"] = int.Parse(treeView_DownTime.SelectedNode.Tag.ToString());
                if (treeView_DownTime.SelectedNode.Parent == null)
                    dr["xParentId"] = -1;
                dr["xGenFact_"] = (int)fct_;
                dr["xCode"] = txt_Code.Text;
                dr["xDeactive"] = false;
                dt_D.Rows.Add(dr);

                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                if (cs.UdMoldingDownTimeType(dt_D))
                    MessageBox.Show("ارسال با موفقیت انجام شد");
                else
                    MessageBox.Show("خطا");
            }
            else if(typT == CS.csEnum.TypeTree.DownTimeObject)
            {
                DataRow dr = dt_O.NewRow();
                dr[TypeTree] = txt_NodeText.Text;
                dr["xParentId"] = int.Parse(treeView_DownTime.SelectedNode.Tag.ToString());
                if (treeView_DownTime.SelectedNode.Parent == null)
                    dr["xParentId"] = -1;
                dr["xCode"] = txt_Code.Text;
                dt_O.Rows.Add(dr);
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                if (cs.UdMoldingDownTimeObject(dt_O))
                    MessageBox.Show("ارسال با موفقیت انجام شد");
                else
                    MessageBox.Show("خطا");
            }
                Generate();
            
          // treeView_DownTime.Nodes[i].Expand();
           IsUpdate = true;
           treeView_DownTime.Nodes.SetExpansionState(savedExpansionState);
       //    RestoreTreeState(treeView_DownTime, TreeState_);
        }

        private void treeView_DownTime_MouseClick(object sender, MouseEventArgs e)
        {

        }
       
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var savedExpansionState = treeView_DownTime.Nodes.GetExpansionState();
            if (typT == CS.csEnum.TypeTree.DownTimeType)
            {
                int idx = dt_D.Rows.IndexOf(dt_D.Select("x_ = " + treeView_DownTime.SelectedNode.Tag.ToString())[0]);
                dt_D.Rows[idx][TypeTree] = txt_NodeText.Text;
                dt_D.Rows[idx]["xCode"] = txt_Code.Text;
                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                if (cs.UdMoldingDownTimeType(dt_D))
                    MessageBox.Show("ارسال با موفقیت انجام شد");
                else
                    MessageBox.Show("خطا");
            }
            else if (typT == CS.csEnum.TypeTree.DownTimeObject)
            {
                int idx = dt_O.Rows.IndexOf(dt_O.Select("x_ = " + treeView_DownTime.SelectedNode.Tag.ToString())[0]);
                dt_O.Rows[idx][TypeTree] = txt_NodeText.Text;
                dt_D.Rows[idx]["xCode"] = txt_Code.Text;

                BLL.MoldingDownTime.MoldingDownTime cs = new BLL.MoldingDownTime.MoldingDownTime();
                if (cs.UdMoldingDownTimeObject(dt_O))
                    MessageBox.Show("ارسال با موفقیت انجام شد");
                else
                    MessageBox.Show("خطا");
            }

            Generate();
            IsUpdate = true;
            treeView_DownTime.Nodes.SetExpansionState(savedExpansionState);

        }
        public int Node_x_ = -1;
        public string ChildNode = "";
        public CS.csEnum.TypeForm tyfrm = CS.csEnum.TypeForm.Report; 
        private void treeView_DownTime_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView_DownTime.SelectedNode == null)
                return;

            if (tyfrm == CS.csEnum.TypeForm.Report)
            {
                Node_x_ = int.Parse(treeView_DownTime.SelectedNode.Tag.ToString());
                CallRecursive(treeView_DownTime);
                ChildNode += '+' + Node_x_.ToString() + '+';
                this.Close();
            }
            else
            {
                if (treeView_DownTime.SelectedNode.Nodes.Count > 0)
                    return;
                Node_x_ = int.Parse(treeView_DownTime.SelectedNode.Tag.ToString());
                CallRecursive(treeView_DownTime);
                ChildNode += '+' + Node_x_.ToString() + '+';
                this.Close();
            }
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
            if (treeView.SelectedNode.Nodes.Count > 0)
            {
                TreeNodeCollection nodes = treeView.SelectedNode.Nodes;
                foreach (TreeNode n in nodes)
                {
                    PrintRecursive(n);
                }
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (tyfrm == CS.csEnum.TypeForm.Report)
            {
                if (treeView_DownTime.SelectedNode == null)
                {
                    MessageBox.Show("برای در یافت گزارش بر روی یک توقف کلیک کنید");
                    return;
                }
                Node_x_ = int.Parse(treeView_DownTime.SelectedNode.Tag.ToString());
                CallRecursive(treeView_DownTime);
                ChildNode += '+' + Node_x_.ToString() + '+';
                this.Close();
            }
            else
            {
                if (treeView_DownTime.SelectedNode.Nodes.Count > 0)
                    return;
                Node_x_ = int.Parse(treeView_DownTime.SelectedNode.Tag.ToString());
                CallRecursive(treeView_DownTime);
                ChildNode += '+' + Node_x_.ToString() + '+';
                this.Close();
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool expandtreeview = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (expandtreeview)
            {
                treeView_DownTime.ExpandAll();
                expandtreeview = false;
            }
            else
            {
                treeView_DownTime.CollapseAll();
                expandtreeview = true;

            }
        }

        private void treeView_DownTime_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            txt_NodeText.Text = e.Node.Text.Split('-').Length > 2 ? e.Node.Text.Split('-')[2] : e.Node.Text;
            txt_Code.Text = e.Node.Text.Split('-').Length > 2 ? e.Node.Text.Split('-')[0] : e.Node.Text;
        }
    }
}
