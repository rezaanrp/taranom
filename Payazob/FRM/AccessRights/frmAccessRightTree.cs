using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.AccessRights
{
    public partial class frmAccessRightTree : Form
    {
        public frmAccessRightTree()
        {
            InitializeComponent();
            new BLL.authentication().DlAuthenticationDeActive();

            DataGridViewComboBoxColumn combobox_xSupplier2_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xUser_",
                Name = "xUser_",
                Width = 200,
                // ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSupplier2_);

            ShowData(-1);
        }

        DAL.DataSet_Authentication.mAuthenticationByObjectDataTable dt_R;
        void ShowData(int Object_)
        {
            dt_R = new BLL.authentication().mAuthenticationByObject(Object_);
            bindingSource1.DataSource = dt_R;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_R.xObject_Column.DefaultValue = Object_;
            dt_R.xDeleteColumn.DefaultValue = true;
            dt_R.xInsertColumn.DefaultValue = true;
            dt_R.xUpdateColumn.DefaultValue = true;
            Generate();
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_R.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xObject_"].Visible = false;
            dataGridView1.Columns["xGroup_"].Visible = false;

            dataGridView1.Columns["xDelete"].Visible = false;
            dataGridView1.Columns["xInsert"].Visible = false;
            dataGridView1.Columns["xUpdate"].Visible = false;

        }

        Stack<TreeNode> Stack_tree = new Stack<TreeNode>();

        void GenerateTree()
        {
            //int cntnn = 0;
            //treeView1.Nodes.Clear();
            ////TreeNode trn = new TreeNode("");
            //// trn.Tag = "-2";
            //BLL.Object.csObject cs = new BLL.Object.csObject();

            //DataTable dt_D = cs.SlObjectTree();
            //if (dt_D.Rows.Count < 1)
            //{
            //    return;
            //}
            //if (dt_D.Compute("min(xParent_)", string.Empty) == DBNull.Value)
            //    --tag_;
            //else
            //    tag_ = Convert.ToInt32(dt_D.Compute("min(xParent_)", string.Empty));
            //DataRow[] drR = dt_D.Select("xParent_ IS NULL");
            //foreach (DataRow item in drR)
            //{
            //    TreeNode tr = new TreeNode(item["xName"].ToString());
            //    tr.Tag = item["xObject_"].ToString();
            //    treeView1.Nodes.Add(tr);
            //    Stack_tree.Push(tr);
            //}
            //while (Stack_tree.Count != 0)
            //{
            //    TreeNode S_tr = Stack_tree.Pop();
            //    if (int.Parse(S_tr.Tag.ToString()) > 0)
            //    {
            //        //  S_tr.ForeColor = Color.Yellow;
            //        S_tr.NodeFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //    }
            //    drR = dt_D.Select("xParent_ = " + S_tr.Tag);
            //    foreach (DataRow item in drR)
            //    {
            //        TreeNode tr = new TreeNode(item["xName"].ToString()) { Name = "i" + cntnn.ToString() + item["xObject_"].ToString() };
            //        tr.Tag = item["xObject_"].ToString();
            //        S_tr.Nodes.Add(tr);
            //        cntnn++;
            //        Stack_tree.Push(tr);
            //    }
            //}
            ////     MessageBox.Show(cntnn.ToString());

            //// gentree();
            //treeView1.ExpandAll();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        int tag_ = 0;



        private void btn_Del_Click(object sender, EventArgs e)
        {


        }
        DAL.Object.DataSet_Object.mObjectTreeDataTable dt_T = new DAL.Object.DataSet_Object.mObjectTreeDataTable();
        private void btn_Save_Click(object sender, EventArgs e)
        {



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

        private void frmAccessRightTree_Load(object sender, EventArgs e)
        {
            GenerateTree();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int obj_ = -1;
            int.TryParse(e.Node.Tag.ToString(), out obj_);
            ShowData(obj_);
        }
        void SaveData()
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
                MessageBox.Show(new BLL.authentication().UdAuthenticationByObject(dt_R), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int obj_ = -1;
            int.TryParse(treeView1.SelectedNode.Tag.ToString(), out obj_);
            ShowData(obj_);


        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            SaveData();
        }
    }
}
