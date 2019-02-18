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
    public class GPCtyAttribProp : IGTK<GPCtyAttribProp>
    {
        public string LISTID { get; set; }//0
        public string ATTRNAME { get; set; }//1
        public string CAPTION { get; set; }//2
        public string DATATYPE { get; set; }//3
        public string SIZE { get; set; }//4
        public string SHOW { get; set; }//5
        public string SEQNO { get; set; }//6
        public string LISTVAL { get; set; }//7
        public string DESCR { get; set; }//8
        public string CREATEDBY { get; set; }
        public string CREATEDDATE { get; set; }
        public string MODIFIEDBY { get; set; }
        public string MODIFIEDDATE { get; set; }
        public string FLEXID { get; set; }
        public string STATUS { get; set; }
        public string DATATY { get; set; }
        public string TNAME { get; set; }
        public string FNAME { get; set; }
        public string NEEDLOV { get; set; }
        #region IGTK<GPCtyAttribProp> Members

        public string ParentNode
        {
            get { return "GPCtyAttribProps"; }
        }

        public string ChildNode
        {
            get { return "GPCtyAttribProp"; }
        }

        public GPCtyAttribProp GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPCtyAttribProp> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPCtyAttribProp>(dtDetails);
        }

        public void RemoveDetails(ref GPCtyAttribProp type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPCtyAttribProp> liValues)
        {
            return PrepareXML.GetXml<GPCtyAttribProp>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
