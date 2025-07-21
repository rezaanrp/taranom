using System.Linq;

namespace PAYAIND
{
    public class csmtbf
    {

       
        PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter();

        public PAYADATA.dsmttr.mttrelectricDataTable selectmttrelectrical(string fromdate, string todate)
        {
            PAYADATA.dsmttrTableAdapters.mttrelectricTableAdapter db = new PAYADATA.dsmttrTableAdapters.mttrelectricTableAdapter();
            return db.GetDataBydate(fromdate, todate);
        }
        public PAYADATA.dsmttr.mttrmecanicalDataTable selectmecanical(string fromdate, string todate)
        {
            PAYADATA.dsmttrTableAdapters.mttrmecanicalTableAdapter db = new PAYADATA.dsmttrTableAdapters.mttrmecanicalTableAdapter();
            return db.GetDataBydate(fromdate, todate);
        }

      
        public IQueryable selectinterupbycoddevice(string xdevice_cod)// توقفات اضطراری با کد دستگاه 
        {
            PAYADATA.interuptcomp.data_interupt_compDataContext db = new PAYADATA.interuptcomp.data_interupt_compDataContext();
            return db.interupt_comps.Where(c => c.xdevice_cod == xdevice_cod );
        }

        // انتخاب توقف با شماره دستگاه 
        public int calccountmtbf(string xdevice_cod, string xidtruble, string fdate, string ldate, string type, string troubling)
        {
            PAYADATA.interuptcomp.dsinteruptcompTableAdapters.select_interupttrublingTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.select_interupttrublingTableAdapter();
            return db.GetData(xdevice_cod, xidtruble,fdate, ldate,type,  troubling).Count(); 
        }

        public int calsumtmtbf(string xdevice_cod, string xidtruble, string fdate, string ldate, string type, string troubling)
        {
            PAYADATA.interuptcomp.dsinteruptcompTableAdapters.select_interupttrublingTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.select_interupttrublingTableAdapter();
            return db.GetData(xdevice_cod, xidtruble, fdate, ldate, type,troubling).Sum(c=>c.xtime_interupt);
        }

        public PAYADATA.interuptcomp.dsinteruptcomp.select_interupttrublingDataTable Interupt_mselectedtrubleshooting(string xdevice_cod, string xidtruble, string fromdate, string todate, string type, string troubling)
        {
   
            PAYADATA.interuptcomp.dsinteruptcompTableAdapters.select_interupttrublingTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.select_interupttrublingTableAdapter();
            return db.GetData(xdevice_cod, xidtruble,fromdate,todate, type,troubling);
   
        }

        public double calcinteruptcomptime(string xdevice_cod, string xidtruble, string fromdate, string todate, string type, string troubling)
        {
            double interuptcomp;

            PAYADATA.interuptcomp.dsinteruptcompTableAdapters.select_interupttrublingTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.select_interupttrublingTableAdapter();

            try
            {
        
            interuptcomp = double.Parse(db.GetData(xdevice_cod, xidtruble,fromdate, todate, type,troubling).Select(c => c.xtime_interupt).Sum().ToString());
            
            }
            catch { interuptcomp = 0; }
            return interuptcomp;
        }


        public PAYADATA.interuptcomp.dsinteruptcomp.Interupt_ComparedeviceDataTable Interupt_Comparedevice(string xdevice_cod, string xidtruble, string fromdate, string todate, string type)
        {

            PAYADATA.interuptcomp.dsinteruptcompTableAdapters.Interupt_ComparedeviceTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.Interupt_ComparedeviceTableAdapter();
            return db.GetData(xdevice_cod, xidtruble, fromdate, todate,type);

        }



        public PAYADATA.interuptcomp.dsinteruptcomp.SELLECT_ALLDEVICE_ALLTRUBLEDataTable SELLECT_ALLDEVICE_ALLTRUBLE(string fromdate, string todate, string type,int availhours)
        {

            PAYADATA.interuptcomp.dsinteruptcompTableAdapters.SELLECT_ALLDEVICE_ALLTRUBLETableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.SELLECT_ALLDEVICE_ALLTRUBLETableAdapter();
            return db.GetData( fromdate, todate, type,availhours);
        
        }


    }

}
