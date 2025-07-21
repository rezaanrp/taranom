using System;
using System.Data;

namespace BLL.Person
{
    public class csPersonInfo
    {

        /// <summary>
/// کد یوزر می گیرد و نام و فامیل و شماره پرسنلی می دهد
/// </summary>
/// <param name="x_"></param>
/// <returns></returns>
        public DAL.Person.DataSet_PersonInfo.mPersonInfoByUserx_DataTable mPersonInfoByUserx_(int x_)
        {
            DAL.Person.DataSet_PersonInfoTableAdapters.mPersonInfoByUserx_TableAdapter adp =
                new DAL.Person.DataSet_PersonInfoTableAdapters.mPersonInfoByUserx_TableAdapter();
            return adp.GetData(x_);
        }
/// <summary>
/// شماره پرسنلی می گیرد نام قسمت را خروجی می دهد
/// </summary>
/// <param name="PerID"></param>
/// <returns></returns>
        public DAL.Person.DataSet_PersonInfo.SlPersonGetPerIdDataTable SlPersonGetPerId(string PerID)
        {
            DAL.Person.DataSet_PersonInfoTableAdapters.SlPersonGetPerIdTableAdapter adp =
                new DAL.Person.DataSet_PersonInfoTableAdapters.SlPersonGetPerIdTableAdapter();
            return adp.GetData(PerID);
        }

        public int? mPersonInfoGetX_ById(string xPerID)
        {
            DAL.Person.DataSet_PersonInfoTableAdapters.mPersonInfoGetX_ByIdTableAdapter adp =
                new DAL.Person.DataSet_PersonInfoTableAdapters.mPersonInfoGetX_ByIdTableAdapter();

            DAL.Person.DataSet_PersonInfo.mPersonInfoGetX_ByIdDataTable dt = adp.GetData(xPerID);
            if (dt.Rows.Count > 0)
            {

                return (int?)dt[0][0];
            }
            else
                return -1;
        }
        /// <summary>
        /// شماره کاربری می گیری خروجی بر اساس قسمت نمایش می دهد
        /// </summary>
        /// <returns></returns>
        /// 


        public DataTable mPersonInfoSec(int x_)
        {
            DAL.Person.DataSet_PersonInfoTableAdapters.SlPersonInfoSecTableAdapter adp =
                new DAL.Person.DataSet_PersonInfoTableAdapters.SlPersonInfoSecTableAdapter();
            return adp.GetData(x_);
        }
        public DataTable mPersonInfoBySec(int? xSec_)
        {
            DAL.Person.DataSet_PersonInfoTableAdapters.mPersonInfoBySecTableAdapter adp =
                new DAL.Person.DataSet_PersonInfoTableAdapters.mPersonInfoBySecTableAdapter();
            return adp.GetData(xSec_);
        }
        public DataTable mPersonName()
        {
            DAL.Person.DataSet_PersonInfoTableAdapters.mPersonNameTableAdapter adp =
                new DAL.Person.DataSet_PersonInfoTableAdapters.mPersonNameTableAdapter();
            return adp.GetData();
        }
        public DAL.Person.DataSet_PersonInfo.SlPersonInfoDataTable SlPersonInfo(string xName, string xFamily)
        {
            DAL.Person.DataSet_PersonInfoTableAdapters.SlPersonInfoTableAdapter adp =
                new DAL.Person.DataSet_PersonInfoTableAdapters.SlPersonInfoTableAdapter();
            return adp.GetData(xName, xFamily);
        }

        public string UdPersonInfo(DAL.Person.DataSet_PersonInfo.SlPersonInfoDataTable dt)
        {
            try
            {
                DAL.Person.DataSet_PersonInfoTableAdapters.SlPersonInfoTableAdapter adp =
                    new DAL.Person.DataSet_PersonInfoTableAdapters.SlPersonInfoTableAdapter();
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
