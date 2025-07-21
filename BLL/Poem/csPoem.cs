using System;

namespace BLL.Poem
{
    public class csPoem
    {
       public System.Data.DataTable SlPoem()
       {
           DAL.Poem.DataSet_PoemTableAdapters.SlPoemTableAdapter adp =
               new DAL.Poem.DataSet_PoemTableAdapters.SlPoemTableAdapter();
           return adp.GetData();
       }


       public DAL.Poem.DataSet_Poem.SlPoemListDataTable SlPoemList()
       {
           DAL.Poem.DataSet_PoemTableAdapters.SlPoemListTableAdapter adp =
               new DAL.Poem.DataSet_PoemTableAdapters.SlPoemListTableAdapter();
           return adp.GetData();
       }
       public string UdPoem(DAL.Poem.DataSet_Poem.SlPoemListDataTable dt)
       {
           try
           {
               DAL.Poem.DataSet_PoemTableAdapters.SlPoemListTableAdapter adp =
                   new DAL.Poem.DataSet_PoemTableAdapters.SlPoemListTableAdapter();
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
