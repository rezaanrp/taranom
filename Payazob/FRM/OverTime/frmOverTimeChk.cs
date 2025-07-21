using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.OverTime
{
    public partial class frmOverTimeChk : Form
    {
        public frmOverTimeChk(string Section)
        {
            InitializeComponent();
            Sec = Section;
            ShowData1();

        }
        DataTable dt_P;
        string Sec = "";
       void ShowData1()
       {
           if(Sec == "Man")
                dt_P = new BLL.Person.csPersonInfo().mPersonInfoSec(BLL.authentication.x_); 
           else if(Sec == "Apr")
                dt_P = new BLL.Person.csPersonInfo().mPersonInfoSec(-1); 
           bindingSource1.DataSource = dt_P;
           dataGridView1.DataSource = bindingSource1;
           bindingNavigator1.BindingSource = bindingSource1;
           //dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           //dataGridView1.Columns["x_"].Visible = false;
         

       }
       void ShowData_IO()
       {
           dt_P = new BLL.Person.csPersonInfo().mPersonInfoBySec(-1);
           bindingSource1.DataSource = dt_P;
           dataGridView1.DataSource = bindingSource1;
           bindingNavigator1.BindingSource = bindingSource1;
           //dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           //dataGridView1.Columns["x_"].Visible = false;
       }
       DAL.Person.DataSet_PersonIO.IOInfoDataTable dt_A;
       DAL.OverTime.DataSet_OverTime.mOverTimeDataTable dt_O;

       private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
       {
           if (dataGridView1["xPerID", e.RowIndex].Value != null && dataGridView1["xPerID", e.RowIndex].Value != DBNull.Value)
           {
               BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
               dt_A = cs.OverTimeIO((string)dataGridView1["xPerID", e.RowIndex].Value,
                                        uc_Filter_Date1.DateFrom.Substring(5), uc_Filter_Date1.DateTo.Substring(5));
               bindingSource_IO.DataSource = dt_A;
               dataGridView_IO.DataSource = bindingSource_IO;
               bindingNavigator_IO.BindingSource = bindingSource_IO;

               ///////////////////////////////////////////////////////////////////////////////

               dt_O = cs.OverTime(int.Parse((string)dataGridView1["xPerID", e.RowIndex].Value), 
                                        uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
               bindingSource_OV.DataSource = dt_O;
               dataGridView_OV.DataSource = bindingSource_OV;
               bindingNavigator_OV.BindingSource = bindingSource_OV;
               GenerateOV();
           }
                 
       }
       void GenerateOV()
       {

           //dataGridView1.Columns["xPerID"].HeaderText = "شماره پرسنلی";
           //dataGridView1.Columns["Name"].HeaderText = "نام";

           /////////////////////////////////////////////////
           
            dataGridView_IO.Columns["PERNO"].HeaderText = "شماره پرسنلی";
            dataGridView_IO.Columns["BEGINDATE"].HeaderText = "تاریخ شروع کاری";
            dataGridView_IO.Columns["BEGINTIME"].HeaderText = "زمان شروع کار";
            dataGridView_IO.Columns["ENDDATE"].HeaderText = "تاریخ پایان کار";
            dataGridView_IO.Columns["ENDTIME"].HeaderText = "زمان پایان کار";
            dataGridView_IO.Columns["DURATION"].HeaderText = "مدت کار";

           /////////////////////////////////////////////////
           dataGridView_OV.Columns["xDate"].HeaderText = "تاریخ";
           dataGridView_OV.Columns["xPerCode"].HeaderText = "شماره پرسنلی";
           dataGridView_OV.Columns["xBeginTimeOver1"].HeaderText = "شروع اضافه کاری";
           dataGridView_OV.Columns["xEndTimeOver1"].HeaderText = "پایان اضافه کاری";
           dataGridView_OV.Columns["xBeginTimeOver2"].HeaderText = "شروع اضافه کاری - بازنگری";
           dataGridView_OV.Columns["xEndTimeOver2"].HeaderText = "پایان اضافه کاری - بازنگری";
           dataGridView_OV.Columns["xSupplier_"].HeaderText = "تهیه کننده";
           dataGridView_OV.Columns["xSupplier"].HeaderText = "تهیه کننده";
           dataGridView_OV.Columns["xApprove_"].HeaderText = "تایید کننده";
           dataGridView_OV.Columns["xApprove"].HeaderText = "تایید کننده";
           dataGridView_OV.Columns["xManager"].HeaderText = "اعلام مغایرت";
           dataGridView_OV.Columns["xManager_"].HeaderText = "مدیر";
           dataGridView_OV.Columns["xReason"].HeaderText = "علت اضافه کاری- حتما پر شود";

           dataGridView_OV.Columns["xDate"].ReadOnly=true;
           dataGridView_OV.Columns["xPerCode"].ReadOnly =true;
           dataGridView_OV.Columns["xBeginTimeOver1"].ReadOnly =true;
           dataGridView_OV.Columns["xEndTimeOver1"].ReadOnly = true;
           dataGridView_OV.Columns["xBeginTimeOver2"].ReadOnly = true;
           dataGridView_OV.Columns["xEndTimeOver2"].ReadOnly = true;
           dataGridView_OV.Columns["xSupplier_"].ReadOnly = true;
           dataGridView_OV.Columns["xSupplier"].ReadOnly = true;
           dataGridView_OV.Columns["xApprove_"].ReadOnly = true;
           dataGridView_OV.Columns["xApprove"].ReadOnly = true;
           dataGridView_OV.Columns["xManager"].ReadOnly = true;
           dataGridView_OV.Columns["xManager_"].ReadOnly = true;

           dataGridView_OV.Columns["x_"].Visible = false;
           dataGridView_OV.Columns["xDate"].Visible = true;
           dataGridView_OV.Columns["xPerCode"].Visible = true;
           dataGridView_OV.Columns["xBeginTimeOver1"].Visible = true;
           dataGridView_OV.Columns["xEndTimeOver1"].Visible = true;
           dataGridView_OV.Columns["xBeginTimeOver2"].Visible = true;
           dataGridView_OV.Columns["xEndTimeOver2"].Visible = true;
           dataGridView_OV.Columns["xSupplier_"].Visible = false;
           dataGridView_OV.Columns["xSupplier"].Visible = false;
           dataGridView_OV.Columns["xApprove_"].Visible = false;
           dataGridView_OV.Columns["xApprove"].Visible = true;
           dataGridView_OV.Columns["xManager"].Visible = true;
           dataGridView_OV.Columns["xManager_"].Visible = false;

           //foreach (DataGridViewRow item in dataGridView_OV.Rows)
           //{


           //    if (item.Cells["xApprove"].Value != DBNull.Value && item.Cells["xApprove"].Value != null && (bool?)item.Cells["xApprove"].Value == true)
           //        item.DefaultCellStyle.BackColor = Color.LawnGreen;
           //    else
           //        item.DefaultCellStyle.BackColor = Color.OrangeRed;


           //}



           if (Sec == "Man")
           {

               dataGridView_OV.Columns["xManager"].ReadOnly = false;
               dataGridView_OV.Columns["xApprove"].Visible = false;

           }
           else if (Sec == "Apr")
           {
               dataGridView_OV.Columns["xApprove"].ReadOnly = false;

           }

       }

       private void toolStripButton_D_A_Save_Click(object sender, EventArgs e)
       {
           this.Validate();
           dataGridView1.EndEdit();
           BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
           MessageBox.Show(cs.UdOverTime(dt_O), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
       }

       private void dataGridView_OV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
       {

               if (e.RowIndex > -1 && e.ColumnIndex == dataGridView_OV.Columns["xApprove"].Index)
                   if ((bool?)dataGridView_OV["xApprove", e.RowIndex].Value == true)
                   {
                       dataGridView_OV["xApprove_", e.RowIndex].Value = BLL.authentication.x_;
                   }
                   else
                       dataGridView_OV["xApprove_", e.RowIndex].Value = DBNull.Value;
               else if (e.RowIndex > -1 && e.ColumnIndex == dataGridView_OV.Columns["xManager"].Index)
                   if ((e.RowIndex > -1) && (dataGridView_OV["xApprove", e.RowIndex].Value == DBNull.Value 
                        ||  (bool?)dataGridView_OV["xApprove", e.RowIndex].Value != true ))
                              {
                                   if ((bool?)dataGridView_OV["xManager", e.RowIndex].Value == true)
                                   {
                                       dataGridView_OV["xManager_", e.RowIndex].Value = BLL.authentication.x_;
                                   }
                                   else
                                       dataGridView_OV["xManager_", e.RowIndex].Value = DBNull.Value;
                              }
           
       }

       private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
       {
  
       }
       Stack<int> dvg_ind = new Stack<int>();
       private void uc_txtBox1_KeyDown(object sender, KeyEventArgs e)
       {
           if (e.KeyCode == Keys.Enter)
           {
               if (dvg_ind.Count > 0)
               {
                   int i = dvg_ind.Pop();
                   dataGridView1.Rows[i].Selected = true;
                   dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
               }
           }
           else
           {
               dvg_ind.Clear();
               foreach (DataGridViewRow item in dataGridView1.Rows)
               {
                   item.Selected = false;
               }


               foreach (DataGridViewRow item in dataGridView1.Rows)
               {
                   foreach (DataGridViewCell itemCell in item.Cells)
                   {

                       if (
                           itemCell.Visible == true && itemCell.Value != DBNull.Value && itemCell.Value != null &&
                           (itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text) ||
                            itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ی', 'ي')) ||
                             itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ي', 'ی')) ||
                              itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ک', 'ك')) ||
                               itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ك', 'ک')))
                           )
                       {

                           dvg_ind.Push(item.Index);
                           break;
                           //return;
                       }


                   }
               }
               if (dvg_ind.Count > 0)
               {
                   int i = dvg_ind.Pop();
                   dataGridView1.Rows[i].Selected = true;
                   dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
               }
           }
           ///////////////////////////
       }

  

    }
}
