using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.DataAccessLayer;
using System.Data;

namespace Accounting.BusinessLogicLayer
{
    public class CompanyBillingSetupBLL
    {
        CompanyBillingSetupDAL clsCompanyBillingSetupDAL = new CompanyBillingSetupDAL();

        public DataSet Open_ACNTGCMPBL()
        {
            try
            {
                return clsCompanyBillingSetupDAL.Open_ACNTGCMPBL();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_ACNTGCMPBL(string sMode, string sVal1, string sCmp)
        {
            try
            {
                return clsCompanyBillingSetupDAL.Fetch_ACNTGCMPBL(sMode, sVal1, sCmp);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Save_ACNTGCMPBL(string sSaveXml, string Mode)
        {
            try
            {
                return clsCompanyBillingSetupDAL.Save_ACNTGCMPBL(sSaveXml, Mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Save_ACNTGCBCL(string sSaveXml, string sMode)
        {
            try
            {
                return clsCompanyBillingSetupDAL.Save_ACNTGCBCL(sSaveXml, sMode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
