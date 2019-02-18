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
    public class ActMstBillPrfl : IGTK<ActMstBillPrfl>
    {
        public string PRFLID { get; set; }
        public string PRFLSHORTNM { get; set; }
        public string BASISCMPCD { get; set; }
        public string ISACTIVE { get; set; }
        public string PRFLDESCR { get; set; }
        public string AttribCondn { get; set; }
        public string AttribValue { get; set; }
        public string CID { get; set; }
        public string STATUS { get; set; }

        #region IGTK<ActMstBillPrfl> Members

        public string ParentNode
        {
            get { return "ActMstBillPrfls"; }
        }

        public string ChildNode
        {
            get { return "ActMstBillPrfl"; }
        }

        public ActMstBillPrfl GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ActMstBillPrfl> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ActMstBillPrfl>(dtDetails);
        }

        public void RemoveDetails(ref ActMstBillPrfl type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ActMstBillPrfl> liValues)
        {
            return PrepareXML.GetXml<ActMstBillPrfl>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
