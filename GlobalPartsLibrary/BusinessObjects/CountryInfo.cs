using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.Extensions;
using GTKUtilites.HelpMethods;

namespace GlobalPartsLibrary.BusinessObjects
{
    [Serializable]
    public class CountryInfo : IGTK<CountryInfo>
    {
        public int GPM_PARTID { get; set; }
        public string GPM_COMPANY { get; set; }
        public string GPM_PARTCODE { get; set; }
        public string GPM_CATEGORY { get; set; }

        public string gpc_cty { get; set; }
        public string gpc_hts { get; set; }
        public string gpc_htsdesc { get; set; }
        public string gpc_comdesc { get; set; }
        public string gpc_exphts { get; set; }

        public string dutyrule { get; set; }
        public string dutytype { get; set; }
        public string details { get; set; }
        public string Status { get; set; }
        public string LNCD { get; set; }
        public string DESCR { get; set; }
        public string RULNO { get; set; }

        #region IGTK<CountryInfo> Members

        public string ParentNode
        {
            get { return "COUNTRYINFOS"; }
        }

        public string ChildNode
        {
            get { return "COUNTRYINFO"; }
        }

        public CountryInfo GetNewRow()
        {
            CountryInfo clsCountry = new CountryInfo();
            clsCountry = new CountryInfo()
            {
                GPM_PARTID = 0,
                GPM_COMPANY = string.Empty,
                GPM_PARTCODE = string.Empty,
                GPM_CATEGORY = string.Empty,
                gpc_cty = string.Empty,
                gpc_hts = string.Empty,
                gpc_htsdesc = string.Empty,
                gpc_comdesc = string.Empty,
                gpc_exphts = string.Empty,
                dutyrule = string.Empty,
                dutytype = string.Empty,
                details = string.Empty,
                Status = "N"
            };
            return clsCountry;
        }

        public List<CountryInfo> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CountryInfo>(dtDetails);
        }

        public void RemoveDetails(ref CountryInfo type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<CountryInfo> liValues)
        {
            return PrepareXML.GetXml<CountryInfo>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
