using System.Windows.Forms;

namespace Payazob.CS
{
    public class csMessage
    {
        public bool  ShowMessageSaveYesNo()
        {
            if (MessageBox.Show(" ایا می خواهید این اطلاعات ذخیره شود", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
   return true;
            else
   return false;
        }
    }
}
