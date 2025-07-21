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
    public partial class frmMeltTestResultScrab : Form
    {
        public frmMeltTestResultScrab()
        {
            InitializeComponent();
        }
        private DataTable dt_Melt = new DataTable("Melt");

        private void btn_Show_Click(object sender, EventArgs e)
        {
            fillDatagridView();
        }
        private void fillDatagridView()
        {
            bool ap_flag = rdb_approve.Checked;
            dataGridView1.Columns.Clear();

            bindingSource1.DataSource = dt_Melt;
            BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.DataSource = cs.SelectMeltTestResultScrabByDate(uc_txtDateFrom.Text, uc_txtDateTo.Text, true, ap_flag, rdb_all.Checked);
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
            dataGridView1.Columns["xUsage"].Visible= false;
            dataGridView1.Columns["xApprove"].ReadOnly = false;
            dataGridView1.Columns["xMaterialType"].ReadOnly = true;
            dataGridView1.Columns["xSupplierCompany"].ReadOnly = true;
            dataGridView1.Columns["xDateEnter"].ReadOnly = true;
            dataGridView1.Columns["xDateTest"].ReadOnly = true;
            dataGridView1.Columns["xSupplierby"].ReadOnly = true;
            dataGridView1.Columns["xApproveBy"].ReadOnly = true;
            dataGridView1.Columns["Accept"].ReadOnly = true;

            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();

            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "نمایش جزئیات";
            buttonColumn.Text = "جزئیات";
            buttonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Insert(10, buttonColumn);

        }
        

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count < 1)
            //    return;
            //crsMeltTestResultScrab cr = new crsMeltTestResultScrab();
            //BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
            //cr.SetDataSource(cs.SelectMeltTestResultScrabByDate(uc_txtDateFrom.Text, uc_txtDateTo.Text, true, rdb_approve.Checked, rdb_all.Checked));
            //cr.SetParameterValue("DateFrom", uc_txtDateFrom.Text);
            //cr.SetParameterValue("DateTo", uc_txtDateTo.Text);
            //cr.SetParameterValue("DateNow", BLL.csshamsidate.shamsidate);
            //frmReport r = new frmReport();
            //r.GetReport = cr;
            //r.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ایا می خواهید این اطلاعات ذخیره شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int[] ro = new int[dataGridView1.Rows.Count];
                bool?[] ap = new bool?[dataGridView1.Rows.Count];
                int i = 0;
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    ro[i] = (int)item.Cells["x_"].Value;
                    if (item.Cells["xApprove"].Value == DBNull.Value)
                        ap[i++] = null;
                    else
                        ap[i++] = (bool)item.Cells["xApprove"].Value;
                }

                BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
                cs.UpdateCharacteristicScarbPurchaseApprove(ap, ro);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((System.Windows.Forms.DataGridView)(sender)).Columns[e.ColumnIndex].Name == "Details")
            {
                BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
                ControlLibrary.uc_GridView ug = new ControlLibrary.uc_GridView();
                ug.bindingSource1.DataSource = cs.SelectMeltTestRSelectAnalysisMaterialByCharacteristicMaterialPurchaseByAfterAddTableAdapteresult((int)dataGridView1["x_", this.dataGridView1.CurrentCell.RowIndex].Value);
                ug.dataGridView1.Columns["ElementName"].HeaderText = "نام عنصر";
                ug.dataGridView1.Columns["xAmount"].HeaderText = "مقدار";
                ug.dataGridView1.Columns["Status"].HeaderText = "وضعیت";
                ug.dataGridView1.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                ug.dataGridView1.Columns["x_"].Visible = false;
                ControlLibrary.uc_PanelBox pb = new ControlLibrary.uc_PanelBox();
                pb.PanelContainer = ug;
                pb.Location = new System.Drawing.Point(134, 43);
                pb.Name = "pb";
                pb.Size = new System.Drawing.Size(517, 319);
                pb.TabIndex = 2;
                ug.Dock = DockStyle.Fill;
                pb.Dock = DockStyle.Fill;
                pb.BringToFront();
                Form dl = new Form();
                dl.Font = new System.Drawing.Font("Tahoma", 8.25F);
                dl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dl.Size = new System.Drawing.Size(600, 350);
                dl.Controls.Add(pb);
                dl.ShowDialog();
            }
        }
    }
}
