using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.ShotBlasting
{
    public partial class frmShotBlastingInspection : Form
    {
        public frmShotBlastingInspection()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn dataGridViewColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام شیفت",
                DataSource = new BLL.csShift().mShiftDataTable(),
                DisplayMember = "ShiftName",
                ValueMember = "x_",
                Name = "xShift_",
                DataPropertyName = "xShift_",
            };
            this.dataGridView1.Columns.Add(dataGridViewColumn);


            DataGridViewComboBoxColumn combobox_xPieces_ = new DataGridViewComboBoxColumn()
            {
                DisplayIndex = 3,
                HeaderText = "نام قطعه",
                DataSource = new BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xPieces_",
                Name = "xPieces_",
                Width = 200,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xPieces_);



            DataGridViewComboBoxColumn combobox_SHTDEF_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("SHTDEF"),
                DisplayMember = "xName",
                HeaderText = "نوع ",
                ValueMember = "x_",
                DataPropertyName = "xGenDefect_",
                Name = "xGenDefect_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_SHTDEF_);


            DataGridViewComboBoxColumn dataGridViewUser = new DataGridViewComboBoxColumn
            {
                HeaderText = "ثبت کننده",
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                Name = "xSupplier_",
                DataPropertyName = "xSupplier_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };
            this.dataGridView1.Columns.Add(dataGridViewUser);


            dt_A = new DAL.ShotBlasting.DataSet_ShotBlasting.mShotBlastingInspectionDataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_A.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_A.xRegisterDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_A.xRegisterTimeColumn.DefaultValue = new BLL.csshamsidate().CurrentTime;
            Generate();

        }

        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        DAL.ShotBlasting.DataSet_ShotBlasting.mShotBlastingInspectionDataTable dt_A;

        void ShowData()
        {
            BLL.ShotBlasting.csShotBlasting cs = new BLL.ShotBlasting.csShotBlasting();
            dt_A = cs.mShotBlastingInspection(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_A.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            Generate();
        }
        void SaveData()
        {

            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                MessageBox.Show(new BLL.ShotBlasting.csShotBlasting().UdShotBlastingInspection(dt_A));
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
            dataGridView1.Columns["xSupplier_"].DisplayIndex = 6;
            dataGridView1.Columns["xRegisterDate"].ReadOnly = true;
            dataGridView1.Columns["xRegisterTime"].ReadOnly = true;
            dataGridView1.Columns["xComment"].Width = 200;


        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

            ControlLibrary.uc_ExportExcelFile uc = new ControlLibrary.uc_ExportExcelFile();
            uc.Fildvg = dataGridView1;
            uc.RunExcel();
        }
    }
}
