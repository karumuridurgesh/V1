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
    public class CategorySetup : IGTK<CategorySetup>
    {
        public string LISTID { get; set; }
        public string CAPTION { get; set; }
        public string DATATYPE { get; set; }
        public string SIZE { get; set; }
        public string SHOW { get; set; }
        public string SEQNO { get; set; }
        public string LISTVAL { get; set; }
        public string DESCR { get; set; }
        public string ATTRNAME { get; set; }
        public string flexid { get; set; }
        public string status { get; set; }




        #region IGTK<CategorySetup> Members

        public string ParentNode
        {
            get { return "gpctgyattribprops"; }
        }

        public string ChildNode
        {
            get { return "gpctgyattribprop"; }
        }

        public CategorySetup GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<CategorySetup> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CategorySetup>(dtDetails);
        }

        public void RemoveDetails(ref CategorySetup type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<CategorySetup> liValues)
        {
            return PrepareXML.GetXml<CategorySetup>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
