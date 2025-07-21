using System.Linq;
using System.Data;

namespace PAYAIND
{
    public class fill_datagride
    {
        private IQueryable query;
        private PAYADATA.coding.Data_linq_coding_objectDataContext db = new PAYADATA.coding.Data_linq_coding_objectDataContext();
       
        public IQueryable allobject( string cod, string nameobjects)
        {
     
       query = db.Viewallobjects.Where(c => c.xcod.Contains(cod) && c.xname.Contains(nameobjects));
            //    query =db.mdetailsdevices.Join(db.devices,a=>a.xcoddevice,b=> b.xiddevice,
            //        (a,b)=>new {a.xnamedevice,b.xiddevice,b.xnumber,} ).Join(db.mdeviceset1s, a => a.xiddevice, b => b.xiddevice,
            //          (c, d) => new { c.xiddevice, c.xnamedevice, c.xnumber, d.xnameset1, idset1 = d.xid }).Join(db.mdeviceset2s, a => a.xiddevice, b => b.xcoddevice,
            //           (a, b) => new { a.xiddevice, a.xnamedevice, a.xnumber, a.xnameset1, a.idset1, b.xcodset2, b.xnameset2 }).Join(db.mdeviceset3s, a => a.xiddevice, b => b.xcoddevice
            //           , (a, b) => new { a.xiddevice, a.xnamedevice, a.xnumber, a.xnameset1, a.idset1, a.xcodset2, a.xnameset2, b.xcodset3, b.xnameset3, idfinal = a.xiddevice + "-" + a.xnumber + "-" + a.idset1 + "-" + a.xcodset2 + "-" + b.xcodset3 }).Join(db.mallobjects, a => a.idfinal, b => b.xcodparent.Substring(3),
            // (a, b) => new { a.xiddevice, a.xnamedevice, a.xnumber, a.xnameset1, a.idset1, a.xcodset2, a.xnameset2, a.xcodset3, a.xnameset3, a.idfinal, idobject = b.xid, b.oloaviyat, b.count, b.xcod }).Where(c => c.oloaviyat == "بالا" && c.xcod.Contains(cod)).Join(db.objecttables, a => a.idobject, b => b.xid,
            //(a, b) => new { a.xcod, b.xname, b.xdetails, a.count, a.xnamedevice, a.xnumber, a.xnameset1, a.xnameset2, a.xnameset3, a.oloaviyat }).Where(c => c.xname.Contains(nameobjects)).Select(c => c);
               
               return query;
           
        }
//*********************
        public DataTable  allobjects(string cod, string nameobjects)
        {
            PAYADATA.coding.dsallobjectTableAdapters.ViewallobjectTableAdapter db = new PAYADATA.coding.dsallobjectTableAdapters.ViewallobjectTableAdapter();
            return db.GetDataBy(cod);
        }

        //***************************
        public DataTable fillallsetforview()
        {
            PAYADATA.coding.DataSetcodingTableAdapters.ViewallsetofalldeviceTableAdapter dbb = new PAYADATA.coding.DataSetcodingTableAdapters.ViewallsetofalldeviceTableAdapter();
           return  dbb.GetData();
        }
        public DataTable fillallsetforviewbyfilter(string filter)
        {
            PAYADATA.coding.DataSetcodingTableAdapters.ViewallsetofalldeviceTableAdapter dbb = new PAYADATA.coding.DataSetcodingTableAdapters.ViewallsetofalldeviceTableAdapter();
            return dbb.GetDataByfilter(filter);
        }
        
        public DataTable allobject1(bool iskey, string cod, string nameobjects)
        {
    
            PAYADATA.coding.dsallobjectTableAdapters.ViewallobjectTableAdapter db = new PAYADATA.coding.dsallobjectTableAdapters.ViewallobjectTableAdapter();
           return db.GetData();
        }
        
        public IQueryable fillobject()
        {
            query = db.objecttables.Select(c => c).OrderBy(c => c.xname);
            return query;
        }
        public IQueryable fillobject(string name)
        {
            query = db.objecttables.Select(c => c).Where(c=> c.xname.Contains(name)).OrderBy(c=> c.xname);
            return query;
        }
        public IQueryable filldataset1(string cod_of_device)
        {
            query = db.mdeviceset1s.Where(c => c.xiddevice.StartsWith(cod_of_device)).Select(c => c);
            return query;
        }
        public IQueryable filldataset2(string codset1)
        {
            query = db.mdeviceset2s.Where(c => c.xparentid.StartsWith(codset1)).Select(c => c);
            return query;
        }
        public PAYADATA.coding.DataSetcoding.deviceDataTable fill_datagrid_device()
        {
            PAYADATA.coding.DataSetcodingTableAdapters.deviceTableAdapter dbb = new PAYADATA.coding.DataSetcodingTableAdapters.deviceTableAdapter();
           return dbb.GetDataBy2();
        }
        public PAYADATA.coding.DataSetcoding.mdetailsdeviceDataTable selectdetailsdevice()
        {
            PAYADATA.coding.DataSetcodingTableAdapters.mdetailsdeviceTableAdapter db = new PAYADATA.coding.DataSetcodingTableAdapters.mdetailsdeviceTableAdapter();
           return db.GetDataBy();
        }



        public PAYADATA.coding.DataSetcoding.devicenameDataTable fill_datagrid_device_name()
        {
            PAYADATA.coding.DataSetcodingTableAdapters.devicenameTableAdapter dbb = new PAYADATA.coding.DataSetcodingTableAdapters.devicenameTableAdapter();
            return dbb.GetData();
        }

        //****************************
        public IQueryable device_name_set1(string codset1)
        {
            query = db.mdeviceset1s.Where(c=> c.xcod==codset1).Select(c => new {c.xcod, c.xnameset1}).Distinct().OrderBy(c=> c.xcod);
            return query;
        }
        //****************************


        public DataTable selectallobjects()
        {
            PAYADATA.coding.dsallobjectTableAdapters.objecttableTableAdapter db = new PAYADATA.coding.dsallobjectTableAdapters.objecttableTableAdapter();
            return db.GetData();
        }
      
    }
}
