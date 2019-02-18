using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GlobalPartsLibrary.DataAccessLayer;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class PartSummaryBLL
    {
        PartSummaryDAL clsDAL = new PartSummaryDAL();
        public DataSet Fetch_GPMPARTSUM(string sPKvalue, string FromDate, string TODate, string Value)
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Fetch_GPMPARTSUM(sPKvalue, FromDate, TODate, Value);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_HTSDataToExcel(string CtyCode)
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Fetch_HTSDataToExcel(CtyCode);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region GP latest changes by Madhu
        public DataSet Save_PARTVSSRVREQ(string sMode, string sSaveXml, string InputParam)
        {
            try
            {
                return clsDAL.Save_PARTVSSRVREQ(sMode, sSaveXml, InputParam);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        public DataSet Open_GPSUM()
        {
            try
            {
                return clsDAL.Open_GPSUM();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
