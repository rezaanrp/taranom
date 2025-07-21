using System.Data;
namespace PAYAIND.DetailDevice
{
    public  class csDetailDevice
    {
      public DataTable DetailDevice()
      {
          PAYADATA.DetailsDevice.DataSet_DetailDeviceTableAdapters.mdetailsdeviceTableAdapter adp
              = new PAYADATA.DetailsDevice.DataSet_DetailDeviceTableAdapters.mdetailsdeviceTableAdapter();
         return adp.GetData();
      }
    }
}
