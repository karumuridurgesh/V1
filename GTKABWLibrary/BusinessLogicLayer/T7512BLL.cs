using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{

    public class T7512BLL
    {
        T7512DAL clsT7512DAL = new T7512DAL();

        public DataSet Open_PagingGrid()
        {
            try
            {
                return clsT7512DAL.Open_PagingGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_ABWT7512(string strMode, string xmlData)
        {
            try
            {
                return clsT7512DAL.Fetch_ABWT7512(strMode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet T7512Action(string sMode, string sval1)
        {
            try
            {
                return clsT7512DAL.T7512Action(sMode, sval1);
            }
            catch (Exception ex)
            {

                throw ex;


            }
        }

        public DataSet Save_ABWT7512(string strMode, string xmlData)
        {
            try
            {
                return clsT7512DAL.Save_ABWT7512(strMode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_ABWT7512Products(string Mode, string PrdCds, string Locid)
        {
            try
            {
                return clsT7512DAL.Fetch_ABWT7512Products(Mode, PrdCds, Locid);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet GTKINBOUT(string sTranId, string sImpCode)
        {
            try
            {
                return clsT7512DAL.GTKINBOUT(sTranId, sImpCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Replace_CF7512(string OldCF7512, string NewCF7512, string Remarks)
        {
            try
            {
                clsT7512DAL.Replace_CF7512(OldCF7512, NewCF7512, Remarks);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_REPRNT7512(string BeginDate, string EndDate, string Invoice, string strMode, string xmlData)
        {
            try
            {
                return clsT7512DAL.Fetch_REPRNT7512(BeginDate, EndDate, Invoice, strMode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Del_Fetchdel7512(string tranno)
        {
            try
            {
                return clsT7512DAL.Del_Fetchdel7512(tranno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ABW_CancelT7512(string tranno)
        {
            try
            {
                return clsT7512DAL.ABW_CancelT7512(tranno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
