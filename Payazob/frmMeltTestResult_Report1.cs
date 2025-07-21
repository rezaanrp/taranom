using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmMeltTestResult_Report1 : Form
    {
        public frmMeltTestResult_Report1()
        {
            InitializeComponent();


        }
        DataTable dt_Me = new DataTable("Melt");

        private void generateForm()
        {


                        //    xSupplierCompany,
                        //CoutAccept,
                        //Accept,
                        //MonthEnter,
                        //NameMonth

            dataGridView1.Columns["xSupplierCompany"].HeaderText = "شرکت";
            dataGridView1.Columns["CoutAccept"].HeaderText = "تعداد";
            dataGridView1.Columns["Accept"].HeaderText = "وضعیت";
            if (treeView1.SelectedNode.Tag.ToString() == "2" || treeView1.SelectedNode.Tag.ToString() == "4")
            {
                dataGridView1.Columns["MonthEnter"].Visible = false;
                dataGridView1.Columns["NameMonth"].HeaderText = "ماه";
            }
        }

        private int position;

        private Stack<ControlLibrary.uc_cmbAuto> stack = new Stack<ControlLibrary.uc_cmbAuto>();

        private void btn_Show_Click(object sender, EventArgs e)
        {
            generateForm();            
        }

        private void btn_AddCustomr_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                ControlLibrary.uc_cmbAuto u = stack.Peek();
                position = uc_cmbAuto_supplier.Size.Height + u.Location.Y;
            }
            else
                position = uc_cmbAuto_supplier.Size.Height + uc_cmbAuto_supplier.Location.Y;

            ControlLibrary.uc_cmbAuto cmb_Goods = new ControlLibrary.uc_cmbAuto();
            cmb_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cmb_Goods.FormattingEnabled = true;
            cmb_Goods.LimitToList = true;
            cmb_Goods.Location = new System.Drawing.Point(uc_cmbAuto_supplier.Location.X, position);
            cmb_Goods.Name = "cmb_Goods";
            cmb_Goods.Size = new System.Drawing.Size(112, 21);

            this.panel1.Controls.Add(cmb_Goods);

            BLL.csCompony meln = new BLL.csCompony();

            cmb_Goods.DataSource = meln.SelectSupplier();
            cmb_Goods.DisplayMember = "xComponyName";
            cmb_Goods.ValueMember = "x_";
            cmb_Goods.SelectedIndex = -1;



            cmb_Goods.Focus();
            stack.Push(cmb_Goods);

        }

        private void btn_DelCustomer_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                panel1.Controls.Remove(stack.Pop());
                position -= uc_cmbAuto_supplier.Size.Height;
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode.Tag == null)
                return;
            if (treeView1.SelectedNode.Tag.ToString() == "1")
            {

                Report.SendReport cs = new Report.SendReport();
                cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
                cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
                cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(dt_Me, "crsMeltAdditiveTestResultStComany");
                r.ShowDialog();
                r.Dispose();

            }
            else if (treeView1.SelectedNode.Tag.ToString() == "3")
            {
                Report.SendReport cs = new Report.SendReport();
                cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
                cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
                cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(dt_Me, "crsMeltAdditiveTestResultStComany");
                r.ShowDialog();
                r.Dispose();

            }
            else if (treeView1.SelectedNode.Tag.ToString() == "2")
            {
                Report.SendReport cs = new Report.SendReport();
                cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
                cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
                cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(dt_Me, "crsMeltAdditiveTestResultStCoMonth");
                r.ShowDialog();
                r.Dispose();

            }
            else if (treeView1.SelectedNode.Tag.ToString() == "4")
            {
                Report.SendReport cs = new Report.SendReport();
                cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
                cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
                cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                frmReport r = new frmReport();
                r.GetReport = cs.GetReport(dt_Me, "crsMeltAdditiveTestResultStComany");
                r.ShowDialog();
                r.Dispose();

            }

        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {


            if (treeView1.SelectedNode.Tag == null)
                return;
            if (treeView1.SelectedNode.Tag.ToString() == "1")
            {
                BLL.MeltAdditiveTestResult.csMeltAdditiveTestResultStComany cs = new BLL.MeltAdditiveTestResult.csMeltAdditiveTestResultStComany();
                dt_Me = cs.SlMeltAdditiveTestResultStCu(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, true);
                uc_Filter_Date1.Visible = true;
                panel2.Visible = false;
                bindingSource1.DataSource = dt_Me;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                generateForm();

            }
            if (treeView1.SelectedNode.Tag.ToString() == "3")
            {
                BLL.MeltAdditiveTestResult.csMeltAdditiveTestResultStComany cs = new BLL.MeltAdditiveTestResult.csMeltAdditiveTestResultStComany();
                dt_Me = cs.SlMeltAdditiveTestResultStCu(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, false);
                uc_Filter_Date1.Visible = true;
                panel2.Visible = false;
                bindingSource1.DataSource = dt_Me;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                generateForm();
            }
            if (treeView1.SelectedNode.Tag.ToString() == "2")
            {
                BLL.MeltAdditiveTestResult.csMeltAdditiveTestResultStComany cs = new BLL.MeltAdditiveTestResult.csMeltAdditiveTestResultStComany();
                dt_Me = cs.SlMeltAdditiveTestResultStCoMonth(Nud_Year.Value.ToString(), true);
                uc_Filter_Date1.Visible = false;
                panel2.Visible = true;
                bindingSource1.DataSource = dt_Me;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                generateForm();

            }
            if (treeView1.SelectedNode.Tag.ToString() == "4")
            {
                BLL.MeltAdditiveTestResult.csMeltAdditiveTestResultStComany cs = new BLL.MeltAdditiveTestResult.csMeltAdditiveTestResultStComany();
                dt_Me = cs.SlMeltAdditiveTestResultStCoMonth(Nud_Year.Value.ToString(), false);
                uc_Filter_Date1.Visible = false;
                panel2.Visible = true;
                bindingSource1.DataSource = dt_Me;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                generateForm();

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
 
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
 
        }
    }
}
