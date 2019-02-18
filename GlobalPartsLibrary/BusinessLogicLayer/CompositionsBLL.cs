using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class CompositionsBLL
    {
        CompositionsDAL clsDAL = new CompositionsDAL();
        public DataSet Open_GPCMPSTN()
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Open_GPCMPSTN();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_GPCMPSTN(string CType, string CmpCd)
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Fetch_GPCMPSTN(CType, CmpCd);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Save_GPCMPSTN(string Xmldata)
        {
            return clsDAL.Save_GPCMPSTN(Xmldata);
        }
    }
}
