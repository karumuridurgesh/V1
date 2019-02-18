using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.DataAccessLayer;
using System.Data;
using System.Configuration;
using GTKUtilites.SessionUtils;
using GTKUtilites.HelpMethods;

namespace GlobalPartsLibrary.DataAccessLayer
{
    public class PartSummaryDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
        internal DataSet Fetch_GPMPARTSUM(string sPKvalue, string FromDate, string TODate, string Value)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(4);
                DataSet ds = new DataSet();
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@sPKvalue", sPKvalue, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@FromDate", FromDate, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@TODate", TODate, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@Value", Value, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMPARTSUM");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMPARTSUM");

                }
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
                //return null;
            }
            finally
            {
                dbManager.Dispose();
            }
        }
        internal DataSet Fetch_HTSDataToExcel(string CtyCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                DataSet ds = new DataSet();
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CtyCode", CtyCode, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_HTSDataToExcel");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_HTSDataToExcel");

                }
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
                //return null;
            }
            finally
            {
                dbManager.Dispose();
            }
        }
        #region GP latest changes by Madhu
        internal DataSet Save_PARTVSSRVREQ(string sMode, string sSaveXml, string InputParam)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                int res = 0;
                dbManager.Open();
                dbManager.CreateParameters(4);
                DataSet ds = new DataSet();
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@Mode", sMode, ParameterDirection.Input, 10);
                    dbManager.AddParameters(2, "@SAVEXML", sSaveXml, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@InputParam", InputParam, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_PARTVSSRVREQ");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_PARTVSSRVREQ");

                }
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
                //return null;
            }
            finally
            {
                dbManager.Dispose();
            }
        }

        #endregion
        internal DataSet Open_GPSUM()
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);
                if (ConfigurationSettings.AppSettings["DataB"] == "SQL")
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
                    dbManager.AddParameters(3, "@ModCode", SessionObjects.obj.GlobalPropertiesObject.ModCode, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPSUM");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPSUM");

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

    }
}
