using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKABWLibrary.DataAccessLayer;
using System.Data;

namespace GTKABWLibrary.BusinessLogicLayer
{
    public class ManualATFSalesBLL
    {
        ManualATFSalesDAL clsMATFSDAL = new ManualATFSalesDAL();
        public DataSet Open_ABWMATFS()
        {
            try
            {
                return clsMATFSDAL.Open_ABWMATFS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Save_ABWMATFS(string strMode, string xmlData)
        {
            try
            {
                return clsMATFSDAL.Save_ABWMATFS(strMode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Get_LOV(string LOVQualifier, string FteCode, string SectionName, string FieldName, string EnteredXML)
        {
            try
            {
                return clsMATFSDAL.Get_LOV(LOVQualifier, FteCode, SectionName, FieldName, EnteredXML);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Validate_EnteredValueString(string SectionName, string FieldName, string Qualifier, string EnteredXML)
        {
            try
            {
                return clsMATFSDAL.Validate_EnteredValueString(SectionName, FieldName, Qualifier, EnteredXML);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet MATFSAction(string sMode, string sval1)
        {
            try
            {
                return clsMATFSDAL.MATFSAction(sMode, sval1);
            }
            catch (Exception ex)
            {

                throw ex;


            }
        }

        public DataSet Fetch_ABWMATFS(string strMode, string xmlData)
        {
            try
            {
                return clsMATFSDAL.Fetch_ABWMATFS(strMode, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
