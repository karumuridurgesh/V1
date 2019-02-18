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
    public class T6043BO : IGTK<T6043BO>
    {
        public string TRANNO { get; set; }
        public string FROMLOCCode { get; set; } 
        public string TOLOCCODE { get; set; }
        public string TRANDATE { get; set; }
        public string CARRIER { get; set; }
        public string CUSTOMERID { get; set; }
        public string SHIPID { get; set; }
        public string SHIPNAME { get; set; }
        public string SHIPADDRESS1 { get; set; }
        public string SHIPADDRESS2 { get; set; }
        public string SHIPADDRESS3 { get; set; }
        public string OTHERCARRIER { get; set; }
        public string LASTUSER { get; set; }
        public string CLEARANCENO { get; set; }
        public string DOMPORT { get; set; }
        public string FORPORT { get; set; }
        public string POSTED { get; set; }
        public string RECEIPT { get; set; }
        public string RECEIPTDATE { get; set; }
        public string RECEIPTUSER { get; set; }
        public string CF6043NOS { get; set; }
        public string CHLICENSENUMBER { get; set; }



      #region IGTK<T6043BO> Members

        public string ParentNode
        {
            get { return "T6043"; }
        }

        public string ChildNode
        {
            get { return "T6043"; }
        }

        public T6043BO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<T6043BO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<T6043BO>(dtDetails);
        }

        public void RemoveDetails(ref T6043BO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<T6043BO> liValues)
        {
            return PrepareXML.GetXml<T6043BO>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }

    [Serializable]
    public class T6043ProductsBO : IGTK<T6043ProductsBO>
    {
        public string prt_Code { get; set; }
        public string prt_desc { get; set; }
        public string Quantity { get; set; }
        public string PRT_UNIQUENO { get; set; }
        public string Status { get; set; }
        public string ID6043 { get; set; }
        public string SEQNO { get; set; }
        public string CF6043 { get; set; }
        public string ENTRYNO { get; set; }
        public string LINENO { get; set; }
        public string BEFORETOTAL { get; set; }
        public string BALANCE { get; set; }
        public string ORIGINALQTY { get; set; }


        #region IGTK<T6043BOProducts> Members

        public string ParentNode
        {
            get { return "T6043Products"; }
        }

        public string ChildNode
        {
            get { return "T6043Products"; }
        }

        public T6043ProductsBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<T6043ProductsBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<T6043ProductsBO>(dtDetails);
        }

        public void RemoveDetails(ref T6043ProductsBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<T6043ProductsBO> liValues)
        {
            return PrepareXML.GetXml<T6043ProductsBO>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }
}
