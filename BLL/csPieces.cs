using System;
using System.Data;

namespace BLL
{
    public class csPieces
    {

       public DataTable SlPiecesList(string xName,string WorkYear)
       {
           DAL.Pieces.DataSet_PiecesTableAdapters.SlPiecesListTableAdapter adp =
               new DAL.Pieces.DataSet_PiecesTableAdapters.SlPiecesListTableAdapter();
           DataTable dt = adp.GetData(xName,WorkYear);
           return dt;
       }

       public DataTable SlMuscle()
       {
           DAL.DataSet_PieceTableAdapters.SlMuscleTableAdapter adp =
               new DAL.DataSet_PieceTableAdapters.SlMuscleTableAdapter();
            DataTable dt = adp.GetData();
            return dt;
       }
       public DataTable mPiecesDataTable(int xGenFactoryGroup)
       {
           DAL.DataSet_PieceTableAdapters.mPiecesTableAdapter adp = 
               new DAL.DataSet_PieceTableAdapters.mPiecesTableAdapter();
            DataTable dt = adp.GetData(xGenFactoryGroup);
            return dt;
       }

       public DAL.DataSet_Piece.SelectPiecesByNameDataTable SelectPiecesByName(string st,int GenGroup_)
       {
           DAL.DataSet_PieceTableAdapters.SelectPiecesByNameTableAdapter adp =
               new DAL.DataSet_PieceTableAdapters.SelectPiecesByNameTableAdapter();
           return adp.GetData(st, GenGroup_);
       }
       public DAL.Pieces.DataSet_Pieces.PiecesTurnedDataTable PiecesTurned()
       {
           DAL.Pieces.DataSet_PiecesTableAdapters.PiecesTurnedTableAdapter adp =
               new DAL.Pieces.DataSet_PiecesTableAdapters.PiecesTurnedTableAdapter();
           return adp.GetData();
       }
       public bool UpdatePiecesByName(DAL.DataSet_Piece.SelectPiecesByNameDataTable dt)
       {
           try
           {
               DAL.DataSet_PieceTableAdapters.SelectPiecesByNameTableAdapter adp =
                   new DAL.DataSet_PieceTableAdapters.SelectPiecesByNameTableAdapter();
               adp.Update(dt);
               return true;
           }
           catch (Exception)
           {

               return false;
           }

       }

       public bool SyncPieces()
       {
           try
           {
               DAL.DataSet_PieceTableAdapters.QueriesTableAdapter adp
                   = new DAL.DataSet_PieceTableAdapters.QueriesTableAdapter();
               adp.SyncPieces();
               return true;
           }
           catch (Exception)
           {
               return false;
           }
       }
    }
}
