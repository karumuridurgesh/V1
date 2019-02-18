using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.DataAccessLayer;
using System.Configuration;
using System.Data;
using GTKUtilites.SessionUtils;
using GTKUtilites.HelpMethods;

namespace GTKABWLibrary.DataAccessLayer
{
    public class ABWListSummaryDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
        internal DataSet Open_ABWLSTSUMRY()
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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWLSTSUMRY");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWLSTSUMRY");
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

        internal DataSet Open_ABWLSTCD()
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

                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_ABWLSTCD");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_ABWLSTCD");

                    if (dbManager.Parameters[0] != null)
                        SessionObjects.obj.GlobalPropertiesObject.UnId = dbManager.Parameters[0].Value.ToString();

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

        internal DataSet FetchListCode(string ListCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                DataSet ds = new DataSet();
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@ListCode", ListCode, ParameterDirection.Input, 100);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_ABWLSTCD");
                ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_ABWLSTCD");
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

        internal int Save_ABWLSTCD(string xmlData, string Mode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);
                    dbManager.AddParameters(1, "@SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Mode", Mode, ParameterDirection.Input, 2);

                }
                int res = 0;
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_ABWLSTCD");
                res = Convert.ToInt32(dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "Save_ABWLSTCD"));
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
    }
}
