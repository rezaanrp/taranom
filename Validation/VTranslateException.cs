using System.Collections.Generic;

namespace Validation
{
    public  class VTranslateException
    {
      public string EnToFarsiCatalog(string StInput)
      {
          Dictionary<string, string> dictionary =
              new Dictionary<string, string>();
          dictionary.Add("Value was either too large or too small for an unsigned byte.", "مقدار ورودی از حد مجاز کمتر یا بیشتر است");
          dictionary.Add("Column 'xPieces_' does not allow nulls.", " لطفا فیلد مربوط به محصولات را پر کنید");
          if (dictionary.ContainsKey(StInput))
          {
              string value = dictionary[StInput];
              return value;
          }

          return "خطا" + "\n" + StInput;
      }


    }
}
