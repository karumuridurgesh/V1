using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.HelpMethods;
using GTKUtilites.Extensions;
using System.Data;

namespace GTKABWLibrary.BusinessObjects
{
    [Serializable]
    public class ABWCustomer : IGTK<ABWCustomer>
    {
        public string CUSTOMERID { get; set; }
        public string CUSTOMERCODE { get; set; }
        public string NAME { get; set; }
        public string IRS { get; set; }
        public string REFNO { get; set; }
        public string CUSTOMERTYPE { get; set; }
        public string AGE { get; set; }
        public string CONSOLIDATE { get; set; }
        public string ACTIVE { get; set; }
        public string createdby { get; set; }
        public string createddate { get; set; }
        public string modifiedby { get; set; }
        public string modifieddate { get; set; }
        #region IGTK<ABWCustomer> Members

        public string ChildNode
        {
            get { return "ABWCustomer"; }
        }

        public List<ABWCustomer> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ABWCustomer>(dtDetails);
        }

        public ABWCustomer GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return "ABWCustomers"; }
        }

        public string PrepareSaveXml(List<ABWCustomer> liValues)
        {
            return PrepareXML.GetXml<ABWCustomer>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref ABWCustomer type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
   
  
}
