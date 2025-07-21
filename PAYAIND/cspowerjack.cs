using System.Linq;
using PAYADATA;
namespace PAYAIND



{
    public class cspowerjack
    {
        PAYADATA.DataLinqpowerjackDataContext db = new DataLinqpowerjackDataContext();

        public PAYADATA.powerjack.mconsumelectricalDataTable Selectpowerjack()
          
        {
            PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();

    return db.GetData();

        }

        public PAYADATA.powerjack.mconsumelectricalDataTable Selectpowerjackbyperiod(int period)
        {
            PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();

            return db.GetDataByperiod(period);

        }

        public bool insertpowerjacki(int period, string xsteelpowerconsumption, string xamounelectricity, string xfinedamountofreactive,
            string xreactivepowerconsumption, string xincreasedymand, string xamountfinesdymand, string xamountofpowerconsumed,float xsaving, float xratioconsumamount, float xratiopowerconsumsteelconsum, string xstartdate, string xtodate,string xtax,string  xnpdymand,
          string xnpreactive, float xnpkwkg, float xnprkg, string xnpprice, float xnpsaving)
        {
            PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();
            try

            {
                db.Insertpowerjack(period,xsteelpowerconsumption,xamounelectricity,xfinedamountofreactive,xreactivepowerconsumption,xincreasedymand,xamountfinesdymand,xamountofpowerconsumed,xstartdate,xtodate,xratioconsumamount,xsaving,xratiopowerconsumsteelconsum,
                    xtax, xnpdymand, xnpreactive, xnpkwkg, xnprkg, xnpprice,xnpsaving);
            return true; 
            }

            catch

            {

                return false;
            }
        }

        public bool updatepowerjacki(int xperiod, string xsteelpowerconsumption, string xamounelectricity, string xfinedamountofreactive,
            string xreactivepowerconsumption, string xincreasedymand, string xamountfinesdymand, string xamountofpowerconsumed, float xsaving,
       float xratioconsumamount, float xratiopowerconsumsteelconsum, string xstartdate, string xtodate, string xtax, string xnpdymand, string xnpreactive, float xnpkwkg, float xnprkg, string xnppric, float xnpsaving, int xid)
        {
            try
            {    
                PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();
                db.Updatepowerjack(xperiod, xsteelpowerconsumption, xamounelectricity, xreactivepowerconsumption, xfinedamountofreactive, xincreasedymand, xamountfinesdymand, xamountofpowerconsumed, xstartdate, xtodate, xsaving, xratioconsumamount, xratiopowerconsumsteelconsum, xtax, xnpdymand, xnpreactive, xnpkwkg, xnprkg, xnppric, xnpsaving, xid);
                return true;
            }
            catch { return false; }
        }

        public bool poewrjackexist(int period)
        {
            PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();
            try
            {

                if (db.GetDataByperiod(period).Count > 0)
                    return true;
                else
                    return false;
            }

            catch
            {
                return false;
            }

        }

        public int selectxid(int period)
        {
            PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();

            try
            {

                return db.Getxid(period).Value;
            }
            catch
            {
                return 0;
            }
 

        }



    public int selectmaxperiod(int period)
        {
            PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();
            try
            {

                return db.Getmaxperiod(period).Value;
            }
            catch
            {
                return 0;
            }
 
        }

    public float selectxratioconsumamount(int period)
    {
        PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();
        try
        {
            return db.Getxratioconsumamount(period).Value;
        }

        catch { }
        return 0;
    }


    public bool deletepowerjacki(int xid  )  {
        PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();
        try
        {

            db.Deletebyxid(xid);

            return true;
        }
        catch
        {
            return false;
        }
    }


    public PAYADATA.powerjack.mconsumelectricalDataTable selectpowerjackforprint(int xid)
    {
        PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();
        return db.GetDataByperiod(xid);
    }
   
        public PAYADATA.powerjack.mpowerindexDataTable selectpowerindex()
    {
        PAYADATA.powerjackTableAdapters.mpowerindexTableAdapter db = new PAYADATA.powerjackTableAdapters.mpowerindexTableAdapter();
        return db.GetData();
    }
        public PAYADATA.powerjack.mpowerindexDataTable selectpowerindexby(int index)
        {
            PAYADATA.powerjackTableAdapters.mpowerindexTableAdapter db = new PAYADATA.powerjackTableAdapters.mpowerindexTableAdapter();
            return db.GetDataBy(index);
        }
        public bool insertpowerindex(string xindexname,int xindexid,string xprice)
        {

            try
            {
                PAYADATA.powerjackTableAdapters.mpowerindexTableAdapter db = new PAYADATA.powerjackTableAdapters.mpowerindexTableAdapter();
                db.Insertpowerindex(xindexname, xindexid, xprice);
                return true;
            }
            catch { return false; }

        }
        public int saveupdatepowerindex(PAYADATA.powerjack.mpowerindexDataTable dt)
        {
            try
            {
                PAYADATA.powerjackTableAdapters.mpowerindexTableAdapter db = new PAYADATA.powerjackTableAdapters.mpowerindexTableAdapter();
                return db.Update(dt);
            }
            catch { return 0; }
        }


       public  bool Confirms_net_Manager( int xiduser_Confirms_net ,bool  xCertified_net_Manager,int xid )
       {
             PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter db = new PAYADATA.powerjackTableAdapters.mconsumelectricalTableAdapter();

          
           try
             {
                db.Confirms_net_Manager(xiduser_Confirms_net, xCertified_net_Manager, xid);
                return true;
             }
             catch
             {
                 return false;
             }
       }

        public string selectnameindex(int xindexid)
        {
            string ss;
            ss = "";
            try
            {
                ss =  db.mpowerindexes.Where(c => c.xindexid== xindexid).Select(c => c.xindexname).First();
            }
            catch { }
            return ss;  
        }

        public string selectindexprice(int xindexid)
        {
            string ss;
            ss = "";
            try
            {
                ss = db.mpowerindexes.Where(c => c.xindexid == xindexid).Select(c => c.xindexprice).First();
            }
            catch { }
            return ss;
        }

        public PAYADATA.powerjack.powerprintDataTable selectforprint(string stratdate,string todate)
        {
            PAYADATA.powerjackTableAdapters.powerprintTableAdapter db = new PAYADATA.powerjackTableAdapters.powerprintTableAdapter();

            return db.Getforprint(stratdate,todate);


        }


    }
}
