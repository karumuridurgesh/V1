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
   public  class AbwPoRcpt : IGTK<AbwPoRcpt>
    {
        #region IGTK<AbwPoRcpt> Members
        public string TRANCODE { get; set; }//0
        public string TRANDATE { get; set; }//1
        public string LASTUSER { get; set; }//2
        public string FILENUM { get; set; }//3
        public string LOCATIONCODE { get; set; }//4
        


        public string ChildNode
        {
            get { return "AbwPoRcpt"; }
        }

        public List<AbwPoRcpt> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<AbwPoRcpt>(dtDetails);
        }

        public AbwPoRcpt GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return "AbwPoRcpts"; }
        }

        public string PrepareSaveXml(List<AbwPoRcpt> liValues)
        {
            return PrepareXML.GetXml<AbwPoRcpt>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref AbwPoRcpt type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    [Serializable]
    public class AbwPoRcptDtls : IGTK<AbwPoRcptDtls>
    {
        #region IGTK<AbwPoRcptDtls> Members
        public string ic_prt_code { get; set; }//0
        public string ic_qty1 { get; set; }//1
        public string prt_desc { get; set; }//2
        public string prt_UniqueNo { get; set; }//3
        public string ic_lineno { get; set; }//4
        public string em_importdate { get; set; }//5
        

        public string ChildNode
        {
            get { return "AbwPoRcptDtls"; }
        }

        public List<AbwPoRcptDtls> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<AbwPoRcptDtls>(dtDetails);
        }

        public AbwPoRcptDtls GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return "AbwPoRcptDtlss"; }
        }

        public string PrepareSaveXml(List<AbwPoRcptDtls> liValues)
        {
            return PrepareXML.GetXml<AbwPoRcptDtls>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref AbwPoRcptDtls type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}
