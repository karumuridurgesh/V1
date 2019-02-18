using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Accounting.DataAccessLayer;

namespace Accounting.BusinessLogicLayer
{
    
   public class checkRelatedBLL
    {
       checkRelatedDAL clsChkDAL = new checkRelatedDAL();
       public DataTable GetCheckDetails(string strCheckNo)
       {
           try
           {
               DataTable dtChkDet = new DataTable();
               dtChkDet = clsChkDAL.GetCheckDetails(strCheckNo);
               return dtChkDet;
           }
           catch(Exception ex)
           {
               throw ex;
           }
       }
       public void SaveCheckDetails(string ckd_chkno, int ckd_seqno, string ckd_fileno, string ckd_refno, float ckd_amtpaid, string chk_billcode, string chk_comments, string luid, int Status)
       {
           try
           {
                clsChkDAL.SaveCheckDetails(ckd_chkno, ckd_seqno, ckd_fileno, ckd_refno, ckd_amtpaid, chk_billcode, chk_comments, luid, Status);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public int SaveCheckMaster(string ckm_chkno, string ckm_payto, string ckm_date, float ckm_amt, string ckm_remarks, string luid, string ckm_numtowordamt, string ckm_printed, string ckm_void, int Status, int id)
       {
           try
           {
               int res = 0;
               res = clsChkDAL.SaveCheckMaster(ckm_chkno, ckm_payto, ckm_date, ckm_amt, ckm_remarks, luid, ckm_numtowordamt, ckm_printed, ckm_void, Status, id);
              return res;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable GetCheckNo(string chkNo)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = clsChkDAL.GetCheckNo(chkNo);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable CheckBillCodes(string code)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = clsChkDAL.CheckBillCodes(code);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public int GetCheckAutoNumber()
       {
           try
           {
               int NUM = 0;
               NUM = clsChkDAL.GetCheckAutoNumber();
               return NUM;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }


       public DataTable GetCashDetails(string strCheckNo)
       {
           try
           {
               DataTable dtChkDet = new DataTable();
               dtChkDet = clsChkDAL.GetCashDetails(strCheckNo);
               return dtChkDet;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public void SaveCashDetails(string chd_receiptno, int chd_seqno, string chd_fileno, string chd_invno, string chd_descr, float chd_netdue, float chd_amtpaid, string luid, int Status)
       {
           try
           {
               clsChkDAL.SaveCashDetails(chd_receiptno,chd_seqno,chd_fileno,chd_invno,chd_descr,chd_netdue,chd_amtpaid,luid,Status);
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public void SaveCashMaster(string chm_receiptno, string chn_depositdate, string chm_chkno, string chm_chkdate, float chm_amt, float chm_totPaid, string chm_billto, string chm_importer, string chm_remarks, string luid, int Status)
       {
           try
           {
               
               clsChkDAL.SaveCashMaster( chm_receiptno,  chn_depositdate,  chm_chkno,  chm_chkdate,  chm_amt,  chm_totPaid,  chm_billto,  chm_importer,  chm_remarks,  luid,  Status);
               
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable GetCheckRecptNo(string chkNo)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = clsChkDAL.GetCheckRecptNo(chkNo);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public int GetCashAutoNumber()
       {
           try
           {
               int NUM = 0;
               NUM = clsChkDAL.GetCashAutoNumber();
               return NUM;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

       public DataTable ChkInvagainstFileNo(string invNo, string fileNo)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = clsChkDAL.ChkInvagainstFileNo(invNo, fileNo);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable GetBillMstrByFileNo(string fileNo, string invNo)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = clsChkDAL.GetBillMstrByFileNo(fileNo, invNo);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable GetBillTo(string code)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = clsChkDAL.GetBillTo(code);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable GetPayToName(string code)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = clsChkDAL.GetPayToName(code);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
       public DataTable GetCheckNoFrmCashMaster(string chkNo)
       {
           try
           {
               DataTable dt = new DataTable();
               dt = clsChkDAL.GetCheckNoFrmCashMaster(chkNo);
               return dt;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }
    }
}
