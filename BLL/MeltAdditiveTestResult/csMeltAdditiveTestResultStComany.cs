using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL.MeltAdditiveTestResult
{
   public class csMeltAdditiveTestResultStComany
    {
       public DataTable SlMeltAdditiveTestResultStCu(string DateFrom, string DateTo,bool IsScrab)
       {
           DAL.MeltAdditiveTestResult.DataSet_MeltAdditiveTestResultTableAdapters.SlMeltAdditiveTestResultStCoTableAdapter adp
               = new DAL.MeltAdditiveTestResult.DataSet_MeltAdditiveTestResultTableAdapters.SlMeltAdditiveTestResultStCoTableAdapter();
           return adp.GetData(DateFrom, DateTo,IsScrab);
       }
       public DataTable SlMeltAdditiveTestResultStCoMonth(string xYear, bool IsScrab)
       {
           DAL.MeltAdditiveTestResult.DataSet_MeltAdditiveTestResultTableAdapters.SlMeltAdditiveTestResultStCoMonthTableAdapter adp
               = new DAL.MeltAdditiveTestResult.DataSet_MeltAdditiveTestResultTableAdapters.SlMeltAdditiveTestResultStCoMonthTableAdapter();
           return adp.GetData(xYear, IsScrab);
       }
    }
}
