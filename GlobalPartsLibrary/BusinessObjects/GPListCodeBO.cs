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
    public class GPListCodeBO : IGTK<GPListCodeBO>
    {
        public string StoredValue { get; set; }
        public string DisplayValue { get; set; }
        public string Show { get; set; }
        public string ListCode { get; set; }
        public string Status { get; set; }
        public string SeqNo { get; set; }
        public string LName { get; set; }
        public string Active { get; set; } 
        #region IGTK<GPListCodeBO> Members

        public string ParentNode
        {
            get { return "gplistcodeprops"; }
        }

        public string ChildNode
        {
            get { return "gplistcodeprop"; }
        }

        public GPListCodeBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPListCodeBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPListCodeBO>(dtDetails);
        }

        public void RemoveDetails(ref GPListCodeBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPListCodeBO> liValues)
        {
            return PrepareXML.GetXml<GPListCodeBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
    [Serializable]
    public class GPCategoryBO : IGTK<GPCategoryBO>
    {
        public string StoredValue { get; set; }
        public string DisplayValue { get; set; }
        public string Show { get; set; }
        public string ListCode { get; set; }
        public string Status { get; set; }
        public string SeqNo { get; set; }
        public string Id { get; set; }

        #region IGTK<GPCategotyBO> Members

        public string ParentNode
        {
            get { return "gpcategoryprops"; }
        }

        public string ChildNode
        {
            get { return "gpcategoryprop"; }
        }

        public GPCategoryBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPCategoryBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPCategoryBO>(dtDetails);
        }

        public void RemoveDetails(ref GPCategoryBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPCategoryBO> liValues)
        {
            return PrepareXML.GetXml<GPCategoryBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }


    [Serializable]
    public class GPCategoryCmpBo : IGTK<GPCategoryCmpBo>
    {
        public string CmpCd { get; set; }
        public string Status { get; set; }
        public string Id { get; set; }
        public string Key { get; set; }

        #region IGTK<GPCategoryCmpBo> Members

        public string ParentNode
        {
            get { return "GPCategoryCmps"; }
        }

        public string ChildNode
        {
            get { return "GPCategoryCmp"; }
        }

        public GPCategoryCmpBo GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPCategoryCmpBo> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPCategoryCmpBo>(dtDetails);
        }

        public void RemoveDetails(ref GPCategoryCmpBo type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPCategoryCmpBo> liValues)
        {
            return PrepareXML.GetXml<GPCategoryCmpBo>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }




}

