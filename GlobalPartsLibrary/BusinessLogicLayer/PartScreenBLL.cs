using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{

    public class PartScreenBLL
    {
        PartScreenDAL psDAL = new PartScreenDAL();
        public DataSet Open_GPMGPSPTSRN(string HeaderId, string CmpID, string Mode)
        {
            try
            {
                return psDAL.Open_GPMGPSPTSRN(HeaderId, CmpID, Mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Open_GPMGPHsEcSPTSRN(string HeaderId, string CmpID, string Mode,string CatCode)
        {
            try
            {
                return psDAL.Open_GPMGPHsEcSPTSRN(HeaderId, CmpID, Mode,CatCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string GenerateMID(string Name, string Address, string CountryCode, string City)
        {
            try
            {
                return psDAL.GenerateMID(Name, Address, CountryCode, City);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_GpComposition(string PartType)
        {
            try
            {
                return psDAL.Fetch_GpComposition(PartType);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public DataSet Fetch_TariffData(string CntyCode, string HTS)
        {
            try
            {
                 return psDAL.Fetch_TariffData(CntyCode, HTS);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataSet Fetch_SuggestHTS(string CntyCode, string HTS, string  XML , string CmpCd,string RulingId)
        {
            try
            {
                return psDAL.Fetch_GPSUGGESTHTS(CntyCode, HTS, XML, CmpCd,RulingId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataSet Fetch_GPMGPSPTSRNAttr(string Mode, string LISTID, string GPPMHDRID, string GPMLVL, string sDelCatg)
        {
            try
            {
                return psDAL.Fetch_GPMGPSPTSRNAttr(Mode, LISTID, GPPMHDRID, GPMLVL, sDelCatg);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Fetch_GPMGPSPTSRNAttr1(string Mode, string LISTID, string GPPMHDRID, string GPMLVL, string sDelCatg, string CmpCd)
        {
            try
            {
                return psDAL.Fetch_GPMGPSPTSRNAttr1(Mode, LISTID, GPPMHDRID, GPMLVL, sDelCatg, CmpCd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_GPMGPHsEcSPTSRNAttr1(string Mode, string LISTID, string GPPMHDRID, string GPMLVL, string sDelCatg, string CmpCd)
                {
                    try
                    {
                        return psDAL.Fetch_GPMGPHsEcSPTSRNAttr1(Mode, LISTID, GPPMHDRID, GPMLVL, sDelCatg, CmpCd);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }

        public DataSet Fetch_GPMGPSPTSRNCtgAttr(string CtgCd, string GPPMHDRID, string Mode)
        {
            try
            {
                return psDAL.Fetch_GPMGPSPTSRNCtgAttr(CtgCd, GPPMHDRID, Mode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Fetch_GPMGPSPTSRNCmpnyAttr(string CmpnyCd, string GPPMHDRID, string Mode)
        {
            try
            {
                return psDAL.Fetch_GPMGPSPTSRNCmpnyAttr(CmpnyCd, GPPMHDRID, Mode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string Validate_EnteredValueString(string SectionName, string FieldName, string Qualifier, string ValidationType, string EnteredValue, string EnteredXML)
        {
            try
            {
                return psDAL.Validate_EnteredValueString(SectionName, FieldName, Qualifier, ValidationType, EnteredValue, EnteredXML);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_GPMGPSPTSRN(string CmpnyCd, string Partno, string strMode, string ProfileName,
            string ProfileId, string Psearch, string CountryCode)
        {
            try
            {
                return psDAL.Fetch_GPMGPSPTSRN(CmpnyCd, Partno, strMode, ProfileName, ProfileId, Psearch, CountryCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_GPMGPHsEcSPTSRN(string CmpnyCd, string Partno, string strMode, string ProfileName,
           string ProfileId, string Psearch, string CountryCode)
        {
            try
            {
                return psDAL.Fetch_GPMGPHsEcSPTSRN(CmpnyCd, Partno, strMode, ProfileName, ProfileId, Psearch, CountryCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string  Save_GPMGPSPTSRN(string strXML, string strMode, byte[] byteImg, string Profile)
        {
            try

            {
                return psDAL.Save_GPMGPSPTSRN(strXML, strMode, byteImg,Profile);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string Save_GPMGPHsEcSPTSRN(string strXML, string strMode, byte[] byteImg, string Profile,string isRvw)
        {
            try

            {
                return psDAL.Save_GPMGPHsEcSPTSRN(strXML, strMode, byteImg, Profile,isRvw);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Fetch_HTSDetails(string CntyCode, string HTS,string RulingId)
        {
            try
            {
                return psDAL.Fetch_HTSDetails(CntyCode, HTS,RulingId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet Fetch_CategoryDetails(string CategoryCode)
        {
            try
            {
                return psDAL.Fetch_CategoryDetails(CategoryCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_CatSummaryDetails(string strXML)
        {
            try
            {
                return psDAL.Fetch_CatSummaryDetails(strXML);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DataSet ValidateGPDepartments(string DeptCode)
        {
            try
            {
                return psDAL.ValidateGPDepartments(DeptCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public DataSet FETCH_GPMstSettings()
        {
            try
            {
                return psDAL.FETCH_GPMstSettings();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Open_GPMPRTUPLD()
        {
            try
            {
                return psDAL.Open_GPMPRTUPLD();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int SAVE_GPMPRTUPLD(string sImpCd, string sSaveXml, string sMode, string sFilename, string sOrgFileName)
        {
            try
            {
                return psDAL.SAVE_GPMPRTUPLD(sImpCd, sSaveXml, sMode, sFilename, sOrgFileName);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DataSet Fetch_GPMEccnChild(string EccnCd, string Mode)
        {
            try

            {
                return psDAL.Fetch_GPMEccnChild(EccnCd, Mode);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
