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
    public class GPCOMPANY : IGTK<GPCOMPANY>
    {
        public string AttrName {get;set;}
        public string DT {get;set;}
        public string CAPTION {get;set;}
         public string LISTID {get;set;}
         public string FLEXID {get;set;}
         public string CMPNYADTL {get;set;}
         public string STATUS{get;set;}
         public string SIZE  { get; set; }
         public string LISTVAL { get; set; }
         public string IsMandatory { get; set; }
        #region IGTK<GPCOMPANY> Members

        public string ParentNode
        {
            get { return "GPCOMPANYs"; }
        }

        public string ChildNode
        {
            get { return "GPCOMPANY"; }
        }

        public GPCOMPANY GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPCOMPANY> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPCOMPANY>(dtDetails);
        }

        public void RemoveDetails(ref GPCOMPANY type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPCOMPANY> liValues)
        {
            return PrepareXML.GetXml<GPCOMPANY>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
