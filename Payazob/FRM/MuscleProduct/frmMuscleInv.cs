using System;
using System.Data;
using System.Windows.Forms;

namespace Payazob.FRM.MuscleProduct
{
    public partial class frmMuscleInv : Form
    {
        public frmMuscleInv()
        {
            InitializeComponent();
            dt_M = new BLL.csPieces().SlMuscle();
            dataGridView1.DataSource = dt_M;
            bindingSource1.DataSource = dt_M;
            bindingNavigator1.BindingSource = bindingSource1;
            GeneratePiecs();
        }
        void GeneratePiecs()
        {
            dataGridView1.Columns["xMuscleName"].Width = 200;
            dataGridView1.Columns["xMuscleName"].HeaderText = "نام ماهیچه";
            dataGridView1.Columns["xName"].HeaderText = "نام قطعه  ";
            dataGridView1.Columns["xName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["x_"].Visible= false;

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
        }
        DataTable dt_M;
        DAL.MuscleProduct.DataSet_MuscleINV.SlMucsleInvDataTable dt_I;
        void ShowDate()
        {
           
          
        }
        DAL.MuscleProduct.DataSet_MuscleINV.SlMuscleInvByPiecesDataTable dt_N;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                BLL.MuscleProduct.csMuscleProduct csm = new BLL.MuscleProduct.csMuscleProduct();
                //dt_M_Foundry.Clear();

                dt_I = csm.SlMucsleInv(uc_Filter_Date1.DateFrom,uc_Filter_Date1.DateTo, (int)dataGridView1["x_",e.RowIndex].Value);
                dataGridView2.DataSource = dt_I;
                bindingSource2.DataSource = dt_I;
                dataGridView2.Columns["xDate"].HeaderText = "تاریخ";
                dataGridView2.Columns["CountMuscleProduct"].HeaderText = "مقدار وارده";
                dataGridView2.Columns["CountMuscleSend"].HeaderText = "مقدار صادره";
                dataGridView2.Columns["CountMuscleSend"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dt_N = new BLL.MuscleProduct.csMuscleProduct().SlMuscleInvByPieces(
                    uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo, (int)dataGridView1["x_", e.RowIndex].Value);
                if (dt_N.Rows.Count > 0)
                {
                    lbl_BalanceBeginningMuscle.Text =  "موجودی ابتدای دوره" + " " + dt_N[0]["BalanceBeginningMuscle"].ToString();
                    lbl_MuscleINV.Text = "موجودی" + " " + dt_N[0]["MuscleINV"].ToString();
                    lbl_MuscleProduct.Text = "وارده" + " " + dt_N[0]["MuscleProduct"].ToString();
                    lbl_MuscleSend.Text = "صادره" + " " + dt_N[0]["MuscleSend"].ToString();
                    
                }
               
            }
        }
    }
}
