using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using GTKUtilites.DataAccessLayer;
//Adding comments to test alm changes1
namespace Accounting.DataAccessLayer
{
    public class BillingCodesDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();

        internal DataTable GetCompBillingCodes()
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_BILLINGCODES");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_BILLINGCODES", cursor);
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
        internal void SaveBillingCodes(string bill_code, string bill_descr, string bill_def_vendor, float bill_def_amount, float bill_def_percent,
            string luid, string bill_internalCode, string bill_type, int IsActive, int status)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(11);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@bill_code", bill_code, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@bill_descr", bill_descr, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@bill_def_vendor", bill_def_vendor, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@bill_def_amount", bill_def_amount, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@bill_def_percent", bill_def_percent, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@luid", luid, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@bill_internalCode", bill_internalCode, ParameterDirection.Input);
                    dbManager.AddParameters(7, "@bill_type", bill_type, ParameterDirection.Input);
                    dbManager.AddParameters(8, "@IsActive", IsActive, ParameterDirection.Input);
                    dbManager.AddParameters(9, "@Id", 0, ParameterDirection.Input);
                    dbManager.AddParameters(10, "@status", status, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_bill_code", bill_code, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_bill_descr", bill_descr, ParameterDirection.Input);
                    dbManager.AddParameters(2, "v_bill_def_vendor", bill_def_vendor, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_bill_def_amount", bill_def_amount, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_bill_def_percent", bill_def_percent, ParameterDirection.Input);
                    dbManager.AddParameters(5, "v_luid", luid, ParameterDirection.Input);
                    dbManager.AddParameters(6, "v_bill_internalCode", bill_internalCode, ParameterDirection.Input);
                    dbManager.AddParameters(7, "v_bill_type", bill_type, ParameterDirection.Input);
                    dbManager.AddParameters(8, "v_IsActive", IsActive, ParameterDirection.Input);
                    dbManager.AddParameters(9, "v_Id", 0, ParameterDirection.Input);
                    dbManager.AddParameters(10, "v_status", status, ParameterDirection.Input);
                }

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteScalar(CommandType.StoredProcedure, "SAVE_BILLINGCODES");

                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_BILLINGCODES");

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

        internal void RemoveBillCode(string billCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@BILLCODE", billCode, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_BILLCODE", billCode, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "DELETE_BILLINGCODE");
                    
                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "DELETE_BILLINGCODE");
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
