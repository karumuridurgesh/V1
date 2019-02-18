using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.Extensions;
using GTKUtilites.HelpMethods;

namespace Accounting.BusinessObjects
{
    [Serializable]
    public class ActMstBillCondnAttrib : IGTK<ActMstBillCondnAttrib>
    {
        public string BillSetUpId { get; set; }
        public string CmpBillSetupId { get; set; }
        public string CondnId { get; set; }
        public string SeqNo { get; set; }
        public string AttribCd { get; set; }
        public string AttribCondn { get; set; }
        public string AttribValue { get; set; }
        public string CID { get; set; }
        public string STATUS { get; set; }

        #region IGTK<ActMstBillCondnAttrib> Members

        public string ParentNode
        {
            get { return "ActMstBillCondnAttribs"; }
        }

        public string ChildNode
        {
            get { return "ActMstBillCondnAttrib"; }
        }

        public ActMstBillCondnAttrib GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ActMstBillCondnAttrib> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ActMstBillCondnAttrib>(dtDetails);
        }

        public void RemoveDetails(ref ActMstBillCondnAttrib type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ActMstBillCondnAttrib> liValues)
        {
            return PrepareXML.GetXml<ActMstBillCondnAttrib>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
