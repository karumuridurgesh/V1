using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{
    public class AbwPoRcptBLL
    {
        AbwPORcptDAL clsAbwPORcptDAL = new AbwPORcptDAL();
        public DataSet Open_AbwPORcpt()
        {
            try
            {
                return clsAbwPORcptDAL.Open_AbwPORcpt();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_AbwPORcpt(string sMode, string sval)
        {
            try
            {
                return clsAbwPORcptDAL.Fetch_AbwPORcpt(sMode, sval);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Save_AbwPORcpt(string sSaveXmdata, string sMode, string OrgCd)
        {
            try
            {
                return clsAbwPORcptDAL.Save_AbwPORcpt(sSaveXmdata, sMode, OrgCd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet DFAPORDateChange(string Em_fileno, DateTime TranDate)
        {
            try
            {
                return clsAbwPORcptDAL.DFAPORDateChange(Em_fileno, TranDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_ABWCHNPOLC(string sval)
        {
            try
            {
                return clsAbwPORcptDAL.Fetch_ABWCHNPOLC(sval);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet ABWchangePOlocation(string Em_fileno, string LocCode)
        {
            try
            {
                return clsAbwPORcptDAL.ABWchangePOlocation(Em_fileno, LocCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_ABWHISCORR(string Fileno)
        {
            try
            {
                return clsAbwPORcptDAL.Fetch_ABWHISCORR(Fileno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Save_ABWHISCORR(string sFileno, string sSaveXmdata, string sMode)
        {
            try
            {
                return clsAbwPORcptDAL.Save_ABWHISCORR(sFileno, sSaveXmdata, sMode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
