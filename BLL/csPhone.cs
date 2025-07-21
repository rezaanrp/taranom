using System;
using System.Data;
namespace BLL
{
    public class csPhone
    {
       public DataTable SelectPhonedetialsFilterByValue(string value)
       {
           DAL.DataSet_PhoneTableAdapters.SelectPhonedetialsFilterByValueTableAdapter adp
               = new DAL.DataSet_PhoneTableAdapters.SelectPhonedetialsFilterByValueTableAdapter();
           return adp.GetData(value,BLL.authentication.x_);
       }
       public DAL.DataSet_Phone.SelectPhoneDetialsByValueDataTable SelectPhoneDetialsByValue(string value)
       {
           DAL.DataSet_PhoneTableAdapters.SelectPhoneDetialsByValueTableAdapter adp
               = new DAL.DataSet_PhoneTableAdapters.SelectPhoneDetialsByValueTableAdapter();
           return adp.GetData(value,BLL.authentication.x_);
       }
       public DataTable SelectPhoneGroupName()
       {
           DAL.DataSet_PhoneTableAdapters.SelectPhoneGroupNameTableAdapter adp
               = new DAL.DataSet_PhoneTableAdapters.SelectPhoneGroupNameTableAdapter();
           return adp.GetData();
       }
       public DataTable SelectPhoneGroupName(int Detials)
       {
           DAL.DataSet_PhoneTableAdapters.SelectPhoneGroupNameByDetialsTableAdapter adp
                         = new DAL.DataSet_PhoneTableAdapters.SelectPhoneGroupNameByDetialsTableAdapter();
           return adp.GetData(Detials);
       }

       public bool InsertPhoneDetials(string xName,string xFamily,string xPost,string xComponyName,
           string xWebSite, string xEmail, string xFax, string xTel, string xMob, string xAddress, int[] Group)
       {
           try
           {
               int? x_ = null;
               DAL.DataSet_PhoneTableAdapters.QueriesTableAdapter adp =
                   new DAL.DataSet_PhoneTableAdapters.QueriesTableAdapter();
               adp.InsertPhoneDetials(xName, xFamily, xPost, xComponyName, xWebSite, xEmail, xFax, xTel, xMob,xAddress ,ref x_);

               foreach (int item in Group)
               {
                   if (item > 0)
                   adp.InsertPhoneDetialsGroup(x_, item);
               }
               return true;

           }
            catch (Exception)
           {
                   return false;
             
           }
       }


       public bool UpdatePhoneDetials(string xName,string xFamily,string xPost,string xComponyName,string xWebSite,
           string xEmail,string xFax,string xTel,string xMob,string xAddress,int x_  ,int[] Group)
       {
           try
           {
               DAL.DataSet_PhoneTableAdapters.QueriesTableAdapter adp
                            = new DAL.DataSet_PhoneTableAdapters.QueriesTableAdapter();
               adp.UpdatePhoneDetials(xName, xFamily, xPost, xComponyName, xWebSite, xEmail, xFax, xTel, xMob, xAddress, x_);

               adp.DeletePhoneDetialsGroup(x_);
               foreach (int item in Group)
               {
                   if (item > 0)
                       adp.InsertPhoneDetialsGroup(x_, item);
               }

               return true;
           }
           catch (Exception)
           {
               return false;
           }

       }
       public bool UpdatePhoneDetials(DAL.DataSet_Phone.SelectPhoneDetialsByValueDataTable dt)
       {
           DAL.DataSet_PhoneTableAdapters.SelectPhoneDetialsByValueTableAdapter adp
               = new DAL.DataSet_PhoneTableAdapters.SelectPhoneDetialsByValueTableAdapter();
           adp.Update(dt);
           return true;
       }
       public bool DeletePhoneDetials(int x_)
       {
           try
           {
               DAL.DataSet_PhoneTableAdapters.QueriesTableAdapter adp
                            = new DAL.DataSet_PhoneTableAdapters.QueriesTableAdapter();
               adp.DeletePhoneDetials(x_);
               return true;
           }
           catch (Exception)
           {
               return false;
           }

       }

    }
}
