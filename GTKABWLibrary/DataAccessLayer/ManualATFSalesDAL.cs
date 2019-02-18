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
    class ManualATFSalesDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
        internal DataSet Open_ABWMATFS()
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWMATFS");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWMATFS");
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
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_ABWMATFS", cursor);
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

        internal DataSet Save_ABWMATFS(string strMode, string xmlData)
        {
            //Configuration myConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~");
            //myConfig.AppSettings.Settings["DataB"].Value = "Oracle";
            //myConfig.Save();
            IDBManager dbManager = CommonConnection.Connectionstring();
            //IDBManager dbManager = GTKGlobalValues.Connectionstring();
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWMATFS");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ABWMATFS");
                }
                else
                {
                    string[] cursor = { "C_Result", "C_TranAtfSalesHDR", "C_TranAtfSalesDTL" };
                    dbManager.AddParameters(0, "V_strMode", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_xmlData", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    //dbManager.AddParameters(3, "C_Result", cursor[0], ParameterDirection.Output);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWMATFS");
                    //return da.ExecuteOracleNonQuery1(dbManager, CommandType.StoredProcedure, "Save_ABWMATFS");
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_ABWMATFS", cursor);
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

        internal DataSet Get_LOV(string LOVQualifier, string FteCode, string SectionName, string FieldName, string EnteredXML)
        {
            IDBManager dbManager = GTKGlobalValues.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(7);

                string[] cursor = { "C_LOVResult", "C_LOVPro", "C_LOVFilters", "C_TotRec" };
                dbManager.AddParameters(0, "V_LOVQualifier", LOVQualifier, ParameterDirection.Input);
                dbManager.AddParameters(1, "V_FteCode", FteCode, ParameterDirection.Input);
                dbManager.AddParameters(2, "V_SectionName", SectionName, ParameterDirection.Input);
                dbManager.AddParameters(3, "V_FieldName", FieldName, ParameterDirection.Input);
                dbManager.AddParameters(4, "V_PAGENUMBER", SessionObjects.obj.LOVInputDataObject[SessionObjects.obj.GlobalPropertiesObject.LOVIndex].PAGENUMBER, ParameterDirection.Input);
                dbManager.AddParameters(5, "V_xmlData", EnteredXML, ParameterDirection.Input);
                dbManager.AddParameters(6, "V_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                //dbManager.AddParameters(5, "V_TotRecords", SessionObjects.obj.LOVInputDataObject[SessionObjects.obj.GlobalPropertiesObject.LOVIndex].TotRecords, ParameterDirection.InputOutput);
                //dbManager.AddParameters(6, "V_TotPages", SessionObjects.obj.LOVInputDataObject[SessionObjects.obj.GlobalPropertiesObject.LOVIndex].TotPages, ParameterDirection.InputOutput);
                //dbManager.AddParameters(4, "C_LOVResult", cursor[0], ParameterDirection.Output);
                //dbManager.AddParameters(5, "C_LOVPro", cursor[1], ParameterDirection.Output);
                //dbManager.AddParameters(6, "C_LOVFilters", cursor[2], ParameterDirection.Output);

                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "GetLOV");
                ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GetLOV", cursor);
                if (ds.Tables.Count >= 4 && ds.Tables[3].Rows.Count > 0)
                {
                    SessionObjects.obj.LOVInputDataObject[SessionObjects.obj.GlobalPropertiesObject.LOVIndex].TotRecords = Convert.ToInt32(ds.Tables[3].Rows[0]["TotRecords"].ToString());
                    SessionObjects.obj.LOVInputDataObject[SessionObjects.obj.GlobalPropertiesObject.LOVIndex].TotPages = Convert.ToInt32(ds.Tables[3].Rows[0]["TotPages"].ToString());
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

        internal string Validate_EnteredValueString(string SectionName, string FieldName, string Qualifier, string EnteredXML)
        {
            IDBManager dbManager = GTKGlobalValues.Connectionstring();
            try
            {
                DataSet ds = new DataSet();
                dbManager.Open();

                dbManager.CreateParameters(6);

                string ReturnValue = "";
                string[] cursor = { "C_Result", "C_test" };
                dbManager.AddParameters(0, "V_FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input);
                dbManager.AddParameters(1, "V_SectionName", SectionName, ParameterDirection.Input);
                dbManager.AddParameters(2, "V_FieldName", FieldName, ParameterDirection.Input);
                dbManager.AddParameters(3, "V_Qualifier", Qualifier, ParameterDirection.Input);
                dbManager.AddParameters(4, "V_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                dbManager.AddParameters(5, "V_xmlData", EnteredXML, ParameterDirection.Input);
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "validateQry");

                ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "validateQry", cursor);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    ReturnValue = ds.Tables[0].Rows[0][0].ToString();
                }
                return ReturnValue;
            }
            catch (Exception ex)
            {
                //throw ex;
                return "";
            }
            finally
            {
                dbManager.Dispose();
            }
        }

        internal DataSet MATFSAction(string sMode, string sVal)
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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "MATFSAction");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "MATFSAction");
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

        internal DataSet Fetch_ABWMATFS(string sMode, string sinputxml)
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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWMATFS");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWMATFS");

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
