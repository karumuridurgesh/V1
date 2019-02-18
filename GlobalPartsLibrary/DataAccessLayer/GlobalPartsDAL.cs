using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using GTKUtilites.SessionUtils;
using GTKUtilites.HelpMethods;
using GTKUtilites.DataAccessLayer;

namespace GlobalPartsLibrary.DataAccessLayer
{
    internal class GlobalPartsDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
        internal DataTable GetCountryByCode(string code)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsComments = new DataSet();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@cty_code", code, ParameterDirection.Input);
                    dsComments = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCtyCd");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dbManager.AddParameters(0, "V_cty_code", code, ParameterDirection.Input);
                    dsComments = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMCtyCd", cursor);
                }

                DataTable dtComments = new DataTable();
                dtComments = dsComments.Tables[0];
                return dtComments;
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
        internal DataSet Open_CountrySetUp()
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


                    // string spCall = SessionObjects.obj.GlobalPropertiesObject.GetSPCall(dbManager, "Open_TSPCBPS");

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMCTYSUNEW");


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

                    string[] cursor = { "cv_1" };

                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMCTYSUNEW", cursor);
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

        internal int SaveCountrySetUp(string countryCode, string companyCode, string UserCode, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@cntryCode", countryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@cmpnyCode", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_cntryCode", countryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_cmpnyCode", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_SaveXML", xmlData, ParameterDirection.Input);
                }
                int res = 0;
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    res = Convert.ToInt32(dbManager.ExecuteScalar(CommandType.StoredProcedure, "GPCTYAttrib_Save"));
                }
                else
                {
                    //to do
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "GPCTYAttrib_Save");

                }

                return res;

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
        internal DataSet Save_GPCTYAttrib(string countryCode, string companyCode, string UserCode, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@cntryCode", countryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@cmpnyCode", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMCTYSUNEW");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_GPMCTYSUNEW");
                }
                else
                {
                    dbManager.AddParameters(0, "V_cntryCode", countryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_cmpnyCode", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_SaveXML", xmlData, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_GPMCTYSUNEW", cursor);
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
        internal DataTable GetOrgDefaults(string cntryCode, string company)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctycode", cntryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@company", company, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_ctycode", cntryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_company", company, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCTYSUNEW");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMCTYSUNEW", cursor);
                }
                DataTable dtOrg = new DataTable();
                dtOrg = dsOrg.Tables[0];
                return dtOrg;
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
        internal DataSet Open_CountryDocSetUp()
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


                    // string spCall = SessionObjects.obj.GlobalPropertiesObject.GetSPCall(dbManager, "Open_TSPCBPS");

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_CountryDocSetUp");


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

                    string[] cursor = { "cv_1" };

                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_CountryDocSetUp", cursor);
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

        internal DataTable GetCntryBaseDocCodes(string cntryCode, string company)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctycode", cntryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@company", company, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_ctycode", cntryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_company", company, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPCTYDOCPROP");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMCTYSUNEW", cursor);
                }
                DataTable dtOrg = new DataTable();
                dtOrg = dsOrg.Tables[0];
                return dtOrg;
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
        internal int SaveCountryDocSetUp(string countryCode, string companyCode, string UserCode, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CtyCode", countryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Company", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_CtyCode", countryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_Company", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_SaveXML", xmlData, ParameterDirection.Input);
                }
                int res = 0;
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "GPCTYDOCPROP_Save");
                }
                else
                {
                    //to do
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "GPCTYDOCPROP_Save");

                }

                return res;

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
        internal int SaveCountryTASetUp(string countryCode, string companyCode, string UserCode, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CtyCode", countryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Company", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_CtyCode", countryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_Company", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_SaveXML", xmlData, ParameterDirection.Input);
                }
                int res = 0;
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    res = Convert.ToInt32(dbManager.ExecuteScalar(CommandType.StoredProcedure, "gpctytaprop_save"));
                }
                else
                {
                    //to do
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "gpctytaprop_save");

                }

                return res;

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
        internal DataSet GetCntryDocSetUp(string cntryCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctycode", cntryCode, ParameterDirection.Input);
                    
                }
                else
                {
                    dbManager.AddParameters(0, "V_ctycode", cntryCode, ParameterDirection.Input);
                    
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPCTYDOCPROP");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPCTYDOCPROP", cursor);
                }
      
                return dsOrg;
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
        internal DataTable GetCntryTASetUp(string cntryCode, string company)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctycode", cntryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@company", company, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_ctycode", cntryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_company", company, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPCTYTAPROP ");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPCTYTAPROP", cursor);
                }
                DataTable dtOrg = new DataTable();
                dtOrg = dsOrg.Tables[0];
                return dtOrg;
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

        internal DataSet GetCntrySpecificDetails(string cntryCode, string company, int partID)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctycode", cntryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@cmpny", company, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@partID", partID, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_ctycode", cntryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_cmpny", company, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_partID", partID, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPPartCtyinfo");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPPartCtyinfo", cursor);
                }
                return dsOrg;
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
        internal DataSet GetGlobalPartMaster(string sMode, string sInputXml)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@Mode", sMode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@inputXml", sInputXml, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(3, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(3, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                }
                else
                {
                    dbManager.AddParameters(0, "V_Mode", sMode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_inputXml", sInputXml, ParameterDirection.Input);
                    dbManager.AddParameters(2, "c_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GlobalPartMaster");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GlobalPartMaster", cursor);
                }
                return dsOrg;
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

        internal DataSet Open_GlobalParts()
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


                    // string spCall = SessionObjects.obj.GlobalPropertiesObject.GetSPCall(dbManager, "Open_TSPCBPS");

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GlobalParts");


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

                    string[] cursor = { "cv_1" };

                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMCTYSUNEW", cursor);
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


        internal void SaveGPMaster(string companyCode, string partCode, string UserCode, string xmlData,string sCategory)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(5);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@cmpnyCode", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@PARTCODE", partCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@IsCategory", sCategory, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_cmpnyCode", companyCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_PARTCODE", partCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_IsCategory", sCategory, ParameterDirection.Input);
                }
                int res = 0;
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "GPPART_Save");
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    res = Convert.ToInt32(dbManager.ExecuteScalar(CommandType.StoredProcedure, "GPPART_Save"));
                }
                else
                {
                    //to do
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "GPPART_Save");

                }

                //return res;

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
        internal DataSet Fetch_GPRTS(int iPrtID)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(1);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@PRTID", iPrtID, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "GetPart_Details");

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GetPart_Details");

                }
                else
                {                    
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


        internal DataTable GetCategoryByCode(string code)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsComments = new DataSet();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@StoredValue", code, ParameterDirection.Input);
                    dsComments = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCgyCd");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dbManager.AddParameters(0, "V_cty_code", code, ParameterDirection.Input);
                    dsComments = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMCgyCd", cursor);
                }

                DataTable dtComments = new DataTable();
                dtComments = dsComments.Tables[0];
                return dtComments;
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
        internal DataTable GetCompanyByCode(string code)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsComments = new DataSet();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@StoredValue", code, ParameterDirection.Input);
                    dsComments = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCmpnyCd");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dbManager.AddParameters(0, "V_cty_code", code, ParameterDirection.Input);
                    dsComments = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMCmpnyCd", cursor);
                }

                DataTable dtComments = new DataTable();
                dtComments = dsComments.Tables[0];
                return dtComments;
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

        internal DataSet Open_CompanySetUp()
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


                    // string spCall = SessionObjects.obj.GlobalPropertiesObject.GetSPCall(dbManager, "Open_TSPCBPS");

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMCMPNYSUNEW");


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

                    string[] cursor = { "cv_1" };

                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMCMPNYSUNEW", cursor);
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
        internal DataSet Open_CategoryrySetUp()
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


                    // string spCall = SessionObjects.obj.GlobalPropertiesObject.GetSPCall(dbManager, "Open_TSPCBPS");

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMCTGYSUNEW");


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

                    string[] cursor = { "cv_1" };

                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMCTGYSUNEW", cursor);
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
        internal int SaveCategorySetUp(string categoryCode, string Category, string UserCode, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CtgyCode", categoryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Category", Category, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_CtgyCode", categoryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_Category", Category, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_SaveXML", xmlData, ParameterDirection.Input);
                }
                int res = 0;
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    res = Convert.ToInt32(dbManager.ExecuteScalar(CommandType.StoredProcedure, "GPCTGYAttrib_Save"));
                }
                else
                {
                    //to do
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "GPCTGYAttrib_Save");

                }

                return res;

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



        internal DataSet Save_GPCTGYAttrib(string categoryCode, string Category, string UserCode, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CtgyCode", categoryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Category", Category, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMCTGYSUNEW");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_GPMCTGYSUNEW");
                }
                else
                {
                    dbManager.AddParameters(0, "V_CtgyCode", categoryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_Category", Category, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_SaveXML", xmlData, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_GPMCTGYSUNEW", cursor);
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
        internal DataSet Save_GPCMPNYYAttrib(string companycode, string company, string UserCode, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CmpnyCode", companycode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Company", company, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", xmlData, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMCMPNYSUNEW");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_GPMCMPNYSUNEW");
                }
                else
                {
                    dbManager.AddParameters(0, "V_CmpnyCode", companycode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_Company", company, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_UserCode", UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_SaveXML", xmlData, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_GPMCMPNYSUNEW", cursor);
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
        internal DataTable GetCategorySetUp(string categoryCode, string Category)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctgycode", categoryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@category", Category, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_ctgycode", categoryCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_category", Category, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCTGYSUNEW");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMCTGYSUNEW", cursor);
                }
                DataTable dtOrg = new DataTable();
                dtOrg = dsOrg.Tables[0];
                return dtOrg;
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
        internal DataTable GetCompanySetUp(string companycode, string company)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@cmpnycode", companycode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@company", company, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_cmpnycode", companycode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_company", company, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCMPNYSUNEW");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMCMPNYSUNEW", cursor);
                }
                DataTable dtOrg = new DataTable();
                dtOrg = dsOrg.Tables[0];
                return dtOrg;
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
