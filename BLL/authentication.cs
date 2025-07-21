using System;
using System.Data;

namespace BLL
{
    public class authentication
    {
        public static string userid { get; set; }
        public static int xGroup_;
        public static int x_ { get; set; }
        public static bool userlogin { get; set; }
        public static bool InsertData = false;
        public static bool UpdateData = false;
        public static bool DeleteData = false;
        public static int RegistringGroup_;
        public static string NameAndFamily = "";
        public static int xApproveby_;
        public static int xSupplierby_;
        public static int xRegisterby_;

                public bool DlAuthenticationDeActive()
        {
            DAL.DataSet_AuthenticationTableAdapters.QueriesTableAdapter adp
             = new DAL.DataSet_AuthenticationTableAdapters.QueriesTableAdapter();
             adp.DlAuthenticationDeActive();
            return true;
        }


        public DAL.DataSet_Authentication.mAuthenticationByObjectDataTable mAuthenticationByObject(int Object_)
        {
            DAL.DataSet_AuthenticationTableAdapters.mAuthenticationByObjectTableAdapter adp
                 = new DAL.DataSet_AuthenticationTableAdapters.mAuthenticationByObjectTableAdapter();
            return adp.GetData(Object_);
        }
        public string UdAuthenticationByObject(DAL.DataSet_Authentication.mAuthenticationByObjectDataTable dt)
        {
            try
            {
                DAL.DataSet_AuthenticationTableAdapters.mAuthenticationByObjectTableAdapter adp
                             = new DAL.DataSet_AuthenticationTableAdapters.mAuthenticationByObjectTableAdapter();
                adp.Update(dt);
                return "عملیات ذخیره سازی با موفقیت انجام شد";
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }


        public bool userloginallow(string username,string password)
        {
            DAL.DataSet_LoginTableAdapters.Select_CheckuserpassTableAdapter adp = new DAL.DataSet_LoginTableAdapters.Select_CheckuserpassTableAdapter();
            DAL.DataSet_Login.Select_CheckuserpassDataTable dt = adp.GetData(username, password);
            if (dt.Count > 0)
            {
                csEvent Event = new csEvent();
                userid = username;
                x_ = int.Parse(dt[0]["x_"].ToString());
                xGroup_ = int.Parse(dt[0]["xGroup_"].ToString());
                NameAndFamily = dt[0]["xName"].ToString() + " " + dt[0]["xFamily"].ToString();
                     Event.eventlogin("loginuser", "", "", "", x_.ToString());

                     if (objectallow("InvMaterialInputAlarm"))
                     {
                         DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialInputCheckExpTableAdapter adpe =
                             new DAL.FIFO.DataSet_InvMaterialInputTableAdapters.SlInvMaterialInputCheckExpTableAdapter();
                         adpe.GetData(x_);
                     }
                if (objectallow("GageList"))
                {
                    DAL.GageList.DataSet_GagelistTableAdapters.SlGageListCalibrationAlarmTableAdapter adpe =
                        new DAL.GageList.DataSet_GagelistTableAdapters.SlGageListCalibrationAlarmTableAdapter();
                    adpe.GetData();
                }
                

                return userlogin = true;

//بررسی فرم دسترسی
      //          SlInvMaterialInputCheckExp

            }
            else
                return userlogin = false;
        }
        public DataTable NameOfUser() 
        {
            DAL.DataSet_AuthenticationTableAdapters.mNameOfUserTableAdapter adp
                 = new DAL.DataSet_AuthenticationTableAdapters.mNameOfUserTableAdapter();
        return adp.GetData();

        }
        public static bool objectallow(string objectname)
        {
            DAL.DataSet_AuthenticationTableAdapters.SelectUserAllowTableAdapter adp =
                new DAL.DataSet_AuthenticationTableAdapters.SelectUserAllowTableAdapter();
            //تنظیم فرد تایید کننده
            BLL.csRegisteringGroup re = new csRegisteringGroup();
            RegistringGroup_ = re.RegistringGroupx_(objectname, out xSupplierby_, out xApproveby_, out  xRegisterby_);

            DataTable dt = adp.GetData(objectname, userid);
            if (BLL.authentication.xGroup_ == 2)
            {
                InsertData = true;
                UpdateData = true;
                DeleteData = true;
                return true;
            }
            if (dt.Rows[0]["Ins"].ToString() != "" && dt.Rows[0]["Upd"].ToString() != "" && dt.Rows[0]["Del"].ToString() != "")
            {
                InsertData = (bool)dt.Rows[0]["Ins"];
                UpdateData = (bool)dt.Rows[0]["Upd"];
                DeleteData = (bool)dt.Rows[0]["Del"];
                return true;
            }
            else
            {
                InsertData = false; 
                UpdateData = false;
                DeleteData = false;
                return false;
            }
        }
        public DataTable SelectObjectListAllow()
        {
            DAL.DataSet_AuthenticationTableAdapters.SelectObjectAllowTableAdapter adp =
                new DAL.DataSet_AuthenticationTableAdapters.SelectObjectAllowTableAdapter();


            return adp.GetData(x_,xGroup_);
        }
        public bool ChangePassword(string NewPassword)
        {
            DAL.DataSet_LoginTableAdapters.QueriesTableAdapter qr = new DAL.DataSet_LoginTableAdapters.QueriesTableAdapter();
            qr.UpdateChangePassword(NewPassword, BLL.authentication.x_);
            return true;
        }
        public bool TestCurrentPass(string Pass)
        {
            DAL.DataSet_LoginTableAdapters.QueriesTableAdapter qr = new DAL.DataSet_LoginTableAdapters.QueriesTableAdapter();
            if (qr.QueryTestCurrentPass(Pass, x_) == x_)
                return true;
            else
                return false;
                
        }

        public DataTable SelectObjectUserCanAccessOrNot(int? xUser_, int? xGroup_)
        {
            DAL.DataSet_AuthenticationTableAdapters.SelectObjectUserCanAccessOrNotTableAdapter adp = 
                new DAL.DataSet_AuthenticationTableAdapters.SelectObjectUserCanAccessOrNotTableAdapter();
            return adp.GetData(xUser_,xGroup_);
        }

        public DataTable SlObjectUserAccess(int? xUser_)
        {
            DAL.DataSet_AuthenticationTableAdapters.SlObjectUserAccessTableAdapter adp = 
                new DAL.DataSet_AuthenticationTableAdapters.SlObjectUserAccessTableAdapter();
            return adp.GetData(xUser_);
        }

        

        public bool InsertAuthentication(int? xUser_, int? xGroup_, int? xObject_)
        {
            DAL.DataSet_AuthenticationTableAdapters.QueriesTableAdapter qr =
                new DAL.DataSet_AuthenticationTableAdapters.QueriesTableAdapter();
            qr.InsertAuthentication(xUser_, xGroup_, true, true, true, xObject_);
            return true;
        }
        public bool DeleteAuthentication(int? xUser_, int? xGroup_, int? xObject_)
        {
            DAL.DataSet_AuthenticationTableAdapters.QueriesTableAdapter qr =
                new DAL.DataSet_AuthenticationTableAdapters.QueriesTableAdapter();
            qr.DeleteAuthentication(xUser_, xObject_, xGroup_);
            return true;
        }

    }
}
