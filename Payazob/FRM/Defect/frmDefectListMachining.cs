using System;
using System.Windows.Forms;
using BLL.Defect;

namespace Payazob.FRM.Defect
{
    public partial class frmDefectListMachining : Form
    {
        public frmDefectListMachining()
        {
            InitializeComponent();
            this.xPieces_ = -1;
            this.xProductOperation_ = -1;
            this.dataGridView_Pi.DataSource = new BLL.csPieces().mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site3);
            this.dataGridView_Pi.Columns["xName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView_Pi.Columns["x_"].Visible = false;
            this.dataGridView_Pi.Columns["Piece"].Visible = false;
            this.dataGridView_Pi.Columns["xName"].HeaderText = "نام محصول";


            this.dt_T = new csDefect().mDefectListTypeMachining();
            this.dataGridViewDefectType.DataSource = this.dt_T;

            GenerateType();

            
        }
        private int xPieces_;
        private int xProductOperation_;
        private int DefectType_;

        private void dataGridView_PI_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1)
            {
   this.dataGridView_OP.DataSource = new BLL.ProductOperation.csProductOperation().ProductOperation((int)this.dataGridView_Pi["x_", e.RowIndex].Value);
   this.dataGridView_OP.Columns["xOpName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
   this.dataGridView_OP.Columns["x_"].Visible = false;
   this.dataGridView_OP.Columns["xPieces_"].Visible = false;
   this.dataGridView_OP.Columns["xDiscription"].Visible = false;
   this.dataGridView_OP.Columns["xPerId_"].Visible = false;
   
   this.dataGridView_OP.Columns["xOpName"].HeaderText = "نام OP";
            }
            ShowData();
            ShowDataDefectCause();

        }
        private DAL.Defect.DataSet_DefectList.mDefectListMachiningDataTable dt_D;
        private DAL.Defect.DataSet_DefectList.mDefectListTypeMachiningDataTable dt_T;
        private DAL.Defect.DataSet_DefectList.mDefectListCauseMachiningDataTable dt_C;

        private void Generate()
        {
            this.dataGridView_Df.Columns["xDefectName"].Width = 300;
            this.dataGridView_Df.Columns["xDefectName"].HeaderText = "نام ضایع";
            this.dataGridView_Df.Columns["xDefectActive"].HeaderText = "فعال باشد؟";
            this.dataGridView_Df.Columns["xCode"].HeaderText = "کد";
            this.dataGridView_Df.Columns["x_"].Visible = false;
            this.dataGridView_Df.Columns["xPieces_"].Visible = false;
            this.dataGridView_Df.Columns["xProductOperation_"].Visible = false;


        }
        void GenerateType()
        {
            this.dataGridViewDefectType.Columns["xName"].HeaderText = "نوع ضایعات ";
            this.dataGridViewDefectType.Columns["xCode"].HeaderText = "کد";
          
            this.dataGridViewDefectType.Columns["x_"].Visible = false;
        }
        void GenerateCause()
        {
            this.dataGridViewDefectCause.Columns["xName"].HeaderText = "علت ضایعات ";
            this.dataGridViewDefectCause.Columns["xCode"].HeaderText = "کد ";
            this.dataGridViewDefectCause.Columns["xDefectListTypeMachining_"].Visible = false;
            this.dataGridViewDefectCause.Columns["x_"].Visible = false;
        }
        
        
        void ShowData()
        {
            if ((this.dataGridView_Pi.SelectedRows.Count > 0) )
            {
   this.dt_D = new csDefect().mDefectListMachining(new int?((int)this.dataGridView_Pi.SelectedRows[0].Cells["x_"].Value));
   this.bindingSource1.DataSource = this.dt_D;
   this.dataGridView_Df.DataSource = this.bindingSource1;
   this.bindingNavigator1.BindingSource = this.bindingSource1;
   this.Generate();
   this.xPieces_ = (int)this.dataGridView_Pi.SelectedRows[0].Cells["x_"].Value;
   //this.xProductOperation_ = (int)this.dataGridView_OP.SelectedRows[0].Cells["x_"].Value;
   this.dt_D.xPieces_Column.DefaultValue = this.xPieces_;
 //  this.dt_D.xProductOperation_Column.DefaultValue = this.xProductOperation_;
            }
            //if ((this.dataGridView2.SelectedRows.Count > 0) && (this.dataGridView3.SelectedRows.Count > 0))
            //{
            //    this.dt_T = new csDefect().mDefectListTypeMachining(new int?((int)this.dataGridView3.SelectedRows[0].Cells["x_"].Value));
            //    this.dataGridViewDefectType.DataSource = this.dt_T;

            //    this.xPieces_ = (int)this.dataGridView2.SelectedRows[0].Cells["x_"].Value;
            //    this.xProductOperation_ = (int)this.dataGridView3.SelectedRows[0].Cells["x_"].Value;

            //    this.dt_D.xProductOperation_Column.DefaultValue = this.xProductOperation_;
            //  //  this.dt_T.xProductOperation_Column.DefaultValue = this.xProductOperation_;

            //    GenerateType();
            //}
           

        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            base.Validate();
            this.dataGridView_Df.EndEdit();
            this.dataGridViewDefectType.EndEdit();
            this.dataGridViewDefectCause.EndEdit();
             csDefect defect = new csDefect();
            if (new Payazob.CS.csMessage().ShowMessageSaveYesNo())
            {
   defect.UdDefectListMachining(this.dt_D);
  defect.UdDefectListTypeMachining(this.dt_T);
  defect.UdDefectListCauseMachining(this.dt_C);
            }
            this.dt_D = defect.mDefectListMachining(new int?(this.xPieces_));
            this.dt_T = defect.mDefectListTypeMachining();
            this.dt_C = defect.mDefectListCauseMachining(-1);
            this.bindingSource1.DataSource = this.dt_D;
            this.dataGridView_Df.DataSource = this.bindingSource1;
            this.dataGridViewDefectType.DataSource = dt_T;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.Generate();
            this.dt_D.xPieces_Column.DefaultValue = this.xPieces_;
         //   this.dt_D.xProductOperation_Column.DefaultValue = this.xProductOperation_;
        //    this.dt_T.xProductOperation_Column.DefaultValue = this.xProductOperation_;
            this.dt_C.xDefectListTypeMachining_Column.DefaultValue = this.DefectType_;

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void ShowDataDefectCause()
        {
            if ((this.dataGridView_Pi.SelectedRows.Count > 0) && (this.dataGridView_OP.SelectedRows.Count > 0) && (this.dataGridViewDefectType.SelectedRows.Count > 0))
            {
   this.dt_C = new csDefect().mDefectListCauseMachining((int)this.dataGridViewDefectType.SelectedRows[0].Cells["x_"].Value);
   this.dataGridViewDefectCause.DataSource = this.dt_C;


   this.dt_C.xDefectListTypeMachining_Column.DefaultValue = (int)this.dataGridViewDefectType.SelectedRows[0].Cells["x_"].Value;
   this.DefectType_ = (int)this.dataGridViewDefectType.SelectedRows[0].Cells["x_"].Value;

   this.GenerateCause();

            }
        }
        private void dataGridViewDefectType_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowDataDefectCause();
        }

        private void dataGridView_OP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //ShowData();
            //ShowDataDefectCause();
        }
 


    }
}
