using System.Linq;
using System.Data;
using System.Windows.Forms;

namespace PAYAIND
{
    public  class csactioncenter
   {
       private string usernameofuser;
       int iduser;
       public  csactioncenter(string username)
       {
           usernameofuser = username;
           PAYAIND.cslogin cs = new cslogin();
            iduser = cs.returnid(usernameofuser);  
       }
       public csactioncenter()
       {
       }
       public bool isservicedaily()
       {
           csshamsidateandtime css = new csshamsidateandtime();
           csserviceprogram cs = new csserviceprogram();
          return cs.isservice(css.calcshmsidate(), css.calcshmsidate());          
       }
       public bool isserviceweekly()
       {
           csserviceprogram cs = new csserviceprogram();
           csshamsidateandtime css = new csshamsidateandtime();
           return cs.isservice(css.previousDay(-1), css.previousDay(-7));
       }
      
       //public bool isrequestrenovation(string username)
       //{
       //    PAYAIND.cslogin cs = new cslogin();
           
       //    if (cs.allowusertoupdateandread(usernameofuser, "Emergencyrepairrequest", true))
       //    {
              
       //        PAYADATA.Datasetactioncenter.A_actioncenterDataTable tb = new PAYADATA.Datasetactioncenter.A_actioncenterDataTable();
       //        PAYADATA.DatasetactioncenterTableAdapters.A_actioncenterTableAdapter db = new PAYADATA.DatasetactioncenterTableAdapters.A_actioncenterTableAdapter();
       //        if (db.GetDataBy(iduser).Where(c => c.xtypeid == 3).Count() > 0) { return true; } return false;
       //    } return false;
       //}
       
       private bool first = true;
       //public bool isrequestrenovationforalarm(string username)
       //{
       //    PAYAIND.csshamsidateandtime cssh= new csshamsidateandtime();
       //    PAYAIND.cslogin cs = new cslogin();
       //    if (cs.allowusertoupdateandread(usernameofuser, "Emergencyrepairrequest", true))
       //    {PAYADATA.DatalinqactioncenterDataContext dblinq= new PAYADATA.DatalinqactioncenterDataContext();  
       //    //dblinq.a_show_action_user_groups.Where(c => string.Compare(c.xdateshow, cssh.calcshmsidate()) >= 0 && string.Compare(c.xtimeshow, cssh.nexttime(8)) > 0 && c.xuserid==iduser).Select(c=> c.xidaction.ToString());
       //        PAYADATA.Datasetactioncenter.A_actioncenterDataTable tb = new PAYADATA.Datasetactioncenter.A_actioncenterDataTable();
       //        PAYADATA.DatasetactioncenterTableAdapters.A_actioncenterTableAdapter db = new PAYADATA.DatasetactioncenterTableAdapters.A_actioncenterTableAdapter();
       //        if (db.GetDataBy1(iduser, cssh.calcshmsidate()).Where(c => c.xtypeid == 3).Count() > 0) { return true; } return false;
       //    } return false;
          
       //}


       public void insertactioncenter(string types,string date,string time,int iduser,int idcauser)
       {
           PAYADATA.DatalinqactioncenterDataContext db = new PAYADATA.DatalinqactioncenterDataContext();
           PAYADATA.A_actioncenter tb = new PAYADATA.A_actioncenter();
           tb.xdate=date;
           tb.xissolved= false;
           tb.xtime= time;
           tb.xidusercauser = iduser;
           tb.xidcauser = idcauser;
           tb.xtypeid= db.a_typeofactions.Where(c=> c.xenglishname==types).Select(c=> c.xid).Single();
           db.A_actioncenters.InsertOnSubmit(tb);
           db.SubmitChanges();

       }
       public void eventrequestrenovationsolved( string time, string date)
       {
         
           PAYADATA.DatalinqactioncenterDataContext db = new PAYADATA.DatalinqactioncenterDataContext();
           PAYADATA.A_actioncenter tb = db.A_actioncenters.Where(c=> c.xtime==time && c.xdate== date).First();
           tb.xissolved = true;
           db.SubmitChanges();
       }
       public void eventsolved(int iduser,int idcauser,string date,string time)
       {
           PAYADATA.DatalinqactioncenterDataContext db = new PAYADATA.DatalinqactioncenterDataContext();
           PAYADATA.A_actioncenter tb = db.A_actioncenters.Where(c =>c.xidcauser==idcauser&&c.xidusercauser==iduser&& c.xtime == time && c.xdate == date).First();
           tb.xissolved = true;
           db.SubmitChanges();

       }
       public void eventsolved(string type, string date, string time)
       {
           PAYADATA.DatalinqactioncenterDataContext db = new PAYADATA.DatalinqactioncenterDataContext();
           PAYADATA.A_actioncenter tb = db.A_actioncenters.Where(c => c.xtypeid == db.a_typeofactions.Where(cb => cb.xenglishname == type).Select(cc => cc.xid).Single() && c.xtime == time && c.xdate == date).First();
           tb.xissolved = true;
           db.SubmitChanges();
       }

       public void eventsolved(string type)
       {
           PAYADATA.DatalinqactioncenterDataContext db = new PAYADATA.DatalinqactioncenterDataContext();
           PAYADATA.A_actioncenter tb = db.A_actioncenters.Where(c => c.xtypeid == db.a_typeofactions.Where(bc => bc.xenglishname == type).Select(cc => cc.xid).Single() && c.xissolved != true).First();
         tb.xissolved = true;
        db.SubmitChanges();
       }

       public void showactionforuser(string type)
       {
           PAYADATA.DatalinqactioncenterDataContext dbb = new PAYADATA.DatalinqactioncenterDataContext();
           PAYAIND.csshamsidateandtime cssh = new csshamsidateandtime();          
           PAYADATA.DatasetactioncenterTableAdapters.A_actioncenterTableAdapter db = new PAYADATA.DatasetactioncenterTableAdapters.A_actioncenterTableAdapter();
           int typeac=  dbb.a_typeofactions.Where(c => c.xenglishname == type).Select(c => c.xid).Single();
           int idac = db.GetDataBy1(iduser, cssh.calcshmsidate()).Where(c => c.xtypeid == typeac).Select(c => c.xid).First();       
           PAYADATA.a_show_action_user_group tb = new PAYADATA.a_show_action_user_group();
           tb.xidaction = idac;
           tb.xdateshow = cssh.calcshmsidate();
           tb.xtimeshow = cssh.calctime();
           tb.xuserid = iduser;
           dbb.a_show_action_user_groups.InsertOnSubmit(tb); dbb.SubmitChanges(); 
       }
       private bool __isrequestrenovationforalarm, __isrequestrenovation, __isserviceforconfimforalarm,__isrequestconstructforalarm, __isrequestconstruct, __isserviceforconfim;
       public bool _isrequestrenovationforalarm
       {
           get
           {
               if (first) { isactionservice(); }
               return __isrequestrenovationforalarm;
           }
           set { __isrequestrenovationforalarm = value; }
       }
      
       public bool _isrequestrenovation
       {
           get
           {
               if (first) { isactionservice(); }
               return __isrequestrenovation;
           }
           set { __isrequestrenovation = value; }
       }
       public bool _isserviceforconfim
       {
           get
           {
               if (first) { isactionservice(); }
               return __isserviceforconfim;
           }
           set { __isserviceforconfim = value; }
       }
       public bool _isserviceforconfimforalarm
       {
           get
           {
               if (first) { isactionservice(); }
               return __isserviceforconfimforalarm;
           }
           set { __isserviceforconfimforalarm = value; }
       }

       public bool _isrequestconstructforalarm
       {
           get
           {
               if (first) { isactionservice(); }
               return __isrequestconstructforalarm;
           }
           set { __isrequestconstructforalarm = value; }
       }
       public bool _isrequestconstruct
       {
           get
           {
               if (first) { isactionservice(); }
               return __isrequestconstruct;
           }
           set { __isrequestconstruct = value; }
       }
       private void isactionservice()
       {
           PAYAIND.csshamsidateandtime cssh = new csshamsidateandtime();
           PAYADATA.DatasetactioncenterTableAdapters.A_actioncenterTableAdapter db = new PAYADATA.DatasetactioncenterTableAdapters.A_actioncenterTableAdapter();
           BindingSource bs = new BindingSource();
           PAYAIND.cslogin cs = new cslogin();
           
           bs.DataSource = db.GetDataBy(iduser);
           bs.Filter = "xtypeid='3'";
           if (bs.Count > 0)
           {
               if (cs.allowusertoupdateandread(usernameofuser, "alarmEmergencyrepairrequest", true))
                   __isrequestrenovation = true;
               else __isrequestrenovation= false;
           }
           else __isrequestrenovation = false;
           bs.Filter = "xtypeid='7'";
           if (bs.Count > 0)
           {
               if (cs.allowusertoupdateandread(usernameofuser, "alarmconstruct", true))
               { __isrequestconstruct = true; }
               else __isrequestconstruct = false;
           }
           else __isrequestconstruct = false;

           bs.Filter = "xtypeid='8'";
           if (bs.Count > 0)
           {
               if (cs.allowusertoupdateandread(usernameofuser, "alarmconfirmproduct", true))
               { __isserviceforconfim = true; }
               else __isserviceforconfim = false;
           }
           else __isserviceforconfim = false;
          
           bs.Filter = "";
           if (bs.Count > 0)
           { }
           bs.DataSource = db.GetDataBy1(iduser, cssh.calcshmsidate());
           bs.Filter = "xtypeid='3'";
           if (bs.Count > 0)
           {
               if (cs.allowusertoupdateandread(usernameofuser, "alarmEmergencyrepairrequest", true))
                   __isrequestrenovationforalarm = true;
               else __isrequestrenovationforalarm = false;
           }
           else __isrequestrenovationforalarm = false;
           bs.Filter = "xtypeid='7'";
           if (bs.Count > 0)
           {
               if (cs.allowusertoupdateandread(usernameofuser, "alarmconstruct", true))

               { __isrequestconstructforalarm = true; }

               else __isrequestconstructforalarm = false;

           }
           else __isrequestconstructforalarm = false;

           bs.Filter = "xtypeid='8'";
           if (bs.Count > 0)
           {
               if (cs.allowusertoupdateandread(usernameofuser, "alarmconfirmproduct", true))
               { __isserviceforconfimforalarm = true; }
               else __isserviceforconfimforalarm = false;
           }
           else __isserviceforconfimforalarm = false; 
           bs.Filter = "";
           if (bs.Count > 0)
           { }
           bs.Filter = "";
           if (bs.Count > 0)
           { }
           first = false;


       }
    }
}
