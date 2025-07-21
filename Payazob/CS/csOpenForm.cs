using System.Windows.Forms;
namespace Payazob.CS
{
    public class csOpenForm
    {
        public void FindForm(string frm, string TitleForm)
        {
            Form f;
            switch (frm)
            {


                case "MoldingDownTimeByDetials":
                    f = new Form();


                    break;

                default:
                    return;
                    // f = new Form();
                    // break;
            }
            if (BLL.authentication.objectallow(frm))
            {
                BLL.csEvent Event = new BLL.csEvent();
                Event.eventlogin("LOGIN FORM", "", TitleForm, frm, BLL.authentication.x_.ToString());
                //    if (BLL.authentication.x_ == 5 || BLL.authentication.x_ == 58 || BLL.authentication.x_ == 51 || BLL.authentication.x_ == 26)
                //  {
                f.Text = TitleForm;
                f.Size = new System.Drawing.Size(950, 500);
                f.Show();


                // f.BringToFront();
                //   }
                //    else
                //    {
                //f.Text = TitleForm;
                //f.Size = new System.Drawing.Size(950, 500);
                //f.Show();
                //   }

            }
        }
    }
}
