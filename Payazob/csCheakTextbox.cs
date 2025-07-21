namespace Payazob
{
    public class csCheakTextbox
    {
      public bool IsNumber(string text)
      {
          if (text == null)
 return false;   
          System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
          return regex.IsMatch(text);
      }
      public bool Isinteger(string text)
      {
          if (text == null)
 return false;   
          System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");
          return regex.IsMatch(text);
      }
    }
}
