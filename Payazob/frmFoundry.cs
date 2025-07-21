using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmFoundry : Form
    {
        public frmFoundry()
        {
            InitializeComponent();
        }
        private void frmFoundry_Load(object sender, EventArgs e)
        {
            BLL.csShift shift = new BLL.csShift();
            cmb_shift.DataSource = shift.mShiftDataTable();
            cmb_shift.DisplayMember = "xShiftName";
            cmb_shift.ValueMember = "x_";
            cmb_shift.SelectedIndex = -1;

            cmb_superviser.DataSource = cmb_shift.DataSource;

            cmb_superviser.ValueMember = "xShiftSuperviser";
            cmb_superviser.DisplayMember = "xShiftSuperviser";
            cmb_superviser.SelectedIndex = -1;

            uc_TextBoxDate1.Text = BLL.csshamsidate.shamsidate;
        }

        bool cheaketbox()
        {
            if (rdb_khakestari.Checked == false && rdb_daktil.Checked == false)
                return false;
            if (!((int)cmb_shift.SelectedValue > 0))
                return false;
            return true;
        }


        public string txtDate;
        public int ReceivedMelt;
        public int FowardMelt;
        public int CastedMold;
        public int SlagWeight;
        public string txt_comment;
        public bool daktil;
        public int shift;
        public bool Accept;


        private void btn_Send_Click(object sender, EventArgs e)
        {
            BLL.csFoundry sc = new BLL.csFoundry();

            if (MessageBox.Show(" ایا می خواهید این اطلاعات مصرفی کوره ارسال شود", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cheaketbox())
                {
                    txtDate = uc_TextBoxDate1.Text;
                    ReceivedMelt = int.Parse(uc_txt_ReceivedMelt.textWithoutcomma == null ? "0" : uc_txt_ReceivedMelt.textWithoutcomma);
                    FowardMelt = int.Parse(uc_txt_FowardMelt.textWithoutcomma == null ? "0" : uc_txt_FowardMelt.textWithoutcomma);
                    CastedMold = int.Parse(uc_txt_CastedMold.textWithoutcomma == null ? "0" : uc_txt_CastedMold.textWithoutcomma);
                    SlagWeight = int.Parse(uc_txt_SlagWeight.textWithoutcomma == null ? "0" : uc_txt_SlagWeight.textWithoutcomma);
                    txt_comment = uc_txt_comment.Text;
                    daktil = rdb_daktil.Checked;
                    shift = (int)cmb_shift.SelectedValue;
                    Accept = true;
                    this.Close();
                }
                else
                    MessageBox.Show("اطلاعات ورودی کامل نیست.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Zinter_Click(object sender, EventArgs e)
        {
            //Foundry.frmFoundryZinter frm = new Foundry.frmFoundryZinter();

            //if (cmb_shift.SelectedValue != null || uc_TextBoxDate1.accept)
            //{
            //    frm.Shift_ = (int?)cmb_shift.SelectedValue;
            //    frm.DateZinter = uc_TextBoxDate1.Text;
            //}
            //frm.ShowDialog();
        }
    }
}
