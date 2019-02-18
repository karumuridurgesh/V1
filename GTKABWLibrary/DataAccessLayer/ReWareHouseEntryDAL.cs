using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using GTKUtilites.SessionUtils;
using GTKUtilites.HelpMethods;
using GTKUtilites.DataAccessLayer;


namespace GTKABWLibrary.DataAccessLayer
{
 public   class ReWareHouseEntryDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();

        internal DataSet Open_ABWRWHE()
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWRWHE");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWRWHE");
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

        internal void Fetch_ABWRWHE()
        {
                   
        }

        internal DataSet Fetch_ABWCF7512No(string ID7512)
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
                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 50);
                    dbManager.AddParameters(3, "@InputParam", ID7512, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@ModCode", SessionObjects.obj.GlobalPropertiesObject.ModCode, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@UserSessionID", System.Web.HttpContext.Current.Session.SessionID, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWCF7512No");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWCF7512No");
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

        internal DataSet Save_ABWRWHE(string No7512, string xmlData)
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
                    dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 50);
                    
                    dbManager.AddParameters(3, "@t7512No", No7512, ParameterDirection.Input,20);
                    dbManager.AddParameters(4, "@SaveXML", xmlData, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "CreateRewarehouse");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "CreateRewarehouse");

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

        internal DataSet Save_ABWEDD(string FileNo, DateTime PFFDate, DateTime FinalDocDate, string CF300DATE)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();

                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@EM_FileNo", FileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@PFFDATE", PFFDate, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@FINALDOCDATE", FinalDocDate, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@CF300DATE", CF300DATE, ParameterDirection.Input);

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWEDD");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ABWEDD");
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
