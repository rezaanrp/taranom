using System;
using System.Linq;
using System.Data;

namespace PAYAIND
{
    public class cs_interupt_comp
    {
        PAYADATA.interuptcomp.data_interupt_compDataContext db = new PAYADATA.interuptcomp.data_interupt_compDataContext();
        PAYADATA.data_name_operatorDataContext dbname = new PAYADATA.data_name_operatorDataContext();
        PAYADATA.interuptcomp.Data_interup_trubleDataContext dbb = new PAYADATA.interuptcomp.Data_interup_trubleDataContext();

        //PAYADATA.Data_linq_coding_objectDataContext dbobject = new PAYADATA.Data_linq_coding_objectDataContext();
        IQueryable query;
        public PAYADATA.interuptcomp.dsinteruptcomp.interupt_compDataTable fill_interupt(string firstdate, string lastdate)
        {
            PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter dbb = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter();
            return dbb.GetDataBydatefordatagrid(firstdate, lastdate);
            //db.interupt_comps.Where(c => string.Compare(firstdate, c.xdate_request) <= 0 && string.Compare(lastdate, c.xdate_request) >= 0).Join(db.mworkers.DefaultIfEmpty(), a => a.xidfirstoperator, b => b.xid,
            //(a, b) => new
            //{
            //    a.x_id,
            //    a.xdate_deliver_tonet,
            //    a.xdate_delivertopro,
            //    a.xdate_end_repair,
            //    a.xdate_request,
            //    a.xdate_start_interupt,
            //    a.xdate_start_repair,
            //    a.xdevice_cod,
            //    a.xelat_interupt,
            //    a.xidfirstoperator,
            //    a.xidsecond_operator,
            //    a.xiduserrequest,
            //    a.xtime_between_in_re,
            //    a.xtime_deliver_tonet,
            //    a.xtime_delivertopro,
            //    a.xtime_end_repair,
            //    a.xtime_interupt,
            //    a.xtime_repairing,
            //    a.xtime_request,
            //    a.xtime_start_interupt,
            //    a.xtime_start_repair,
            //    a.x_activity,
            //    foperator = b.xname
            //}).Join(
            //db.mworkers.DefaultIfEmpty(), a => a.xidsecond_operator, b => b.xid, (a, b) =>
            //new
            //{
            //    a.x_id,
            //    a.xdate_deliver_tonet,
            //    a.xdate_delivertopro,
            //    a.xdate_end_repair,
            //    a.xdate_request,
            //    a.xdate_start_interupt,
            //    a.xdate_start_repair,
            //    a.xdevice_cod,
            //    a.xelat_interupt,
            //    a.xidfirstoperator,
            //    a.xidsecond_operator,
            //    a.xiduserrequest,
            //    a.xtime_between_in_re,
            //    a.xtime_deliver_tonet,
            //    a.xtime_delivertopro,
            //    a.xtime_end_repair,
            //    a.xtime_interupt,
            //    a.xtime_repairing,
            //    a.xtime_request,
            //    a.xtime_start_interupt,
            //    a.xtime_start_repair,
            //    a.x_activity,
            //    a.foperator,
            //    loperator = b.xname
            //}).Join(db.tablelogins, a => a.xiduserrequest, b => b.xid, (a, b) =>
            //    new
            //    {
            //        a.x_id,
            //        a.xdate_deliver_tonet,
            //        a.xdate_delivertopro,
            //        a.xdate_end_repair,
            //        a.xdate_request,
            //        a.xdate_start_interupt,
            //        a.xdate_start_repair,
            //        a.xdevice_cod,
            //        a.xelat_interupt,
            //        a.xidfirstoperator,
            //        a.xidsecond_operator,
            //        a.xiduserrequest,
            //        a.xtime_between_in_re,
            //        a.xtime_deliver_tonet,
            //        a.xtime_delivertopro,
            //        a.xtime_end_repair,
            //        a.xtime_interupt,
            //        a.xtime_repairing,
            //        a.xtime_request,
            //        a.xtime_start_interupt,
            //        a.xtime_start_repair,
            //        a.x_activity,
            //        a.foperator,
            //        a.loperator,
            //        namerequest = b.name
            //    });
        }
        //********************
        /*   public PAYADATA.interuptcomp.dsinteruptcomp.mobject_disposalDataTable fill_object(int xid,string type)
           {PAYADATA.interuptcomp.dsinteruptcompTableAdapters.mobject_disposalTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.mobject_disposalTableAdapter();
           return db.GetDataBy(xid ,type);
           }
           //*****************************
           public PAYADATA.interuptcomp.dsinteruptcomp.viewdisposal_objectDataTable  fill_objectbycod(int xid, string type)
           {
               PAYADATA.interuptcomp.dsinteruptcompTableAdapters.viewdisposal_objectTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.viewdisposal_objectTableAdapter();
               return db.GetDataBy(xid,type);
           }

           public PAYADATA.interuptcomp.dsinteruptcomp.viewdisposal_objectDataTable fill_alldisposalobject()
           {
            PAYADATA.interuptcomp.dsinteruptcompTableAdapters.viewdisposal_objectTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.viewdisposal_objectTableAdapter();
               return db.GetData();
          
           }


           public void delet_object_disposal(int xid)
           {
               PAYADATA.interuptcomp.dsinteruptcompTableAdapters.mobject_disposalTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.mobject_disposalTableAdapter();
               db.DeleteBy(xid);
           }


      
           public void saveobjectdispos(PAYADATA.interuptcomp.dsinteruptcomp.mobject_disposalDataTable dt)
           {
               PAYADATA.interuptcomp.dsinteruptcompTableAdapters.mobject_disposalTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.mobject_disposalTableAdapter();
               db.Update(dt);
           }
         public void insertobjectmasrafi(string id, string name, string count,string type)
           {
           PAYADATA.interuptcomp.mobject_disposal table = new PAYADATA.interuptcomp.mobject_disposal();
         
               table.xid_interupt =Convert.ToInt32( id);
               table.xcount = Convert.ToInt32(count);
               table.x_cod_objects_disposal = (name);
               table.xtype = type;
               db.mobject_disposals.InsertOnSubmit(table);
               db.SubmitChanges();
           }
           public void deletobject(string cod,string type)
        {
            PAYADATA.interuptcomp.mobject_disposal tb = new PAYADATA.interuptcomp.mobject_disposal();
            tb = db.mobject_disposals.Where(c => c.xid ==Convert.ToInt32( cod)&& c.xtype==type).Select(c => c).Single();
            db.mobject_disposals.DeleteOnSubmit(tb);
            db.SubmitChanges();
        }*/

        //*****************
        public IQueryable fill_repairer(int xid)
        {
            return query = db.mserviceman_hours.Where(c => c.xid_interupt == xid && c.xtype == "plan").Select(c => new { c.xid, c.xid_interupt, c.xname_repairer, c.xhours });
        }
        public IQueryable fill_repairer_inteuptcomp(int xid)
        {
            return query = db.mserviceman_hours.Where(c => c.xid_interupt == xid && c.xtype == "comp").Select(c => new { c.xid, c.xid_interupt, c.xname_repairer, c.xhours });
        }
        public int insertrequestrenovation(int iduserrequset, string devicecod, int? idoperator, string time, string date, string havoc)
        {
            PAYADATA.interuptcomp.interupt_comp tb = new PAYADATA.interuptcomp.interupt_comp();
            tb.xiduserrequest = iduserrequset;
            tb.xtime_request = time;
            tb.xdate_request = date;
            tb.xdevice_cod = devicecod;
            tb.xidfirstoperator = idoperator;
            tb.xelat_interupt = havoc;
            db.interupt_comps.InsertOnSubmit(tb);
            db.SubmitChanges();
            return tb.x_id;
        }
        public void inserttrubleforrequest(int idparent, int idtruble)
        {
            PAYADATA.interuptcomp.mselectedtrubleshooting tb = new PAYADATA.interuptcomp.mselectedtrubleshooting();
            tb.xidofparent = idparent;
            tb.xtypeofparant = "comp";
            tb.xidtruble = idtruble;
            dbb.mselectedtrubleshootings.InsertOnSubmit(tb);
            dbb.SubmitChanges();
        }
        public IQueryable operator_name()
        {
            return query = dbname.mworkers.Where(c => c.xgroup == 2);
        }
        public IQueryable filterobject(string coddevice, string nameobject)
        {
            query = db.objecttables.Join(db.mallobjects, c => c.xid, z => z.xid,
                (a, b) => new { a.xname, b.xcod }).Where(c => c.xname.Contains(nameobject) && c.xcod.Contains(coddevice)).Select(c => new { c.xname, c.xcod });
            // query = dbobject.object_set2s.Where(c => c.xcod.Contains(coddevice)).Select(c => c).Join(dbobject.objecttables, x => x.xid, z => z.xid, (a, b) => new { a.xcod, b.xname });
            return query;
        }
        public IQueryable fillcomborepairer()
        {
            return dbname.mworkers.Where(c => c.xgroup == 1);

        }

        public void insertservickaran(string id, string name, string h, string type)
        {

            PAYADATA.interuptcomp.mserviceman_hour table = new PAYADATA.interuptcomp.mserviceman_hour();
            table.xhours = Convert.ToDouble(h);
            table.xid_interupt = Convert.ToInt32(id);
            table.xname_repairer = name;
            table.xtype = type;
            db.mserviceman_hours.InsertOnSubmit(table);
            db.SubmitChanges();

        }
        public void inserinterupt(string devicecod, string operator1, string datestartinterupt, string timestartinterupt, string elat, string datestartrepair, string timestartrepair, string activity, string dateendrepair,
            string timeendrepair, string operator2, string datedelivertonet, string timedelivertonet, string datedelivertopro, string timedelivertopro,
            string timerepair, string timeinterupt, string timebetweenin_re, string cause)
        {

            DateTime dstartin = Convert.ToDateTime(datestartinterupt); DateTime dstartre = Convert.ToDateTime(datestartrepair); DateTime dendre = Convert.ToDateTime(dateendrepair);
            DateTime ddelivertonet = Convert.ToDateTime(datedelivertonet);
            DateTime ddelivertopro = Convert.ToDateTime(datedelivertopro);
            int i1, i2, i3;
            i1 = Convert.ToInt32(timerepair);
            i2 = Convert.ToInt32(timeinterupt);
            i3 = Convert.ToInt32(timebetweenin_re);

            //  db.Insertinteruptcomp(devicecod, operator1, d1, timeinterupt, elat, d2, timestart, activity, d3, timeend, operator2);
            //db.Insertinteruptcomp(devicecod,operator1,dstartin,timestartinterupt,elat,
            //    timedelivertonet,ddelivertonet,dstartre,timestartrepair,ddelivertopro,timedelivertopro,activity,dendre,timeendrepair,operator2,i1,i2,i3,cause);

        }
        public void deleteinterupt(string cod)
        {
            PAYADATA.interuptcomp.interupt_comp tb = new PAYADATA.interuptcomp.interupt_comp();
            tb = db.interupt_comps.Where(x => x.x_id == Convert.ToInt32(cod)).Select(c => c).Single();
            db.interupt_comps.DeleteOnSubmit(tb);
            db.SubmitChanges();

        }

        public void deletservice(string cod, string type)
        {
            PAYADATA.interuptcomp.mserviceman_hour tb = new PAYADATA.interuptcomp.mserviceman_hour();
            tb = db.mserviceman_hours.Where(c => c.xid == Convert.ToInt32(cod) && c.xtype == type).Select(c => c).Single();
            db.mserviceman_hours.DeleteOnSubmit(tb);
            db.SubmitChanges();

        }
        public bool updateinteruptcomptable(PAYADATA.interuptcomp.dsinteruptcomp.interupt_compDataTable dt)
        {
            try
            {
                PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter p = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter();
                p.Update(dt);
                return true;
            }
            catch { return false; }

        }
        public IQueryable datasourcecheckbox()
        {
            return db.demuercauses;
        }
        public void deletalldemuerofinterupt(int id)
        {
            db.Deletealldemuerfointerupt(id, "comp");
        }
        public bool selectdemuerofinterupt(int id, int iddemuer)
        {

            if (db.mselectdemuers.Where(c => c.idparent == id && c.xiddemuer == iddemuer && c.typeparent == "comp").Count() > 0) return true; return false;

        }
        public void insertdemuerforinterupt(int id, int parentid)
        {
            PAYADATA.interuptcomp.mselectdemuer tb = new PAYADATA.interuptcomp.mselectdemuer();
            tb.idparent = parentid; tb.typeparent = "comp"; tb.xiddemuer = id;
            db.mselectdemuers.InsertOnSubmit(tb);
            db.SubmitChanges();
        }

        public IQueryable selecttrubleofrequestrenovation(int id)
        {
            // PAYADATA.interuptcomp.Data_interup_trubleDataContext dbb = new PAYADATA.interuptcomp.Data_interup_trubleDataContext();
            return dbb.mselectedtrubleshootings.Where(c => c.xidofparent == id && c.xtypeofparant == "comp").Join(dbb.ttruble_shootings, a => a.xidtruble, b => b.xid,
                (a, b) => new { a.xidtruble, b.xtruble });

        }

        public bool updateinteruptcomp(int? idoperator1, int? idoperator2, string datestartinterupt, string timestartinterupt, string elat, string datestartrepair, string timestartrepair, string activity, string dateendrepair,
            string timeendrepair, string datedelivertonet, string timedelivertonet, string datedelivertopro, string timedelivertopro,
            string timerepair, string timeinterupt, string timebetweenin_re, int id, bool mecanical)
        {

            int? i1, i2, i3;
            i1 = Convert.ToInt32(timerepair);
            i2 = Convert.ToInt32(timeinterupt);
            i3 = Convert.ToInt32(timebetweenin_re);
            db.Updateinteruptcomp(idoperator1, datestartinterupt, timestartinterupt, elat, timedelivertonet, datedelivertonet, datestartrepair, timestartrepair, datedelivertopro, timedelivertopro, activity, dateendrepair, timeendrepair, idoperator2, i1, i2, i3, id, mecanical);

            return true;

        }

        public IQueryable selectrenovationcomp(string username)
        {
            cslogin csl = new cslogin();
            int id = csl.returnid(username);
            return db.interupt_comps.Where(c => c.xiduserrequest == id && c.xdate_deliver_tonet == null).Select(c => new { c.x_id, c.xdevice_cod, c.xdate_request, c.xtime_request }).Join(db.devices, a => a.xdevice_cod, b => b.xcod, (a, b) => new { a.x_id, a.xdate_request, a.xtime_request, b.xiddevice, b.xnumber }).Join(db.mdetailsdevices,
             a => a.xiddevice, b => b.xcoddevice, (a, b) => new { a.x_id, a.xdate_request, a.xtime_request, b.xnamedevice, a.xnumber });

        }

        //**************************

        public IQueryable selecttrubleof_comp(string id)
        {
            return dbb.ttruble_shootings.Where(c => c.xid == Convert.ToInt32(id));//.Join(dbb.mselectedtrubleshootings, a => a.xid, b => b.xidtruble, (a, b) => new { });
        }

        public IQueryable selecttrubleof_compp(string id)
        {
            return dbb.mselectedtrubleshootings.Where(c => c.xidtruble == Convert.ToInt32(id));
        }




    }
}
