using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;
namespace GTKABWLibrary.BusinessLogicLayer
{
   public class T7501BLL
    {
       T7501DAL clsT7501DAL = new T7501DAL();
       public DataSet Open_ABWT7501()
       {
           try
           {
               return clsT7501DAL.Open_ABWT7501();
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet Fetch_ABWT7501(string sMode, string xmlData)
       {
           try
           {
               return clsT7501DAL.Fetch_ABWT7501(sMode, xmlData);
           }
           catch (Exception ex)
           {
               throw ex;
           }

       }
       public DataSet Save_ABWT7501(string sMode, string xmlData)
       {
           try
           {
               return clsT7501DAL.Save_ABWT7501(sMode, xmlData);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet Fetch_ABWT7501Products(string sMode, string PrdCds, string Locid)
       {
           try
           {
               return clsT7501DAL.Fetch_ABWT7501Products(sMode, PrdCds, Locid);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataSet T7501Action(string Mode,string sVal)
       {
           try
           {
               return clsT7501DAL.T7501Action(Mode, sVal);
           }
           catch(Exception ex)
           {
               throw ex;
           }
       }
    }
}
