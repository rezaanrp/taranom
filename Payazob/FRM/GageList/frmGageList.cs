using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.GageList
{
    public partial class frmGageList : Form
    {
        public frmGageList(CS.csEnum.Factory FCT)
        {
            InitializeComponent();
            FCT_ = FCT;

            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("GAGESTUS"),
                DisplayMember = "xName",
                HeaderText = "xGenStatus_",
                ValueMember = "x_",
                DataPropertyName = "xGenStatus_",
                Name = "xGenStatus_",
               // Width = 150,
                MaxDropDownItems = 30,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_Type_);


            DataGridViewComboBoxColumn combobox_Sch_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("GAGESCH"),
                DisplayMember = "xName",
                HeaderText = "xGenStatus_",
                ValueMember = "x_",
                DataPropertyName = "xGenScheduleType_",
                Name = "xGenScheduleType_",
              //  Width = 150,
                MaxDropDownItems = 30,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_Sch_);

            DataGridViewComboBoxColumn combobox_xMaterialType_ = new DataGridViewComboBoxColumn()
            {
                HeaderText = "نام ابزار",
                DataSource = new BLL.csMaterial().SlMaterial("$",(int)CS.csEnum.MaterilaType.AbzarAndazeGiri),
                DisplayMember = "xMaterialName",
                ValueMember = "x_",
                DataPropertyName = "xGageName_",
                Name = "xGageName_",
                Width = 150,
                MaxDropDownItems = 30,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
            };
            dataGridView1.Columns.Add(combobox_xMaterialType_);
            ShowData();



        }
        DAL.GageList.DataSet_Gagelist.mGagelistDataTable dt_P;
        DAL.GageList.DataSet_Gagelist.mGageListCalibrationDataTable dt_D;
        CS.csEnum.Factory FCT_;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        void ShowData()
        {
            dt_P = new BLL.GageList.csGageList().mGagelist((int)FCT_);
            bindingSource1.DataSource = dt_P;
            dt_P.xGenFactory_Column.DefaultValue = (int)FCT_;
            dt_P.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dataGridView1.DataSource = bindingSource1;
            uc_bindingNavigator1.BindingSource = bindingSource1;
            generate();
        }
        void ShowDataDetails(int index_)
        {
            dt_D = new BLL.GageList.csGageList().mGageListCalibration(index_);
            bindingSource2.DataSource = dt_D;
            dataGridView2.DataSource = bindingSource2;
            uc_bindingNavigator3.BindingSource = bindingSource2;
            dt_D.xGageList_Column.DefaultValue = index_;
            dt_D.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_D.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            generateD();
        }
        void generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_P.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;
            dataGridView1.Columns["xGenFactory_"].Visible = false;



        }

        void generateD()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_D.Columns)
            {
                if (dataGridView2.Columns[dc.ColumnName] != null)
                {
                    dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
            dataGridView2.Columns["xGageList_"].Visible = false;
            dataGridView2.Columns["xInterval"].Width = 50;
            dataGridView2.Columns["xCalibrationPlace"].Width = 200;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.GageList.csGageList().UdGagelist(dt_P), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridView2.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                MessageBox.Show(new BLL.GageList.csGageList().UdGageListCalibration(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dataGridView1.SelectedRows.Count > 0)
                    ShowDataDetails((int)dataGridView1.SelectedRows[0].Cells["x_"].Value);
                else
                    ShowDataDetails(-1);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {

                ShowDataDetails((int)dataGridView1["x_", e.RowIndex].Value);

            }
        }
    }
}
