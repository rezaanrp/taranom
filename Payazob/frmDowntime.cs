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
    public partial class frmDowntime : Form
    {
        public frmDowntime()
        {
            InitializeComponent();
        }

        private void frmDowntime_Load(object sender, EventArgs e)
        {
            BLL.csShift shift = new BLL.csShift();
            uc_cmbAuto_shift.DataSource = shift.mShiftDataTable();
            uc_cmbAuto_shift.DisplayMember = "xShiftName";
            uc_cmbAuto_shift.ValueMember = "x_";
            uc_cmbAuto_shift.SelectedIndex = -1;

            uc_cmbAuto_superviser.DataSource = uc_cmbAuto_shift.DataSource;

            uc_cmbAuto_superviser.ValueMember = "xShiftSuperviser";
            uc_cmbAuto_superviser.DisplayMember = "xShiftSuperviser";
            uc_cmbAuto_superviser.SelectedIndex = -1;


            BLL.csDownTime DT = new BLL.csDownTime();
            uc_cmbAuto_DowntiomeType.DataSource = DT.SelectDownTimeType();
            uc_cmbAuto_DowntiomeType.ValueMember = "x_";
            uc_cmbAuto_DowntiomeType.DisplayMember = "xDowntimeName";
            uc_cmbAuto_DowntiomeType.SelectedIndex = -1;

            BLL.csSection sc = new BLL.csSection();
            uc_cmbAuto_SectionType.DataSource = sc.SelectSection();
            uc_cmbAuto_SectionType.ValueMember = "x_";
            uc_cmbAuto_SectionType.DisplayMember = "xSectionName";
            uc_cmbAuto_SectionType.SelectedIndex = -1;

        }
        void filldatagirdView(string date, string dvg_shift_, string dvg_cmbSectionName_, string dvg_cmbSectionName, string dvg_cmbDowntimeType,
           string dvg_cmbDowntimeType_, string dvg_dmbshiftname, string dvg_Duration, string dvg_Start, string dvg_End, string dvg_comment)
        {
            dataGridView1.Rows.Add();
            int i = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[i].Cells["dvg_Date"].Value = date;
            dataGridView1.Rows[i].Cells["dvg_shift_"].Value = dvg_shift_;
            dataGridView1.Rows[i].Cells["dvg_Section_"].Value = dvg_cmbSectionName_;
            dataGridView1.Rows[i].Cells["dvg_cmbSectionName"].Value = dvg_cmbSectionName;
            dataGridView1.Rows[i].Cells["dvg_cmbDowntimeType"].Value = dvg_cmbDowntimeType;
            dataGridView1.Rows[i].Cells["dvg_downtime_"].Value = dvg_cmbDowntimeType_;
            dataGridView1.Rows[i].Cells["dvg_dmbshiftname"].Value = dvg_dmbshiftname;
            dataGridView1.Rows[i].Cells["dvg_Duration"].Value = dvg_Duration;
            dataGridView1.Rows[i].Cells["dvg_Start"].Value = dvg_Start;
            dataGridView1.Rows[i].Cells["dvg_End"].Value = dvg_End;
            dataGridView1.Rows[i].Cells["dvg_comment"].Value = dvg_comment;
        }
        void editdatagirdView(string date, string dvg_shift_, string dvg_cmbSectionName_, string dvg_cmbSectionName, string dvg_cmbDowntimeType,
                    string dvg_cmbDowntimeType_, string dvg_dmbshiftname, string dvg_Duration, string dvg_Start, string dvg_End, string dvg_comment,int index)
        {
            dataGridView1.Rows[index].Cells["dvg_Date"].Value = date;
            dataGridView1.Rows[index].Cells["dvg_shift_"].Value = dvg_shift_;
            dataGridView1.Rows[index].Cells["dvg_Section_"].Value = dvg_cmbSectionName_;
            dataGridView1.Rows[index].Cells["dvg_cmbSectionName"].Value = dvg_cmbSectionName;
            dataGridView1.Rows[index].Cells["dvg_cmbDowntimeType"].Value = dvg_cmbDowntimeType;
            dataGridView1.Rows[index].Cells["dvg_downtime_"].Value = dvg_cmbDowntimeType_;
            dataGridView1.Rows[index].Cells["dvg_dmbshiftname"].Value = dvg_dmbshiftname;
            dataGridView1.Rows[index].Cells["dvg_Duration"].Value = dvg_Duration;
            dataGridView1.Rows[index].Cells["dvg_Start"].Value = dvg_Start;
            dataGridView1.Rows[index].Cells["dvg_End"].Value = dvg_End;
            dataGridView1.Rows[index].Cells["dvg_comment"].Value = dvg_comment;
        }

        private bool Fillingright()
        {
            bool flag = true;
            Validation.Vuc_cmbAuto vc = new Validation.Vuc_cmbAuto();
            flag = vc.NotNullContent(groupBox1);
            if (txt_Duration.Text == "")
                flag = false;
            return flag;
        }


        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (!Fillingright())
            {
                MessageBox.Show("فیلد ها را به طور کامل پر کنید.");
                return;
            }
            filldatagirdView(uc_TextBoxDate1.Text, uc_cmbAuto_shift.SelectedValue.ToString(), uc_cmbAuto_SectionType.SelectedValue.ToString(), uc_cmbAuto_SectionType.Text, uc_cmbAuto_DowntiomeType.Text,
                 uc_cmbAuto_DowntiomeType.SelectedValue.ToString(), uc_cmbAuto_shift.Text, txt_Duration.Text, mtxt_StartTime.Text, mtxt_StopTime.Text, uc_txt_comment.Text);     
        }

        private void btn_send_Click(object sender, EventArgs e)
        {


                try
                {
                    bool flag = false;
                    BLL.csDownTime dt = new BLL.csDownTime();
                    string xDate; int xSection_; string xStartTime; string xEndTime; int xDuration;
                    string xComment; int xShift_; int xDowntimeType_;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        xSection_ = int.Parse(dataGridView1["dvg_Section_", i].Value.ToString());
                        xShift_ = int.Parse(dataGridView1["dvg_shift_", i].Value.ToString());
                        xStartTime = dataGridView1["dvg_Start", i].Value.ToString();
                        xEndTime = dataGridView1["dvg_End", i].Value.ToString();
                        xDuration = int.Parse(dataGridView1["dvg_Duration", i].Value.ToString());
                        xDowntimeType_ = int.Parse(dataGridView1["dvg_downtime_", i].Value.ToString());
                        xDate = dataGridView1["dvg_Date", i].Value.ToString();
                        xComment = dataGridView1["dvg_comment", i].Value.ToString();
                        flag = dt.InsertDownTime(xDate, xSection_, xStartTime, xEndTime, xDuration, xComment, xShift_, xDowntimeType_);


                    }
                    if (flag)
                     MessageBox.Show("برنامه شما با موفقیت ارسال شد");
                    else
                     MessageBox.Show("شما مجوز ارسال برنامه را ندارید");

                        
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("خطا در ارتباط با دیتا بیس");
                }



        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
                return;
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            editdatagirdView(uc_TextBoxDate1.Text,uc_cmbAuto_shift.SelectedValue.ToString(), uc_cmbAuto_SectionType.SelectedValue.ToString(),
                uc_cmbAuto_SectionType.Text, uc_cmbAuto_DowntiomeType.Text,
                    uc_cmbAuto_DowntiomeType.SelectedValue.ToString(), uc_cmbAuto_shift.Text, txt_Duration.Text, mtxt_StartTime.Text,
                    mtxt_StopTime.Text, uc_txt_comment.Text, dataGridView1.SelectedRows[0].Index);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            mtxt_StartTime.Text = "";
            mtxt_StopTime.Text = "";
            uc_txt_comment.Text = "";
            txt_Duration.Text = "";
            uc_TextBoxDate1.Text = "";
        }

    }
}
