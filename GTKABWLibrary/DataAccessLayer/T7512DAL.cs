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
    public class T7512DAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();

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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWT7512Products");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWT7512Products");

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

        internal DataSet Save_ABWT7512(string strMode, string xmlData)
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
                dbManager.Command.CommandTimeout = 120;
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWTRAN7512");
                ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ABWTRAN7512");

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

        internal DataSet Fetch_ABWT7512Products(string Mode, string PrdCds, string Locid)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();

                dbManager.CreateParameters(6);


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
                    dbManager.AddParameters(4, "@PrdCds", PrdCds, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@Locid", Locid, ParameterDirection.Input);


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
                    dbManager.AddParameters(4, "v_PrdCds", PrdCds, ParameterDirection.Input);
                    dbManager.AddParameters(5, "v_Locid", Locid, ParameterDirection.Input);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_T7512Products");
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_T7512Products");
                }
                else
                {
                    string[] cursor = { "cv_1", "cv_2", "cv_3" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_T7512Products", cursor);
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

        internal DataSet T7512Action(string sMode, string sVal)
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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "T7512Action");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "T7512Action");
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

        internal DataSet Fetch_ABWT7512(string sMode, string sinputxml)
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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWT7512");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWT7512");

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

        internal DataSet GTKINBOUT(string sTranId, string sImpCode)
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
                        dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    else
                        dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@tranid", sTranId, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@ImpCode", sImpCode, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "GTKINBOUT");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GTKINBOUT");

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

        internal void Replace_CF7512(string OldCF7512, string NewCF7512, string Remarks)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@oldcf7512", OldCF7512, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@newcf7512", NewCF7512, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@userid", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@remarks", Remarks, ParameterDirection.Input);
                }
                //else
                //{
                //    dbManager.AddParameters(0, "@oldcf7512", OldCF7512, ParameterDirection.Input);
                //    dbManager.AddParameters(1, "@newcf7512", NewCF7512, ParameterDirection.Input);
                //    dbManager.AddParameters(2, "@userid", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                //    dbManager.AddParameters(3, "@remarks", Remarks, ParameterDirection.Input);
                //}
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "cf7512replacement");
                dbManager.ExecuteDataSet(CommandType.StoredProcedure, "cf7512replacement");

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

        internal DataSet Fetch_REPRNT7512(string BeginDate, string EndDate, string Invoice, string strMode, string xmlData)
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

                    dbManager.AddParameters(3, "@BeginDate", BeginDate, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@EndDate", EndDate, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@Invoice", Invoice, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@Mode", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(7, "@SaveXML", xmlData, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_REPRNT7512");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_REPRNT7512");

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

        internal DataSet Del_Fetchdel7512(string tranno)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);
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
                    dbManager.AddParameters(3, "@tranno", tranno, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Delete7512");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Delete7512");
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

        internal DataSet ABW_CancelT7512(string tranno)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);
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
                    dbManager.AddParameters(3, "@Tranno", tranno, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "ABW_CancelT7512");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "ABW_CancelT7512");
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

    }
}
