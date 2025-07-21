using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.MaterialLocation
{
    public partial class frmMaterialLocation : Form
    {
        public frmMaterialLocation()
        {
            InitializeComponent();
        }
        public string _CodeLocation = "";
        public int _ObjectCode = -1;
        public string _ObjectName = "";
        public string _ObjectSGCode = "";
        void Generate()
        {
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xObjectTable_"].Visible = false;
            dataGridView1.Columns["xNeedExtra"].HeaderText = "قطعه جایگزین";
            dataGridView1.Columns["xCodeParent"].HeaderText = "کد مکان";
            dataGridView1.Columns["ObjectName"].HeaderText = "نام قطعه";
            dataGridView1.Columns["ObjectName"].DisplayIndex = 1;
            dataGridView1.Columns["xSerialSG"].HeaderText = "کد همکاران";

        }
        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();

        DAL.Object.DataSet_Object.mObjectTreeDataTable dt_T = new DAL.Object.DataSet_Object.mObjectTreeDataTable();

        void GenerateTree()
        {
            treeView1.Nodes.Clear();
         //   BLL.MaterialLocation.csMatarialLocation cs = new BLL.MaterialLocation.csMatarialLocation();

            DataTable dt_D = new PAYAIND.DeviceTree.DeviceTree().SlDeviceTreeData();
            //   tag_ = Convert.ToInt32(dt_D.Compute("min(xParentId_)", string.Empty));
            DataRow[] drR = dt_D.Select("xparentid IS NULL");
            foreach (DataRow item in drR)
            {
                TreeNode tr = new TreeNode(item["xcod"].ToString() + " " + item["xnameset"].ToString() + "   ");
                tr.Tag =  item["xcod"].ToString();
                treeView1.Nodes.Add(tr);
                Stack_tree.Push(tr);
            }
            while (Stack_tree.Count != 0)
            {
                TreeNode S_tr = Stack_tree.Pop();
                    S_tr.NodeFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                drR = dt_D.Select("xparentid = '" +  S_tr.Tag.ToString()+"'" );
                foreach (DataRow item in drR)
                {
                    TreeNode tr = new TreeNode(item["xcod"].ToString() + " " + item["xnameset"].ToString() + "   ") { Name = "i" + item["xcod"].ToString() };
                    tr.Tag = item["xcod"].ToString();
  
                    S_tr.Nodes.Add(tr);
                    Stack_tree.Push(tr);
                }
            }
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string cod =  e.Node.Tag.ToString();
            cod = cod.Replace(" ", "");
            if (e.Node.Tag.ToString().Length != 15)
            {
                if (cod.Length == 6)
                {
                    cod+= "-00-00-00";
                }
                else if (cod.Length == 9)
                {
                    cod+= "-00-00";
                }
                else if (cod.Length == 12)
                {
                    cod+= "-00";
                }
            }
            DataTable dt = new PAYAIND.ObjectLocation.csObjectLoation().mObjectLocation(cod);
            dataGridView1.DataSource = dt;
            bindingSource1.DataSource = dataGridView1.DataSource;
            Generate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
            CS.csSearchTreeView tr = new CS.csSearchTreeView();
            tr.CallRecursiveTreeView(treeView1, textBox1.Text);
            if (textBox1.Text == "" || tr.tr.Count < 1)
            {
                return;
            }
            foreach (TreeNode item in tr.tr)
            {
                TreeNode tn = item;
                while (tn != null)
                {
                    tn.Expand();
                    tn = tn.Parent;

                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _ObjectCode = (int)dataGridView1["xObjectTable_", e.RowIndex].Value;

                _CodeLocation = dataGridView1["xCodeParent", e.RowIndex].Value != DBNull.Value ? (string)dataGridView1["xCodeParent", e.RowIndex].Value : "";
                _ObjectName = dataGridView1["ObjectName", e.RowIndex].Value != DBNull.Value ? (string)dataGridView1["ObjectName", e.RowIndex].Value : "";
                _ObjectSGCode = dataGridView1["xSerialSG", e.RowIndex].Value != DBNull.Value ? (string)dataGridView1["xSerialSG", e.RowIndex].Value : "";

                this.Close();

            }
        }
      

    }
}
