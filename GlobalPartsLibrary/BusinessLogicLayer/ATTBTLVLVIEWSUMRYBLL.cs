using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GlobalPartsLibrary.DataAccessLayer;
using System.Data;

namespace GlobalPartsLibrary.BusinessLogicLayer
{
    public class ATTBTLVLVIEWSUMRYBLL
    {
        ATTBTLVLVIEWSUMRYDAL clsATTBTLVLVWDAL = new ATTBTLVLVIEWSUMRYDAL();
        public DataSet Open_GPMATTBTLVLVW()
        {
            try
            {
                return clsATTBTLVLVWDAL.Open_GPMATTBTLVLVW();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet Fetch_GPMATTBTLVLVW(string strLvl, int ATTBTID)
        {
            try
            {
                return clsATTBTLVLVWDAL.Fetch_GPMATTBTLVLVW(strLvl, ATTBTID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
