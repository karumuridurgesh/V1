using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.Extensions;
using GTKUtilites.HelpMethods;

namespace GlobalPartsLibrary.BusinessObjects
{
    [Serializable]
    public class GPPartMaster : IGTK<GPPartMaster>
    {
        public string GPM_PARTID { get; set; }
        public string GPM_COMPANY { get; set; }
        public string GPM_PARTCODE { get; set; }
        public string GPM_PARTDESC { get; set; }
        public string GPM_KEYWORD { get; set; }
        public string GPM_CATEGORY { get; set; }
        public string GPM_COMHTS { get; set; }
        public string GPM_CREATEDBY { get; set; }
        public string GPM_CREATEDDATE { get; set; }
        public string GPM_MODIFIEDBY { get; set; }
        public string GPM_MODIFIEDDATE { get; set; }
        public string GPM_LONGDESC { get; set; }
        public string GPM_WEIGHT { get; set; }
        public string GPM_SELLPRICE { get; set; }
        public string GPM_PURPRICE { get; set; }
        public string GPM_PURUOM { get; set; }
        public string GPM_BUYUOM { get; set; }
        public string GPM_VOLUME { get; set; }
        public string GPM_COMMDESC { get; set; }
        public string GPM_BRANDNAME { get; set; }
        public string GPM_LENGTH { get; set; }
        public string GPM_HEIGHT { get; set; }
        public string GPM_WIDTH { get; set; }
        public string GPM_ISCATEGORY { get; set; } 

        #region IGTK<GPPartMaster> Members

        public string ParentNode
        {
            get { return "GPPartMasters"; }
        }

        public string ChildNode
        {
            get { return "GPPartMaster"; }
        }

        public GPPartMaster GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPPartMaster> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPPartMaster>(dtDetails);
        }

        public void RemoveDetails(ref GPPartMaster type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPPartMaster> liValues)
        {
            return PrepareXML.GetXml<GPPartMaster>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
