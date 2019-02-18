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
   public class AuditTrailDAL
    {
       IDBOracleAdapter da = new IDBOracleAdapter();
       internal DataSet Fetch_GPMAUDIT(string SKU,string ID)
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
                   dbManager.AddParameters(3, "@SKU", SKU, ParameterDirection.Input);
                   dbManager.AddParameters(4, "@ID", ID, ParameterDirection.Input);
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
                   dbManager.AddParameters(3, "v_SKU", SKU, ParameterDirection.Input);
                   dbManager.AddParameters(4, "v_ID", ID, ParameterDirection.Input);
               }
               string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMAUDIT");
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMAUDIT");
               }
               else
               {
                   string[] cursor = { "cv_1", "cv_2", "cv_3", "cv_4" };
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMAUDIT", cursor);
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

       internal DataSet Fetch_GPMAUDIT_Ctg(string PrtId, string mode, string Param1, string Param2)
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
                   dbManager.AddParameters(2, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                   dbManager.AddParameters(3, "@PrtId", PrtId, ParameterDirection.Input);
                   dbManager.AddParameters(4, "@mode", mode, ParameterDirection.Input);
                   dbManager.AddParameters(5, "@Param1", Param1, ParameterDirection.Input);
                   dbManager.AddParameters(6, "@Param2", Param2, ParameterDirection.Input);
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
                   dbManager.AddParameters(3, "v_PrtId", PrtId, ParameterDirection.Input);
                   dbManager.AddParameters(4, "@mode", mode, ParameterDirection.Input);
                   dbManager.AddParameters(5, "@Param1", Param1, ParameterDirection.Input);
                   dbManager.AddParameters(6, "@Param2", Param2, ParameterDirection.Input);
               }
               string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMAUDIT_Ctg");
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMAUDIT_Ctg");
               }
               else
               {
                   string[] cursor = { "cv_1", "cv_2", "cv_3" };
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMAUDIT_Ctg", cursor);
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
    }
}
