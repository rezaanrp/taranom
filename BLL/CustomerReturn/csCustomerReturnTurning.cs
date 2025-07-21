using System;

namespace BLL.CustomerReturn
{
    public class csCustomerReturnTurning
    {
       public DAL.CustomerReturn.DataSet_CustomerReturnTurning.mCustomerReturnTurningDataTable CustomerReturnTurning(string DateFrom, string DateTo)
        {
            DAL.CustomerReturn.DataSet_CustomerReturnTurningTableAdapters.mCustomerReturnTurningTableAdapter adp =
                 new DAL.CustomerReturn.DataSet_CustomerReturnTurningTableAdapters.mCustomerReturnTurningTableAdapter();
            return adp.GetData( DateFrom, DateTo);
        }

       public string UdCustomerReturnTurning(DAL.CustomerReturn.DataSet_CustomerReturnTurning.mCustomerReturnTurningDataTable dt)
        {
            try
            {
                DAL.CustomerReturn.DataSet_CustomerReturnTurningTableAdapters.mCustomerReturnTurningTableAdapter adp =
                     new DAL.CustomerReturn.DataSet_CustomerReturnTurningTableAdapters.mCustomerReturnTurningTableAdapter();
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
