using System.Linq;
namespace PAYAIND
{
    public   class cschecklist
  {

      public  PAYADATA.checklist.DataSetchecklist.mchecklistitemDataTable selectchecklist(string devicecod)
      {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemTableAdapter();
          return db.GetDataBycoddevice(devicecod);
      
      }

     public int saveupdatechecklistitemcatgroy(PAYADATA.checklist.DataSetchecklist.mchecklistitemcatgroyDataTable dt)
     {
         try
         {
             PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemcatgroyTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemcatgroyTableAdapter();
          return db.Update(dt);
         }
         catch { return 0; }
     }

     public PAYADATA.checklist.DataSetchecklist.mchecklistitemcatgroyDataTable selectchecklistcategory(string devicecod)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemcatgroyTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemcatgroyTableAdapter();
         return db.GetDataBy(devicecod);
         
     }

     public PAYADATA.checklist.DataSetchecklist.mchecklistitemDataTable selectchecklistall()
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemTableAdapter();
         return db.GetData();
     }

     public bool saveupdatechecklistitem(PAYADATA.checklist.DataSetchecklist.mchecklistitemDataTable dt)
     {
         try
         {
             PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistitemTableAdapter();
             db.Update(dt); return true;
         }
         catch { return false; }
     }
      //*****************************

     public bool  existcheckheader(string devicecod,string devicenumber,string date)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.existcheckheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.existcheckheaderTableAdapter();
         if (db.GetData(devicecod, devicenumber, date).Count > 0)
             return true;
         else
             return false;


     }
     public bool Existchecklistforset(string devicecod, string devicenumber, string date)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.existcheckheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.existcheckheaderTableAdapter();
         if (db.Existchecklistforset(devicecod,devicenumber, date).Count > 0)
         {
             
             return true;
         }
         else
             return false;


     }
 
   /* ------ public PAYADATA.checklist.DataSetchecklist.mchecklistheaderDataTable selectchecklistheadercategroy(string devicecod,string fromdate, string todate)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistheaderTableAdapter();
         //return db.GetDataBycategroy(devicecod,fromdate, todate);
     }
   //*********************/
 

     public PAYADATA.checklist.DataSetchecklist.mchecklistheaderDataTable selectchecklistheader(string fromdate, string todate)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistheaderTableAdapter();
       return db.GetDataBy(fromdate, todate);
     }

     public PAYADATA.checklist.DataSetchecklist.mchecklistheaderDataTable selectchecklistheadercatgroy(string devicecod, string date)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistheaderTableAdapter();
         return db.GetDataBycategory(devicecod, date);
     }

     public bool saveupdatechecklistheader(PAYADATA.checklist.DataSetchecklist.mchecklistheaderDataTable dt)
     {
         try
         {
             PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistheaderTableAdapter();
             db.Update(dt);
             return true;
         }
         catch { return false; }
     }

     public PAYADATA.checklist.DataSetchecklist.mchecklistdetailsDataTable selectchecklistdetailsbyid(int id)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistdetailsTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistdetailsTableAdapter();
         return db.GetDataByxid(id);

     }
     public bool saveupdatechecklistdetails(PAYADATA.checklist.DataSetchecklist.mchecklistdetailsDataTable dt)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistdetailsTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistdetailsTableAdapter();
         db.Update(dt);
         return true;
     }
     public PAYADATA.checklist.DataSetchecklist.mchecklistcontrolerDataTable selectcontroler(int id)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistcontrolerTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistcontrolerTableAdapter();
        return db.GetDataBy(id);
     }
     public bool saveupdatechecklistcontroler(PAYADATA.checklist.DataSetchecklist.mchecklistcontrolerDataTable dt)
     {         
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistcontrolerTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistcontrolerTableAdapter();
         db.Update(dt);
         return true;
     }
     public bool insertchecklistheader(string date, string time, string devicecod, string devicenumber, string details)
     {
         PAYADATA.checklist.DatalinqchecklistDataContext dbb = new PAYADATA.checklist.DatalinqchecklistDataContext();
         PAYADATA.checklist.mchecklistheader dt = new PAYADATA.checklist.mchecklistheader();
         dt.xdate = date;
         dt.xtime = time;
         dt.xnote = details;
         dt.xdevicecod = devicecod; dt.xdevicenumber = devicenumber;
         dbb.mchecklistheaders.InsertOnSubmit(dt);
         dbb.SubmitChanges();
         int index = dt.xid;       
        insertchecklistitemforheader(devicecod,index);
        insertcurrentitemforheader(devicecod.Trim()+"-"+devicenumber,index,date);
        return true;
     }

     private void insertcurrentitemforheader(string devicecod, int index,string date)
     { 
         PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter dbc = new PAYADATA.DatasetcurrentTableAdapters.mcurrentrengTableAdapter();
         PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter db = new PAYADATA.DatasetcurrentTableAdapters.mcurrenTableAdapter();

         PAYAIND.cscurrent csc = new cscurrent();
         int[] a; a = csc.selectcurrentrengbycod(devicecod).Select(c => c.xid).ToArray();
        
         for (int i = 0; i < a.Length; i++)
         {

             db.Insertcurrent(index, a[i], true,0,0,0, "", date,"");
             //db.Insertcurrent(index, a[i], true, float.Parse(""), float.Parse(""), float.Parse(""), "", date);
         }

     }
     private void insertchecklistitemforheader(string devicecod, int index)
     {
        
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistdetailsTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistdetailsTableAdapter();
         int[] a; a = selectchecklist(devicecod).Select(c => c.xid).ToArray();
         for (int i = 0; i < a.Length; i++)
         {
             db.Insertchecklistitem(index, a[i]);
         }

     }
    
      
   
     //******************************ctchecklistperiodbyd
     //  ---------------------------------------
 

    // ---------------------------------------
   public bool insertchecklistheaderheadercategory(string date, string time, string devicecod, string devicenumber, string details)
       {
           PAYADATA.checklist.DatalinqchecklistDataContext dbb = new PAYADATA.checklist.DatalinqchecklistDataContext();
           PAYADATA.checklist.mchecklistheader dt = new PAYADATA.checklist.mchecklistheader();
           dt.xdate = date;
           dt.xtime = time;
           dt.xnote = details;
           dt.xdevicecod = devicecod; dt.xdevicenumber = devicenumber;
           dbb.mchecklistheaders.InsertOnSubmit(dt);
           dbb.SubmitChanges();
           int index = dt.xid;
           insertchecklistitemforheadercategory(devicecod, index);
            //insertcurrentitemforheader(devicecod, index, date);
           return true;
       }

     private void insertchecklistitemforheadercategory(string devicecod, int index)
     {
     
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistdetailsTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistdetailsTableAdapter();
         int[] a; a= selectchecklistcategory(devicecod).Select(c => c.xid).ToArray();
         for (int i = 0; i < a.Length; i++)
         {
             db.Insertchecklistitem(index, a[i]);
         }

     }


  

      //************************************************
     public IQueryable fillworkername()
     {
         PAYADATA.interuptcomp.data_interupt_compDataContext db = new PAYADATA.interuptcomp.data_interupt_compDataContext();
        return db.mworkers.OrderBy(c=> c.xname);
     }
     public PAYADATA.checklist.DataSetchecklist.mcheckliststateDataTable state()
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mcheckliststateTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mcheckliststateTableAdapter();
        return  db.GetData();
     }
     public PAYADATA.checklist.DataSetchecklist.mchecklistperiodheaderDataTable selectchecklistheaderperiod(string fromdate, string todate)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter();
        return  db.GetDataBydate(fromdate, todate);
     }
     public PAYADATA.checklist.DataSetchecklist.mchecklistperiodDataTable selectchecklistperiod(int idheader)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodTableAdapter();
         return db.GetDataBy(idheader);
     }
      /*/*/
    public void saveupdatechecklistheaderperiod(PAYADATA.checklist.DataSetchecklist.mchecklistperiodheaderDataTable tb)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter();
       
        
        db.Update(tb);
         
     }
     public void saveupdatechecklistperiod(PAYADATA.checklist.DataSetchecklist.mchecklistperiodDataTable dt)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodTableAdapter();
         db.Update(dt);
     }
     public IQueryable selectgroup()
     {
         PAYADATA.checklist.DatalinqchecklistDataContext db = new PAYADATA.checklist.DatalinqchecklistDataContext();
         return db.mchecklistgroupcontrolers.Select(c=> c);
     }
     public PAYADATA.checklist.DataSetchecklist.mchecklistperiodDataTable selectchecklistperiodbydate(string fromdate, string lastdate)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodTableAdapter();
        return  db.GetDataBydate(fromdate, lastdate);
     }
     public PAYADATA.checklist.DataSetchecklist.mchecklistperiodheaderDataTable selectchecklistheaderperiodforconfirmnet(string fromdate, string todate)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter();
         return db.GetDataconfirmnet(fromdate, todate);
     }
     public PAYADATA.checklist.DataSetchecklist.mchecklistperiodheaderDataTable selectchecklistheaderperiodforconfirmproduct(string fromdate, string todate)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter();
         return db.GetDataByconfirmproduct(fromdate, todate);
     }
     public PAYADATA.checklist.DataSetchecklist.mchecklistperiodheaderDataTable selectchecklistheaderperiodforconfirmmanage(string fromdate, string todate)
     {
         PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter db = new PAYADATA.checklist.DataSetchecklistTableAdapters.mchecklistperiodheaderTableAdapter();
         return db.GetDataByconfirmmanage(fromdate, todate);
     }

     

     
  }
}
