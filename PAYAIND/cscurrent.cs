using System;
using System.Linq;

namespace PAYAIND
{
    public class cscurrent
    {
     
        PAYAIND.fillcombo css = new PAYAIND.fillcombo();
        IQueryable query;
        PAYADATA.DatalinqcurrentDataContext db = new PAYADATA.DatalinqcurrentDataContext();

        public PAYADATA.Datasetcurrent.mcurrenDataTable selectcurrent()
        {
            PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter();
            return db.GetData();
        }
        public PAYADATA.Datasetcurrent.mcurrenDataTable selectcurrentbychecklistid(int id,bool xcheclist)
        {
            PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter();
            return db.GetDataBychecklistcode(id,xcheclist);
        }

    public PAYADATA.Datasetcurrent.mcurrenDataTable selectcurrentbychecklistidforset(int id, bool xchecklist,int currentrengeid)
        {
            PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter();
            return db.GetDataforSet(id, xchecklist,currentrengeid);
        }

        public PAYADATA.Datasetcurrent.mcurrenttypeDataTable selectcurrenttype()
        {
            PAYADATA.DatasetcurrentTableAdapters.mcurrenttypeTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrenttypeTableAdapter();
            return db.GetData();
        }

        public PAYADATA.Datasetcurrent.mcurrentrengDataTable selectcurrentreng()
        {
            PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter();
            return db.GetData();
        }
        public PAYADATA.Datasetcurrent.mcurrentrengDataTable selectcurrentrengbycod(string cod)
        {
            PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter();
            return db.GetDataBydevicecod(cod);
        }

  
        public bool insertcurrntreng(string xdevicecod,int xidcurrenttype, float xmincurrent, float xmidcurrent, float xmaxcurrent)
        {
            try
            {
                PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter();
                db.Insertcurrentreng(xdevicecod,xidcurrenttype, xmincurrent, xmidcurrent, xmaxcurrent);
                return true;
            }
            catch { return false; }
        }


        public bool existcurrentdevice(string xdevicecod)
        {
            try
            {
                PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter();
                if (db.GetDataBycod(xdevicecod).Count > 0)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }
     
        public string selectcurrenttypeby( int id) 
        {

            string ss;
            ss = "";
            try
            {
                ss =  db.mcurrenttypes.Where(c => c.xid == id).Select(c => c.xcurrentypename).First();
            }
            catch { }
            return ss;  
        }

       public int selectcurrenttypeid(int idcurrentreng)
        {

            int currenttypeid;
           
         
        
                 currenttypeid=Convert.ToInt16( db.mcurrentrengs.Where(c => c.xid ==idcurrentreng).Select(c => c.xidcurrenttype).First());

                 return currenttypeid;
        
          

           // return currenttypeid;
        }

        public bool saveupdatecurrntreng( PAYADATA.Datasetcurrent.mcurrentrengDataTable dt)
        {
            try
            {
                PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter();
                db.Update(dt); 
                return true;
            }

            catch { return false; }
        }
        //*****************************


        public bool saveupdatecurrnt(PAYADATA.Datasetcurrent.mcurrenDataTable dt)
        {
            try
            {
                PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter();
                db.Update(dt);
                return true;
            }

            catch { return false; }
        }
        //*****************************

        public string sellectcodedeviccurrentreng(int id)
        {

         

                  string ss;
            ss = "";
            try
            {
                ss =  db.mcurrentrengs.Where(c => c.xid == id).Select(c => c.xdevicecod).First();
            }
            catch { }
            return ss;  


        }

        public bool insertcurrnt(int xidchecklist, int xidcurrentrenge, bool xcheckkist, float xcurrentR, float xcurrentS, float xcurrentT, string xcurrentmsgid, string xnot, string xdate)
        {
            try
            {
                PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter();
                db.Insertcurrent(xidchecklist, xidcurrentrenge, xcheckkist, xcurrentR, xcurrentS, xcurrentT, xnot, xdate,xcurrentmsgid);
                return true;
            }
            catch { return false; }
        }
     
        public IQueryable fillcombocurrentmsg()
        {
            query = db.mcurrentcommsgs.Select(c => c).OrderBy(c => c.xname);
            return query;
        }

        public string sellectcodeforcurrentmsg(int xidcurrentrenge, float currentR, float currentS, float currentT)
        {
            string sss = "000";
            try
            {
                float mincurrent = db.mcurrentrengs.Where(c => c.xid == xidcurrentrenge).Select(c => c.xmincurrent).First();
                float midcurrent = db.mcurrentrengs.Where(c => c.xid == xidcurrentrenge).Select(c => c.xmidcurrent).First();
                float maxcurrent = db.mcurrentrengs.Where(c => c.xid == xidcurrentrenge).Select(c => c.xmaxcurrent).First();
                sss = setcodeforcurrentmsg(currentR, mincurrent, maxcurrent) + setcodeforcurrentmsg(currentS, mincurrent, maxcurrent) + setcodeforcurrentmsg(currentT, mincurrent, maxcurrent);
          
            }
            catch { }
            return sss;  
        }

        public string setcodeforcurrentmsg(float current, float mincurrent, float maxcurrent)
        {
            string s = "0";
            if (current == 0)
                return s;
            else if (current < mincurrent)
                s = "2";
            else if (current > maxcurrent)
                s = "3";
            else if (mincurrent < current && current < maxcurrent)
                s = "1";
            return s;
        }

        public string selectcurrentmsgbycod(string s)
        {
            try
            {
                s = db.mcurrentcommsgs.Where(c => c.xcodtype == s).Select(c => c.xname).First();
            }
            catch { }
            return s;
        }


        public int selectcurrentrengid(string devicecod)
        {

            int currentrengid;

                currentrengid = Convert.ToInt16(db.mcurrentrengs.Where(c => c.xdevicecod == devicecod).Select(c => c.xid).First());

                    return currentrengid;
         
  
        }
        public string  devicenameforcurrent(string devicecode)
        {
            string devicename="";
       
             if(devicecode.Length==15)
                    devicename=  css.fillcombonamedeviceset(devicecode.Substring(0, 9)) + "-"
                        + css.fillcombonamedeviceset2(devicecode.Substring(0, 12)) + "-"
                        + css.fillcombonamedeviceset3(devicecode);
                 if(devicecode.Length==12)
                   devicename= css.fillcombonamedeviceset(devicecode.Substring(0, 9)) + "-"
                        + css.fillcombonamedeviceset2(devicecode.Substring(0, 12));
                if(devicecode.Length==9)
                  devicename= css.fillcombonamedeviceset(devicecode.Substring(0, 9));
          return devicename;
            }

 //**************************************************
public void updatecurrentrenge (int xid,int xidcurrenttype,float  xmincurrent,float xmidcurrent, float xmaxcurrent)
{
    PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter db=new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter ();
    try{

    db.Updatecurrentrenge(xidcurrenttype,xmincurrent,xmidcurrent,xmaxcurrent,xid);

    }
    catch{}
}


public void deletcurrentreng(int xid)
{
    PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter();
    try
    {

        db.Deletecurrentreng(xid);

    }

    catch { }

}
public PAYADATA.Datasetcurrent.viewcurrentrenge1DataTable  selectviewcurrent()
{
    PAYADATA.DatasetcurrentTableAdapters.viewcurrentrenge1TableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.viewcurrentrenge1TableAdapter();
    return db.GetData();
}

//*****************************************
      

    }
}
