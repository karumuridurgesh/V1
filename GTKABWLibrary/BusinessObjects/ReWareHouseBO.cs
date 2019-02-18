using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.Extensions;
using System.Data;
using GTKUtilites.HelpMethods;

namespace GTKABWLibrary.BusinessObjects
{
    [Serializable]
 public   class ReWareHouseBO:IGTK<ReWareHouseBO>
    {
        
        public string CF7512 { get; set; }//0
        public string EntryNo { get; set; }//1
        public string PRT_DESC { get; set; }//2
        public string DeptNo { get; set; }//3
        public string NO7512 { get; set; }//4


        #region IGTK<ReWareHouseBO> Members

        public string ParentNode
        {
            get { return "ReWareHouseBOs"; }
        }

        public string ChildNode
        {
            get { return "ReWareHouseBO" ;}
        }

        public ReWareHouseBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ReWareHouseBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ReWareHouseBO>(dtDetails);
        }

        public void RemoveDetails(ref ReWareHouseBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ReWareHouseBO> liValues)
        {
            return PrepareXML.GetXml<ReWareHouseBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
