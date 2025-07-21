using System;

namespace BLL.RequestObject
{
    public class csRequestObject
    {

        public DAL.RequestObject.DataSet_RequestObject.SlObjectUseListAndLocationDataTable SlObjectUseListAndLocation(string DateFrom,string DateTo)
        {
            DAL.RequestObject.DataSet_RequestObjectTableAdapters.SlObjectUseListAndLocationTableAdapter adp
                = new DAL.RequestObject.DataSet_RequestObjectTableAdapters.SlObjectUseListAndLocationTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.RequestObject.DataSet_RequestObject.SlObjectListAndLocationDataTable ObjectListAndLocation()
        {
            DAL.RequestObject.DataSet_RequestObjectTableAdapters.SlObjectListAndLocationTableAdapter adp
                = new DAL.RequestObject.DataSet_RequestObjectTableAdapters.SlObjectListAndLocationTableAdapter();
            return adp.GetData();
        }


        public DAL.RequestObject.DataSet_RequestObject.SlRequestObjectDataTable mRequestObject(string DateFrom, string DateTo)
        {
            DAL.RequestObject.DataSet_RequestObjectTableAdapters.SlRequestObjectTableAdapter adp
                = new DAL.RequestObject.DataSet_RequestObjectTableAdapters.SlRequestObjectTableAdapter();
            return adp.GetData(DateFrom, DateTo);

        }

        public string UdRequestObject(DAL.RequestObject.DataSet_RequestObject.SlRequestObjectDataTable dt)
        {
            try
            {
                DAL.RequestObject.DataSet_RequestObjectTableAdapters.SlRequestObjectTableAdapter adp
                    = new DAL.RequestObject.DataSet_RequestObjectTableAdapters.SlRequestObjectTableAdapter();
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
