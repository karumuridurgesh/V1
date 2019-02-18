using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GlobalPartsLibrary.DataAccessLayer;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class GlobalParts1BLL
    {
        GlobalParts1DAL clsDAL = new GlobalParts1DAL();
        public DataTable GetCountryByCode(string code)
        {
            try
            {
                DataTable dt;
                dt = clsDAL.GetCountryByCode(code);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Open_CountrySetUp()
        {
            try
            {
                return clsDAL.Open_CountrySetUp();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveCountrySetUp(string countryCode, string companyCode, string UserCode, string xmlData)
        {
            try
            {
                int i = 0;
                return i = clsDAL.SaveCountrySetUp(countryCode, companyCode, UserCode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetOrgDefaults(string cntryCode, string company)
        {
            try
            {
                DataTable dt = new DataTable();
                return dt = clsDAL.GetOrgDefaults(cntryCode, company);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Open_CountryDocSetUp()
        {
            try
            {
                return clsDAL.Open_CountryDocSetUp();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCntryBaseDocCodes(string cntryCode, string company)
        {
            try
            {
                DataTable dt = new DataTable();
                return dt = clsDAL.GetCntryBaseDocCodes(cntryCode, company);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveCountryDocSetUp(string countryCode, string companyCode, string UserCode, string xmlData)
        {
            try
            {
                int i = 0;
                return i = clsDAL.SaveCountryDocSetUp(countryCode, companyCode, UserCode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int SaveCountryTASetUp(string countryCode, string companyCode, string UserCode, string xmlData)
        {
            try
            {
                int i = 0;
                return i = clsDAL.SaveCountryTASetUp(countryCode, companyCode, UserCode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetCntryDocSetUp(string cntryCode)
        {
            try
            {                
                return  clsDAL.GetCntryDocSetUp(cntryCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCntryTASetUp(string cntryCode, string company)
        {
            try
            {
                DataTable dt = new DataTable();
                return dt = clsDAL.GetCntryTASetUp(cntryCode, company);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public DataSet GetCntrySpecificDetails(string cntryCode, string company, string partID)
        {
            try
            {
                DataSet ds = new DataSet();
                return ds = clsDAL.GetCntrySpecificDetails(cntryCode, company, partID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet GetGlobalPartMaster(string sMode, string sInputXml)
        {
            try
            {
                DataSet ds = new DataSet();
                return ds = clsDAL.GetGlobalPartMaster(sMode, sInputXml);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Open_GlobalParts()
        {
            try
            {
                return clsDAL.Open_GlobalParts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SaveGPMaster(string companyCode, string partCode, string UserCode, string xmlData,string sMode)
        {
            try
            {
                clsDAL.SaveGPMaster(companyCode, partCode, UserCode, xmlData, sMode);
                }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GPHTSNotification_SKU(string xmlData, string CNTY, string NewHTS, string HTS, string actiontype, string UserCode)
        {
            try
            {
             return   clsDAL.GPHTSNotification_SKU(xmlData, CNTY, NewHTS, HTS, actiontype, UserCode );
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataSet Open_GPHTSNotification_SKU(string CmpID, string Cnty)
        {
            try
            {
                return clsDAL.Open_GPHTSNotification_SKU(CmpID,Cnty);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DataSet Get_CNTRYHTS(string XML, string Cntry,string Descr)
        {
            try
            {                
                return clsDAL.Get_CNTRYHTS(XML, Cntry,Descr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Open_PARTSUM()
        {
            try
            {
                return clsDAL.Open_PARTSUM();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
