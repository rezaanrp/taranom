using System;

namespace Validation
{
    public  class time
  {
      public bool validtime(string time)
      {
         try
          {
              if (time.Length != 5) return false;
              if (Convert.ToInt32(time.Substring(0, 2)) > 23) return false;
              if (Convert.ToInt32(time.Substring(0, 2)) < 0) return false;
              if (Convert.ToInt32(time.Substring(3, 2)) > 59) return false;
              if (Convert.ToInt32(time.Substring(3, 2)) < 0) return false;
              if (time.Substring(2, 1) != ":") return false;
              return true;
          }
          catch { return false; }

          
      }
      public bool bigertime(string smaltime, string bigtime)
      {
          DateTime st = Convert.ToDateTime(smaltime);
          DateTime bt = Convert.ToDateTime(bigtime);

          if (bt > st) return true;
          else return false;
      }
      public string returnexpandtime( string  timeinput)
      {

          if (timeinput.Length == 2)
              timeinput += ":00";
          else  if (timeinput.Length == 1)
          {
              timeinput = "0" + timeinput;
              timeinput += ":00";
          }
          else if (timeinput.Length == 4)
          {
              timeinput += "0";    
          }
          else if (timeinput.Length == 3)
              timeinput += "00";
          return timeinput;
          
      }
   
    }
}
