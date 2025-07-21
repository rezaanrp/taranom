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
    public partial class frmProcurmentSalesProduct_Report : Form
    {
        public frmProcurmentSalesProduct_Report()
        {
            InitializeComponent();
            generateForm();
            position = uc_cmbAutoPieces.Location.Y;
            positionCustomerCmb = uc_cmbAutoCustomer.Location.Y;
        }
        DataTable dt_PS = new DataTable("Procurment");
        private int position;
        private Stack<ControlLibrary.uc_cmbAuto> stack = new Stack<ControlLibrary.uc_cmbAuto>();
        private int positionCustomerCmb;

        private void generateForm()
        {
            BLL.csProcurement pr = new BLL.csProcurement();

            BLL.csPieces cp = new BLL.csPieces();

            uc_cmbAutoPieces.DataSource = cp.mPiecesDataTable();
            uc_cmbAutoPieces.DisplayMember = "xName";
            uc_cmbAutoPieces.ValueMember = "x_";
            uc_cmbAutoPieces.SelectedIndex = -1;

            BLL.csCompony cs = new BLL.csCompony();
            uc_cmbAutoCustomer.DataSource = cs.SelectCustomer();
            uc_cmbAutoCustomer.DisplayMember = "xComponyName";
            uc_cmbAutoCustomer.ValueMember = "x_";
            uc_cmbAutoCustomer.SelectedIndex = -1;

            dt_PS.Columns.Add("x_", typeof(int));
            dt_PS.Columns.Add("xShift", typeof(string));
            dt_PS.Columns.Add("xDate", typeof(string));
            dt_PS.Columns.Add("xDarftNumber", typeof(string));
            dt_PS.Columns.Add("xPieces_", typeof(int));
            dt_PS.Columns.Add("xPieces", typeof(string));
            dt_PS.Columns.Add("xPackingType", typeof(string));
            dt_PS.Columns.Add("xCount", typeof(int));
            dt_PS.Columns.Add("xWeight", typeof(int));
            dt_PS.Columns.Add("xDriverName", typeof(string));
            dt_PS.Columns.Add("xDriverTel", typeof(string));
            dt_PS.Columns.Add("xlicenseCar", typeof(string));
            dt_PS.Columns.Add("xCustomer_", typeof(int));
            dt_PS.Columns.Add("xCustomer", typeof(string));
            dt_PS.Columns.Add("xComment", typeof(string));
            dt_PS.Columns.Add("xSupplier_", typeof(int));
            dt_PS.Columns.Add("xRent", typeof(int));


            bindingSource1.DataSource = dt_PS;
            dataGridView1.DataSource = bindingSource1;

            //string xDarftNumber, int xPieces_, string xPackingType, int xCount, int xWeight, string xDriverName, string xDriverTel, string xlicenseCar, int xCustomer_,
            //string xComment
            dataGridView1.Columns["xShift"].HeaderText = "شیفت";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xDarftNumber"].HeaderText = "شماره حواله";
            dataGridView1.Columns["xPieces"].HeaderText = "نوع محصول";
            dataGridView1.Columns["xPackingType"].HeaderText = "نوع بسته بندی";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xWeight"].HeaderText = "وزن";
            dataGridView1.Columns["xDriverName"].HeaderText = "نام راننده";
            dataGridView1.Columns["xDriverTel"].HeaderText = "تلفن";
            dataGridView1.Columns["xlicenseCar"].HeaderText = "شماره پلاک";
            dataGridView1.Columns["xRent"].HeaderText = "کرایه";
            dataGridView1.Columns["xCustomer"].HeaderText = "تحویل گیرنده";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xPieces_"].Visible = false;
            dataGridView1.Columns["xCustomer_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            //dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csProcurement cs = new BLL.csProcurement();

            string[] st = new string[stack.Count + 1];
            string[] stC = new string[stackCustomer.Count + 1];
            if (chb_Goods.Checked)
            {
                st[0] = uc_cmbAutoPieces.Text;
                int count = stack.Count;
                for (int i = 1; i < count + 1; i++)
                {
                    ControlLibrary.uc_cmbAuto uc = stack.Pop();
                    st[i] = uc.Text;
                    panel1.Controls.Remove(uc);
                    position -= uc_cmbAutoPieces.Size.Height;
                }
            }
            if (chb_Customer.Checked)
            {
                stC[0] = uc_cmbAutoCustomer.Text;
                int countC = stackCustomer.Count;
                for (int i = 1; i < countC + 1; i++)
                {
                    ControlLibrary.uc_cmbAuto uc = stackCustomer.Pop();
                    stC[i] = uc.Text;
                    panel2.Controls.Remove(uc);
                    positionCustomerCmb -= uc_cmbAutoCustomer.Size.Height;
                }
            }
            //RefreshForm();
            //if (dt_PS != null)
            //{
                dt_PS.Rows.Clear();
                dt_PS = cs.SelectProcurmentSalesProductByDateAndPieces(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, st, stC);
              //  dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ////}
            bindingSource1.DataSource = dt_PS;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Columns["xCustomer"].DisplayIndex = 4;
            dataGridView1.Columns["xPieces"].DisplayIndex= 5;

        }

        private void btn_and_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                ControlLibrary.uc_cmbAuto u = stack.Peek();
                position = uc_cmbAutoPieces.Size.Height + u.Location.Y;
            }
            else
                position = uc_cmbAutoPieces.Size.Height + uc_cmbAutoPieces.Location.Y;

            ControlLibrary.uc_cmbAuto cmb_Goods = new ControlLibrary.uc_cmbAuto();
            cmb_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cmb_Goods.FormattingEnabled = true;
            cmb_Goods.LimitToList = true;
            cmb_Goods.Location = new System.Drawing.Point(uc_cmbAutoPieces.Location.X, position);
            cmb_Goods.Name = "cmb_Goods";
            cmb_Goods.Size = new System.Drawing.Size(112, 21);

            this.panel1.Controls.Add(cmb_Goods);
            BLL.csPieces cp = new BLL.csPieces();

            cmb_Goods.DataSource = cp.mPiecesDataTable();
            cmb_Goods.DisplayMember = "xName";
            cmb_Goods.ValueMember = "x_";
            cmb_Goods.SelectedIndex = -1;
            cmb_Goods.Focus();
            stack.Push(cmb_Goods);

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                panel1.Controls.Remove(stack.Pop());
                position -= uc_cmbAutoPieces.Size.Height;
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //crsProcurmentSalesProduct cr = new crsProcurmentSalesProduct();
            //cr.SetDataSource(dt_PS);
            //frmReport r = new frmReport();
            //r.GetReport = cr;
            //r.ShowDialog();

            Report.SendReport cs = new Report.SendReport();
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_PS, "crsProcurmentSalesProduct");
            r.ShowDialog();
            r.Dispose();

        }
        private Stack<ControlLibrary.uc_cmbAuto> stackCustomer = new Stack<ControlLibrary.uc_cmbAuto>();

        private void btn_AddCustomr_Click(object sender, EventArgs e)
        {
            if (stackCustomer.Count > 0)
            {
                ControlLibrary.uc_cmbAuto u = stackCustomer.Peek();
                positionCustomerCmb = uc_cmbAutoPieces.Size.Height + u.Location.Y;
            }
            else
                positionCustomerCmb = uc_cmbAutoCustomer.Size.Height + uc_cmbAutoCustomer.Location.Y;

            ControlLibrary.uc_cmbAuto cmb_Auto = new ControlLibrary.uc_cmbAuto();
            cmb_Auto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cmb_Auto.FormattingEnabled = true;
            cmb_Auto.LimitToList = true;
            cmb_Auto.Location = new System.Drawing.Point(uc_cmbAutoCustomer.Location.X, positionCustomerCmb);
            cmb_Auto.Name = "cmb_Goods";
            cmb_Auto.Size = new System.Drawing.Size(112, 21);
            BLL.csCompony cs = new BLL.csCompony();
            this.panel2.Controls.Add(cmb_Auto);
            cmb_Auto.DataSource = cs.SelectCustomer();
            cmb_Auto.DisplayMember = "xComponyName";
            cmb_Auto.ValueMember = "x_";
            cmb_Auto.SelectedIndex = -1;
            cmb_Auto.Focus();
            stackCustomer.Push(cmb_Auto);

        }

        private void btn_DelCustomer_Click(object sender, EventArgs e)
        {
            if (stackCustomer.Count > 0)
            {
                panel2.Controls.Remove(stackCustomer.Pop());
                positionCustomerCmb -= uc_cmbAutoCustomer.Size.Height;
            }
        }

        private void chb_Goods_CheckedChanged(object sender, EventArgs e)
        {

            if (((System.Windows.Forms.CheckBox)(sender)).Name == "chb_Goods")
                groupBox2.Enabled = ((System.Windows.Forms.CheckBox)(sender)).Checked;
            else if (((System.Windows.Forms.CheckBox)(sender)).Name == "chb_Customer")
                groupBox3.Enabled = ((System.Windows.Forms.CheckBox)(sender)).Checked;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
