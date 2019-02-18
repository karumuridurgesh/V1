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
    public class CompositionsBO : IGTK<CompositionsBO>
    {
        public string CDescription { get; set; }
        public string CType { get; set; }
        public string IsActive { get; set; }
        public string GPMCID { get; set; }
        public string NoofLines { get; set; }
        public string PPCols { get; set; }
        public string MMCols { get; set; }
        public string Status { get; set; }
        public string Show { get; set; }
        public string Code { get; set; }
        #region IGTK<CompositionsBO> Members

        public string ParentNode
        {
            get { return "gpcompcodeprops"; }
        }

        public string ChildNode
        {
            get { return "gpcompcodeprop"; }
        }

        public CompositionsBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<CompositionsBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CompositionsBO>(dtDetails);
        }

        public void RemoveDetails(ref CompositionsBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<CompositionsBO> liValues)
        {
            return PrepareXML.GetXml<CompositionsBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
