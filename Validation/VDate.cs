namespace Validation
{
    public class VDate
    {
       public bool ValidationDate( string InputDate)
       {
           bool acceptDate = false;

           if (InputDate.Length != 10)
           {
               return false;
           }
           string date = InputDate;

           int day = 0;
           int mon = 0;
           int year = 0;

           if (!int.TryParse(date.Substring(8, 2), out day) ||
               !int.TryParse(date.Substring(5, 2), out mon) ||
               !int.TryParse(date.Substring(0, 4), out year))
           {
               return false;
           }
           if (year < 1300 || year > 1500 || day > 31 || 1 > day || mon > 12 || mon < 1)
           {
               acceptDate = false;
           }
           else
               acceptDate = true;

           return acceptDate;
       }
    }
}
