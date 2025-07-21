using System.Linq;

namespace PAYAIND
{
    public  class csrequsetconstruct
    {
       public PAYADATA.DataSetrequestconstruct.munitDataTable selectunit()
       {
        using( PAYADATA.DataSetrequestconstructTableAdapters.munitTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.munitTableAdapter())
           return db.GetData();
       }
       public PAYADATA.DataSetrequestconstruct.objecttableDataTable selectobjectconstruct()
       {
           using (PAYADATA.DataSetrequestconstructTableAdapters.objecttableTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.objecttableTableAdapter())
               return db.GetDataBy();
       }
       public int insertrequestheader( string date,string time ,int idrequester,bool xtype,string explain)
       {
          try
           {
                {  
                    
                    PAYADATA.DataSetrequestconstruct.requestconstructheaderDataTable dt = new PAYADATA.DataSetrequestconstruct.requestconstructheaderDataTable();
                    PAYADATA.DataSetrequestconstruct.requestconstructheaderRow dr;
                    dr= dt.NewrequestconstructheaderRow();                    
                    dr.xchecked =1;                   
                    dr.xdate = date; dr.xexplain = explain; dr.xidreqester = idrequester; dr.xtime = time; dr.xtype = xtype;                   
                    dt.AddrequestconstructheaderRow(dr);
                    PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter();
                    db.Update(dt);
                    return dr.xid;
               }              
           }
         catch { return -1; }
       }
       public void insertrequest(int idrequest,string cod,string name,int unit,int masraf,int count,bool hastype,string explain)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter();
           db.Insertrequest(idrequest, cod, name, unit, masraf, count, hastype, 1, explain);
       }
       public PAYADATA.DataSetrequestconstruct.requestconstructheaderDataTable selectrequest(string username)
       {
           PAYAIND.cslogin clogin= new cslogin();
           int id = clogin.returnid(username);
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter();
           return db.GetDataBy1(id);
       }
       public PAYADATA.DataSetrequestconstruct.requestconstructDataTable selectrequestbyidheader(int idheader)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter();
           return db.GetDataByidrequest(idheader);
       }
       public void savechangeheader(int idrequest, bool xtype, string explain)
       {
           {
               PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter();
               db.Updatebyxid(xtype, explain, idrequest);
           } 
         
       }
       public void savechange(PAYADATA.DataSetrequestconstruct.requestconstructDataTable dt)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter();
           db.Update(dt);
       }
       public void removerequest(int id)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter();
           db.DeleteQuery(id);
       }
       public PAYADATA.DataSetrequestconstruct.requestconstructstateDataTable stateofrequest()
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructstateTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructstateTableAdapter();
           return db.GetData();
       }
       public PAYADATA.DataSetrequestconstruct.requestconstructheaderDataTable selectrequestheaderbydate(string fromdate,string todate)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter();
           return   db.GetDataBydate(todate, fromdate);
       }
       public void saveupdateheader(PAYADATA.DataSetrequestconstruct.requestconstructheaderDataTable dt)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructheaderTableAdapter();
           db.Update(dt);
       }
       public void saveupdaterequest(PAYADATA.DataSetrequestconstruct.requestconstructDataTable dt)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter();
           db.Update(dt);
       }
       public void savedatailsforrequest(int id, bool map, bool internulbuild, bool history, bool evalution, string adress, string date, int day)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructTableAdapter();
           db.Updatedetailsrequest(map, internulbuild, history, evalution, adress, date, day, id);
       
       }
       public PAYADATA.DataSetrequestconstruct.requestconstructreciveobjectDataTable selectconstructreciveobject(int idrequest)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructreciveobjectTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructreciveobjectTableAdapter();
           return   db.GetDataByidrequest(idrequest);
       }
       public void insertrequestconstructreciverobject(int idrequest,string date,int countrecive, int countreciveok)
       {
           PAYADATA.DataSetrequestconstructTableAdapters.requestconstructreciveobjectTableAdapter db = new PAYADATA.DataSetrequestconstructTableAdapters.requestconstructreciveobjectTableAdapter();
           if (db.GetDataByidrequest(idrequest).Any())
               db.Updaterequestrecive(date, countrecive, countreciveok, idrequest);
           else db.Insertrequestreciveobject(idrequest, date, countrecive, countreciveok);
       }
      
    }
}
