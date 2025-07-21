using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.Mold
{
    public partial class frmMoldRecordActions : Form
    {
        public frmMoldRecordActions()
        {
            InitializeComponent();
            ShowDateGridPieces();

            DataGridViewComboBoxColumn combobox_MOLDTYP_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("MOLDTYP"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenMoldType_",
                Name = "xGenMoldType_",
                Width = 100,
                DisplayIndex = 1,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,

            };
            DataGridViewComboBoxColumn combobox_TRP_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("STUSMLD"),
                DisplayMember = "xName",
                ValueMember = "x_",
                DataPropertyName = "xGenStatusMold_",
                Name = "xGenStatusMold_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,

            };

            dataGridView2.Columns.Add(combobox_TRP_);
            dataGridView2.Columns.Add(combobox_MOLDTYP_);


            DataGridViewComboBoxColumn combobox_xSupplier2_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.authentication().NameOfUser(),
                DisplayMember = "NameAndFamily",
                ValueMember = "x_",
                DataPropertyName = "xSupplier_",
                Name = "xSupplier_",
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView3.Columns.Add(combobox_xSupplier2_);
            dataGridView3.DataSource = dt_MA = new DAL.Mold.DataSet_Mold.mMoldRecordActionsDataTable();
        }
        DAL.Mold.DataSet_Mold.mMoldListDataTable dt_M;
        DAL.Mold.DataSet_Mold.mMoldRecordActionsDataTable dt_MA;

        void ShowDateGridPieces()
        {
            dataGridView1.DataSource  = new BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            bindingSource1.DataSource = dataGridView1.DataSource;
            dataGridView1.Columns["xName"].HeaderText = "نام قطعه";

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xName"].Visible = true;
            dataGridView1.Columns["Piece"].Visible = false;
            dataGridView1.Columns["xGenProductionMethod_"].Visible = false;

            dataGridView1.Columns["xName"].Width = 200;

        }

        void ShowDateGridMold(int Mold_)
        {
            dataGridView2.DataSource = dt_M = new BLL.Mold.csMold().mMoldList(Mold_);
            generateMold();


        }
        void generateMold()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_M.Columns)
            {
                dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
           dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xPieces_"].Visible = false;
            dataGridView2.Columns["xDateRegister"].ReadOnly = true;
            dataGridView2.Columns["xComment"].Width = 300;
            dataGridView2.Columns["xGenMoldType_"].DisplayIndex = 1;
            dataGridView2.Columns["xSupplierCompanyName"].DisplayIndex = 2;
            dataGridView2.Columns["xDateEnter"].DisplayIndex = 3;
            dataGridView2.Columns["xGenStatusMold_"].DisplayIndex = 6;
        }

        void ShowDateGridMoldActiveity(int Mold_)
        {
            dataGridView3.DataSource = dt_MA = new BLL.Mold.csMold().mMoldRecordActions(Mold_);
            dt_MA.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_MA.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            dt_MA.xMold_Column.DefaultValue = Mold_;
            GenerateMoldActiveity();


        }
        void GenerateMoldActiveity()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_MA.Columns)
            {
                dataGridView3.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }


            dataGridView3.Columns["x_"].Visible = false;
            //dataGridView2.Columns["xSupplier_"].Visible = false;
           dataGridView3.Columns["xMold_"].Visible = false;
            dataGridView3.Columns["xAction"].Width = 500;
          //  dataGridView3.Columns["xSupplier_"].DisplayIndex = 5;

        }
        private void Btn_Show_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowDateGridMoldActiveity(-1);


            ShowDateGridMold((int)dataGridView1["x_", e.RowIndex].Value);
           
        }

        private void DataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowDateGridMoldActiveity((int)dataGridView2["x_", e.RowIndex].Value);

        }
        void SaveData()
        {
            this.Validate();
            dataGridView3.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.Mold.csMold().UdMoldRecordActions(dt_MA), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ToolStripButton_Save_D_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
