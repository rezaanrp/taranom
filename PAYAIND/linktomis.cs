using DAL;
using System.Data;
using System.Windows.Forms;

namespace PAYAIND
{
    public   class linktomis
    {BindingSource dt = new BindingSource();
            DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductAndDetialAllTableAdapter adp
                    = new DAL.inventory.DataSet_InventoryTableAdapters.SelectPiecesProductAndDetialAllTableAdapter();
            public bool connectiontomis()
            {
                DAL.csConnectionTest cc = new csConnectionTest();
               return cc.testConnection();

            }
        public DataTable returproductofday(string fdate)
            {
               
           return adp.GetData(fdate, fdate);
             
          
        }

        
    }
}
