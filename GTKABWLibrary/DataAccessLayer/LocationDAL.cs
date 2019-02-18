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


    public class LocationDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
        internal DataSet Open_ABWMSTLOC()
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWMSTLOC");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWMSTLOC");
                }
                else
                {
                    if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                        dbManager.AddParameters(0, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                    else
                        dbManager.AddParameters(0, "v-returnUniqueKey", DBNull.Value, ParameterDirection.InputOutput, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "v_FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(1, "v_FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "v_Section", "", ParameterDirection.Input, 50);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_ABWMSTLOC", cursor);
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

        internal DataSet Save_ABWMSTLOC(string strMode, string xmlData)
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
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWLOC");
                ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ABWLOC");

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

        internal DataSet Fetch_ABWMSTLOC(string sMode, string sinputxml)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(7);

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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWMSTLOC");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWMSTLOC");

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
                //return null;
            }
            finally
            {
                dbManager.Dispose();
            }
        }


        internal DataSet Open_PagingGrid()
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
                    // dbManager.AddParameters(3, "@ListCode", ListCode, ParameterDirection.Input);

                    // string spCall = Helper.Ins.GetSPCall((dbManager.Parameters, "Open_Grid");
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWLocDept");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWLocDept");

                    if (dbManager.Parameters[0] != null)
                        SessionObjects.obj.GlobalPropertiesObject.UnId = dbManager.Parameters[0].Value.ToString();

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

        internal DataSet LocationAction(string sMode, string sVal)
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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "LocationAction");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "LocationAction");
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


        internal DataSet Fetch_ABWLocDepts(string Mode, string DeptCds)
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
                    dbManager.AddParameters(3, "@Mode", Mode, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@DeptCds", DeptCds, ParameterDirection.Input);


                }
                else
                {


                    if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                        dbManager.AddParameters(0, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    else
                        dbManager.AddParameters(0, "v_returnUniqueKey", DBNull.Value, ParameterDirection.Input, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "v_FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(1, "v_FTECODE", DBNull.Value, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);

                    dbManager.AddParameters(3, "v_Mode", Mode, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_DeptCds", DeptCds, ParameterDirection.Input);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWLocDepts");
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWLocDepts");
                }
                else
                {
                    string[] cursor = { "cv_1", "cv_2", "cv_3" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_ABWLocDepts", cursor);
                }


                DataTable dt = new DataTable();

                dt = ds.Tables[0];

                return ds;
            }
            catch (Exception ex)
            {
                //throw ex;
                return null;
            }
            finally
            {
                dbManager.Dispose();
            }
        }
    }
}
