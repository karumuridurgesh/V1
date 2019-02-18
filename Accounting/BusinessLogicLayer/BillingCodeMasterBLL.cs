using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.DataAccessLayer;
using System.Data;
//test for ALM 1
namespace Accounting.BusinessLogicLayer
{
    public class BillingCodeMasterBLL
    {
        BillingCodeMasterDAL clsBillingCodeMasterDAL = new BillingCodeMasterDAL();

        public DataSet Open_PRENTINVRC()
        {
            try
            {
                return clsBillingCodeMasterDAL.Open_PRENTINVRC();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Save_ACNTGBLCD(string sSaveXml, string Mode)
        {
            try
            {
                return clsBillingCodeMasterDAL.Save_ACNTGBLCD(sSaveXml, Mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_ACNTGBLCD(string sMode, string sVal1)
        {
            try
            {
                return clsBillingCodeMasterDAL.Fetch_ACNTGBLCD(sMode, sVal1);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Save_ACNTGGBCL(string sSaveXml)
        {
            try
            {
                return clsBillingCodeMasterDAL.Save_ACNTGGBCL(sSaveXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_BILLMASDETHIS(string sFileno,string sInvoiceno)
        {
            try
            {
                return clsBillingCodeMasterDAL.Fetch_BILLMASDETHIS(sFileno, sInvoiceno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
