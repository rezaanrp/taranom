using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.BalanceBeginningMaterial
{
    public partial class frmBalanceBeginningMaterial : Form
    {
        public frmBalanceBeginningMaterial()
        {
            InitializeComponent();
            dt_B = new BLL.BalanceBeginningMaterial.csBalanceBeginningMaterial().SlBalanceBeginningMaterial(Properties.Settings.Default.WorkYear);
            bindingSource1.DataSource = dt_B;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;

            BLL.csMaterial csm = new BLL.csMaterial();
            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn();
            combobox_xMaterialType_.DisplayIndex = 3;
            combobox_xMaterialType_.HeaderText = "نوع مواد";
            combobox_xMaterialType_.DataSource = csm.SlMaterial("A",0);
            combobox_xMaterialType_.DisplayMember = "xMaterialName";
            combobox_xMaterialType_.ValueMember = "x_";
            combobox_xMaterialType_.DataPropertyName = "xMaterial_";
            combobox_xMaterialType_.Name = "cmb_Material";
            combobox_xMaterialType_.Width = 150;
            combobox_xMaterialType_.ReadOnly = true;
            combobox_xMaterialType_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;


            dataGridView1.Columns.Add(combobox_xMaterialType_);

            uc_DataGridViewBtn1.ColumnsFilter_ = "xMaterialName";
            uc_DataGridViewBtn1.Ds = csm.SlMaterial("A",0);

            uc_DataGridViewBtn1.ParamName = new string[] { "xMaterialName" };
            uc_DataGridViewBtn1.ParamValue = new string[] { "نام مواد" };
            uc_DataGridViewBtn1.ParamHide = new string[] { "x_", "xType", "xModule_","xGenType_", "Module","xConditionMaintenance",
           "xFeature",
           "xAcceptCriteria",
           "xControlTools",
           "xSupplier_",
           "xSupplier",
           "xDateEdit" };

            formFunctionPointer += new functioncall(Replicate);
            uc_DataGridViewBtn1.userFunctionPointer = formFunctionPointer;

            dt_B.xDateColumn.DefaultValue = Properties.Settings.Default.WorkYear;
            Generate();

            label1.Text = " موجودی ابتدای دوره سال " + Properties.Settings.Default.WorkYear.Substring(2, 2);

            ActiveControl = dataGridView1;
        }
        DAL.BalanceBeginningMaterial.DataSet_BalanceBeginningMaterial.SlBalanceBeginningMaterialDataTable dt_B;

        public delegate void functioncall(string Display, string value);

        private event functioncall formFunctionPointer;

        private void Replicate(string Display, string value)
        {
            if (value != "-1")
            {
   dataGridView1["xMaterial_", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
   dataGridView1["cmb_Material", uc_DataGridViewBtn1.RI].Value = int.Parse(value);
   dataGridView1.CurrentCell = dataGridView1["cmb_Material", uc_DataGridViewBtn1.RI];
            }
        }


        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_B.Columns)
            {
   dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dt_B.xDateColumn.DefaultValue = Properties.Settings.Default.WorkYear;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xMaterial_"].HeaderText = "کد مواد";
            dataGridView1.Columns["xMaterial_"].ReadOnly = true;
            dataGridView1.Columns["cmb_Material"].HeaderText = "نام مواد";
           dataGridView1.Columns["xBalanceBegin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xMaterial_")
            {
   uc_DataGridViewBtn1.Visible = true;
   var cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
   uc_DataGridViewBtn1.Location = new Point(cellRectangle.X, cellRectangle.Y);
   uc_DataGridViewBtn1.Size = new Size(20, dataGridView1.Rows[e.RowIndex].Height);
   uc_DataGridViewBtn1.RI = e.RowIndex;
   uc_DataGridViewBtn1.CI = e.ColumnIndex;
   
            }

            else
   uc_DataGridViewBtn1.Visible = false;
        }
        void SaveData()
        {
            BLL.BalanceBeginningMaterial.csBalanceBeginningMaterial cs = new BLL.BalanceBeginningMaterial.csBalanceBeginningMaterial();
            if(new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show( cs.UdBalanceBeginningMaterial(dt_B),"",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
   case (System.Windows.Forms.Keys.Down ):

       if(dataGridView1.Rows.Count  ==  0 || dataGridView1["xMaterial_", dataGridView1.Rows.Count - 1].Value != DBNull.Value)
           dt_B.Rows.Add();
       break;
   case (System.Windows.Forms.Keys.Enter):
       if (uc_DataGridViewBtn1.Visible == true)
       {
           uc_DataGridViewBtn1.button1.PerformClick();

       }
       break;
   case  (System.Windows.Forms.Keys.Control | Keys.S):

           dt_B.Rows.Add();
       break;


            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //uc_DataGridViewBtn1.Visible = false;

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Validation.VTranslateException v = new Validation.VTranslateException();

            MessageBox.Show(v.EnToFarsiCatalog((e.Exception).Message));


        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "xMaterial_")
            //{
            //    if (!((DataGridViewComboBoxColumn)dataGridView1.Columns["cmb_Material"]).Items.Contains(e.FormattedValue))
            //        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            //}
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
