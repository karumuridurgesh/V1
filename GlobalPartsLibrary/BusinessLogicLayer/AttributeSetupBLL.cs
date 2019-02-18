using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class AttributeSetupBLL
    {
        AttributeSetupDAL AttbtSuDAL = new AttributeSetupDAL();
        public DataSet Open_GPMATTBTSU()
        {
            try
            {
                return AttbtSuDAL.Open_GPMATTBTSU();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Save_GPMATTBTSU(string strLvl, string strPK1, string strPK2, int strPK3,string xmlData)
        {
            try
            {
                return AttbtSuDAL.Save_GPMATTBTSU(strLvl, strPK1, strPK2, strPK3, xmlData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet Fetch_GPMATTBTSU(string strLvl, string strPK1,string Mode, int LISTID)
        {
            try
            {
                return AttbtSuDAL.Fetch_GPMATTBTSU(strLvl, strPK1, Mode, LISTID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Open_GPMATTBTSUMRY()
        {
            try
            {
                return AttbtSuDAL.Open_GPMATTBTSUMRY();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //--AttributeMst
        public DataSet Open_GPMATTBTMST()
        {
            try
            {
                return AttbtSuDAL.Open_GPMATTBTMST();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataSet Fetch_GPMATTBTMST(string strLvl, int ATTBTID)
        {
            try
            {
                return AttbtSuDAL.Fetch_GPMATTBTMST(strLvl, ATTBTID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Save_GPMATTBTMST(string strLvl, string strMode, string xmlData, int ATTBTID)
        {
            try
            {
                return AttbtSuDAL.Save_GPMATTBTMST(strLvl, strMode, xmlData, ATTBTID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
