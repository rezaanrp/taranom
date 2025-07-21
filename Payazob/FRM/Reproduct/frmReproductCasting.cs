using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.Reproduct
{
    public partial class frmReproductCasting : Form
    {
        public frmReproductCasting()
        {
            InitializeComponent();

            BLL.csPieces cs = new BLL.csPieces();


            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام قطعه",
                DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "xPieces_",
                Visible = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                DataPropertyName = "xPieces_",
                Width = 150

        };
            dataGridView1.Columns.Add(combobox_PiecesLine1_);


            DataGridViewComboBoxColumn combobox_REPRD_ = new DataGridViewComboBoxColumn
            {
                HeaderText = "نوع بازکاری",
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("REPRD"),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "xGenTypeReproduct_",
                Visible = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                DataPropertyName = "xGenTypeReproduct_",
                Width = 150

            };
            dataGridView1.Columns.Add(combobox_REPRD_);

            ShowData(new DAL.Reproduct.DataSet_Reproduct.mReproductCastingDataTable());
        }
        private DAL.Reproduct.DataSet_Reproduct.mReproductCastingDataTable dt_P;

        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData(new BLL.Reproduct.csReproduct().mReproductCasting(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo));
        }
        void ShowData(DAL.Reproduct.DataSet_Reproduct.mReproductCastingDataTable dt)
        {
            this.dt_P = dt;
            this.bindingSource1.DataSource = this.dt_P;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.dt_P.xDateSupplierColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            this.dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
             this.Generate();
        }
        void Generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P.Columns)
            {
                dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            //this.dataGridView1.Columns["xPieces_"].HeaderText = "نام قطعه";
            //this.dataGridView1.Columns["xDate"].HeaderText = "تاریخ";
            //this.dataGridView1.Columns["xGenTypeReproduct_"].HeaderText = "نوع بازکاری";
            //this.dataGridView1.Columns["xDateSupplier"].HeaderText = "تاریخ ثبت";
            this.dataGridView1.Columns["xDateSupplier"].ReadOnly = true;
            this.dataGridView1.Columns["xSupplier_"].Visible = false;
            //this.dataGridView1.Columns["x_"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //this.dataGridView1.Columns["x_"].HeaderText = "سریال";
        }
        void SaveData()
        {
            base.Validate();
            this.dataGridView1.EndEdit();

            if (new Payazob.CS.csMessage().ShowMessageSaveYesNo())
                MessageBox.Show(new BLL.Reproduct.csReproduct().udReproductCasting(this.dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.bindingSource1.DataSource = this.dt_P;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.ShowData(new BLL.Reproduct.csReproduct().mReproductCasting(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo));
        }
        private void ToolStripButtonSave_F_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
