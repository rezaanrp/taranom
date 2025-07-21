using System;

namespace BLL.AccidentsMinor
{
    public class Accidents
    {
        public DAL.AccidentsMinor.DataSet_AccidentsMinor.SlFireExtinguisherEXPDataTable SlFireExtingusherEXP()
        {
            DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.SlFireExtinguisherEXPTableAdapter adp
                 = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.SlFireExtinguisherEXPTableAdapter();
            return adp.GetData();
        }
        public DAL.AccidentsMinor.DataSet_AccidentsMinor.mFireExtingusherDetialsDataTable mFireExtingusherDetials(int x_)
        {
            DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mFireExtingusherDetialsTableAdapter adp
                 = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mFireExtingusherDetialsTableAdapter();
            return adp.GetData(x_);
        }
        public string UdFireExtingusherDetials(DAL.AccidentsMinor.DataSet_AccidentsMinor.mFireExtingusherDetialsDataTable dt)
        {
            try
            {
                DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mFireExtingusherDetialsTableAdapter adp
                     = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mFireExtingusherDetialsTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.AccidentsMinor.DataSet_AccidentsMinor.mFireExtinguisherDataTable mFireExtinguisher()
        {
            DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mFireExtinguisherTableAdapter adp
                 = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mFireExtinguisherTableAdapter();
            return adp.GetData();
        }
        public string UdFireExtinguisher(DAL.AccidentsMinor.DataSet_AccidentsMinor.mFireExtinguisherDataTable dt)
        {
            try
            {
                DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mFireExtinguisherTableAdapter adp
                     = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mFireExtinguisherTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public DAL.AccidentsMinor.DataSet_AccidentsMinor.mAccidentsMinorDataTable AccidentsMinor()
        {
            DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsMinorTableAdapter adp
                 = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsMinorTableAdapter();
            return adp.GetData();
        }
        public string UdAccidentsMinor(DAL.AccidentsMinor.DataSet_AccidentsMinor.mAccidentsMinorDataTable dt)
        {
            try
            {
                DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsMinorTableAdapter adp
                     = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsMinorTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public DAL.AccidentsMinor.DataSet_AccidentsMinor.mAccidentsExtremeDataTable AccidentsExtreme()
        {
            DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsExtremeTableAdapter adp
                 = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsExtremeTableAdapter();
            return adp.GetData();
        }
        public string UdAccidentsExtreme(DAL.AccidentsMinor.DataSet_AccidentsMinor.mAccidentsExtremeDataTable dt)
        {
            try
            {
                DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsExtremeTableAdapter adp
                     = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsExtremeTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public DAL.AccidentsMinor.DataSet_AccidentsMinor.mAccidentsSemiDataTable AccidentsSemi()
        {
            DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsSemiTableAdapter adp
                 = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsSemiTableAdapter();
            return adp.GetData();
        }
        public string UdAccidentsSemi(DAL.AccidentsMinor.DataSet_AccidentsMinor.mAccidentsSemiDataTable dt)
        {
            try
            {
                DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsSemiTableAdapter adp
                     = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mAccidentsSemiTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public DAL.AccidentsMinor.DataSet_AccidentsMinor.mInspectionWorkDataTable mInspectionWork()
        {
            DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mInspectionWorkTableAdapter adp
                 = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mInspectionWorkTableAdapter();
            return adp.GetData();
        }
        public string UdInspectionWork(DAL.AccidentsMinor.DataSet_AccidentsMinor.mInspectionWorkDataTable dt)
        {
            try
            {
                DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mInspectionWorkTableAdapter adp
                     = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mInspectionWorkTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";

            }
            catch (Exception e)
            {
                return e.Message;
            }

        }


        public DAL.AccidentsMinor.DataSet_AccidentsMinor.mSafetyNotesDataTable mSafetyNotes()
        {
            DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mSafetyNotesTableAdapter adp
                 = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mSafetyNotesTableAdapter();
            return adp.GetData();
        }
        public string UdSafetyNotes(DAL.AccidentsMinor.DataSet_AccidentsMinor.mSafetyNotesDataTable dt)
        {
            try
            {
                DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mSafetyNotesTableAdapter adp
                     = new DAL.AccidentsMinor.DataSet_AccidentsMinorTableAdapters.mSafetyNotesTableAdapter();
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
