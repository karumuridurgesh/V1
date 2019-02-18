using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{
    public class ATFAdjustmentBLL
    {
        ATFAdjustmentDAL clsManualAdjustmentDAL = new ATFAdjustmentDAL();

        public DataSet Open_ABWATFADJ()
        {
            try
            {
                return clsManualAdjustmentDAL.Open_ABWATFADJ();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Save_ABWATFADJ(string strMode, string xmlData)
        {
            try
            {
                return clsManualAdjustmentDAL.Save_ABWATFADJ(strMode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_ABWATFADJ(string strMode, string xmlData, string LocationId)
        {
            try
            {
                return clsManualAdjustmentDAL.Fetch_ABWATFADJ(strMode, xmlData, LocationId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ATFADJAction(string sMode, string sval1)
        {
            try
            {
                return clsManualAdjustmentDAL.ATFADJAction(sMode, sval1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
    }
}
