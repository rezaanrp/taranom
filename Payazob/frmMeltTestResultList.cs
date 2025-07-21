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
    public partial class frmMeltTestResultList : Form
    {
        public frmMeltTestResultList()
        {
            InitializeComponent();
            BLL.csMeltTestResult cs = new BLL.csMeltTestResult();

            toolStripTextBoxDateFrom.Text = BLL.csshamsidate.shamsidate;
            toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;

            dt_I_S = cs.SelectCharacteristicMaterialPurchaseIsScrab("-1", "-1");
            dt_D_B = cs.SelectAnalysisMaterial(-1, true);
            dt_D_A = cs.SelectAnalysisMaterial(-1, false);

            generateForm_I();
            generateForm_D_A();
            generateForm_D_B();
        }

        DAL.CharacterusticMaterial.DataSet_CharacterusticMaterial.SelectCharacteristicMaterialPurchaseDataTable dt_I;
        DAL.CharacterusticMaterial.DataSet_CharacterusticMaterial.SelectCharacteristicMaterialPurchaseIsScrabDataTable dt_I_S;
        DAL.CharacterusticMaterial.DataSet_CharacterusticMaterial.SelectAnalysisMaterialDataTable dt_D_B;
        DAL.CharacterusticMaterial.DataSet_CharacterusticMaterial.SelectAnalysisMaterialDataTable dt_D_A;


        private void generateForm_I()
        {

            BLL.csMaterial cs = new BLL.csMaterial();

            DataGridViewComboBoxColumn combobox_Material_ = new DataGridViewComboBoxColumn();
            combobox_Material_.HeaderText = "نام مواد اولیه";
            combobox_Material_.DataSource = cs.SelectMeltName(chb_Scarb.Checked);
            combobox_Material_.DisplayMember = "xMaterialName";
            combobox_Material_.ValueMember = "x_";
            combobox_Material_.DataPropertyName = "xMaterialName_";
            combobox_Material_.Name = "xMaterialName_";
            dataGridView1.Columns.Add(combobox_Material_);

            BLL.csCompony cs_Supplier = new BLL.csCompony();
            DataGridViewComboBoxColumn combobox_Supplier_ = new DataGridViewComboBoxColumn();
            combobox_Supplier_.HeaderText = "نام تامین کننده";
            combobox_Supplier_.DataSource = cs_Supplier.SelectSupplier();
            combobox_Supplier_.DisplayMember = "xComponyName";
            combobox_Supplier_.ValueMember = "x_";
            combobox_Supplier_.DataPropertyName = "xSupplierCompany_";
            combobox_Supplier_.Name = "xSupplierCompany_";
            dataGridView1.Columns.Add(combobox_Supplier_);



            DataTable dt = new DataTable();
            dt.Columns.Add("State",typeof(string));
            dt.Columns.Add("Value", typeof(byte));

            DataRow dr = dt.NewRow();
            dr["State"] = "قبول";
            dr["Value"] = 1;
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["State"] = "رد";
            dr1["Value"] = 0;
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["State"] = "مشروط";
            dr2["Value"] = 2;
            dt.Rows.Add(dr2);

            DataGridViewComboBoxColumn combobox_State = new DataGridViewComboBoxColumn();
            combobox_State.HeaderText = "وضعیت";
            combobox_State.DataSource = dt;
            combobox_State.DisplayMember = "State";
            combobox_State.ValueMember = "Value";
            combobox_State.DataPropertyName = "xAccept";
            combobox_State.Name = "Accept";
            dataGridView1.Columns.Add(combobox_State);


            combobox_Supplier_.DisplayIndex = 1;
            combobox_Material_.DisplayIndex = 1;

            // برای قراضه
            if (!chb_Scarb.Checked)
            {
                dataGridView1.DataSource = dt_I;
                bindingSource_S.DataSource = dataGridView1.DataSource;
                dataGridView1.Columns["xUsage"].HeaderText = "مقدار مصرف";
                dataGridView1.Columns["xUsageMeltingAmount"].HeaderText = "میزان ذوب مصرفی";
                dataGridView1.Columns["xAbsorptionPercent"].HeaderText = "در صد جذب";
                bindingNavigator1.BindingSource = bindingSource_S;

            }
            // برای مواد اولیه غیر از قراضه
            else
            {
                dataGridView1.DataSource = dt_I_S;
                bindingSource1.DataSource = dataGridView1.DataSource;
                dataGridView1.Columns["xVisualScore"].HeaderText = "امتیاز ظاهری";
                dataGridView1.Columns["xExperimentalScore"].HeaderText = "امتیاز آزمایش";
                dataGridView1.Columns["xMaximumScore"].HeaderText = "حداکثر امتیاز";
                dataGridView1.Columns["xGradeProduct"].HeaderText = "درجه محصول";
                bindingNavigator1.BindingSource = bindingSource1;

            }


            dataGridView1.Columns["xDateEnter"].HeaderText = "تاریخ ورود";
            dataGridView1.Columns["xDateResult"].HeaderText = "تاریخ نتایج";
            dataGridView1.Columns["xDateTest"].HeaderText = "تاریخ آزمایش";
            dataGridView1.Columns["xApprove"].HeaderText = "تایید شده";
            dataGridView1.Columns["xSupplierCompany_"].HeaderText = "شرکت تامین کننده";
            dataGridView1.Columns["xMaterialName_"].Visible = false;
            dataGridView1.Columns["Accept"].Visible = false;
            dataGridView1.Columns["xSupplierCompany_"].Visible = false;
            dataGridView1.Columns["xVisualCharacteristic"].HeaderText = "مشخصات ظاهری";
            dataGridView1.Columns["xApprove_"].HeaderText = "تایید کننده";
            dataGridView1.Columns["xDateEnter"].ReadOnly = true;
            dataGridView1.Columns["xDateResult"].ReadOnly = true;
            dataGridView1.Columns["xDateTest"].ReadOnly = true;
            dataGridView1.Columns["xApprove_"].ReadOnly = true;

            if (BLL.authentication.x_ != BLL.authentication.xApproveby_)
                dataGridView1.Columns["xApprove"].ReadOnly = true;
            else
                dataGridView1.Columns["xApprove"].ReadOnly = false;

            dataGridView1.Columns["x_"].Visible = false;


            if (BLL.authentication.x_ != BLL.authentication.xApproveby_)
                dataGridView1.Columns["xApprove"].ReadOnly = true;


        }

        private void generateForm_D_A()
        {


            BLL.csElement cs = new BLL.csElement();

            DataGridViewComboBoxColumn combobox_Element_ = new DataGridViewComboBoxColumn();
            combobox_Element_.HeaderText = "نام عنصر";
            combobox_Element_.DataSource = cs.SelectElement();
            combobox_Element_.DisplayMember = "xNameElement";
            combobox_Element_.ValueMember = "x_";
            combobox_Element_.DataPropertyName = "xElement_";
            combobox_Element_.Name = "Element";
            dataGridView_D_A.Columns.Add(combobox_Element_);

            dataGridView_D_A.DataSource = dt_D_A;
            bindingSource_D_A.DataSource = dataGridView_D_B.DataSource;
           // dataGridView_D_A.Columns["xElement_"].HeaderText = "نام عنصر";
            dataGridView_D_A.Columns["xAmount"].HeaderText = "مقدار";
            // dataGridView_D_A.Columns["xAmount"].ReadOnly = true;
            dataGridView_D_A.Columns["xCharacteristicMaterialPurchase_"].HeaderText = "";
            dataGridView_D_A.Columns["xCharacteristicMaterialPurchase_"].Visible = false;
            dataGridView_D_A.Columns["x_"].Visible = false;
            dataGridView_D_A.Columns["xAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bindingNavigator_D_A.BindingSource = bindingSource_D_A;

        }

        private void generateForm_D_B()
        {

            BLL.csElement cs = new BLL.csElement();

            DataGridViewComboBoxColumn combobox_Element_ = new DataGridViewComboBoxColumn();
            combobox_Element_.HeaderText = "نام عنصر";
            combobox_Element_.DataSource = cs.SelectElement();
            combobox_Element_.DisplayMember = "xNameElement";
            combobox_Element_.ValueMember = "x_";
            combobox_Element_.DataPropertyName = "xElement_";
            combobox_Element_.Name = "xElement";
            dataGridView_D_B.Columns.Add(combobox_Element_);

            dataGridView_D_B.DataSource = dt_D_B;
            bindingSource_D_B.DataSource = dataGridView_D_B.DataSource;
           // dataGridView_D_B.Columns["xElement_"].HeaderText = "نام عنصر";
            dataGridView_D_B.Columns["xAmount"].HeaderText = "مقدار";
            // dataGridView_D_B.Columns["xAmount"].ReadOnly = true;
            dataGridView_D_B.Columns["xCharacteristicMaterialPurchase_"].HeaderText = "";
            dataGridView_D_B.Columns["xCharacteristicMaterialPurchase_"].Visible = false;
            dataGridView_D_B.Columns["x_"].Visible = false;
            dataGridView_D_B.Columns["xAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bindingNavigator_D_B.BindingSource = bindingSource_D_B;
        }

        private void ShowStripButton_Click(object sender, EventArgs e)
        {

            BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
           

            if (chb_Scarb.Checked)
            {
                if (dt_I_S != null)
                dt_I_S.Clear();
                dataGridView1.Columns.Clear();
                dt_I_S = cs.SelectCharacteristicMaterialPurchaseIsScrab(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
                dt_D_B = cs.SelectAnalysisMaterial(-1, true);
                dt_D_A = cs.SelectAnalysisMaterial(-1, false);
                dataGridView1.DataSource = dt_I_S;
                bindingSource_S.DataSource = dt_I_S;
                bindingNavigator1.BindingSource = bindingSource_S;
            }

            else
            {
                if (dt_I != null)
                dt_I.Clear();
                dataGridView1.Columns.Clear();
                dt_I = cs.SelectCharacteristicMaterialPurchase(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
                dt_D_B = cs.SelectAnalysisMaterial(-1, true);
                dt_D_A = cs.SelectAnalysisMaterial(-1, false);
                dataGridView1.DataSource = dt_I;
                bindingSource1.DataSource = dt_I;
                bindingNavigator1.BindingSource = bindingSource1;

            }

            generateForm_I();
            dataGridView1.Columns["xAccept"].Visible = false;

            //generateForm_D_A();
            //generateForm_D_B();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMeltTestResult frm = new frmMeltTestResult();
            frm.ShowDialog();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            CS.csMessage csM = new CS.csMessage();
            if (!csM.ShowMessageSaveYesNo())
                return;
            this.Validate();
            dataGridView1.EndEdit();
            BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
            if (chb_Scarb.Checked)
                cs.UpdateCharacteristicMaterialPurchaseIsScrab(dt_I_S);
            else
            {
                cs.UpdateCharacteristicMaterialPurchase(dt_I);

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
                //dt_D_A.Clear();

                dt_D_B = cs.SelectAnalysisMaterial((int)dataGridView1["x_", e.RowIndex].Value, true);
                dt_D_A = cs.SelectAnalysisMaterial((int)dataGridView1["x_", e.RowIndex].Value, false);

                bindingSource_D_A.DataSource = dt_D_A;
                dataGridView_D_A.DataSource = bindingSource_D_A;
                bindingNavigator_D_A.BindingSource = bindingSource_D_A;

                bindingSource_D_B.DataSource = dt_D_B;
                dataGridView_D_B.DataSource = bindingSource_D_B;
                bindingNavigator_D_B.BindingSource = bindingSource_D_B;
               //// dataGridView_D_A.Columns[""].Visible = false;
                //dataGridView_D_B.Columns["xElement"].Visible = false;
            

        }

        private void toolStripButton_D_B_Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView_D_B.EndEdit();
            BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
              cs.UpdateAnalysisMaterial(dt_D_B);


        }

        private void toolStripButton_D_A_Save_Click(object sender, EventArgs e)
        {
            this.Validate();           
            dataGridView_D_A.EndEdit();
            BLL.csMeltTestResult cs = new BLL.csMeltTestResult();
            cs.UpdateAnalysisMaterial(dt_D_A);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);
        }

        private void toolStripButton_D_Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_D_B.SelectedRows)
                if (!row.IsNewRow) dataGridView_D_B.Rows.Remove(row);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_D_A.SelectedRows)
                if (!row.IsNewRow) dataGridView_D_A.Rows.Remove(row);
        } 

    }
}
