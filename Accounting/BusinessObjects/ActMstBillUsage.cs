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
    public class ActMstBillUsage : IGTK<ActMstBillUsage>
    {

        public string BillSetUpId { get; set; }
        public string UsedFor { get; set; }

        #region IGTK<ActMstBillUsage> Members

        public string ParentNode
        {
            get { return "ActMstBillUsages"; }
        }

        public string ChildNode
        {
            get { return "ActMstBillUsage"; }
        }

        public ActMstBillUsage GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ActMstBillUsage> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ActMstBillUsage>(dtDetails);
        }

        public void RemoveDetails(ref ActMstBillUsage type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ActMstBillUsage> liValues)
        {
            return PrepareXML.GetXml<ActMstBillUsage>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
    [Serializable]
    public class BillingMaster : IGTK<BillingMaster>
    {
        public string BLM_FILENO { get; set; }
        public string BLM_INVNO { get; set; }
        public string BLM_ENTRYNO { get; set; }
        public string BLM_INV_DATE { get; set; }
        public string BLM_MBNO { get; set; }
        public string BLM_HBNO { get; set; }
        public string BLM_SBNO { get; set; }
        public string BLM_IMPORTERNO { get; set; }
        public string BLM_BILLTO { get; set; }
        public string BLM_PAY_TERMS { get; set; }
        public string BLM_REFNO { get; set; }
        public string BLM_REMARKS { get; set; }
        public string BLM_BILLTOT { get; set; }
        public string BLM_PAYOUTTOT { get; set; }
        public string LUID { get; set; }
        public string LUPD { get; set; }
        public string blm_pieces { get; set; }
        public string blm_weight { get; set; }
        public string blm_descr { get; set; }
        public string blm_shipper { get; set; }
        public string blm_consg_name { get; set; }
        public string blm_origin { get; set; }
        public string blm_dest { get; set; }
        public string blm_arrivaldate { get; set; }
        public string blm_entrydate { get; set; }
        public string blm_carrier { get; set; }
        public string BLM_PrintYorN { get; set; }
        public string blm_amtpaid { get; set; }
        public string blm_GenYorN { get; set; }
        public string Id { get; set; }
        public string BLM_INVREF { get; set; }
        public string ISACTIVE { get; set; }
        public string BLM_CustInv_int2QB { get; set; }
        public string BLM_vendInv_int2QB { get; set; }
        public string BL_STATUS { get; set; }



        #region IGTK<BillingMaster> Members

        public string ParentNode
        {
            get { throw new NotImplementedException(); }
        }

        public string ChildNode
        {
            get { throw new NotImplementedException(); }
        }

        public BillingMaster GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<BillingMaster> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<BillingMaster>(dtDetails);
        }

        public void RemoveDetails(ref BillingMaster type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<BillingMaster> liValues)
        {
            return PrepareXML.GetXml<BillingMaster>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
    [Serializable]
    public class BillingDetails : IGTK<BillingDetails>
    {

        public string bld_fileno { get; set; }//0
        public string bld_invno { get; set; }//1
        public string bld_seqno { get; set; }//2
        public string bld_bill_code { get; set; }//3
        public string bld_bill_descr { get; set; }//4
        public string bld_pay_amt { get; set; }//5
        public string bld_pay_vendor { get; set; }//6
        public string bld_refno { get; set; }//7
        public string luid { get; set; }//8
        public string lupd { get; set; }//9
        public string bld_bill_amt { get; set; }//10
        public string bld_VendorRefno { get; set; }//11
        public string IsActive { get; set; }//12
        public string bld_billtype { get; set; }//13
        public string bld_bill_descriptor { get; set; }//14


        #region IGTK<BillingDetails> Members

        public string ParentNode
        {
            get { return "BillingDetailss"; }
        }

        public string ChildNode
        {
            get { return "BillingDetails"; }
        }

        public BillingDetails GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<BillingDetails> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<BillingDetails>(dtDetails);
        }

        public void RemoveDetails(ref BillingDetails type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<BillingDetails> liValues)
        {
            return PrepareXML.GetXml<BillingDetails>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
