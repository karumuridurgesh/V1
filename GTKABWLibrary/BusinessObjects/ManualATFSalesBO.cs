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
    public class ManualATFSalesBO : IGTK<ManualATFSalesBO>
    {
        public string TRANCODE { get; set; }
        public string TRANDATE { get; set; }
        public string LASTUSER { get; set; }
        public string FROMLOCATION { get; set; }
        public string TOLOCATION { get; set; }
        public string POSTED { get; set; }
        public string PERMIT_NO { get; set; }
        public string CUSTOMER_NO { get; set; }
        public string REMOVE_CODE { get; set; }
        public string EXPORT_PORT { get; set; }
        public string CUSTOMER_TYPE { get; set; }
        public string SEQNO { get; set; }
        public string TRANS_TYPE { get; set; }
        public string CARRIER { get; set; }
        public string BOL_NO { get; set; }
        public string FROMLOCNAME { get; set; }
        public string FROMLOCADD1 { get; set; }
        public string FROMLOCADD2 { get; set; }
        public string TOLOCNAME { get; set; }
        public string TOLOCADD1 { get; set; }
        public string TOLOCADD2 { get; set; }
        public string PO_NUMBER { get; set; }
        public string CONTROL_NO { get; set; }
        public string BLOCKSEMAPHORE { get; set; }
        public string SHIPTONAME { get; set; }
        public string SHIPTOADR1 { get; set; }
        public string SHIPTOADR2 { get; set; }
        public string SHIPTOADR3 { get; set; }
        public string TRANDTLCNT { get; set; }
        public string ATFSID { get; set; }
        public string CUSTOMERNAME { get; set; }
        public string STATUS { get; set; }


        #region IGTK<ManualATFSalesBO> Members

        public string ParentNode
        {
            get { return "ManualATFSalesBO"; }
        }

        public string ChildNode
        {
            get { return "ManualATFSalesBO"; }
        }

        public ManualATFSalesBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ManualATFSalesBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ManualATFSalesBO>(dtDetails);
        }

        public void RemoveDetails(ref ManualATFSalesBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ManualATFSalesBO> liValues)
        {
            return PrepareXML.GetXml<ManualATFSalesBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

    [Serializable]
    public class ManualATFSalesDTLBO : IGTK<ManualATFSalesDTLBO>
    {
        public string MARKS { get; set; }//MARKS=PartNo
        public string QUANTITY { get; set; }
        public string NOS_PER_QTY { get; set; }
        public string TOTAL_NOS { get; set; }
        public string TAX_RATE { get; set; }
        public string VALUE { get; set; }

        public string PRT_UNIQUENO { get; set; }
        public string ATFSID { get; set; }
        public string STATUS { get; set; }
        


        #region IGTK<ManualATFSalesDTLBO> Members

        public string ParentNode
        {
            get { return "ManualATFSalesDTLBO"; }
        }

        public string ChildNode
        {
            get { return "ManualATFSalesDTLBO"; }
        }

        public ManualATFSalesDTLBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ManualATFSalesDTLBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ManualATFSalesDTLBO>(dtDetails);
        }

        public void RemoveDetails(ref ManualATFSalesDTLBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ManualATFSalesDTLBO> liValues)
        {
            return PrepareXML.GetXml<ManualATFSalesDTLBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
