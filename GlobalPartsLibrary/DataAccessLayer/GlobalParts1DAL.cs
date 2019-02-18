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
    internal class GlobalParts1DAL
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
                    dsComments = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_CountryByCode");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dbManager.AddParameters(0, "V_cty_code", code, ParameterDirection.Input);
                    dsComments = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CountryByCode", cursor);
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

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_CountrySetUp");


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

                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_CountrySetUp", cursor);
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
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPCTYATTRIB");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPCTYATTRIB", cursor);
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
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPCTYATTRIB", cursor);
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

        internal DataSet GetCntrySpecificDetails(string cntryCode, string company, string partID)
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
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPPartCtyinfo1");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPPartCtyinfo1", cursor);
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

                dbManager.CreateParameters(12);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@Mode", sMode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@inputXml", sInputXml, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                        dbManager.AddParameters(3, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                    else
                        dbManager.AddParameters(3, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(4, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(4, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                    dbManager.AddParameters(5, "@Section", SessionObjects.obj.FilterPropertiesObject.SectionName, ParameterDirection.Input, 50);

                    dbManager.AddParameters(6, "@RecordsPerPage", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].RecordsPerPage, ParameterDirection.Input);

                    dbManager.AddParameters(7, "@PAGENUMBER", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].PAGENUMBER, ParameterDirection.Input);
                    dbManager.AddParameters(8, "@PParams", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].PParams, ParameterDirection.Input);
                    dbManager.AddParameters(9, "@TotRecords", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotRecords, ParameterDirection.InputOutput);
                    dbManager.AddParameters(10, "@TotPages", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotPages, ParameterDirection.InputOutput);
                    if (SessionObjects.obj.PropertiesObject1.Param1 != "" && SessionObjects.obj.PropertiesObject1.Param1 != null)
                        dbManager.AddParameters(11, "@Param1", SessionObjects.obj.PropertiesObject1.Param1, ParameterDirection.Input, 30);
                    else
                        dbManager.AddParameters(11, "@Param1", DBNull.Value, ParameterDirection.Input, 30);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GlobalPartMaster1");
                //else
                //{
                //    dbManager.AddParameters(0, "V_Mode", sMode, ParameterDirection.Input);
                //    dbManager.AddParameters(1, "V_inputXml", sInputXml, ParameterDirection.Input);
                //    dbManager.AddParameters(2, "c_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                //}
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GlobalPartMaster1");
                }
                //else
                //{
                //    string[] cursor = { "cv_1" };
                //    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GlobalPartMaster", cursor);
                //}
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


                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GlobalParts1");

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GlobalParts1");


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

                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GlobalParts1", cursor);
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
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "GPPART1_Save");
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    res = Convert.ToInt32(dbManager.ExecuteScalar(CommandType.StoredProcedure, "GPPART1_Save"));
                }
                else
                {
                    //to do
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "GPPART1_Save");

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

        internal DataSet Get_CNTRYHTS(string XML, string Cntry, string Descr)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsOrg = new DataSet();

                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@inputXml", XML, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Cntry", Cntry, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Descr", Descr, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "V_ctycode", XML, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_cmpny", Cntry, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_partID", Descr, ParameterDirection.Input);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Get_CNTRYHTS");
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsOrg = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Get_CNTRYHTS");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    dsOrg = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Get_CNTRYHTS", cursor);
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

        internal DataSet Open_PARTSUM()
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
                        dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                    else
                        dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.InputOutput, 100);
                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                    dbManager.AddParameters(2, "@ModCode", SessionObjects.obj.GlobalPropertiesObject.ModCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_PARTSUM");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_PARTSUM");
                }
                else
                {
                    string[] cursor = { "cv_1" };
                    if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                        dbManager.AddParameters(0, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                    else
                        dbManager.AddParameters(0, "v_returnUniqueKey", DBNull.Value, ParameterDirection.InputOutput, 100);
                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "v_FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(1, "v_FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                    dbManager.AddParameters(2, "v_ModCode", SessionObjects.obj.GlobalPropertiesObject.ModCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);

                    da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_PARTSUM", cursor);
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
        


        internal string GPHTSNotification_SKU(string xmlData, string CNTY, string NewHTS, string HTS, string actiontype, string UserCode)
        {

            string res = string.Empty;
            string reutrnval = string.Empty;
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(7);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@returnVal ", string.Empty, ParameterDirection.Output, 150);
                    dbManager.AddParameters(6, "@UserCode", UserCode , ParameterDirection.Input);
                    dbManager.AddParameters(1, "@CNTY", CNTY, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@NewHTS", NewHTS, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@HTS", HTS, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@ActionType", actiontype, ParameterDirection.Input);
                }
                else
                {
                    //
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPHTSNotification_SKU");
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "Save_GPHTSNotification_SKU");
                   
                    if (dbManager.Parameters[5].Value.ToString() != "")
                        reutrnval = dbManager.Parameters[5].Value.ToString();
                    else
                        reutrnval = string.Empty;
                }
                else
                {

                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "Save_GPHTSNotification_SKU");

                }

                return reutrnval;

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

        internal DataSet Open_GPHTSNotification_SKU(string CmpID, string Cnty)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {

                    dbManager.AddParameters(0, "@CmpID", CmpID, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@CNTY", Cnty, ParameterDirection.Input, 10);
                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPHTSNotification_SKU");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPHTSNotification_SKU");
                }
                else
                {
                   //
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
