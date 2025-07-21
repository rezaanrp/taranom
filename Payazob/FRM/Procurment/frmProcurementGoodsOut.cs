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
    public partial class frmProcurementGoodsOut : Form
    {


        public frmProcurementGoodsOut()
        {
            InitializeComponent();
            uc_mtxtDate1.Text = date;
            BLL.csProcurement cs = new BLL.csProcurement();
            dt_P = cs.SelectProcurmentGoodsOutByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            generateForm();
        }

        DAL.DataSet_Procurement.SelectProcurementGoodsOutByDateDataTable dt_P;
        string date = BLL.csshamsidate.shamsidate;
        private void generateForm()
        {
            //x_, xApprove_, xShift, xDate, xGoods, xCount, xModule_, xPersonNameGoodsOut, xCarNumber, xLicensorsName, xComment 

            BLL.csProcurement pr = new BLL.csProcurement();
            uc_cmbAutoGoodsName.DataSource = pr.SelectProcurementGoodsNameOut();
            uc_cmbAutoGoodsName.ValueMember = "xGoods";
            uc_cmbAutoGoodsName.DisplayMember = "xGoods";
            uc_cmbAutoGoodsName.SelectedIndex = -1;

            uc_cmbAutoLisencor.DataSource = pr.SelectProcurementLicensorsNameGoodsOut();
            uc_cmbAutoLisencor.ValueMember = "xLicensorsName";
            uc_cmbAutoLisencor.DisplayMember = "xLicensorsName";
            uc_cmbAutoLisencor.SelectedIndex = -1;

            uc_cmbAutoPersonsGoodsOut.DataSource = pr.SelectProcurementPersonNameGoodsOut();
            uc_cmbAutoPersonsGoodsOut.ValueMember = "xPersonNameGoodsOut";
            uc_cmbAutoPersonsGoodsOut.DisplayMember = "xPersonNameGoodsOut";
            uc_cmbAutoPersonsGoodsOut.SelectedIndex = -1;

            uc_cmbAutoModule.DataSource = pr.SelectMudole();
            uc_cmbAutoModule.DisplayMember = "xModuleName";
            uc_cmbAutoModule.ValueMember = "x_";
            uc_cmbAutoModule.SelectedIndex = -1;



            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            
            dataGridView1.Columns["xShift"].HeaderText = "شیفت";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xGoods"].HeaderText = "نام جنس";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xModule"].HeaderText = "واحد";
            dataGridView1.Columns["xCarNumber"].HeaderText = "شماره ماشین";
            dataGridView1.Columns["xLicensorsName"].HeaderText = "نام مجوزدهنده";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xLicenseNumber"].HeaderText = "شماره مجوز";
            dataGridView1.Columns["xPersonNameGoodsOut"].HeaderText = "نام خارج کننده مواد";
            dataGridView1.Columns["xModule_"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;
          //  dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            toolStripTextBoxDateFrom.Text = date;
            toolStripTextBoxDateTo.Text = date;
        }

        private void AdddatagirdView()
        {

            if (!FillRight())
            {

                return;
            }
            
            //x_, xApprove_, xShift, xDate, xGoods, xCount, xModule_, xPersonNameGoodsOut, xCarNumber, xLicensorsName, xComment 
            DataRow dr_Prc = dt_P.NewRow();
            dr_Prc["xApprove_"] = BLL.authentication.x_;
            dr_Prc["xShift"] = cmbAuto_Shift.Text;
            dr_Prc["xModule"] = (int)uc_cmbAutoModule.SelectedValue;
            dr_Prc["xDate"] = uc_mtxtDate1.Text;
            dr_Prc["xGoods"] = uc_cmbAutoGoodsName.Text;
            dr_Prc["xCount"] = decimal.Parse( uc_txtCount.Text);
            dr_Prc["xModule_"] = (int)uc_cmbAutoModule.SelectedValue;
            dr_Prc["xPersonNameGoodsOut"] = uc_cmbAutoPersonsGoodsOut.Text;
            dr_Prc["xCarNumber"] = uc_txtCar.Text;
            dr_Prc["xLicensorsName"] = uc_cmbAutoLisencor.Text;
            dr_Prc["xLicenseNumber"] = uc_txtLicensNumber.Text;
            dr_Prc["xComment"] = uc_txtComment.Text;
            dt_P.Rows.Add(dr_Prc);

        }

        private void frmProcurementGoodsOut_Load(object sender, EventArgs e)
        {

        }

        private bool FillRight()
        {
          bool flag = true;
          flag = uc_mtxtDate1.accept & flag;
          if (uc_txtCount.Text == "")
              uc_txtCount.Text = "0";
          foreach (ControlLibrary.uc_cmbAuto item in groupBox1.Controls.OfType<ControlLibrary.uc_cmbAuto>())
          {
              if (item == uc_cmbAutoModule || item == cmbAuto_Shift)
              {
                  if (uc_cmbAutoModule.SelectedIndex < 0 || cmbAuto_Shift.SelectedIndex < 0 || uc_txtCount.Text == "")
                  {
                      MessageBox.Show("اطلاعات را به طور کامل وارد کنید.");
                      return false;
                  }
                  continue;
              }
              if (item.SelectedIndex < 0)
              {
                  if (item.Text != "")
                  {
                      if (MessageBox.Show(item.Text + " در لیست وجود ندارد ایا می خواهیند آن را به پایگاه داده اضافه کنید " , "", MessageBoxButtons.YesNo) == DialogResult.No)
                          return false;

                  }
                  else
                      flag = false;
              }
          }
          return flag;
        }

        private void RefreshForm()
        {
            BLL.csProcurement pr = new BLL.csProcurement();
            uc_cmbAutoGoodsName.DataSource = pr.SelectProcurementGoodsNameOut();
            uc_cmbAutoGoodsName.ValueMember = "xGoods";
            uc_cmbAutoGoodsName.DisplayMember = "xGoods";
            uc_cmbAutoGoodsName.SelectedIndex = -1;

            uc_cmbAutoLisencor.DataSource = pr.SelectProcurementLicensorsNameGoodsOut();
            uc_cmbAutoLisencor.ValueMember = "xLicensorsName";
            uc_cmbAutoLisencor.DisplayMember = "xLicensorsName";
            uc_cmbAutoLisencor.SelectedIndex = -1;

            uc_cmbAutoPersonsGoodsOut.DataSource = pr.SelectProcurementPersonNameGoodsOut();
            uc_cmbAutoPersonsGoodsOut.ValueMember = "xPersonNameGoodsOut";
            uc_cmbAutoPersonsGoodsOut.DisplayMember = "xPersonNameGoodsOut";
            uc_cmbAutoPersonsGoodsOut.SelectedIndex = -1;

            uc_cmbAutoModule.DataSource = pr.SelectMudole();
            uc_cmbAutoModule.DisplayMember = "xModuleName";
            uc_cmbAutoModule.ValueMember = "x_";
            uc_cmbAutoModule.SelectedIndex = -1;

            foreach (UC.uc_TextBox item in groupBox1.Controls.OfType<UC.uc_TextBox>())
            {
                item.Text = "";
            }
          
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataGridView1.EndEdit();

           // if (show)
           //     return;

            //if (!FillRight())
            //{

            //    return;
            //}

            BLL.csProcurement cs = new BLL.csProcurement();
            if (cs.UpdateProcurementGoodsOut(dt_P))
            {
             
                MessageBox.Show("ارسال با موفقیت انجام شد.");
                this.Close();
            }
            else
                MessageBox.Show("شما مجوز ارسال نداریند.");


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            AdddatagirdView();
        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {
            RefreshForm();
            BLL.csProcurement cs = new BLL.csProcurement();
            dt_P.Clear();

            BLL.csshamsidate dateshamsi = new BLL.csshamsidate();
            string previousWeek = dateshamsi.previousDay(10);

            if (dateshamsi.CompareDate(toolStripTextBoxDateFrom.Text, previousWeek))
                dt_P = cs.SelectProcurmentGoodsOutByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            else
                dt_P = cs.SelectProcurmentGoodsOutByDate(previousWeek, toolStripTextBoxDateTo.Text);

            dataGridView1.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bindingSource1.DataSource = dt_P;
            dataGridView1.DataSource = bindingSource1;


        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            //show = false;
            //RefreshForm();
            //dataGridView1.Columns.Clear();
            //dt_P = new DataTable();
            //generateForm();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            AdddatagirdView();

        }



    }
}
