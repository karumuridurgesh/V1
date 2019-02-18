using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class GPListCodeBLL
    {
        GPListCodeDAL clsDAL = new GPListCodeDAL();
        public DataSet Open_PagingGrid()
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Open_PagingGrid();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_GPLSTCD(string ListCode)
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Fetch_GPLSTCD(ListCode);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Save_GPLSTCD(string Xmldata, string Mode, string Active,string ListCode,string LName)
        {
            return clsDAL.Save_GPLSTCD(Xmldata, Mode,Active,ListCode,LName);
        }
        //FetchListCode
    }
}
