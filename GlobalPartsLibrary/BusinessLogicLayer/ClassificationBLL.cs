using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class ClassificationBLL:IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public DataSet Open_GPWizard(string sCtyCode)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Open_GPWizard(sCtyCode);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Open_GPECCNWizard(string sCtyCode)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Open_GPECCNWizard(sCtyCode);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_Duties(string sHTSCode, string sCountry, string ChapterNo, string type)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_Duties(sHTSCode, sCountry, ChapterNo,  type);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public DataSet Fetch_GPWizard(string sMode, string sVal, string sCountry)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GPWizard(sMode, sVal, sCountry);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_Notes(string ChapterNo, string type)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_Notes( ChapterNo,  type);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void SAVE_GPBM(string sMode, string sSaveXmdata)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    DAL.SAVE_GPBM(sMode, sSaveXmdata);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_HTSTree(string sCountry, string user, char cMode)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_HTSTree(sCountry, user, cMode);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_HTSECCNTree(string sCountry, string CatCode, string user, string SearchString, char cMode)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_HTSECCNTree(sCountry, CatCode, user, SearchString, cMode);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_GPStepByStep(int QuesNo, string sSelQues, string sProcType, int StepId, int ProcessId,string HTSNo)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GPStepByStep(QuesNo,sSelQues,sProcType,StepId,ProcessId,HTSNo);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Save_PartHTS(string sMode, string sSaveXmdata, string sCompany, string sPart)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    DAL.Save_PartHTS( sMode,  sSaveXmdata,  sCompany,  sPart);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Get_PartHTS(string sCompany, string sPart)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Get_PartHTS(sCompany, sPart);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet GET_PArt()
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.GET_PArt();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_GPwizardHTSGet(string TID, string Country)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GPwizardHTSGet(TID, Country);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_GPwizardECCNGet(string TID, string Country)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GPwizardECCNGet(TID, Country);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Search_GPMCLASSWIZBM(string Search, string Country,string Companycd)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Search_GPMCLASSWIZBM(Search, Country, Companycd);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_TariffData(string CntyCode, string HTS)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_TariffData(CntyCode, HTS);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataSet Fetch_GpRulingYear(string ctyCode)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GpRulingYear(ctyCode);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataSet Fetch_GpRulingMonth(string ctyCode, string year)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GpRulingMonth(ctyCode, year);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Fetch_GpRulingData(string ctyCode, string RulMonth, String Rulyear)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GpRulingData(ctyCode, RulMonth, Rulyear);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataSet Fetch_RulingClassificationData(string Country, String RulNo)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_RulingClassificationData(Country, RulNo);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public DataSet Fetch_SearchResultRuling(string Search, string Country)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_RulingClassificationData(Search, Country);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Fetch_GPMCLASSWIZRulingsByHTS(string Country, string HTS, string Type,string RulMonth,string RulYear)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GPMCLASSWIZRulingsByHTS(Country, HTS, Type, RulMonth, RulYear);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet Open_HtsNotifUpd()
        {
            try
            {
                 using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Open_HtsNotifUpd();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_GPMCLASSWIZRulingsDesc(string RulingId,string Type)
        {
            try
            {
                using (ClassificationDAL DAL = new ClassificationDAL())
                {
                    return DAL.Fetch_GPMCLASSWIZRulingsDesc( RulingId,Type);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
