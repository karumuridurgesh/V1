using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Accounting.DataAccessLayer;


namespace Accounting.BusinessLogicLayer
{
    public class ImpBillingBLL
    {
        ImpBillingDAL clsImpBillDAL = new ImpBillingDAL();
        public DataTable CheckForImpLnkCode(string impCode, string billCode)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsImpBillDAL.CheckForImpLnkCode(impCode, billCode);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetImpBillingDetails(string compCode)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsImpBillDAL.GetImpBillingDetails(compCode);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SaveLinkImpBilling(string compCode, string billCode, string billName, float value, string calcVal, int status, int codeStatus)
        {
            try
            {
                DataTable dt = new DataTable();
                clsImpBillDAL.SaveLinkImpBilling(compCode, billCode, billName, value, calcVal, status, codeStatus);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoveImpBillCode(string ImpCode, string billCode)
        {
            try
            {
                clsImpBillDAL.RemoveImpBillCode(ImpCode, billCode);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetBilMstrDet(string fileNo, string invSeqNo)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = clsImpBillDAL.GetBilMstrDet(fileNo, invSeqNo);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetBilDetails(string fileNo, string type, string invNo)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsImpBillDAL.GetBilDetails(fileNo, type, invNo);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Save_BillingMaster(string BLM_FILENO, string BLM_INVNO, string BLM_ENTRYNO, DateTime BLM_INV_DATE, string BLM_MBNO, string BLM_HBNO, string BLM_SBNO,
          string BLM_IMPORTERNO, string BLM_BILLTO, string BLM_PAY_TERMS, string BLM_REFNO, string BLM_REMARKS, float BLM_BILLTOT, float BLM_PAYOUTTOT, string LUID,
           float blm_pieces, float blm_weight, string blm_descr, string blm_shipper, string blm_consg_name, string blm_origin, string blm_dest, DateTime blm_arrivaldate,
           DateTime blm_entrydate, string blm_carrier, string BLM_PrintYorN, float blm_amtpaid, string blm_GenYorN, int Id, string BLM_INVREF, int Status)
        {
            int res = 0;
            try
            {
                res = clsImpBillDAL.Save_BillingMaster(BLM_FILENO, BLM_INVNO, BLM_ENTRYNO, BLM_INV_DATE, BLM_MBNO, BLM_HBNO, BLM_SBNO,
            BLM_IMPORTERNO, BLM_BILLTO, BLM_PAY_TERMS, BLM_REFNO, BLM_REMARKS, BLM_BILLTOT, BLM_PAYOUTTOT, LUID,
             blm_pieces, blm_weight, blm_descr, blm_shipper, blm_consg_name, blm_origin, blm_dest, blm_arrivaldate,
             blm_entrydate, blm_carrier, BLM_PrintYorN, blm_amtpaid, blm_GenYorN, Id, BLM_INVREF, Status,string.Empty);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save_BillingDetails(string bld_fileno, string bld_invno, int bld_seqno, string bld_bill_code, string bld_bill_descr, float bld_pay_amt, string bld_pay_vendor, string bld_refno, string luid, float bld_bill_amt, string bld_VendorRefno, int Status, string bld_bill_descriptor)
        {
            try
            {
                DataTable dt = new DataTable();
                clsImpBillDAL.Save_BillingDetails(bld_fileno, bld_invno, bld_seqno, bld_bill_code, bld_bill_descr, bld_pay_amt, bld_pay_vendor, bld_refno, luid, bld_bill_amt, bld_VendorRefno, Status, bld_bill_descriptor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetDutyFees(string fileNo, string impCode)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = clsImpBillDAL.GetDutyFees(fileNo, impCode);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetCheckImporters(string fileNo, string billCode)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = clsImpBillDAL.GetCheckImporters(fileNo, billCode);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetVendorCheck(string code)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsImpBillDAL.GetVendorCheck(code);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update_BillingAmount(string fileNo, string billCode, float billAmt, string strVendor, string updatedby)
        {
            try
            {
                clsImpBillDAL.Update_BillingAmount(fileNo, billCode, billAmt, strVendor, updatedby);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void VoidBillingMaster(string strFileNo, string invNo)
        {
            try
            {
                clsImpBillDAL.VoidBillingMaster(strFileNo, invNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetDefBillTo(string strImpCode,string sFileno)
        {
            try
            {                
                return clsImpBillDAL.GetDefBillTo(strImpCode, sFileno);              
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //code added by geetha 05.04.2010
        public int LastPageNumber
        {
            get { return clsImpBillDAL.LastPageNumber; }
        }
        public DataTable GetBillPaging(int startRecord, int recordCount, int lastRecord, int pageNumber, string query)
        {
            try
            {
                DataTable dtResults = new DataTable();
                dtResults = clsImpBillDAL.GetBillPaging(startRecord, recordCount, lastRecord, pageNumber, query);
                return dtResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //end

        public DataTable GetVendorBillsbyEntryNo(string entryNo)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsImpBillDAL.GetVendorBillsbyEntryNo(entryNo);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Save_BillingMaster(string BLM_FILENO, string BLM_INVNO, string BLM_ENTRYNO, DateTime BLM_INV_DATE, string BLM_MBNO, string BLM_HBNO, string BLM_SBNO,
         string BLM_IMPORTERNO, string BLM_BILLTO, string BLM_PAY_TERMS, string BLM_REFNO, string BLM_REMARKS, float BLM_BILLTOT, float BLM_PAYOUTTOT, string LUID,
          float blm_pieces, float blm_weight, string blm_descr, string blm_shipper, string blm_consg_name, string blm_origin, string blm_dest, DateTime blm_arrivaldate,
          DateTime blm_entrydate, string blm_carrier, string BLM_PrintYorN, float blm_amtpaid, string blm_GenYorN, int Id, string BLM_INVREF, int Status, string sIsFinalize)
        {
            int res = 0;
            try
            {
                res = clsImpBillDAL.Save_BillingMaster(BLM_FILENO, BLM_INVNO, BLM_ENTRYNO, BLM_INV_DATE, BLM_MBNO, BLM_HBNO, BLM_SBNO,
            BLM_IMPORTERNO, BLM_BILLTO, BLM_PAY_TERMS, BLM_REFNO, BLM_REMARKS, BLM_BILLTOT, BLM_PAYOUTTOT, LUID,
             blm_pieces, blm_weight, blm_descr, blm_shipper, blm_consg_name, blm_origin, blm_dest, blm_arrivaldate,
             blm_entrydate, blm_carrier, BLM_PrintYorN, blm_amtpaid, blm_GenYorN, Id, BLM_INVREF, Status, sIsFinalize);
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
