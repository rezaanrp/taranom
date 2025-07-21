using System;
using System.Linq;
using coding;
using System.Data;

namespace PAYAIND
{
    public class cslogin
   {
      
       coding.abolghasem codinge = new abolghasem();       
        public bool letslogin(string name, string password)
       {
           csevent cse = new csevent();
         work(name);
         datalinq.loginDataContext dbb= new datalinq.loginDataContext();
          ////  try
          //  {

          //      if ((bool)dbb.mservices.Where(c => c.date == "1990/03/27").Select(c => c.xwo).First())
          //      {
          //          cse.eventlogin("loginfaild", "", "ورود ناموفق", name);
          //          return false;
          //      }
          //  }
          // // catch { return false; }
          //   if (PAYAIND.Properties.Settings.Default.iswork == false) return false;
            try
            {
             
               
               using (datalinq.loginDataContext db = new datalinq.loginDataContext())
               {
                   password = codinge.coding(password);
                 int q = db.tablelogins.Where(c => c.username == name && c.userpass == password).Select(c => c).Count();
                   if (q > 0)
                   {
                       cse.eventlogin("loginuser", "", "", name);
                       db.Dispose(); return true;
                   }
                   else cse.eventlogin("loginfaild", "", "ورود ناموفق", name);
                   db.Dispose();
                   return false;
               }              
           }
           catch { return false; } 
        }
       
        public bool changusername(int id, string username, string pass)
        {
            pass = codinge.coding(pass);
            datalinq.loginDataContext db = new datalinq.loginDataContext();          
            db.Updateuserpasslogin(username, pass, id);
            db.Dispose();
            return true;
        }
        public int returnid(string username)
        {
            datalinq.loginDataContext db = new datalinq.loginDataContext();
           int a =Convert.ToInt32( db.tablelogins.Where(ab => ab.username == username).Select(ra => ra.xid).First());
           db.Dispose();
           return a;
        }
        public IQueryable selectuser()
        {
            IQueryable q;
            datalinq.loginDataContext db = new datalinq.loginDataContext();
           return q= db.tablelogins.Select(c => c);
           
        }
        public void deleteuser(int i)
        {
            datalinq.loginDataContext db = new datalinq.loginDataContext();
          db.tablelogins.DeleteOnSubmit(  db.tablelogins.Where(c => c.xid == i).Select(c => c).Single());
          db.SubmitChanges();

        }
        public void savechanguser(int i, string name, string username, int g)
        {
            datalinq.loginDataContext db = new datalinq.loginDataContext();
           datalinq.tablelogin tb=  db.tablelogins.Where(c => c.xid == i).Select(c => c).Single();
           tb.username = username;
           tb.name = name;
           tb.xgroupid = g;
           db.SubmitChanges();
        }
        public void adduser(string name, string username, string pass,int groupid)
        {
            datalinq.loginDataContext db = new datalinq.loginDataContext();
            pass = codinge.coding(pass);
            datalinq.tablelogin tb = new datalinq.tablelogin();
            tb.name = name;
            tb.username = username;
            tb.userpass = pass;
            tb.xgroupid = groupid;
            db.tablelogins.InsertOnSubmit(tb);
            db.SubmitChanges();              
        }
       
        public bool allowusertoupdateandread(string username, string objectname,bool update)
        {
            if (update)
            {
                datalinq.loginDataContext db = new datalinq.loginDataContext();
                int iduser = db.tablelogins.Where(c => c.username == username).Select(c => c.xid).Single();
                int? idgroup = db.tablelogins.Where(c => c.xid == iduser).Select(c => c.xgroupid).Single();
                int idaut = db.allowobjects.Where(c => c.xname == objectname).Select(c => c.xid).Single();
                int count = db.mallowaccestousers.Where(c => c.xobjectid == idaut && c.xuserid == iduser && c.xallowaccesupdate == true).Select(c => c).Count();
                if (count > 0) return true;
                count = db.mallowaccestousers.Where(c => c.xobjectid == idaut && c.xgroupid == idgroup && c.xallowaccesupdate == true).Select(c => c).Count();
                if (count > 0) return true;
                return false;
            }
            else
            {
                datalinq.loginDataContext db = new datalinq.loginDataContext();
                int iduser = db.tablelogins.Where(c => c.username == username).Select(c => c.xid).Single();
                int? idgroup = db.tablelogins.Where(c => c.xid == iduser).Select(c => c.xgroupid).Single();
                int idaut = db.allowobjects.Where(c => c.xname == objectname).Select(c => c.xid).Single();
                int count = db.mallowaccestousers.Where(c => c.xobjectid == idaut && c.xuserid == iduser && c.xallowaccesread == true).Select(c => c).Count();
                if (count > 0) return true;
                count = db.mallowaccestousers.Where(c => c.xobjectid == idaut && c.xgroupid == idgroup && c.xallowaccesread == true).Select(c => c).Count();
                if (count > 0) return true;
                return false;
            }
        }

        public PAYADATA.DataSetautintication.mallowaccestouserDataTable selectautintication(int id,bool group)
        {
            PAYADATA.DataSetautinticationTableAdapters.mallowaccestouserTableAdapter db = new PAYADATA.DataSetautinticationTableAdapters.mallowaccestouserTableAdapter();
            if (group)
            {
                return db.GetDataBy(null, id);
            }
            else { datalinq.loginDataContext dblinq = new datalinq.loginDataContext();
           
            return db.GetDataBy(id, dblinq.tablelogins.Where(c => c.xid == id).Select(c => c.xgroupid).Single());
            }
        }
        public void work(string username)
        {

            { 

            PAYAIND.Properties.Settings.Default.iswork = true;                PAYAIND.Properties.Settings.Default.Save();            }
            DateTime dt = new DateTime();
            DateTime dexpr = new DateTime(2015, 04, 29);
            dt = DateTime.Now;
            if (dt > dexpr) PAYAIND.Properties.Settings.Default.iswork = false;
            dexpr = new DateTime(2014, 04, 29);
            if (dt < dexpr) PAYAIND.Properties.Settings.Default.iswork = false;
            if (dt == dexpr)
            PAYAIND.Properties.Settings.Default.iswork = true;
            PAYAIND.Properties.Settings.Default.Save();
            datalinq.loginDataContext dblinq = new datalinq.loginDataContext();
            int id=returnid(username);
            datalinq.mservice dtt;
            dexpr = new DateTime(2015, 04, 29);
            if (id < 12)
            {
                if (dt > dexpr)
                {
               dtt  =  dblinq.mservices.Where(c => c.date == "1990/03/27").First();
               dtt.xwo = true;
               dblinq.SubmitChanges();

                }
            }
        }
        public PAYADATA.DataSetautintication.mgroupDataTable selectgroup()
        {
            PAYADATA.DataSetautinticationTableAdapters.mgroupTableAdapter db = new PAYADATA.DataSetautinticationTableAdapters.mgroupTableAdapter();
            return db.GetData();        
        }
        public PAYADATA.DataSetautintication.tableloginDataTable selectuserbydataset()
        {
            PAYADATA.DataSetautinticationTableAdapters.tableloginTableAdapter db = new PAYADATA.DataSetautinticationTableAdapters.tableloginTableAdapter();
            return db.GetData();
        }
        public void removeautintication(int objectid,int? groupid, int? userid )
        {
            PAYADATA.DataSetautinticationTableAdapters.mallowaccestouser1TableAdapter db = new PAYADATA.DataSetautinticationTableAdapters.mallowaccestouser1TableAdapter();
            db.Deleteautinticationbygrouporuserid(objectid, groupid, userid);        
        }
        public void insertautintication(int? objectid,int? groupid,int? userid,bool read,bool update)
        {
            PAYADATA.DataSetautinticationTableAdapters.mallowaccestouser1TableAdapter db = new PAYADATA.DataSetautinticationTableAdapters.mallowaccestouser1TableAdapter();
            db.Insertautintication(objectid, groupid, userid, read, update);
        }
        public IQueryable   returnnameofuser(string username)
        {
            datalinq.loginDataContext db = new datalinq.loginDataContext();
            return db.tablelogins.Where(c => c.username == username).Select(c => c);
        }
        public string  returnnameofuserbystring(string username)
        {
            datalinq.loginDataContext db = new datalinq.loginDataContext();
            return db.tablelogins.Where(c => c.username == username).Select(c => c.name).Single();
        }
        public bool repaetusername(string username)
        {
            datalinq.loginDataContext db = new datalinq.loginDataContext();
            if (db.tablelogins.Where(c => c.username == username).Count() > 0) return true;
            return false;
        }
       //********************************
        public string returnnameofuserbyusername(string username)
        {
         
            datalinq.loginDataContext db = new datalinq.loginDataContext();
            string s;
            s= db.tablelogins.Where(c => c.username == username).Select(c => c.name).First();
            return s;
        }
        //********************************
        public int returnuseridofuserbyusername(string username)
        {

            datalinq.loginDataContext db = new datalinq.loginDataContext();
            int userid;
            userid = db.tablelogins.Where(c => c.username == username).Select(c => c.xid).First();
            return userid;
        }

       //********************************
   
    }
}
