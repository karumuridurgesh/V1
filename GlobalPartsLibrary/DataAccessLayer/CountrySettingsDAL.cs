using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.SessionUtils;
using GTKUtilites.DataAccessLayer;
using GTKUtilites.HelpMethods;
using System.Data;
using System.Configuration;

namespace GlobalPartsLibrary.DataAccessLayer
{
   public class CountrySettingsDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
        internal DataSet Open_CountrySettings(string Cmpanycode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try

            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(5);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                        dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                    else
                        dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.InputOutput, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                    else
                        dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "@CmpCD", Cmpanycode, ParameterDirection.Input, 5);
                    dbManager.AddParameters(4, "@ModCode", SessionObjects.obj.GlobalPropertiesObject.ModCode, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPCountriesSettings");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPCountriesSettings");
                }                
                if (dbManager.Parameters[0] != null)
                    SessionObjects.obj.GlobalPropertiesObject.UnId = dbManager.Parameters[0].Value.ToString();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbManager.Dispose();
            }
        }
        //internal DataSet FetchCompanycode(string Companycode)
        //{
        //    IDBManager dbManager = CommonConnection.Connectionstring();
        //    try
        //    {
        //        dbManager.Open();
        //        dbManager.CreateParameters(1);
        //        DataSet ds = new DataSet();
        //        if (ConfigurationManager.AppSettings["DataB"] == "SQL")
        //        {
        //            dbManager.AddParameters(0, "@Companycode", Companycode, ParameterDirection.Input, 100);
        //        }
        //        if (ConfigurationManager.AppSettings["DataB"] == "SQL")
        //        {
        //            string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPCNSET");
        //            ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPCNSET");

        //        }
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        dbManager.Dispose();
        //    }

        //}
        internal int Save_Country(string Cmpny,string Mode,string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            dbManager.Open();
            dbManager.CreateParameters(6);
            if (ConfigurationManager.AppSettings["DataB"] == "SQL")
            {
                dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                dbManager.AddParameters(1, "@FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                dbManager.AddParameters(3, "@Cmpny", Cmpny, ParameterDirection.Input);
                dbManager.AddParameters(4, "@Mode", Mode, ParameterDirection.Input);
                dbManager.AddParameters(5, "@SaveXML", xmlData, ParameterDirection.Input);
                //dbManager.AddParameters(2, "@CountryCode", CountryCode, ParameterDirection.Input);

            }
            int res = 0;
            if (ConfigurationManager.AppSettings["DataB"] == "SQL")
            {
                string spCall = GTKUtilites.HelpMethods.Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPCountries");
                res = Convert.ToInt32(dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "Save_GPCountries"));
            }


            return res;
        }

    }
}
