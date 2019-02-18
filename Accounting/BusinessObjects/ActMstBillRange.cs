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
    public class ActMstBillRange : IGTK<ActMstBillRange>
    {

        public string BillSetUpId { get; set; } //0
        public string RANGEFR { get; set; } //1
        public string RANGETO { get; set; } //2
        public string UNITRATE { get; set; } //3
        public string FREEBASIS { get; set; } //4
        public string NUMFREEUNIT { get; set; } //5
        public string MINCHRG { get; set; } //6
        public string MAXCHRG { get; set; } //7
        public string MINCOST { get; set; } //8
        public string MAXCOST { get; set; } //9
        public string COSTBASISRATE { get; set; } //10
        public string ROUNDINGAXN { get; set; } //11
        public string ID { get; set; } //12
        public string CHID { get; set; } //13
        public string CID { get; set; } //14
        public string FREEBASISText { get; set; } //15
        public string CmpBillSetupId { get; set; }

        //public string FREEBASIS { get; set; } //4
        public string STATUS { get; set; } 

        #region IGTK<ActMstBillRange> Members

        public string ParentNode
        {
            get { return "ActMstBillRanges"; }
        }

        public string ChildNode
        {
            get { return "ActMstBillRange"; }
        }

        public ActMstBillRange GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ActMstBillRange> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ActMstBillRange>(dtDetails);
        }

        public void RemoveDetails(ref ActMstBillRange type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ActMstBillRange> liValues)
        {
            return PrepareXML.GetXml<ActMstBillRange>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
