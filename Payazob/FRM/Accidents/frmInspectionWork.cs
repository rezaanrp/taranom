using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Accidents
{
    public partial class frmInspectionWork : Form
    {
        public frmInspectionWork()
        {
            InitializeComponent();

            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();
            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = csm.SlGenGroup("SAFEFFIN");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "اثر بخشی نتایج";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xGenEffectiveness_";
            combobox_Type_.Name = "xGenEffectiveness_";
            combobox_Type_.Width = 150;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Type_);

            dt_A = new DAL.AccidentsMinor.DataSet_AccidentsMinor.mInspectionWorkDataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();
        }
        DAL.AccidentsMinor.DataSet_AccidentsMinor.mInspectionWorkDataTable dt_A;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            BLL.AccidentsMinor.Accidents cs = new BLL.AccidentsMinor.Accidents();
            dt_A = cs.mInspectionWork();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            Generate();
        }
        void SaveData()
        {
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
   this.Validate();
   dataGridView1.EndEdit();
   MessageBox.Show(new BLL.AccidentsMinor.Accidents().UdInspectionWork(dt_A));
   ShowData();
            }
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_A.Columns)
            {
   dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;

            dataGridView1.Columns["xDescriptionOfDefects"].Width = 300;
            dataGridView1.Columns["xNextActions"].Width = 300;

            dataGridView1.Columns["xGenEffectiveness_"].HeaderText = "نتایج اثر بخشی";

            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }



        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }

        private void frmAccidentsMinor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
   if (dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
       dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
   else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
       dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;
        }
    }
}
