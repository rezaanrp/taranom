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
    public partial class frmProcurementGoodsOut_Report : Form
    {
        public frmProcurementGoodsOut_Report()
        {
            InitializeComponent();
            generateForm();

            BLL.csProcurement pr = new BLL.csProcurement();
            uc_cmbAutoGoodsName.DataSource = pr.SelectProcurementGoodsNameOut();
            uc_cmbAutoGoodsName.ValueMember = "xGoods";
            uc_cmbAutoGoodsName.DisplayMember = "xGoods";
            uc_cmbAutoGoodsName.SelectedIndex = -1;
            position = uc_cmbAutoGoodsName.Location.Y;
        }
        DataTable dt_P = new DataTable("Procurment");

        private void generateForm()
        {
            //x_, xApprove_, xShift, xDate, xGoods, xCount, xModule_, xPersonNameGoodsOut, xCarNumber, xLicensorsName, xComment xLicenseNumber

         
            dt_P.Columns.Add("xShift", typeof(string));
            dt_P.Columns.Add("xDate", typeof(string));
            dt_P.Columns.Add("xGoods", typeof(string));
            dt_P.Columns.Add("xCount", typeof(decimal));
            dt_P.Columns.Add("xModule_", typeof(int));
            dt_P.Columns.Add("xModule", typeof(string));
            dt_P.Columns.Add("xPersonNameGoodsOut", typeof(string));
            dt_P.Columns.Add("xCarNumber", typeof(string));
            dt_P.Columns.Add("xLicensorsName", typeof(string));
            dt_P.Columns.Add("xLicenseNumber", typeof(string));
            dt_P.Columns.Add("xComment", typeof(string));
            dt_P.Columns.Add("xApprove_", typeof(int));
            dt_P.Columns.Add("x_", typeof(int));

            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["xShift"].HeaderText = "شیفت";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xGoods"].HeaderText = "نام جنس";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xModule"].HeaderText = "واحد";
            dataGridView1.Columns["xCarNumber"].HeaderText = "شماره ماشین";
            dataGridView1.Columns["xLicensorsName"].HeaderText = "نام مجوزدهنده";
            dataGridView1.Columns["xLicenseNumber"].HeaderText = "شماره مجوز";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xPersonNameGoodsOut"].HeaderText = "نام خارج کننده مواد";
            dataGridView1.Columns["xModule_"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            bindingNavigator1.BindingSource = bindingSource1;
        }




        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private int position;
        private Stack<ControlLibrary.uc_cmbAuto> stack = new Stack<ControlLibrary.uc_cmbAuto>();

        private void button1_Click(object sender, EventArgs e)
        {

            if (stack.Count > 0)
            {
                ControlLibrary.uc_cmbAuto u = stack.Peek();
                position = uc_cmbAutoGoodsName.Size.Height + u.Location.Y;
            }
            else
                position = uc_cmbAutoGoodsName.Size.Height + position;
               
            ControlLibrary.uc_cmbAuto cmb_Goods = new ControlLibrary.uc_cmbAuto();
            cmb_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cmb_Goods.FormattingEnabled = true;
            cmb_Goods.LimitToList = true;
            cmb_Goods.Location = new System.Drawing.Point(uc_cmbAutoGoodsName.Location.X, position);
            cmb_Goods.Name = "cmb_Goods";
            cmb_Goods.Size = new System.Drawing.Size(112, 21);
            cmb_Goods.TabIndex = 69;

            this.panel1.Controls.Add(cmb_Goods);

            BLL.csProcurement pr = new BLL.csProcurement();
            cmb_Goods.DataSource = pr.SelectProcurementGoodsNameOut();
            cmb_Goods.ValueMember = "xGoods";
            cmb_Goods.DisplayMember = "xGoods";
            cmb_Goods.SelectedIndex = -1;
            cmb_Goods.Focus();
            stack.Push(cmb_Goods);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                panel1.Controls.Remove(stack.Pop());
                position -= uc_cmbAutoGoodsName.Size.Height;
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csProcurement cs = new BLL.csProcurement();
            string st = uc_cmbAutoGoodsName.Text;
            while (stack.Count > 0)
            {
                ControlLibrary.uc_cmbAuto uc = stack.Pop();
                st += "("+ uc.Text + ")";
                panel1.Controls.Remove(uc);
                position -= uc_cmbAutoGoodsName.Size.Height;
            }
            //RefreshForm();
            if (dt_P != null)
            {
                dt_P.Clear();
                dt_P = cs.SelectProcurmentGoodsOutByDate(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, st);
                dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //crsProcurmentGoodsOut cr = new crsProcurmentGoodsOut();
            //cr.SetDataSource(dt_P);
            //frmReport r = new frmReport();
            //r.GetReport = cr;
            //r.ShowDialog();
            Report.SendReport cs = new Report.SendReport();
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_P, "crsProcurmentGoodsOut");
            r.ShowDialog();
            r.Dispose();

        }




    }
}
