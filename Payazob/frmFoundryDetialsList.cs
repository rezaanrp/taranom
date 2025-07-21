using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmFoundryDetialsList : Form
    {
        public frmFoundryDetialsList()
        {
            InitializeComponent();
            BLL.csFoundry cs = new BLL.csFoundry();

            toolStripTextBoxDateFrom.Text = new BLL.csshamsidate().previousDay(5);
            toolStripTextBoxDateTo.Text = BLL.csshamsidate.shamsidate;

            dt_Foundry = cs.SelectFoundryDetial(BLL.csshamsidate.shamsidate, BLL.csshamsidate.shamsidate);

            BLL.csShift cs_shift = new BLL.csShift();
            DataGridViewComboBoxColumn combobox_xShift_ = new DataGridViewComboBoxColumn();
            combobox_xShift_.DisplayIndex = 4;
            combobox_xShift_.HeaderText = "شیفت ";
            combobox_xShift_.DataSource = cs_shift.mShiftDataTable();
            combobox_xShift_.DisplayMember = "xShiftName";
            combobox_xShift_.ValueMember = "x_";
            combobox_xShift_.Name = "cmb_Shift";
            dataGridView_F.Columns.Add(combobox_xShift_);

            DataGridViewTextBoxColumn SumMaterialAmount = new DataGridViewTextBoxColumn();
            SumMaterialAmount.ValueType = typeof(decimal?);
            SumMaterialAmount.Name = "SumAmount";
            SumMaterialAmount.HeaderText = "مقدار اضافه شده";
            SumMaterialAmount.Visible = false;

            dataGridView_Detials.Columns.Add(SumMaterialAmount);

            BLL.csMaterial csMaterial = new BLL.csMaterial();
            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 4;
            combobox_xMaterialType_.HeaderText = "نوع مواد";
            combobox_xMaterialType_.DataSource = csMaterial.SlectMatreilAndScarb();
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.Name = "xMaterial";
            combobox_xMaterialType_.MaxDropDownItems = 20;
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.Visible = false;
            //combobox_xMaterialType_.DataPropertyName = "xMaterial_";
            dataGridView_Detials.Columns.Add(combobox_xMaterialType_);

            bindingSource1.DataSource = dt_Foundry;
            dataGridView_F.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            bindingSource2.DataSource = dt_M_Foundry;
            dataGridView_Detials.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            generateFormF();
        }
        DAL.Foundry.DataSet_Foundry.SelectFoundryDetailsByDateDataTable dt_Foundry;
        DAL.Foundry.DataSet_Foundry.SelectMaterialOfFoundryDataTable dt_M_Foundry;
        private void generateFormF()
        {
            dataGridView_F.Columns["cmb_Shift"].DataPropertyName = "xShift_";
            dataGridView_F.Columns["xDate"].HeaderText = "تاریخ";
            dataGridView_F.Columns["xDate"].ReadOnly = true;
            dataGridView_F.Columns["cmb_Shift"].HeaderText = "شیفت";
            dataGridView_F.Columns["xComment"].HeaderText = "توضیحات";
            dataGridView_F.Columns["xComment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView_F.Columns["xCastedMold"].HeaderText = "کل قالب";
            dataGridView_F.Columns["xReceivedMelt"].HeaderText = "ذوب تحویل گرفته شده";
            dataGridView_F.Columns["xFowardMelt"].HeaderText = "ذوب تحویل داده شده";
            dataGridView_F.Columns["xSlagWeight"].HeaderText = "وزن سرباره";
            dataGridView_F.Columns["xIsDaktil"].HeaderText = "داکتیل";
            dataGridView_F.Columns["x_"].Visible = false;
            dataGridView_F.Columns["xShift_"].Visible = false;
            dataGridView_F.Columns["xShift_"].Visible = false;
            
        }

        private void generateFormDetails()
        {

            dataGridView_Detials.Columns["xMaterial"].DataPropertyName = "xMaterial_";
            dataGridView_Detials.Columns["xMaterialAmount"].HeaderText = "مقدار مواد اولیه";
            dataGridView_Detials.Columns["x_"].Visible = false;
            dataGridView_Detials.Columns["xMaterial_"].Visible = false;
            dataGridView_Detials.Columns["xNumberFurnace"].Visible = false;
            dataGridView_Detials.Columns["xFoundry_"].Visible = false;
            dataGridView_Detials.Columns["xMaterial"].Visible = true;
            dataGridView_Detials.Columns["SumAmount"].Visible = true;
            
            
            dataGridView_Detials.Columns["SumAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView_Detials.Columns["xMaterial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_Detials.Columns["xMaterialAmount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void toolStripButtonSave_F_Click(object sender, EventArgs e)
        {
            SaveDataGridView1();
        }
        void SaveDataGridView1()
        {
            this.Validate();
            dataGridView_F.EndEdit();
            BLL.csFoundry cs = new BLL.csFoundry();
            cs.UpdateFoundryDetial(dt_Foundry);
            bindingSource1.DataSource = dt_Foundry;
            dataGridView_F.DataSource = bindingSource1;
        }
        private void toolStripButtonShow_F_Click(object sender, EventArgs e)
        {
            ShowDataGridView1();
        }
        void ShowDataGridView1()
        {

            BLL.csFoundry cs = new BLL.csFoundry();
            dt_Foundry = cs.SelectFoundryDetial(toolStripTextBoxDateFrom.Text, toolStripTextBoxDateTo.Text);
            bindingSource1.DataSource = dt_Foundry;
            dataGridView_F.DataSource = bindingSource1;
            generateFormF();
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveDataGridViewD();

        }
        void SaveDataGridViewD()
        {
            this.Validate();
            dataGridView_Detials.EndEdit();
            BLL.csFoundry cs = new BLL.csFoundry();
            MessageBox.Show( cs.UpdateMaterialOfFoundry(dt_M_Foundry),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bindingSource2.DataSource = dt_M_Foundry;
            dataGridView_Detials.DataSource = bindingSource2;

            this.ActiveControl = dataGridView_F;
        }
        private void dataGridView_F_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButtonAdd_F_Click(object sender, EventArgs e)
        {
            /*xDate,xShift_,xCastedMold,xReceivedMelt,xTotalMelt,xFowardMelt,xSlagWeight,xZinter,xStartTime,xEndTime,xIsDaktil,xComment*/

            AddNewFoundry();
        }

        void AddNewFoundry()
        {
            frmFoundry frm = new frmFoundry();
            frm.ShowDialog();
            if (frm.Accept)
            {
                DataRow dr = dt_Foundry.NewRow();
                dr["xDate"] = frm.txtDate;
                dr["xShift_"] = frm.shift;
                dr["xCastedMold"] = frm.CastedMold;
                dr["xReceivedMelt"] = frm.ReceivedMelt;
                dr["xFowardMelt"] = frm.FowardMelt;
                dr["xSlagWeight"] = frm.SlagWeight;
                dr["xIsDaktil"] = frm.daktil;
                dr["xComment"] = frm.txt_comment;
                dt_Foundry.Rows.Add(dr);
                ////////////////////////////

                this.Validate();
                dataGridView_F.EndEdit();
                BLL.csFoundry cs = new BLL.csFoundry();
                cs.UpdateFoundryDetial(dt_Foundry);
                bindingSource1.DataSource = dt_Foundry;
                dataGridView_F.DataSource = bindingSource1;

                toolStripButtonShow_F_Click(null, new EventArgs());
                this.ActiveControl = dataGridView_F;

            }
        }

        byte fer_N = 1;
        private void rdb_1_CheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView_F.Rows.Count < 1)
                return;
             fer_N = byte.Parse((sender as RadioButton).Name.Substring((sender as RadioButton).Name.Length - 1));
             dataGridView_F_RowEnter(dataGridView_F, new DataGridViewCellEventArgs(0, dataGridView_F.SelectedRows[0].Index));
             dataGridView_F.Refresh();

        }

        private void dataGridView_Detials_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Detials.EndEdit();
            decimal? AddOn = (decimal?)dataGridView_Detials["SumAmount", e.RowIndex].Value;
            if (AddOn == null)
                return;
            decimal? Current = 0;

            if (dataGridView_Detials["xMaterialAmount", e.RowIndex].Value == null || dataGridView_Detials["xMaterialAmount", e.RowIndex].Value == DBNull.Value)
                Current = 0;
            else
                Current = (decimal?)dataGridView_Detials["xMaterialAmount", e.RowIndex].Value;
            decimal? Sum = AddOn + Current;
            dataGridView_Detials["SumAmount", e.RowIndex].Value = null;
            dataGridView_Detials["xMaterialAmount", e.RowIndex].Value = Sum;
        
        }

        private void toolStripTextBoxDateFrom_Enter(object sender, EventArgs e)
        {
            string st = new CS.csDateform().DateOutPut((sender as ToolStripTextBox).Owner, (sender as ToolStripTextBox).Owner.Width / 2, 0);
            (sender as ToolStripTextBox).Text = st == "" ? (sender as ToolStripTextBox).Text : st;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (System.Windows.Forms.Keys.Control | Keys.Enter):
                    ShowDataGridView1();
                    break;
                case (System.Windows.Forms.Keys.Control | Keys.S):
                    SaveDataGridView1();
                    break;
                case (System.Windows.Forms.Keys.Control | Keys.Shift | Keys.S):
                    SaveDataGridViewD();
                    break;
                case (System.Windows.Forms.Keys.Control  | Keys.N):
                    AddNewFoundry();
                    break;

            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridView_F_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                BLL.csFoundry cs = new BLL.csFoundry();
                //dt_M_Foundry.Clear();
                dt_M_Foundry = cs.SelectMaterialOfFoundryByxFoundry_((int)dataGridView_F["x_", e.RowIndex].Value, fer_N);
                dt_M_Foundry.Columns["xFoundry_"].DefaultValue = (int)dataGridView_F["x_", e.RowIndex].Value;
                dt_M_Foundry.Columns["xNumberFurnace"].DefaultValue = fer_N;
                //  dt_M_Foundry.Columns["xMaterialAmount"].DefaultValue = 0;
                bindingSource2.DataSource = dt_M_Foundry;
                dataGridView_Detials.DataSource = bindingSource2;
                generateFormDetails();
                dataGridView_Detials.Columns["SumAmount"].DisplayIndex = 5;
                dataGridView_Detials.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
