using System;

namespace BLL.Tools
{
    public class csTools
    {
        public DAL.Tools.DataSet_Tools.SlToolsPersonDataTable SlToolsPerson(int Person_)
        {
            DAL.Tools.DataSet_ToolsTableAdapters.SlToolsPersonTableAdapter adp
                 = new DAL.Tools.DataSet_ToolsTableAdapters.SlToolsPersonTableAdapter();
            return adp.GetData(Person_);
        }
        public DAL.Tools.DataSet_Tools.SlToolsUnknownDataTable SlToolsUnknown(string DateFrom, string DateTo)
        {
            DAL.Tools.DataSet_ToolsTableAdapters.SlToolsUnknownTableAdapter adp
                 = new DAL.Tools.DataSet_ToolsTableAdapters.SlToolsUnknownTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.Tools.DataSet_Tools.ToolsRetiringDataTable SlToolsRetiring(string DateFrom, string DateTo)
        {
            DAL.Tools.DataSet_ToolsTableAdapters.ToolsRetiringTableAdapter adp
                 = new DAL.Tools.DataSet_ToolsTableAdapters.ToolsRetiringTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.Tools.DataSet_Tools.SlToolsDeliveryDataTable SlToolsDelivery(int Person_)
        {
            DAL.Tools.DataSet_ToolsTableAdapters.SlToolsDeliveryTableAdapter adp
                 = new DAL.Tools.DataSet_ToolsTableAdapters.SlToolsDeliveryTableAdapter();
            return adp.GetData( Person_);
        }
        public DAL.Tools.DataSet_Tools.SlToolsReturnDataTable ToolsReturn(int xDeliveryTools_, int GenGroup)
        {
            DAL.Tools.DataSet_ToolsTableAdapters.SlToolsReturnTableAdapter adp
                 = new DAL.Tools.DataSet_ToolsTableAdapters.SlToolsReturnTableAdapter();
            return adp.GetData(xDeliveryTools_, GenGroup);
        }
        public string UdToolsReturn(DAL.Tools.DataSet_Tools.SlToolsReturnDataTable dt)
        {
            try
            {
                DAL.Tools.DataSet_ToolsTableAdapters.SlToolsReturnTableAdapter adp
                     = new DAL.Tools.DataSet_ToolsTableAdapters.SlToolsReturnTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

        public DAL.Tools.DataSet_Tools.SlToolsDeliveryODataTable ToolsDelivery(int Person_)
        {
            DAL.Tools.DataSet_ToolsTableAdapters.SlToolsDeliveryOTableAdapter adp
                 = new DAL.Tools.DataSet_ToolsTableAdapters.SlToolsDeliveryOTableAdapter();
            return adp.GetData( Person_);
        }
        public string UdToolsDelivery(DAL.Tools.DataSet_Tools.SlToolsDeliveryODataTable dt)
        {
            try
            {
                DAL.Tools.DataSet_ToolsTableAdapters.SlToolsDeliveryOTableAdapter adp
                     = new DAL.Tools.DataSet_ToolsTableAdapters.SlToolsDeliveryOTableAdapter();
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
