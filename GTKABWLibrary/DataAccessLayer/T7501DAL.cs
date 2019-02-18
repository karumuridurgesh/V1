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
   public class T7501DAL
    {
       IDBOracleAdapter da = new IDBOracleAdapter();
       internal DataSet Open_ABWT7501()
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

                   string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWT7501");
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWT7501");

                   if (dbManager.Parameters[0] != null)
                       SessionObjects.obj.GlobalPropertiesObject.UnId = dbManager.Parameters[0].Value.ToString();
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
       internal DataSet Fetch_ABWT7501(string sMode,string xmlData)
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
                       dbManager.AddParameters(0, "@ReturnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                   else
                       dbManager.AddParameters(0, "@ReturnUniquqKey", DBNull.Value, ParameterDirection.Input, 100);
                   if (SessionObjects.obj.GlobalPropertiesObject.FteCode != null && SessionObjects.obj.GlobalPropertiesObject.FteCode != "")
                       dbManager.AddParameters(1, "@FTECODE", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                   else
                       dbManager.AddParameters(1, "@FTECODE", DBNull.Value, ParameterDirection.Input, 10);
                   dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 50);

                   dbManager.AddParameters(3, "@Mode", sMode, ParameterDirection.Input, 1);
                   dbManager.AddParameters(4, "@inputXML", xmlData, ParameterDirection.Input);
                   dbManager.AddParameters(5, "@ModCode", SessionObjects.obj.GlobalPropertiesObject.ModCode, ParameterDirection.Input);
                   dbManager.AddParameters(6, "@UserSessionID", System.Web.HttpContext.Current.Session.SessionID, ParameterDirection.Input);

                   string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWT7501");
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWT7501");
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
       internal DataSet Save_ABWT7501(string sMode,string xmlData)
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
                   dbManager.AddParameters(3, "@SaveXml", xmlData, ParameterDirection.Input);
                   dbManager.AddParameters(4, "@Mode", sMode, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_returnUniqueKey", new Guid(SessionObjects.obj.GlobalPropertiesObject.UnId), ParameterDirection.Input, 100);
                   dbManager.AddParameters(1, "v_FteCode", SessionObjects.obj.GlobalPropertiesObject.FteCode, ParameterDirection.Input, 10);
                   dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                   dbManager.AddParameters(3, "v_SaveXml", xmlData, ParameterDirection.Input);
                   dbManager.AddParameters(4, "v_Mode", sMode, ParameterDirection.Input);
                   dbManager.AddParameters(5, "v_CommID", 0, ParameterDirection.Input, 4);
               }
               string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWT7501");
               ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_ABWT7501");
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
       internal DataSet Fetch_ABWT7501Products(string sMode, string PrdCds,string Locid)
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
                   dbManager.AddParameters(3, "@Mode", sMode, ParameterDirection.Input);
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

                   dbManager.AddParameters(3, "v_Mode", sMode, ParameterDirection.Input);
                   dbManager.AddParameters(4, "v_PrdCds", PrdCds, ParameterDirection.Input);
                   dbManager.AddParameters(5, "v_Locid", Locid, ParameterDirection.Input);
               }
               string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_T7501Products");
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_T7501Products");
               }
               else
               {
                   string[] cursor = { "cv_1", "cv_2", "cv_3" };
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_T7501Products", cursor);
               }


               DataTable dt = new DataTable();

               dt = ds.Tables[0];

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
       internal DataSet T7501Action(string Mode, string sVal)
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
                   dbManager.AddParameters(4, "@SAVEXML", sVal, ParameterDirection.Input);

                   string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "T7501Action");
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "T7501Action");
               }
               return ds;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
