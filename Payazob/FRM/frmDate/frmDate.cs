using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.frmDate
{
    public partial class frmDate : Form
    {
        public frmDate()
        {
            InitializeComponent();
            cmb_Day.Text = BLL.csshamsidate.shamsidate.Substring(8, 2);
            cmb_Mon.Text = BLL.csshamsidate.shamsidate.Substring(5, 2);
            cmb_Year.Text = BLL.csshamsidate.shamsidate.Substring(0, 4);
        //    fDate = BLL.csshamsidate.shamsidate;
        }
       public string fDate = BLL.csshamsidate.shamsidate;
        //public string fDate { get; set; }
        public void SetDate(String Dt)
        {
            if (new Validation.VDate().ValidationDate(Dt))
            {
                cmb_Day.Text = Dt.Substring(8, 2);
                cmb_Mon.Text = Dt.Substring(5, 2);
                cmb_Year.Text = Dt.Substring(0, 4);
            }
        }
        public bool accept = false;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            int y,m,d = 0;
            if(cmb_Year.Text.Length == 4 && cmb_Mon.Text.Length == 2 && cmb_Day.Text.Length == 2)
            if (int.TryParse(cmb_Year.Text, out y) && int.TryParse(cmb_Mon.Text, out m) && int.TryParse(cmb_Day.Text, out d))
            {
                if (y > 1389 && y < 1405 && m > 0 && m < 13 && d > 0 && d < 32)
                {
                    accept = true;
                    fDate = cmb_Year.Text + "/" + cmb_Mon.Text + "/" + cmb_Day.Text;
                    this.Close();
                }
            }
       //     lbl_Date.Text = uc_cmbAuto_Year.Text + "/" + uc_cmbAuto_Month.Text + "/" + uc_cmbAutoDay.Text;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDate_Load(object sender, EventArgs e)
        {
            lbl_CurrentDate.Text = BLL.csshamsidate.shamsidate;
        }


        private void cmb_Day_TextChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Text.Length == (sender as ComboBox).MaxLength)
            {
                this.SelectNextControl((sender as Control), true, true, true, true);
                (sender as ComboBox).SelectedIndex = (sender as ComboBox).FindString((sender as ComboBox).Text);
            }
            int y,m,d = 0;
      
            if (int.TryParse(cmb_Year.Text, out y) && int.TryParse(cmb_Mon.Text, out m) && int.TryParse(cmb_Day.Text, out d))
            {
                if ( cmb_Year.Text.Length == 4 && cmb_Mon.Text.Length == 2 && cmb_Day.Text.Length == 2 &&  y > 1389 && y < 1405  && m > 0  &&  m < 13  &&  d > 0 && d < 32 )
                {
                    this.BackColor = Color.LightGreen;
                }
                else
                    this.BackColor = Color.LightPink;
            }


        }

 


    }
}
