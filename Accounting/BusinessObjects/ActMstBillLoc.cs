using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.HelpMethods;
using GTKUtilites.Extensions;

namespace Accounting.BusinessObjects
{
    [Serializable]
    public class ActMstBillLoc : IGTK<ActMstBillLoc>
    {
        public string BillSetUpId { get; set; }
        public string LocId { get; set; }

        #region IGTK<ActMstBillLoc> Members

        public string ParentNode
        {
            get { return "ActMstBillLocs"; }
        }

        public string ChildNode
        {
            get { return "ActMstBillLoc"; }
        }

        public ActMstBillLoc GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ActMstBillLoc> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ActMstBillLoc>(dtDetails);
        }

        public void RemoveDetails(ref ActMstBillLoc type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ActMstBillLoc> liValues)
        {
            return PrepareXML.GetXml<ActMstBillLoc>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
