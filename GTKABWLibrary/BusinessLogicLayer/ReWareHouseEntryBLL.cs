using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{
    public class ReWareHouseEntryBLL
    {
        ReWareHouseEntryDAL clsReWareHouseEntryDAL = new ReWareHouseEntryDAL();

        public DataSet Open_ABWRWHE()
        {
            try
            {
                return clsReWareHouseEntryDAL.Open_ABWRWHE();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_ABWCF7512No(string ID7512)
        {
            try
            {
                return clsReWareHouseEntryDAL.Fetch_ABWCF7512No(ID7512);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Save_ABWRWHE(string No7512,string xmlData)
        {
            try
            {
                return clsReWareHouseEntryDAL.Save_ABWRWHE( No7512,xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Save_ABWEDD(string FileNo, DateTime PFFDate, DateTime FinalDocDate, string CF300DATE)
        {
            try
            {
                return clsReWareHouseEntryDAL.Save_ABWEDD(FileNo, PFFDate, FinalDocDate, CF300DATE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
