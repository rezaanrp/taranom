using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class uc_ChangePassword : UserControl
    {
        public uc_ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            BLL.authentication cs = new BLL.authentication();
            if (!cs.TestCurrentPass(uc_txtBoxOldPass.Text))
            {
                MessageBox.Show("رمز عبور صحیح نمی باشد");
                return;
            }
            if (uc_txtBoxNewPass.Text == uc_txtBoxRePass.Text)
            {
                cs.ChangePassword(uc_txtBoxRePass.Text);
                MessageBox.Show("رمز عبور با موفقیت تغییر یافت.");
            }
            else
                MessageBox.Show("عدم تطابق");
            this.ParentForm.Close();
        }

        private void uc_txtBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            if (uc_txtBoxNewPass.Text != uc_txtBoxRePass.Text)
            {
                uc_txtBoxNewPass.BackColor = Color.Pink;
                uc_txtBoxRePass.BackColor = Color.Pink;
            }
            else
            {
                uc_txtBoxNewPass.BackColor = Color.White;
                uc_txtBoxRePass.BackColor = Color.White;
            }
        }
    }
}
