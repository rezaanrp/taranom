using System;

namespace BLL.Register
{
    public  class csRegister
    {
        public DAL.Register.DataSet_User.mUserDataTable mUser()
        {
            DAL.Register.DataSet_UserTableAdapters.mUserTableAdapter 
                adp = new DAL.Register.DataSet_UserTableAdapters.mUserTableAdapter();
            return adp.GetData();
        }
        public string UdmUser(DAL.Register.DataSet_User.mUserDataTable dt)
        {
            try
            {
                DAL.Register.DataSet_UserTableAdapters.mUserTableAdapter
                    adp = new DAL.Register.DataSet_UserTableAdapters.mUserTableAdapter();
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
