using System.Linq;

namespace PAYAIND
{
    public   class csmttr
    {
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
      /// <summary>
      /// count of interuptcomp mecanical
      /// </summary>
      /// <param name="date"></param>
      /// <returns> count of interuptcomp mecanical</returns>
      public int calccountofmttrmecanical(string date,bool mecanical)
      {
          PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter();

          return db.GetData().Where(c => c.xdate_start_interupt.Contains(date) && c.xmecanical == mecanical).Count();
      }
      public int calccountofmttrmecanical(string fromdate, string todate, bool mecanical)
      {
          PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter();
          
          return db.GetData().Where(c => string.Compare(c.xdate_start_interupt, fromdate) >= 0 && string.Compare(todate, c.xdate_start_interupt) >= 0 && c.xmecanical == mecanical).Count();
     

      }
      public int calcsummttrmecanical(string date, bool mecanical)
      {
          PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter();
          return db.GetData().Where(c => c.xdate_start_interupt.StartsWith(date) && c.xmecanical == mecanical).Select(c => c.xtime_interupt).Sum();
    

      }
      public int calcsummttrmecanical(string fromdate, string todate, bool mecanical)
      {
          PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter db = new PAYADATA.interuptcomp.dsinteruptcompTableAdapters.interupt_compTableAdapter();

          return db.GetData().Where(c => string.Compare(c.xdate_start_interupt, fromdate) >= 0 && string.Compare(todate, c.xdate_start_interupt) >= 0 && c.xmecanical == mecanical).Select(c => c.xtime_interupt).Sum();    
      }
      ////////////////////////
      /////////////
      //
      public void insertmttrmecanical(string xdate, float count, float sum, float mttr)
      {
          PAYADATA.dsmttrTableAdapters.mttrmecanicalTableAdapter db = new PAYADATA.dsmttrTableAdapters.mttrmecanicalTableAdapter();
          db.DeleteQuery(xdate);
          db.InsertQuery(sum, count, mttr, xdate);
      }
      public void insertelectrical(string date, float count, float sum, float mttr)
      {
          PAYADATA.dsmttrTableAdapters.mttrelectricTableAdapter db = new PAYADATA.dsmttrTableAdapters.mttrelectricTableAdapter();
          db.DeleteQuery(date);
          db.InsertQuery(date, sum, count, mttr);
      }



    }

}
