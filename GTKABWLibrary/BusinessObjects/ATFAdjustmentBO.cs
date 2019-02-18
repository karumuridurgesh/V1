using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.Extensions;
using GTKUtilites.HelpMethods;

namespace GTKABWLibrary.BusinessObjects
{
    [Serializable]
    public class ATFAdjustmentBO : IGTK<ATFAdjustmentBO>
    {

        #region IGTK<ATFAdjustmentBO> Members

        public string TranID { get; set; }
        public string TranCode { get; set; }
        public string TranDate { get; set; }
        public string Notes { get; set; }
        public string LastUser { get; set; }
        public string BlockSemaphore { get; set; }
        public string LocationId { get; set; }
        public string Posted { get; set; }
        public string LOCATIONCODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string createddate { get; set; }


        public string ChildNode
        {
            get { return "ATFAdjHdr"; }
        }

        public List<ATFAdjustmentBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ATFAdjustmentBO>(dtDetails);
        }

        public ATFAdjustmentBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return "ATFAdjHdrs"; }
        }

        public string PrepareSaveXml(List<ATFAdjustmentBO> liValues)
        {
            return PrepareXML.GetXml<ATFAdjustmentBO>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref ATFAdjustmentBO type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    [Serializable]
    public class ATFAdjustmentDtlBO : IGTK<ATFAdjustmentDtlBO>
    {
        #region IGTK<ATFAdjustmentDtlBO> Members

        public string Prt_Code { get; set; }
        public string Description { get; set; }
        public string ReasonCode { get; set; }
        public string Qty { get; set; }
        public string CurQty { get; set; }
        public string Prt_UniqueNo { get; set; }
        public string LineNo { get; set; }
        public string SeqNo { get; set; }
        public string TranID { get; set; }
        public string Status { get; set; }

        public string ParentNode
        {
            get { return "ATFAdjDtls"; }
        }

        public string ChildNode
        {
            get { return "ATFAdjDtl"; }
        }

        public List<ATFAdjustmentDtlBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ATFAdjustmentDtlBO>(dtDetails);
        }

        public ATFAdjustmentDtlBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ATFAdjustmentDtlBO> liValues)
        {
            return PrepareXML.GetXml<ATFAdjustmentDtlBO>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref ATFAdjustmentDtlBO type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
