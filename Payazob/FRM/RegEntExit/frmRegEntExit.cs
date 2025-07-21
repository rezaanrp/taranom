using System;
using System.Windows.Forms;

namespace Payazob.FRM.RegEntExit
{
    public partial class frmRegEntExit : Form
    {
        public frmRegEntExit(string UserType )
        {
            InitializeComponent();
            Show_DataType();
            usrtyp = UserType;

            if (UserType == "USER")
            {
                dataGridViewT.ReadOnly = true;
                dataGridViewD.ReadOnly = true;
                dataGridViewR.ReadOnly = true;

                dataGridViewT.AllowUserToAddRows = false;
                dataGridViewD.AllowUserToAddRows = false;
                dataGridViewR.AllowUserToAddRows = false;

                dataGridViewT.AllowUserToDeleteRows = false;
                dataGridViewD.AllowUserToDeleteRows = false;
                dataGridViewR.AllowUserToDeleteRows = false;

                saveToolStripButton_R.Visible = false;
                toolStripButton_SaveD.Visible = false;
                SavetoolStripButton_T.Visible = false;

                toolStripButtonDelete_T.Visible = false;
                toolStripButtonDelete_D.Visible = false;
                toolStripButtonDelete_R.Visible = false;
            }
        }
        DAL.RegEntExit.DataSet_RegEntExit.mRegEntExitTypeDataTable dt_T;
        DAL.RegEntExit.DataSet_RegEntExit.mReEntExitTypeDetailDataTable dt_D;
        DAL.RegEntExit.DataSet_RegEntExit.mRegEntExitDataTable dt_R;
        string usrtyp = "USER";
        private void SavetoolStripButton_Pieces_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridViewT.EndEdit();
            dataGridViewD.EndEdit();
            dataGridViewR.EndEdit();


            BLL.RegEntExit.csRegEntExit cs = new BLL.RegEntExit.csRegEntExit();
            MessageBox.Show(cs.UdmRegEntExitType(dt_T), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show_DataType();

        }

        private void toolStripButton_SaveD_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridViewT.EndEdit();
            dataGridViewD.EndEdit();
            dataGridViewR.EndEdit();

            BLL.RegEntExit.csRegEntExit cs = new BLL.RegEntExit.csRegEntExit();
            MessageBox.Show(cs.UdmReEntExitTypeDetail(dt_D), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

           // Show_DataTypeD();

        }

        private void dataGridViewT_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((int?)dataGridViewT["x_", e.RowIndex].Value > 0)
            {
                BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
                Show_DataTypeD((int)dataGridViewT["x_", e.RowIndex].Value) ;
            }
        }



        private void dataGridViewR_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToolStripButton_R_Click(object sender, EventArgs e)
        {
            this.Validate();
            dataGridViewT.EndEdit();
            dataGridViewD.EndEdit();
            dataGridViewR.EndEdit();

            BLL.RegEntExit.csRegEntExit cs = new BLL.RegEntExit.csRegEntExit();
            MessageBox.Show(cs.UdmRegEntExit(dt_R), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewD_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((int?)dataGridViewD["x_", e.RowIndex].Value > 0)
            {
                BLL.CustomerReturn.csCustomerReturn cs = new BLL.CustomerReturn.csCustomerReturn();
                Show_DataTypeR((int)dataGridViewD["x_", e.RowIndex].Value);
            }
        }
        void Show_DataType()
        {
            dt_T = new BLL.RegEntExit.csRegEntExit().mRegEntExitType();
            bindingSourceT.DataSource = dt_T;
            dataGridViewT.DataSource = bindingSourceT;
            bindingNavigatorT.BindingSource = bindingSourceT;
            GenerateT();
        }

        void Show_DataTypeD(int x_)
        {

            dt_D = new BLL.RegEntExit.csRegEntExit().mReEntExitTypeDetail(x_);
            bindingSourceD.DataSource = dt_D;
            dataGridViewD.DataSource = bindingSourceD;
            bindingNavigatorD.BindingSource = bindingSourceD;
            dt_D.xRegEntExitType_Column.DefaultValue = x_;
            GenerateD();
        }
        void Show_DataTypeR(int x_)
        {
            dt_R = new BLL.RegEntExit.csRegEntExit().mRegEntExit(x_, uc_Filter_Date1.DateFrom, uc_Filter_Date1.DateTo);
            bindingSourceR.DataSource = dt_R;
            dataGridViewR.DataSource = bindingSourceR;
            bindingNavigatorR.BindingSource = bindingSourceR;
            dt_R.xRegEntExitTypeDetail_Column.DefaultValue = x_;
            dt_R.xSupplier_Column.DefaultValue = BLL.authentication.x_;
            dt_R.xDateColumn.DefaultValue = BLL.csshamsidate.shamsidate;
            GenerateR();

        }
        void GenerateT()
        {
            dataGridViewT.Columns["x_"].Visible = false;
            dataGridViewT.Columns["xName"].HeaderText = "نوع مدرک";
            dataGridViewT.Columns["xName"].Width = 200;
        }
        void GenerateD()
        {
            dataGridViewD.Columns["x_"].Visible = false;
            dataGridViewD.Columns["xRegEntExitType_"].Visible = false;
            dataGridViewD.Columns["xName"].HeaderText = "تفضیل";
            dataGridViewD.Columns["xName"].Width = 200;


        }
        void GenerateR()
        {
            dataGridViewR.Columns["x_"].Visible = false;
           dataGridViewR.Columns["xRegEntExitTypeDetail_"].Visible = false;
            dataGridViewR.Columns["xSupplier_"].Visible = false;

            dataGridViewR.Columns["xDate"].Visible = false;

            dataGridViewR.Columns["xDescription"].HeaderText = "شرح";
            dataGridViewR.Columns["xDate"].HeaderText = "تاریخ ثبت";
            dataGridViewR.Columns["xDeliverDate"].HeaderText = "تاریخ ارسال و دریافت";
            dataGridViewR.Columns["xPerGiveName"].HeaderText = "تحویل دهنده";
            dataGridViewR.Columns["xPerGetName"].HeaderText = "تحویل گیرنده";
            dataGridViewR.Columns["xDateRefer"].HeaderText = "تاریخ ارجاع";
            dataGridViewR.Columns["xPerReferName"].HeaderText = "ارجاع دهنده";
            dataGridViewR.Columns["xPerReferToName"].HeaderText = "تحویل به";
            dataGridViewR.Columns["xReceiverName"].HeaderText = "گیرنده";
            dataGridViewR.Columns["xComment"].HeaderText = "توضیحات";

            dataGridViewR.Columns["xDateRefer"].DisplayIndex = 7;


        }

        private void frmRegEntExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridViewR.IsCurrentCellInEditMode)
                if (dataGridViewR.CurrentCell.EditedFormattedValue.ToString().Length > 15 && e.KeyChar != '\b')
                    dataGridViewR.Columns[dataGridViewR.CurrentCell.ColumnIndex].Width += 5;
                else if (dataGridViewR.Columns[dataGridViewR.CurrentCell.ColumnIndex].Width > 100 && e.KeyChar == '\b')
                    dataGridViewR.Columns[dataGridViewR.CurrentCell.ColumnIndex].Width -= 5;  
        }

        private void dataGridViewT_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {

        }
    }
}
