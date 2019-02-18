using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GTKUtilites.HelpMethods;
using GTKUtilites.SessionUtils;
using System.Configuration;
using GTKUtilites.DataAccessLayer;

namespace Accounting.DataAccessLayer
{
    public class BillingCodeMasterDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();

        internal DataSet Open_PRENTINVRC()
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(10);
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
                    dbManager.AddParameters(3, "@Section", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].Section, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@RecordsPerPage", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].RecordsPerPage, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@PAGENUMBER", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].PAGENUMBER, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@TotRecords", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotRecords, ParameterDirection.InputOutput);
                    dbManager.AddParameters(7, "@TotPages", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].TotPages, ParameterDirection.InputOutput);
                    dbManager.AddParameters(8, "@PParams", SessionObjects.obj.PagingParametersObject[SessionObjects.obj.GlobalPropertiesObject.PagingIndex].PParams, ParameterDirection.Input);
                    if (SessionObjects.obj.PropertiesObject1.Param1 != "" && SessionObjects.obj.PropertiesObject1.Param1 != null)
                        dbManager.AddParameters(9, "@Param1", SessionObjects.obj.PropertiesObject1.Param1, ParameterDirection.Input, 30);
                    else
                        dbManager.AddParameters(9, "@Param1", DBNull.Value, ParameterDirection.Input, 30);                    
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ACNTGBLCD");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ACNTGBLCD");
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
            }
            finally
            {
                dbManager.Dispose();
            }
        }

        internal DataSet Save_ACNTGBLCD(string sSaveXml, string Mode)
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
                    dbManager.AddParameters(4, "@SAVEXML", sSaveXml, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ACNTGBLCD");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ACNTGBLCD");
                    //dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "Save_IMPMNENR_Pror");
                }
                else
                {
                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(0, "v_FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(0, "v_FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                    dbManager.AddParameters(1, "v_inputXml", sSaveXml, ParameterDirection.Input);
                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                        dbManager.AddParameters(3, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    else
                        dbManager.AddParameters(3, "v_returnUniqueKey", DBNull.Value, ParameterDirection.Input, 100);
                    dbManager.AddParameters(4, "v_Mode", Mode, ParameterDirection.Input);

                    string[] cursor = { "cv_1" };

                    da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_ACNTGBLCD", cursor);
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

        internal DataSet Fetch_ACNTGBLCD(string sMode, string sVal1)
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
                    dbManager.AddParameters(3, "@Mode", sMode, ParameterDirection.Input, 1);
                    dbManager.AddParameters(4, "@Val1", sVal1, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ACNTGBLCD");

                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ACNTGBLCD");

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
                    dbManager.AddParameters(3, "v_Mode", sMode, ParameterDirection.Input, 1);
                    dbManager.AddParameters(4, "v_Val1", sVal1, ParameterDirection.Input);                   

                    string[] cursor = { "cv_1" };

                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_IMPMNENR", cursor);
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

        internal DataSet Save_ACNTGGBCL(string sSaveXml)
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
                    dbManager.AddParameters(3, "@SAVEXML", sSaveXml, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ACNTGGBCL");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ACNTGGBCL");
                    //dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "Save_IMPMNENR_Pror");
                }
                else
                {
                    if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                        dbManager.AddParameters(0, "v_FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    else
                        dbManager.AddParameters(0, "v_FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                    dbManager.AddParameters(1, "v_inputXml", sSaveXml, ParameterDirection.Input);
                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    if (SessionObjects.obj.GlobalPropertiesObject.UnId != null && SessionObjects.obj.GlobalPropertiesObject.UnId != "")
                        dbManager.AddParameters(3, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                    else
                        dbManager.AddParameters(3, "v_returnUniqueKey", DBNull.Value, ParameterDirection.Input, 100);                   

                    string[] cursor = { "cv_1" };

                    da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_ACNTGGBCL", cursor);
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

        internal DataSet Fetch_BILLMASDETHIS(string sFileno, string sInvoiceno)
        {

            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@fileno", sFileno, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@Invoiceno", sInvoiceno, ParameterDirection.Input, 100);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_BILLMASDETHIS");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_BILLMASDETHIS");
                }
                else
                {
                    dbManager.AddParameters(0, "@fileno", sFileno, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@Invoiceno", sInvoiceno, ParameterDirection.Input, 100);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_BILLMASDETHIS", cursor);
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
    }
}
