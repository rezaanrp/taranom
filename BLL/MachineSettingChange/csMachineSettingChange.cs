using System;

namespace BLL.MachineSettingChange
{
    public  class csMachineSettingChange
    {
        public DAL.MachineSettingChange.DataSet_MachineSettingChange.mMachineSettingChangeDataTable MachineSettingChange(string DateFrom,string DateTo)
        {
            DAL.MachineSettingChange.DataSet_MachineSettingChangeTableAdapters.mMachineSettingChangeTableAdapter
                adp = new DAL.MachineSettingChange.DataSet_MachineSettingChangeTableAdapters.mMachineSettingChangeTableAdapter();
            return adp.GetData(DateFrom,DateTo);
        }
        public string UdMachineSettingChange(DAL.MachineSettingChange.DataSet_MachineSettingChange.mMachineSettingChangeDataTable dt)
        {
            try
            {
                DAL.MachineSettingChange.DataSet_MachineSettingChangeTableAdapters.mMachineSettingChangeTableAdapter
                    adp = new DAL.MachineSettingChange.DataSet_MachineSettingChangeTableAdapters.mMachineSettingChangeTableAdapter();
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
