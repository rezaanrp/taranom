using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.MuscleProduct
{
    public partial class frmBalanceBeginningMuscle : Form
    {
        public frmBalanceBeginningMuscle()
        {
            InitializeComponent();

            BLL.csPieces cs = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_Muscle_ = new DataGridViewComboBoxColumn();
            combobox_Muscle_.HeaderText = "نام ماهیچه";
            combobox_Muscle_.DataSource = cs.SlMuscle();
            combobox_Muscle_.DisplayMember = "xMuscleName";
            combobox_Muscle_.ValueMember = "x_";
            combobox_Muscle_.Name = "combobox_Muscle_";
            combobox_Muscle_.DataPropertyName = "xPiecesMuscle_";
            combobox_Muscle_.Visible = true;
            combobox_Muscle_.MaxDropDownItems = 30;
            combobox_Muscle_.Width = 150;
            combobox_Muscle_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dataGridView1.Columns.Add(combobox_Muscle_);


            dt_B = new BLL.MuscleProduct.csMuscleProduct().SlBalanceBeginningMuscle(Properties.Settings.Default.WorkYear);
            bindingSource1.DataSource = dt_B;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            Generate();

            label1.Text = " موجودی ابتدای دوره  سال " + Properties.Settings.Default.WorkYear.Substring(2, 2);
        }


        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_B.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)

                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }


            dt_B.xDateColumn.DefaultValue = Properties.Settings.Default.WorkYear;
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xDate"].Visible = false;
            dataGridView1.Columns["xCount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        DAL.MuscleProduct.DataSet_BalanceBeginningMuscle.mBalanceBeginningMuscleDataTable dt_B;

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            this.dataGridView1.EndEdit();
            this.Validate();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.MuscleProduct.csMuscleProduct cs = new BLL.MuscleProduct.csMuscleProduct();

                MessageBox.Show(cs.UdBalanceBeginningMuscle(dt_B));

                dt_B = cs.SlBalanceBeginningMuscle(Properties.Settings.Default.WorkYear);

                dt_B.xDateColumn.DefaultValue = Properties.Settings.Default.WorkYear;

                bindingSource1.DataSource = dt_B;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
