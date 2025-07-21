using System.Data;

namespace BLL.State
{
    public class csState
    {
       public DataTable mState()
       {
           DAL.State.DataSet_StateTableAdapters.mStateTableAdapter adp
               = new DAL.State.DataSet_StateTableAdapters.mStateTableAdapter();
           return adp.GetData();
       }
    }
}
