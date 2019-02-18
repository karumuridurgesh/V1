using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{
    public class ReportBLL
    {
        ReportDAL clsReportDAL = new ReportDAL();
        public DataSet Open_Report()
        {
            try
            {
                return clsReportDAL.Open_Report();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_DriverCheckList(string id7512, string BeginDate, string EndDate,string Print)
        {
            try
            {
                return clsReportDAL.Fetch_DriverCheckList(id7512, BeginDate, EndDate,Print);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Open_DriverCheckReport()
        {
            try
            {
                return clsReportDAL.Open_DriverCheckReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Save_DriverCheckList(string CustCode, string Printtype, string SaveXML)
        {
            try
            {
                return clsReportDAL.Save_DriverCheckList(CustCode, Printtype, SaveXML);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
