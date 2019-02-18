using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Accounting.DataAccessLayer;
namespace Accounting.BusinessLogicLayer
{
    public class BillingCodesBLL
    {
        BillingCodesDAL clsBillCodesDAL = new BillingCodesDAL();

        public DataTable GetCompBillingCodes()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsBillCodesDAL.GetCompBillingCodes();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SaveBillingCodes(string bill_code, string bill_descr, string bill_def_vendor, float bill_def_amount, float bill_def_percent,
            string luid, string bill_internalCode, string bill_type, int IsActive, int status)
        {
            try
            {

                clsBillCodesDAL.SaveBillingCodes(bill_code, bill_descr, bill_def_vendor, bill_def_amount, bill_def_percent,
            luid, bill_internalCode, bill_type, IsActive, status);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoveBillCode(string billCode)
        {
            try
            {

                clsBillCodesDAL.RemoveBillCode(billCode);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
