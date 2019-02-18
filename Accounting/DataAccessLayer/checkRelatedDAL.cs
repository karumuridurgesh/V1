using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using GTKUtilites.DataAccessLayer;

namespace Accounting.DataAccessLayer
{
   internal class checkRelatedDAL
    {
       IDBOracleAdapter da = new IDBOracleAdapter();
       internal DataTable GetCheckDetails(string strCheckNo)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(1);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@CHECKNO", strCheckNo, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_CHECKNO", strCheckNo, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_CHECKDETAILS");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CHECKDETAILS", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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
       internal void SaveCheckDetails(string ckd_chkno, int ckd_seqno, string ckd_fileno, string ckd_refno, float ckd_amtpaid, string chk_billcode, string chk_comments, string luid, int Status)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(9);
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@ckd_chkno", ckd_chkno, ParameterDirection.Input);
                   dbManager.AddParameters(1, "@ckd_seqno", ckd_seqno, ParameterDirection.Input);
                   dbManager.AddParameters(2, "@ckd_fileno", ckd_fileno, ParameterDirection.Input);
                   dbManager.AddParameters(3, "@ckd_refno", ckd_refno, ParameterDirection.Input);
                   dbManager.AddParameters(4, "@ckd_amtpaid", ckd_amtpaid, ParameterDirection.Input);
                   dbManager.AddParameters(5, "@chk_billcode", chk_billcode, ParameterDirection.Input);
                   dbManager.AddParameters(6, "@chk_comments", chk_comments, ParameterDirection.Input);
                   dbManager.AddParameters(7, "@luid", luid, ParameterDirection.Input);
                   dbManager.AddParameters(8, "@Status", Status, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_ckd_chkno", ckd_chkno, ParameterDirection.Input);
                   dbManager.AddParameters(1, "v_ckd_seqno", ckd_seqno, ParameterDirection.Input);
                   dbManager.AddParameters(2, "v_ckd_fileno", ckd_fileno, ParameterDirection.Input);
                   dbManager.AddParameters(3, "v_ckd_refno", ckd_refno, ParameterDirection.Input);
                   dbManager.AddParameters(4, "v_ckd_amtpaid", ckd_amtpaid, ParameterDirection.Input);
                   dbManager.AddParameters(5, "v_chk_billcode", chk_billcode, ParameterDirection.Input);
                   dbManager.AddParameters(6, "v_chk_comments", chk_comments, ParameterDirection.Input);
                   dbManager.AddParameters(7, "v_luid", luid, ParameterDirection.Input);
                   dbManager.AddParameters(8, "v_Status", Status, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "SAVE_CHECKDETAILS");
               }
               else
               {
                   da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_CHECKDETAILS");
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
       internal int SaveCheckMaster(string ckm_chkno, string ckm_payto, string ckm_date, float ckm_amt, string ckm_remarks, string luid, string ckm_numtowordamt, string ckm_printed, string ckm_void, int Status, int id)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(11);
               int res = 0;
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@ckm_chkno", ckm_chkno, ParameterDirection.Input);
                   dbManager.AddParameters(1, "@ckm_payto", ckm_payto, ParameterDirection.Input);
                   dbManager.AddParameters(2, "@ckm_date", ckm_date, ParameterDirection.Input);
                   dbManager.AddParameters(3, "@ckm_amt", ckm_amt, ParameterDirection.Input);
                   dbManager.AddParameters(4, "@ckm_remarks", ckm_remarks, ParameterDirection.Input);
                   dbManager.AddParameters(5, "@luid", luid, ParameterDirection.Input);
                   dbManager.AddParameters(6, "@ckm_numtowordamt", ckm_numtowordamt, ParameterDirection.Input);
                   dbManager.AddParameters(7, "@ckm_printed", ckm_printed, ParameterDirection.Input);
                   if(ckm_void=="1"){
                   dbManager.AddParameters(8, "@ckm_void", ckm_void, ParameterDirection.Input);
                   }
                   else
                   {
                       dbManager.AddParameters(8, "@ckm_void", System.DBNull.Value, ParameterDirection.Input);
                   }
                   dbManager.AddParameters(9, "@Status", Status, ParameterDirection.Input);
                   dbManager.AddParameters(10, "@id", id, ParameterDirection.Output);
               }
               else
               {
                   dbManager.AddParameters(0, "v_ckm_chkno", ckm_chkno, ParameterDirection.Input);
                   dbManager.AddParameters(1, "v_ckm_payto", ckm_payto, ParameterDirection.Input);
                   dbManager.AddParameters(2, "v_ckm_date", ckm_date, ParameterDirection.Input);
                   dbManager.AddParameters(3, "v_ckm_amt", ckm_amt, ParameterDirection.Input);
                   dbManager.AddParameters(4, "v_ckm_remarks", ckm_remarks, ParameterDirection.Input);
                   dbManager.AddParameters(5, "v_luid", luid, ParameterDirection.Input);
                   dbManager.AddParameters(6, "v_ckm_numtowordamt", ckm_numtowordamt, ParameterDirection.Input);
                   dbManager.AddParameters(7, "v_ckm_printed", ckm_printed, ParameterDirection.Input);
                   if (ckm_void == "1")
                   {
                       dbManager.AddParameters(8, "v_ckm_void", ckm_void, ParameterDirection.Input);
                   }
                   else
                   {
                       dbManager.AddParameters(8, "v_ckm_void", System.DBNull.Value, ParameterDirection.Input);
                   }
                   
                   dbManager.AddParameters(9, "v_Status", Status, ParameterDirection.Input);
                   dbManager.AddParameters(10, "v_id", id, ParameterDirection.Output);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   res=dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "SAVE_CHECKMASTER");
                   
               }
               else
               {
                   object[] arr = da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_CHECKMASTER");
                   if (arr != null && arr[10] != null && arr[0].ToString() != null)
                   {
                       res = int.Parse(arr[10].ToString());
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
       internal DataTable GetCheckNo(string chkNo)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(1);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@CHECKNO", chkNo, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_CHECKNO", chkNo, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_CHECKNO");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CHECKNO", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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
       internal DataTable CheckBillCodes(string code)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(1);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
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
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_BILLCODEBYCODE");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_BILLCODEBYCODE", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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
       internal int GetCheckAutoNumber()
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               int num = 0;
               DataSet ds = new DataSet();
               
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {

                   IDataReader reader = dbManager.ExecuteReader(CommandType.StoredProcedure, "GET_CHECKNUMBER");

                   while (reader.Read())
                   {
                       if (reader["aut_number"].ToString()!="")
                       {
                       num =int.Parse(reader["aut_number"].ToString());
                       }
                   }
               }
               else
               {
                   
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CHECKNUMBER", cursor);
                   DataTable dt = new DataTable();
                   dt = ds.Tables[0];
                   if (dt.Rows[0]["aut_number"].ToString() != "")
                   {
                       num = int.Parse(dt.Rows[0]["aut_number"].ToString());
                   }
               }


               return num;
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


       internal DataTable GetCashDetails(string strCheckNo)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(1);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@CHECKRECPTNO", strCheckNo, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_CHECKRECPTNO", strCheckNo, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_CASHDETAILS");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CASHDETAILS", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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
       internal void SaveCashDetails(string chd_receiptno, int chd_seqno, string chd_fileno, string chd_invno, string chd_descr, float chd_netdue, float chd_amtpaid, string luid, int Status)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(9);
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@chd_receiptno", chd_receiptno, ParameterDirection.Input);
                   dbManager.AddParameters(1, "@chd_seqno", chd_seqno, ParameterDirection.Input);
                   dbManager.AddParameters(2, "@chd_fileno", chd_fileno, ParameterDirection.Input);
                   dbManager.AddParameters(3, "@chd_invno", chd_invno, ParameterDirection.Input);
                   dbManager.AddParameters(4, "@chd_descr", chd_descr, ParameterDirection.Input);
                   dbManager.AddParameters(5, "@chd_netdue", chd_netdue, ParameterDirection.Input);
                   dbManager.AddParameters(6, "@chd_amtpaid", chd_amtpaid, ParameterDirection.Input);
                   dbManager.AddParameters(7, "@luid", luid, ParameterDirection.Input);
                   dbManager.AddParameters(8, "@Status", Status, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_chd_receiptno", chd_receiptno, ParameterDirection.Input);
                   dbManager.AddParameters(1, "v_chd_seqno", chd_seqno, ParameterDirection.Input);
                   dbManager.AddParameters(2, "v_chd_fileno", chd_fileno, ParameterDirection.Input);
                   dbManager.AddParameters(3, "v_chd_invno", chd_invno, ParameterDirection.Input);
                   dbManager.AddParameters(4, "v_chd_descr", chd_descr, ParameterDirection.Input);
                   dbManager.AddParameters(5, "v_chd_netdue", chd_netdue, ParameterDirection.Input);
                   dbManager.AddParameters(6, "v_chd_amtpaid", chd_amtpaid, ParameterDirection.Input);
                   dbManager.AddParameters(7, "v_luid", luid, ParameterDirection.Input);
                   dbManager.AddParameters(8, "v_Status", Status, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "SAVE_CASHDETAILS");
               }
               else
               {
                   da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_CASHDETAILS");
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
       internal void SaveCashMaster(string chm_receiptno, string chn_depositdate, string chm_chkno, string chm_chkdate, float chm_amt, float chm_totPaid, string chm_billto, string chm_importer, string chm_remarks, string luid, int Status)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(11);
               int res = 0;
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@chm_receiptno", chm_receiptno, ParameterDirection.Input);
                   dbManager.AddParameters(1, "@chn_depositdate", chn_depositdate, ParameterDirection.Input);
                   dbManager.AddParameters(2, "@chm_chkno", chm_chkno, ParameterDirection.Input);
                   dbManager.AddParameters(3, "@chm_chkdate", chm_chkdate, ParameterDirection.Input);
                   dbManager.AddParameters(4, "@chm_amt", chm_amt, ParameterDirection.Input);
                   dbManager.AddParameters(5, "@chm_totPaid", chm_totPaid, ParameterDirection.Input);
                   dbManager.AddParameters(6, "@chm_billto", chm_billto, ParameterDirection.Input);
                   dbManager.AddParameters(7, "@chm_importer", chm_importer, ParameterDirection.Input);
                   dbManager.AddParameters(8, "@chm_remarks", chm_remarks, ParameterDirection.Input);
                   dbManager.AddParameters(9, "@luid", luid, ParameterDirection.Input);
                   dbManager.AddParameters(10, "@Status", Status, ParameterDirection.Input);
                   
               }
               else
               {
                   dbManager.AddParameters(0, "v_chm_receiptno", chm_receiptno, ParameterDirection.Input);
                   dbManager.AddParameters(1, "v_chn_depositdate", chn_depositdate, ParameterDirection.Input);
                   dbManager.AddParameters(2, "v_chm_chkno", chm_chkno, ParameterDirection.Input);
                   dbManager.AddParameters(3, "v_chm_chkdate", chm_chkdate, ParameterDirection.Input);
                   dbManager.AddParameters(4, "v_chm_amt", chm_amt, ParameterDirection.Input);
                   dbManager.AddParameters(5, "v_chm_totPaid", chm_totPaid, ParameterDirection.Input);
                   dbManager.AddParameters(6, "v_chm_billto", chm_billto, ParameterDirection.Input);
                   dbManager.AddParameters(7, "v_chm_importer", chm_importer, ParameterDirection.Input);
                   dbManager.AddParameters(8, "v_chm_remarks", chm_remarks, ParameterDirection.Input);
                   dbManager.AddParameters(9, "v_luid", luid, ParameterDirection.Input);
                   dbManager.AddParameters(10, "v_Status", Status, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.ExecuteNonQuery(CommandType.StoredProcedure, "SAVE_CASHMASTER");
               }
               else
               {
                   da.ExecuteOracleNonQuery(dbManager, CommandType.StoredProcedure, "SAVE_CASHMASTER");
                   
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
       internal DataTable GetCheckRecptNo(string chkNo)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(1);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@CASHRECPTNO", chkNo, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_CASHRECPTNO", chkNo, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_CASHMASTER");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CASHMASTER", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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
       internal int GetCashAutoNumber()
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               int num = 0;
               DataSet ds = new DataSet();

               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {

                   IDataReader reader = dbManager.ExecuteReader(CommandType.StoredProcedure, "GET_CHECKNUMBER");

                   while (reader.Read())
                   {
                       if (reader["aut_number"].ToString() != "")
                       {
                           num = int.Parse(reader["aut_number"].ToString());
                       }
                   }
               }
               else
               {

                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CHECKNUMBER", cursor);
                   DataTable dt = new DataTable();
                   dt = ds.Tables[0];
                   if (dt.Rows[0]["aut_number"].ToString() != "")
                   {
                       num = int.Parse(dt.Rows[0]["aut_number"].ToString());
                   }
               }


               return num;
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

       internal DataTable ChkInvagainstFileNo(string invNo, string fileNo)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(2);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@FILENO", fileNo, ParameterDirection.Input);
                   dbManager.AddParameters(1, "@INVNO", invNo, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_FILENO", fileNo, ParameterDirection.Input);
                   dbManager.AddParameters(1, "v_INVNO", invNo, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_FILENOBYINVOICE");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_FILENOBYINVOICE", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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
       internal DataTable GetBillMstrByFileNo(string fileNo, string invNo)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(2);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@FILENO", fileNo, ParameterDirection.Input);
                   dbManager.AddParameters(1, "@INVNO", invNo, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_FILENO", fileNo, ParameterDirection.Input);
                   dbManager.AddParameters(1, "v_INVNO", invNo, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_BILLMSTRBYFILENO");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_BILLMSTRBYFILENO", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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
       internal DataTable GetBillTo(string code)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(1);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
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
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_BILLTONAMEFRMVIEW");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_BILLTONAMEFRMVIEW", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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
       internal DataTable GetPayToName(string code)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(1);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
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
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_PAYTONAME");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_PAYTONAME", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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

       internal DataTable GetCheckNoFrmCashMaster(string chkNo)
       {
           IDBManager dbManager = CommonConnection.Connectionstring();
           try
           {
               dbManager.Open();
               dbManager.CreateParameters(1);
               DataSet ds = new DataSet();
               DataTable dt = new DataTable();
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   dbManager.AddParameters(0, "@CHECKNO", chkNo, ParameterDirection.Input);
               }
               else
               {
                   dbManager.AddParameters(0, "v_CHECKNO", chkNo, ParameterDirection.Input);
               }
               if (ConfigurationManager.AppSettings["DataB"] == "SQL")
               {
                   ds = dbManager.ExecuteDataSet(CommandType.StoredProcedure, "GET_CHKNOFRMCASHMSTR");
               }
               else
               {
                   string[] cursor = new string[1];
                   cursor[0] = "cv_1";
                   ds = da.ExecuteOracleDataSet(dbManager, CommandType.StoredProcedure, "GET_CHKNOFRMCASHMSTR", cursor);
               }
               dt = ds.Tables[0];
               return dt;
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

