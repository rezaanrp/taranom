using System.Linq;

namespace PAYAIND
{
    public   class cspersentavailable
  {
      public PAYADATA.dspersentavailable.mpersent_AvailableDataTable selectpersentbydate(int fromyear,int frommonth,int toyear,int tomonth)
      {
          PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter db = new PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter();
          return db.GetDataBydate(fromyear, frommonth, toyear, tomonth);
      }
      public void saveupdatepersent(PAYADATA.dspersentavailable.mpersent_AvailableDataTable dt)
      {
          PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter db = new PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter();
          db.Update(dt);
      }
      public void insertavailable(int year, int month, string devicecod, string number, double allhour, double avaihour, double persent)
      {
          PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter db = new PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter();
          db.Insertavailable(month, year, devicecod, number, allhour, avaihour, persent);
      }
      public bool existavailabilityfordevice(string devicecod, string number, int year, int month)
      {
          PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter db = new PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter();
          if (db.GetData().Where(c => c.xdevicecod == devicecod && c.xnumber == number && c.xyear == year && c.xmonth == month).Any()) return true;
          return false;
      }
      public void updateavailable(int year, int month, string devicecod, string number, double allhour, double avaihour, double persent)
      {
          PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter db = new PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter();
          db.Updateexistpersent(allhour, avaihour, persent, month, year, devicecod, number);       
      }
      public double calcinterupttime(int year, int month, string devicecod, string number)
      {
          double interuptcomp;
          double interuptplan;

          PAYADATA.interuptcomp.data_interupt_compDataContext db = new PAYADATA.interuptcomp.data_interupt_compDataContext();
          try
          {
               interuptcomp = double.Parse(db.interupt_comps.Where(c => c.xdate_start_interupt.StartsWith(year.ToString() + "/" + month.ToString()) && c.xdevice_cod == devicecod + "-" + number).Select(c => c.xtime_interupt).Sum().ToString());
          }
          catch { interuptcomp = 0; }
              PAYADATA.interuptplan.lqinterupt_planDataContext dbb = new PAYADATA.interuptplan.lqinterupt_planDataContext();
              try
              {
                   interuptplan = double.Parse(dbb.minterupt_plans.Where(c => c.xdate_endinterupt.StartsWith(year.ToString() + "/" + month.ToString()) && c.xdevice_cod == devicecod + "-" + number).Select(c => c.xtime_interupt).Sum().ToString());
              }
              catch { interuptplan = 0; }
          return interuptcomp + interuptplan;
      }
      public double calacpersentavailabilityformonth(int year,int month)
      {
          PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter db = new PAYADATA.dspersentavailableTableAdapters.mpersent_AvailableTableAdapter();
          return db.GetDataBydate(year, month, year, month).Select(c => c.xpersentavailable).Average();
      }
      public double insertandcalacpersentavailabilityformonth(int year, int month)
      {double i= calacpersentavailabilityformonth(year ,month);
          PAYADATA.dspersentavailableTableAdapters.mpersent_availability_monthTableAdapter db = new PAYADATA.dspersentavailableTableAdapters.mpersent_availability_monthTableAdapter();
          if (db.GetData().Where(c => c.xdate == year.ToString() + "/" + month.ToString()).Any())
              db.UpdateQuery(i, year.ToString() + "/" + month.ToString());
          else 
          db.Insert(year.ToString()+"/"+month.ToString(),i);
          return i;
      }
      public PAYADATA.dspersentavailable.mpersent_availability_monthDataTable selectpersentavailable_month(string fromdate, string todate)
      {
          PAYADATA.dspersentavailableTableAdapters.mpersent_availability_monthTableAdapter db = new PAYADATA.dspersentavailableTableAdapters.mpersent_availability_monthTableAdapter();
          return db.GetDataBy(todate, fromdate);
      }

  

    }
}
