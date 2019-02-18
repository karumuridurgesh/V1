using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{
    public class ABWListSummaryBLL
    {
        ABWListSummaryDAL clsABWListSummary = new ABWListSummaryDAL();
        public DataSet Open_ABWLSTSUMRY()
        {
            try
            {
                return clsABWListSummary.Open_ABWLSTSUMRY();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Open_ABWLSTCD()
        {
            try
            {
                return clsABWListSummary.Open_ABWLSTCD();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet FetchListCode(string ListCode)
        {
            try
            {
                return clsABWListSummary.FetchListCode(ListCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Save_ABWLSTCD(string Xmldata, string Mode)
        {
            return clsABWListSummary.Save_ABWLSTCD(Xmldata, Mode);
        }
    }
}
