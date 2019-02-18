using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.HelpMethods;
using GTKUtilites.Extensions;
using System.Data;

namespace GTKABWLibrary.BusinessObjects
{
    [Serializable]
  public  class ATFReceiptBo:IGTK<ATFReceiptBo>
    {

        #region IGTK<ATFReceipt> Members
        public string TRANCODE { get; set; }//0
        public string TRANDATE { get; set; }//1
        public string LASTUSER { get; set; }//2
        public string LOCATIONCODE { get; set; }//3
        public string PONUMBER { get; set; }//4
       

        public string ParentNode
        {
            get { return "ATFReceipts"; }
        }

        public string ChildNode
        {
            get { return "ATFReceipt"; }
        }

        public ATFReceiptBo GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ATFReceiptBo> GetDetails(DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ATFReceiptBo>(dtDetails);
        }

        public void RemoveDetails(ref ATFReceiptBo type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ATFReceiptBo> liValues)
        {
            return PrepareXML.GetXml<ATFReceiptBo>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
    [Serializable]
    public class ATFReceiptDtl : IGTK<ATFReceiptDtl>
    {
        #region IGTK<ATFReceiptDtl> Members
        
        public string ic_prt_code { get; set; }//0
        public string ic_qty1 { get; set; }//1
        public string prt_desc { get; set; }//2
        public string prt_UniqueNo { get; set; }//3
        public string ic_lineno { get; set; }//4
        public string ID { get; set; }//5
        public string STATUS { get; set; }//6
        
        public string ParentNode
        {
            get { return "ATFReceiptDtls"; }
        }

        public string ChildNode
        {
            get { return "ATFReciptDtl"; }
        }

        public ATFReceiptDtl GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ATFReceiptDtl> GetDetails(DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ATFReceiptDtl>(dtDetails);
        }

        public void RemoveDetails(ref ATFReceiptDtl type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ATFReceiptDtl> liValues)
        {
            return PrepareXML.GetXml<ATFReceiptDtl>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

}
