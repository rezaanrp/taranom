namespace Payazob.CS
{
    public class csDateform
    {
       public string DateOutPut(System.Windows.Forms.Control  cr, int x_ ,int y_)
       {
           
           FRM.frmDate.frmDate fr = new FRM.frmDate.frmDate();

            while ( cr != null)
            {
   x_ += cr.Location.X;
   y_ += cr.Location.Y;

   cr = cr.Parent;
            }
            fr.Location = new System.Drawing.Point(x_ ,y_ );

            fr.ShowDialog();
            if (fr.accept)
   return fr.fDate;
            else
   return "";
       }
    }
}
