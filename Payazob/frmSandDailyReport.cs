using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmSandDailyReport : Form
    {
        public frmSandDailyReport()
        {
            InitializeComponent();

            BLL.csPieces cp = new BLL.csPieces();

            uc_cmbAutoPiecesLine1.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            uc_cmbAutoPiecesLine1.DisplayMember = "xName";
            uc_cmbAutoPiecesLine1.ValueMember = "x_";
            uc_cmbAutoPiecesLine1.SelectedIndex = -1;

            uc_cmbAutoPiecesLine2.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            uc_cmbAutoPiecesLine2.DisplayMember = "xName";
            uc_cmbAutoPiecesLine2.ValueMember = "x_";
            uc_cmbAutoPiecesLine2.SelectedIndex = -1;

            BLL.csShift shift = new BLL.csShift();
            uc_cmbShift.DataSource = shift.mShiftDataTable();
            uc_cmbShift.DisplayMember = "xShiftName";
            uc_cmbShift.ValueMember = "x_";
            uc_cmbShift.SelectedIndex = -1;


            uc_cmbSuperviser.DataSource = uc_cmbShift.DataSource;
            uc_cmbSuperviser.ValueMember = "xSandOperator";
            uc_cmbSuperviser.DisplayMember = "xSandOperator";
            uc_cmbSuperviser.SelectedIndex = -1;

            uc_cmbAutoMachine.DataSource = new BLL.GenGroup.csGenGroup().SlGenGroup("MACHINENME");
            uc_cmbAutoMachine.ValueMember = "x_";
            uc_cmbAutoMachine.DisplayMember = "xName";
            uc_cmbAutoMachine.SelectedIndex = -1;

            uc_TextBoxDate1.Text = BLL.csshamsidate.shamsidate;

        }
       public string TextBoxDate1 = "";
       public string txtMechanical = "";
       public string txtElectric = "";
       public string txtReportOther = "";
       public string txtComment = "";

       public int? x_ = -1;
       public int? PiceasLine1_ = -1;
       public int? PiceasLine2_ = -1;
       public int? Machine = -1;
       public int? Shift_ = -1;

       public bool accept = false;
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (
                //(int?)uc_cmbAutoPiecesLine1.SelectedValue != null &&
                //(int?)uc_cmbAutoPiecesLine2.SelectedValue != null &&
                (int?)uc_cmbShift.SelectedValue != null && uc_TextBoxDate1.accept == true && uc_cmbAutoMachine.SelectedValue != null 
              )
            {
                TextBoxDate1 = uc_TextBoxDate1.Text;
                txtMechanical = uc_txtMechanical.Text;
                txtElectric = uc_txtElectric.Text;
                txtReportOther = uc_txtReportOther.Text;
                txtComment = uc_txtComment.Text;

                PiceasLine1_ = (int?)uc_cmbAutoPiecesLine1.SelectedValue;
                PiceasLine2_ = (int?)uc_cmbAutoPiecesLine2.SelectedValue;
                Machine = (int?)uc_cmbAutoMachine.SelectedValue;
                
                Shift_ = (int?)uc_cmbShift.SelectedValue;
                accept = true;
                this.Close();
            }
            else
                MessageBox.Show("داده ها را به طور کامل وارد کنید.");
        }
        public void FillForm()
        {
            uc_TextBoxDate1.Text = TextBoxDate1;
            uc_txtMechanical.Text = txtMechanical;
            uc_txtElectric.Text = txtElectric;
            uc_txtReportOther.Text = txtReportOther;
            uc_txtComment.Text = txtComment;

            uc_cmbAutoPiecesLine1.SelectedValue = PiceasLine1_ == null ? -1 : PiceasLine1_;
            uc_cmbAutoPiecesLine2.SelectedValue = PiceasLine2_ == null ? -1 : PiceasLine2_;
            uc_cmbAutoMachine.SelectedValue = Machine == null ? -1 : Machine;
            uc_cmbShift.SelectedValue = Shift_;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
