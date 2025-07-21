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
    public partial class frmMoldCount : Form
    {

        public frmMoldCount(CS.csEnum.FactorySection FactorySection_)
        {
            InitializeComponent();
            FS_ = FactorySection_;



            DataGridViewComboBoxColumn combobox_Shift_ = new DataGridViewComboBoxColumn
            {
                HeaderText = "نام شیفت",
                DataSource = new BLL.csShift().mShiftDataTable(),
                DisplayMember = "xShiftName",
                ValueMember = "x_",
                Name = "xShife_",
                DataPropertyName = "xShife_"

            };
            dataGridView1.Columns.Add(combobox_Shift_);

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
            DataGridViewComboBoxColumn column5 = new DataGridViewComboBoxColumn
            {
                DataSource = new BLL.Mold.csMold().MoldCombo(-1),
                HeaderText = " کد مدل",
                DisplayMember = "CodeMold",
                ValueMember = "x_",
                DataPropertyName = "xMoldList_",
                Name = "xMoldList_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

            };


            dataGridView1.Columns.Add(column5);


            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn()
            {
                DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("PRSTAT"),
                DisplayMember = "xName",
                //    HeaderText = "شیفت",
                ValueMember = "x_",
                DataPropertyName = "xGenStatusMold_",
                Name = "xGenStatusMold_",
                Width = 100,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            dataGridView1.Columns.Add(combobox_Type_);
            dt_A = new DAL.Mold.DataSet_Mold.SlMoldCountDataTable();
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_A.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;

            Generate();

        }
        CS.csEnum.FactorySection FS_ = CS.csEnum.FactorySection.Guest;
        private void glassButton_Show_Click(object sender, EventArgs e)
        {
            //ShowData();
        }
        DAL.Mold.DataSet_Mold.SlMoldCountDataTable dt_A;
        void ShowData()
        {
            BLL.Mold.csMold cs = new BLL.Mold.csMold();
            dt_A = cs.mMoldCount(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_A.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;

            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if ((!row.IsNewRow && (row.Cells["xPieces_"].Value != DBNull.Value)) && (row.Cells["xPieces_"].Value != null))
                {
                    (row.Cells["xMoldList_"] as DataGridViewComboBoxCell).DataSource = new BLL.Mold.csMold().MoldCombo((int?)row.Cells["xPieces_"].Value);
                }
            }


            Generate();
        }
        void SaveData()
        {

            //foreach (DataGridViewRow row in this.dataGridView1.Rows)
            //{
            //    if ((!row.IsNewRow && (row.Cells["xMoldList_"].Value == DBNull.Value)) || (row.Cells["xMoldList_"].Value == null))
            //    {
            //        MessageBox.Show("کد قالب را وارد کنید");
            //        return;
            //    }
            //}
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                this.Validate();
                dataGridView1.EndEdit();
                MessageBox.Show(new BLL.Mold.csMold().UdMoldCount(dt_A));
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
            dataGridView1.Columns["xSupplier_"].Visible = false;

            if (FS_ == CS.csEnum.FactorySection.Product)
            {
                dataGridView1.Columns["xGenStatusMold_"].Visible = false;
            }
            if (FS_ == CS.csEnum.FactorySection.QC)
            {
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    item.ReadOnly = true;
                }
                dataGridView1.Columns["xGenStatusMold_"].Visible = true;
                dataGridView1.Columns["xGenStatusMold_"].ReadOnly = false;
                dataGridView1.AllowUserToDeleteRows = false;
            }
        }
        int LoadFormSearchUser()
        {
            Form frm = new Form();
            ControlLibrary.uc_SearchData uc = new ControlLibrary.uc_SearchData();
            uc.ColumnFilter = "xName";
            uc.DataGridViewHeaderText("xName", "نام محصول");
            //  uc.DataGridViewHeaderText("xPerID", "شماره پرسنلی");
            uc.DataGridViewClmHide("x_");
            uc.DataGridViewClmHide("x_");
            uc.GenDataGridView(new BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1));
            uc.ResultCustom = "xName";

            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            frm.Controls.Add(uc);
            frm.Size = uc.Size;
            frm.Height += 30;
            frm.Width += 30;
            frm.StartPosition = FormStartPosition.CenterParent;

            uc.Dock = DockStyle.Fill;
            frm.ShowDialog();

            // lbl_Comment.Text = uc.ResultCustomValue;

            return int.Parse(uc.ResultID);

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }



        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // MessageBox.Show(e.Exception.Message);
        }

        private void frmAccidentsMinor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.IsCurrentCellInEditMode)
                if (dataGridView1.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                    dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width += 5;
                else if (dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
                    dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Width -= 5;
        }

        private void DataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dataGridView1.Columns["xPieces_"].Index == e.ColumnIndex)
            {
                int x_ = LoadFormSearchUser();
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = x_;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.dataGridView1.Columns[e.ColumnIndex].Name == "xPieces_"))
            {
                this.dataGridView1["xMoldList_", e.RowIndex].Value = DBNull.Value;
                if (this.dataGridView1[e.ColumnIndex, e.RowIndex].Value != DBNull.Value)
                {
                    (this.dataGridView1["xMoldList_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.Mold.csMold().MoldCombo((int?)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value);
                }
                else
                {
                    (this.dataGridView1["xMoldList_", e.RowIndex] as DataGridViewComboBoxCell).DataSource = new BLL.Mold.csMold().MoldCombo((-1));
                }
            }
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && (this.dataGridView1.Columns[e.ColumnIndex].Name == "xMoldList_"))
            {

            }
        }
    }
}
