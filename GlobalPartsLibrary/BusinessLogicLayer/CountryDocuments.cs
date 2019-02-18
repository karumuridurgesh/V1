using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using GTKUtilites.HelpMethods;
using GTKUtilites.InterfaceLayer;
namespace GlobalPartsLibrary.BusinessLogicLayer
{
    [Serializable]
    public class  CountryDocuments : IGTK<CountryDocuments>
    {
  
        public string DOCID { get; set; }
        public string DOCCODE { get; set; }
        public string DESCR { get; set; }
        public string GROUPNAME { get; set; }
        public string SHOW { get; set; }
        public string STATUS { get; set; }
        //public List<CountryDocuments> liCountryDocDetails { get; set; }
        #region IGTK<CountryDocuments> Members

        public string ParentNode
        {
            get { return "GPCTYDOCPROPS"; }
        }

        public string ChildNode
        {
            get { return "GPCTYDOCPROP"; }
        }

        public CountryDocuments GetNewRow()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Remove Details
        /// </summary>
        /// <param name="type"></param>
        public void RemoveDetails(ref CountryDocuments type)
        {
            type.STATUS = "R";
        }

        #endregion

       /// <summary>
        /// Converting Datatable to List Type
       /// </summary>
       /// <param name="dtDetails"></param>
       /// <returns></returns>
        public List<CountryDocuments> GetDetails(DataTable dtDetails)
        {
            CountryDocuments clsCountryDocuments = new CountryDocuments();
            List<CountryDocuments> liCountryDocuments = new List<CountryDocuments>();
            foreach (DataRow dr in dtDetails.Rows)
            {
                clsCountryDocuments = new CountryDocuments()
                {
                    DOCID = dr["DOCID"].ToString(),
                    DOCCODE = dr["DOCCODE"].ToString(),
                    GROUPNAME = dr["GROUPNAME"].ToString(),
                    DESCR = dr["DESCR"].ToString(),
                    STATUS = "U"
                };

                liCountryDocuments.Add(clsCountryDocuments);
            }

            return liCountryDocuments;
        }
        /// <summary>
        /// Adding CountryDoc details to List
        /// </summary>
        /// <param name="sSelectedvalues"></param>
        /// <param name="sGroupName"></param>
        /// <param name="listCountryDocuments"></param>
        /// <returns></returns>
        public List<CountryDocuments> AddDetails(string sSelectedvalues, string sGroupName, List<CountryDocuments> listCountryDocuments,DataTable dtDocDesc)
        {
            if (!String.IsNullOrEmpty(sSelectedvalues))
            {
                string[] arrSelected = sSelectedvalues.TrimEnd('|').Split('|');
                CountryDocuments countryDocuments = new CountryDocuments();
                 foreach (string sSlected in arrSelected)
                {
                    int iCount = (from liCountry in listCountryDocuments where liCountry.DOCCODE == sSlected && liCountry.GROUPNAME == sGroupName && liCountry.STATUS != "R" select liCountry).Count();
                    if (iCount < 1)
                    {
                        countryDocuments = new CountryDocuments()
                        {
                            DOCCODE = sSlected.ToString(),
                            DESCR = dtDocDesc != null ? dtDocDesc.Select("C1='" + sSlected.ToString()+"'")[0]["C2"].ToString() : string.Empty,
                            GROUPNAME = sGroupName,
                            STATUS = "N" 
                        };
                        listCountryDocuments.Add(countryDocuments);
                    }
                }
            }
            return listCountryDocuments;
        }
     
        /// <summary>
        /// PreparingXml with CountryDoc Details for Save
        /// </summary>
        /// <param name="listCountryDocuments"></param>
        /// <returns></returns>
        public string PrepareSaveXml(List<CountryDocuments> listCountryDocuments)
        {
            return PrepareXML.GetXml<CountryDocuments>(listCountryDocuments, ParentNode, ChildNode);

        }
 

    }
}
