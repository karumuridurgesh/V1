using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GlobalPartsLibrary.DataAccessLayer;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class GlobalPartsBLL
    {
        GlobalPartsDAL clsDAL = new GlobalPartsDAL();
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
        public DataSet Save_GPCTYAttrib(string countryCode, string companyCode, string UserCode, string xmlData)
        {
            try
            {
                return  clsDAL.Save_GPCTYAttrib(countryCode, companyCode, UserCode, xmlData);
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
        
        public DataSet GetCntrySpecificDetails(string cntryCode, string company, int partID)
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

        public void SaveGPMaster(string companyCode, string partCode, string UserCode, string xmlData,string sCategory)
        {
            try
            {
                clsDAL.SaveGPMaster(companyCode, partCode, UserCode, xmlData, sCategory);
                }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataSet Fetch_GPRTS(int iPrtID)
        {
            try
            {
                return clsDAL.Fetch_GPRTS(iPrtID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DataTable GetCategoryByCode(string code)
        {
            try
            {
                DataTable dt;
                dt = clsDAL.GetCategoryByCode(code);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCompanyByCode(string code)
        {
            try
            {
                DataTable dt;
                dt = clsDAL.GetCompanyByCode(code);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Open_CategoryrySetUp()
        {
            try
            {
                return clsDAL.Open_CategoryrySetUp();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Open_CompanySetUp()
        {
            try
            {
                return clsDAL.Open_CompanySetUp();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public int SaveCategorySetUp(string categoryCode, string Category, string UserCode, string xmlData)
        {
            try
            {
                int i = 0;
                return i = clsDAL.SaveCategorySetUp(categoryCode, Category, UserCode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Save_GPCTGYAttrib(string categoryCode, string Category, string UserCode, string xmlData)
        {
            try
            {
                return  clsDAL.Save_GPCTGYAttrib(categoryCode, Category, UserCode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Save_GPCMPNYYAttrib(string companyCode, string company, string UserCode, string xmlData)
        {
            try
            {
                return clsDAL.Save_GPCMPNYYAttrib(companyCode, company, UserCode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        
        public DataTable GetCategorySetUp(string categoryCode, string category)
        {
            try
            {
                DataTable dt = new DataTable();
                return dt = clsDAL.GetCategorySetUp(categoryCode, category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCompanySetUp(string companyCode, string company)
        {
            try
            {
                DataTable dt = new DataTable();
                return dt = clsDAL.GetCompanySetUp(companyCode, company);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
    }
}
