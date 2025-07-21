using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.OverTime
{
    public partial class frmOverTimeDefTime : Form
    {
        public frmOverTimeDefTime()
        {
            InitializeComponent();

            dt_A = new DAL.OverTime.DataSet_OverTime.SlOverTimeDataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generate();
            
        }
        DAL.OverTime.DataSet_OverTime.SlOverTimeDataTable dt_A;
        DAL.OverTime.DataSet_OverTime.IOInfoByDateDataTable dt_I;
        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            string startTime = "7:00";
            string endTime = "14:00";

            TimeSpan duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));

            dt_A = new BLL.OverTime.csOverTime().SlOverTime(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, -1,"LIST",-1);

            dt_I = new BLL.OverTime.csOverTime().SlIOInfoByDate(uc_Filter_Date1.DateFrom.Substring(5), uc_Filter_Date1.DateTo.Substring(5));

            foreach (DataRow item in dt_A.Rows)
            {
              //  item["xDate"].ToString();
            //  MessageBox.Show(item["xDate"].ToString() + item["xEndTimeOver1"].ToString() +  item["xPerCode"].ToString());

              if(  ChkTime(item["xDate"].ToString()
                            ,item["xEndTimeOver2"] == DBNull.Value ? item["xEndTimeOver1"].ToString() : item["xEndTimeOver2"].ToString()
                                ,item["xPerCode"] == DBNull.Value ? "" : item["xPerCode"].ToString() ))
                item.Delete();
            }

            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            generate();
        }
        bool ChkTime(string Date,string Time,string PerCode)
        {
            Validation.VString cs = new Validation.VString();
            foreach (DataRow item in dt_I.Rows)
            {
               
                if (cs.isTime( item["ENDTIME"].ToString() ))
             //   {
                    if (uc_Filter_Date1.DateFrom.Substring(0, 4) + "/" + item["BEGINDATE"].ToString() == Date &&
                         int.Parse(item["PERNO"].ToString()) == int.Parse(PerCode) &&

                        (DateTime.Parse(item["ENDTIME"].ToString()).Subtract(DateTime.Parse(Time)).Minutes <= 30
                                || DateTime.Parse(item["ENDTIME"].ToString()).Subtract(DateTime.Parse(Time)).Minutes > 30)

                        )
                    {

                        return true;
                    }
               // }
   
            }
            return false;
        }
        void generate()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = true;
            dataGridView1.Columns["xDateOverTime"].Visible = false;
            dataGridView1.Columns["xPerCode"].Visible = true;
            dataGridView1.Columns["xBeginTimeOver1"].Visible = true;
            dataGridView1.Columns["xEndTimeOver1"].Visible = true;
            dataGridView1.Columns["xBeginTimeOver2"].Visible = true;
            dataGridView1.Columns["xEndTimeOver2"].Visible = true;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xSupplier"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["xApprove"].Visible = true;
            dataGridView1.Columns["xManager_"].Visible = false;
            dataGridView1.Columns["xManager"].Visible = false;
            dataGridView1.Columns["xReason"].Visible = true;


            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xPerCode"].HeaderText = "شماره پرسنلی";
            dataGridView1.Columns["xBeginTimeOver1"].HeaderText = "شروع اضافه کاری";
            dataGridView1.Columns["xEndTimeOver1"].HeaderText = "پایان اضافه کاری";
            dataGridView1.Columns["xBeginTimeOver2"].HeaderText = "شروع اضافه کاری - بازنگری";
            dataGridView1.Columns["xEndTimeOver2"].HeaderText = "پایان اضافه کاری - بازنگری";
            dataGridView1.Columns["xReason"].HeaderText = "علت اضافه کاری";

            dataGridView1.Columns["Approve"].HeaderText = " نام تایید کننده اداری";


            dataGridView1.Columns["Supplier"].HeaderText = "تهیه کننده";
            dataGridView1.Columns["xApprove"].HeaderText = "تایید اداری ";
            dataGridView1.Columns["Manager"].HeaderText = "تایید مدیر";
        }
    }
}
