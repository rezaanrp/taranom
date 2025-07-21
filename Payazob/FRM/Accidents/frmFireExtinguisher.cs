using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.Accidents
{
    public partial class frmFireExtinguisher : Form
    {
        public frmFireExtinguisher()
        {
            InitializeComponent();//EXTIGTYP

            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn();
            combobox_Type_.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("EXTIGTYP");
            combobox_Type_.DisplayMember = "xName";
            combobox_Type_.HeaderText = "نوع کپسول";
            combobox_Type_.ValueMember = "x_";
            combobox_Type_.DataPropertyName = "xGenType_";
            combobox_Type_.Name = "xGenType_1";
            //combobox_Type_.Width = 100;
            combobox_Type_.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;

            dataGridView1.Columns.Add(combobox_Type_);

            ShowData();
        }
        DAL.AccidentsMinor.DataSet_AccidentsMinor.mFireExtinguisherDataTable dt_C;
        DAL.AccidentsMinor.DataSet_AccidentsMinor.mFireExtingusherDetialsDataTable dt_D;

        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_C.Columns)
            {
   if (dataGridView1.Columns[dc.ColumnName] != null)
   dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dt_C.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xCode"].HeaderText = "کد";
            dataGridView1.Columns["xLocation"].Width = 300;

        }

        void GenerateD()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_D.Columns)
            {
   dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }

            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;

            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xDate"].ReadOnly = true;
            dataGridView2.Columns["xDateEXP"].Visible = false;
            dataGridView2.Columns["xFireExtinguisher_"].Visible = false;
            dataGridView2.Columns["xComment"].Width = 300;

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            BLL.AccidentsMinor.Accidents css = new BLL.AccidentsMinor.Accidents();

   dt_C = css.mFireExtinguisher();

            bindingSource1.DataSource = dt_C;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
        
            Generate();
        }

        void ShowDataD(int x_)
        {
            BLL.AccidentsMinor.Accidents css = new BLL.AccidentsMinor.Accidents();
            dt_D = css.mFireExtingusherDetials(x_);
            bindingSource2.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;
            dt_D.xFireExtinguisher_Column.DefaultValue = x_;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;

            GenerateD();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

   this.Validate();
   dataGridView1.EndEdit();
   BLL.AccidentsMinor.Accidents css = new BLL.AccidentsMinor.Accidents();
   if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(css.UdFireExtinguisher(dt_C), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
   //ShowDataD();
       

        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView2.EndEdit();
            BLL.AccidentsMinor.Accidents css = new BLL.AccidentsMinor.Accidents();
            if (new CS.csMessage().ShowMessageSaveYesNo()) MessageBox.Show(css.UdFireExtingusherDetials(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowData();
        }

        private void frmFireExtinguisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView2.IsCurrentCellInEditMode)
   if (dataGridView2.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
       dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width += 5;
   else if (dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
       dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].Width -= 5;
            if (dataGridView1.IsCurrentCellInEditMode)
   if (dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
       dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
   else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
       dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;  
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
   ShowDataD((int)dataGridView1["x_", e.RowIndex].Value);
            }
        }

    }
}
