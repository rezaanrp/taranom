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
    public partial class frmMeltTestResult_Report : Form
    {
        public frmMeltTestResult_Report()
        {
            InitializeComponent();
            
            dt_Melt.Columns.Add("x_", typeof(int));
            dt_Melt.Columns.Add("xMaterialType", typeof(string));
            dt_Melt.Columns.Add("xSupplierCompany", typeof(string));
            dt_Melt.Columns.Add("xDateEnter", typeof(string));
            dt_Melt.Columns.Add("xDateTest", typeof(string));
            dt_Melt.Columns.Add("xAbsorptionPercent", typeof(string));
            dt_Melt.Columns.Add("xSupplierby", typeof(string));
            dt_Melt.Columns.Add("xApproveBy", typeof(string));
            dt_Melt.Columns.Add("xSupplier", typeof(bool));
            dt_Melt.Columns.Add("xApprove", typeof(bool));
            dt_Melt.Columns.Add("Accept", typeof(string));
        }
        private DataTable dt_Melt = new DataTable("Melt");
        private void ShowStripButton_Click(object sender, EventArgs e)
        {
            fillDatagridView();
        }
        private void fillDatagridView()
        {
            bool ap_flag = rdb_approve.Checked;
             //xMaterialType,
             //           xSupplier,
             //           xDateEnter,
             //           xDateTest,
             //           xAbsorptionPercent,
             //           Accept
            dataGridView1.Columns.Clear();

            bindingSource1.DataSource = dt_Melt;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xMaterialType"].HeaderText = "نوع مواد";
            dataGridView1.Columns["xSupplierCompany"].HeaderText = "تامین کننده";
            dataGridView1.Columns["xDateEnter"].HeaderText = "تاریخ ورود";
            dataGridView1.Columns["xDateTest"].HeaderText = "تاریخ تست";
            dataGridView1.Columns["xAbsorptionPercent"].HeaderText = "درصد جذب";
            dataGridView1.Columns["xSupplierby"].HeaderText = "تهیه شده توسط";
            dataGridView1.Columns["xApproveBy"].HeaderText = "تایید شده توسط";
            dataGridView1.Columns["Accept"].HeaderText = "وضعیت";
            dataGridView1.Columns["xSupplier"].Visible = false;
            dataGridView1.Columns["xApprove"].HeaderText = "تایید ";
            dataGridView1.Columns["xApprove"].ReadOnly = false;
            dataGridView1.Columns["xMaterialType"].ReadOnly = true;
            dataGridView1.Columns["xSupplierCompany"].ReadOnly = true;
            dataGridView1.Columns["xDateEnter"].ReadOnly = true;
            dataGridView1.Columns["xDateTest"].ReadOnly = true;
            dataGridView1.Columns["xAbsorptionPercent"].ReadOnly = true;
            dataGridView1.Columns["xSupplierby"].ReadOnly = true;
            dataGridView1.Columns["xApproveBy"].ReadOnly = true;
            dataGridView1.Columns["Accept"].ReadOnly = true;
            
            BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.DataSource = cs.SelectMeltTestResultByDate(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, true, ap_flag, rdb_all.Checked);
            dataGridView1.DataSource = bindingSource1;
            
            
            DataGridViewButtonColumn buttonColumn =
                new DataGridViewButtonColumn();

            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "نمایش جزئیات";
            buttonColumn.Text = "جزئیات";
            buttonColumn.UseColumnTextForButtonValue = true;
          
            dataGridView1.Columns.Insert(10, buttonColumn);

        }
        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    crsMeltTestResultDetails cr = new crsMeltTestResultDetails();
        //    BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
        //    //cr.Database.Tables[0].SetDataSource(cc);
        //    frmReport r = new frmReport();
        //    r.GetReport = cr;
        //    r.ShowDialog();
        //}

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1)
                return;
            //crsMeltTestResult cr = new crsMeltTestResult();
            //BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
            //cr.SetDataSource(cs.SelectMeltTestResultByDate(uc_txtDateFrom.Text, uc_txtDateTo.Text, true, rdb_approve.Checked, rdb_all.Checked));
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
            r.GetReport = cs.GetReport(dt_Melt, "crsMeltTestResult");
            r.ShowDialog();
            r.Dispose();

           
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
                if (!cs.UpdateCharacteristicScarbPurchaseApprove(ap, ro)) MessageBox.Show("شما مجوز تایید نداریند");
            }
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
