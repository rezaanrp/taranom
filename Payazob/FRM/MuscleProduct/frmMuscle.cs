using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.MuscleProduct
{
    public partial class frmMuscle : Form
    {
        public frmMuscle()
        {
            InitializeComponent();
            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.Machine.csMachine().mMachine((int)CS.csEnum.Factory.Site2),
                DisplayMember = "xName",
                HeaderText = "نام دستگاه ",
                ValueMember = "x_",
                DataPropertyName = "xMachine_",
                Name = "xMachine_",
                Width = 200,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);

        }
        DAL.DataSet_Piece.SlMuscleDataTable dt_P;

        void Generate()
        {
            this.dataGridView1.Columns["xMuscleTimeToProduct"].HeaderText = "مدت زمان استاندارد تولید ماهیچه ";
            this.dataGridView1.Columns["xMusclePay"].HeaderText = " مقدار دستمزد تولید ماهیچه تومان";
            this.dataGridView1.Columns["xMuscleName"].HeaderText = "نام ماهیچه";
            this.dataGridView1.Columns["xMuscleName"].Width = 250;
            this.dataGridView1.Columns["xName"].HeaderText = "نام محصول ";
            this.dataGridView1.Columns["xName"].Width =250;
            this.dataGridView1.Columns["xName"].ReadOnly =true;
            this.dataGridView1.Columns["xName"].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            this.dataGridView1.Columns["x_"].DefaultCellStyle.BackColor = Color.AntiqueWhite;
            this.dataGridView1.Columns["x_"].HeaderText = "کد  ";
            this.dataGridView1.Columns["xMachine_"].HeaderText = "نام دستگاه ماهیچه سازی ";
            this.dataGridView1.Columns["xSGCode"].HeaderText = "کد همکاران سیستم ";

            
        }
        void ShowData()
        {
            this.dt_P = new BLL.MuscleProduct.csMuscleProduct().SlMuscle();
            this.dataGridView1.DataSource = this.dt_P;
            this.bindingSource1.DataSource = this.dt_P;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.Generate();
        }
        void SaveData()
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(new BLL.MuscleProduct.csMuscleProduct().UdMuscle(dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
        }

        private void FrmMuscle_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
