using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmWorkYear : Form
    {
        public frmWorkYear()
        {
            InitializeComponent();
            lbl_WorkYear.Text = " سال کاری " + TARANOM.Properties.Settings.Default.WorkYear.Substring(0, 4);
            int y = int.Parse(BLL.csshamsidate.shamsidate.Substring(0, 4));
            for (int i = 1391; i <= y; i++)
            {
                this.cmb_Year.Items.AddRange(new object[] { i.ToString() });
            }

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (cmb_Year.SelectedIndex > -1)
            {
                TARANOM.Properties.Settings.Default.WorkYear =  cmb_Year.SelectedItem + "/01/01";
                TARANOM.Properties.Settings.Default.Save();
                MessageBox.Show("تغییر سال کاری با موفقیت انجام شد",
                    "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
            }
            else
                MessageBox.Show("سال کاری به درستی انتخاب نشده است",
                                "خطا",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);

            lbl_WorkYear.Text = " سال کاری " + TARANOM.Properties.Settings.Default.WorkYear.Substring(0, 4);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWorkYear_Load(object sender, EventArgs e)
        {

        }


    }
}
