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
    public class AccMiscBill : IGTK<AccMiscBill>
    {

        public string ID { get; set; }
        public string INVNO { get; set; }
        public string INVDATE { get; set; }
        public string IMPORTER { get; set; }        
        public string CUSTINVNO { get; set; }
        public string CUSTREF { get; set; }
        public string SHIPREF { get; set; }
        public string BOLREF { get; set; }
        public string REMARKS { get; set; }
        public string LUID { get; set; }
        public string LUPD { get; set; }
        public string ISACTIVE  { get; set; }
        public string STATUS { get; set; }
        public string FINALIZE { get; set; }
        public string DESTLOC { get; set; }
        public string SUFFIX { get; set; }


        #region IGTK<AccMiscBill> Members

        public string ParentNode
        {
            get { return "AccMiscBills"; }
        }

        public string ChildNode
        {
            get { return "AccMiscBill"; }
        }

        public AccMiscBill GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<AccMiscBill> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<AccMiscBill>(dtDetails);
        }

        public void RemoveDetails(ref AccMiscBill type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<AccMiscBill> liValues)
        {
            return PrepareXML.GetXml<AccMiscBill>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
