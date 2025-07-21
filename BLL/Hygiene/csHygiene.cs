using System;

namespace BLL.Hygiene
{
    public  class csHygiene
    {


      public DAL.Hygiene.DataSet_Hygiene.mDoctorReportByPerson_DataTable mDoctorReportByPerson_(int xPer_)
        {
            DAL.Hygiene.DataSet_HygieneTableAdapters.mDoctorReportByPerson_TableAdapter adp
                 = new DAL.Hygiene.DataSet_HygieneTableAdapters.mDoctorReportByPerson_TableAdapter();
            return adp.GetData(xPer_);
        }

      public DAL.Hygiene.DataSet_Hygiene.mDoctorReportDataTable mDoctorReport()
        {
            DAL.Hygiene.DataSet_HygieneTableAdapters.mDoctorReportTableAdapter adp
                 = new DAL.Hygiene.DataSet_HygieneTableAdapters.mDoctorReportTableAdapter();
            return adp.GetData();
        }
      public string UdDoctorReport(DAL.Hygiene.DataSet_Hygiene.mDoctorReportDataTable dt)
        {
            try
            {
                DAL.Hygiene.DataSet_HygieneTableAdapters.mDoctorReportTableAdapter adp
                     = new DAL.Hygiene.DataSet_HygieneTableAdapters.mDoctorReportTableAdapter();
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
