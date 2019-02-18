using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using GTKUtilites.DataAccessLayer;
using GTKUtilites.HelpMethods;

namespace Accounting.DataAccessLayer
{
    public class ImpBillingDAL
    {
        IDBOracleAdapter da = new IDBOracleAdapter();

        internal DataTable CheckForImpLnkCode(string impCode, string billCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@IMPCODE", impCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@BILLCODE", billCode, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_IMPCODE", impCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_BILLCODE", billCode, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_LNKIMPBILROW");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_LNKIMPBILROW", cursor);
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

        internal DataTable GetImpBillingDetails(string compCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@COMPCODE", compCode, ParameterDirection.Input);

                }
                else
                {
                    dbManager.AddParameters(0, "v_COMPCODE", compCode, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_IMPBILLINGDETAILS");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_IMPBILLINGDETAILS", cursor);
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

        internal void SaveLinkImpBilling(string compCode, string billCode, string billName, float value, string calcVal, int status, int codeStatus)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(8);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@lib_impcode", compCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@lib_billcode", billCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@lib_descr", billName, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@lib_value", value, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@lib_CalculatedYorN", calcVal, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@lib_percentage", System.DBNull.Value, ParameterDirection.Input);
                    dbManager.AddParameters(6, "@status", status, ParameterDirection.Input);
                    dbManager.AddParameters(7, "@IsActive", codeStatus, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_lib_impcode", compCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_lib_billcode", billCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "v_lib_descr", billName, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_lib_value", value, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_lib_CalculatedYorN", calcVal, ParameterDirection.Input);
                    dbManager.AddParameters(5, "v_lib_percentage", System.DBNull.Value, ParameterDirection.Input);
                    dbManager.AddParameters(6, "v_status", status, ParameterDirection.Input);
                    dbManager.AddParameters(7, "v_IsActive", codeStatus, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteScalar(CommandType.StoredProcedure, "SAVE_IMPBILLING");
                    
                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_IMPBILLING");
                    
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

        internal void RemoveImpBillCode(string impCode, string billCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@IMPCODE", impCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@BILLCODE", billCode, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_IMPCODE", impCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_BILLCODE", billCode, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "DELETE_LINKIMPBILCODE");

                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "DELETE_LINKIMPBILCODE");
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

        internal DataSet GetBilMstrDet(string fileNo, string invSeqNo)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@INVSEQNO", invSeqNo, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_INVSEQNO", invSeqNo, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_BILGMSTRDETBYFILENO");
                }
                else
                {
                    string[] cursor = new string[3];
                    cursor[0] = "cv_1";
                    cursor[1] = "cv_2";
                    cursor[2] = "cv_3";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_BILGMSTRDETBYFILENO", cursor);
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

        internal DataTable GetBilDetails(string fileNo,string type, string invNo)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(3);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@TYPE", type, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@INVNO", invNo, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_TYPE", type, ParameterDirection.Input);
                    dbManager.AddParameters(2, "v_INVNO", invNo, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_BILGDETAILSBYFILENO");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_BILGDETAILSBYFILENO", cursor);
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

        internal int Save_BillingMaster(string BLM_FILENO, string BLM_INVNO, string BLM_ENTRYNO, DateTime BLM_INV_DATE, string BLM_MBNO, string BLM_HBNO, string BLM_SBNO,
          string BLM_IMPORTERNO, string BLM_BILLTO, string BLM_PAY_TERMS, string BLM_REFNO, string BLM_REMARKS, float BLM_BILLTOT, float BLM_PAYOUTTOT, string LUID, 
           float blm_pieces, float blm_weight, string blm_descr, string blm_shipper, string blm_consg_name,string  blm_origin, string blm_dest, DateTime blm_arrivaldate, 
           DateTime blm_entrydate, string blm_carrier, string BLM_PrintYorN, float blm_amtpaid, string blm_GenYorN, int Id,string BLM_INVREF, int Status,
            string sFinalize)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                int res = 0;
                dbManager.Open();
                dbManager.CreateParameters(32);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@BLM_FILENO", BLM_FILENO, ParameterDirection.Input);
		            dbManager.AddParameters(1, "@BLM_INVNO", BLM_INVNO, ParameterDirection.InputOutput,8);
		            dbManager.AddParameters(2, "@BLM_ENTRYNO", BLM_ENTRYNO, ParameterDirection.Input);
		            dbManager.AddParameters(3, "@BLM_INV_DATE", BLM_INV_DATE, ParameterDirection.Input);
		            dbManager.AddParameters(4, "@BLM_MBNO", BLM_MBNO, ParameterDirection.Input);
		            dbManager.AddParameters(5, "@BLM_HBNO", BLM_HBNO, ParameterDirection.Input);
		            dbManager.AddParameters(6, "@BLM_SBNO", BLM_SBNO, ParameterDirection.Input);
		            dbManager.AddParameters(7, "@BLM_IMPORTERNO", BLM_IMPORTERNO, ParameterDirection.Input);
		            dbManager.AddParameters(8, "@BLM_BILLTO", BLM_BILLTO, ParameterDirection.Input);
		            dbManager.AddParameters(9, "@BLM_PAY_TERMS", BLM_PAY_TERMS, ParameterDirection.Input);
		            dbManager.AddParameters(10, "@BLM_REFNO", BLM_REFNO, ParameterDirection.Input);
		            dbManager.AddParameters(11, "@BLM_REMARKS", BLM_REMARKS, ParameterDirection.Input);
		            dbManager.AddParameters(12, "@BLM_BILLTOT", BLM_BILLTOT, ParameterDirection.Input);
		            dbManager.AddParameters(13, "@BLM_PAYOUTTOT", BLM_PAYOUTTOT, ParameterDirection.Input);
		            dbManager.AddParameters(14, "@LUID", LUID, ParameterDirection.Input);
		            dbManager.AddParameters(15, "@blm_pieces", blm_pieces, ParameterDirection.Input);
		            dbManager.AddParameters(16, "@blm_weight", blm_weight, ParameterDirection.Input);
		            dbManager.AddParameters(17, "@blm_descr", blm_descr, ParameterDirection.Input);
		            dbManager.AddParameters(18, "@blm_shipper", blm_shipper, ParameterDirection.Input);
		            dbManager.AddParameters(19, "@blm_consg_name", blm_consg_name, ParameterDirection.Input);
		            dbManager.AddParameters(20, "@blm_origin", blm_origin, ParameterDirection.Input);
		            dbManager.AddParameters(21, "@blm_dest", blm_dest, ParameterDirection.Input);
		            dbManager.AddParameters(22, "@blm_arrivaldate", blm_arrivaldate, ParameterDirection.Input);
		            dbManager.AddParameters(23, "@blm_entrydate", blm_entrydate, ParameterDirection.Input);
		            dbManager.AddParameters(24, "@blm_carrier", blm_carrier, ParameterDirection.Input);
		            dbManager.AddParameters(25, "@BLM_PrintYorN", BLM_PrintYorN, ParameterDirection.Input);
		            dbManager.AddParameters(26, "@blm_amtpaid", blm_amtpaid, ParameterDirection.Input);
		            dbManager.AddParameters(27, "@blm_GenYorN", @blm_GenYorN, ParameterDirection.Input);
		            dbManager.AddParameters(28, "@Id", @Id, ParameterDirection.Input);
                    dbManager.AddParameters(29, "@BLM_INVREF", BLM_INVREF, ParameterDirection.Input);
                    dbManager.AddParameters(30, "@Status", Status, ParameterDirection.Input);
                    dbManager.AddParameters(31, "@Finalize", sFinalize, ParameterDirection.Input);
                }
                else
                {
		            dbManager.AddParameters(0, "v_BLM_FILENO", BLM_FILENO, ParameterDirection.Input);
		            dbManager.AddParameters(1, "v_BLM_INVNO", BLM_INVNO, ParameterDirection.InputOutput,8);
		            dbManager.AddParameters(2, "v_BLM_ENTRYNO", BLM_ENTRYNO, ParameterDirection.Input);
		            dbManager.AddParameters(3, "v_BLM_INV_DATE", BLM_INV_DATE, ParameterDirection.Input);
		            dbManager.AddParameters(4, "v_BLM_MBNO", BLM_MBNO, ParameterDirection.Input);
		            dbManager.AddParameters(5, "v_BLM_HBNO", BLM_HBNO, ParameterDirection.Input);
		            dbManager.AddParameters(6, "v_BLM_SBNO", BLM_SBNO, ParameterDirection.Input);
		            dbManager.AddParameters(7, "v_BLM_IMPORTERNO", BLM_IMPORTERNO, ParameterDirection.Input);
		            dbManager.AddParameters(8, "v_BLM_BILLTO", BLM_BILLTO, ParameterDirection.Input);
		            dbManager.AddParameters(9, "v_BLM_PAY_TERMS", BLM_PAY_TERMS, ParameterDirection.Input);
		            dbManager.AddParameters(10, "v_BLM_REFNO", BLM_REFNO, ParameterDirection.Input);
		            dbManager.AddParameters(11, "v_BLM_REMARKS", BLM_REMARKS, ParameterDirection.Input);
		            dbManager.AddParameters(12, "v_BLM_BILLTOT", BLM_BILLTOT, ParameterDirection.Input);
		            dbManager.AddParameters(13, "v_BLM_PAYOUTTOT", BLM_PAYOUTTOT, ParameterDirection.Input);
		            dbManager.AddParameters(14, "v_LUID", LUID, ParameterDirection.Input);
		            dbManager.AddParameters(15, "v_blm_pieces", blm_pieces, ParameterDirection.Input);
		            dbManager.AddParameters(16, "v_blm_weight", blm_weight, ParameterDirection.Input);
		            dbManager.AddParameters(17, "v_blm_descr", blm_descr, ParameterDirection.Input);
		            dbManager.AddParameters(18, "v_blm_shipper", blm_shipper, ParameterDirection.Input);
		            dbManager.AddParameters(19, "v_blm_consg_name", blm_consg_name, ParameterDirection.Input);
		            dbManager.AddParameters(20, "v_blm_origin", blm_origin, ParameterDirection.Input);
		            dbManager.AddParameters(21, "v_blm_dest", blm_dest, ParameterDirection.Input);
		            dbManager.AddParameters(22, "v_blm_arrivaldate", blm_arrivaldate, ParameterDirection.Input);
		            dbManager.AddParameters(23, "v_blm_entrydate", blm_entrydate, ParameterDirection.Input);
		            dbManager.AddParameters(24, "v_blm_carrier", blm_carrier, ParameterDirection.Input);
		            dbManager.AddParameters(25, "v_BLM_PrintYorN", BLM_PrintYorN, ParameterDirection.Input);
		            dbManager.AddParameters(26, "v_blm_amtpaid", blm_amtpaid, ParameterDirection.Input);
		            dbManager.AddParameters(27, "v_blm_GenYorN", blm_GenYorN, ParameterDirection.Input);
		            dbManager.AddParameters(28, "v_Id", Id, ParameterDirection.Input);
                    dbManager.AddParameters(29, "v_BLM_INVREF", BLM_INVREF, ParameterDirection.Input);
                    dbManager.AddParameters(30, "v_Status", Status, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "SAVE_BILLINGMASTER");
                    res = Convert.ToInt32(dbManager.Parameters[1].Value.ToString());
                    
                }
                else
                {
                    
                    object[] arr = da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_BILLINGMASTER");
                    if (arr != null && arr[0] != null && arr[0].ToString() != null)
                    {
                        res = Convert.ToInt32(arr[0].ToString());
                    }
                    
                }
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


        internal void Save_BillingDetails(string bld_fileno, string bld_invno, int bld_seqno, string bld_bill_code, string bld_bill_descr, float bld_pay_amt, string bld_pay_vendor, string bld_refno, string luid, float bld_bill_amt, string bld_VendorRefno, int Status,string bld_bill_descriptor)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(13);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@bld_fileno", bld_fileno, ParameterDirection.Input);
		            dbManager.AddParameters(1, "@bld_invno", bld_invno, ParameterDirection.Input);
		            dbManager.AddParameters(2, "@bld_seqno", bld_seqno, ParameterDirection.Input);
		            dbManager.AddParameters(3, "@bld_bill_code", bld_bill_code, ParameterDirection.Input);
		            dbManager.AddParameters(4, "@bld_bill_descr", bld_bill_descr, ParameterDirection.Input);
		            dbManager.AddParameters(5, "@bld_pay_amt", bld_pay_amt, ParameterDirection.Input);
		            dbManager.AddParameters(6, "@bld_pay_vendor", bld_pay_vendor, ParameterDirection.Input);
		            dbManager.AddParameters(7, "@bld_refno", bld_refno, ParameterDirection.Input);
		            dbManager.AddParameters(8, "@luid", luid, ParameterDirection.Input);
		            dbManager.AddParameters(9, "@bld_bill_amt", bld_bill_amt, ParameterDirection.Input);
		            dbManager.AddParameters(10, "@bld_VendorRefno", bld_VendorRefno, ParameterDirection.Input);
                    dbManager.AddParameters(11, "@Status", Status, ParameterDirection.Input);
                    dbManager.AddParameters(12, "@bld_bill_descriptor", bld_bill_descriptor, ParameterDirection.Input);
                }
                else
                {
		            dbManager.AddParameters(0, "v_bld_fileno", bld_fileno, ParameterDirection.Input);
		            dbManager.AddParameters(1, "v_bld_invno", bld_invno, ParameterDirection.Input);
		            dbManager.AddParameters(2, "v_bld_seqno", bld_seqno, ParameterDirection.Input);
		            dbManager.AddParameters(3, "v_bld_bill_code", bld_bill_code, ParameterDirection.Input);
		            dbManager.AddParameters(4, "v_bld_bill_descr", bld_bill_descr, ParameterDirection.Input);
		            dbManager.AddParameters(5, "v_bld_pay_amt", bld_pay_amt, ParameterDirection.Input);
		            dbManager.AddParameters(6, "v_bld_pay_vendor", bld_pay_vendor, ParameterDirection.Input);
		            dbManager.AddParameters(7, "v_bld_refno", bld_refno, ParameterDirection.Input);
		            dbManager.AddParameters(8, "v_luid", luid, ParameterDirection.Input);
		            dbManager.AddParameters(9, "v_bld_bill_amt", bld_bill_amt, ParameterDirection.Input);
		            dbManager.AddParameters(10, "v_bld_VendorRefno", bld_VendorRefno, ParameterDirection.Input);
                    dbManager.AddParameters(11, "v_Status", Status, ParameterDirection.Input);
                    dbManager.AddParameters(12, "v_bld_bill_descriptor", bld_bill_descriptor, ParameterDirection.Input);
                }
                string spCall = Helper.Ins.GetSPCall(dbManager.Parameters, "SAVE_BILLINGDETAILS");
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                dbManager.ExecuteScalar(CommandType.StoredProcedure, "SAVE_BILLINGDETAILS");
                }
                 else
                 {
                  da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_BILLINGDETAILS");
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


        internal DataSet GetDutyFees(string fileNo, string impCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@IMPCODE", impCode, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_IMPCODE", impCode, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_DUTYFEES");
                }
                else
                {
                    string[] cursor = new string[3];
                    cursor[0] = "cv_1";
                    cursor[1] = "cv_2";
                    cursor[2] = "cv_3";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_DUTYFEES", cursor);
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


        internal DataSet GetCheckImporters(string fileNo, string billCode)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@BILLCODE", billCode, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_BILLCODE", billCode, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_CHECKIMPORTERS");
                }
                else
                {
                    string[] cursor = new string[3];
                    cursor[0] = "cv_1";
                    cursor[1] = "cv_2";
                    cursor[2] = "cv_3";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CHECKIMPORTERS", cursor);
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

        internal DataTable GetVendorCheck(string code)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(1);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CODE", code, ParameterDirection.Input);
                    
                }
                else
                {
                    dbManager.AddParameters(0, "v_CODE", code, ParameterDirection.Input);
                    
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "CHECK_VENDPTYTYPE");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "CHECK_VENDPTYTYPE", cursor);
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

        internal void Update_BillingAmount(string fileNo, string billCode, float billAmt, string strVendor, string updatedby)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                //dbManager.CreateParameters(4);
                dbManager.CreateParameters(5);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@BILLCODE", billCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@AMOUNT", billAmt, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@VENDOR", strVendor, ParameterDirection.Input);
                    dbManager.AddParameters(4, "@UpdatedBy", updatedby, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_FILENO", fileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_BILLCODE", billCode, ParameterDirection.Input);
                    dbManager.AddParameters(2, "v_AMOUNT", billAmt, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_VENDOR", strVendor, ParameterDirection.Input);
                    dbManager.AddParameters(4, "v_UpdatedBy", updatedby, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteScalar(CommandType.StoredProcedure, "UPDATE_BILLINGDETAILS");
                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "UPDATE_BILLINGDETAILS");
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

        internal void VoidBillingMaster(string strFileNo, string invNo)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@FILENO", strFileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@INVNO", invNo, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_FILENO", strFileNo, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_INVNO", invNo, ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.ExecuteScalar(CommandType.StoredProcedure, "VOID_BILLINGMASTER");
                }
                else
                {
                    da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "VOID_BILLINGMASTER");
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

        internal DataSet GetDefBillTo(string strImpCode, string sFileno)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                dbManager.CreateParameters(2);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@CODE", strImpCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@Fileno", sFileno, ParameterDirection.Input);

                }
                else
                {
                    dbManager.AddParameters(0, "v_CODE", strImpCode, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_Fileno", sFileno, ParameterDirection.Input);

                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_DEFAULTBILLTO");
                }
                else
                {
                    string[] cursor = new string[1];
                    cursor[0] = "cv_1";
                    ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_DEFAULTBILLTO", cursor);
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

        internal DataTable GetVendorBillsbyEntryNo(string entryNo)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                dbManager.CreateParameters(1);
                dbManager.AddParameters(0, "@EntryNo", entryNo, ParameterDirection.Input);
                ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GetVendorBillsbyEntryNo");
                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //CODE ADDED BY GEETHA 05.04.2010
        private int lastpage;
        internal DataTable GetBillPaging(int startRecord, int recordCount, int lastRecord, int pageNumber, string query)
        {
            IDBManager dbManager = CommonConnection.Connectionstring();
            try
            {
                dbManager.Open();
                DataSet dsEM = new DataSet();

                dbManager.CreateParameters(6);
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dbManager.AddParameters(0, "@FIRSTRECORD", startRecord, ParameterDirection.Input);
                    dbManager.AddParameters(1, "@RECORDSCOUNT", recordCount, ParameterDirection.Input);
                    dbManager.AddParameters(2, "@LASTRECORD", lastRecord, ParameterDirection.Input);
                    dbManager.AddParameters(3, "@LASTPAGECOUNT", 0, ParameterDirection.Output);
                    dbManager.AddParameters(4, "@PAGENUMBER", pageNumber, ParameterDirection.Input);
                    dbManager.AddParameters(5, "@QUERY", query, ParameterDirection.Input);
                }
                else
                {
                    dbManager.AddParameters(0, "v_firstRecord", startRecord, ParameterDirection.Input);
                    dbManager.AddParameters(1, "v_recordsCount", recordCount, ParameterDirection.Input);
                    dbManager.AddParameters(2, "v_lastRecord", lastRecord, ParameterDirection.Input);
                    dbManager.AddParameters(3, "v_lastPageCount", 0, ParameterDirection.Output);
                    dbManager.AddParameters(4, "v_pageNumber", pageNumber, ParameterDirection.Input);
                    //dk 02/10/10 removing dbo. for oracle
                    dbManager.AddParameters(5, "v_QUERY", query.Replace("dbo.", ""), ParameterDirection.Input);
                }
                if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                {
                    dsEM = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_BILL_PAGING");
                }
                else
                {
                    //dk 02/10/10
                    string[] cursor = { "cv_1", "cv_2" };
                    dsEM = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_BILL_PAGING", cursor);
                }
                DataTable dtEM = new DataTable();

                if (lastRecord == 1)
                {
                    if (ConfigurationManager.AppSettings["DataB"] == "SQL")
                    {
                        if (dbManager.Parameters[3] != null)
                        {
                            LastPageNumber = Convert.ToInt32(dbManager.Parameters[3].Value);
                        }
                    }
                    else
                    {
                        if (dsEM.Tables[1].Rows.Count > 0 && dsEM.Tables[1].Rows[0][0].ToString() != "")
                        {
                            LastPageNumber = Convert.ToInt32(dsEM.Tables[1].Rows[0][0].ToString());
                        }
                    }
                }
                if (dsEM.Tables.Count > 0)
                {
                    dtEM = dsEM.Tables[0];
                }
                return dtEM;
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

        internal int LastPageNumber
        {
            get { return lastpage; }
            set { lastpage = value; }
        }
        //END
    }
}
