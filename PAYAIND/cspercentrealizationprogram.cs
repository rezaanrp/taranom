using System;
using System.Linq;
using System.Windows.Forms;

namespace PAYAIND
{
    public  class cspercentrealizationprogram
   {
       public PAYADATA.indicator.DataSetpercentrealizationprogram.SelectpercentrealizationprogrambydateDataTable selectbydate(string fromdate, string dateto)
       {
           PAYADATA.indicator.DataSetpercentrealizationprogramTableAdapters.SelectpercentrealizationprogrambydateTableAdapter db = new PAYADATA.indicator.DataSetpercentrealizationprogramTableAdapters.SelectpercentrealizationprogrambydateTableAdapter();
           return db.GetDataBydate(fromdate, dateto);
       }
       public void updatetable(PAYADATA.indicator.DataSetpercentrealizationprogram.SelectpercentrealizationprogrambydateDataTable dt)
       {        
           PAYADATA.indicator.DataSetpercentrealizationprogramTableAdapters.SelectpercentrealizationprogrambydateTableAdapter db = new PAYADATA.indicator.DataSetpercentrealizationprogramTableAdapters.SelectpercentrealizationprogrambydateTableAdapter();
           db.Update(dt);
       }
       public void calcutepercent(string date)
       {
           PAYADATA.indicator.DatalinqpercentrealizationprogramDataContext db = new PAYADATA.indicator.DatalinqpercentrealizationprogramDataContext();
           float numberofprogram;
           float numberofprogramdown;
           numberofprogram = db.mserviceprograms.Where(c => c.xdate.StartsWith(date)).Count();
           numberofprogramdown = db.mserviceprograms.Where(c => c.xdate.StartsWith(date)&& c.xresult==1).Count();
           double percent =Math.Round(( numberofprogramdown / numberofprogram),2)*100;
           MessageBox.Show(percent.ToString());
           if (db.mpercent_realization_programs.Where(c => c.xdate == date).Count() > 0)
           {
               PAYADATA.indicator.mpercent_realization_program tb = db.mpercent_realization_programs.Where(c => c.xdate == date).Single();
               tb.xdate = date;
               tb.xnumberofprogramservice =Convert.ToInt32( numberofprogram);
               tb.xnumberofprogramservicedone =Convert.ToInt32( numberofprogramdown);
               tb.xpercent =( percent);
               db.SubmitChanges();           
           }
           else
           {
               PAYADATA.indicator.mpercent_realization_program tb = new PAYADATA.indicator.mpercent_realization_program();
               tb.xdate = date; tb.xnumberofprogramservice =Convert.ToInt32( numberofprogram);
               tb.xnumberofprogramservicedone =Convert.ToInt32( numberofprogramdown);
               tb.xpercent = percent;
               db.mpercent_realization_programs.InsertOnSubmit(tb);
               db.SubmitChanges();
           }
       }
    }
}
