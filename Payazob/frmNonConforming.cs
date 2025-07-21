using System;
using System.Linq;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmNonConforming : Form
    {
        public frmNonConforming()
        {
            InitializeComponent();
            //BLL.csPieces cp = new BLL.csPieces();

            //uc_cmbAuto_piece.DataSource = cp.mPiecesDataTable((int)CS.csEnum.GenFactoryGroupPieces.Site1);
            //uc_cmbAuto_piece.DisplayMember = "xName";
            //uc_cmbAuto_piece.ValueMember = "x_";
            //uc_cmbAuto_piece.SelectedIndex = -1;

            //BLL.csQualityControl cs = new BLL.csQualityControl();
            //string st = cs.MaxFormNumber();
            //if (st == null)
            //{
            //    uc_txtFormNumber.Text = "1";
                
            //}
            //else
            //uc_txtFormNumber.Text = (int.Parse(st ) + 1).ToString();

            //uc_mtxtDate1.Text = BLL.csshamsidate.shamsidate;
        }


        private bool Fillingright()
        {
            bool flag = false;
            csCheakTextbox ch = new csCheakTextbox();

            foreach (UC.uc_TextBox txt in splitContainer1.Panel1.Controls.OfType<UC.uc_TextBox>())
            {
                if (txt.IsNumber)
                if (txt.Text == "")
                {
                    txt.Text = "0";
                }
                if (txt.IsTime)
                if (txt.Text == "")
                { txt.Text = "00:00"; }
            }

            if (uc_cmbAuto_piece.SelectedIndex > -1 && uc_mtxtDate1.accept && uc_mtxtDateActionApproval.accept 
                && uc_mtxtDateNonConformTitle.accept && uc_mtxtDateResult.accept && uc_mtxtDateTakenAction.accept)
            {
                flag = true;
            }

            return flag;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show(" ایا می خواهید این اطلاعات  ارسال شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    if (!Fillingright())
            //    { MessageBox.Show("اطلاعات ورودی کامل نیست."); return; }
            //    BLL.csQualityControl cs = new BLL.csQualityControl();
            //    if (cs.CountFormNumber(uc_txtFormNumber.Text) > 0)
            //    { MessageBox.Show("شماره فرم تکراری است"); return; }
            //    cs.InsertNonconforming((int)uc_cmbAuto_piece.SelectedValue, uc_txtSubstancePiece.Text, int.Parse(uc_txtQuarantineNumber.Text), uc_txtTime.Text
            //        , uc_txtFormNumber.Text, uc_mtxtDateNonConformTitle.Text, uc_txtNonConformTitle.Text, uc_mtxtDateTakenAction.Text, uc_txtTakenAction.Text, uc_mtxtDateActionApproval.Text
            //        , uc_txtActionApproval.Text, uc_mtxtDateResult.Text, uc_txtResult.Text);

            //    MessageBox.Show("ارسال با موفقیت انجام شد.");
            //}
        }
    }
}
