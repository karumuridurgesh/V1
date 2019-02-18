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
    public class ATTBTLVLVIEWSUMRYBO : IGTK<ATTBTLVLVIEWSUMRYBO>
    {
        public string GPM_CODE { get; set; }
        public string GPM_CAPTION { get; set; }
        public string GPM_DESC { get; set; }
        public string GPM_DATATYPE { get; set; }
        public string GPM_SIZE { get; set; }
        public string IsActive { get; set; }
        public string GPM_MODIFIEDDATE { get; set; }
        public string GPM_ATTBTID { get; set; }
        public string GPM_ATTBTDTLID { get; set; }
        public string GPM_STATUS { get; set; }
        public string ismandatory { get; set; }
        

        #region IGTK<ATTBTLVLVIEWSUMRYBO> Members

        public string ParentNode
        {
            get { return "ATTBTLVLVIEWSUMRYBO"; }
        }

        public string ChildNode
        {
            get { return "ATTBTLVLVIEWSUMRYBO"; }
        }

        public ATTBTLVLVIEWSUMRYBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ATTBTLVLVIEWSUMRYBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ATTBTLVLVIEWSUMRYBO>(dtDetails);
        }

        public void RemoveDetails(ref ATTBTLVLVIEWSUMRYBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ATTBTLVLVIEWSUMRYBO> liValues)
        {
            return PrepareXML.GetXml<ATTBTLVLVIEWSUMRYBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
