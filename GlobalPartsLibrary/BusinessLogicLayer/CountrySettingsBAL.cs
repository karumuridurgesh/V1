using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.Extensions;
using GTKUtilites.HelpMethods;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
  public  class CountrySettingsBAL
    {

      CountrySettingsDAL obj = new CountrySettingsDAL();
      public DataSet Open_CountrySettings(string Cmpanycode)
      {
          try
          {
              DataSet ds;
              ds= obj.Open_CountrySettings(Cmpanycode);
              return ds;
          }
          catch(Exception ex)
          {
              throw ex;
          }
      }
      //public DataSet FetchCompanycode(string Companycode)
      //{
      //    try
      //    {
      //        DataSet ds;
      //        ds = obj.FetchCompanycode(Companycode);
      //        return ds;
      //    }
      //    catch (Exception ex)
      //    {
      //        throw ex;
      //    }
      //}
      public int Save_Country(string Cmpny,string Mode,string xmldata )
      {
          return obj.Save_Country(Cmpny,Mode,xmldata);
      }
    }
}
