using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{

    public class CategoryCodesBLL
    {

        CategoryCodesDAL clsDAL = new CategoryCodesDAL();
        public DataSet Open_GPMCATCDE()
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Open_GPMCATCDE();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Save_GPMCATCDE(string Xmldata)
        {
            return clsDAL.Save_GPMCATCDE(Xmldata);
        }
    }
}
