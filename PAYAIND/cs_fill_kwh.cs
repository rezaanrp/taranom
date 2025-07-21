using System.Linq;
using System.Data;
using System.Windows.Forms;


namespace PAYAIND
{
    public  class cs_fill_kwh
    {
       // IQueryable query;
        datalinq.kwhlinqDataContext db = new datalinq.kwhlinqDataContext();

        public BindingSource fillmasraf_zob(string first_date,string last_date)
        {
            BindingSource s = new BindingSource();
            s.DataSource = db.masraf_zobs.Select(ra => ra);
            return s;
        }

        public BindingSource fillmasraf_day(string first_date, string last_date)
        {
            BindingSource s = new BindingSource();
            s.DataSource= db.masraf_days.Select(ra => ra);
            s.Filter = "date >= '" + first_date + "' and  date <='" + last_date + "'";
            return s;

        }
    }
}
