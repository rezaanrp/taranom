using System;
using System.Windows.Forms;

namespace Payazob
{
    public partial class frmUpdateFromSgdb : Form
    {
        public frmUpdateFromSgdb()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (chb_Customer.Checked)
            {
                BLL.csCompony cs = new BLL.csCompony();
                if (cs.SyncCustomer())
                {
                    chb_Customer.Checked = false;
                    chb_Customer.Enabled = false;
                }
                else
                    MessageBox.Show("خطا در بروز رسانی مشتری");
            }
            if (chb_melt.Checked)
            {
                BLL.csMaterial cs = new BLL.csMaterial();
                if (cs.SyncMaterial() && cs.SyncScarb())
                {
                    chb_melt.Checked = false;
                    chb_melt.Enabled = false;
                }
                else
                    MessageBox.Show("خطا در بروز رسانی مواد اولیه");

            }
            if (chb_Pieces.Checked)
            {
                BLL.csPieces cs = new BLL.csPieces();
                if (cs.SyncPieces())
                {
                    chb_Pieces.Checked = false;
                    chb_Pieces.Enabled = false;
                }
                else
                    MessageBox.Show("خطا در بروز رسانی محصولات");
            }
            if (chb_Supplier.Checked)
            {

            }
                
        }
    }
}
