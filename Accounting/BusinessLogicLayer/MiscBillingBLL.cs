using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.DataAccessLayer;
using System.Data;

namespace Accounting.BusinessLogicLayer
{
    public class MiscBillingBLL
    {
        MiscBillingDLL clsDAL = new MiscBillingDLL();
        public DataSet Open_ACCMISCBIL()
        {
            try
            {
                return clsDAL.Open_ACCMISCBIL();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_ACCMISCBIL(string sMode, string sValue)
        {
            try
            {
                return clsDAL.Fetch_ACCMISCBIL(sMode, sValue);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Save_ACCMISCBIL(string sSaveXmdata, string sMode, ref string fileno, string InvNo )
        {
            try
            {
                clsDAL.Save_ACCMISCBIL(sSaveXmdata, sMode, ref fileno, InvNo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_ACNTVBRBLG(string sFileNo,string sEntryNo)
        {
            try
            {
                return clsDAL.Fetch_ACNTVBRBLG(sFileNo, sEntryNo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Save_ACNTVBRBLG(string sSavexml)
        {
            try
            {
                return clsDAL.Save_ACNTVBRBLG(sSavexml);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Open_ACNTVBRBLG()
        {
            try
            {
                return clsDAL.Open_ACNTVBRBLG();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
