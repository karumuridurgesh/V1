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
    public class ManualAdjustmentBO : IGTK<ManualAdjustmentBO>
    {
        #region IGTK<ManualAdjustmentBO> Members

        public string TranID { get; set; }
        public string TranCode { get; set; }
        public string EntryNumber { get; set; }
        public string FileNo { get; set; }
        public string TranDate { get; set; }
        public string Notes { get; set; }
        public string LastUser { get; set; }
        public string BlockSemaphore { get; set; }
        public string LocationId { get; set; }
        public string Posted { get; set; }
        public string LOCATIONCODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string createddate { get; set; }

        public string ParentNode
        {
            get { return "ManualAdjHdrs"; }
        }

        public string ChildNode
        {
            get { return "ManualAdjHdr"; }
        }

        public List<ManualAdjustmentBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ManualAdjustmentBO>(dtDetails);
        }

        public ManualAdjustmentBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ManualAdjustmentBO> liValues)
        {
            return PrepareXML.GetXml<ManualAdjustmentBO>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref ManualAdjustmentBO type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    [Serializable]
    public class ManualAdjustmentDtlBO : IGTK<ManualAdjustmentDtlBO>
    {
        #region IGTK<ManualAdjustmentDtlBO> Members

        public string Prt_Code { get; set; }
        public string Description { get; set; }
        public string ReasonCode { get; set; }
        public string Qty { get; set; }
        public string CurQty { get; set; }
        public string TotQty { get; set; }
        public string Em_fileno { get; set; }
        public string Prt_UniqueNo { get; set; }
        public string ReasonId { get; set; }
        public string LineNo { get; set; }
        public string SeqNo { get; set; }
        public string TranID { get; set; }
        public string Status { get; set; }

        public string ParentNode
        {
            get { return "ManualAdjDtls"; }
        }

        public string ChildNode
        {
            get { return "ManualAdjDtl"; }
        }
        public List<ManualAdjustmentDtlBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ManualAdjustmentDtlBO>(dtDetails);
        }

        public ManualAdjustmentDtlBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ManualAdjustmentDtlBO> liValues)
        {
            return PrepareXML.GetXml<ManualAdjustmentDtlBO>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref ManualAdjustmentDtlBO type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
