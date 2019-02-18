using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Accounting.DataAccessLayer;

namespace Accounting.BusinessLogicLayer
{
    public class GBillingCodesBLL
    {
        GBillingCodesDAL clsBillCodesDAL = new GBillingCodesDAL();

        public DataTable GetGlobalBillingCodes()
        {
            try
            {
                //Adding comments to test alm changes1
                DataTable dt = new DataTable();
                dt = clsBillCodesDAL.GetGlobalBillingCodes();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetGlobalOTHBillingCodes(string billcode)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsBillCodesDAL.GetGlobalOTHBillingCodes(billcode);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void RemoveGBillCode(string billCode)
        {
            try
            {

                clsBillCodesDAL.RemoveGBillCode(billCode);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveGOTHBillCodes(string bill_code, int seqno, string fldind, float from, float to, float value, float unitrate, int status)
        {
            try
            {
                clsBillCodesDAL.SaveGOTHBillCodes(bill_code, seqno, fldind, from, to, value, unitrate,  status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveGBillingCodes(string bill_code, string bill_descr, string fldind, float bill_def_amount, float bill_def_percent,
        string luid, float maxamt, float minamt, int addsub, string oth, int IsActive, int status)
        {
            try
            {
                clsBillCodesDAL.SaveGBillingCodes(bill_code, bill_descr, fldind, bill_def_amount, bill_def_percent, luid, maxamt, minamt, addsub, oth, IsActive, status);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
