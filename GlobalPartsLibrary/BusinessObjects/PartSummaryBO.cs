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
    public class PartSummaryBO : IGTK<PartSummaryBO>
    {
        public string GP_PARTNO { get; set; }
        public string GP_PARTDESC { get; set; }
        public string GPPMHDRID { get; set; }
        public string PartType { get; set; }
        public string ProdPart { get; set; }
        public string Meterial { get; set; }
        public string Percentage { get; set; }
        public string GP_VENDNAME { get; set; }
        public string Status { get; set; }
        #region IGTK<PartSummaryBO> Members

        public string ParentNode
        {
            get { return "gpPartSumprops"; }
        }

        public string ChildNode
        {
            get { return "gpPartSumprop"; }
        }

        public PartSummaryBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<PartSummaryBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<PartSummaryBO>(dtDetails);
        }

        public void RemoveDetails(ref PartSummaryBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<PartSummaryBO> liValues)
        {
            return PrepareXML.GetXml<PartSummaryBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
    [Serializable]
    public class SrvReqpartsBO : IGTK<SrvReqpartsBO>
    {
        public string PRTID { get; set; }

        #region IGTK<SrvReqpartsBO> Members

        public string ParentNode
        {
            get { return "SrvReqpartsBOs"; }
        }

        public string ChildNode
        {
            get { return "SrvReqpartsBO"; }
        }

        public SrvReqpartsBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<SrvReqpartsBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<SrvReqpartsBO>(dtDetails);
        }

        public void RemoveDetails(ref SrvReqpartsBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<SrvReqpartsBO> liValues)
        {
            return PrepareXML.GetXml<SrvReqpartsBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

}
