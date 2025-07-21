using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.MaterialLocation
{
    public partial class frmMaterilLocation : Form
    {
        public frmMaterilLocation()
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
            BLL.MaterialLocation.csMatarialLocation cs = new BLL.MaterialLocation.csMatarialLocation();

            DataTable dt_D = cs.mMaterialLocation();
         //   tag_ = Convert.ToInt32(dt_D.Compute("min(xParentId_)", string.Empty));
            DataRow[] drR = dt_D.Select("xParentId_ IS NULL");
            foreach (DataRow item in drR)
            {
                TreeNode tr = new TreeNode(  item["xCode"].ToString() + " " +item["xName"].ToString() + "   ") ;
                tr.Tag = item["x_"].ToString() + "$" + item["xCode"].ToString(); 
                treeView1.Nodes.Add(tr);
                Stack_tree.Push(tr);
            }
            while (Stack_tree.Count != 0)
            {
                TreeNode S_tr = Stack_tree.Pop();
                if (int.Parse(S_tr.Tag.ToString().Split('$')[0]) > 0)
                {
                    //  S_tr.ForeColor = Color.Yellow;
                    S_tr.NodeFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                drR = dt_D.Select("xParentId_ = " + S_tr.Tag.ToString().Split('$')[0]);
                foreach (DataRow item in drR)
                {
                    TreeNode tr = new TreeNode(item["xCode"].ToString()+" " + item["xName"].ToString() + "   ") { Name = "i" + item["x_"].ToString() };
                    tr.Tag = item["x_"].ToString() + "$" + item["xCode"].ToString(); 
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
                ShowMatrial();
        }

        void ShowMatrial()
        {
            BLL.csMaterial cs = new BLL.csMaterial();
            dt_O = cs.mMaterialForLocation();
            dataGridView1.DataSource = dt_O;
            bindingSource1.DataSource = dt_O;
            Generate();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            string ColumnFilter = "xMaterialName";
            
            if (dt_O.Select(ColumnFilter + " like  '%" + uc_txtBox_Filter.Text + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ی', 'ي') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ي', 'ی') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ک', 'ك') + "%'" + "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ك', 'ک') + "%'").Length > 0)
             dataGridView1.DataSource =  dt_O.Select(ColumnFilter + " like  '%" + uc_txtBox_Filter.Text + "%'" + 
                 "Or " + ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ی', 'ي') + "%'" + "Or " + 
                 ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ي', 'ی') + "%'" + "Or " + 
                 ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ک', 'ك') + "%'" + "Or " + 
                 ColumnFilter + " like  '%" + uc_txtBox_Filter.Text.Replace('ك', 'ک') + "%'").CopyToDataTable() ;
            bindingSource1.DataSource = dt_O;
           
        }

        private void btn_filterBack_Click(object sender, EventArgs e)
        {
            ShowMatrial();
        }

        private void btn_AddRoot_Click_1(object sender, EventArgs e)
        {
            string yourParentNode;
            yourParentNode = textBox1.Text.Trim();
            TreeNode nd = new TreeNode(yourParentNode);
            int max = 0;
            string tg = "";
            foreach (TreeNode item in treeView1.Nodes)
            {
                if( int.Parse( item.Tag.ToString().Split('$')[1] )> max)
                {
                    max = int.Parse(item.Tag.ToString().Split('$')[1]);
                }
            }
            if (max < 10)
                tg = "00" + max.ToString();
            else if (max > 9 && max < 100)
                tg = "0" + max.ToString();
            else
                tg = max.ToString();

            nd.Tag = --tag_ + '$' + tg;
            treeView1.Nodes.Add(nd);
            this.ActiveControl = textBox1;
        }

        private void btn_AddChild_Click_1(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                FRM.MaterialLocation.frmMaterialOfLocation_D f = new frmMaterialOfLocation_D();
                f.ShowDialog();
                if (!f.flagCancel)
                {
                    DAL.MaterialLocation.DataSet_MaterialLocation.mMaterialLocationRow dr = dt_M.NewmMaterialLocationRow();
                    dr.xActive = true;
                    dr.xCode = "";
                    dr.xDateMade = f.uc_TextBoxDateMade.Text;
                    dr.xDateStart = f.uc_TextBoxDateStart.Text;
                    dr.xGenAutomationLevel_ = (int)f.comboBoxlevel.SelectedValue;
                    dr.xGenPriority_ = (int)f.comboBox_pirority.SelectedValue;
                    dr.xGenTypeSell_ = (int)f.comboBox_TypeSell.SelectedValue;
                    dr.xLifeTime = int.Parse( f.uc_txtBoxLifeTime.textWithoutcomma);
                    dr.xLocation = int.Parse( f.uc_txtBox_xLocation.Text );
                    dr.xModel = f.uc_txtBox_Model.Text;
                    dr.xName = f.uc_txtBox_Name.Text;
                    dr.xPeriodService = (int)f.comboBoxperiod.SelectedValue;
                    dr.xSerialNumber = f.uc_txtBox_Serial.Text;
                    dr.xSupplier_ = BLL.authentication.x_;
                    ///////////////////////////////////////////////////
                    string yourChildNode;
                    yourChildNode = textBox1.Text.Trim();
                    TreeNode nd = new TreeNode(yourChildNode);
                    nd.Tag = --tag_;
                    treeView1.SelectedNode.Nodes.Add(nd);
                }
            }
            this.ActiveControl = textBox1;
        }

        private void btn_Del_Click_1(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.GetNodeCount(true) < 1)
                treeView1.SelectedNode.Remove();
            else
            {
                CallRecursive(treeView1.SelectedNode.Nodes);
                treeView1.SelectedNode.Remove();
            }

        }

        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                //BLL.Object.csObject cs = new BLL.Object.csObject();
                //DAL.Object.DataSet_Object.mObjectTreeDataTable dt = new DAL.Object.DataSet_Object.mObjectTreeDataTable();

                //CallRecursiveTreeView(treeView1);
                //cs.UdObjectTree(dt_T);
                //MessageBox.Show("ذخیره سازی با موفقیت انجام شد");
            }
        }

      
    }
}
