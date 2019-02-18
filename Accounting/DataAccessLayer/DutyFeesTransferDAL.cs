using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using GTKUtilites.DataAccessLayer;

namespace Accounting.DataAccessLayer
{
    public class DutyFeesTransferDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();

        internal DataTable GetDtyTransferDetails()
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_DTYFEESDETAILS");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_DTYFEESDETAILS", cursor);
                }
                return ds.Tables[0];
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
        internal void SaveDutyFees(string fee_code, string fee_no, string fee_description, float fee_amount, string fee_type, string fee_bill_code, string luid, int fee_priority,int codeStat, int status)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(10);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@fee_code", fee_code.ToUpper(), ParameterDirection.Input);
                    dbManager.AddParameters(1, "@fee_no", fee_no, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@fee_description", fee_description, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@fee_amount", fee_amount, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@fee_type", fee_type.ToUpper(), ParameterDirection.Input);
                    dbManager.AddParameters(5, "@fee_bill_code", fee_bill_code.ToUpper(), ParameterDirection.Input);
                    dbManager.AddParameters(6, "@luid", luid, ParameterDirection.Input);
                    if (fee_priority!=0)
                        dbManager.AddParameters(7, "@fee_priority", fee_priority, ParameterDirection.Input);
                    else
                        dbManager.AddParameters(7, "@fee_priority", System.DBNull.Value, ParameterDirection.Input);

                    dbManager.AddParameters(8, "@status", status, ParameterDirection.Input);
                    dbManager.AddParameters(9, "@IsActive", codeStat, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_fee_code", fee_code.ToUpper(), ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_fee_no", fee_no, ParameterDirection.Input);
                    dbManager.AddParameters(2, "v_fee_description", fee_description, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_fee_amount", fee_amount, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_fee_type", fee_type.ToUpper(), ParameterDirection.Input);
                    dbManager.AddParameters(5, "v_fee_bill_code", fee_bill_code.ToUpper(), ParameterDirection.Input);
                    dbManager.AddParameters(6, "v_luid", luid, ParameterDirection.Input);
                    if (fee_priority != 0)
                        dbManager.AddParameters(7, "v_fee_priority", fee_priority, ParameterDirection.Input);
                    else
                        dbManager.AddParameters(7, "v_fee_priority", System.DBNull.Value, ParameterDirection.Input);

                    dbManager.AddParameters(8, "v_status", status, ParameterDirection.Input);
                    dbManager.AddParameters(9, "v_IsActive", codeStat, ParameterDirection.Input);
                }

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteScalar(CommandType.StoredProcedure, "SAVE_DUTYFEES");

                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_DUTYFEES");

                }
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
        internal void RemoveDtyFee(string Code)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CODE", Code, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_CODE", Code, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "DELETE_DTYFEECODE");

                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "DELETE_DTYFEECODE");
                }

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
