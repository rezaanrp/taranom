using System;

namespace BLL.PiecesCorrectiveMachining
{
    public class csPiecesCorrectiveMachining
    {
        public DAL.PiecesCorrectiveMachining.PiecesCorrectiveMachining.mPiecesCorrectiveMachiningDataTable mPiecesCorrectiveMachining(string DateFrom, string DateTo)
        {
            DAL.PiecesCorrectiveMachining.PiecesCorrectiveMachiningTableAdapters.mPiecesCorrectiveMachiningTableAdapter adp =
                new DAL.PiecesCorrectiveMachining.PiecesCorrectiveMachiningTableAdapters.mPiecesCorrectiveMachiningTableAdapter();
            return adp.GetData(DateFrom,DateTo);
        }

        public string UdPiecesCorrectiveMachining(DAL.PiecesCorrectiveMachining.PiecesCorrectiveMachining.mPiecesCorrectiveMachiningDataTable dt)
        {

            try
            {
                DAL.PiecesCorrectiveMachining.PiecesCorrectiveMachiningTableAdapters.mPiecesCorrectiveMachiningTableAdapter adp =
                    new DAL.PiecesCorrectiveMachining.PiecesCorrectiveMachiningTableAdapters.mPiecesCorrectiveMachiningTableAdapter();
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
