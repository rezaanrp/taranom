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
    public partial class frmMoldListByPiecesAndStatus_R : Form
    {
        public frmMoldListByPiecesAndStatus_R()
        {
            InitializeComponent();
        }
        DAL.Mold.DataSet_Mold.SlMoldListByPieces_RDataTable dt_I;
        private void Btn_Show_Click(object sender, EventArgs e)
        {
            ShowData(-1);
            ShowDataPieces();
        }
        void ShowDataPieces()
        {
            this.dt_I = new BLL.Mold.csMold().SlMoldListByPieces_R(-1);
            this.dataGridView1.DataSource = new  BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            this.generateDGVPieces();
        }
        void ShowData(int xPieces_)
        {
            this.dt_I = new BLL.Mold.csMold().SlMoldListByPieces_R(xPieces_);
            this.bindingSource2.DataSource = this.dt_I;
            this.dataGridView2.DataSource = bindingSource2;
            this.generateDGVForm();
        }
        private void generateDGVForm()
        {
            Payazob.CS.csDic dic = new Payazob.CS.csDic();
            foreach (DataColumn column in this.dt_I.Columns)
            {
                if (this.dataGridView2.Columns[column.ColumnName] != null)
                {
                    this.dataGridView2.Columns[column.ColumnName].HeaderText = dic.EnToFarsiCatalog(column.ColumnName);
                }
            }
         
        }
        private void generateDGVPieces()
        {
            dataGridView1.Columns["x_"].Visible = false;
            dataGridView1.Columns["xName"].Visible = false;
            dataGridView1.Columns["xGenProductionMethod_"].Visible = false;
            dataGridView1.Columns["Piece"].HeaderText = "نام قطعه";
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                int x_ = (int)dataGridView1["x_", e.RowIndex].Value;
                ShowData(x_);
            }
        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                int Index = (int)dataGridView2["x_", e.RowIndex].Value;
                new Payazob.FRM.Mold.frmMoldActivitiesByMold_R(Index).ShowDialog();
            }
        }
    }
}
