using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.MachineSettingChange
{
    public partial class frmMachineSettingChange : Form
    {
        public frmMachineSettingChange()
        {
            InitializeComponent();


            DataGridViewComboBoxColumn combobox_Shift_ = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام شیفت",
                DataSource = new BLL.csShift().mShiftDataTable(),
                DisplayMember = "xShiftName",
                ValueMember = "x_",
                DataPropertyName = "xShift_",
                Visible = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_Shift_);
        
            DataGridViewComboBoxColumn column2 = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام دستگاه",
                DataSource = new BLL.Machine.csMachine().mMachine((int)CS.csEnum.Factory.Site3),
                DisplayMember = "CodeName",
                ValueMember = "x_",
                DataPropertyName = "xMachine_",
                Name = "MachineName",
                Visible = true,
                Width = 200,

                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };
            this.dataGridView1.Columns.Add(column2);

            DataGridViewComboBoxColumn combobox_Section = new DataGridViewComboBoxColumn
            {
                HeaderText = "واحد درخواست کننده",
                DataSource = new BLL.Section.csSection().SlSection(),
                DisplayMember = "xSectionName",
                ValueMember = "x_",
                Name = "xSection_",
                DataPropertyName = "xSection_",
                Width = 100,

                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };
            dataGridView1.Columns.Add(combobox_Section);

            DataGridViewComboBoxColumn column4 = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("TYPCHMA"),
                HeaderText = "نوع تغییرات",
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenTypeChange_",
                Name = "xGenTypeChange_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };
            dataGridView1.Columns.Add(column4);


            DataGridViewComboBoxColumn combobox_xSupplier2_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                Width = 120,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_xSupplier2_);



            ShowData();
        }
        DAL.MachineSettingChange.DataSet_MachineSettingChange.mMachineSettingChangeDataTable dt_D;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            BLL.MachineSettingChange.csMachineSettingChange cs = new BLL.MachineSettingChange.csMachineSettingChange();
            dt_D = cs.MachineSettingChange(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_D;
            dataGridView1.DataSource = bindingSource1;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            Generate();
         //   dt_D.xGenFactory_Column.DefaultValue = fct_;

        }
        void SaveData()
        {
            this.Validate();
            dataGridView1.EndEdit();

            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.MachineSettingChange.csMachineSettingChange cs = new BLL.MachineSettingChange.csMachineSettingChange();

                MessageBox.Show(cs.UdMachineSettingChange(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                Generate();
            }
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_D.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xGenFactory_"].Visible = false;

            dataGridView1.Columns["xDescriptionOperation"].Width = 300;
            dataGridView1.Columns["xReasonChange"].Width = 300;
            dataGridView1.Columns["xResultChanges"].Width = 300;

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
