using System.Linq;

namespace Validation
{
    public class Vuc_cmbAuto
    {
       public bool NotNullUc_cmbAuto(ControlLibrary.uc_cmbAuto cmb)
       {
           return cmb.ISInTheList();
       }
       public bool NotNullContent(System.Windows.Forms.Control ctr)
       {
           bool flag = true;
           foreach (ControlLibrary.uc_cmbAuto cmb in ctr.Controls.OfType<ControlLibrary.uc_cmbAuto>())
           {
               flag = NotNullUc_cmbAuto(cmb) & flag;
           }
           return flag;
       }
    }
}
