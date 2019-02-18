using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GlobalPartsLibrary.DataAccessLayer;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
   public class ProfileScreenBLL
    {
        ProfileScreenDAL clsDAL = new ProfileScreenDAL();
        public DataSet Open_GPMProfile(string Mode)
        {
            try
            {
               return clsDAL.Open_GPMProfile(Mode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Fetch_GPPrfHTS(string CntyCode)
        {
            try
            {
                return clsDAL.Fetch_GPPrfHTS(CntyCode);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet Fetch_GPPrfDtls(string Prfname,string PrfId)
        {
            try
            {
                return clsDAL.Fetch_GPPrfDtls(Prfname,PrfId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public string Save_GPPrfDtls(string strXML,string Cmpcd,string PrfNm,string PrfType,string CatCd,int Active,string AtrVal,string AttrId)
        //{
        //    try
        //    {
        //        return clsDAL.Save_GPPrfDtls(strXML,Cmpcd,PrfNm,PrfType,CatCd,Active,AtrVal,AttrId);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        public string Save_GPPrfDtls(string strXML)
        {
            try
            {
                return clsDAL.Save_GPPrfDtls(strXML);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet Fetch_GPCtgDtls(string CatCd)
        {
            try
            {
                return clsDAL.Fetch_GPCtgDtls(CatCd);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet UserAction(string sMode, string sval1,string sVal2)
        {
            try
            {
                return clsDAL.UserAction(sMode, sval1,sVal2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}
