using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob.FRM.FIFO
{
    public partial class FrmInvLocation : Form
    {
        public FrmInvLocation()
        {
            InitializeComponent();

            foreach (InputLanguage il in InputLanguage.InstalledInputLanguages)
            {
                if (il.Culture.EnglishName.ToLower().Contains("en") || il.Culture.EnglishName.ToLower().Contains("en-us") || il.Culture.EnglishName.ToLower().Contains("united states") || il.Culture.EnglishName.ToLower().Contains("english"))
                {
                    InputLanguage.CurrentInputLanguage = il;
                }
            }
        }

        public bool accept = false;
        public string fDate;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            int m, d = 0;
            if (cmb_Year.Text.Length == 1 && cmb_Mon.Text.Length == 2 && cmb_Day.Text.Length == 2)
                if (
                    (
                      ( (int)cmb_Year.Text[0] < 91 && (int)cmb_Year.Text[0] > 64 ) || ( (int)cmb_Year.Text[0] < 123 && (int)cmb_Year.Text[0] > 96 ) 
                    )
                    &&


                    int.TryParse(cmb_Mon.Text, out m) && int.TryParse(cmb_Day.Text, out d))
                {
                    if (m > 0 && m < 21 && d > 0 && d < 21)
                    {
                        accept = true;
                        fDate = cmb_Year.Text.ToUpper() + cmb_Mon.Text + "/" + cmb_Day.Text;
                        this.Close();
                    }

                }
        }

        private void cmb_Day_TextChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Text.Length == (sender as ComboBox).MaxLength)
            {
                this.SelectNextControl((sender as Control), true, true, true, true);
                (sender as ComboBox).SelectedIndex = (sender as ComboBox).FindString((sender as ComboBox).Text);
            }
            int y, m, d = 0;

            if (int.TryParse(cmb_Mon.Text, out m) && int.TryParse(cmb_Day.Text, out d))
            {
                if (cmb_Year.Text.Length == 1 && cmb_Mon.Text.Length == 2 && cmb_Day.Text.Length == 2  &&     
                    (
                      ( (int)cmb_Year.Text[0] < 91 && (int)cmb_Year.Text[0] > 64 ) || ( (int)cmb_Year.Text[0] < 123 && (int)cmb_Year.Text[0] > 96 ) 
                    ) &&
                    m > 0 && m < 21 && d > 0 && d < 21)
                {
                    this.BackColor = Color.LightGreen;
                }
                else
                    this.BackColor = Color.LightPink;
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInvLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (InputLanguage il in InputLanguage.InstalledInputLanguages)
            {
                if (il.Culture.EnglishName.ToLower().Contains("persian") || il.Culture.EnglishName.ToLower().Contains("iran") || il.Culture.EnglishName.ToLower().Contains("farsi"))
                {
                    InputLanguage.CurrentInputLanguage = il;
                }
            }
        }

    }
}
