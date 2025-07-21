using System;
using System.Windows.Forms;

namespace Payazob.FRM.MaterialLocation
{
    public partial class frmMaterialOfLocation_D : Form
    {
        public frmMaterialOfLocation_D()
        {
            InitializeComponent();
        }

        public bool flagCancel = false;
        public bool flagEdit = false;

        private void button1_Click(object sender, EventArgs e)
        {
            flagCancel = true;
            this.Close();
        }

       
     
    }
}
