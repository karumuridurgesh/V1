using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{
    public class ManualAdjustmentBLL
    {
        ManualAdjustmentDAL clsManualAdjustmentDAL = new ManualAdjustmentDAL();

        public DataSet Open_ABWMADJT()
        {
            try
            {
                return clsManualAdjustmentDAL.Open_ABWMADJT();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Save_ABWMADJT(string strMode, string xmlData)
        {
            try
            {
                return clsManualAdjustmentDAL.Save_ABWMADJT(strMode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_ABWMADJT(string strMode, string xmlData, string LocationId, string FileNo)
        {
            try
            {
                return clsManualAdjustmentDAL.Fetch_ABWMADJT(strMode, xmlData,LocationId,FileNo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet MADJAction(string sMode, string sval1)
        {
            try
            {
                return clsManualAdjustmentDAL.MADJAction(sMode, sval1);
            }
            catch (Exception ex)
            {

                throw ex;


            }
        }

        public DataSet Fetch_FIFOADJ(string strMode, string xmlData, string LocationId)
        {
            try
            {
                return clsManualAdjustmentDAL.Fetch_FIFOADJ(strMode, xmlData, LocationId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
