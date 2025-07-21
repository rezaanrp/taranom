using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSandDailyReportList : Form
    {
        public frmSandDailyReportList()
        {
            InitializeComponent();

            toolStripTextBoxDateFrom.Text = BLL.csshamsidate.shamsidate;
            toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;

            BLL.csShift cs_Shift = new BLL.csShift();
            DataGridViewComboBoxColumn combobox_Shift_ = new DataGridViewComboBoxColumn();
            combobox_Shift_.HeaderText = "نام شیفت";
            combobox_Shift_.DataSource = cs_Shift.mShiftDataTable();
            combobox_Shift_.DisplayMember = "xShiftName";
            combobox_Shift_.ValueMember = "x_";
            combobox_Shift_.Name = "combobox_Shift_";
            combobox_Shift_.Visible = false;
            dataGridView1.Columns.Add(combobox_Shift_);

            BLL.csPieces cs = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn();
            combobox_PiecesLine1_.HeaderText = "نام قطعه در خط یک";
            combobox_PiecesLine1_.DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_PiecesLine1_.DisplayMember = "xName";
            combobox_PiecesLine1_.ValueMember = "x_";
            combobox_PiecesLine1_.Name = "combobox_PiecesLine1_";
            combobox_PiecesLine1_.Visible = false;
            dataGridView1.Columns.Add(combobox_PiecesLine1_);

            DataGridViewComboBoxColumn combobox_PiecesLine2_ = new DataGridViewComboBoxColumn();
            combobox_PiecesLine2_.HeaderText = "نام قطعه در خط دو";
            combobox_PiecesLine2_.DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            combobox_PiecesLine2_.DisplayMember = "xName";
            combobox_PiecesLine2_.ValueMember = "x_";
            combobox_PiecesLine2_.Name = "combobox_PiecesLine2_";
            combobox_PiecesLine2_.Visible = false;
            dataGridView1.Columns.Add(combobox_PiecesLine2_);


            DataGridViewComboBoxColumn combobox_MACHINENME_ = new DataGridViewComboBoxColumn();
            combobox_MACHINENME_.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("MACHINENME");
            combobox_MACHINENME_.DisplayMember = "xName";
            combobox_MACHINENME_.HeaderText = "نام دستگاه";
            combobox_MACHINENME_.ValueMember = "x_";
            combobox_MACHINENME_.DataPropertyName = "xGenGroup_";
            combobox_MACHINENME_.Name = "cmb_MACHINENME";
            combobox_MACHINENME_.Width = 150;
            combobox_MACHINENME_.MaxDropDownItems = 30;
          //  combobox_MACHINENME_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_MACHINENME_);


            generateForm_I();
            
            BLL.csSand csSand = new BLL.csSand();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                RowindexDataGridView1 = (int)dataGridView1["x_", 0].Value;
                dt_A = csSand.SelectSandMaterialUsageBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                generateForm_D_A();
                dt_B = csSand.SelectSandDailyReportDetialBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                generateForm_D_B();
            }
        }
        DAL.Sand.DataSet_SandDailyReport.SelectSandDailyReportByDateDataTable dt_I;
        DAL.Sand.DataSet_SandDailyReport.SelectSandDailyReportDetialBySandDailyDataTable dt_B;
        DAL.Sand.DataSet_SandDailyReport.SelectSandMaterialUsageBySandDailyDataTable dt_A;
        private void generateForm_I()
        {

            /*
                        xPiecesLine1_,
                        xPiecesLine2_,
                        xShift_,
                        xDate,
                        xSupplier_,
                        xApprove_,
                        xReportOther,
                        xReportMechanical,
                        xReportElectric,
                        xComment */
             BLL.csSand cs = new BLL.csSand();
             dt_I = cs.SandDailyReport(toolStripTextBoxDateFrom.Text,toolStripTextBoxDateTo.Text);

             dataGridView1.DataSource = dt_I;

             dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
             dataGridView1.Columns["xReportMechanical"].HeaderText = "گزارش مکانیکی";
             dataGridView1.Columns["xReportElectric"].HeaderText = "گزارش الکتریکی";
             dataGridView1.Columns["xReportOther"].HeaderText = "گزارشات دیگر";
             dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
             dataGridView1.Columns["x_"].HeaderText = "";
                
             dataGridView1.Columns["x_"].Visible = false;
             dataGridView1.Columns["xPiecesLine1_"].Visible = false;
             dataGridView1.Columns["xPiecesLine2_"].Visible = false;
             dataGridView1.Columns["xShift_"].Visible = false;
             dataGridView1.Columns["xSupplier_"].Visible = false;
             dataGridView1.Columns["xApprove_"].Visible = false;
             dataGridView1.Columns["xMachineName_"].Visible = false;

             dataGridView1.Columns["combobox_PiecesLine1_"].Visible = true;
             dataGridView1.Columns["combobox_PiecesLine2_"].Visible = true;
             dataGridView1.Columns["combobox_Shift_"].Visible = true;

             dataGridView1.Columns["combobox_PiecesLine1_"].DataPropertyName = "xPiecesLine1_";
             dataGridView1.Columns["combobox_PiecesLine2_"].DataPropertyName = "xPiecesLine2_";
             dataGridView1.Columns["combobox_Shift_"].DataPropertyName = "xShift_";
             dataGridView1.Columns["cmb_MACHINENME"].DataPropertyName = "xMachineName_";

             dataGridView1.Columns["xDate"].DisplayIndex = 0;
             dataGridView1.Columns["combobox_PiecesLine1_"].DisplayIndex = 3;
             dataGridView1.Columns["combobox_PiecesLine2_"].DisplayIndex = 4;
             dataGridView1.Columns["combobox_Shift_"].DisplayIndex = 1;
             dataGridView1.Columns["cmb_MACHINENME"].DisplayIndex = 5;

             dataGridView1.Columns["combobox_Shift_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
             dataGridView1.Columns["xDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
             dataGridView1.Columns["combobox_PiecesLine1_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
             dataGridView1.Columns["combobox_PiecesLine2_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

             dataGridView1.DataSource = dt_I;
             bindingSource1.DataSource = dataGridView1.DataSource;
             bindingNavigator1.BindingSource = bindingSource1;

        }

        private void generateForm_D_A()
        {
           // int xBantonit, int xSandNew, int xCoalDust, int xWater, int xBatchCount, int xSandReturn, int xOther, string xOtherName, int xSandDailyReport_
            dataGridView_D_A.DataSource = dt_A;
            bindingSource_D_A.DataSource = dataGridView_D_A.DataSource;
            bindingNavigator_D_A.BindingSource = bindingSource_D_A;

            dataGridView_D_A.Columns["xBantonit"].HeaderText = "بنتونیت";
            dataGridView_D_A.Columns["xSandNew"].HeaderText = "ماسه نو";
            dataGridView_D_A.Columns["xCoalDust"].HeaderText = "گرد زغال";
            dataGridView_D_A.Columns["xWater"].HeaderText = "آب";
            dataGridView_D_A.Columns["xBatchCount"].HeaderText = "تعداد بچ";
            dataGridView_D_A.Columns["xSandReturn"].HeaderText = "ماسه برگشتی";
            dataGridView_D_A.Columns["xOther"].HeaderText = "مقدار";
            dataGridView_D_A.Columns["xOtherName"].HeaderText = "نام مواد دیگر";
            dataGridView_D_A.Columns["x_"].Visible = false;
            dataGridView_D_A.Columns["xSandDailyReport_"].Visible = false;
        }

        private void generateForm_D_B()
        {
            //string xSamplingTime, decimal xMoisturePercent, int xPermeability, decimal xCompresiveStrength, int xCompactibility, int xSandDailyReport_



            dataGridView_D_B.DataSource = dt_B;
            bindingSource_D_B.DataSource = dataGridView_D_B.DataSource;
            bindingNavigator_D_B.BindingSource = bindingSource_D_B;

            dataGridView_D_B.Columns["xSamplingTime"].HeaderText = "زمان";
            dataGridView_D_B.Columns["xMoisturePercent"].HeaderText = "درصد رطوبت";
            dataGridView_D_B.Columns["xPermeability"].HeaderText = "عبور گاز";
            dataGridView_D_B.Columns["xCompresiveStrength"].HeaderText = "استحکام فشاری";
            dataGridView_D_B.Columns["xCompactibility"].HeaderText = "تراکم پذیری";
            dataGridView_D_B.Columns["xWaterHardness"].HeaderText = "سختی اب";
            
            dataGridView_D_B.Columns["xSandDailyReport_"].Visible = false;
            dataGridView_D_B.Columns["x_"].Visible = false;

        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {
            generateForm_I();

            BLL.csSand csSand = new BLL.csSand();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                RowindexDataGridView1 = (int)dataGridView1["x_", 0].Value;
                dt_A = csSand.SelectSandMaterialUsageBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                generateForm_D_A();
                dt_B = csSand.SelectSandDailyReportDetialBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                generateForm_D_B();
            }
        }
        int RowindexDataGridView1 = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BLL.csSand cs = new BLL.csSand();
            if (e.RowIndex > -1)
            {
                RowindexDataGridView1 = (int)dataGridView1["x_", e.RowIndex].Value;
                dt_A = cs.SelectSandMaterialUsageBySandDaily((int)dataGridView1["x_", e.RowIndex].Value);
                generateForm_D_A();
                dt_B = cs.SelectSandDailyReportDetialBySandDaily((int)dataGridView1["x_", e.RowIndex].Value);
                generateForm_D_B();
            }
        }


        private void toolStripButton_AddNew_I_Click(object sender, EventArgs e)
        {
            frmSandDailyReport frm = new frmSandDailyReport();
            frm.ShowDialog();
            if (frm.accept == true)
            {
                DataRow dr = dt_I.NewRow();
                if (frm.PiceasLine1_ != null)
                    dr["xPiecesLine1_"] = frm.PiceasLine1_;
                if(frm.PiceasLine2_ != null)
                    dr["xPiecesLine2_"] = frm.PiceasLine2_;
                if (frm.Machine != null)
                    dr["xMachineName_"] = frm.Machine;
                dr["xShift_"] = frm.Shift_;
                dr["xSupplier_"] = BLL.authentication.x_;

                if (BLL.authentication.xApproveby_ == BLL.authentication.x_)
                {
                    dr["xApprove_"] = BLL.authentication.x_;
                }

                dr["xReportOther"] = frm.txtReportOther;
                dr["xReportMechanical"] = frm.txtMechanical;
                dr["xReportElectric"] = frm.txtElectric;
                dr["xComment"] = frm.txtComment;
                dr["xDate"] = frm.TextBoxDate1;

                dt_I.Rows.Add(dr);
                ////////////////////////////

                this.Validate();
                dataGridView1.EndEdit();
                BLL.csSand cs = new BLL.csSand();
                cs.UpdateSandDailyReport(dt_I, frm.TextBoxDate1, frm.Shift_, frm.Machine);
                generateForm_I();
                dt_A = cs.SelectSandMaterialUsageBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                generateForm_D_A();
                dt_B = cs.SelectSandDailyReportDetialBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                generateForm_D_B();
            }

        }



        private void toolStripButton_Del_I_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);

        }

        private void toolStripButton_Del_B_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_D_B.SelectedRows)
                if (!row.IsNewRow) dataGridView_D_B.Rows.Remove(row);
        }



        private void toolStripButton_AddNew_B_Click(object sender, EventArgs e)
        {

            dt_B.xSandDailyReport_Column.DefaultValue = RowindexDataGridView1;
        }

        private void toolStripButton_AddNew_A_Click(object sender, EventArgs e)
        {
            dt_A.xSandDailyReport_Column.DefaultValue = RowindexDataGridView1;

        }

        private void toolStripButton_Del_A_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_D_A.SelectedRows)
                if (!row.IsNewRow) dataGridView_D_A.Rows.Remove(row);
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            CS.csMessage csm = new CS.csMessage();
            if (csm.ShowMessageSaveYesNo())
            {
                    this.Validate();
                    dataGridView1.EndEdit();
                    BLL.csSand cs = new BLL.csSand();
                    cs.UpdateSandDailyReport(dt_I, "", null,-1);
                    generateForm_I();

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                    dt_A = cs.SelectSandMaterialUsageBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                    generateForm_D_A();
                    dt_B = cs.SelectSandDailyReportDetialBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                    generateForm_D_B();
                }
            }
        }
        private void toolStripButton_D_B_Save_Click(object sender, EventArgs e)
        {
            CS.csMessage csm = new CS.csMessage();
            if (csm.ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView_D_B.EndEdit();
                BLL.csSand cs = new BLL.csSand();
                cs.UpdateSandDailyReportDetial(dt_B);
            }
        }
        private void toolStripButton_D_A_Save_Click(object sender, EventArgs e)
        {
            CS.csMessage csm = new CS.csMessage();
            if (csm.ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView_D_A.EndEdit();
                BLL.csSand cs = new BLL.csSand();
                cs.UpdateSandMaterialUsage(dt_A);
            }
        }

 

        private void btn_Test_Click(object sender, EventArgs e)
        {
            //frmSandDailyReport_Report frm = new frmSandDailyReport_Report();
            //frm.ShowDialog();
        }

        private void btn_Material_Click(object sender, EventArgs e)
        {

        }

        private void btn_TestAndMaterial_Click(object sender, EventArgs e)
        {
            frmSandMaterialAndDaily_Report frm = new frmSandMaterialAndDaily_Report();
            frm.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*
            xPiecesLine1_,
            xPiecesLine2_,
            xShift_,
            xDate,
            xSupplier_,
            xApprove_,
            xReportOther,
            xReportMechanical,
            xReportElectric,
            xComment */
            frmSandDailyReport frm = new frmSandDailyReport();
            frm.TextBoxDate1 = dataGridView1["xDate", e.RowIndex].Value.ToString();
            frm.txtComment = dataGridView1["xComment", e.RowIndex].Value.ToString();
            frm.txtElectric = dataGridView1["xReportElectric", e.RowIndex].Value.ToString();
            frm.txtMechanical = dataGridView1["xReportMechanical", e.RowIndex].Value.ToString();
            frm.txtReportOther = dataGridView1["xReportOther", e.RowIndex].Value.ToString();

            frm.PiceasLine1_ = dataGridView1["xPiecesLine1_", e.RowIndex].Value == null || dataGridView1["xPiecesLine1_", e.RowIndex].Value == DBNull.Value ? null : (int?)dataGridView1["xPiecesLine1_", e.RowIndex].Value;
            frm.PiceasLine2_ = dataGridView1["xPiecesLine2_", e.RowIndex].Value == null || dataGridView1["xPiecesLine2_", e.RowIndex].Value == DBNull.Value ? null : (int?)dataGridView1["xPiecesLine2_", e.RowIndex].Value;
            frm.Shift_ = (int?)dataGridView1["xShift_", e.RowIndex].Value;
            frm.FillForm();
            frm.ShowDialog();
            if (frm.accept == true)
            {


                dataGridView1["xDate", e.RowIndex].Value = frm.TextBoxDate1;
                dataGridView1["xComment", e.RowIndex].Value = frm.txtComment;
                dataGridView1["xReportElectric", e.RowIndex].Value = frm.txtElectric;
                dataGridView1["xReportMechanical", e.RowIndex].Value = frm.txtMechanical;
                dataGridView1["xReportOther", e.RowIndex].Value = frm.txtReportOther;
                dataGridView1["xPiecesLine1_", e.RowIndex].Value = frm.PiceasLine1_;
                dataGridView1["xPiecesLine2_", e.RowIndex].Value = frm.PiceasLine2_;
                dataGridView1["xShift_", e.RowIndex].Value = frm.Shift_;
                dataGridView1["xSupplier_", e.RowIndex].Value = BLL.authentication.x_; ;


                if (BLL.authentication.xApproveby_ == BLL.authentication.x_)
                {
                    dataGridView1["xApprove_", e.RowIndex].Value = BLL.authentication.x_; ;
                }
                
                this.Validate();
                dataGridView1.EndEdit();
                
                BLL.csSand cs = new BLL.csSand();
                cs.UpdateSandDailyReport(dt_I,"", null,-1);
                generateForm_I();
                dt_A = cs.SelectSandMaterialUsageBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                generateForm_D_A();
                dt_B = cs.SelectSandDailyReportDetialBySandDaily((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                generateForm_D_B();
            }

        }

        private void dataGridView_D_B_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView_D_B.Columns[e.ColumnIndex].Name == "xMoisturePercent")
            {
                float val;
                if (float.TryParse(e.FormattedValue.ToString(), out val))
                {
                    if (val < 2 || val > 5)
                    {
                        dataGridView_D_B.Rows[e.RowIndex].ErrorText = "عدد ورودی خارج از رنج می باشد";
                        e.Cancel = true;
                    }
                }
                else
                {
                    dataGridView_D_B.Rows[e.RowIndex].ErrorText = "خطا مقدار وارد شده عدد نمی باشد";
                }
            }

            //                dataGridView_D_B.Columns["xPermeability"].HeaderText = "عبور گاز";
            //dataGridView_D_B.Columns["xCompresiveStrength"].HeaderText = "استحکام فشاری";
            //dataGridView_D_B.Columns["xCompactibility"].HeaderText = "تراکم پذیری"; 3050

            else if (dataGridView_D_B.Columns[e.ColumnIndex].Name == "xCompactibility")
            {
                float val;
                if (float.TryParse(e.FormattedValue.ToString(), out val))
                {
                    if (val < 30 || val > 50)
                    {
                        dataGridView_D_B.Rows[e.RowIndex].ErrorText = "عدد ورودی خارج از رنج می باشد";
                        e.Cancel = true;
                    }
                }
                else
                {
                    dataGridView_D_B.Rows[e.RowIndex].ErrorText = "خطا مقدار وارد شده عدد نمی باشد";
                }
            }

            else if (dataGridView_D_B.Columns[e.ColumnIndex].Name == "xPermeability")
            {
                float val;
                if (float.TryParse(e.FormattedValue.ToString(), out val))
                {
                    if (val < 50 || val > 150)
                    {
                        dataGridView_D_B.Rows[e.RowIndex].ErrorText = "عدد ورودی خارج از رنج می باشد";
                        e.Cancel = true;
                    }
                }
                else
                {
                    dataGridView_D_B.Rows[e.RowIndex].ErrorText = "خطا مقدار وارد شده عدد نمی باشد";
                }
            }
            else if (dataGridView_D_B.Columns[e.ColumnIndex].Name == "xCompresiveStrength")
            {
                float val;
                if (float.TryParse(e.FormattedValue.ToString(), out val))
                {
                    if (val < 1 || val > 2)
                    {
                        dataGridView_D_B.Rows[e.RowIndex].ErrorText = "عدد ورودی خارج از رنج می باشد";
                        e.Cancel = true;
                    }
                }
                else
                {
                    dataGridView_D_B.Rows[e.RowIndex].ErrorText = "خطا مقدار وارد شده عدد نمی باشد";
                }
            }
        }

        private void ChLine1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChLine1.Checked)
            {
                ChLine1.Text = "ON";
                new BLL.TimeLine.csTimeLine().InTimeLineMachine(new BLL.csshamsidate().CurrentTime , BLL.csshamsidate.shamsidate,true,51);
            }
            else
            {
                ChLine1.Text = "OFF";
                new BLL.TimeLine.csTimeLine().InTimeLineMachine(new BLL.csshamsidate().CurrentTime, BLL.csshamsidate.shamsidate, false, 51);

            }
        }

        private void ChLine2_CheckedChanged(object sender, EventArgs e)
        {
            if (ChLine2.Checked)
            {
                ChLine2.Text = "ON";
                new BLL.TimeLine.csTimeLine().InTimeLineMachine(new BLL.csshamsidate().CurrentTime, BLL.csshamsidate.shamsidate, true, 52);

            }
            else
            {
                ChLine2.Text = "OFF";
                new BLL.TimeLine.csTimeLine().InTimeLineMachine(new BLL.csshamsidate().CurrentTime, BLL.csshamsidate.shamsidate, false, 52);

            }
        }

        private void CHLine3_CheckedChanged(object sender, EventArgs e)
        {
            if (CHLine3.Checked)
            {
                CHLine3.Text = "ON";
                new BLL.TimeLine.csTimeLine().InTimeLineMachine(new BLL.csshamsidate().CurrentTime, BLL.csshamsidate.shamsidate, true, 53);

            }
            else
            {
                CHLine3.Text = "OFF";
                new BLL.TimeLine.csTimeLine().InTimeLineMachine(new BLL.csshamsidate().CurrentTime, BLL.csshamsidate.shamsidate, false, 53);

            }
        }

        private void frmSandDailyReportList_Load(object sender, EventArgs e)
        {
          ChLine1.Checked =  new BLL.TimeLine.csTimeLine().SlTimeLineMachineLastStatus( BLL.csshamsidate.shamsidate,51);
          ChLine2.Checked =  new BLL.TimeLine.csTimeLine().SlTimeLineMachineLastStatus( BLL.csshamsidate.shamsidate,52);
          CHLine3.Checked =  new BLL.TimeLine.csTimeLine().SlTimeLineMachineLastStatus( BLL.csshamsidate.shamsidate,53);
        }
    }
}
