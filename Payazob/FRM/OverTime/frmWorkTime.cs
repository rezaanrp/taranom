using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL.OverTime;

namespace Payazob.FRM.OverTime
{
    public partial class frmWorkTime : Form
    {
        public frmWorkTime()
        {
            InitializeComponent();
            this.PerID_ = "0";

        }
        private string PerID_;
        private DAL.Person.DataSet_PersonIO.IOInfoDataTable dt_A;

        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            this.Show_DataWINKART();

        }
        private void Show_DataWINKART()
        {
            csOverTime time = new csOverTime();
            DataTable table = new BLL.GenGroup.csGenGroup().SlGenGroup("DATELENOVT");
            DataTable table2 = new BLL.Person.csPersonInfo().mPersonInfoByUserx_(BLL.authentication.x_);
            if (table2.Rows.Count > 0)
            {
                this.PerID_ = table2.Rows[0]["xPerID"].ToString();
            }
 
            else 
            {

                MessageBox.Show("خطا");
                return;

            }
            if (this.PerID_ == "0" || this.PerID_ == "")
            {
                MessageBox.Show("شماره پرسنلی شما هنوز در سیستم تعریف نشده");
            }
            else
            {
                this.dt_A = time.OverTimeIO(this.PerID_, new BLL.csshamsidate().previousDay(int.Parse(table.Rows[0]["xName"].ToString())).Substring(5), BLL.csshamsidate.shamsidate.Substring(5));
                this.bindingSource1.DataSource = this.dt_A;
                this.dataGridView1.DataSource = this.bindingSource1;
                this.bindingNavigator1.BindingSource = this.bindingSource1;
                try
                {
                    this.dataGridView1.Columns["PERNO"].HeaderText = "شماره پرسنلی";
                    this.dataGridView1.Columns["BEGINDATE"].HeaderText = "تاریخ شروع کاری";
                    this.dataGridView1.Columns["BEGINTIME"].HeaderText = "زمان شروع کار";
                    this.dataGridView1.Columns["ENDDATE"].HeaderText = "تاریخ پایان کار";
                    this.dataGridView1.Columns["ENDTIME"].HeaderText = "زمان پایان کار";
                    this.dataGridView1.Columns["DURATION"].HeaderText = "مدت کار";

                    BLL.csshamsidate csss = new BLL.csshamsidate();
                    string ss =     BLL.csshamsidate.shamsidate.Substring(0, 4);
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        decimal k = item.Cells["DURATION"].Value == DBNull.Value ? 0 : (decimal)item.Cells["DURATION"].Value;
                        if (k < 570)
                        {
                            item.DefaultCellStyle.BackColor = Color.Cornsilk;
                        }
                        int inx = csss.ShamsiDayeOfWeek(  ss +"/" + item.Cells["BEGINDATE"].Value.ToString());
                        if (  inx ==  6)
                        {
                            item.DefaultCellStyle.BackColor = Color.Lime;
                        }
                        if (inx == 0 )
                        {
                            item.DefaultCellStyle.BackColor = Color.OrangeRed;
                        }

                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new ControlLibrary.uc_ExportExcelFile { Fildvg = this.dataGridView1 }.RunExcel();
            /*
                         ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
             */

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ucStatusBar1.DgvCell = dataGridView1.SelectedCells;
        }
    }
}
