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
    public partial class frmProcurmentSalesProduct : Form
    {
        public frmProcurmentSalesProduct()
        {
            InitializeComponent();
            uc_TextBoxDate1.Text = date;
            BLL.csProcurement cs = new BLL.csProcurement();
            dt_PS = cs.SelectProcurmentSalesProductByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            generateForm();
        }
        DAL.DataSet_Procurement.SelectProcurmentSalesProductByDate1DataTable dt_PS;
        private string date = BLL.csshamsidate.shamsidate;

        private void generateForm()
        {
            BLL.csProcurement pr = new BLL.csProcurement();

            uc_txtDraftNumber.Text = (pr.MaxDraftNumbers() + 1).ToString();

            BLL.csCompony cm = new BLL.csCompony();
            uc_cmbAutoCustomer.uc_cmbAuto1.DataSource = cm.SelectCustomer();
            uc_cmbAutoCustomer.uc_cmbAuto1.DisplayMember = "xComponyName";
            uc_cmbAutoCustomer.uc_cmbAuto1.ValueMember = "x_";
            uc_cmbAutoCustomer.uc_cmbAuto1.SelectedIndex = -1;
            uc_cmbAutoCustomer.ParamName = new string[] { "xComponyName" };
            uc_cmbAutoCustomer.ParamValue = new string[] { "نام شرکت" };
            uc_cmbAutoCustomer.ParamHide = new string[] { "x_", "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
               "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};


            BLL.csPieces cp = new BLL.csPieces();

            uc_cmbAutoPieces.uc_cmbAuto1.DataSource = cp.mPiecesDataTable();
            uc_cmbAutoPieces.uc_cmbAuto1.DisplayMember = "xName";
            uc_cmbAutoPieces.uc_cmbAuto1.ValueMember = "x_";
            uc_cmbAutoPieces.uc_cmbAuto1.SelectedIndex = -1;
            uc_cmbAutoPieces.ParamName = new string[] { "xName" };
            uc_cmbAutoPieces.ParamValue = new string[] { "نام قطعه" };
            uc_cmbAutoPieces.ParamHide = new string[] { "x_", "xKind" ,"xStandard","xPieceweight","xTechnicalname","xSolutionweight","xKbythtotal",
               "xImage","xMarkettype","xMusclekhoury"};
            //dt_PS.Columns.Add("x_", typeof(int));
            //dt_PS.Columns.Add("xShift", typeof(string));
            //dt_PS.Columns.Add("xDate", typeof(string));
            //dt_PS.Columns.Add("xDarftNumber", typeof(string));
            //dt_PS.Columns.Add("xPieces_", typeof(int));
            //dt_PS.Columns.Add("xPieces", typeof(string));
            //dt_PS.Columns.Add("xPackingType", typeof(string));
            //dt_PS.Columns.Add("xCount", typeof(int));
            //dt_PS.Columns.Add("xWeight", typeof(int));
            //dt_PS.Columns.Add("xDriverName", typeof(string));
            //dt_PS.Columns.Add("xDriverTel", typeof(string));
            //dt_PS.Columns.Add("xlicenseCar", typeof(string));
            //dt_PS.Columns.Add("xCustomer_", typeof(int));
            //dt_PS.Columns.Add("xCustomer", typeof(string));
            //dt_PS.Columns.Add("xComment", typeof(string));

            bindingSource1.DataSource = dt_PS;
            dataGridView1.DataSource = bindingSource1;

            //string xDarftNumber, int xPieces_, string xPackingType, int xCount, int xWeight, string xDriverName, string xDriverTel, string xlicenseCar, int xCustomer_,
            //string xComment
            dataGridView1.Columns["xShift"].HeaderText = "شیفت";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xDarftNumber"].HeaderText = "شماره حواله";
            dataGridView1.Columns["xPieces"].HeaderText = "نوع محصول";
            dataGridView1.Columns["xPackingType"].HeaderText = "نوع بسته بندی";
            dataGridView1.Columns["xCount"].HeaderText = "تعداد";
            dataGridView1.Columns["xWeight"].HeaderText = "وزن";
            dataGridView1.Columns["xDriverName"].HeaderText = "نام راننده";
            dataGridView1.Columns["xDriverTel"].HeaderText = "تلفن";
            dataGridView1.Columns["xlicenseCar"].HeaderText = "شماره پلاک";
            dataGridView1.Columns["xCustomer"].HeaderText = "تحویل گیرنده";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xRent"].HeaderText = "کرایه";
            dataGridView1.Columns["xPieces_"].Visible = false;
            dataGridView1.Columns["xCustomer"].Visible = false;
            dataGridView1.Columns["xPieces"].Visible = false;
            dataGridView1.Columns["xShift"].Visible = false;
            dataGridView1.Columns["xCustomer_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["x_"].Visible = false;

            DataGridViewComboBoxColumn combobox_xCustomer_ = new DataGridViewComboBoxColumn();
            combobox_xCustomer_.DisplayIndex = 3;
            combobox_xCustomer_.HeaderText = "مشتری";
            combobox_xCustomer_.DataSource = cm.SelectCustomer();
            combobox_xCustomer_.DisplayMember = "xComponyName";
            combobox_xCustomer_.ValueMember = "x_";
            combobox_xCustomer_.DataPropertyName = "xCustomer_";
            dataGridView1.Columns.Add(combobox_xCustomer_);

            BLL.csPieces crp = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn();
            combobox_xPieces_.DisplayIndex = 4;
            combobox_xPieces_.HeaderText = "نوع قطعه";
            combobox_xPieces_.DataSource = crp.mPiecesDataTable();
            combobox_xPieces_.DisplayMember = "xName";
            combobox_xPieces_.ValueMember = "x_";
            combobox_xPieces_.DataPropertyName = "xPieces_";
            dataGridView1.Columns.Add(combobox_xPieces_);

            DataGridViewComboBoxColumn combobox_Shift = new DataGridViewComboBoxColumn();
            combobox_Shift.DisplayIndex = 1;
            combobox_Shift.HeaderText = "شیفت";
            combobox_Shift.Items.Add("صبح   ");
            combobox_Shift.Items.Add("عصر   ");
            combobox_Shift.Items.Add("شب    ");
            combobox_Shift.DataPropertyName = "xShift";
            dataGridView1.Columns.Add(combobox_Shift);

            DataGridViewComboBoxColumn combobox_xPackingType = new DataGridViewComboBoxColumn();
            combobox_xPackingType.DisplayIndex = 2;
            combobox_xPackingType.HeaderText = "نوع بسته بندی";
            combobox_xPackingType.Items.Add("پالت استریج");
            combobox_xPackingType.Items.Add("گونی");
            combobox_xPackingType.Items.Add("کیلویی");
            combobox_xPackingType.Items.Add("پالت");

            combobox_xPackingType.DataPropertyName = "xPackingType";
            dataGridView1.Columns.Add(combobox_xPackingType);

            bindingNavigator1.BindingSource = bindingSource1;
            toolStripTextBoxDateFrom.Text = date;
            toolStripTextBoxDateTo.Text = date;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (FillRight())
            AdddatagirdView();
        }

        private void AdddatagirdView()
        {
            // x_, xSupplier_, xShift, xDate, xDarftNumber, xPieces_, xPackingType, xCount, xWeight, xDriverName, xDriverTel, xlicenseCar, xCustomer_, xApprove, 

            DataRow dr_Prc = dt_PS.NewRow();
            dr_Prc["xSupplier_"] = BLL.authentication.x_;
            dr_Prc["xShift"] = uc_cmbAuto_Shift.Text;
            dr_Prc["xDate"] = uc_TextBoxDate1.Text;
            dr_Prc["xDarftNumber"] =uc_txtDraftNumber.Text;
            dr_Prc["xPieces"] = (int)uc_cmbAutoPieces.uc_cmbAuto1.SelectedValue;
            dr_Prc["xPieces_"] = (int)uc_cmbAutoPieces.uc_cmbAuto1.SelectedValue;
            dr_Prc["xPackingType"] = uc_cmbAutoPackingType.Text;
            dr_Prc["xCount"] = int.Parse(uc_txtCount.textWithoutcomma == null ? "0" : uc_txtCount.textWithoutcomma);
            dr_Prc["xWeight"] = int.Parse(uc_txtWeight.textWithoutcomma == null ? "0" : uc_txtWeight.textWithoutcomma);
            dr_Prc["xDriverName"] = uc_txtDriverName.Text;
            dr_Prc["xDriverTel"] = uc_txtDriverTel.Text;
            dr_Prc["xlicenseCar"] = uc_txtLicenseCar.Text;
            dr_Prc["xCustomer"] = uc_cmbAutoCustomer.Text;
            dr_Prc["xRent"] = int.Parse(uc_txtBox_Rent.textWithoutcomma == null ? "0" : uc_txtBox_Rent.textWithoutcomma);
            dr_Prc["xCustomer_"] = (int)uc_cmbAutoCustomer.uc_cmbAuto1.SelectedValue;
            dr_Prc["xComment"] = uc_txtComment.Text;
           // dr_Prc["xApprove"] = false;
            dt_PS.Rows.Add(dr_Prc);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (FillRight())
            AdddatagirdView();

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            BLL.csProcurement cs = new BLL.csProcurement();
            this.Validate();
            this.bindingSource1.EndEdit();
            if (cs.InsertProcurmentSalesProduct(dt_PS))
            {
                MessageBox.Show("ارسال با موفقیت انجام شد.");
                this.Close();
            }
            else
                MessageBox.Show("شما مجوز ارسال نداریند.");
            dt_PS = cs.SelectProcurmentSalesProductByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            RefreshForm();
            //if (show)
            //{

            //    if (cs.UpdateProcurmentSalesProduct(uc_cmbAuto_Shift.Text, uc_mtxtDate1.Text, uc_txtDraftNumber.Text, (int)uc_cmbAutoPieces.SelectedValue, uc_cmbAutoPackingType.Text,
            //         int.Parse(uc_txtCount.Text), int.Parse(uc_txtWeight.Text), uc_txtDriverName.Text, uc_txtDriverTel.Text, uc_txtLicenseCar.Text, (int)uc_cmbAutoCustomer.SelectedValue,
            //         uc_txtComment.Text, x_Selected))
            //    {

            //        MessageBox.Show("ارسال با موفقیت انجام شد");
            //        ShowStripButton_Click(null, null);
            //    }
            //    else
            //        MessageBox.Show("خطا در ارسال");

            //}
            //else
            //{
            //    if (!FillRight()) return;



            //    if (cs.InsertProcurmentSalesProduct(dt_PS))
            //        MessageBox.Show("ارسال با موفقیت انجام شد.");
            //    else
            //        MessageBox.Show("شما مجوز ارسال نداریند.");
            //    RefreshForm();
            //}

        }


        private void RefreshForm()
        {

            foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                item.Text = "";
            }
            foreach (ControlLibrary.uc_combobox item in groupBox1.Controls.OfType<ControlLibrary.uc_combobox>())
            {
                item.SelectedIndex = -1;
            }
        }

        private bool FillRight()
        {
            bool flag = true;
            flag = uc_TextBoxDate1.accept & flag;

            BLL.csProcurement pr = new BLL.csProcurement();
            if (int.Parse(uc_txtDraftNumber.Text) < pr.MaxDraftNumbers())
            {
                MessageBox.Show("شماره حواله نادرست می باشد.");
                return false;
            }
            foreach (ControlLibrary.uc_txtBox item in groupBox1.Controls.OfType<ControlLibrary.uc_txtBox>())
            {
                if (item.IsNumber == true && item.Text == "")
                    item.Text = "0";
            }
            //////////////
            foreach (ControlLibrary.uc_cmbAuto item in groupBox1.Controls.OfType<ControlLibrary.uc_cmbAuto>())
            {
                if (item.SelectedIndex < 0)
                {
                    MessageBox.Show("اطلاعات را به طور کامل وارد کنید.");
                    return false;
                }

            }
            ////////////////////
            return flag;
        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {
            RefreshForm();
            BLL.csProcurement cs = new BLL.csProcurement();
            dt_PS.Clear();

            BLL.csshamsidate dateshamsi = new BLL.csshamsidate();
            string previousWeek = dateshamsi.previousDay(10);

            if (dateshamsi.CompareDate(toolStripTextBoxDateFrom.Text, previousWeek))
            dt_PS = cs.SelectProcurmentSalesProductByDate(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            else
                dt_PS = cs.SelectProcurmentSalesProductByDate(previousWeek, toolStripTextBoxDateTo.Text);

            bindingSource1.DataSource = dt_PS;
            dataGridView1.DataSource = bindingSource1;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
           // groupBox1.Enabled = true;
            //show = false;
            //RefreshForm();
            //dataGridView1.Columns.Clear();
            //generateForm();
        }

        int x_Selected = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
                return;
            x_Selected = (int)dataGridView1["x_", e.RowIndex].Value;
            uc_cmbAuto_Shift.Text = dataGridView1["xShift", e.RowIndex].Value.ToString();
            uc_TextBoxDate1.Text = dataGridView1["xDate",e.RowIndex].Value.ToString();
            uc_txtDraftNumber.Text = dataGridView1["xDarftNumber", e.RowIndex].Value.ToString();
            uc_cmbAutoPackingType .Text = dataGridView1["xPackingType", e.RowIndex].Value.ToString();
            uc_txtCount.Text = dataGridView1["xCount", e.RowIndex].Value.ToString();
            uc_txtWeight.Text = dataGridView1["xWeight", e.RowIndex].Value.ToString();
            uc_txtDriverName.Text = dataGridView1["xDriverName", e.RowIndex].Value.ToString();
            uc_txtDriverTel.Text = dataGridView1["xDriverTel", e.RowIndex].Value.ToString();
            uc_txtLicenseCar.Text = dataGridView1["xlicenseCar", e.RowIndex].Value.ToString();
            uc_txtComment.Text = dataGridView1["xComment", e.RowIndex].Value.ToString();
            uc_cmbAutoPieces.Text = dataGridView1["xPieces", e.RowIndex].Value.ToString();
            uc_cmbAutoCustomer.Text = dataGridView1["xCustomer", e.RowIndex].Value.ToString();
        }


    }

}