using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tools.rtv
{
    public  class ValidationHelper
    {

        //public static void CheckIsCodeMelliValid(string nationalCode)
        //{
        //    if (!IsCodeMelliValid(nationalCode))
        //    {
        //        throw new EITException(string.Format("کد ملی {0} معتبر نمی باشد.", nationalCode));
        //    }
        //}

        //public static void CheckIsValidCompanyCode(string companyCode)
        //{
        //    if (!IsValidCompanyCode(companyCode))
        //    {
        //        throw new EITException(string.Format("شناسه ملی {0} معتبر نیست.", companyCode));
        //    }
        //}

        public static bool IsCellphoneNumberValid(string phrase)
        {
            return Regex.IsMatch(phrase, "^09[0-9]{9}$");
        }

        public static bool IsCodeMelliValid(string codeMelli)
        {
            string str = (codeMelli != null) ? codeMelli.Trim() : null;
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            if (str.Length != 10)
            {
                return false;
            }
            Regex regex = new Regex(@"\d{10}");
            if (!regex.IsMatch(str))
            {
                return false;
            }
            string[] source = new string[] { "0000000000", "1111111111", "2222222222", "3333333333", "4444444444", "5555555555", "6666666666", "7777777777", "8888888888", "9999999999" };
            if (source.Contains<string>(str))
            {
                return false;
            }
            char[] chArray = str.ToCharArray();
            int num = Convert.ToInt32(chArray[0].ToString()) * 10;
            int num2 = Convert.ToInt32(chArray[1].ToString()) * 9;
            int num3 = Convert.ToInt32(chArray[2].ToString()) * 8;
            int num4 = Convert.ToInt32(chArray[3].ToString()) * 7;
            int num5 = Convert.ToInt32(chArray[4].ToString()) * 6;
            int num6 = Convert.ToInt32(chArray[5].ToString()) * 5;
            int num7 = Convert.ToInt32(chArray[6].ToString()) * 4;
            int num8 = Convert.ToInt32(chArray[7].ToString()) * 3;
            int num9 = Convert.ToInt32(chArray[8].ToString()) * 2;
            int num10 = Convert.ToInt32(chArray[9].ToString());
            int num11 = (((((((num + num2) + num3) + num4) + num5) + num6) + num7) + num8) + num9;
            int num12 = num11 % 11;
            return (((num12 < 2) && (num10 == num12)) || ((num12 >= 2) && ((11 - num12) == num10)));
        }

        public static bool IsEnglishWithNumbersPhrase(string phrase)
        {
            return Regex.IsMatch(phrase, @"^[a-zA-Z\s0-9]+$");
        }

        public static bool IsEnglishWithSymbolsPhrase(string phrase)
        {
            return Regex.IsMatch(phrase, @"^(?:[a-zA-Z\s0-9]|[\x21\x22\x23\x24\x25\x26\x27\x28\x29\x2A\x2B\x2C\x2D\x2E\x2F\x3A\x3B\x3C\x3D\x3E\x3F\x40\x5B\x5C\x5D\x5E\x5F\x60\x7B\x7C\x7D\x7E])+$");
        }

        public static bool IsNumberOnlyPhrase(string phrase)
        {
            return Regex.IsMatch(phrase, "^[0-9]+$");
        }
        public static bool IsPersianWithNumbersPhrase(string phrase)
        {
            return Regex.IsMatch(phrase, @"^(?:[\u0600-\u06FF]|\s|[0-9])+$");
        }

        public static bool IsPhoneNumberValid(string phrase)
        {
            return Regex.IsMatch(phrase, "^(?:0[1-8][0-9]{9}|[1-9][0-9]{3,7})$");
        }

        public static bool IsPureEnglishPhrase(string phrase)
        {
            return Regex.IsMatch(phrase, @"^[a-zA-Z\s]+$");
        }

        public static bool IsPurePersianPhrase(string phrase)
        {
            return Regex.IsMatch(phrase, @"^(?:[\u0600-\u06FF]|\s)+$");
        }
        public static bool IsRegexMatch(string input, string regex)
        {
            return Regex.IsMatch(input, regex, RegexOptions.ECMAScript | RegexOptions.Multiline | RegexOptions.IgnoreCase);
        }

        public static bool IsValidCompanyCode(string companyCode)
        {
            long num;
            byte num2;
            byte num3;
            int num4;
            string str = (companyCode != null) ? companyCode.Trim() : null;
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            if (((str.Length != 11) || !long.TryParse(str, out num)) || new string[] { "00000000000", "11111111111", "22222222222", "33333333333", "44444444444", "55555555555", "66666666666", "77777777777", "88888888888", "99999999999" }.Contains<string>(str))
            {
                return false;
            }
            byte.TryParse(str.Substring(10, 1), out num2);
            byte.TryParse(str.Substring(9, 1), out num3);
            int[] source = new int[] { ((byte.Parse(str.Substring(0, 1)) + num3) + 2) * 0x1d, ((byte.Parse(str.Substring(1, 1)) + num3) + 2) * 0x1b, ((byte.Parse(str.Substring(2, 1)) + num3) + 2) * 0x17, ((byte.Parse(str.Substring(3, 1)) + num3) + 2) * 0x13, ((byte.Parse(str.Substring(4, 1)) + num3) + 2) * 0x11, ((byte.Parse(str.Substring(5, 1)) + num3) + 2) * 0x1d, ((byte.Parse(str.Substring(6, 1)) + num3) + 2) * 0x1b, ((byte.Parse(str.Substring(7, 1)) + num3) + 2) * 0x17, ((byte.Parse(str.Substring(8, 1)) + num3) + 2) * 0x13, ((byte.Parse(str.Substring(9, 1)) + num3) + 2) * 0x11 };
            Math.DivRem(source.Sum(), 11, out num4);
            if (num4 == 10)
            {
                num4 = 0;
            }
            return (num4 == num2);
        }

        //public static bool IsValidShDate(string phrase)
        //{
        //    return DateTimeTools.IsValidShDate(phrase);
        //}




 



 



     
 


    }
}
