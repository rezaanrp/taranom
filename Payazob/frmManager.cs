using System;
using System.Drawing;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }
 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            PointF[] points = {	  new Point(20, 90),
                                  new Point(410, 90),
                                  new Point(410, 200),
                                  new Point(80, 200),
                                  new Point(20, 90)};

            System.Drawing.Drawing2D.LinearGradientBrush brush0 =
                new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, panel1.Width, panel1.Height),
                    Color.FromArgb(64, 64, 64), Color.FromArgb(0, 0, 0), 0.0f);

            e.Graphics.FillRectangle(brush0, 0, 0, 1500, 1600);
        }





        private void glassButtonINV_Click(object sender, EventArgs e)
        {
            MyControl.Chart.uc_ChartInvCollect cnt = new MyControl.Chart.uc_ChartInvCollect();
            cnt.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(cnt);
        }

        private void glassButton_EXit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
