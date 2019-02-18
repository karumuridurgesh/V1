using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;


namespace GTKABWLibrary.BusinessLogicLayer
{
   public class LocationBLL
    {
       LocationDAL clsLocDAl = new LocationDAL();

       public DataSet Open_ABWMSTLOC()
       {
           try
           {
               return clsLocDAl.Open_ABWMSTLOC();
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }

       public DataSet Save_ABWMSTLOC(string strMode, string xmlData)
       {
           try
           {
               return clsLocDAl.Save_ABWMSTLOC(strMode, xmlData);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public DataSet Fetch_ABWMSTLOC(string strMode, string xmlData)
       {
           try
           {
               return clsLocDAl.Fetch_ABWMSTLOC(strMode, xmlData);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public DataSet Open_PagingGrid()
       {
           try
           {
               return clsLocDAl.Open_PagingGrid();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public DataSet LocationAction(string sMode, string sval1)
       {
           try
           {
               return clsLocDAl.LocationAction(sMode, sval1);
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }

       public DataSet Fetch_ABWLocDepts(string Mode, string DeptCds)
       {
           try
           {
               return clsLocDAl.Fetch_ABWLocDepts(Mode, DeptCds);
           }
           catch (Exception ex)
           {

               throw ex;
           }
       }

    }
}
