using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
   public class ManufactureSummaryBLL
    {
       ManufactureSummaryDAL clsDAL =new ManufactureSummaryDAL();
       public DataSet Open_GPMFGSUM()
       {
           try
           {
               return clsDAL.Open_GPMFGSUM();
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }
       public string Save_GPMFGSUM(string sSaveXml)
       {
           try
           {
               return clsDAL.Save_GPMFGSUM(sSaveXml);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
