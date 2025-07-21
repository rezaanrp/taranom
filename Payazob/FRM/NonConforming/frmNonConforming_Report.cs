using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.NonConforming
{
    public partial class frmNonConforming_Report : Form
    {
        public frmNonConforming_Report()
        {
            InitializeComponent();
            formFunctionPointer += new functioncall(Replicate);
            uc_ListFiled1.userFunctionPointer = formFunctionPointer;
        }

        System.Data.DataTable dt_D;
        System.Data.DataTable dt_T;
      //  DAL.NonConforming.DataSet_NonConforming.SlNonconformingRpDataTable dt_D;
        public delegate void functioncall(string message);

        private event functioncall formFunctionPointer;

        private void Replicate(string message)
        {
            this.uc_ListFiled1.Visible = false;
            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            cs.SetParam("DateNow", uc_Filter_Date1.DateTo);

            frmReport r = new frmReport();
 
            if (message == "گزارش عدم تطابق")
                r.GetReport = cs.GetReport(dt_T, "crsNonConforming");
            else
            {
                if (tn == null || tn.Tag.ToString() == "-1")
                {
                    cs.SetParam("Pieces", "تمام قطعات");
                    r.GetReport = cs.GetReport(new BLL.Nonconforming.csNonconforming().SlNonconformingParentCountRp(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo,-1), "crsNonConformingParato");

                }
                else
                {
                    cs.SetParam("Pieces", tn.Text);
                    r.GetReport = cs.GetReport(new BLL.Nonconforming.csNonconforming().SlNonconformingParentCountRp(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, int.Parse(treeView1.SelectedNode.Tag.ToString())), "crsNonConformingParato");
                }
            }
            r.ShowDialog();
            r.Dispose();
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {

            FRM.NonConforming.frmNonConformingType frm = new FRM.NonConforming.frmNonConformingType();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            dt_D = new BLL.Nonconforming.csNonconforming().SlNonconformingTypeRp(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, frm.ChildNode);


            ///////////////////xPieces_
            System.Data.DataTable dt = dt_D.DefaultView.ToTable(true, "xPieces_", "Pieces");
            treeView1.Nodes.Clear();
            TreeNode trn = new TreeNode("نام قطعه");
            trn.Tag = "-1";
            foreach (DataRow item in dt.Rows)
            {
                TreeNode tr = new TreeNode(item["Pieces"].ToString());
                tr.Tag = item["xPieces_"].ToString();
                trn.Nodes.Add(tr);
            }
            treeView1.Nodes.Add(trn);
//            bindingSource1.DataSource = dt_A;
//            dataGridView1.DataSource = bindingSource1;
//            bindingNavigator1.BindingSource = bindingSource1;
//            generate();

            //////////////////////////////
            
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            Generate();
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_D.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["xNonConformingType"].HeaderText = "نام عدم انطباق";
        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            uc_ListFiled1.Location = new Point(dataGridView1.Location.X + dataGridView1.Size.Width - 470 ,dataGridView1.Location.Y  + dataGridView1.Size.Height - 100);
            uc_ListFiled1.Visible = true;
            DataTable dt = new DataTable();
            dt.Columns.Add("State", typeof(string));
            dt.Columns.Add("Value", typeof(int));

            DataRow dr = dt.NewRow();
            dr["State"] = "گزارش عدم تطابق";
            dr["Value"] = 1;
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["State"] = "گزارش پاراتو عدم تطابق";
            dr1["Value"] = 2;
            dt.Rows.Add(dr1);
            uc_ListFiled1.BringToFront();

            //`uc_ListFiled1.Location = bindingNavigator1.DisplayRectangle.;

            uc_ListFiled1.ValueMemmbers = "Value";
            uc_ListFiled1.DisplayMemmbers = "State";
            uc_ListFiled1.Generate(dt);

            uc_ListFiled1.Focus();
            
            
            //Report.SendReport cs = new Report.SendReport();
            //cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            //frmReport r = new frmReport();
            //r.GetReport = cs.GetReport(dt_D, "crsNonConforming");
            //r.ShowDialog();
            //r.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
        TreeNode tn;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tn = e.Node;
            DataRow[] dr;
            if (e.Node.Tag.ToString() == "-1")
                dr = dt_D.Select();
            else
                dr = dt_D.Select("xPieces_ = " + e.Node.Tag.ToString());
            if (dr.Length > 0)
            {
                dt_T = dr.CopyToDataTable();
                bindingSource1.DataSource = dt_T;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
            }
        }

        private void uc_ListFiled1_Leave(object sender, EventArgs e)
        {
            uc_ListFiled1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  label1.Text = printToolStripButton.

        }

        private void frmNonConforming_Report_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void frmNonConforming_Report_Resize(object sender, EventArgs e)
        {
            uc_ListFiled1.Visible = false;
        }
    }
}
