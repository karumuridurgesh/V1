using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{
   public  class ATFReceiptBLL
    {
        ATFRcptDAL clsATFRcptDAL = new ATFRcptDAL();
        public DataSet Open_ATFRcpt()
        {
            try
            {
                return clsATFRcptDAL.Open_ATFRcpt();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_ATFRcpt(string sMode,string sVal)
        {
            try
            {
                return clsATFRcptDAL.Fetch_ATFRcpt(sMode,sVal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Save_ATFRcpt(string sSaveXmdata, string sMode)
        {
            try
            {
                return clsATFRcptDAL.Save_ATFRcpt(sSaveXmdata, sMode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
