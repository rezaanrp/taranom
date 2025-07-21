using System;

namespace BLL.Inventory
{
    public  class csSendProductTurning
  {
      #region SendProductTurning

      public DAL.inventory.DataSet_SendProductTurning.SlSendProductTurningDataTable SlSendProductTurning(string DateFrom, string DateTo)
        {
            DAL.inventory.DataSet_SendProductTurningTableAdapters.SlSendProductTurningTableAdapter adp
                = new DAL.inventory.DataSet_SendProductTurningTableAdapters.SlSendProductTurningTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }
      public string UdSendProductTurning(DAL.inventory.DataSet_SendProductTurning.SlSendProductTurningDataTable dt)
        {

          try
          {
              DAL.inventory.DataSet_SendProductTurningTableAdapters.SlSendProductTurningTableAdapter adp
                  = new DAL.inventory.DataSet_SendProductTurningTableAdapters.SlSendProductTurningTableAdapter();
               adp.Update(dt);
              return "عملیات ذخیره سازی با موفقیت انجام شد";
          }
          catch (Exception e)
          {

              return e.Message;
          }
        }

        #endregion
    }
}
