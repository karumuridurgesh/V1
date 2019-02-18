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
    class PartScreenDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
        internal DataSet Open_GPMGPSPTSRN(string HeaderId, string CmpID, string Mode)
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
                        dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                    else
                        dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.InputOutput, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                    else
                        dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "@HeaderId", HeaderId, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@CmpID", CmpID, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@Mode", Mode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPMGPSPTSRN");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMGPSPTSRN");
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
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMGPSPTSRN", cursor);
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
        internal DataSet Open_GPMGPHsEcSPTSRN(string HeaderId, string CmpID, string Mode,string CatCode)
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
                        dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                    else
                        dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.InputOutput, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                    else
                        dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "@HeaderId", HeaderId, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@CmpID", CmpID, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@Mode", Mode, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@CatCode", CatCode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPMGPHsEcSPTSRN");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMGPHsEcSPTSRN");
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
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMGPHsEcSPTSRN", cursor);
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
        public string GenerateMID(string Name, string Address, string CountryCode, string City)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(5);
                string sReturnMessage = "";
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@Name", Name, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Address", Address, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@CntryCode", CountryCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@City", City, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@OUTMID", sReturnMessage, ParameterDirection.InputOutput, 250);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Create_MID");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Create_MID");
                }
                sReturnMessage = dbManager.Parameters[4].Value.ToString();
                return sReturnMessage;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataSet Fetch_GpComposition(string PartType)
        {
            try
            {

                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@PartType", PartType, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GpComposition");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GpComposition");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }           
        }
        public DataSet  Fetch_TariffData(string CntyCode, string HTS)
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

        internal DataSet Fetch_GPSUGGESTHTS(string CntyCode, string HTS, string XML, string CmpCd,string RulingId)
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
                        dbManager.AddParameters(0, "@returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);
                    else
                        dbManager.AddParameters(0, "@returnUniqueKey", DBNull.Value, ParameterDirection.InputOutput, 100);

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                    else
                        dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(3, "@CntyCode", CntyCode, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@HTS", HTS, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@XML", XML, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@CmpCd",CmpCd, ParameterDirection.Input);
                    dbManager.AddParameters(7, "@RulingId", RulingId, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPSUGGESTEDHTS");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPSUGGESTEDHTS");
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


        internal DataSet Fetch_GPMGPSPTSRNAttr(string Mode, string LISTID, string GPPMHDRID, string GPMLVL,string sDelCatg)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(5);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@Mode", Mode, ParameterDirection.Input);
                    if (LISTID != "undefined")
                        dbManager.AddParameters(1, "@LISTID", LISTID, ParameterDirection.Input);
                    else
                    dbManager.AddParameters(1, "@LISTID", DBNull.Value, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@GPPMHDRID", GPPMHDRID, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@GPMLVL", GPMLVL, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@DelCatg", sDelCatg, ParameterDirection.Input);
                    
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMGPSPTSRNAttr");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNAttr");
                }
                else
                {
                    //dbManager.AddParameters(1, "v_CtgCd", CtgCd, ParameterDirection.Input, 100);
                    //string[] cursor = { "cv_1" };
                    //ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNCtgAttr", cursor);
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

        internal DataSet Fetch_GPMGPSPTSRNAttr1(string Mode, string LISTID, string GPPMHDRID, string GPMLVL, string sDelCatg, string CmpCd)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(6);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@Mode", Mode, ParameterDirection.Input);
                    if (LISTID != "undefined")
                        dbManager.AddParameters(1, "@LISTID", LISTID, ParameterDirection.Input);
                    else
                        dbManager.AddParameters(1, "@LISTID", DBNull.Value, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@GPPMHDRID", GPPMHDRID, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@GPMLVL", GPMLVL, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@DelCatg", sDelCatg, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@CmpID", CmpCd, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMGPSPTSRNAttr");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNAttr");
                }
                else
                {
                    //dbManager.AddParameters(1, "v_CtgCd", CtgCd, ParameterDirection.Input, 100);
                    //string[] cursor = { "cv_1" };
                    //ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNCtgAttr", cursor);
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

        internal DataSet Fetch_GPMGPHsEcSPTSRNAttr1 (string Mode, string LISTID, string GPPMHDRID, string GPMLVL, string sDelCatg, string CmpCd)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(6);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@Mode", Mode, ParameterDirection.Input);
                    if (LISTID != "undefined")
                        dbManager.AddParameters(1, "@LISTID", LISTID, ParameterDirection.Input);
                    else
                        dbManager.AddParameters(1, "@LISTID", DBNull.Value, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@GPPMHDRID", GPPMHDRID, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@GPMLVL", GPMLVL, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@DelCatg", sDelCatg, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@CmpID", CmpCd, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMGPHsEcSPTSRNAttr");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMGPHsEcSPTSRNAttr");
                }
                else
                {
                    //dbManager.AddParameters(1, "v_CtgCd", CtgCd, ParameterDirection.Input, 100);
                    //string[] cursor = { "cv_1" };
                    //ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNCtgAttr", cursor);
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

        internal DataSet Fetch_GPMGPSPTSRNCtgAttr(string CtgCd, string GPPMHDRID, string Mode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CtgCd", CtgCd, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@GPPMHDRID", GPPMHDRID, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Mode", Mode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMGPSPTSRNCtgAttr");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNCtgAttr");
                }
                else
                {
                    dbManager.AddParameters(1, "v_CtgCd", CtgCd, ParameterDirection.Input, 100);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNCtgAttr", cursor);
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

        internal DataSet Fetch_GPMGPSPTSRNCmpnyAttr(string CmpnyCd, string GPPMHDRID, string Mode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CmpnyCd", CmpnyCd, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@GPPMHDRID", GPPMHDRID, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Mode", Mode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMGPSPTSRNCmpnyAttr");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNCmpnyAttr");
                }
                else
                {
                    dbManager.AddParameters(1, "v_CmpnyCd", CmpnyCd, ParameterDirection.Input, 100);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMGPSPTSRNCmpnyAttr", cursor);
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
        internal string Validate_EnteredValueString(string SectionName, string FieldName, string Qualifier, string ValidationType, string EnteredValue, string EnteredXML)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                dbManager.CreateParameters(9);

                string ReturnValue = "";

                dbManager.AddParameters(0, "@FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input);
                dbManager.AddParameters(1, "@SectionName", SectionName, ParameterDirection.Input);
                dbManager.AddParameters(2, "@FieldName", FieldName, ParameterDirection.Input);
                dbManager.AddParameters(3, "@Qualifier", Qualifier, ParameterDirection.Input);
                dbManager.AddParameters(4, "@ValidationType", ValidationType, ParameterDirection.Input);
                if (EnteredValue != "")
                {
                    dbManager.AddParameters(5, "@EnteredValue", EnteredValue, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(5, "@EnteredValue", DBNull.Value, ParameterDirection.Input);
                }
                dbManager.AddParameters(6, "@EnteredXML", EnteredXML, ParameterDirection.Input);
                dbManager.AddParameters(7, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                dbManager.AddParameters(8, "@MODCD", SessionObjects.obj.GlobalPropertiesObject.ModCode, ParameterDirection.Input);

                string spCall = GTKUtilites.HelpMethods.Helper.Ins.GetSPCall(dbManager.Parameters, "Validate_EnteredValueString");
                ReturnValue = dbManager.ExecuteScalar(CommandType.StoredProcedure, "Validate_EnteredValueString").ToString();

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
        internal DataSet Fetch_GPMGPSPTSRN(string CmpnyCd, string Partno, string strMode, string ProfileName, 
            string ProfileId,string Psearch,string CountryCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(7);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CmpnyCd", CmpnyCd, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Partno", Partno, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Mode", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@ProfileName", ProfileName, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@ProfileId", ProfileId, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@Psearch", Psearch, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@CCode", CountryCode, ParameterDirection.Input);
                    
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMGPSPTSRN");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMGPSPTSRN");
                }
                else
                {
                    dbManager.AddParameters(0, "v_cpyCd", CmpnyCd, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "v_Partno", Partno, ParameterDirection.Input, 100);
                    dbManager.AddParameters(2, "v_Mode", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_ProfileName", ProfileName, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_ProfileId", ProfileId, ParameterDirection.Input);
                    dbManager.AddParameters(5, "v_Psearch", Psearch, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMGPSPTSRN", cursor);
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

        internal DataSet Fetch_GPMGPHsEcSPTSRN(string CmpnyCd, string Partno, string strMode, string ProfileName,
           string ProfileId, string Psearch, string CountryCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(7);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CmpnyCd", CmpnyCd, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Partno", Partno, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Mode", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@ProfileName", ProfileName, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@ProfileId", ProfileId, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@Psearch", Psearch, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@CCode", CountryCode, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMGPHsEcSPTSRN");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMGPHsEcSPTSRN");
                }
                else
                {
                    dbManager.AddParameters(0, "v_cpyCd", CmpnyCd, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "v_Partno", Partno, ParameterDirection.Input, 100);
                    dbManager.AddParameters(2, "v_Mode", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_ProfileName", ProfileName, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_ProfileId", ProfileId, ParameterDirection.Input);
                    dbManager.AddParameters(5, "v_Psearch", Psearch, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMGPHsEcSPTSRN", cursor);
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

        internal string  Save_GPMGPSPTSRN(string strXML, string strMode, byte[] byteImg, string Profile)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(6);
                string sReturnMessage = "";
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@strXML", strXML, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@usercode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@mode", strMode, ParameterDirection.Input);
                    if (byteImg!=null)
                        dbManager.AddParameters(3, "@Img", byteImg, ParameterDirection.Input);
                    else
                        dbManager.AddParameters(3, "@Img", DBNull.Value, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@Profile", Profile, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@OUT", sReturnMessage, ParameterDirection.InputOutput, 30);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMGPSPTSRN");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_GPMGPSPTSRN");
                }
                else
                {
                    dbManager.AddParameters(0, "v_cpyCd", strXML, ParameterDirection.Input, 100);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_GPMGPSPTSRN", cursor);
                }
                sReturnMessage = dbManager.Parameters[5].Value.ToString();
                return sReturnMessage;
             
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

        internal string Save_GPMGPHsEcSPTSRN(string strXML, string strMode, byte[] byteImg, string Profile,string isRvw)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(7);
                string sReturnMessage = "";
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@strXML", strXML, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@usercode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@mode", strMode, ParameterDirection.Input);
                    if (byteImg != null)
                        dbManager.AddParameters(3, "@Img", byteImg, ParameterDirection.Input);
                    else
                        dbManager.AddParameters(3, "@Img", DBNull.Value, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@Profile", Profile, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@OUT", sReturnMessage, ParameterDirection.InputOutput, 30);
                    dbManager.AddParameters(6, "@isRvw", isRvw, ParameterDirection.Input, 2);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMGPHsEcSPTSRN");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_GPMGPHsEcSPTSRN");
                }
                else
                {
                    dbManager.AddParameters(0, "v_cpyCd", strXML, ParameterDirection.Input, 100);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_GPMGPHsEcSPTSRN", cursor);
                }
                sReturnMessage = dbManager.Parameters[5].Value.ToString();
                return sReturnMessage;

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
        internal DataSet Fetch_GPMEccnChild(string EccnCd, string Mode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(3);
                string sReturnMessage = "";
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@EccnCd", EccnCd, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@usercode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Mode", Mode, ParameterDirection.Input);
                    

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMEccnChild");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMEccnChild");
                }
                else
                {
                    dbManager.AddParameters(0, "EccnCd", EccnCd, ParameterDirection.Input, 100);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMEccnChild", cursor);
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

        public DataSet Fetch_HTSDetails(string CntyCode, string HTS,string RulingId)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CntyCode", CntyCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@HTS", HTS, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@RulingId", RulingId, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_HTSDetails");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_HTSDetails");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Fetch_CategoryDetails(string CategoryCode)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CategoryCode", CategoryCode, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "FETCH_CATEGORYDETAILS");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "FETCH_CATEGORYDETAILS");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet Fetch_CatSummaryDetails(string strXML)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);               
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@usercode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);                  

                    dbManager.AddParameters(1, "@strXML", strXML, ParameterDirection.Input);                                    

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_CatSummaryDetails");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_CatSummaryDetails");
                }
                else
                {
                    dbManager.AddParameters(0, "v_cpyCd", strXML, ParameterDirection.Input, 100);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_CatSummaryDetails", cursor);
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


        public DataSet ValidateGPDepartments(string DeptCode)
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@DeptCode", DeptCode, ParameterDirection.Input, 10);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "ValidateGPDepartments");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "ValidateGPDepartments");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet FETCH_GPMstSettings()
        {
            try
            {
                IDBManager dbManager = CommonConnection.Connectionstring();
                DataSet ds = new DataSet();
                dbManager.Open();
                dbManager.CreateParameters(0);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "FETCH_GPMstSettings");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "FETCH_GPMstSettings");
                }
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal DataSet Open_GPMPRTUPLD()
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPMPRTUPLD");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMPRTUPLD");
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

        internal int SAVE_GPMPRTUPLD(string sImpCd, string sSaveXml, string sMode, string sFileName, string sOrgFileName)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(7);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {

                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(0, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(0, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);

                    dbManager.AddParameters(1, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);

                    dbManager.AddParameters(2, "@SAVEXML", sSaveXml, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@IMPCD", sImpCd, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@Mode", sMode, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@FileName", sFileName, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@OrgFileName", sOrgFileName, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "SAVE_GPMPRTUPLD");
                    dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "SAVE_GPMPRTUPLD");
                }
                else
                {

                }

                return 1;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                dbManager.Dispose();
            }

        }


    }
}
