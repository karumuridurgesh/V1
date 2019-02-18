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
   public class GBillingCodesDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();

        internal DataTable GetGlobalBillingCodes()
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_GlobalBILLINGCODES");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_GlobalBILLINGCODES", cursor);
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

        internal DataTable GetGlobalOTHBillingCodes(string billcode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(1);
                DataSet ds = new DataSet();

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@gob_billcode", billcode, ParameterDirection.Input);
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_GlobalOthersBILLCODES");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_GlobalOthersBILLCODES", cursor);
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

        internal void SaveGBillingCodes(string bill_code, string bill_descr, string fldind, float bill_def_amount, float bill_def_percent,
         string luid,float maxamt,float minamt,int addsub,string oth,int IsActive, int status)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(13);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@gb_billcode", bill_code, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@gb_billdescr", bill_descr, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@gb_fieldind", fldind, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@gb_value", bill_def_amount, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@gb_percentage", bill_def_percent, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@luid", luid, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@gb_maximum", maxamt, ParameterDirection.Input);
                    dbManager.AddParameters(7, "@gb_minimum", minamt, ParameterDirection.Input);
                    dbManager.AddParameters(8, "@gb_addsubtract", addsub, ParameterDirection.Input);
                    dbManager.AddParameters(9, "@gb_others", oth, ParameterDirection.Input);
                    dbManager.AddParameters(10, "@IsActive", IsActive, ParameterDirection.Input);
                    dbManager.AddParameters(11, "@Id", 0, ParameterDirection.Input);
                    dbManager.AddParameters(12, "@status", status, ParameterDirection.Input);
                }
                else
                {
                    //dbManager.AddParameters(0, "v_bill_code", bill_code, ParameterDirection.Input);
                    //dbManager.AddParameters(1, "v_bill_descr", bill_descr, ParameterDirection.Input);
                    //dbManager.AddParameters(2, "v_bill_def_vendor", bill_def_vendor, ParameterDirection.Input);
                    //dbManager.AddParameters(3, "v_bill_def_amount", bill_def_amount, ParameterDirection.Input);
                    //dbManager.AddParameters(4, "v_bill_def_percent", bill_def_percent, ParameterDirection.Input);
                    //dbManager.AddParameters(5, "v_luid", luid, ParameterDirection.Input);
                    //dbManager.AddParameters(6, "v_bill_internalCode", bill_internalCode, ParameterDirection.Input);
                    //dbManager.AddParameters(7, "v_bill_type", bill_type, ParameterDirection.Input);
                    //dbManager.AddParameters(8, "v_IsActive", IsActive, ParameterDirection.Input);
                    //dbManager.AddParameters(9, "v_Id", 0, ParameterDirection.Input);
                    //dbManager.AddParameters(10, "v_status", status, ParameterDirection.Input);
                }

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteScalar(CommandType.StoredProcedure, "SAVE_GBILLINGCODES");

                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_GBILLINGCODES");

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

        internal void SaveGOTHBillCodes(string bill_code,int seqno, string fldind, float from, float to, float value, float unitrate, int status)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(8);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@gb_billcode", bill_code, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@seqno", seqno, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@type", fldind, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@from", from, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@to", to, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@value", value, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@ur", unitrate, ParameterDirection.Input);                    
                    dbManager.AddParameters(7, "@status", status, ParameterDirection.Input);
                }
                else
                {
                    //dbManager.AddParameters(0, "v_bill_code", bill_code, ParameterDirection.Input);
                    //dbManager.AddParameters(1, "v_bill_descr", bill_descr, ParameterDirection.Input);
                    //dbManager.AddParameters(2, "v_bill_def_vendor", bill_def_vendor, ParameterDirection.Input);
                    //dbManager.AddParameters(3, "v_bill_def_amount", bill_def_amount, ParameterDirection.Input);
                    //dbManager.AddParameters(4, "v_bill_def_percent", bill_def_percent, ParameterDirection.Input);
                    //dbManager.AddParameters(5, "v_luid", luid, ParameterDirection.Input);
                    //dbManager.AddParameters(6, "v_bill_internalCode", bill_internalCode, ParameterDirection.Input);
                    //dbManager.AddParameters(7, "v_bill_type", bill_type, ParameterDirection.Input);
                    //dbManager.AddParameters(8, "v_IsActive", IsActive, ParameterDirection.Input);
                    //dbManager.AddParameters(9, "v_Id", 0, ParameterDirection.Input);
                    //dbManager.AddParameters(10, "v_status", status, ParameterDirection.Input);
                }

                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteScalar(CommandType.StoredProcedure, "SAVE_GOTHBILLCODES");

                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_GBILLINGCODES");

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

        internal void RemoveGBillCode(string billCode)
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
                    dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "DELETE_GBILLINGCODE");

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
