using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Accounting.DataAccessLayer;

namespace Accounting.BusinessLogicLayer
{
    public class DutyFeesTransferBLL
    {
        DutyFeesTransferDAL clsDtyFeeDAL = new DutyFeesTransferDAL();
        public DataTable GetDtyTransferDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = clsDtyFeeDAL.GetDtyTransferDetails();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SaveDutyFees(string fee_code, string fee_no, string fee_description, float fee_amount, string fee_type, string fee_bill_code, string luid, int fee_priority, int codeStat, int status)
        {
            try
            {
             
                clsDtyFeeDAL.SaveDutyFees(fee_code, fee_no, fee_description, fee_amount, fee_type, fee_bill_code, luid, fee_priority,codeStat, status);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void RemoveDtyFee(string Code)
        {
            try
            {
                clsDtyFeeDAL.RemoveDtyFee(Code);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
