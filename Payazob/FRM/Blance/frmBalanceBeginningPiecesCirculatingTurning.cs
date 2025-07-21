using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Blance
{
    public partial class frmBalanceBeginningPiecesCirculatingTurning : Form
    {
        public frmBalanceBeginningPiecesCirculatingTurning()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
   DisplayIndex = 3,
   HeaderText = "نوع مواد",
   DataSource = new BLL.csMaterial().SlMaterial("#", 160),
   DisplayMember = "xMaterialName",
   ValueMember = "x_",
   DataPropertyName = "xMaterial_",
   Name = "xMaterial_",
   Width = 150,
 //  ReadOnly = true,
   DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);
            this.dt_B = new BLL.BalanceBeginning.csBalanceBeginnig().SlmBalanceBeginningPiecesCirculatingTurningTableAdapter(Payazob.Properties.Settings.Default.WorkYear);
            this.bindingSource1.DataSource = this.dt_B;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.Generate();
            this.label1.Text = " موجودی ابتدای دوره قطعات سال " + Payazob.Properties.Settings.Default.WorkYear.Substring(2, 2);

        }
        private DAL.BalanceBeginingPiecesTurning.DataSet_BalanceBeginingPiecesTurning.mBalanceBeginningPiecesCirculatingTurningDataTable dt_B;
        private void Generate()
        {
            Payazob.CS.csDic dic = new Payazob.CS.csDic();
            foreach (DataColumn column in this.dt_B.Columns)
            {
   this.dataGridView1.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
            }
            this.dt_B.xDateColumn.DefaultValue = Payazob.Properties.Settings.Default.WorkYear;
            this.dataGridView1.Columns["x_"].Visible = false;
            this.dataGridView1.Columns["xDate"].Visible = false;
            this.dataGridView1.Columns["xBalanceBegin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.EndEdit();
            base.Validate();
            if (new Payazob.CS.csMessage().ShowMessageSaveYesNo())
            {
   BLL.BalanceBeginning.csBalanceBeginnig beginnig = new BLL.BalanceBeginning.csBalanceBeginnig();
   MessageBox.Show(beginnig.UdmBalanceBeginningPiecesCirculatingTurningTableAdapter(this.dt_B));
   this.dt_B = beginnig.SlmBalanceBeginningPiecesCirculatingTurningTableAdapter(Payazob.Properties.Settings.Default.WorkYear);
   this.dt_B.xDateColumn.DefaultValue = Payazob.Properties.Settings.Default.WorkYear;
   this.bindingSource1.DataSource = this.dt_B;
   this.dataGridView1.DataSource = this.bindingSource1;
   this.bindingNavigator1.BindingSource = this.bindingSource1;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new ControlLibrary.uc_ExportExcelFile { Fildvg = dataGridView1 }.RunExcel();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
   if (!row.IsNewRow)
   {
       this.dataGridView1.Rows.Remove(row);
   }
            }

        }
    }
}
