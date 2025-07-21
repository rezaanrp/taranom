using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.OverTime
{
    public partial class frmOverTime : Form
    {
        public frmOverTime()
        {
            InitializeComponent();

          //  Sec = Section_;
            dataGridView2.AllowUserToAddRows = true;
            toolStripButton_Add.Visible = true;
        }
        DAL.Person.DataSet_PersonIO.IOInfoDataTable dt_A;
        DAL.OverTime.DataSet_OverTime.mOverTimeDataTable dt_O;
        int User_ = -1;
        string PerID_ = "0";

        void Show_DataWINKART()
        {
                BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
                dt_A = cs.OverTimeIO(PerID_, uc_Filter_Date1.DateFrom.Substring(5), uc_Filter_Date1.DateTo.Substring(5));
                bindingSource1.DataSource = dt_A;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                try
                {
                    dataGridView1.Columns["PERNO"].HeaderText = "شماره پرسنلی";
                    dataGridView1.Columns["BEGINDATE"].HeaderText = "تاریخ شروع کاری";
                    dataGridView1.Columns["BEGINTIME"].HeaderText = "زمان شروع کار";
                    dataGridView1.Columns["ENDDATE"].HeaderText = "تاریخ پایان کار";
                    dataGridView1.Columns["ENDTIME"].HeaderText = "زمان پایان کار";
                    dataGridView1.Columns["DURATION"].HeaderText = "مدت کار";
                }
                catch (Exception)
                {
                    
                }


        }

        void Show_Data()
        {

            try
            {
                BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
                dt_O = cs.OverTime(int.Parse(PerID_ == "" ? "0" : PerID_), uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
                bindingSource2.DataSource = dt_O;
                dataGridView2.DataSource = bindingSource2;
                bindingNavigator1.BindingSource = bindingSource2;
                // dt_O.xDateColumn.DefaultValue = "";

                Generate();
            }
            catch (Exception)
            {
                
            }


        }

        void Generate()
        {
            dt_O.xPerCodeColumn.DefaultValue = int.Parse(PerID_ == "" ? "0" : PerID_);
            dt_O.xSupplierColumn.DefaultValue = false;
            dt_O.xApproveColumn.DefaultValue = false;
         //   dt_O.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_O.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView2.Columns["xApprove"].HeaderText = "تایید نهایی";
            dataGridView2.Columns["xSupplier"].HeaderText = "تایید ثبت";
            dataGridView2.Columns["xReason"].HeaderText = "علت اضافه کاری";
            dataGridView2.Columns["xReason"].Width  = 200;
            dataGridView2.Columns["x_"].Visible = false;

            dataGridView2.Columns["xPerCode"].ReadOnly = true;

            dataGridView2.Columns["xBeginTimeOver1"].ReadOnly = true;
            dataGridView2.Columns["xEndTimeOver1"].ReadOnly = true; 
            dataGridView2.Columns["xBeginTimeOver2"].ReadOnly = true;
            dataGridView2.Columns["xEndTimeOver2"].ReadOnly = true;
       //     dataGridView2.Columns["xDate"].ReadOnly = true;

            dataGridView2.Columns["xSupplier"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xApprove"].Visible = false;
            dataGridView2.Columns["xApprove_"].Visible = false;

            dataGridView2.Columns["xManager"].Visible = false;
            dataGridView2.Columns["xManager_"].Visible = false;
            dataGridView2.Columns["xPerCode"].Visible = false;

            //if (ty_in == "US")
            //{
            //    dataGridView2.Columns["xBeginTimeOver2"].Visible = false;
            //    dataGridView2.Columns["xEndTimeOver2"].Visible = false;
            //    dataGridView2.Columns["xSupplier"].Visible = false;
            //    dataGridView2.Columns["xSupplier_"].Visible = false;
            //    dataGridView2.Columns["xApprove_"].Visible = false;
            //    dataGridView2.Columns["xApprove"].Visible = false;
                
            //}
            BLL.csshamsidate csd = new BLL.csshamsidate();

            foreach (DataGridViewRow item in dataGridView2.Rows)
            {
                if (item.Cells["xDate"].Value == DBNull.Value || item.Cells["xDate"].Value == null)
                    continue;
                if (  csd.CompareDate(item.Cells["xDate"].Value.ToString(), BLL.csshamsidate.shamsidate))
                {
                    item.Cells["xBeginTimeOver1"].ReadOnly = false;
                    item.Cells["xEndTimeOver1"].ReadOnly = false;
                    item.Cells["xBeginTimeOver1"].Style.BackColor = Color.LightGreen;
                    item.Cells["xEndTimeOver1"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    BLL.csshamsidate cs = new BLL.csshamsidate();
                    int Ovr =  int.Parse( new BLL.GenGroup.csGenGroup().SlGenGroup("OVRT").Rows[0]["xName"].ToString() );

                    bool flagDate = false;
                    for (int i = 1; i < Ovr; i++)
                    {
                        if (cs.previousDay(i) == dataGridView2["xDate", item.Index].FormattedValue.ToString())
                        {
                            flagDate = true;
                        }
                    }
                    if (flagDate
                        || dataGridView2["xDate", item.Index].FormattedValue.ToString() == BLL.csshamsidate.shamsidate)
                    {
                        dataGridView2["xBeginTimeOver2", item.Index].ReadOnly = false;
                        dataGridView2["xEndTimeOver2", item.Index].ReadOnly = false;
                        dataGridView2["xBeginTimeOver2", item.Index].Style.BackColor = Color.LightGreen;
                        dataGridView2["xEndTimeOver2", item.Index].Style.BackColor = Color.LightGreen;

                        dataGridView2["xBeginTimeOver1", item.Index].ReadOnly = true;
                        dataGridView2["xEndTimeOver1", item.Index].ReadOnly = true;
                        dataGridView2["xBeginTimeOver1", item.Index].Style.BackColor = Color.White;
                        dataGridView2["xEndTimeOver1", item.Index].Style.BackColor = Color.White;


                    }
                    else
                    {
                        dataGridView2["xBeginTimeOver2", item.Index].ReadOnly = true;
                        dataGridView2["xEndTimeOver2", item.Index].ReadOnly = true;
                        dataGridView2["xBeginTimeOver2", item.Index].Style.BackColor = Color.LightGray;
                        dataGridView2["xEndTimeOver2", item.Index].Style.BackColor = Color.LightGray;
                        dataGridView2["xBeginTimeOver1", item.Index].ReadOnly = true;
                        dataGridView2["xEndTimeOver1", item.Index].ReadOnly = true;
                        dataGridView2["xBeginTimeOver1", item.Index].Style.BackColor = Color.White;
                        dataGridView2["xEndTimeOver1", item.Index].Style.BackColor = Color.White;
                    }

                }
            }
          
        }

        void LoadForm()
        {
            Form frm = new Form();
            ControlLibrary.uc_SearchData uc = new ControlLibrary.uc_SearchData();
            uc.ColumnFilter = "PerName";
            uc.DataGridViewHeaderText("PerName", "نام و نام خانوادگی");
            uc.DataGridViewHeaderText("xPerID", "شماره پرسنلی");
            uc.DataGridViewClmHide("x_");
            uc.GenDataGridView(new BLL.Person.csPersonInfo().mPersonInfoSec(BLL.authentication.x_));
            uc.ResultCustom = "PerName";
            uc.ResultCustom1 = "xPerID";
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.Controls.Add(uc);
            frm.Size = uc.Size;
            frm.Height += 30;
            frm.Width += 30;
            frm.StartPosition = FormStartPosition.CenterParent;
            
            uc.Dock = DockStyle.Fill;
            frm.ShowDialog();

            lbl_Header.Text = uc.ResultCustomValue;

            User_ = int.Parse(uc.ResultID);
            PerID_ = uc.ResultCustomValue1;
            uc.Dispose();
            frm.Dispose();
            if (User_ == -1)
            {
                this.Close();
            }
        }

        private void frmOverTime_Load(object sender, EventArgs e)
        {
            LoadForm();
            BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
            dt_O = new DAL.OverTime.DataSet_OverTime.mOverTimeDataTable();
            bindingSource2.DataSource = dt_O;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator1.BindingSource = bindingSource2;
         //   dt_O.xDateColumn.DefaultValue = "";

            Generate();

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadForm();
            if (User_ != -1)
            {
                Show_DataWINKART();
                Show_Data();
            }
           // Generate();
            
        }
        bool validatedData()
        {
                Validation.VString csTime = new Validation.VString();
                Validation.VDate vd = new Validation.VDate();
                bool vl = false;

            foreach (DataGridViewRow item in dataGridView2.Rows)
            {

                if (item.Cells["xBeginTimeOver1"].Value == null ||
                        item.Cells["xBeginTimeOver1"].Value == DBNull.Value ||
                        item.Cells["xBeginTimeOver1"].Value.ToString().Replace(" ","") == "" ||

                           csTime.isTime((string)item.Cells["xBeginTimeOver1"].Value)
                    )
                {
                    vl = true;
                }
                else
                    return false;

                if (item.Cells["xEndTimeOver1"].Value == null ||
                        item.Cells["xEndTimeOver1"].Value == DBNull.Value ||
                        item.Cells["xEndTimeOver1"].Value.ToString().Replace(" ", "") == "" ||
                            csTime.isTime((string)item.Cells["xEndTimeOver1"].Value)
                    )
                {
                    vl = true;
                }
                else
                    return false;

                if (item.Cells["xBeginTimeOver2"].Value == null ||
                        item.Cells["xBeginTimeOver2"].Value == DBNull.Value ||
                        item.Cells["xBeginTimeOver2"].Value.ToString().Replace(" ", "") == "" ||
                            csTime.isTime((string)item.Cells["xBeginTimeOver2"].Value)
                    )
                {
                    vl = true;
                }
                else
                    return false;

                if (item.Cells["xEndTimeOver2"].Value == null ||
                                        item.Cells["xEndTimeOver2"].Value == DBNull.Value ||
                        item.Cells["xEndTimeOver2"].Value.ToString().Replace(" ", "") == "" ||
                                            csTime.isTime((string)item.Cells["xEndTimeOver2"].Value)
                                    )
                {
                    vl = true;
                }
                else
                    return false;

            }
            return vl;
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView2.EndEdit();
            if (!validatedData())
            {
                MessageBox.Show("داده ها به طور صحیح وارد نشده");
                return;
            }
            BLL.OverTime.csOverTime cs = new BLL.OverTime.csOverTime();
            MessageBox.Show(cs.UdOverTime(dt_O),"",MessageBoxButtons.OK,MessageBoxIcon.Information );
            Show_Data();
            Generate();

        }
        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (
                dataGridView2.Columns["xBeginTimeOver1"].Index == e.ColumnIndex ||
                dataGridView2.Columns["xEndTimeOver1"].Index == e.ColumnIndex ||
                dataGridView2.Columns["xBeginTimeOver2"].Index == e.ColumnIndex ||
                dataGridView2.Columns["xEndTimeOver2"].Index == e.ColumnIndex
                
                )
            {


                Validation.VString csTime = new Validation.VString();
                if (!csTime.isTime(dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString()))
                {
                    dataGridView2[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Red;
                    dataGridView2[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.White;
                    MessageBox.Show("زمان ورودی صحیح نمی باشد");
                }
                else
                {
                    dataGridView2[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightGreen;
                    dataGridView2[e.ColumnIndex, e.RowIndex].Style.ForeColor = Color.Black;
                }

            }

            if (dataGridView2.Columns["xDate"].Index == e.ColumnIndex)
            {
              
                Validation.VDate vd = new Validation.VDate();
                if (dataGridView2[e.ColumnIndex, e.RowIndex].Value ==null || dataGridView2[e.ColumnIndex, e.RowIndex].Value == DBNull.Value
                     || !vd.ValidationDate(dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString()))
                {
                    dataGridView2["xDate", e.RowIndex].Style.BackColor = Color.Red;
                    dataGridView2["xDate", e.RowIndex].Style.ForeColor = Color.White;
                    //dataGridView2["xDate", e.RowIndex].Value = null;
                    MessageBox.Show("تاریخ ورودی صحیح نمی باشد");
                    dataGridView2[e.ColumnIndex, e.RowIndex].Value = null;
                }
                else
                {
                    dataGridView2["xDate", e.RowIndex].Style.BackColor = Color.White;
                    dataGridView2["xDate", e.RowIndex].Style.ForeColor = Color.Black;
                }

                dataGridView2["xBeginTimeOver1", e.RowIndex].Value = null;
                dataGridView2["xEndTimeOver1", e.RowIndex].Value = null;
                dataGridView2["xBeginTimeOver2", e.RowIndex].Value = null;
                dataGridView2["xEndTimeOver2", e.RowIndex].Value = null;
                if (dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue == DBNull.Value
                     || dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue == null)
                    return;
                BLL.csshamsidate cs = new BLL.csshamsidate();

           //     dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString();


                if (cs.CompareDate(dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString()
                     , BLL.csshamsidate.shamsidate))
               {
                   dataGridView2["xBeginTimeOver1", e.RowIndex].ReadOnly = false;
                   dataGridView2["xEndTimeOver1", e.RowIndex].ReadOnly = false;
                   dataGridView2["xBeginTimeOver1", e.RowIndex].Style.BackColor = Color.LightGreen;
                   dataGridView2["xEndTimeOver1", e.RowIndex].Style.BackColor = Color.LightGreen;

                   dataGridView2["xBeginTimeOver2", e.RowIndex].ReadOnly = true;
                   dataGridView2["xEndTimeOver2", e.RowIndex].ReadOnly = true;
                   dataGridView2["xBeginTimeOver2", e.RowIndex].Style.BackColor = Color.White;
                   dataGridView2["xEndTimeOver2", e.RowIndex].Style.BackColor = Color.White;

               }
               else
               {
                    
                    int Ovr =  int.Parse( new BLL.GenGroup.csGenGroup().SlGenGroup("OVRT").Rows[0]["xName"].ToString() );

                    bool flagDate = false;
                    for (int i = 1; i < Ovr; i++)
                    {
                        if (cs.previousDay(i) == dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString())
                        {
                            flagDate = true;
                        }
                    }
                    if (flagDate
                        || dataGridView2[e.ColumnIndex, e.RowIndex].FormattedValue.ToString() == BLL.csshamsidate.shamsidate)
                   {
                       dataGridView2["xBeginTimeOver2", e.RowIndex].ReadOnly = false;
                       dataGridView2["xEndTimeOver2", e.RowIndex].ReadOnly = false;
                       dataGridView2["xBeginTimeOver2", e.RowIndex].Style.BackColor = Color.LightGreen;
                       dataGridView2["xEndTimeOver2", e.RowIndex].Style.BackColor = Color.LightGreen;

                       dataGridView2["xBeginTimeOver1", e.RowIndex].ReadOnly = true;
                       dataGridView2["xEndTimeOver1", e.RowIndex].ReadOnly = true;
                       dataGridView2["xBeginTimeOver1", e.RowIndex].Style.BackColor = Color.White;
                       dataGridView2["xEndTimeOver1", e.RowIndex].Style.BackColor = Color.White;


                   }
                   else
                   {
                       dataGridView2["xBeginTimeOver2", e.RowIndex].ReadOnly = true;
                       dataGridView2["xEndTimeOver2", e.RowIndex].ReadOnly = true;
                       dataGridView2["xBeginTimeOver2", e.RowIndex].Style.BackColor = Color.LightGray;
                       dataGridView2["xEndTimeOver2", e.RowIndex].Style.BackColor = Color.LightGray;
                       dataGridView2["xBeginTimeOver1", e.RowIndex].ReadOnly = true;
                       dataGridView2["xEndTimeOver1", e.RowIndex].ReadOnly = true;
                       dataGridView2["xBeginTimeOver1", e.RowIndex].Style.BackColor = Color.White;
                       dataGridView2["xEndTimeOver1", e.RowIndex].Style.BackColor = Color.White;
                   }

               }
            }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if ( dataGridView2.Columns["xDate"].Index == e.ColumnIndex && (int)dataGridView2["x_", e.RowIndex].Value > 0)
            {
                e.Cancel = true;
            }
            if (dataGridView2.Columns["xApprove"].Index != e.ColumnIndex && dataGridView2["xApprove", e.RowIndex].Value != DBNull.Value 
                && (bool?)dataGridView2["xApprove", e.RowIndex].Value == true)
            {
                e.Cancel = true;
            }
        }

        private void frmOverTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView2.IsCurrentCellInEditMode)
                if (dataGridView2.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                    dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width += 5;
                else if (dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
                    dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width -= 5;  
        }

        private void toolStripButton_GroupAdd_Click(object sender, EventArgs e)
        {
            FRM.OverTime.frmOverTimeReg frm = new frmOverTimeReg();
            frm.ShowDialog();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Report.SendReport cs = new Report.SendReport();
            cs.SetParam("DateFrom", uc_Filter_Date1.DateFrom);
            cs.SetParam("DateTo", uc_Filter_Date1.DateTo);
            cs.SetParam("DateNow", BLL.csshamsidate.shamsidate);
            cs.SetParam("namefamily", lbl_Header.Text);
            frmReport r = new frmReport();
            r.GetReport = cs.GetReport(dt_A, "crsOverTime_WorkTime");
            r.ShowDialog();
            r.Dispose();
        }

   
    }
}
