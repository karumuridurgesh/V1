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
    public class T7512BO : IGTK<T7512BO>
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
        public string ENTRYTYPE { get; set; }
        public string CHLICENSENUMBER { get; set; }
        public string ToLocationCode { get; set; }
        public string FromLocationCode { get; set; }



        #region IGTK<T7512BO> Members

        public string ParentNode
        {
            get { return "T7512"; }
        }

        public string ChildNode
        {
            get { return "T7512"; }
        }

        public T7512BO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<T7512BO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<T7512BO>(dtDetails);
        }

        public void RemoveDetails(ref T7512BO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<T7512BO> liValues)
        {
            return PrepareXML.GetXml<T7512BO>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }

    [Serializable]
    public class T7512ProductsBO : IGTK<T7512ProductsBO>
    {
        public string prt_Code { get; set; }
        public string prt_desc { get; set; }
        public string Quantity { get; set; }
        public string PRT_UNIQUENO { get; set; }
        public string Status { get; set; }
        public string ID7512 { get; set; }
        public string SEQNO { get; set; }
        public string CF7512 { get; set; }
        public string ENTRYNO { get; set; }
        public string LINENO { get; set; }
        public string BEFORETOTAL { get; set; }
        public string BALANCE { get; set; }
        public string ORIGINALQTY { get; set; }


        #region IGTK<T7512BOProducts> Members

        public string ParentNode
        {
            get { return "T7512Products"; }
        }

        public string ChildNode
        {
            get { return "T7512Products"; }
        }

        public T7512ProductsBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<T7512ProductsBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<T7512ProductsBO>(dtDetails);
        }

        public void RemoveDetails(ref T7512ProductsBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<T7512ProductsBO> liValues)
        {
            return PrepareXML.GetXml<T7512ProductsBO>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }
}
