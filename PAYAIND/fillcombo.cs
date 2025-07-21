using System;
using System.Linq;

namespace PAYAIND
{
    public class fillcombo
   {

       IQueryable query;
       PAYADATA.coding.Data_linq_coding_objectDataContext db = new PAYADATA.coding.Data_linq_coding_objectDataContext();
       PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext dbs = new PAYADATA.trubleshooting.DatalinqtrubleshootingDataContext();
       public IQueryable fillcomboname_truble()
       {

           //query=dbs.m
           return query;
       }

        public IQueryable fillcombonamedevice()
        {           
            
           query = db.mdetailsdevices.Select(c => c).OrderBy(c=> c.xnamedevice);
            return query;
        }

       //---------------------------------------

        public string fillcombonamedeviceset(string code_device_set)//نام زیر دستگاه در مجموعه 1 
        {

            string ss;
            ss = "";
            try
            {
                ss = db.mdeviceset1s.Where(c => c.xcod == code_device_set).Select(c => c.xnameset1).First();
            }
            catch { }
            return ss;  
        }
        public string fillcombonamedeviceset2(string code_device_set)//نام زیر دستگاه در مجموعه 2 
        {

            string ss;
            ss = "";
            try
            {
                ss = db.mdeviceset2s.Where(c => c.xcodfinalset2 == code_device_set).Select(c => c.xnameset2).First();
            }
            catch { }
            return ss;
        }
        public string fillcombonamedeviceset3(string code_device_set)//نام زیر دستگاه در مجموعه 3 
        {
            string ss;
            ss = "";
            try
            {
                ss = db.mdeviceset3s.Where(c => c.xcodfinalset3 == code_device_set).Select(c => c.xnameset3).First();
            }
            catch { }
            return ss;
        }
        public IQueryable fillcombo_setbycod(string cod_of_device)// نام زیر مجموعه ها بوسیله کد دستگاه مادر
        {
            query = db.mdeviceset1s.Select(c => c).Where(c => c.xiddevice == (cod_of_device));
            return query;
        }
        public IQueryable fillcombo_set()// نام زیر مجموعه ها بوسیله کد دستگاه مادر
        {
            query = db.mdeviceset1s.Select(c => c).OrderBy(c =>c.xcod);
            return query;
        }
       //----------------------------------------
        public IQueryable fillcombolocation()
        {
          return  query = db.mlocations.Select(c => c);
        }
        public IQueryable fillcombonamedevicebycod()
        {
            query = db.mdetailsdevices.Select(c => new { c.xnamedevice, c.xcoddevice}).Distinct().OrderBy(c=> c.xnamedevice);
            return query;
        }
        public IQueryable fillcombono(string namedevice)
        {
            try
            {
                string cod = db.mdetailsdevices.Where(c => c.xnamedevice == namedevice).Select(c => c.xcoddevice).Single().Substring(0,3);
                query = db.devices.Where(c => c.xiddevice == cod).Select(c => c.xnumber);
                return query;
            }
            catch { }
            return query;
        }
        public string cod_of_device(string device_name)
        {
            string ss;
            ss = "";
           try
            {
                ss= db.mdetailsdevices.Where(c => c.xnamedevice.Trim() == device_name.Trim()  ).Select(c => c.xcoddevice).First().Trim();
            }
            catch { }
            return ss;
        }
        public string cod_of_deviceforinterupt(string device_name, string device_no)
        {
            string ss;
            ss = "";
            try
            {
                string cod = db.mdetailsdevices.Where(c => c.xnamedevice == device_name).Select(c => c.xcoddevice).Single();
      
                ss = db.devices.Where(c => c.xiddevice == cod && c.xnumber.ToString() == device_no).Select(c => c.xcod).First();
            
            }
            catch { }
            return ss;
        }
        public string devicenamebycod(string devicecod)
        {
            string ss;
            ss = "";
            try
            {
                ss = db.mdetailsdevices.Where(c => c.xcoddevice == devicecod).Select(c => c.xnamedevice).Single();
            }
            catch { }
            return ss;
        }
        public IQueryable fillcombo_set1(string cod_of_device)
        {
          
            query = db.mdeviceset1s.Where( c => c.xiddevice==( cod_of_device ) && c.xcod.Substring(7,2) != "00" ).Select(c => c);
            return query;

        }
        public IQueryable fillcombo_set2(string codset1)
        {
            query = db.mdeviceset2s.Where(c => c.xparentid == codset1 && c.xcodfinalset2.Substring(10, 2) != "00").Select(c => c);
            return query;
        }
        public IQueryable fillcombo_set3(string codset2)
        {
            query = db.mdeviceset3s.Where(c => c.xparentid == (codset2) && c.xcodfinalset3.Substring(13, 2) != "00").Select(c => c);
            return query;
        }
        public string cod_of_set1(string name_set1,string cod_device)
       {
           string ss = db.mdeviceset1s.Where(c => c.xnameset1 == name_set1 && c.xiddevice.StartsWith(cod_device)).Select(c => c.xcod).First();
           return ss;
       }
        public string cod_of_set2(string name_set2, string codset1)
        {
            try
            {
                string ss = db.mdeviceset2s.Where(c => c.xnameset2 == name_set2 && c.xparentid.StartsWith(codset1)).Select(c => c.xcodfinalset2).First();
                return ss;
            }
            catch { return ""; }
       }
        public IQueryable fillcombo_object_name()
       {
           query = db.objecttables.OrderBy(c=>c.xname).Select(c => c);
           return query;
       }
        public string cod_of_object(string name)
       {
           return db.objecttables.Where(c => c.xname == name).Select(c => c.xid).First();          
       }
        //public string finalcod(string location, string devicename, string deviceno, string set1, string set2,string set3, string objectname)
        //{
        //    string codfinal = location+"-";
        //    string coddevice = cod_of_device(devicename);
        //    codfinal += coddevice+"-"+deviceno+"-";
        //    codfinal += db.mdeviceset1s.Where(c => c.xnameset1 == set1&& c.xiddevice==coddevice).Select(c => c.xid).Single()+"-";
        //    codfinal += db.mdeviceset2s.Where(c => c.xnameset2 == set2&& c.xcoddevice== coddevice).Select(c => c.xcodset2).Single()+"-";
        //    codfinal += db.mdeviceset3s.Where(c => c.xnameset3 == set3 && c.xcoddevice == coddevice).Select(c => c.xcodset3).Single() + "-";
        //    codfinal += cod_of_object(objectname);
        //    return codfinal;
        //}
        public string returnmaxcodobject(string COD)
       {string i="1000";
       
       try
       {
           i = db.objecttables.Where(c => c.xid.Contains(COD)).Select(c => c.xid).Max();
           i = i.Substring(0, 4);
           i = (Convert.ToInt64(i) + 1).ToString();
           if (i.Length < 2)
           {i= "100"+i; }

       }
       catch { i = "1000"; }
       return i;
       }
        public string returnmaxcodset1(string namedevic,string number)
        {
            string i;
            string coddevice = cod_of_device(namedevic);
            i = db.mdeviceset1s.Where(c=> c.xiddevice==coddevice+"-"+number).Select(c => c.xid).Max();
            try
            {               
                i = (Convert.ToInt64(i) + 1).ToString();
                if (Convert.ToInt32(i) <= 9)
                    i = "0" + i;
            }
            catch { i = "00"; }
            return i;
        }
        public string returnmaxcodset2(string codset1)
        {
            string i;
            
            i = db.mdeviceset2s.Where(c => c.xparentid == codset1).Select(c => c.xid).Max();
            try
            {
                i = (Convert.ToInt64(i) + 1).ToString();
                if (Convert.ToInt32(i) <= 9)
                    i = "0" + i;
            }
            catch { i = "00";}
            return i;
        }
        public string returnmaxcodset3(string codset2)
        {
            string i;
           
            i = db.mdeviceset3s.Where(c => c.xparentid == codset2).Select(c => c.xid).Max();
            try
            {
                i = (Convert.ToInt64(i) + 1).ToString();
                if (Convert.ToInt32(i) <= 9)
                    i = "0" + i;
            }
            catch { }
            return i;
        }
       
     

        public IQueryable fillcombo_set1forview(string codof_device_in_saloon)
        {
           return query = db.mdeviceset1s.Where(c => c.xiddevice.Contains(codof_device_in_saloon)).Select(c => c.xnameset1);

        }
        public IQueryable fillcombo_set2forview(string codset1)
        {
            return query = db.mdeviceset2s.Where(c => c.xparentid.Contains(codset1)).Select(c => c);
        }
        public IQueryable fillperiod()
        {
            return db.mPeriods;

        }
        public IQueryable filldevice_state()
        {
            return db.mdevice_states;

        }
        public IQueryable filllevelautomation()
        {
            return db.mlevelautomationdevices;

        }


        //public string  finalcodforset2(string devicename, string deviceno, string set1, string set2)
        //{
        //    try
        //    {
        //        string codfinal = "";
        //        string coddevice = cod_of_device(devicename);
        //        codfinal += coddevice + "-" + deviceno + "-";
        //        codfinal += db.mdeviceset1s.Where(c => c.xnameset1 == set1 && c.xiddevice == coddevice).Select(c => c.xid).Single() + "-";
        //        codfinal += db.mdeviceset2s.Where(c => c.xnameset2 == set2 && c.xcoddevice == coddevice).Select(c => c.xcodset2).Single();
        //        return codfinal;
        //    }
        //    catch { return ""; }

        //}
        //public string finalcodforset3(string devicename, string deviceno, string set1, string set2,string set3)
        //{
        //    try
        //    {
        //        string codfinal = "";
        //        string coddevice = cod_of_device(devicename);
        //        codfinal += coddevice + "-" + deviceno + "-";
        //        codfinal += db.mdeviceset1s.Where(c => c.xnameset1 == set1 && c.xiddevice == coddevice).Select(c => c.xid).Single() + "-";
        //        codfinal += db.mdeviceset2s.Where(c => c.xnameset2 == set2 && c.xcoddevice == coddevice).Select(c => c.xcodset2).Single()+"-";
        //        codfinal += db.mdeviceset3s.Where(c => c.xnameset3 == set3 && c.xcoddevice == coddevice).Select(c => c.xcodset3).First();

        //        return codfinal;
        //    }
        //    catch { return ""; }

        //}
        //public string finalcodforset1(string devicename, string deviceno, string set1)
        //{
        //    string codfinal = "";
        //    string coddevice = cod_of_device(devicename);
        //    codfinal += coddevice + "-" + deviceno + "-";
        //    codfinal += db.mdeviceset1s.Where(c => c.xnameset1 == set1 && c.xiddevice == coddevice).Select(c => c.xid).Single() ;
        //  //  codfinal += db.mdeviceset2s.Where(c => c.xnameset2 == set2 && c.xcoddevice == coddevice).Select(c => c.xcodset2).Single() + "-";
        //    return codfinal;

        //}

        public IQueryable fillcombonameminobject(string knid)
        {
            PAYADATA.coding.Data_linq_coding_objectDataContext db = new PAYADATA.coding.Data_linq_coding_objectDataContext();
            char[] a = knid.ToArray();
            return db.mobjectcods.Where(c => c.knid == a[0]).Select(c => c).OrderBy(c=> c.xname);
        }
       
     


    }
}
