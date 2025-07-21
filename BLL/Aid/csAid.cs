using System;

namespace BLL.Aid
{
    public class csAid
    {
        public DAL.Aid.DataSet_Aid.SlSectionAidDeliveryUsePerDayDataTable SlSectionAidDeliveryUsePerDay(string DateFrom, string DateTo)
        {
            DAL.Aid.DataSet_AidTableAdapters.SlSectionAidDeliveryUsePerDayTableAdapter adp =
                 new DAL.Aid.DataSet_AidTableAdapters.SlSectionAidDeliveryUsePerDayTableAdapter();
            return adp.GetData(DateFrom, DateTo);
        }

        public DAL.Aid.DataSet_Aid.SlSectionAidUseForSecDataTable SlSectionAidUseForSec()
       {
           DAL.Aid.DataSet_AidTableAdapters.SlSectionAidUseForSecTableAdapter adp =
               new DAL.Aid.DataSet_AidTableAdapters.SlSectionAidUseForSecTableAdapter();
           return adp.GetData();
       }
       public DAL.Section.DataSet_Section.SlSectionAidListAidForPerDataTable SlSectionAidListAidForPer()
       {
           DAL.Section.DataSet_SectionTableAdapters.SlSectionAidListAidForPerTableAdapter adp =
               new DAL.Section.DataSet_SectionTableAdapters.SlSectionAidListAidForPerTableAdapter();
           return adp.GetData();
       }

       public DAL.Aid.DataSet_Aid.SlSectionAidDelivryToPerCntDataTable SlSectionAidDelivryToPerCnt(string DateFrom, string DateTo)
       {
           DAL.Aid.DataSet_AidTableAdapters.SlSectionAidDelivryToPerCntTableAdapter adp =
                new DAL.Aid.DataSet_AidTableAdapters.SlSectionAidDelivryToPerCntTableAdapter();
           return adp.GetData(DateFrom, DateTo);
       }
       public DAL.Aid.DataSet_Aid.SlSectionAidSearchDataTable SlSectionAidSearch(int Person_)
       {
           DAL.Aid.DataSet_AidTableAdapters.SlSectionAidSearchTableAdapter adp =
                new DAL.Aid.DataSet_AidTableAdapters.SlSectionAidSearchTableAdapter();
           return adp.GetData(Person_);
       }
       

       public DAL.Aid.DataSet_SectionAidPerdicUsage.SlSectionAidPerdicUsageDataTable SlSectionAidPerdicUsage(string WorkYear)
       {
           DAL.Aid.DataSet_SectionAidPerdicUsageTableAdapters.SlSectionAidPerdicUsageTableAdapter adp =
                new DAL.Aid.DataSet_SectionAidPerdicUsageTableAdapters.SlSectionAidPerdicUsageTableAdapter();
           return adp.GetData(WorkYear);
       }
       

       public DAL.Aid.DataSet_Aid.SlSectionAidDeliveryDataTable SlSectionAidDelivery(string DateFrom, string DateTo, int User_)
       {
           DAL.Aid.DataSet_AidTableAdapters.SlSectionAidDeliveryTableAdapter adp =
                new DAL.Aid.DataSet_AidTableAdapters.SlSectionAidDeliveryTableAdapter();
           return adp.GetData(DateFrom, DateTo, User_);
       }
       
       public DAL.Aid.DataSet_Aid.mSectionAidDataTable SectionAid()
        {
            DAL.Aid.DataSet_AidTableAdapters.mSectionAidTableAdapter adp =
                 new DAL.Aid.DataSet_AidTableAdapters.mSectionAidTableAdapter();
            return adp.GetData();
        }
       public DAL.Aid.DataSet_Aid.SlSectionAidMaterialAllowListDataTable SlSectionAidMaterialAllowList(int Person_)
        {
            DAL.Aid.DataSet_AidTableAdapters.SlSectionAidMaterialAllowListTableAdapter adp =
                 new DAL.Aid.DataSet_AidTableAdapters.SlSectionAidMaterialAllowListTableAdapter();
            return adp.GetData(Person_);
        }

       public string UdSectionAid(DAL.Aid.DataSet_Aid.mSectionAidDataTable dt)
        {
            try
            {
                DAL.Aid.DataSet_AidTableAdapters.mSectionAidTableAdapter adp =
                     new DAL.Aid.DataSet_AidTableAdapters.mSectionAidTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

       public DAL.Aid.DataSet_Aid.mSectionAidMaterialDataTable SectionAidMaterial(int? x_)
       {
           DAL.Aid.DataSet_AidTableAdapters.mSectionAidMaterialTableAdapter adp =
                new DAL.Aid.DataSet_AidTableAdapters.mSectionAidMaterialTableAdapter();
           return adp.GetData(x_);
       }

       public string UdSectionAidMaterial(DAL.Aid.DataSet_Aid.mSectionAidMaterialDataTable dt)
       {
           try
           {
               DAL.Aid.DataSet_AidTableAdapters.mSectionAidMaterialTableAdapter adp =
                    new DAL.Aid.DataSet_AidTableAdapters.mSectionAidMaterialTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {
               return e.Message;
           }
       }

       public DAL.Aid.DataSet_Aid.mSectionAidPersonDataTable SectionAidPerson(int? x_)
       {
           DAL.Aid.DataSet_AidTableAdapters.mSectionAidPersonTableAdapter adp =
                new DAL.Aid.DataSet_AidTableAdapters.mSectionAidPersonTableAdapter();
           return adp.GetData(x_);
       }

       public string UdSectionAidPerson(DAL.Aid.DataSet_Aid.mSectionAidPersonDataTable dt)
       {
           try
           {
               DAL.Aid.DataSet_AidTableAdapters.mSectionAidPersonTableAdapter adp =
                    new DAL.Aid.DataSet_AidTableAdapters.mSectionAidPersonTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {
               return e.Message;
           }
       }

       public DAL.Aid.DataSet_Aid.mSectionAidDeliveryDataTable mSectionAidDelivery(string DateFrom, string DateTo, int? xPerson_)
       {
           DAL.Aid.DataSet_AidTableAdapters.mSectionAidDeliveryTableAdapter adp =
                new DAL.Aid.DataSet_AidTableAdapters.mSectionAidDeliveryTableAdapter();
           return adp.GetData(DateFrom,DateTo,xPerson_);
       }

       public string UdSectionAidDelivery(DAL.Aid.DataSet_Aid.mSectionAidDeliveryDataTable dt)
       {
           try
           {
               DAL.Aid.DataSet_AidTableAdapters.mSectionAidDeliveryTableAdapter adp =
                    new DAL.Aid.DataSet_AidTableAdapters.mSectionAidDeliveryTableAdapter();
               adp.Update(dt);
               return "عملیات ذخیره سازی با موفقیت انجام شد";
           }
           catch (Exception e)
           {
               return e.Message;
           }
       }

       public DAL.Aid.DataSet_Aid.SlSectionAidNeedDataTable SlSectionAidNeed(int? xPerson_)
       {
           DAL.Aid.DataSet_AidTableAdapters.SlSectionAidNeedTableAdapter adp =
                new DAL.Aid.DataSet_AidTableAdapters.SlSectionAidNeedTableAdapter();
           return adp.GetData(xPerson_);
       }


       
    }
}
