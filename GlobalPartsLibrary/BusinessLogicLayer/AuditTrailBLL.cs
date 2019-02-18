using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GlobalPartsLibrary.DataAccessLayer;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class AuditTrailBLL
    {
        AuditTrailDAL clsAuditTrailDAL = new AuditTrailDAL();
        public DataSet Fetch_GPMAUDIT(string SKU,string ID)
        {
            try
            {
                return clsAuditTrailDAL.Fetch_GPMAUDIT(SKU,ID);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
        public DataSet Fetch_GPMAUDIT_Ctg(string PrtId, string mode, string Param1, string Param2)
        {
            try
            {
                return clsAuditTrailDAL.Fetch_GPMAUDIT_Ctg(PrtId,mode,Param1,Param2);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
