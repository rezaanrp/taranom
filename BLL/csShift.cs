using System;
using System.Data;
namespace BLL
{
    public class csShift
    {
        public DataTable mShiftDataTable()
        {
            DAL.DataSet_ShiftTableAdapters.SelectmShiftAndNameUserTableAdapter adp = 
                new DAL.DataSet_ShiftTableAdapters.SelectmShiftAndNameUserTableAdapter();
     
            return adp.GetData(); 
        }

        public DAL.DataSet_Shift.mShiftDataTable mShift()
        {
            DAL.DataSet_ShiftTableAdapters.mShiftTableAdapter adp
                = new DAL.DataSet_ShiftTableAdapters.mShiftTableAdapter();
            return adp.GetData();

        }

        public string UdShift(DAL.DataSet_Shift.mShiftDataTable dt)
        {
            try
            {
                DAL.DataSet_ShiftTableAdapters.mShiftTableAdapter adp
                    = new DAL.DataSet_ShiftTableAdapters.mShiftTableAdapter();
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
