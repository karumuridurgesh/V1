using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class ListSummaryBLL
    {
       ListSummaryDAL clsDAL = new ListSummaryDAL();
       public DataSet Open_LSTSUMRY()
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Open_LSTSUMRY();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
