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
    class AttributeSetupDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();
        internal DataSet Open_GPMATTBTSU()
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPMATTBTSU");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMATTBTSU");
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
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMATTBTSU", cursor);
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

        internal DataSet Save_GPMATTBTSU(string strLvl, string strPK1, string strPK2,int strPK3, string xmlData)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(6);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@strLvl", strLvl, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@strPK1", strPK1, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@strPK2", strPK2, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@strPK3", strPK3, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMATTBTSU");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_GPMATTBTSU");
                }
                else
                {
                    dbManager.AddParameters(0, "V_strLvl", strLvl, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_strPK1", strPK1, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_strPK2", strPK2, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_strPK3", strPK3, ParameterDirection.Input);
                    dbManager.AddParameters(4, "V_SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(5, "V_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_GPMATTBTSU", cursor);
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

        internal DataSet Fetch_GPMATTBTSU(string strLvl, string strPK1, string Mode, int LISTID)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(4);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@strLvl", strLvl, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@strPK1", strPK1, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@Mode", Mode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@LISTID", LISTID, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMATTBTSU");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMATTBTSU");
                }
                else
                {
                    dbManager.AddParameters(0, "V_strLvl", strLvl, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_strPK1", strPK1, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_Mode", Mode, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_LISTID", LISTID, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMATTBTSU", cursor);
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

        internal DataSet Open_GPMATTBTSUMRY()
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPMATTBTSUMRY");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMATTBTSUMRY");
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

                    dbManager.AddParameters(2, "v_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input, 100);

                    da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMATTBTSUMRY", cursor);
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

        //--AttributeMst
        internal DataSet Open_GPMATTBTMST()
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
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Open_GPMATTBTMST");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Open_GPMATTBTMST");
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
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Open_GPMATTBTMST", cursor);
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

        internal DataSet Fetch_GPMATTBTMST(string strLvl, int ATTBTID)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@strLvl", strLvl, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@ATTBTID", ATTBTID, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Fetch_GPMATTBTMST");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Fetch_GPMATTBTMST");
                }
                else
                {
                    dbManager.AddParameters(0, "V_strLvl", strLvl, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_strPK1", ATTBTID, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Fetch_GPMATTBTMST", cursor);
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


        internal DataSet Save_GPMATTBTMST(string strLvl, string strMode, string xmlData, int ATTBTID)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(5);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@strLvl", strLvl, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@strMode", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@ATTBTID", ATTBTID, ParameterDirection.Input);
                    string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "Save_GPMATTBTMST");
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "Save_GPMATTBTMST");
                }
                else
                {
                    dbManager.AddParameters(0, "V_strLvl", strLvl, ParameterDirection.Input);
                    dbManager.AddParameters(1, "V_strPK1", strMode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "V_SaveXML", xmlData, ParameterDirection.Input);
                    dbManager.AddParameters(3, "V_UserCode", SessionObjects.obj.GlobalPropertiesObject.UserCode, ParameterDirection.Input);
                    dbManager.AddParameters(4, "V_ATTBTID", ATTBTID, ParameterDirection.Input);
                    string[] cursor = { "cv_1" };
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "Save_GPMATTBTMST", cursor);
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
