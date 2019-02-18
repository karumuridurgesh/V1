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
    public class ActMstBillCondn : IGTK<ActMstBillCondn>
    {
        public string BillSetUpId { get; set; } //0
        public string CondnId { get; set; } //1
        public string CondnTxt { get; set; } //2       
        public string UsageTypeCd { get; set; } //3
        public string ChrgeSetUp { get; set; }//4
        public string UseGlobal { get; set; } //5
        public string ChrgeURL { get; set; } //6
        public string CID { get; set; } //7
        public string ID { get; set; } //8
        public string CondnSimpleTxt { get; set; } //9
        public string CmpBillSetupId { get; set; }//10
        public string BasisCd { get; set; } //9
        public string OneChargePerBasis { get; set; } //10
        public string AlwaysApply { get; set; } //11
        public string AutoEval { get; set; } //12
        public string AutoApply { get; set; }  //13
        public string AllowOverride { get; set; } //
        public string DfltPayeeCd { get; set; } //
        public string BillCurrCd { get; set; } //
        public string ExpenseCurrCd { get; set; } //
        public string HasRange { get; set; } //
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
        public string STATUS { get; set; } //11
        public string BillCd { get; set; } //11
        public string IsDefault { get; set; } //11
        public string BSDESCR { get; set; }
        public string TRNDESCR { get; set; }


        public string CompanyCd { get; set; }
        public string CmpBill { get; set; }


        #region IGTK<ActMstBillCondn> Members

        public string ParentNode
        {
            get { return "ActMstBillCondns"; }
        }

        public string ChildNode
        {
            get { return "ActMstBillCondn"; }
        }

        public ActMstBillCondn GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ActMstBillCondn> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ActMstBillCondn>(dtDetails);
        }

        public void RemoveDetails(ref ActMstBillCondn type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ActMstBillCondn> liValues)
        {
            return PrepareXML.GetXml<ActMstBillCondn>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
