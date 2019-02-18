using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GlobalPartsLibrary.DataAccessLayer;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class QuickLinksBLL
    {
        QuickLinksDAL clsDAL = new QuickLinksDAL();
        public DataSet Open_GPMQCKLNKS()
        {
            try
            {
                DataSet ds;
                ds = clsDAL.Open_GPMQCKLNKS();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
