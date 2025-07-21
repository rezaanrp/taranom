using System;
using System.Linq;

namespace Tools.rtv
{
    public class FarsiTools
    {
       public const string WasteCharsPattern = "[‍ًٌٍَُِّ]";
 
        private static string BaseNumToLitralStr(long number)
        {
            string str = "";
            long num = number;
            if (num > 300L)
            {
                if (num <= 700L)
                {
                    if (num <= 500L)
                    {
                        switch (num)
                        {
                            case 400L:
                                return "چهارصد";

                            case 500L:
                                return "پانصد";
                        }
                        return str;
                    }
                    switch (num)
                    {
                        case 600L:
                            return "ششصد";

                        case 700L:
                            return "هفتصد";
                    }
                    return str;
                }
                if (num <= 900L)
                {
                    switch (num)
                    {
                        case 800L:
                            return "هشتصد";

                        case 900L:
                            return "نهصد";
                    }
                    return str;
                }
                switch (num)
                {
                    case 0x3e8L:
                        return "هزار";

                    case 0xf4240L:
                        return "ميليون";

                    case 0x3b9aca00L:
                        return "ميليارد";
                }
                return str;
            }
            if (num > 70L)
            {
                if (num <= 90L)
                {
                    switch (num)
                    {
                        case 80L:
                            return "هشتاد";

                        case 90L:
                            return "نود";
                    }
                    return str;
                }
                switch (num)
                {
                    case 100L:
                        return "يکصد";

                    case 200L:
                        return "دويست";

                    case 300L:
                        return "سيصد";
                }
                return str;
            }
            if (num > 50L)
            {
                switch (num)
                {
                    case 60L:
                        return "شصت";

                    case 70L:
                        return "هفتاد";
                }
                return str;
            }
            if (num <= 40L)
            {
                long expressionStack_34_0 = num;
                switch (((uint)expressionStack_34_0))
                {
                    case 0:
                        return "صفر";

                    case 1:
                        return "يک";

                    case 2:
                        return "دو";

                    case 3:
                        return "سه";

                    case 4:
                        return "چهار";

                    case 5:
                        return "پنج";

                    case 6:
                        return "شش";

                    case 7:
                        return "هفت";

                    case 8:
                        return "هشت";

                    case 9:
                        return "نه";

                    case 10:
                        return "ده";

                    case 11:
                        return "يازده";

                    case 12:
                        return "دوازده";

                    case 13:
                        return "سيزده";

                    case 14:
                        return "چهارده";

                    case 15:
                        return "پانزده";

                    case 0x10:
                        return "شانزده";

                    case 0x11:
                        return "هفده";

                    case 0x12:
                        return "هجده";

                    case 0x13:
                        return "نوزده";

                    case 20:
                        return "بيست";

                    case 0x15:
                    case 0x16:
                    case 0x17:
                    case 0x18:
                    case 0x19:
                    case 0x1a:
                    case 0x1b:
                    case 0x1c:
                    case 0x1d:
                    case 0x1f:
                    case 0x20:
                    case 0x21:
                    case 0x22:
                    case 0x23:
                    case 0x24:
                    case 0x25:
                    case 0x26:
                    case 0x27:
                        return str;

                    case 30:
                        return "سي";

                    case 40:
                        return "چهل";
                }
            }
            else
            {
                long expressionStack_2E_0 = num;
            }
            if (num == 50L)
            {
                return "پنجاه";
            }
            return str;
        }
        private static string BaseNumToLitralStrPoint(int number)
        {
            switch (number)
            {
                case 1:
                    return "دهم";

                case 2:
                    return "صدم";

                case 3:
                    return "هزارم";

                case 4:
                    return "ده هزارم";

                case 5:
                    return "صد هزارم";

                case 6:
                    return "ميليونم";

                case 7:
                    return "ده ميليونم";

                case 8:
                    return "صد ميليونم";

                case 9:
                    return "يک ميلياردم";

                case 10:
                    return "ده ميلياردم";

                case 11:
                    return "صد ميلياردم";
            }
            throw new OverflowException("مقدار اعشار بيش از اندازه کوچک بود");
        }
        public static string CorrectFarsiCharacters(string str, bool isPassword)
        {
            string str2 = str;
            if (!string.IsNullOrEmpty(str2) && !isPassword)
            {
                str2 = str2.Replace('ی', 'ي').Replace('ك', 'ک').Replace("≡", "").Replace("ً", "").Replace("ٌ", "").Replace("ٍ", "").Replace("َ", "").Replace("ُ", "").Replace("ِ", "").Replace("\x00b0", "").Replace("∙", "").Replace("\x00b7", "");
            }
            return str2;
        }

        public static string LiteralDate(string strDate)
        {
            string str;
            string str2;
            string str3;
            DecodeShDate(strDate, out str, out str2, out str3);
            string[] strArray = new string[] { "", "فروردين", "ارديبهشت", "خرداد", "تير", "مرداد", "شهريور", "مهر", "آبان", "آذر", "دي", "بهمن", "اسفند" };
            if (str.Length == 4)
            {
                str = str.Remove(0, 2);
            }
            str = LiteralValue((long)int.Parse(str));
            str2 = strArray[int.Parse(str2)];
            int num = int.Parse(str3);
            str3 = LiteralValue((long)int.Parse(str3));
            if ((num == 3) || (num == 0x17))
            {
                str3 = str3.Remove(str3.Length - 1, 1) + "وم";
            }
            else if (num == 30)
            {
                str3 = str3 + " ام";
            }
            else
            {
                str3 = str3 + "م";
            }
            string[] textArray2 = new string[] { str3, " ", str2, " ", str };
            return string.Concat(textArray2);
        }
     
        public static string LiteralValue(long number)
        {
            string str;
            bool flag = false;
            if (number < 0L)
            {
                number = -number;
                flag = true;
            }
            if (number <= 20L)
            {
                str = BaseNumToLitralStr(number);
            }
            else
            {
                long num;
                long num2;
                if (number <= 0x63L)
                {
                    num = number / 10L;
                    num2 = number % 10L;
                    str = BaseNumToLitralStr(num * 10L);
                    if (num2 > 0L)
                    {
                        str = str + " و " + BaseNumToLitralStr(num2);
                    }
                }
                else if (number <= 0x3e7L)
                {
                    num = number / 100L;
                    num2 = number % 100L;
                    str = BaseNumToLitralStr(num * 100L);
                    if (num2 > 0L)
                    {
                        str = str + " و " + LiteralValue(num2);
                    }
                }
                else if (number <= 0xf423fL)
                {
                    num = number / 0x3e8L;
                    num2 = number % 0x3e8L;
                    str = LiteralValue(num) + " " + BaseNumToLitralStr(0x3e8L);
                    if (num2 > 0L)
                    {
                        str = str + " و " + LiteralValue(num2);
                    }
                }
                else if (number <= 0x3b9ac9ffL)
                {
                    num = number / 0xf4240L;
                    num2 = number % 0xf4240L;
                    str = LiteralValue(num) + " " + BaseNumToLitralStr(0xf4240L);
                    if (num2 > 0L)
                    {
                        str = str + " و " + LiteralValue(num2);
                    }
                }
                else
                {
                    num = number / 0x3b9aca00L;
                    num2 = number % 0x3b9aca00L;
                    str = LiteralValue(num) + " " + BaseNumToLitralStr(0x3b9aca00L);
                    if (num2 > 0L)
                    {
                        str = str + " و " + LiteralValue(num2);
                    }
                }
            }
            if (flag)
            {
                str = " منفي " + str;
            }
            return str;
        }

        public static string NumToLiteralStrOrdinal(long number)
        {
            string str3;
            string str = LiteralValue(number);
            string str2 = number.ToString();
            string str4 = str2.Substring(str2.Length - 1, 1);
            if (str2.Length == 1)
            {
                str3 = str4;
            }
            else
            {
                str3 = str2.Substring(str2.Length - 2, 2);
            }
            if (number == 1L)
            {
                return "اول";
            }
            if (number == 13L)
            {
                return "سيزدهم";
            }
            if (str4 == "3")
            {
                return (str.Substring(0, str.Length - 1) + "وم");
            }
            if (str3 == "30")
            {
                return (str + " ام");
            }
            return (str + "م");
        }


        public static string NumToLitralStr(decimal number)
        {
            return NumToLitralStr(number, true);
        }


        public static string NumToLitralStr(decimal number, bool trimEndZeros)
        {
           
                char[] separator = new char[] { '.' };
                string[] strArray = number.ToString().Split(separator);
                if (strArray[0].Contains('/'))
                {
                    separator = new char[] { '/' };
                    strArray = number.ToString().Split(separator);
                }
                string str = LiteralValue(long.Parse(strArray[0]));
           

            if (strArray.Length > 1)
            {
                if (!trimEndZeros && (int.Parse(strArray[1]) > 0))
                {
                    string[] textArray1 = new string[] { str, " مميز ", LiteralValue(long.Parse(strArray[1])), " ", BaseNumToLitralStrPoint(strArray[1].Length) };
                    return string.Concat(textArray1);
                }
                bool flag3 = true;
                while ((strArray[1].Length > 0) & flag3)
                {
                    if (int.Parse(strArray[1].Substring(strArray[1].Length - 1)) == 0)
                    {
                        strArray[1] = strArray[1].Remove(strArray[1].Length - 1);
                    }
                    else
                    {
                        flag3 = false;
                    }
                }
                if (strArray[1].Length > 0)
                {
                    string[] textArray2 = new string[] { str, " مميز ", LiteralValue(long.Parse(strArray[1])), " ", BaseNumToLitralStrPoint(strArray[1].Length) };
                    str = string.Concat(textArray2);
                }
            }
            return str;
        }

        private static void DecodeShDate(string strDate, out string sYear, out string sMonth, out string sDay)
        {
            try
            {
                char[] separator = new char[] { '/' };
                string[] strArray = strDate.Split(separator);
                sYear = strArray[0];
                sMonth = strArray[1];
                sDay = strArray[2];
            }
            catch
            {
                throw new Exception("فرمت تاريخ صحيح نمي باشد");
            }
        }



 
  


    }
}
