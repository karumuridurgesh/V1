using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GlobalPartsLibrary.DataAccessLayer;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
   public class CompositionSummaryBLL
    {
       CompositionSummaryDAL clsDAL = new CompositionSummaryDAL();
       public DataSet Open_CMPSUMRY()
       {
           try
           {
               DataSet ds;
               ds = clsDAL.Open_CMPSUMRY();
               return ds;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
