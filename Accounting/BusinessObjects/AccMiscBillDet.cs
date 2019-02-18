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
    public class AccMiscBillDet : IGTK<AccMiscBillDet>
    {


        public string ID { get; set; }
        public string INVNO { get; set; }
        public string SEQNO { get; set; }
        public string BILLCODE { get; set; }
        public string DESCR { get; set; }
        public string BILLAMT { get; set; }
        public string PAYAMT { get; set; }
        public string VENDOR { get; set; }
        public string LUID { get; set; }
        public string LUPD { get; set; }
        public string STATUS { get; set; }
        public string DESCRIPTOR { get; set; }




        #region IGTK<AccMiscBillDet> Members

        public string ParentNode
        {
            get { return "AccMiscBillDets"; }
        }

        public string ChildNode
        {
            get { return "AccMiscBillDet"; }
        }

        public AccMiscBillDet GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<AccMiscBillDet> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<AccMiscBillDet>(dtDetails);
        }

        public void RemoveDetails(ref AccMiscBillDet type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<AccMiscBillDet> liValues)
        {
            return PrepareXML.GetXml<AccMiscBillDet>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
