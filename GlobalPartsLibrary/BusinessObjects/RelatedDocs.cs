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
    public class RelatedDocs : IGTK<RelatedDocs>
    {
        public string LISTID { get; set; }
        public string DOCCODE { get; set; }
        public string DisplayValue { get; set; }
        public string GROUPNAME { get; set; }
        public string REQ { get; set; }
        public string Status { get; set; }

        #region IGTK<RelatedDocs> Members

        public string ParentNode
        {
            get { return "RelatedDocS"; }
        }

        public string ChildNode
        {
            get { return "RelatedDoc"; }
        }

        public RelatedDocs GetNewRow()
        {
           RelatedDocs clsRelatedDocs = new RelatedDocs();
           clsRelatedDocs = new RelatedDocs()
           {
               LISTID = "0",
               DOCCODE = string.Empty,
               DisplayValue = string.Empty,
               GROUPNAME = string.Empty,
               REQ = string.Empty,
               Status = string.Empty
           };
           return clsRelatedDocs;
        }

        public List<RelatedDocs> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<RelatedDocs>(dtDetails);
        }

        public void RemoveDetails(ref RelatedDocs type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<RelatedDocs> liValues)
        {
            return PrepareXML.GetXml<RelatedDocs>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
