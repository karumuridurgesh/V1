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
    public class ActMstBillCd : IGTK<ActMstBillCd>
    {
        public string BillId { get; set; }
        public string CmpBillSetupId { get; set; }
        public string CompanyCd { get; set; }
        public string BillCd { get; set; }
        public string IsActive { get; set; }
        public string BasisCd { get; set; }
        public string Descr { get; set; }
        public string AltDescr { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string AutoApply { get; set; }
        public string AllowOverride { get; set; }
        public string DfltPayeeCd { get; set; }
        public string BillCurrCd { get; set; }
        public string ExpenseCurrCd { get; set; }
        public string HasRange { get; set; }
        public string WtType { get; set; }
        public string MaxWt { get; set; }
        public string SurchPct { get; set; }
        //public string AltDescr { get; set; }
        public string GLACNORev { get; set; }
        public string CostCenterCdRev { get; set; }
        public string GLACNOExp { get; set; }
        public string CostCenterCdExp { get; set; }
        public string BlRef{ get; set; }        


        #region IGTK<ActMstBillCd> Members

        public string ParentNode
        {
            get { return "ActMstBillCds"; }
        }

        public string ChildNode
        {
            get { return "ActMstBillCd"; }
        }

        public ActMstBillCd GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ActMstBillCd> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ActMstBillCd>(dtDetails);
        }

        public void RemoveDetails(ref ActMstBillCd type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ActMstBillCd> liValues)
        {
            return PrepareXML.GetXml<ActMstBillCd>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
