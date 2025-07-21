using System;

namespace BLL
{
    public class csshamsidate
    {
       

        public string  CurrentTime
        {
            get { return new DAL.DataSet_ShamsiDateTableAdapters.GetShamsiInfoTableAdapter().GetData()[0].CrTime; }
        }

        public  string CalcShamsidate()
        {
            DAL.DataSet_ShamsiDateTableAdapters.GetShamsiInfoTableAdapter adp = new DAL.DataSet_ShamsiDateTableAdapters.GetShamsiInfoTableAdapter();
            DAL.DataSet_ShamsiDate.GetShamsiInfoDataTable dt =  adp.GetData();
            DAL.DataSet_ShamsiDate.GetShamsiInfoRow dr = dt[0];


            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime dttime = new DateTime(int.Parse(dr.YearMiladi.ToString()), int.Parse(dr.MonthMiladi), int.Parse(dr.DayMiladi));
             
            string month = (pc.GetMonth(dttime) > 9) ? pc.GetMonth(dttime).ToString() : "0" + pc.GetMonth(dttime);
            string day = (pc.GetDayOfMonth(dttime) > 9) ? pc.GetDayOfMonth(dttime).ToString() : "0" + pc.GetDayOfMonth(dttime);
            string time = pc.GetYear(dttime) + "/" + month + "/" + day;

            shamsidate = time;

            return time;
        }

        public static string shamsidate = "1399/01/01";

        public int DayOfYearShamsi()
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            int ro = pc.GetDayOfYear(DateTime.Now);
            return ro;
        }
        public int DayOfYearShamsi(string st)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            return pc.GetDayOfYear(pc.ToDateTime(int.Parse(st.Substring(0, 4)), int.Parse(st.Substring(5, 2)), int.Parse(st.Substring(8, 2)), 0, 0, 0, 0));
        }
        public static string ShamsiDateAndDayOfYear(decimal year, decimal dayOfYear)
        {
            decimal Da = dayOfYear;
            decimal mo = 1;
            for (int i = 0; i < 6; i++)
            {
                if (Da > 31)
                {
                    Da -= 31;
                    mo++;
                }

            }
            if(Da > 31 )
            for (int i = 0; i < 5; i++)
            {
                if (Da > 30)
                {
                    Da -= 30;
                    mo++;
                }

            }
            string mos = mo.ToString().Length < 2 ? "0" + mo.ToString() : mo.ToString();
            string Day = Da.ToString().Length < 2 ? "0" + Da.ToString() : Da.ToString();
            return  year.ToString() + "/" + mos + "/" + Day;
        }

        public string previousDay(int Perday)
        {
            try
            {
                string st = shamsidate;
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

                DateTime dttime = new DateTime(int.Parse(st.Substring(0, 4)), int.Parse(st.Substring(5, 2)), int.Parse(st.Substring(8, 2)),pc);
                dttime = dttime.AddDays(-Perday);

                //string month = (dttime.Month > 9) ? dttime.Month.ToString() : "0" + dttime.Month;
                //string day = (dttime.Day > 9) ? dttime.Day.ToString() : "0" + dttime.Day;
                //string time = dttime.Year + "/" + month + "/" + day;


                string month = (pc.GetMonth(dttime) > 9) ? pc.GetMonth(dttime).ToString() : "0" + pc.GetMonth(dttime);
                string day = (pc.GetDayOfMonth(dttime) > 9) ? pc.GetDayOfMonth(dttime).ToString() : "0" + pc.GetDayOfMonth(dttime);
                string time = pc.GetYear(dttime) + "/" + month + "/" + day;

                return time;
            }
            catch (Exception)
            {

                return "";
            }

        }
       public enum Ravand
        {
            up,
            down
        }
        public string previousDay(string Dte, int Perday, Ravand kt)
        {
            try
            {
                string st = Dte;
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

                DateTime dttime = new DateTime(int.Parse(st.Substring(0, 4)), int.Parse(st.Substring(5, 2)), int.Parse(st.Substring(8, 2)), pc);
                if (kt == Ravand.down)
                    dttime = dttime.AddDays(-Perday);
                else
                    dttime = dttime.AddDays(Perday);

                //string month = (dttime.Month > 9) ? dttime.Month.ToString() : "0" + dttime.Month;
                //string day = (dttime.Day > 9) ? dttime.Day.ToString() : "0" + dttime.Day;
                //string time = dttime.Year + "/" + month + "/" + day;


                string month = (pc.GetMonth(dttime) > 9) ? pc.GetMonth(dttime).ToString() : "0" + pc.GetMonth(dttime);
                string day = (pc.GetDayOfMonth(dttime) > 9) ? pc.GetDayOfMonth(dttime).ToString() : "0" + pc.GetDayOfMonth(dttime);
                string time = pc.GetYear(dttime) + "/" + month + "/" + day;

                return time;
            }
            catch (Exception)
            {

                return "";
            }

        }
        public DateTime PersianToGregorian(string ShamsiDate,string Time)
        {
            string st = ShamsiDate;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime dttime = new DateTime(int.Parse(st.Substring(0, 4)),
                int.Parse(st.Substring(5, 2)), int.Parse(st.Substring(8, 2)), int.Parse(Time.Substring(0, 2)), int.Parse(Time.Substring(3, 2)), 0,pc);
            return dttime;

        }

        public int ShamsiDayeOfWeek(string ShamsiDate)
        {
            string st = ShamsiDate;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime dttime = new DateTime(int.Parse(st.Substring(0, 4)), int.Parse(st.Substring(5, 2)), int.Parse(st.Substring(8, 2)), pc);
            return ((int)dttime.DayOfWeek  + 2) % 7;

        }
        public bool CompareDate(string MAXDate, string MINDate)
        {
            try
            {
                int may = int.Parse(MAXDate.Substring(0, 4));
                int mam = int.Parse(MAXDate.Substring(5, 2));
                int mad = int.Parse(MAXDate.Substring(8, 2));

                int miy = int.Parse(MINDate.Substring(0, 4));
                int mim = int.Parse(MINDate.Substring(5, 2));
                int mid = int.Parse(MINDate.Substring(8, 2));


                if (may > miy)
                    return true;
                else if (may == miy)
                {
                    if (mam > mim)
                        return true;
                    else if (mam == mim)
                    {
                        if (mad >= mid)
                            return true;
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }


        }
    }
}
