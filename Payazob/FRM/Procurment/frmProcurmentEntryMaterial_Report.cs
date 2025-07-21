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
    public partial class frmProcurmentEntryMaterial_Report : Form
    {
        public frmProcurmentEntryMaterial_Report()
        {
            InitializeComponent();
            generateForm();
            position = uc_cmbAutoMatrilal.Location.Y;

        }

        DataTable dt_PE = new DataTable("Procurment");

        private void generateForm()
        {
            BLL.csProcurement pr = new BLL.csProcurement();
            uc_cmbAutoMatrilal.DataSource = pr.SelectMaterial();
            uc_cmbAutoMatrilal.ValueMember = "x_";
            uc_cmbAutoMatrilal.DisplayMember = "xMaterialName";
            uc_cmbAutoMatrilal.SelectedIndex = -1;

            dt_PE.Columns.Add("x_", typeof(int));
            dt_PE.Columns.Add("xApprove_", typeof(int));
            dt_PE.Columns.Add("xDate", typeof(string));
            dt_PE.Columns.Add("xShift", typeof(string));
            dt_PE.Columns.Add("xMaterialType_", typeof(int));
            dt_PE.Columns.Add("xMaterialType", typeof(string));
            dt_PE.Columns.Add("xSupplier_", typeof(int));
            dt_PE.Columns.Add("xSupplier", typeof(string));
            dt_PE.Columns.Add("xDriverName", typeof(string));
            dt_PE.Columns.Add("xDriverTel", typeof(string));
            dt_PE.Columns.Add("xWeightBeginning", typeof(decimal));
            dt_PE.Columns.Add("xWeightDestination", typeof(decimal));
            dt_PE.Columns.Add("xModule", typeof(string));
            dt_PE.Columns.Add("xModule_", typeof(int));
            dt_PE.Columns.Add("xRent", typeof(int));
            dt_PE.Columns.Add("xComment", typeof(string));
            dt_PE.Columns.Add("Approve", typeof(string));
            
            bindingSource1.DataSource = dt_PE;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["xShift"].HeaderText = "شیفت";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["Approve"].HeaderText = "تاييد كننده";
            dataGridView1.Columns["xSupplier"].HeaderText = "تامین کننده";
            dataGridView1.Columns["xMaterialType"].HeaderText = "نوع مواد";
            dataGridView1.Columns["xDriverName"].HeaderText = "نام راننده";
            dataGridView1.Columns["xDriverTel"].HeaderText = "شماره راننده";
            dataGridView1.Columns["xWeightBeginning"].HeaderText = "وزن مبدا";
            dataGridView1.Columns["xModule"].HeaderText = "واحد";
            dataGridView1.Columns["xWeightDestination"].HeaderText = "وزن مقصد";
            dataGridView1.Columns["xRent"].HeaderText = "کرایه";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xModule_"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xMaterialType_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
            //dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            bindingNavigator1.BindingSource = bindingSource1;
        }

        private int position;

        private Stack<ControlLibrary.uc_cmbAuto> stack = new Stack<ControlLibrary.uc_cmbAuto>();

        private void btn_Show_Click(object sender, EventArgs e)
        {
            BLL.csProcurement cs = new BLL.csProcurement();

            string[] st = new string[stack.Count+1]; 
            st[0] = uc_cmbAutoMatrilal.Text;
            int count = stack.Count;
            for (int i = 1; i < count +1; i++)
			{
             ControlLibrary.uc_cmbAuto uc = stack.Pop();
			 st[i] =uc.Text;
             panel1.Controls.Remove(uc);
             position -= uc_cmbAutoMatrilal.Size.Height;
			}
            //RefreshForm();

                dt_PE.Clear();
                dt_PE = cs.SelectProcurmentEnteryMaterialByDateAndMaterial(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, st);
                dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            bindingSource1.DataSource = dt_PE;
            dataGridView1.DataSource = bindingSource1;

        }

        private void btn_and_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                ControlLibrary.uc_cmbAuto u = stack.Peek();
                position = uc_cmbAutoMatrilal.Size.Height + u.Location.Y;
            }
            else
                position = uc_cmbAutoMatrilal.Size.Height + uc_cmbAutoMatrilal.Location.Y;
                
            ControlLibrary.uc_cmbAuto cmb_Goods = new ControlLibrary.uc_cmbAuto();
            cmb_Goods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cmb_Goods.FormattingEnabled = true;
            cmb_Goods.LimitToList = true;
            cmb_Goods.Location = new System.Drawing.Point(uc_cmbAutoMatrilal.Location.X, position);
            cmb_Goods.Name = "cmb_Goods";
            cmb_Goods.Size = new System.Drawing.Size(112, 21);

            this.panel1.Controls.Add(cmb_Goods);

            BLL.csProcurement pr = new BLL.csProcurement();
            cmb_Goods.DataSource = pr.SelectMaterial();
            cmb_Goods.ValueMember = "x_";
            cmb_Goods.DisplayMember = "xMaterialName";
            cmb_Goods.SelectedIndex = -1;

            cmb_Goods.Focus();
            stack.Push(cmb_Goods);

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                panel1.Controls.Remove(stack.Pop());
                position -= uc_cmbAutoMatrilal.Size.Height;
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //crsProcurmentEnteryMaterial cr = new crsProcurmentEnteryMaterial();
            //cr.SetDataSource(dt_PE);
            //frmReport r = new frmReport();
            //r.GetReport = cr;
            //r.ShowDialog();

            Report.SendReport cs = new Report.SendReport();
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_PE, "crsProcurmentEnteryMaterial");
            r.ShowDialog();
            r.Dispose();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
