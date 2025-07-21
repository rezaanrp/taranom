using System;
using System.Drawing;
using System.Windows.Forms;

namespace PAYAZOBNET.form.coding
{
    public partial class frmeditefinalobject : Form
    {
        public frmeditefinalobject()
        {
            InitializeComponent();
        }
       

        private void buttonX1_Click(object sender, EventArgs e)
        { 
            PAYAIND.csedit insertsource = new PAYAIND.csedit();
            insertsource.updateobject_set2(Convert.ToInt32( usnumericupdown1.Value), lblcod.Text, comboBox1.Text,false);
            MessageBox.Show("ذخیره شد");
            Close();
        }
        private bool drag;
        private Point pointClicked;
        private void frmeditefinalobject_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
   Point pointmoveto;
   // Find the current mouse position in screen coordinates.
   pointmoveto = this.PointToScreen(new Point(e.X, e.Y));
   // Compensate for the position the control was clicked.
   pointmoveto.Offset(-pointClicked.X, -pointClicked.Y);
   // Move the form.
   this.Location = pointmoveto;
            }
        }

        private void frmeditefinalobject_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
   drag = true;
   pointClicked = new Point(e.X, e.Y);
            }
            else drag = false;
        }

        private void frmeditefinalobject_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
