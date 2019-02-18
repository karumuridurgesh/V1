using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.SessionUtils;
using GTKUtilites.DataAccessLayer;
using GTKUtilites.HelpMethods;
using System.Data;
using System.Configuration;

namespace GTKABWLibrary.DataAccessLayer
{
    public class ATFAdjustmentDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();

        internal DataSet Open_ABWATFADJ()
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(3);

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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWATFADJ");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWATFADJ");

                    if (dbManager.Parameters[0] != null)
                        SessionObjects.obj.GlobalPropertiesObject.UnId = dbManager.Parameters[0].Value.ToString();

                }
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

        internal DataSet Save_ABWATFADJ(string strMode, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(5);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);

                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@Mode", strMode, ParameterDirection.Input);

                }
                else
                {
                    dbManager.AddParameters(0, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "v_FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_Mode", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(5, "v_CommID", 0, ParameterDirection.InputOutput, 4);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWATFADJ");
                ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ABWATFADJ");

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

        internal DataSet Fetch_ABWATFADJ(string sMode, string sinputxml,string LocationId)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(8);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                        dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    else
                        dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.Input, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 50);

                    dbManager.AddParameters(3, "@Mode", sMode, ParameterDirection.Input, 1);
                    dbManager.AddParameters(4, "@inputXML", sinputxml, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@ModCode", SessionObjects.obj.GlobalPropertiesObject.ModCode, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@UserSessionID", System.Web.HttpContext.Current.Session.SessionID, ParameterDirection.Input);
                    dbManager.AddParameters(7, "@LocationId", LocationId, ParameterDirection.Input, 1);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWATFADJ");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWATFADJ");

                }
                else
                {

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

        internal DataSet ATFADJAction(string sMode, string sVal)
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
                        dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    else
                        dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.Input, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "@Mode", sMode, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@SAVEXML", sVal, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "ATFADJAction");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "ATFADJAction");
                }
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
