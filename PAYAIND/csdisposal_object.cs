using System;

namespace PAYAIND
{
    public  class csdisposal_object
    {
        PAYADATA.disposal_object.DataClasses1DataContext db = new PAYADATA.disposal_object.DataClasses1DataContext();
        public PAYADATA.disposal_object.dsdisposl_object.viewdisposal_objectDataTable fill_objectbycod(int xid, string type)
        {
            PAYADATA.disposal_object.dsdisposl_objectTableAdapters.viewdisposal_objectTableAdapter db = new PAYADATA.disposal_object.dsdisposl_objectTableAdapters.viewdisposal_objectTableAdapter();
            return db.GetDataBy(xid, type);
        }
        public PAYADATA.disposal_object.dsdisposl_object.viewdisposal_objectDataTable fill_alldisposalobject()
        {
            PAYADATA.disposal_object.dsdisposl_objectTableAdapters.viewdisposal_objectTableAdapter db = new PAYADATA.disposal_object.dsdisposl_objectTableAdapters.viewdisposal_objectTableAdapter();
            return db.GetData();

        }

        public void delet_object_disposal(int xid)
        {
            PAYADATA.disposal_object.dsdisposl_objectTableAdapters.mobject_disposalTableAdapter db = new PAYADATA.disposal_object.dsdisposl_objectTableAdapters.mobject_disposalTableAdapter();
            db.DeleteBy(xid);
        }

        public void insertobjectmasrafi(string id, string name, string count, string type)
        {
            PAYADATA.disposal_object.mobject_disposal table = new PAYADATA.disposal_object.mobject_disposal();
            table.xid_interupt = Convert.ToInt32(id);
            table.xcount = Convert.ToInt32(count);
            table.x_cod_objects_disposal = (name);
            table.xtype = type;
            db.mobject_disposals.InsertOnSubmit(table);
            db.SubmitChanges();
        }

    }
}
