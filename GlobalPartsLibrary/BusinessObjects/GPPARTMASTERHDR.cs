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
    public class GPPARTMASTERHDR : IGTK<GPPARTMASTERHDR>
    {
        public string GPPMHDRID { get; set; }
        public string GP_CPYCD { get; set; }
        public string GP_PARTNO { get; set; }
        public string GP_PARTDESC { get; set; }
        public string GP_CATEGORY { get; set; }
        public string GP_COMDESC { get; set; }
        public string GP_LONGDESC { get; set; }
        public string GP_IMGAGE { get; set; }
        public string GP_STYLE { get; set; }
        public string GP_STYLEDESC { get; set; }
        public string ProfileID { get; set; }
        public string PRTStatus { get; set; }
        public string IsActive { get; set; }
        public string VersNo { get; set; }
        public string CITES { get; set; }
        public string ISSET { get; set; }
        public string imp_name1 { get; set; }
        public string CTGDESC { get; set; }
        public string ClsFlag { get; set; }
        public string AttrFlag { get; set; }
        public string PtnrCode { get; set; }
        public string PtnrName { get; set; }
        public string PtnrRef { get; set; }
        public string ShowCites { get; set; }
        public string SKUExceptionFlag { get; set; }
        public string CitesFlag { get; set; }
        public string FWFlag { get; set; }

        public string ECCNClsFlag { get; set; }

        #region IGTK<GPPARTMASTERHDR> Members

        public string ParentNode
        {
            get { return "GPPARTMASTERHDRs"; }
        }

        public string ChildNode
        {
            get { return "GPPARTMASTERHDR"; }
        }

        public GPPARTMASTERHDR GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPPARTMASTERHDR> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPPARTMASTERHDR>(dtDetails);
        }

        public void RemoveDetails(ref GPPARTMASTERHDR type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPPARTMASTERHDR> liValues)
        {
            return PrepareXML.GetXml<GPPARTMASTERHDR>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
