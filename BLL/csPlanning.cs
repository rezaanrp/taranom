using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
   public class csPlanning
    {
       //public bool InsertPlanning(int xPiece_,int  xPieceCount,int xShift_,string xPlanningDate,string xDate, 
       //    int xRegistringGroup_,bool xSupplier,bool xApprove,bool xRegister,string xComment)
       //{
       //    DAL.DataSet_PlanningTableAdapters.mPlanningTableAdapter adp =
       //        new DAL.DataSet_PlanningTableAdapters.mPlanningTableAdapter();
       //    adp.Insert(xPiece_, xPieceCount, xShift_, xPlanningDate, xDate, xRegistringGroup_, xSupplier, xApprove, xRegister, xComment);
       //    return true;
       //}
       public DataTable SelectmPlanningAndName(string DateFrom, string DateTo, bool Confirm)
       {
           DAL.DataSet_PlanningTableAdapters.SelectmPlanningAndNameTableAdapter adp = 
               new DAL.DataSet_PlanningTableAdapters.SelectmPlanningAndNameTableAdapter();
           return adp.GetData(DateFrom, DateTo, Confirm);
           
       }
       //public bool UpdatePlanningRegisteringGroup(int x_,bool xSupplier,bool xApprove,bool xRegister)
       //{

       //    DAL.DataSet_PlanningTableAdapters.mPlanningTableAdapter adp
       //        = new DAL.DataSet_PlanningTableAdapters.mPlanningTableAdapter();
       //    adp.UpdateRegisteringGroup(xSupplier, xApprove, xRegister, x_);
       //    return true;
       //}
       //public bool updateplanning(int x_, int xpiece_,int xpiececount,int xshift_,string xplanningdate ,string xcomment)
       //{
       //    DAL.DataSet_PlanningTableAdapters.mPlanningTableAdapter adp = new DAL.DataSet_PlanningTableAdapters.mPlanningTableAdapter();
       //    adp.UpdatePlanning( xpiece_,xpiececount,xshift_, xplanningdate , xcomment ,x_);
       //    return true;
       //}

       public DAL.DataSet_Planning.SelectPlanningByDateDataTable SelectPlanningByDate(string DateFrom,string DateTo)
       {
           DAL.DataSet_PlanningTableAdapters.SelectPlanningByDateTableAdapter adp =
               new DAL.DataSet_PlanningTableAdapters.SelectPlanningByDateTableAdapter();
           return adp.GetData(DateFrom,DateTo);
       }

       public bool UpdatePlanning(DAL.DataSet_Planning.SelectPlanningByDateDataTable dt)
       {

               DAL.DataSet_PlanningTableAdapters.SelectPlanningByDateTableAdapter adp =
                   new DAL.DataSet_PlanningTableAdapters.SelectPlanningByDateTableAdapter();

               adp.Update(dt);
               return true;
       }
    }
}
