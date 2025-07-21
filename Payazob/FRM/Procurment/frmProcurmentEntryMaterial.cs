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
    public partial class frmProcurmentEntryMaterial : Form
    {
        public frmProcurmentEntryMaterial()
        {

            InitializeComponent();
            uc_TextBoxDate1.Text = date;

            BLL.csProcurement cs = new BLL.csProcurement();
            dt_PE = new DAL.DataSet_Procurement.SelectProcurmentEnteryMaterialDataTable();
            generateForm();

        }
        private string date = BLL.csshamsidate.shamsidate;
        DAL.DataSet_Procurement.SelectProcurmentEnteryMaterialDataTable dt_PE;

        private void generateForm()
        {
            BLL.csMaterial csm = new BLL.csMaterial();
            BLL.csProcurement pr = new BLL.csProcurement();
            uc_cmbAutoMatrilal.uc_cmbAuto1.DataSource = csm.SlectMatreilAndScarb();
            uc_cmbAutoMatrilal.uc_cmbAuto1.ValueMember = "x_";
            uc_cmbAutoMatrilal.uc_cmbAuto1.DisplayMember = "xMaterialName";
            uc_cmbAutoMatrilal.uc_cmbAuto1.SelectedIndex = -1;

            uc_cmbAutoMatrilal.ParamName = new string[] { "xMaterialName" };
            uc_cmbAutoMatrilal.ParamValue = new string[] { "نام مواد" };
            uc_cmbAutoMatrilal.ParamHide = new string[] { "x_"};

            uc_cmbAutoModule.DataSource = pr.SelectMudole();
            uc_cmbAutoModule.DisplayMember = "xModuleName";
            uc_cmbAutoModule.ValueMember = "x_";
            uc_cmbAutoModule.SelectedIndex = -1;

            BLL.csCompony cm = new BLL.csCompony();
            uc_cmbAutoxSupplier.uc_cmbAuto1.DataSource = cm.SelectSupplier();
            uc_cmbAutoxSupplier.uc_cmbAuto1.DisplayMember = "xComponyName";
            uc_cmbAutoxSupplier.uc_cmbAuto1.ValueMember = "x_";
            uc_cmbAutoxSupplier.uc_cmbAuto1.SelectedIndex = -1;

            uc_cmbAutoxSupplier.ParamName = new string[] { "xComponyName" };
            uc_cmbAutoxSupplier.ParamValue = new string[] { "نام شرکت" };
            uc_cmbAutoxSupplier.ParamHide = new string[] { "x_", "xAddress" ,"xTel","xFax","xEmail","xWebsite","xSupplyManager",
               "xSupplyManagerTel","xDirectorFactor","xDirectorFactorTel"};

            bindingSource1.DataSource = dt_PE;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            dataGridView1.Columns["xShift"].HeaderText = "شیفت";
            dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView1.Columns["xSupplier"].HeaderText = "تامین کننده";
            dataGridView1.Columns["xMaterialType"].HeaderText = "نوع مواد";
            dataGridView1.Columns["xDriverName"].HeaderText = "نام راننده";
            dataGridView1.Columns["xDriverTel"].HeaderText = "شماره تلفن";
            dataGridView1.Columns["xWeightBeginning"].HeaderText = "وزن مبدا";
            dataGridView1.Columns["xModule"].HeaderText = "واحد";
            dataGridView1.Columns["xWeightDestination"].HeaderText = "وزن مقصد";
            dataGridView1.Columns["xRent"].HeaderText = "کرایه";
            dataGridView1.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView1.Columns["xModule_"].Visible = false;
            dataGridView1.Columns["xModule"].Visible = false;
            dataGridView1.Columns["xApprove_"].Visible = false;
            dataGridView1.Columns["Approve"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xSupplier"].Visible = false;
            dataGridView1.Columns["xMaterialType"].Visible = false;
            dataGridView1.Columns["xMaterialType_"].Visible = false;


            DataGridViewComboBoxColumn combobox_xModule_ = new DataGridViewComboBoxColumn();
            combobox_xModule_.DisplayIndex = 11;
            combobox_xModule_.HeaderText = "واحد";
            combobox_xModule_.DataSource = pr.SelectMudole();
            combobox_xModule_.DisplayMember = "xModuleName";
            combobox_xModule_.ValueMember = "x_";
            combobox_xModule_.DataPropertyName = "xModule_";
            dataGridView1.Columns.Add(combobox_xModule_);


            DataGridViewComboBoxColumn combobox_xSupplier_ = new DataGridViewComboBoxColumn();
            combobox_xSupplier_.DisplayIndex = 3;
            combobox_xSupplier_.HeaderText = "تامین کننده";
            combobox_xSupplier_.DataSource = cm.SelectSupplier();
            combobox_xSupplier_.DisplayMember = "xComponyName";
            combobox_xSupplier_.ValueMember = "x_";
            combobox_xSupplier_.DataPropertyName = "xSupplier_";
            dataGridView1.Columns.Add(combobox_xSupplier_);

            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 4;
            combobox_xMaterialType_.HeaderText = "نوع مواد";
            combobox_xMaterialType_.DataSource = pr.SelectMaterial();
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xMaterialType_";
            dataGridView1.Columns.Add(combobox_xMaterialType_);

            combobox_xModule_.ValueType = typeof(int);
            dataGridView1.Columns["x_"].Visible = false;
            toolStripTextBoxDateFrom.Text = date;
            toolStripTextBoxDateTo.Text = date;
        }

        private void AdddatagirdView()
        {
            DataRow dr_Prc = dt_PE.NewRow();
            dr_Prc["xApprove_"] = BLL.authentication.x_;
            dr_Prc["xShift"] = cmbAuto_Shift.Text;
            dr_Prc["xDate"] = uc_TextBoxDate1.Text;
            dr_Prc["xMaterialType_"] = uc_cmbAutoMatrilal.uc_cmbAuto1.SelectedValue;
            dr_Prc["xMaterialType"] = uc_cmbAutoMatrilal.Text;
            dr_Prc["xSupplier"] = uc_cmbAutoxSupplier.Text;
            dr_Prc["xSupplier_"] = uc_cmbAutoxSupplier.uc_cmbAuto1.SelectedValue;
            dr_Prc["xDriverName"] = uc_txtDriverName.Text;
            dr_Prc["xDriverTel"] = uc_txtCarNumber.Text;
            dr_Prc["xWeightBeginning"] = uc_txtWeightBeginning.Text;
            dr_Prc["xWeightDestination"] = uc_txtWeightDistination.Text;
            dr_Prc["xModule"] = uc_cmbAutoModule.Text;
            dr_Prc["xModule_"] = uc_cmbAutoModule.SelectedValue;
            dr_Prc["xRent"] = int.Parse( uc_txtRent.Text);
            dr_Prc["xComment"] = uc_txtComment.Text;
            dt_PE.Rows.Add(dr_Prc);

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (FillRight())
                AdddatagirdView();
            RefreshForm();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            BLL.csProcurement cs = new BLL.csProcurement();
            this.Validate();
            this.bindingSource1.EndEdit();
            if (cs.InsertProcurmentEnteryMaterial(dt_PE))
            {
                MessageBox.Show("ارسال با موفقیت انجام شد.");
                this.Close();
            }
            else
                MessageBox.Show("شما مجوز ارسال نداریند.");
            dt_PE = cs.SelectProcurmentEnteryMaterial(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            RefreshForm();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
             if(FillRight())
            AdddatagirdView();
        }

        private void RefreshForm()
        {
            
            foreach (UC.uc_TextBox item in groupBox1.Controls.OfType<UC.uc_TextBox>())
            {
                item.Text = "";
            }
            //BLL.csProcurement cs = new BLL.csProcurement();

            //dt_PE.Clear();
            ////dt_PE = cs.SelectProcurmentEnteryMaterial(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            //bindingSource1.DataSource = dt_PE;
            //dataGridView1.DataSource = bindingSource1;
            //bindingNavigator1.BindingSource = bindingSource1;
        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {

            RefreshForm();
            BLL.csProcurement cs = new BLL.csProcurement();
            dt_PE.Clear();

            BLL.csshamsidate dateshamsi = new BLL.csshamsidate();
            string previousWeek = dateshamsi.previousDay(10);

             if( dateshamsi.CompareDate(toolStripTextBoxDateFrom.Text ,previousWeek))
               dt_PE = cs.SelectProcurmentEnteryMaterial(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            else
               dt_PE = cs.SelectProcurmentEnteryMaterial(previousWeek, toolStripTextBoxDateTo.Text);

            bindingSource1.DataSource = dt_PE;
            dataGridView1.DataSource = bindingSource1;
        }

        private bool FillRight()
        {
            bool flag = true;
            flag = uc_TextBoxDate1.accept & flag;


            foreach (UC.uc_TextBox item in groupBox1.Controls.OfType<UC.uc_TextBox>())
            {
                if(item.IsNumber == true && item.Text == "")
                     item.Text = "0";
            }
            foreach (ControlLibrary.uc_cmbAuto item in groupBox1.Controls.OfType<ControlLibrary.uc_cmbAuto>())
            {
                if (item.SelectedIndex < 0)
                {
                        MessageBox.Show("اطلاعات را به طور کامل وارد کنید.");
                        return false;
                }

            }
            return flag;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           if (dataGridView1.SelectedRows.Count > 1)
                return;
            cmbAuto_Shift.Text = dataGridView1["xShift", e.RowIndex].Value.ToString();
            uc_TextBoxDate1.Text =dataGridView1["xDate",e.RowIndex].Value.ToString();
            uc_cmbAutoMatrilal.uc_cmbAuto1.SelectedValue =dataGridView1["xMaterialType_",e.RowIndex].Value;  
            uc_cmbAutoMatrilal.Text = dataGridView1["xMaterialType",e.RowIndex].Value.ToString();  
            uc_cmbAutoxSupplier.Text= dataGridView1["xSupplier",e.RowIndex].Value.ToString();  
            uc_cmbAutoxSupplier.uc_cmbAuto1.SelectedValue = dataGridView1["xSupplier_",e.RowIndex].Value;  
            uc_txtDriverName.Text = dataGridView1["xDriverName",e.RowIndex].Value.ToString();  
            uc_txtCarNumber.Text = dataGridView1["xDriverTel",e.RowIndex].Value.ToString();  
            uc_txtWeightBeginning.Text = dataGridView1["xWeightBeginning",e.RowIndex].Value.ToString();  
            uc_txtWeightDistination.Text = dataGridView1["xWeightDestination",e.RowIndex].Value.ToString();  
            uc_cmbAutoModule.Text= dataGridView1["xModule",e.RowIndex].Value.ToString();  
            uc_cmbAutoModule.SelectedValue =  dataGridView1["xModule_",e.RowIndex].Value;  
            uc_txtRent.Text = dataGridView1["xRent",e.RowIndex].Value.ToString();  
            uc_txtComment.Text = dataGridView1["xComment",e.RowIndex].Value.ToString();
        }


    }
}
