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
    public partial class frmDownTime_Report : Form
    {
        public frmDownTime_Report()
        {
            InitializeComponent();


            BLL.csSection sc = new BLL.csSection();
            uc_cmbAuto_SectionType.DataSource = sc.SelectSection();
            uc_cmbAuto_SectionType.ValueMember = "x_";
            uc_cmbAuto_SectionType.DisplayMember = "xSectionName";


            DataGridViewButtonColumn buttonColumn =
                        new DataGridViewButtonColumn();
            buttonColumn.Name = "Details";
            buttonColumn.HeaderText = "نمایش جزئیات";
            buttonColumn.Text = "بيشتر";
            buttonColumn.Visible = false;
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(0, buttonColumn);

        }
        DataTable dt_Me = new DataTable("DownTime");
        private Stack<ControlLibrary.uc_cmbAuto> stack = new Stack<ControlLibrary.uc_cmbAuto>();

        private void generateForm()
        {
            //Duration xSectionName xDowntimeName xSection_ xDowntimeType_
            BLL.csDownTime cs = new BLL.csDownTime();

            dt_Me.Clear();
            dt_Me = cs.SelectDownTimeByDateGDuration(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text);

            bindingSource1.DataSource = dt_Me;
            dataGridView1.DataSource = bindingSource1;

            dataGridView1.Columns["Duration"].HeaderText = "مدت توقف (دقیقه)";
            dataGridView1.Columns["xSectionName"].HeaderText = "نام قسمت";
            dataGridView1.Columns["xDowntimeName"].HeaderText = "نام توقف";
            dataGridView1.Columns["Details"].DisplayIndex = 3;
            dataGridView1.Columns["Details"].Visible = true;
            dataGridView1.Columns["xDowntimeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["xSection_"].Visible = false;
            dataGridView1.Columns["xDowntimeType_"].Visible = false;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            generateForm();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((System.Windows.Forms.DataGridView)(sender)).Columns[e.ColumnIndex].Name == "Details")
            {
                BLL.csDownTime cs = new BLL.csDownTime();
                ControlLibrary.uc_GridView ug = new ControlLibrary.uc_GridView();
                ug.bindingSource1.DataSource = cs.SelectDownTimeByxDateByTypeBySectionTableAdapter(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, (int)dataGridView1["xDowntimeType_", e.RowIndex].Value, (int)dataGridView1["xSection_", e.RowIndex].Value);
                ug.dataGridView1.Columns["x_"].HeaderText = "نام عنصر";
                ug.dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
                ug.dataGridView1.Columns["xStartTime"].HeaderText = "زمان شروع";
                ug.dataGridView1.Columns["xEndTime"].HeaderText = "زمان پایان";
                ug.dataGridView1.Columns["xDuration"].HeaderText = "مدت";
                ug.dataGridView1.Columns["xSectionName"].HeaderText = "نام قسمت";
                ug.dataGridView1.Columns["xDowntimeName"].HeaderText = "نوع توقف";
                ug.dataGridView1.Columns["xShiftName"].HeaderText = "شیفت";
                ug.dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
               // ug.dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

               private void chb_Goods_CheckedChanged(object sender, EventArgs e)
        {

            if (((System.Windows.Forms.CheckBox)(sender)).Name == "chb_Goods")
                groupBox2.Enabled = ((System.Windows.Forms.CheckBox)(sender)).Checked;

        }
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (chb_Goods.Checked)
            {
                //crsDownTimeByDateGDurationHSection cr = new crsDownTimeByDateGDurationHSection();
                BLL.csDownTime cs = new BLL.csDownTime();
                DataTable dt = cs.SelectDownTimeByDateGDurationHSection(uc_Filter_Date1.uc_txtDateFrom.Text, uc_Filter_Date1.uc_txtDateTo.Text, int.Parse(uc_cmbAuto_SectionType.SelectedValue.ToString()));
                //cr.SetDataSource(dt);
                int sum = 0;
                foreach (DataRow item in dt.Rows)
                {
                    sum += int.Parse(item["Duration"].ToString());
                }
                //cr.SetParameterValue("SumDuration", sum);
                //cr.SetParameterValue("DateNow", BLL.csshamsidate.shamsidate);
                //cr.SetParameterValue("DateFrom", uc_txtDateFrom.Text);
                //cr.SetParameterValue("DateTo", uc_txtDateTo.Text);
                Report.SendReport crp = new Report.SendReport();
                crp.SetParam("SumDuration", sum.ToString());
                crp.SetParam("DateNow", BLL.csshamsidate.shamsidate);
                crp.SetParam("DateFrom", uc_Filter_Date1.uc_txtDateFrom.Text);
                crp.SetParam("DateTo", uc_Filter_Date1.uc_txtDateTo.Text);
                frmReport r = new frmReport();
                r.GetReport = crp.GetReport(dt, "crsDownTimeByDateGDurationHSection");
                r.ShowDialog();
                r.Dispose();
            }
        }

    }
}
