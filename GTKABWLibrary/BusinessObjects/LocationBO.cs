using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.Extensions;
using GTKUtilites.HelpMethods;

namespace GTKABWLibrary.BusinessObjects
{
    [Serializable]
    public class LocationBO : IGTK<LocationBO>
    {
        public string DEPTCODE { get; set; }
        public string Dep_name { get; set; }
        public string LOCATIONID { get; set; }
        public string LOCATIONCODE { get; set; }
        public string DESCRIPTION { get; set; }
        public string LOCADDR1 { get; set; }
        public string LOCADDR2 { get; set; }
        public string DIVISIONID { get; set; }
        public string DISTRIBUTIONCENTERID { get; set; }
        public string LOCATIONSTOCKCODE { get; set; }
        public string LOCATINAUDITCODE { get; set; }
        public string WDVSIE { get; set; }
        public string LOCATIONONLINE { get; set; }
        public string DOMPORT { get; set; }
        public string FIRMSCODE { get; set; }
        public string CARRIERCODE { get; set; }
        public string PERMITNO { get; set; }
        public string BEGINNING7512 { get; set; }
        public string CURRENT7512 { get; set; }
        public string ENDING7512 { get; set; }
        public string CONSOLIDATE7512 { get; set; }
        public string AGE7512 { get; set; }
        public string IsActive { get; set; }
        public string DIVISIONCODE { get; set; }
        public string DISTCODE { get; set; }

        #region IGTK<LocationBO> Members

        public string ParentNode
        {
            get { return "Locations"; }
        }

        public string ChildNode
        {
            get { return "Location"; }
        }

        public LocationBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<LocationBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<LocationBO>(dtDetails);
        }

        public void RemoveDetails(ref LocationBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<LocationBO> liValues)
        {
            return PrepareXML.GetXml<LocationBO>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }


    [Serializable]
    public class LocationDeptBO : IGTK<LocationDeptBO>
    {
        public string DEPTCODE { get; set; }
        public string Dep_name { get; set; }
        public string LOCATIONID { get; set; }
        public string IsActive { get; set; }
        public string Status { get; set; }


        #region IGTK<LocationDeptBO> Members

        public string ParentNode
        {
            get { return "Departments"; }
        }

        public string ChildNode
        {
            get { return "Department"; }
        }

        public LocationDeptBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<LocationDeptBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<LocationDeptBO>(dtDetails);
        }

        public void RemoveDetails(ref LocationDeptBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<LocationDeptBO> liValues)
        {
            return PrepareXML.GetXml<LocationDeptBO>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }
}
