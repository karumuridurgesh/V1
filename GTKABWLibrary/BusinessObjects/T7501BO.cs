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
    public class T7501BO:IGTK<T7501BO>
    {
        public string TRANNO { get; set; }//0
        public string FROMLOCATION { get; set; }//1
        public string TRANDATE { get; set; }//2
        public string ENTRYTYPE { get; set; }//3
        public string LASTUSER { get; set; }//4
        public string CUSTOMERID { get; set; }//5
        public string CARRIER { get; set; }//6
        public string SHIPNAME { get; set; }//7
        public string CLEARANCENO { get; set; }//8
        public string DOMPORT { get; set; }//9
        public string FORPORT { get; set; }//10
        public string SHIPID{get;set;}//11
        public string SHIPADDRESS1 { get; set; }//12
        public string SHIPADDRESS2 { get; set; }//13
        public string SHIPADDRESS3 { get; set; }//14
        public string POSTED { get; set; }//15
        #region IGTK<T7501BO> Members

        public string ParentNode
        {
            get { return "T7501s"; }
        }

        public string ChildNode
        {
            get { return "T7501"; }
        }

        public T7501BO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<T7501BO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<T7501BO>(dtDetails);
        }

        public void RemoveDetails(ref T7501BO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<T7501BO> liValues)
        {
            return PrepareXML.GetXml<T7501BO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
    [Serializable]
    public class T7501ProductsBo : IGTK<T7501ProductsBo>
    {
        public string ID7501 { get; set; }//0
        public string PRT_UNIQUENO { get; set; }//1
        public string SEQNO { get; set; }//2
        public string CF7501 { get; set; }//3
        public string ENTRYNO { get; set; }//4
        public string LINENO { get; set; }//5
        public string BEFORETOTAL { get; set; }//6
        public string Quantity { get; set; }//7
        public string BALANCE { get; set; }//8
        public string ORIGINALQTY { get; set; }//9
        public string EM_FILENO { get; set; }//10
        public string EM_ENTRYNO { get; set; }//11
        public string prt_Code { get; set; }//12
        public string prt_desc { get; set; }//13
        public string Status { get; set; }//14
        #region IGTK<T7501ProductsBo> Members

        public string ParentNode
        {
            get { return "T7501Products"; }
        }

        public string ChildNode
        {
            get { return "T7501Product"; }
        }

        public T7501ProductsBo GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<T7501ProductsBo> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<T7501ProductsBo>(dtDetails);
        }

        public void RemoveDetails(ref T7501ProductsBo type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<T7501ProductsBo> liValues)
        {
            return PrepareXML.GetXml<T7501ProductsBo>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

}
