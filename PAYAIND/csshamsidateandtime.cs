using System;

namespace PAYAIND
{
    public class csshamsidateandtime
    {
        public string calcshmsidate()
        { string date;
        System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
        DateTime datet = DateTime.Now;
        string month = (pc.GetMonth(datet) > 9) ? pc.GetMonth(datet).ToString() : "0" + pc.GetMonth(datet);
        string day = (pc.GetDayOfMonth(datet) > 9) ? pc.GetDayOfMonth(datet).ToString() : "0" + pc.GetDayOfMonth(datet);
        date = pc.GetYear(datet) + "/" + month + "/" + day;

        return date;
        } 

           public string calcshmsidate(string dateinput)
        {
            try
            { 
                string date;
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                DateTime datet = Convert.ToDateTime(dateinput);
                string month = (pc.GetMonth(datet) > 9) ? pc.GetMonth(datet).ToString() : "0" + pc.GetMonth(datet);
                string day = (pc.GetDayOfMonth(datet) > 9) ? pc.GetDayOfMonth(datet).ToString() : "0" + pc.GetDayOfMonth(datet);
                date = pc.GetYear(datet) + "/" + month + "/" + day;
                shamsidatetime = date;

                return date;
            }
            catch { return "0000/00/00"; }
        }
        public string miladitoshamsi(string miladi)
        {
            string date;
            date = miladi.Substring(0, 4);
            date += "/";
            date += miladi.Substring(5, 2);
            date += "/";
            date += miladi.Substring(8, 2);
            return calcshmsidate(date);
        }
        public string dayofweekfarsi()
        {
            DateTime d = DateTime.Now;
            DayOfWeek dey= d.DayOfWeek;
            switch (dey)
            {
                case DayOfWeek.Friday: return "جمعه";
                case DayOfWeek.Monday: return "دوشنبه";
                case DayOfWeek.Saturday: return "شنبه";
                case DayOfWeek.Sunday: return "یک شنبه";
                case DayOfWeek.Thursday: return "پنج شنبه";
                case DayOfWeek.Tuesday: return "سه شنبه";
                case DayOfWeek.Wednesday: return "چهار شنبه";
            }
            return "";
        }

        public static string shamsidatetime;

        public int DayOfYearShamsi()
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            int day = pc.GetDayOfYear(DateTime.Now);
            return day;
        }
        ////public int DayOfYearShamsi(string st)
        //{
        //    System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
        //    DateTime dttime = new DateTime(int.Parse(st.Substring(0, 4)), int.Parse(st.Substring(5, 2)), int.Parse(st.Substring(8, 2)));
        //    return dttime.DayOfYear;
        //}
        public string previousDay(int Perday)
        {
            try
            {
                string st = shamsidatetime;
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

                DateTime dttime = new DateTime(int.Parse(st.Substring(0, 4)), int.Parse(st.Substring(5, 2)), int.Parse(st.Substring(8, 2)), pc);
                dttime = dttime.AddDays(-Perday);

                string month = (pc.GetMonth(dttime) > 9) ? pc.GetMonth(dttime).ToString() : "0" + pc.GetMonth(dttime);
                string day = (pc.GetDayOfMonth(dttime) > 9) ? pc.GetDayOfMonth(dttime).ToString() : "0" + pc.GetDayOfMonth(dttime);
                string date = pc.GetYear(dttime) + "/" + month + "/" + day;

                return date;
            }
            catch (Exception)
            {

                return "";
            }

        }
        /*********************************/
         public string nextDay(string startday,int nextday)
        {
            try
            {
                string st = startday;
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                DateTime dttime = new DateTime(int.Parse(st.Substring(0, 4)), int.Parse(st.Substring(5, 2)), int.Parse(st.Substring(8, 2)), pc);
                dttime = dttime.AddDays(nextday);
                string month = (pc.GetMonth(dttime) > 9) ? pc.GetMonth(dttime).ToString() : "0" + pc.GetMonth(dttime);
                string day = (pc.GetDayOfMonth(dttime) > 9) ? pc.GetDayOfMonth(dttime).ToString() : "0" + pc.GetDayOfMonth(dttime);
                string date = pc.GetYear(dttime) + "/" + month + "/" + day;
                return date;
                
            }
            catch (Exception)
            {

                return "";
          
            }

        }
        /***************************************/
         
        //public bool CompareDate(string MAXDate, string MINDate)
        //{
        //    try
        //    {
        //        DateTime MAdttime = new DateTime(int.Parse(MAXDate.Substring(0, 4)), int.Parse(MAXDate.Substring(5, 2)), int.Parse(MAXDate.Substring(8, 2)));
        //        DateTime MIdttime = new DateTime(int.Parse(MINDate.Substring(0, 4)), int.Parse(MINDate.Substring(5, 2)), int.Parse(MINDate.Substring(8, 2)));

        //        if (MAdttime >= MIdttime)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }


        //}
        public string nexttime(int nexttime)
        {

            try
            {
                string st = shamsidatetime;
                DateTime t = DateTime.Now;
                t.AddHours(nexttime);
                string time;              
                string h = (t.Hour > 9) ? t.Hour.ToString() : "0" + t.Hour.ToString();
                string m = (t.Minute > 9) ? t.Minute.ToString() : "0" + t.Minute.ToString();
                time = h + ":" + m;
                return time;               
            }
            catch (Exception)
            {

                return "";
            }

        }
        public string calctime()
        {
            string time;
            DateTime t = DateTime.Now;
            string h = (t.Hour > 9) ? t.Hour.ToString() : "0" + t.Hour.ToString();
            string m = (t.Minute > 9) ? t.Minute.ToString() : "0" + t.Minute.ToString();
            time = h + ":" + m;
            return time;
        }
        public string calctimeful()
        {
            string time;
            DateTime t = DateTime.Now;
            string h = (t.Hour > 9) ? t.Hour.ToString() : "0" + t.Hour.ToString();
            string m = (t.Minute > 9) ? t.Minute.ToString() : "0" + t.Minute.ToString();
            string s = (t.Second > 9) ? t.Second.ToString() : "0" + t.Second.ToString();
            time = h + ":" + m+":"+s;
            
            return time;
        }
        public int distansbetweentimeinonseday(string firsttime, string lasttime)
        {
            try
            {

                int h1 = Convert.ToInt32(firsttime.Substring(0, 2));
                int h2 = Convert.ToInt32(lasttime.Substring(0, 2));
                int m1 = Convert.ToInt32(firsttime.Substring(3, 2));
                int m2 = Convert.ToInt32(lasttime.Substring(3, 2));
                h1 *= 60; h1 += m1;
                h2 *= 60; h2 += m2;
                return h2 - h1;
            }
            catch { return 0; }

        }

        public double distansebetweendayandtime(string firstdate, string lastdate, string firsttime, string lasttime)
        {
            System.Globalization.PersianCalendar calendar = new System.Globalization.PersianCalendar();
            try
            {  
                int fyear = Convert.ToInt32(firstdate.Substring(0, 4));
                int lyear = Convert.ToInt32(lastdate.Substring(0, 4));
                int fmo = Convert.ToInt32(firstdate.Substring(5, 2)); 
                int lmo = Convert.ToInt32(lastdate.Substring(5, 2));
                int fday = Convert.ToInt32(firstdate.Substring(8, 2));
                int lday = Convert.ToInt32(lastdate.Substring(8, 2));
                int h1 = Convert.ToInt32(firsttime.Substring(0, 2));
                int h2 = Convert.ToInt32(lasttime.Substring(0, 2));
                int m1 = Convert.ToInt32(firsttime.Substring(3, 2));
                int m2 = Convert.ToInt32(lasttime.Substring(3, 2));
                DateTime fd = calendar.ToDateTime(fyear, fmo, fday, h1, m1, 0, 0);
                DateTime ld = calendar.ToDateTime(lyear, lmo, lday, h2, m2, 0, 0);   
                double bt = (ld - fd).TotalMinutes;
                return bt;
            }
            catch
            {
                return -1;
            }
        }

        //*************************************************** اختلاف بین دو تاریخ بر حسب روز

        public Int32 distansebetween(string firstdate, string lastdate)
        {
            /*try
            {   Int32 z;
                
                int distanseday = int.Parse(lastdate.Substring(8, 2)) - int.Parse(firstdate.Substring(8, 2));
                int distansemonth = int.Parse(lastdate.Substring(5, 2)) - int.Parse(firstdate.Substring(5, 2));
                int distanseyear = int.Parse(lastdate.Substring(0, 4)) - int.Parse(firstdate.Substring(0, 4));
                return(Convert.ToInt32(distanseyear * 365 + distansemonth * 30 + distanseday));
            }
            catch
            {
                return -1;
            }*/


            try
            {

                System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
                DateTime l = p.ToDateTime(int.Parse(lastdate.Substring(0, 4)), int.Parse(lastdate.Substring(5, 2)), int.Parse(lastdate.Substring(8, 2)), 0, 0, 0, 0);
                DateTime f = p.ToDateTime(int.Parse(firstdate.Substring(0, 4)), int.Parse(firstdate.Substring(5, 2)), int.Parse(firstdate.Substring(8, 2)), 0, 0, 0, 0);
                return ((l - f).Days);

            }

            catch
            {

                return -1;

            }
        }
        //***************************************************
        public string shamsitomiladi(string sh)
        {
            try
            {
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                int y, m, d;

                y = Convert.ToInt32(sh.Substring(0, 4));
                m = Convert.ToInt32(sh.Substring(5, 2));
                d = Convert.ToInt32(sh.Substring(8, 2));

                DateTime dt = pc.ToDateTime(y, m, d, 0, 0, 0, 0);
                string y1, m1, d1;
                y1 = dt.Year.ToString();
                m1 = dt.Month > 9 ? dt.Month.ToString() : "0" + dt.Month.ToString();
                d1 = dt.Day > 9 ? dt.Day.ToString() : "0" + dt.Day.ToString();

                return (y1 + "/" + m1 + "/" + d1);
            }
            catch { return "0000/00/00"; }

        }
        public bool bigerdatetime(string d1, string d2)
        {
            try
            {
                DateTime dd1 = Convert.ToDateTime(d1);
                DateTime dd2 = Convert.ToDateTime(d2);
                if (dd1 > dd2) return true;
                return false;
            }
            catch { return false; }
        }
        public string persianmonth(int month)
        {
            string monthp="ماه انتخابی اشتباه است";
            switch (month)
            {
                case 1: monthp = "فروردین"; break;
                case 2: monthp = "اردیبهشت"; break;
                case 3: monthp = "خرداد"; break;
                case 4: monthp = "تیر"; break;
                case 5: monthp = "مرداد"; break;
                case 6: monthp = "شهریور"; break;
                case 7: monthp = "مهر"; break;
                case 8: monthp = "آبان"; break;
                case 9: monthp = "آذر"; break;
                case 10: monthp = "دی"; break;
                case 11: monthp = "بهمن"; break;
                case 12: monthp = "اسفند"; break;
                   
                   
            }
            return monthp;

        }

        public int distansbetweentimebysecond(string firsttime, string lasttime)
        {
            try
            {
                int s1 = Convert.ToInt32(firsttime.Substring(6, 2));
                int s2 = Convert.ToInt32(lasttime.Substring(6, 2));
                int h1 = Convert.ToInt32(firsttime.Substring(0, 2));
                int h2 = Convert.ToInt32(lasttime.Substring(0, 2));
                int m1 = Convert.ToInt32(firsttime.Substring(3, 2));
                int m2 = Convert.ToInt32(lasttime.Substring(3, 2));
                m1 *= 60;
                m2 *= 60;
                h1 *= 3600; 
                h2 *= 3600;
                h1 = h1 + m1 + s1;
                h2 = h2 + m2 + s2;
                return h2 - h1;
            }
            catch { return 0; }

        }
        public bool bigertime(string time1, string time2)
        {
            try
            {
                DateTime dd1 = Convert.ToDateTime(time1);
                DateTime dd2 = Convert.ToDateTime(time2);
                if (dd1 > dd2) return true;
                return false;
            }
            catch { return false; }
        }
        public string addtime (string time,int step)
        {
            DateTime dt;
            dt = Convert.ToDateTime(time);
            string y1, m1, d1;
            int h, m, s;
            h = dt.Hour;
            m = dt.Minute;
            s = dt.Second;
            s += step;
            if (s > 59)
            {
                s = s - 60;
                m++;
                {
                    if (m >= 59)
                        h++;
                    if (h > 23)
                        h = 0;
                }
            }

            y1 = h.ToString();
            m1 = m > 9 ? m.ToString(): "0" + m.ToString();
            d1 = s > 9 ? s.ToString() : "0" + s.ToString();
            //MessageBox.Show(step.ToString());
            return y1 + ":" + m1 + ":"+d1 ;

        }


    }
}
