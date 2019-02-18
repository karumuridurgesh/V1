using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;


namespace GTKABWLibrary.BusinessLogicLayer
{
   public class ABWCustomerBLL
    {
        ABWCustomerDAL clsABWCustomerDAL = new ABWCustomerDAL();
        public DataSet Open_ABWCustomer()
        {
            try
            {
                return clsABWCustomerDAL.Open_ABWCustomer();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Save_ABWCustomer(string sMode, string sSaveXmdata)
        {
            try
            {
                clsABWCustomerDAL.Save_ABWCustomer(sMode, sSaveXmdata);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_ABWCustomer(string sMode, string sval)
        {
            try
            {
                return clsABWCustomerDAL.Fetch_ABWCustomer(sMode, sval);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet CustomerAction(string sMode, string sval1)
        {
            try
            {
                return clsABWCustomerDAL.CustomerAction(sMode, sval1);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
