using System.Linq;

namespace PAYAIND
{
    public  class csserviceprogram
   {
       public bool insertservice(int id,string date,bool monthly,string devicecod,string number,string timestart,string timeendm,string explain)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
           PAYADATA.mserviceprogram tb = new PAYADATA.mserviceprogram();
           tb.xdate =( date); tb.xdevicecod = devicecod; tb.xexplain = explain;
           tb.xidservice = id; tb.xdevicenumber = number;
           tb.xMonthly = monthly; tb.xtimeend = timeendm;
           tb.xtimestart = timestart; tb.xresult = 0;
           db.mserviceprograms.InsertOnSubmit(tb);  
           db.SubmitChanges();
           return true;  
           
       }
       public int returnidservic(string date, string coddevice,string number)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
         return  db.mserviceprograms.Where(c => c.xdate == date && c.xdevicecod == coddevice && c.xdevicenumber==number).Select(c => c.xid).Single();
       }
       public bool returntypeservic(string date, string coddevice,string number)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
           return db.mserviceprograms.Where(c => c.xdate == date && c.xdevicecod == coddevice && c.xdevicenumber == number).Select(c => c.xMonthly).Single();
;
       }
       public PAYADATA.dataserservicefordevice.mserviceprogramDataTable selectservicedetails(int xid)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramTableAdapter();
          return  db.GetDataBy(xid);
       }
       public void updateprogramservice(PAYADATA.dataserservicefordevice.mserviceprogramDataTable dt)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramTableAdapter();
           db.Update(dt);
       }
       public IQueryable selectservice(string year1,string month1,string year2,string month2)
       {
           string d,d2;
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
          if (month1.Length>1)
            d = month1.ToString();
           else   d = "0"+month1.ToString();
          if (month2.Length > 1)
              d2 = month2.ToString();
          else d2 = "0" + month2.ToString();
          return db.mserviceprogramheaders.Where(c => string.Compare(c.xmonth, d) >= 0 && string.Compare(c.xmonth, d2) <= 0 && string.Compare(c.xyear, year1) >= 0 && string.Compare(c.xyear, year2)<=0);
       }
       public PAYADATA.dataserservicefordevice.mserviceprogramheaderDataTable selectservicebydataset(string year1, string month1, string year2, string month2)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter();

           string d, d2;
           if (month1.Length > 1)
               d = month1;
           else d = "0" + month1;
           if (month2.Length > 1)
               d2 = month2;
           else d2 = "0" + month2;
           return db.GetDataBy1(year1,year2);
       }
       public PAYADATA.dataserservicefordevice.mserviceprogramheaderDataTable selectservicebydatasetnet(string year1, string month1, string year2, string month2)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter();

           string d, d2;
           if (month1.Length > 1)
               d = month1;
           else d = "0" + month1;
           if (month2.Length > 1)
               d2 = month2;
           else d2 = "0" + month2;
           return db.GetDataBy2net(year1, year2);
       }
       public PAYADATA.dataserservicefordevice.mserviceprogramheaderDataTable selectservicebydatasetproduct(string year1, string month1, string year2, string month2)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter();

           string d, d2;
           if (month1.Length > 1)
               d = month1;
           else d = "0" + month1;
           if (month2.Length > 1)
               d2 = month2;
           else d2 = "0" + month2;
           return db.GetDataBy2product(year1, year2);
       }
       public PAYADATA.dataserservicefordevice.mserviceprogramheaderDataTable selectservicebydatasetplan(string year1, string month1, string year2, string month2)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter();

           string d, d2;
           if (month1.Length > 1)
               d = month1;
           else d = "0" + month1;
           if (month2.Length > 1)
               d2 = month2;
           else d2 = "0" + month2;
           return db.GetDataByplan(year1, year2);
       }
       public PAYADATA.dataserservicefordevice.mserviceprogramheaderDataTable selectservicebydatasetmanage(string year1, string month1, string year2, string month2)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter();

           string d, d2;
           if (month1.Length > 1)
               d = month1;
           else d = "0" + month1;
           if (month2.Length > 1)
               d2 = month2;
           else d2 = "0" + month2;
           return db.GetDataBy2manage(year1, year2);
       }
       public PAYADATA.dataserservicefordevice.ViewprogramservicesDataTable selectserviceforprint(int xid)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.ViewprogramservicesTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.ViewprogramservicesTableAdapter();
           return db.GetDataBy(xid);
       }
       public void saveheaderservice(PAYADATA.dataserservicefordevice.mserviceprogramheaderDataTable dt)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter();
           db.Update(dt);
       }
       public void removeserviceheader(int id)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mserviceprogramheaderTableAdapter();
           db.DeleteQuery(id);

       }
       public void deleteservice(int id)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
           PAYADATA.mserviceprogram tb = new PAYADATA.mserviceprogram();
           tb = db.mserviceprograms.Where(c => c.xid == id).Single();
           db.mserviceprograms.DeleteOnSubmit(tb);
           db.SubmitChanges();
       }
       public void update(int id,string date, bool monthly, string devicecod, string timestart, string timeend, string explain,int result)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
           PAYADATA.mserviceprogram tb = db.mserviceprograms.Where(c => c.xid == id).Single();
           tb.xdate = (date); tb.xdevicecod = devicecod; tb.xexplain = explain;
           tb.xMonthly = monthly; tb.xtimeend = timeend;
           tb.xtimestart = timestart; tb.xresult = result;          
           db.SubmitChanges();           
       }
       public IQueryable existservice(string date)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
           return db.mserviceprograms.Where(c =>(c.xdate== date)).Join(db.mdetailsdevices , a=> a.xdevicecod,b=> b.xcoddevice,
               (a,b)=> new {a.xdate,a.xdevicenumber,b.xnamedevice});
       }

       public IQueryable selectserviceforview(string fromdate,string todate)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
           return db.mserviceprograms.Where(c => string.Compare(c.xdate, fromdate) >= 0 && string.Compare(c.xdate, todate) <= 0).Join(db.mdetailsdevices, a => a.xdevicecod, b => b.xcoddevice,
               (a, d) => new { a.xdate, d.xnamedevice, a.xdevicenumber, a.xtimestart, a.xtimeend, a.xMonthly});                  
      

       }
       public bool isservice(string fromdate, string todate)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
            if( ( db.mserviceprograms.Where(c => string.Compare(c.xdate, fromdate) >= 0 && string.Compare(c.xdate, todate) <= 0).Join(db.mdetailsdevices, a => a.xdevicecod, b => b.xcoddevice,
               (a, d) => new { a.xdate, d.xnamedevice, a.xdevicenumber, a.xtimestart, a.xtimeend, a.xMonthly }).Count()>0))return true;
            return false;
       }
       public IQueryable selectserviceforshowininterupt(string date)
       {
           PAYADATA.DatalinqserviceprogramDataContext db = new PAYADATA.DatalinqserviceprogramDataContext();
         return   db.mserviceprograms.Where(c => c.xdate.StartsWith(date)&&c.xresult==0).Join(db.mdetailsdevices, a => a.xdevicecod, b => b.xcoddevice,
               (a, b) => new { a.xid, a.xdate, b.xnamedevice, a.xdevicenumber,a.xdevicecod, a.xtimeend, a.xtimestart});
       }

       public bool insertserviceforconfirmproduct(string devicecod,string number,string date)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter();
        //********اگر if را برداریم 


           if (!(db.GetData().Where(c => c.xdevicecod.Trim() == devicecod.Trim() && c.xnumber == number && c.xdate == date).Any()))//اگر  داخل تایید شده ها نبود  //اگر  داخل تایید شده ها نبود 
           {

               db.Insertprogramserviceforconfirmproduct(devicecod, number, date, "");
               return true;



           }

           else
           {

               return false;
           }

       }
   

       public PAYADATA.dataserservicefordevice.mshowserviceprogramforconfirmproductDataTable showserviceforconfirmproduct()
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter();
           return db.GetDataBy2();
       }
       public void updateserviceconfirmproduct(PAYADATA.dataserservicefordevice.mshowserviceprogramforconfirmproductDataTable dt)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter();
           db.Update(dt);
       }
       public string returnexplainforservice(string devicecod,string devicenumber,string date )
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter();
         return   db.GetData().Where(c => c.xdevicecod == devicecod && c.xnumber == devicenumber && c.xdate == date).Select(c => c.xexplain).First();

       }
       public PAYADATA.dataserservicefordevice.mshowserviceprogramforconfirmproductDataTable showservicereturnproduct(string fromdate,string todate)
       {
           PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter db = new PAYADATA.dataserservicefordeviceTableAdapters.mshowserviceprogramforconfirmproductTableAdapter();
         //   return db.GetDataBy3(fromdate,todate);
           //****************************
           return db.GetDataByResualt(fromdate, todate);
           //****************************
      
       }
    }
}
