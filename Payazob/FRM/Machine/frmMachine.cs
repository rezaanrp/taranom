using System;
using System.Windows.Forms;
using BLL.Machine;

namespace Payazob.FRM.Machine
{
    public partial class frmMachine : Form
    {
        public frmMachine(CS.csEnum.Factory factory_)
        {
            InitializeComponent();
            this.fct = factory_;

            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("STSMACH"),
                DisplayMember = "xName",
                HeaderText = "وضعیت دستگاه",
                ValueMember = "x_",
                DataPropertyName = "xGenStatus_",
                Name = "xGenStatus_",
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);

            DataGridViewComboBoxColumn dataGridViewColumn1 = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("LINENAME3"),
                DisplayMember = "xName",
                HeaderText = "وضعیت دستگاه",
                ValueMember = "x_",
                DataPropertyName = "xGenLineName_",
                Name = "xGenLineName_",
                Width = 150,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn1);

            this.ShowData();

        }
        private DAL.Machine.DataSet_Machine.mMachineDataTable dt_P;
        CS.csEnum.Factory fct;

        private void ShowData()
        {
            this.dt_P = new csMachine().mMachine((int)fct);
            this.bindingSource1.DataSource = this.dt_P;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            dt_P.xGenFact_Column.DefaultValue = fct;

            this.Generate();
        }
     

        private void Generate()
        {
            this.dataGridView1.Columns["xName"].HeaderText = "نام";
            this.dataGridView1.Columns["xCode"].HeaderText = "کد";
            this.dataGridView1.Columns["xGenLineName_"].HeaderText = "نام خط";
            this.dataGridView1.Columns["xGenLineName_"].DisplayIndex = 5;
            this.dataGridView1.Columns["xGenFact_"].Visible = false;
            this.dataGridView1.Columns["xGenStatus_"].Visible = false;
            this.dataGridView1.Columns["CodeName"].Visible = false;
            this.dataGridView1.Columns["xName"].Width = 300;
            this.dataGridView1.Columns["x_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns["x_"].HeaderText = "سریال";
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int rowIndex = this.dataGridView1.SelectedCells[0].RowIndex;
                if (this.dataGridView1.Rows[rowIndex].Cells["xName"].Value != null)
                {
                    this.lbl_Comment.Text = this.dataGridView1.Rows[rowIndex].Cells["xName"].Value.ToString();
                }
            }

        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            base.Validate();
            this.dataGridView1.EndEdit();
            csMachine machine = new csMachine();
            if (new Payazob.CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(machine.UdMachine(this.dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.bindingSource1.DataSource = this.dt_P;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            dt_P.xGenFact_Column.DefaultValue = fct;
            this.ShowData();
        }

    }
}
