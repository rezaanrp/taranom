using System.Data;
using System.Linq;
using PAYADATA.coding;

namespace PAYAIND
{
    public class csedit
    {
       // IQueryable query;
        public PAYADATA.coding.Data_linq_coding_objectDataContext db = new PAYADATA.coding.Data_linq_coding_objectDataContext();
        public bool insertset1(string iddevice, string name, string xid, string xcod)
       {
            mdeviceset1 tb = new mdeviceset1();
            tb.xid= xid;
            tb.xnameset1 = name;
            tb.xiddevice = iddevice;
            tb.xcod = iddevice + "-" + xid;
            db.mdeviceset1s.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }
        public bool insertset2(string idset1, string name, string xid)
        {
            mdeviceset2 tb = new mdeviceset2();
            tb.xnameset2 = name;
            tb.xparentid = idset1;
            tb.xid = xid;
            tb.xcodfinalset2 = idset1 + "-" + xid;
            db.mdeviceset2s.InsertOnSubmit(tb);
            db.SubmitChanges(); 
           return true; 
        }
        public bool insertset3(string codparent, string name, string xid,string details,bool m)
        {
            
            mdeviceset3 tb = new mdeviceset3();
            tb.xnameset3 = name;
            fillcombo css = new fillcombo();
            tb.xparentid = codparent; 
            tb.xid = xid;
            tb.xdetails = details;
            tb.xismecanical = m;
            tb.xcodfinalset3 = tb.xparentid + "-" + xid;           
            db.mdeviceset3s.InsertOnSubmit(tb);
            db.SubmitChanges();
            return true;
        }
        public bool insertdevice(string cod,string iddevice,string  numbe,string codlocation,string manafacturserial,string datemake,string datestart,int? purchase,int? auto,int? period)
        {
            PAYADATA.coding.DataSetcodingTableAdapters.deviceTableAdapter db = new PAYADATA.coding.DataSetcodingTableAdapters.deviceTableAdapter();
            try
            {
                db.Insertintodevice(cod, iddevice, numbe, codlocation, manafacturserial, datemake, datestart, purchase,auto, period);
                return true;           
            }
          catch { return false; }

        }
        public bool updatedevicebydataset(string cod, string manafacturserial, string datemake, string datestart, int purchase, int auto, int period)
        {
            PAYADATA.coding.DataSetcodingTableAdapters.deviceTableAdapter db = new PAYADATA.coding.DataSetcodingTableAdapters.deviceTableAdapter();
            try
            {
                db.Updatedevice(manafacturserial, datemake, datestart, purchase, auto, period, cod);
                return true;
            }
            catch { return false; }

        }
        public bool insertobject_set2( string xid, int xcount, string xcod,string is_key)
        {try{
            fillcombo c = new fillcombo();
           
            mallobject tb = new mallobject();
            tb.oloaviyat = is_key;
            tb.count = xcount;
            tb.xcod = xcod;
            tb.xid = xid;
            tb.xcodparent = xcod.Substring(3, 15);
            db.mallobjects.InsertOnSubmit(tb);           
              db.SubmitChanges();
               return true;
           }
        catch
        {
            return false;
        }
        }
        public bool updateobject_set2( int xcount, string xcod,string olaviyat)
        {
            db.Updatemallobject(xcount, olaviyat, xcod);             
            return true;  
        }
        public bool updateobject_set2(int xcount, string xcod, string olaviyat,bool f)
        {
          mallobject tb=   db.mallobjects.Where(c => c.xcod == xcod).Select(c => c).Single();
          tb.oloaviyat = olaviyat;
          tb.count = xcount;
           
          db.SubmitChanges();
            return true;
        }

        public bool insert_object(string xid, string xname, string xdetails,bool isbuilding)
        {
            //try {            
               objecttable table = new objecttable();
               table.xid = xid;
               table.xname = xname;
               table.xdetails = xdetails;
               table.xisBuilding = isbuilding;
               db.objecttables.InsertOnSubmit(table);
               db.SubmitChanges();
               return true;
           // }
          //  catch { return false; }
        }
       
        public void deletefromobjecttable_set2(string cod)
        {
            db.Deletefromobjectset2table(cod); 
        }
        public void deletfromallobject(string cod)
        {
            mallobject tb = new mallobject();
            tb = db.mallobjects.Where(c => c.xcod == cod).Select(c => c).Single();
            db.mallobjects.DeleteOnSubmit(tb);
            db.SubmitChanges();
        }
        public void deletefromobjectteble1(string cod)
        {
            db.Deletefromobject(cod);
        }

        public void updateobjecttable(string cod, string name, string tozih,bool isbuilding)
        {
            try
            {
                var table = db.objecttables.Where(c => c.xid == cod).Select(c => c).Single();
                table.xname = name;               
                table.xdetails = tozih;
                table.xisBuilding = isbuilding;
                db.SubmitChanges();
            }
            catch { }
        }
       
        public void deletefromdevice(string cod)
        {
           var data= db.devices.Where(c => c.xcod == cod).Select(c => c).Single();
           db.devices.DeleteOnSubmit(data);
           db.SubmitChanges();
        }
        public void deletefromset2(string cod)
        {
           // try
            {
                var data = db.mdeviceset2s.Where(c => c.xcodfinalset2 == cod).Select(c => c).First();
                db.mdeviceset2s.DeleteOnSubmit(data);
                db.SubmitChanges();
            }
           // catch { }
        }
        public void deletefromset1(string cod)
        {
           // try
            {
                var data = db.mdeviceset1s.Where(c => c.xcod == cod).Select(c => c).First();
                db.mdeviceset1s.DeleteOnSubmit(data);
                db.SubmitChanges();
            }
           // catch { }
        }
        public bool exitobject(string name, string details)
        {
            if (db.objecttables.Where(c => c.xdetails == details && c.xname == name).Select(c => c).Count() > 0) return true;
            return false;
        }
        public void updateset2(string name,string details,bool m, string cod)
        {
            var table = db.mdeviceset2s.Where(c => c.xcodfinalset2 == cod).Select(c => c).Single();
            table.xnameset2 = name;
            table.xIsmecanical = m;
            table.xdetails = details;
            db.SubmitChanges();
        }
        public void updateset1(string name,string details,bool m, string cod)
        {
            try
            {
                var table = db.mdeviceset1s.Where(c => c.xcod == cod).Select(c => c).Single();
                table.xnameset1 = name;
                table.xIsmecanical = m;
                table.xdetails = details;
                db.SubmitChanges();
            }
            catch { }

        }
        public void minserset1(string nameset1, string namedevice,string number, string cod2set1,string details,bool m)
        {
            string coddevic = db.mdetailsdevices.Where(c => c.xnamedevice == namedevice).Select(c => c.xcoddevice.Substring(0,3)).First();
            coddevic += "-" + number;
            string   codset1 = coddevic + "-" + cod2set1;
            mdeviceset1 tb = new mdeviceset1();
            tb.xnameset1 = nameset1;
            tb.xiddevice = coddevic;
            tb.xcod = codset1;
            tb.xid = cod2set1;
            tb.xdetails = details;
            tb.xIsmecanical = m;
            db.mdeviceset1s.InsertOnSubmit(tb);
            db.SubmitChanges();
        }
        public void minsertset2( string codset1, string xid, string nameset2,string details,bool m)
        {
            
            mdeviceset2 tb = new mdeviceset2();
            
            tb.xparentid = codset1;
           
            tb.xid = xid;
            tb.xnameset2 = nameset2;
            tb.xcodfinalset2 = codset1 + "-" + xid;
            tb.xdetails = details;
            tb.xIsmecanical = m;
            db.mdeviceset2s.InsertOnSubmit(tb);
            db.SubmitChanges();
        }
        public void insertcodobject(string name,string cod,string  knid,string vahed ,string eng)
        {
           PAYADATA.coding.mobjectcod tb = new PAYADATA.coding.mobjectcod();
            tb.xcod= cod;
            tb.xname= name;
            tb.xvahed = vahed;
            tb.xname_English = eng;
            char[] a = knid.ToArray();
            tb.xcodfinal = cod + "-" + a[0];
            tb.knid = a[0];
            db.mobjectcods.InsertOnSubmit(tb);
            
            db.SubmitChanges();


        }
        public bool exitcodobject(string cod)
        {
            if (db.mobjectcods.Where(c => c.xcod == cod).Count() > 0)
                return true;
            return false;
        }
        public void insertdevicedetails(string name, string ename, string coddevice, int count, int countop, float weigth, float usfullife)
        {
            PAYADATA.coding.DataSetcodingTableAdapters.mdetailsdeviceTableAdapter db = new PAYADATA.coding.DataSetcodingTableAdapters.mdetailsdeviceTableAdapter();
            db.Insertdevicedetails(name, ename, coddevice, count, countop, weigth, usfullife);
        }
        public void updatedevicedetails(PAYADATA.coding.DataSetcoding.mdetailsdeviceDataTable dt) //string name, string ename, string coddevice, int count, int countop, float weigth, float usfullife)
        {
            PAYADATA.coding.DataSetcodingTableAdapters.mdetailsdeviceTableAdapter db = new PAYADATA.coding.DataSetcodingTableAdapters.mdetailsdeviceTableAdapter();
            db.Update(dt);  
        }
        public void deletefromdevicedetails(int xid)
        { mdetailsdevice dt = db.mdetailsdevices.Where(c => c.xid == xid).Single();
        db.mdetailsdevices.DeleteOnSubmit(dt);
        db.SubmitChanges();
        }

        public bool insermapfordevice(string filename,int id,bool type)
        {
            try
            {
                mdetailsdevice dt = db.mdetailsdevices.Where(c => c.xid == id).Single();
                byte[] filebyte = null;
                filebyte = System.IO.File.ReadAllBytes(filename);
                dt.map = filebyte;
                dt.typemap = type;
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
       

    }
}
