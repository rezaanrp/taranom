using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payazob.FRM.ConfirmMoldCompressNumber
{
    public partial class frmConfirmMoldCompressNumber : Form
    {
        public frmConfirmMoldCompressNumber()
        {
            InitializeComponent();

            BLL.csPieces cs = new BLL.csPieces();
            DataGridViewComboBoxColumn combobox_PiecesLine1_ = new DataGridViewComboBoxColumn()
            {
                HeaderText = "نام قطعه",
                DataSource = cs.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1),
                DisplayMember = "xName",
                ValueMember = "x_",
                Name = "xPieces_",
                DataPropertyName = "xPieces_",
                Visible = true,
                MaxDropDownItems = 30,
                Width = 220,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

            dataGridView1.Columns.Add(combobox_PiecesLine1_);


            BLL.GenGroup.csGenGroup csm = new BLL.GenGroup.csGenGroup();

            DataGridViewComboBoxColumn combobox_Type_ = new DataGridViewComboBoxColumn()
            {
                DataSource = csm.SlGenGroup("CNTRM"),
                DisplayMember = "xName",
                HeaderText = "نوع کنترل",
                ValueMember = "x_",
                DataPropertyName = "xGenType_",
                Name = "xGenType_",
                Width = 150,
                ReadOnly = true,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };

            dataGridView1.Columns.Add(combobox_Type_);
            dt = new DAL.ConfirmMoldCompressNumber.DataSet_ConfirmMoldCompressNumber.mConfirmMoldCompressNumberDataTable();
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
            Generation();

        }
        DAL.ConfirmMoldCompressNumber.DataSet_ConfirmMoldCompressNumber.mConfirmMoldCompressNumberDataTable dt;
        void ShowData()
        {
            dt = new BLL.ConfirmMoldCompressNumber.csConfirmMoldCompressNumber().mConfirmMoldCompressNumber(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt;
            dataGridView1.DataSource = bindingSource1;
            Generation();
        }
        void Generation()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt.Columns)
            {
                if (dataGridView1.Columns[dc.ColumnName] != null)
                {
                    dataGridView1.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
                }
            }

            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xSupplier_"].Visible = false;

            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.ReadOnly = true;

            }

            dataGridView1.Columns["xAccept"].ReadOnly = false;
            dataGridView1.Columns["xDeny"].ReadOnly = false;
            dataGridView1.Columns["xComment"].ReadOnly = false;
            dataGridView1.Columns["xComment"].Width = 200;
            dataGridView1.Columns["xGenType_"].HeaderText = "نوع کنترل";


        }
        void SaveData()
        {
            this.Validate();
            dataGridView1.EndEdit();
            if (new CS.csMessage().ShowMessageSaveYesNo())
            {
                BLL.ConfirmMoldCompressNumber.csConfirmMoldCompressNumber cs = new BLL.ConfirmMoldCompressNumber.csConfirmMoldCompressNumber();
                MessageBox.Show(cs.UdConfirmMoldCompressNumber(dt), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
            }
        }
        private void GlassButton_Show_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xAccept"  ||  dataGridView1.Columns[e.ColumnIndex].Name == "xDeny")
            {
                if ((bool)dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue == true)
                {
                    dataGridView1["xSupplier_", e.RowIndex].Value = BLL.authentication.x_;
                    dataGridView1["xDateConfirm", e.RowIndex].Value = BLL.csshamsidate.shamsidate;
                }
                else
                {
                    dataGridView1["xSupplier_", e.RowIndex].Value = DBNull.Value;
                    dataGridView1["xDateConfirm", e.RowIndex].Value = DBNull.Value;
                }


                if (dataGridView1.Columns[e.ColumnIndex].Name == "xAccept")
                {
                        dataGridView1["xDeny", e.RowIndex].Value = !(bool)dataGridView1["xAccept", e.RowIndex].Value;
                }

                else 
                {
                        dataGridView1["xAccept", e.RowIndex].Value = !(bool)dataGridView1["xDeny", e.RowIndex].Value;
                }

            }
        }
    }
}
