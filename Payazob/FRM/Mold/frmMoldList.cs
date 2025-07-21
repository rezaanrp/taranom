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
    public partial class frmMoldList : Form
    {
        public frmMoldList()
        {
            InitializeComponent();

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

            ShowData(-1);
        }
        DAL.Mold.DataSet_Mold.mMoldListDataTable dt_M;
        DAL.Mold.DataSet_Mold.mMoldActivitiesDataTable dt_A;

    
    
        void ShowDateGrid1()
        {

            dataGridView1.DataSource = new BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            bindingSource1.DataSource = dataGridView1.DataSource;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.Columns["piece"].Visible = false;
            dataGridView1.Columns["xName"].Width = 250;
            dataGridView1.Columns["x_"].Width = 50;
            dataGridView1.Columns["xName"].HeaderText = "نام قطعه";
            dataGridView1.Columns["x_"].HeaderText = "کد ";
            dataGridView1.Columns["xGenProductionMethod_"].HeaderText = "روش تولید";
            dataGridView1.Columns["xName"].ReadOnly = true;
        }
        void generate()
        {
            CS.csDic css = new CS.csDic();

            foreach (DataColumn dc in dt_M.Columns)
            {
                dataGridView2.Columns[dc.ColumnName].HeaderText = css.EnToFarsiCatalog(dc.ColumnName);
            }
            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xSupplier_"].Visible = false;
           // dataGridView2.Columns["xPieces_"].Visible = false;
      //      dataGridView2.Columns["xPieces_"].Visible = false;
            dataGridView2.Columns["xDateRegister"].ReadOnly = true;
            dataGridView2.Columns["xComment"].Width = 300;
            dataGridView2.Columns["xGenMoldType_"].DisplayIndex = 1;
            dataGridView2.Columns["xSupplierCompanyName"].DisplayIndex = 2;
            dataGridView2.Columns["xDateEnter"].DisplayIndex = 3;
            dataGridView2.Columns["xGenStatusMold_"].DisplayIndex = 6;

        }
        private void FrmMoldList_Load(object sender, EventArgs e)
        {
            ShowDateGrid1();
        }

        void ShowData(int x_)
        {
            dt_M = new BLL.Mold.csMold().mMoldList(x_);
            bindingSource2.DataSource = dt_M;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator2.BindingSource = bindingSource2;

            dataGridView2.Columns["x_"].Visible = false;
            dataGridView2.Columns["xCounter"].Visible = false;
            dataGridView2.Columns["xTotalCounter"].Visible = false;

            dt_M.xPieces_Column.DefaultValue = x_;
            dt_M.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_M.xDateRegisterColumn.DefaultValue = BLL.csshamsidate.shamsidate;

           generate();

        }


        void SaveData()
        {
            this.Validate();
            dataGridView2.EndEdit();
            rwIndx1 = dataGridView1.SelectedRows.Count > 0 ? dataGridView1.SelectedRows[0].Index : -1;
            rwIndx2 = dataGridView2.SelectedRows.Count > 0 ? dataGridView2.SelectedRows[0].Index : -1;
            if (new CS.csMessage().ShowMessageSaveYesNo())
                MessageBox.Show(new BLL.Mold.csMold().UdMoldList(dt_M), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        int rwIndx1 = -1;
        int rwIndx2 = -1;

        private void ToolStripButtonSave1_Click(object sender, EventArgs e)
        {
            SaveData();
            ShowDateGrid1();
            if (rwIndx1 > -1 && dataGridView1.Rows.Count > 0 )
            {
                dataGridView1.Rows[rwIndx1].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[rwIndx1].Index > 1 ? dataGridView1.Rows[rwIndx1].Index - 2 : dataGridView1.Rows[rwIndx1].Index;
                ShowData((int)dataGridView1["x_", rwIndx1].Value);
               
            }

        }



        private void ToolStripButton_SaveAct_Click(object sender, EventArgs e)
        {
            int idx = 0;
            int selidx = 0;
            if (dataGridView2.SelectedCells.Count > 0)
            {
                selidx = (int)dataGridView2.SelectedCells[0].RowIndex;
                idx = (int)dataGridView2.Rows[selidx].Cells["x_"].Value;
            }
        }

        private void DataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        Stack<int> dvg_ind = new Stack<int>();

        private void Uc_txtBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dvg_ind.Count > 0)
                {
                    int i = dvg_ind.Pop();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
                }
            }
            else
            {
                dvg_ind.Clear();
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    item.Selected = false;
                }


                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell itemCell in item.Cells)
                    {

                        if (
                            itemCell.Visible == true && itemCell.Value != DBNull.Value && itemCell.Value != null &&
                            (itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text) ||
                             itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ی', 'ي')) ||
                              itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ي', 'ی')) ||
                               itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ک', 'ك')) ||
                                itemCell.FormattedValue.ToString().Contains(uc_txtBox1.Text.Replace('ك', 'ک')))
                            )
                        {

                            dvg_ind.Push(item.Index);
                            break;
                            //return;
                        }


                    }
                }
                if (dvg_ind.Count > 0)
                {
                    int i = dvg_ind.Pop();
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[i].Index > 1 ? dataGridView1.Rows[i].Index - 2 : dataGridView1.Rows[i].Index;
                }
            }
        }


        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                ShowData((int)dataGridView1["x_", e.RowIndex].Value);
            }

        }

       
    }

}
