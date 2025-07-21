using System;
using System.Linq;
using System.Windows.Forms;

namespace PAYAIND
{
    public   class cstrubleshooting
 {
     IQueryable query;
     string cod_truble;
     public void sevetruble1(string coddevice, string knid, string truble, string sol)
     {  int index;
         string codmax;
         PAYADATA.DatatrubleshootingDataContext db = new PAYADATA.DatatrubleshootingDataContext();
         try
         { 
             codmax = db.mtruble_shootings.Where(c => c.xcodtruble.Contains(coddevice)).Select(c => c.xcodtruble).Max();
             index =Convert.ToInt32( codmax.Substring(0, 4));
             index++;
         }

         catch { index = 1001; }
         PAYADATA.mtruble_shooting tb = new PAYADATA.mtruble_shooting();
         tb.xcodtruble = index.ToString() + "-" + coddevice + "-" + knid;
         tb.xtruble = truble;
         tb.xsolution = sol;
         db.mtruble_shootings.InsertOnSubmit(tb);
         db.SubmitChanges();
     }

     public IQueryable selecttruble1(string coddevice,string knid)
     { PAYADATA.DatatrubleshootingDataContext db = new PAYADATA.DatatrubleshootingDataContext();
         if( (coddevice!="all")&&(knid!= "all"))
     return db.mtruble_shootings.Select(c => c).Where(c=> c.xcodtruble.Contains(coddevice)&&c.xcodtruble.EndsWith(knid));
         else if ((coddevice == "all") && (knid != "all"))
             return db.mtruble_shootings.Select(c => c).Where(c=> c.xcodtruble.EndsWith(knid));
         if ((coddevice != "all") && (knid == "all"))
             return db.mtruble_shootings.Select(c => c).Where(c => c.xcodtruble.Contains(coddevice) );
         else return db.mtruble_shootings.Select(c => c);
     }

     public void delete1(int cod)
     {
         PAYADATA.DatatrubleshootingDataContext db = new PAYADATA.DatatrubleshootingDataContext();
         PAYADATA.mtruble_shooting tb = new PAYADATA.mtruble_shooting();
         tb = db.mtruble_shootings.Where(c => c.xid == cod).Select(c => c).Single();
         db.mtruble_shootings.DeleteOnSubmit(tb);
         db.SubmitChanges();
     }
     //-------------------
     public IQueryable selecttrublebycoddevice(string coddevice)
     {
         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
         return db.ttruble_shootings.Where(c => c.xcod.StartsWith(coddevice.Trim()));
     }
     //---------------------
     public object[] selecttrublebycoddevicetoarray(string coddevice)
     { 
      PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
        return  db.ttruble_shootings.Where(c => c.xcod.StartsWith(coddevice)).Select(c=> c.xtruble).ToArray();
     }
    
     public void updatetable(int id,string truble)
     {
         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
         PAYADATA.trubleshooting.ttruble_shooting tb = new PAYADATA.trubleshooting.ttruble_shooting();
        tb= db.ttruble_shootings.Where(c => c.xid == id).Single();
        tb.xtruble = truble;
        db.SubmitChanges();
     }

     public void delettruble(int id)
     {
         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
        PAYADATA.trubleshooting.ttruble_shooting tb=new PAYADATA.trubleshooting.ttruble_shooting();
        tb = db.ttruble_shootings.Where(c => c.xid == id).Select(c => c).Single() ;
        db.ttruble_shootings.DeleteOnSubmit(tb);
        db.SubmitChanges();     
     }
    
     public void inserttruble(string truble, string cod)
     {  PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();

     int index;
     try
     {
         MessageBox.Show(cod+""+"01");
         string s;
         s = (db.ttruble_shootings.Where(c => c.xcod.StartsWith(cod)).Select(c => c.xcod.Substring(4, 3)).Max());
         if (s.Length < 3) s =  s+"0" ;
         if (s.Length < 3) s = s + "0";
         index = Convert.ToInt32(s)+1;
     }
         
     catch { index = 100; }
         PAYADATA.trubleshooting.ttruble_shooting tb = new PAYADATA.trubleshooting.ttruble_shooting();
     tb.xtruble = truble;
     tb.xcod = cod + "-" + index.ToString();
     db.ttruble_shootings.InsertOnSubmit(tb);
     db.SubmitChanges();
     }

     public IQueryable selectsolution(string codtruble, string type)
     {
         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
            
         if (type != "all")
         {
            return   db.tsolutionfortrubles.Where(c => c.xcodtruble == codtruble && c.xcod.EndsWith(type));
         }
         else return db.tsolutionfortrubles.Where(c => c.xcodtruble == codtruble);
        }
     public void insersolution(string codtruble, string cause, string solution,string type)
     {
         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
         PAYADATA.trubleshooting.tsolutionfortruble tb = new PAYADATA.trubleshooting.tsolutionfortruble();
         tb.xcause = cause;
         tb.xsolution = solution;
         tb.xcodtruble = codtruble;
         int index;
         try
         {
             index = Convert.ToInt32(db.tsolutionfortrubles.Where(c => c.xcod.StartsWith(codtruble)).Select(c => c.xcod.Substring(8, 2)).Max()) + 1;
             if (index < 10) index = 10 + index;
         }
         catch { index = 10; }
         tb.xcod = codtruble + "-" + index.ToString() + "-" + type;
         db.tsolutionfortrubles.InsertOnSubmit(tb);
         db.SubmitChanges();
     }
     
     public void updatetablesolution(int id, string cause, string solution)
     {
         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
         PAYADATA.trubleshooting.tsolutionfortruble tb = new PAYADATA.trubleshooting.tsolutionfortruble();         
         tb = db.tsolutionfortrubles.Where(c => c.xid == id).Select(c => c).Single();
         tb.xsolution = solution;
         tb.xcause = cause;        
         db.SubmitChanges();
     }

     public void deletsolution(int id)
     {
         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
         PAYADATA.trubleshooting.tsolutionfortruble tb = new PAYADATA.trubleshooting.tsolutionfortruble();
         tb = db.tsolutionfortrubles.Where(c => c.xid == id).Select(c => c).Single();
         db.tsolutionfortrubles.DeleteOnSubmit(tb);
         db.SubmitChanges();
     }
     //*********************************

     public IQueryable selectsolutionbytrulename(string trubl_name)
     {

         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
        
         try
         {
             string cod = db.ttruble_shootings.Where(c => c.xtruble == trubl_name).Select(c => c.xcod).Single();
             query = db.tsolutionfortrubles.Where(c => c.xcodtruble == cod);
             return query;
         }

         catch {  }

        return query;

     }

      //*******************************
     public string selectcodtruble_bytrublename(string trubl_name)
     {
         PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext db = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();

         try
         {
             cod_truble = db.ttruble_shootings.Where(c => c.xtruble == trubl_name).Select(c => c.xcod).Single();
             return cod_truble;
         }

         catch { }

         return cod_truble;

     }

     //*************************
     //*************************
    }
}
