using System;

namespace BLL.DeliveryWareHouse
{
    public  class csDeliveryWareHouse
    {

      public DAL.DeliveryWareHose.DataSet_DeliveryWareHouse.SlDeliveryWareHouseDataTable SlDeliveryWareHouse(string DateFrom, string DateTo, int xGenFactory_)
        {
            DAL.DeliveryWareHose.DataSet_DeliveryWareHouseTableAdapters.SlDeliveryWareHouseTableAdapter adp =
                new DAL.DeliveryWareHose.DataSet_DeliveryWareHouseTableAdapters.SlDeliveryWareHouseTableAdapter();
            return adp.GetData(DateFrom, DateTo,xGenFactory_);
        }
      public string UdDeliveryWareHouse(DAL.DeliveryWareHose.DataSet_DeliveryWareHouse.SlDeliveryWareHouseDataTable dt)
        {
            try
            {
                DAL.DeliveryWareHose.DataSet_DeliveryWareHouseTableAdapters.SlDeliveryWareHouseTableAdapter adp =
                    new DAL.DeliveryWareHose.DataSet_DeliveryWareHouseTableAdapters.SlDeliveryWareHouseTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
    }
}
