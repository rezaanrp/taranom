using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.EditObjectGroup
{
    public partial class frmEditObjectGroup : Form
    {
        public frmEditObjectGroup()
        {
            InitializeComponent();
        }

        void Generate()
        {
            dataGridView1.Columns["xObjectname"].HeaderText = "نام انگلیسی";
            dataGridView1.Columns["xObjectFarsiName"].HeaderText = "نام فارسی";
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xRegistringGroup_"].Visible = false;
            dataGridView1.Columns["xType_"].Visible = false;
            dataGridView1.Columns["xObjectType"].HeaderText = "نوع";
            
            dataGridView1.Columns["xGroup_"].Visible = false;
            BLL.Object.csObject cs = new BLL.Object.csObject();
            DataTable dt_D = cs.SlObjectTree();

            foreach (DataRow item in dt_D.Rows)
            {
                foreach (DataGridViewRow ItemGrid in dataGridView1.Rows)
                {
                    if (ItemGrid.Cells["x_"].Value.ToString() == item["xObject_"].ToString())
                        ItemGrid.DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();

        void GenerateTree()
        {
            int cntnn = 0;
            treeView1.Nodes.Clear();
            //TreeNode trn = new TreeNode("");
            // trn.Tag = "-2";
            BLL.Object.csObject cs = new BLL.Object.csObject();

            DataTable dt_D = cs.SlObjectTree();
            if (dt_D.Rows.Count < 1 )
            {
                return;
            }
            if (dt_D.Compute("min(xParent_)", string.Empty)  == DBNull.Value)
                --tag_ ;
            else
                tag_ = Convert.ToInt32(dt_D.Compute("min(xParent_)", string.Empty));
            DataRow[] drR = dt_D.Select("xParent_ IS NULL");
            foreach (DataRow item in drR)
            {
                TreeNode tr = new TreeNode(item["xName"].ToString());
                tr.Tag = item["xObject_"].ToString();
                treeView1.Nodes.Add(tr);
                Stack_tree.Push(tr);
            }
            while (Stack_tree.Count != 0)
            {
                TreeNode S_tr = Stack_tree.Pop();
                if (int.Parse(S_tr.Tag.ToString()) > 0)
                {
                  //  S_tr.ForeColor = Color.Yellow;
                    S_tr.NodeFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                }
                drR = dt_D.Select("xParent_ = " + S_tr.Tag);
                foreach (DataRow item in drR)
                {
                    TreeNode tr = new TreeNode(item["xName"].ToString()) { Name = "i" + cntnn.ToString() + item["xObject_"].ToString() };
                    tr.Tag = item["xObject_"].ToString();
                    S_tr.Nodes.Add(tr);
                    cntnn++;
                    Stack_tree.Push(tr);
                }
            }
       //     MessageBox.Show(cntnn.ToString());
           
           // gentree();
            treeView1.ExpandAll();
        }

        DAL.Object.DataSet_Object.mObjectDataTable dt_O;

        private void frmEditObjectGroup_Load(object sender, EventArgs e)
        {
            GenerateTree();
            BLL.Object.csObject cs = new BLL.Object.csObject();
            dt_O = cs.SlObject();
            dataGridView1.DataSource = dt_O;
            bindingSource1.DataSource = dt_O ;
          //  bindingNavigator1.BindingSource = bindingSource1;
            Generate();
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
             //   treeView1.ExpandAll();
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; 
                
            }
        }
        int tag_ = 0;
        private void btn_AddChild_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string yourChildNode;

                yourChildNode = textBox1.Text.Trim();
                TreeNode nd = new TreeNode(yourChildNode);
                nd.Tag = --tag_;
                treeView1.SelectedNode.Nodes.Add(nd);
            //    treeView1.ExpandAll();
            }
            this.ActiveControl = textBox1;

        }

        private void btn_AddRoot_Click(object sender, EventArgs e)
        {
            string yourParentNode;
            yourParentNode = textBox1.Text.Trim();
            TreeNode nd = new TreeNode(yourParentNode);
            nd.Tag = --tag_;
            treeView1.Nodes.Add(nd);
            this.ActiveControl = textBox1;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {

        }

        private void RemoveRecursive(TreeNode treeNode)
        {

            if (int.Parse(treeNode.Tag.ToString()) > 0)
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if ((int)item.Cells["x_"].Value == int.Parse( treeNode.Tag.ToString() ))
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

        // Call the procedure using the TreeView.
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
            DataRow dr  = dt_T.NewRow();
            dr["xObject_"] = treeNode.Tag;
            if(treeNode.Parent != null)
                dr["xParent_"] = treeNode.Parent.Tag;
            dr["xName"] = treeNode.Text;
            dt_T.Rows.Add(dr);
            foreach (TreeNode tn in treeNode.Nodes)
            {
                FillDataTableRecursive(tn);
            }
        }

        // Call the procedure using the TreeView.
        private void CallRecursiveTreeView(TreeView treeView)
        {
            // Print each node recursively.
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                FillDataTableRecursive(n);
            }
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.GetNodeCount(true) < 1)
                treeView1.SelectedNode.Remove();
            else
            {
                CallRecursive(treeView1.SelectedNode.Nodes);
                treeView1.SelectedNode.Remove();
            }

        }
        DAL.Object.DataSet_Object.mObjectTreeDataTable dt_T = new DAL.Object.DataSet_Object.mObjectTreeDataTable();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.Object.csObject cs = new BLL.Object.csObject();
                DAL.Object.DataSet_Object.mObjectTreeDataTable dt = new DAL.Object.DataSet_Object.mObjectTreeDataTable();

                CallRecursiveTreeView(treeView1);
                cs.UdObjectTree(dt_T);
                MessageBox.Show("ذخیره سازی با موفقیت انجام شد");
            }

           
        }
        bool expandtreeview = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (expandtreeview)
            {
                treeView1.ExpandAll();
                expandtreeview = false;
            }
            else
            {
                treeView1.CollapseAll();
                expandtreeview = true;

            }
        }

  
    }
}
