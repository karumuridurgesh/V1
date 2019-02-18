using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using GTKUtilites.SessionUtils;
using GTKUtilites.DataAccessLayer;
using GTKUtilites.HelpMethods;

namespace GlobalPartsLibrary.DataAccessLayer
{
    public class ClassificationDAL:IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);

        }
        internal DataSet Open_GPWizard(string sCtyCode)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(11);

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
                    dbManager.AddParameters(2, "@Section", SessionObjects.obj.FilterPropertiesObject.SectionName, ParameterDirection.Input, 50);

                    dbManager.AddParameters(3, "@RecordsPerPage", 10, ParameterDirection.Input);

                    dbManager.AddParameters(4, "@PAGENUMBER", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].PAGENUMBER, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@PParams", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].PParams, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@TotRecords", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotRecords, ParameterDirection.InputOutput);
                    dbManager.AddParameters(7, "@TotPages", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotPages, ParameterDirection.InputOutput);
                    dbManager.AddParameters(8, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    if (SessionObjects.obj.PropertiesObject1.Param1 != "" && SessionObjects.obj.PropertiesObject1.Param1 != null)
                        dbManager.AddParameters(9, "@Param1", SessionObjects.obj.PropertiesObject1.Param1, ParameterDirection.Input, 30);
                    else
                        dbManager.AddParameters(9, "@Param1", DBNull.Value, ParameterDirection.Input, 30);
                    dbManager.AddParameters(10, "@ctyCode", sCtyCode, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPMCLASSWIZ");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMCLASSWIZ");

                }
                else
                {
                }


                if (dbManager.Parameters[0] != null)
                    SessionObjects.obj.GlobalPropertiesObject.UnId = dbManager.Parameters[0].Value.ToString();
                if (dbManager.Parameters[6].Value.ToString() != "")
                    SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotRecords = Convert.ToInt32(dbManager.Parameters[6].Value);

                if (dbManager.Parameters[7].Value.ToString() != "")
                    SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotPages = Convert.ToInt32(dbManager.Parameters[7].Value);


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

        internal DataSet Open_GPECCNWizard(string sCtyCode)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(11);

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
                    dbManager.AddParameters(2, "@Section", SessionObjects.obj.FilterPropertiesObject.SectionName, ParameterDirection.Input, 50);
                    dbManager.AddParameters(3, "@RecordsPerPage", 10, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@PAGENUMBER", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].PAGENUMBER, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@PParams", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].PParams, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@TotRecords", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotRecords, ParameterDirection.InputOutput);
                    dbManager.AddParameters(7, "@TotPages", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotPages, ParameterDirection.InputOutput);
                    dbManager.AddParameters(8, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    if (SessionObjects.obj.PropertiesObject1.Param1 != "" && SessionObjects.obj.PropertiesObject1.Param1 != null)
                        dbManager.AddParameters(9, "@Param1", SessionObjects.obj.PropertiesObject1.Param1, ParameterDirection.Input, 30);
                    else
                        dbManager.AddParameters(9, "@Param1", DBNull.Value, ParameterDirection.Input, 30);
                    dbManager.AddParameters(10, "@ctyCode", sCtyCode, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPMECCNCLASSWIZ");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMECCNCLASSWIZ");
                }                
                if (dbManager.Parameters[0] != null)
                    SessionObjects.obj.GlobalPropertiesObject.UnId = dbManager.Parameters[0].Value.ToString();
                if (dbManager.Parameters[6].Value.ToString() != "")
                    SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotRecords = Convert.ToInt32(dbManager.Parameters[6].Value);
                if (dbManager.Parameters[7].Value.ToString() != "")
                    SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotPages = Convert.ToInt32(dbManager.Parameters[7].Value);
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
        internal DataSet Fetch_Duties(string sHTSCode, string sCountry, string ChapterNo, string type)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@hts_code", sHTSCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@cty_code", sCountry, ParameterDirection.Input, 100);
                    dbManager.AddParameters(2, "@ChapterNo", ChapterNo, ParameterDirection.Input, 1);
                    dbManager.AddParameters(3, "@type", type, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMHtsDuties");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMHtsDuties");

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
        internal DataSet Fetch_GPWizard(string sMode, string sValue, string sCountry)
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
                    dbManager.AddParameters(3, "@Mode", sMode, ParameterDirection.Input, 1);
                    dbManager.AddParameters(4, "@inputXml", sValue, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@ctyCode", sCountry, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMCLASSWIZ");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCLASSWIZ");
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
        internal DataSet Fetch_Notes(string ChapterNo, string type)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ChapterNo", ChapterNo, ParameterDirection.Input, 1);
                    dbManager.AddParameters(1, "@type", type, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ChapterNotes");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ChapterNotes");
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
        internal int SAVE_GPBM(string sMode, string sSaveXmdata)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(6);
                int res = 0;
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", sSaveXmdata, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@EQID", 0, ParameterDirection.InputOutput, 4);
                    dbManager.AddParameters(5, "@Mode", sMode, ParameterDirection.Input, 1);
                }
                else
                {
                    dbManager.AddParameters(0, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);

                    dbManager.AddParameters(1, "v_FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_SaveXML", sSaveXmdata, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_EQID", 0, ParameterDirection.InputOutput, 4);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMCLASSWIZBM");
                dbManager.ExecuteScalar(CommandType.StoredProcedure, "Save_GPMCLASSWIZBM");
                res = Convert.ToInt32(dbManager.Parameters[4].Value.ToString());
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
        internal DataSet Fetch_HTSTree(string sCountry, string user, char cMode)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(3);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctyCode", sCountry, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@UserCode", user, ParameterDirection.Input, 100);
                    dbManager.AddParameters(2, "@mode", cMode, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMCLASSWIZData");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCLASSWIZData");

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

        internal DataSet Fetch_HTSECCNTree(string sCountry, string CatCode, string user, string SearchECCN, char cMode)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(5);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctyCode", sCountry, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@catCode", CatCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(2, "@UserCode", user, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "@SearchECCN", SearchECCN, ParameterDirection.Input, 100);
                    dbManager.AddParameters(4, "@mode", cMode, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMECCNCLASSWIZData");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMECCNCLASSWIZData");

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
        internal DataSet Fetch_GPStepByStep(int QuesNo, string sSelQues,string sProcType,int StepId,int ProcessId,string HTSNo)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(7);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {                    
                    //dbManager.AddParameters(0, "@Mode", sMode, ParameterDirection.Input);
                    //dbManager.AddParameters(1, "@Val1", sValue, ParameterDirection.Input);                   
                    dbManager.AddParameters(0, "@QuestionNo", QuesNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@SelectedQuestion", sSelQues, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@ProcessType", sProcType, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@StepID", StepId, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@ProcessId", ProcessId, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@HTSNo", HTSNo, ParameterDirection.Input); 
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMStepByStep");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMStepByStep");
                }
                else
                {

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
        internal int Save_PartHTS(string sMode, string sSaveXmdata, string sCompany, string sPart)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(8);
                int res = 0;
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@SaveXML", sSaveXmdata, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@EQID", 0, ParameterDirection.InputOutput, 4);
                    dbManager.AddParameters(5, "@Mode", sMode, ParameterDirection.Input, 1);
                    dbManager.AddParameters(6, "@cmpnyCode", sCompany, ParameterDirection.Input, 100);
                    dbManager.AddParameters(7, "@partCode", sPart, ParameterDirection.Input, 100);
                }
                else
                {
                    dbManager.AddParameters(0, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);

                    dbManager.AddParameters(1, "v_FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_SaveXML", sSaveXmdata, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_EQID", 0, ParameterDirection.InputOutput, 4);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMCLASSWIZPartHTS");
                dbManager.ExecuteScalar(CommandType.StoredProcedure, "Save_GPMCLASSWIZPartHTS");
                res = Convert.ToInt32(dbManager.Parameters[4].Value.ToString());
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
        internal DataSet Get_PartHTS(string sCompany, string sPart)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctyCode", sCompany, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@partID", sPart, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Get_PartHTS");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Get_PartHTS");

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
        internal DataSet GET_PArt()
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(0);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "GET_PArt");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_PArt");

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
        internal DataSet Fetch_GPwizardHTSGet(string TID, string Country)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {                    
                
                    dbManager.AddParameters(0, "@TID", TID, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Country", Country, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPwizardHTSGet");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPwizardHTSGet");
                }
                else
                {

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

        internal DataSet Fetch_GPwizardECCNGet(string TID, string Country)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {

                    dbManager.AddParameters(0, "@TID", TID, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Country", Country, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPwizardECCNGet");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPwizardECCNGet");
                }
                else
                {

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
        internal DataSet Search_GPMCLASSWIZBM(string Search, string Country, string Companycd)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {

                    dbManager.AddParameters(0, "@Search", Search, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Country", Country, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Companycd", Companycd, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Search_GPMCLASSWIZBM");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Search_GPMCLASSWIZBM");
                }
                else
                {

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
        public DataSet Fetch_TariffData(string CntyCode, string HTS)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CntyCode", CntyCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@HTS", HTS, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_TariffData");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_TariffData");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Fetch_GpRulingYear(string ctyCode)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctyCode", ctyCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@UserCode",  SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "fetch_GpRulingYear");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "fetch_GpRulingYear");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Fetch_GpRulingMonth(string ctyCode, string year)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctyCode", ctyCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@year", year, ParameterDirection.Input, 100);
                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "fetch_GpRulingMonth");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "fetch_GpRulingMonth");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Fetch_GpRulingData(string ctyCode, string RulMonth ,String Rulyear )
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ctyCode", ctyCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@RulMonth", RulMonth, ParameterDirection.Input, 100);
                    dbManager.AddParameters(2, "@year", Rulyear, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "fetch_GpRulingData");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "fetch_GpRulingData");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataSet Fetch_RulingClassificationData(string Country, String RulNo)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CountryCd", Country, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@RulingNo", RulNo, ParameterDirection.Input, 100);
                    //dbManager.AddParameters(3, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_RulingClassificationData");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_RulingClassificationData");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Fetch_SearchResultRuling(string Search,string Country)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@Search", Search, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@CountryCd", Country, ParameterDirection.Input, 100);
                    //dbManager.AddParameters(3, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_SearchResultRuling");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_SearchResultRuling");
                }
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet Fetch_GPMCLASSWIZRulingsByHTS(string Country, string HTS, string Type,string RulMonth,string RulYear)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(5);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CountryCd", Country, ParameterDirection.Input, 5);
                    dbManager.AddParameters(1, "@HTS", HTS, ParameterDirection.Input, 20);
                    dbManager.AddParameters(2, "@Type", Type, ParameterDirection.Input, 2);
                    if (RulMonth != null && RulMonth != "")
                        dbManager.AddParameters(3, "@RulMonth", RulMonth, ParameterDirection.Input);
                    else
                        dbManager.AddParameters(3, "@RulMonth", DBNull.Value, ParameterDirection.Input);
                    if (RulYear != null && RulYear != "")
                        dbManager.AddParameters(4, "@RulYear", RulYear, ParameterDirection.Input);
                    else
                        dbManager.AddParameters(4, "@RulYear", DBNull.Value, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMCLASSWIZRulingsByHTS");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCLASSWIZRulingsByHTS");
                }
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet Open_HtsNotifUpd()
        {
            try
            {

                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(2);

                if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                    dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                else
                    dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.InputOutput, 100);

                if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                    dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                else
                    dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_HtsNotifUpd");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_HtsNotifUpd");
                }
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet Fetch_GPMCLASSWIZRulingsDesc(string RulingId,string Type)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    //dbManager.AddParameters(0, "@CountryCd", Country, ParameterDirection.Input, 100);
                    dbManager.AddParameters(0, "@RulingId", RulingId, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@Type", Type, ParameterDirection.Input, 100);
                    //dbManager.AddParameters(3, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMCLASSWIZRulingsDesc");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMCLASSWIZRulingsDesc");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
