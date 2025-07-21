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
    public partial class frmMoldActivits : Form
    {
        public frmMoldActivits(CS.csEnum.FactorySection FactorySection_)
        {
            InitializeComponent();
            FS_ = FactorySection_;

        }
        CS.csEnum.FactorySection FS_ = CS.csEnum.FactorySection.Guest;
        DAL.Mold.DataSet_Mold.SlMoldActivitiesDataTable dt_A;

        void ShowData()
        {
            BLL.Mold.csMold cs = new BLL.Mold.csMold();
            dt_A = cs.SlMoldActivities(uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSource1.DataSource = dt_A;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            dt_A.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_A.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;

            


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
                MessageBox.Show(new BLL.Mold.csMold().UdMoldActivities(dt_A));
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
            dataGridView1.Columns["xMoldCount_"].Visible = false;
            dataGridView1.Columns["xActivities"].Width = 300;

            if (FS_ == CS.csEnum.FactorySection.ENG)
            {
                dataGridView1.Columns["xQcConfirm"].ReadOnly = true;
            }
            else if (FS_ == CS.csEnum.FactorySection.QC)
            {
                foreach (DataGridViewColumn item in dataGridView1.Columns)
                {
                    item.ReadOnly = true;
                }
                dataGridView1.Columns["xQcConfirm"].ReadOnly = false;
                dataGridView1.AllowUserToDeleteRows = false;
            }
        }
     
        private void GlassButton_EXit_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
