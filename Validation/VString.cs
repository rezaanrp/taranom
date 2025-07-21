namespace Validation
{
    public class VString
    {
        /// <summary>
        /// فرمت تاریخ ورودی 
        /// xx/?x/?x
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public string StandardDate(string st)
        {
            int st_len = st.Length;
            bool flag = true;
            while (flag)
            {
                if (!(st[0] == '0' || st[0] == '1' || st[0] == '2' || st[0] == '3' || st[0] == '4' || st[0] == '5' || st[0] == '6' || st[0] == '7' || st[0] == '8' || st[0] == '9'))
                {
                    st = st.Remove(0, 1);
                    st_len = st.Length;
                }
                else
                    flag = false;

            }
            flag = true;
            while (flag)
            {
                if (!(st[st_len - 1] == '0' || st[st_len - 1] == '1' || st[st_len - 1] == '2' || st[st_len - 1] == '3' || st[st_len - 1] == '4' || st[st_len - 1] == '5' || st[st_len - 1] == '6' || st[st_len - 1] == '7' || st[st_len - 1] == '8' || st[st_len - 1] == '9'))
                {
                    st = st.Remove(st_len - 1);
                    st_len = st.Length;
                }
                else
                    flag = false;
            }

            string[] Dt = st.Split('/');
            string St_Year = "13" + Dt[0];
            string St_Month = Dt[1].Length < 2 ? "0" + Dt[1] : Dt[1]; ;
            string St_Day = Dt[2].Length < 2 ? "0" + Dt[2] : Dt[2]; ;
            st = St_Year + "/" + St_Month + "/" + St_Day;
            return st;
        }
        public bool isTime(string Time)
        {
            if (Time == "" || Time.Length != 5)
                return false;
            int Ho = 0;  
            int Mi = 0; 
            int.TryParse( Time.Substring(0,2),out Ho);
            int.TryParse( Time.Substring(3,2),out Mi);

            if(Time.Length == 5 &&  int.TryParse( Time.Substring(0,2),out Ho) && int.TryParse( Time.Substring(3,2),out Mi) )
            {
                if (Ho >= 0 && Ho < 24 && Mi < 60  && Mi >= 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
