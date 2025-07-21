using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Payazob
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {


            foreach (InputLanguage il in InputLanguage.InstalledInputLanguages)
            {
                if (il.Culture.EnglishName.ToLower().Contains("english") || il.Culture.EnglishName.ToLower().Contains("united states"))
                {
                    InputLanguage.CurrentInputLanguage = il;
                }
            }
            InitializeComponent();
            txt_user.Text = TARANOM.Properties.Settings.Default.user.ToString();

            //BLL.User sd = new BLL.User();
            //sd.con();
            //BLL.csFoundry.abc();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool EnterSuccess = false;
        private void btn_login_Click(object sender, EventArgs e)
        {
            EnterSuccess = false;
            int tempx_ = BLL.authentication.x_;
            DAL.csConnectionTest t = new DAL.csConnectionTest();
            if (!t.testConnection())
            {
                MessageBox.Show("ارتباط شما با شبکه قطع شده");
                return;
            }
                BLL.authentication sc = new BLL.authentication();
                if (sc.userloginallow(txt_user.Text, txt_pass.Text))
                {
                    if (tempx_ > 0 && tempx_ != BLL.authentication.x_)
                    {
                        MessageBox.Show("کاربر دیگری قبلا وارد شده لطفا وارد شوید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        EnterSuccess = false;
                        BLL.authentication.x_ = 0;
                    }
                    else
                    {
                    TARANOM.Properties.Settings.Default.user = txt_user.Text;
                    TARANOM.Properties.Settings.Default.Save();
                        EnterSuccess = true;
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("نام کاربری یا پسورد شما صحیح نمی باشد.");
                txt_pass.Text = "";

           
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (BLL.authentication.x_ <= 0)
                Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PointF[] points = {	  new Point(20, 90),
                                  new Point(410, 90),
                                  new Point(410, 200),
                                  new Point(80, 200),
                                  new Point(20, 90)};


		
            Pen pen = new Pen(Color.FromArgb(100, 160, 116), 2);
          //  SolidBrush brush1 = new SolidBrush(Color.FromArgb(0, 60, 116));
            LinearGradientBrush brush0 = new LinearGradientBrush(new Rectangle(0, 0, 500, 250), Color.FromArgb(0, 241, 243), Color.FromArgb(0, 206, 180), 90.0f);
            
            e.Graphics.FillRectangle(brush0, 0, 0, 1500, 1600);
           e.Graphics.DrawLines(pen, points);
            

        }
    }
}
