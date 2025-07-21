using System.Collections.Generic;
using System.Windows.Forms;

namespace Payazob.CS
{
    public class csSearchTreeView
    {

       public List<TreeNode> tr = new List<TreeNode>();
        
        private void SearchTreeRecursive(TreeNode treeNode, string key)
        {

            foreach (TreeNode tn in treeNode.Nodes)
            {
   if (tn.Text.Contains(key))
   {
       tr.Add(tn);
   }
   SearchTreeRecursive(tn,key);
            }
        }

        public void CallRecursiveTreeView(TreeView treeView, string key)
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
   if (n.Text.Contains(key))
   {
       tr.Add(n);
   }
   SearchTreeRecursive(n,key);

            }
        }
    }
}
