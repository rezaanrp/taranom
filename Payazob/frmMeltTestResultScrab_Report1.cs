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
    public partial class frmMeltTestResultScrab_Report1 : Form
    {
        public frmMeltTestResultScrab_Report1()
        {
            InitializeComponent();
            position = uc_cmbAuto_supplier.Location.Y;

            BLL.csCompony sup = new BLL.csCompony();
            uc_cmbAuto_supplier.DataSource = sup.SelectSupplier();
            uc_cmbAuto_supplier.DisplayMember = "xComponyName";
            uc_cmbAuto_supplier.ValueMember = "x_";
            uc_cmbAuto_supplier.SelectedIndex = -1;

        }
        DataTable dt_Me = new DataTable("Melt");

        private void generateForm()
        {
            //string xMaterialType, string xSupplier, string xDateEnter, string xDateTest, decimal xAbsorptionPercent, string Accept
            //xMaterialType,
            //            xSupplier,
            //            xDateEnter,
            //            xDateTest,
            //            xAbsorptionPercent,
            //            Accept

            BLL.csMeltTestResult cs = new BLL.csMeltTestResult();

            string[] st = new string[stack.Count + 1];
            st[0] = uc_cmbAuto_supplier.Text;
            int count = stack.Count;
            for (int i = 1; i < count + 1; i++)
            {
                ControlLibrary.uc_cmbAuto uc = stack.Pop();
                st[i] = uc.Text;
                panel1.Controls.Remove(uc);
                position -= uc_cmbAuto_supplier.Size.Height;
            }
            dt_Me.Clear();
            dt_Me = cs.SelectMeltTestResultScrabByDate(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, st, true, true, true);

            bindingSource1.DataSource = dt_Me;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xMaterialType"].HeaderText = "نوع مواد";
            dataGridView1.Columns["xSupplierCompany"].HeaderText = "تامین کننده";
            dataGridView1.Columns["xDateEnter"].HeaderText = "تاریخ ورود";
            dataGridView1.Columns["xDateTest"].HeaderText = "تاریخ آزمایش";
            dataGridView1.Columns["xDateResult"].HeaderText = "تاریخ نتایج";
            dataGridView1.Columns["xGradeProduct"].HeaderText = "درجه محصول";
            dataGridView1.Columns["SumScore"].HeaderText = "مجموع امتياز";
            dataGridView1.Columns["xSupplierby"].HeaderText = "تهیه شده توسط";
            dataGridView1.Columns["xApproveBy"].HeaderText = "تایید شده توسط";
            dataGridView1.Columns["xApprove"].HeaderText = "تایید شده";
            dataGridView1.Columns["Accept"].HeaderText = "وضعیت";
            dataGridView1.Columns["xVisualScore"].Visible = false;
            dataGridView1.Columns["xExperimentalScore"].Visible = false;
            dataGridView1.Columns["xMaximumScore"].Visible = false;
            dataGridView1.Columns["xUsageMeltingAmount"].Visible = false;
            dataGridView1.Columns["xSupplier"].Visible = false;
            dataGridView1.Columns["xUsage"].Visible = false;
            dataGridView1.Columns["xApprove"].ReadOnly = false;
            dataGridView1.Columns["xMaterialType"].ReadOnly = true;
            dataGridView1.Columns["xSupplierCompany"].ReadOnly = true;
            dataGridView1.Columns["xDateEnter"].ReadOnly = true;
            dataGridView1.Columns["xDateTest"].ReadOnly = true;
            dataGridView1.Columns["xSupplierby"].ReadOnly = true;
            dataGridView1.Columns["xApproveBy"].ReadOnly = true;
            dataGridView1.Columns["Accept"].ReadOnly = true;

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
            //crsMeltTestResultScrabFSuplierFDate cr = new crsMeltTestResultScrabFSuplierFDate();
            //cr.SetDataSource(dt_Me);
            //cr.SetParameterValue("DateFrom", uc_txtDateFrom.Text);
            //cr.SetParameterValue("DateTo", uc_txtDateTo.Text);
            //cr.SetParameterValue("DateNow", BLL.csshamsidate.shamsidate);
            //frmReport r = new frmReport();
            //r.GetReport = cr;
            //r.ShowDialog();


            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
            cs.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_Me, "crsMeltTestResultScrabFSuplierFDate");
            r.ShowDialog();
            r.Dispose();

        }
    }
}
