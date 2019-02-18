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
    public class CountrySpecInfo : IGTK<CountrySpecInfo>
    {
        public string CntyName { get; set; }
        public string CntyCode { get; set; }
        public string CmpCD { get; set; }
        public string RowNumber { get; set; }
        public string Duplicate { get; set; }
        public string FirstDot { get; set; }
        public string SecondDot { get; set; }
        public string RegExp { get; set; }
        public string MaximumLength { get; set; }
        public string MinimumLength { get; set; }
        public string HTS { get; set; }
        public string HTSDescription { get; set; }
        public string NumOfCount { get; set; }
        public string HTSNotes { get; set; }
        

        #region IGTK<CountrySpecInfo> Members

        public string ParentNode
        {
            get { return "Countries"; }
        }

        public string ChildNode
        {
            get { return "Country"; }
        }

        public CountrySpecInfo GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<CountrySpecInfo> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CountrySpecInfo>(dtDetails);
        }

        public void RemoveDetails(ref CountrySpecInfo type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<CountrySpecInfo> liValues)
        {
            return PrepareXML.GetXml<CountrySpecInfo>(liValues, ParentNode, ChildNode);
        }

        #endregion

    }
    [Serializable]
    public class ProfileHdr1 : IGTK<ProfileHdr1>
    {

        #region IGTK<ProfileHdr1> Members
        public string ProfileName { get; set; }
        public string Attr1 { get; set; }
        public string IsActive { get; set; }
        public string Category { get; set; }
        public string PFType { get; set; }
        public string Comments { get; set; }
        public string CmpCD { get; set; }
       

        public string ParentNode
        {
            get { return "ProfileHdrs"; }
        }

         public string ChildNode
        {
            get { return "ProfileHdr"; }
        }

        public ProfileHdr1 GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ProfileHdr1> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ProfileHdr1>(dtDetails);
        }

        public void RemoveDetails(ref ProfileHdr1 type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ProfileHdr1> liValues)
        {
            return PrepareXML.GetXml<ProfileHdr1>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
    [Serializable]
    public class ProfileAttribute : IGTK<ProfileAttribute>
    {
        public string AttrId { get; set; }
        public string AttrValue { get; set; }
        
        public string ParentNode
        {
            get { return "ProfileAttrs"; }
        }

        public string ChildNode
        {
            get { return "ProfileAttr"; }
        }

        public ProfileAttribute GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ProfileAttribute> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ProfileAttribute>(dtDetails);
        }
        public void RemoveDetails(ref ProfileAttribute type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ProfileAttribute> liValues)
        {
            return PrepareXML.GetXml<ProfileAttribute>(liValues, ParentNode, ChildNode);
        }

        
    }
}
