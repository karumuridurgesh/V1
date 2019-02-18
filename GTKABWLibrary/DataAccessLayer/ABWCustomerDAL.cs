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
    class ABWCustomerDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
       internal DataSet Open_ABWCustomer()
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWCustomer");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWCustomer");
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
         internal DataSet Fetch_ABWCustomer(string sMode, string sval)
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
                    dbManager.AddParameters(4, "@inputXml", sval, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWCustomer");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWCustomer");
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
       internal void  Save_ABWCustomer(string sMode, string sSaveXmdata)
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
                    dbManager.AddParameters(3, "@SaveXML", sSaveXmdata, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@Mode", sMode, ParameterDirection.Input);
                    //dbManager.AddParameters(5, "@Content", sTextContent, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.InputOutput, 100);

                    dbManager.AddParameters(1, "v_FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);

                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_SaveXML", sSaveXmdata, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_Mode", sMode, ParameterDirection.Input);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWCustomer");
             dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ABWCustomer");
                

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
       internal DataSet CustomerAction(string sMode, string sVal)
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

                   string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "CustomerAction");
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "CustomerAction");
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

