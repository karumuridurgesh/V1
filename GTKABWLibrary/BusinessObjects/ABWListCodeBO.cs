using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.HelpMethods;
using GTKUtilites.Extensions;

namespace GTKABWLibrary.BusinessObjects
{
    [Serializable]
    public class ABWListCodeBO : IGTK<ABWListCodeBO>
    {
        public string StoredValue { get; set; }
        public string DisplayValue { get; set; }
        public string Show { get; set; }
        public string ListCode { get; set; }
        public string Status { get; set; }
        public string SeqNo { get; set; }
        public string LName { get; set; } 

        #region IGTK<ABWListCodeBO> Members

        public string ChildNode
        {
            get { return "ABWLSTCODE"; }
        }

        public List<ABWListCodeBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ABWListCodeBO>(dtDetails);
        }

        public ABWListCodeBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return "ABWLSTCODES"; }
        }

        public string PrepareSaveXml(List<ABWListCodeBO> liValues)
        {
            return PrepareXML.GetXml<ABWListCodeBO>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref ABWListCodeBO type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
