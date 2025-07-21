using System;
using System.Linq;

namespace PAYAIND
{
    public    class csinterupt_plan
    {
     private PAYADATA.interuptplan.lqinterupt_planDataContext db = new PAYADATA.interuptplan.lqinterupt_planDataContext();
     public PAYADATA.interuptplan.dsinteruptplan.Select_interuptplanDataTable interuptplan(string datefrom, string dateto)
     {
         PAYADATA.interuptplan.dsinteruptplanTableAdapters.Select_interuptplanTableAdapter db =
           new PAYADATA.interuptplan.dsinteruptplanTableAdapters.Select_interuptplanTableAdapter();
         return db.GetDataBy((datefrom), (dateto));
     }
     public PAYADATA.interuptplan.dsinteruptplan.Select_interuptplanDataTable interuptplan(PAYADATA.interuptplan.dsinteruptplan.Select_interuptplanDataTable dt, string datefrom, string dateto)
     {
         PAYADATA.interuptplan.dsinteruptplanTableAdapters.Select_interuptplanTableAdapter db =
           new PAYADATA.interuptplan.dsinteruptplanTableAdapters.Select_interuptplanTableAdapter();
          db.Update(dt);
          return db.GetDataBy((datefrom), (dateto));
        
     }
     public bool selectdemuerofinterupt(int id, int iddemuer)
     {
         if (db.mselectdemuers.Where(c => c.idparent == id && c.xiddemuer == iddemuer && c.typeparent == "plan").Count() > 0) return true; return false;

     }
     public int   insertintointeruptplan(int idserviceprogram, string xdat_plan,string xdatestartinterupt,string xtime_startinterupt,string xdate_end,
         string xtime_end,string xdevicecod,string xoperator1,string operator2,
         string xexplain_havoc,string xplainactivity,string xtime_interupt,bool xdelay   ,bool m )
     {// try 
         { 

         db.Insertinto_interuptplan(xdat_plan, idserviceprogram, xdatestartinterupt, xtime_startinterupt, xdate_end, xtime_end, xdevicecod, xoperator1, operator2, xexplain_havoc, xplainactivity, Convert.ToInt32(xtime_interupt), xdelay, m);
         PAYADATA.DatalinqserviceprogramDataContext dbb = new PAYADATA.DatalinqserviceprogramDataContext();
             PAYADATA.mserviceprogram tb=   dbb.mserviceprograms.Where(c => c.xid == idserviceprogram).Single();
             if (xdelay)
                 tb.xresult = 3;
             else if (string.Compare(xdat_plan, xdatestartinterupt)>0)
                 tb.xresult = 2;
             else tb.xresult = 1;
             dbb.SubmitChanges();
              int idinteruptpaln=db.minterupt_plans.Select(c => c.xid).Max();
             insertcurrentitemforheader(xdevicecod,idinteruptpaln,xdat_plan);
             return idinteruptpaln;

         }
        // catch{return 0 ;}
     }
     public void delete(string id)
     {

         int? idserviceprogram = db.minterupt_plans.Where(c => c.xid == Convert.ToInt32(id)).Select(c => c.xidserviceprogram).Single();
         db.Delete_from_interupt_plan(Convert.ToInt32(id));
         if (idserviceprogram != null)
         {
             PAYADATA.DatalinqserviceprogramDataContext dbb = new PAYADATA.DatalinqserviceprogramDataContext();
             PAYADATA.mserviceprogram tb = dbb.mserviceprograms.Where(c => c.xid == idserviceprogram).Single();
             tb.xresult = 0;
             dbb.SubmitChanges();
         }

     }
     public bool updateinteruptplan(int idserviceprogram, string xid, string xdat_plan, string xdatestartinterupt, string xtime_startinterupt, string xdate_end,
        string xtime_end, string xdevicecod, string xoperator1, string operator2,
        string xexplain_havoc, string xplainactivity, string xtime_interupt, bool xdelay,bool m)
     { try
     {
         PAYADATA.DatalinqserviceprogramDataContext dbb = new PAYADATA.DatalinqserviceprogramDataContext();
            
             db.Update_interupt_plan(xdat_plan, xdatestartinterupt, xtime_startinterupt, xdate_end, xtime_end, xdevicecod, xoperator1, operator2, xexplain_havoc, xplainactivity, Convert.ToInt32(xtime_interupt), xdelay, Convert.ToInt32(xid), m);
             PAYADATA.mserviceprogram tb = dbb.mserviceprograms.Where(c => c.xid == idserviceprogram).Single();
             if (xdelay)
                 tb.xresult = 3;
             else if (string.Compare(xdat_plan, xdatestartinterupt) > 0)
                 tb.xresult = 2;
             else tb.xresult = 1;
             dbb.SubmitChanges();   
         return true;
         }
            catch{return false;}
     }
     public IQueryable fillservic(string coddevice, bool mountly)
     {
         return db.mservic_devices.Where(c => c.xdevicecod == coddevice && c.xmount == mountly).Select(c => new { c.xitemno, c.xid });
     }
     public void insertservicforinterupt(int xidservic, int idinterupt)
    {PAYADATA.interuptplan.mservicefor_interupt_plan dt= new PAYADATA.interuptplan.mservicefor_interupt_plan();
        dt.xidinterupt = idinterupt;
        dt.xidservice = xidservic;
        db.mservicefor_interupt_plans.InsertOnSubmit(dt);
        db.SubmitChanges();

     }
     public object selectserviceforinterupt (int codinterupt)
     {
       return  db.Selectservice_for_interupt_plan(codinterupt);
        
     }
     public void updateservicforinterupt(int id, bool do_, string explain)
     {
         db.Updateserviceforinterupt(do_, explain, id);
     }
     public void insertdemuerforinterupt(int id, int parentid)
     {
         PAYADATA.interuptplan.mselectdemuer tb = new PAYADATA.interuptplan.mselectdemuer();
         tb.idparent = parentid; tb.typeparent = "plan"; tb.xiddemuer = id;
         db.mselectdemuers.InsertOnSubmit(tb);
         db.SubmitChanges();
     }
     public void deletalldemuerofinterupt(int id)
     {
         db.Deletealldemuerfointerupt(id, "plan");
     }
     //************************************

     private void insertcurrentitemforheader(string devicecod, int index, string date)
     {
         PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter dbc = new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter();
         PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter();
         PAYAIND.cscurrent csc = new cscurrent();
         int[] a; a = csc.selectcurrentrengbycod(devicecod).Select(c => c.xid).ToArray();
         for (int i = 0; i < a.Length; i++)
         {

             db.Insertcurrent(index, a[i], false, 0, 0, 0, "", date, "");

         }
     }

     //************************************
  
    }
}
