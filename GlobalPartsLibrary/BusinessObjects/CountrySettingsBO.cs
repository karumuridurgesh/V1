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
    public class CountrySettingsBO : IGTK<CountrySettingsBO>, ICloneable
    {

        public CountrySettingsBO()
        {
            RowNumber = this.RowNumber;
            CntyName = this.CntyName;
            CNTY = this.CNTY;
            HTS = this.HTS;
            CTGSKUID = this.CTGSKUID;
            IsActive = this.IsActive;
            ClSTYPE = this.ClSTYPE;
            STATUS = this.STATUS;
            Duplicate = this.Duplicate;
            SeqNo = this.SeqNo;

            IsProfile = this.IsProfile;
            ProfileName = this.ProfileName;
            Attribute1 = this.Attribute1;
            Attribute2 = this.Attribute2;

            FirstDot = this.FirstDot;
            SecondDot = this.SecondDot;
            MinimumLength = this.MinimumLength;
            MaximumLength = this.MaximumLength;
            RegExp = this.RegExp;
            GPPMHDRID = this.GPPMHDRID;
            NumOfCount = this.NumOfCount;
            DefaultCLSType = this.DefaultCLSType;
            HTSDescription = this.HTSDescription;
            WatchesRows = this.WatchesRows;
            HtsColor = this.HtsColor;
            RulingId = this.RulingId;
            Notes = this.Notes;
            CLSApprove = this.CLSApprove;
        }

        public CountrySettingsBO(string _RowNumber, string _CntyName, string _CNTY, string _HTS, string _CTGSKUID, string _IsActive, string _ClSTYPE, string
              _STATUS, string _Duplicate, string _SeqNo
              , string _IsProfile, string _ProfileName, string _Attribute1, string _Attribute2, string _FirstDot, string _SecondDot, string _MinimumLength,
              string _MaximumLength, string _RegExp, string _GPPMHDRID,
              string _NumOfCount, string _DefaultCLSType, string _HTSDescription, string _WatchesRows, string _HtsColor, string _RulingId,
              string _Notes,string _CLSApprove)
        {
            RowNumber = _RowNumber;
            CntyName = _CntyName;
            CNTY = _CNTY;
            HTS = _HTS;
            CTGSKUID = _CTGSKUID;
            IsActive = _IsActive;
            ClSTYPE = _ClSTYPE;
            STATUS = _STATUS;
            Duplicate = _Duplicate;
            SeqNo = _SeqNo;

            IsProfile = _IsProfile;
            ProfileName = _ProfileName;
            Attribute1 = _Attribute1;
            Attribute2 = _Attribute2;

            FirstDot = _FirstDot;
            SecondDot = _SecondDot;
            MinimumLength = _MinimumLength;
            MaximumLength = _MaximumLength;
            RegExp = _RegExp;
            GPPMHDRID = _GPPMHDRID;
            NumOfCount = _NumOfCount;
            DefaultCLSType = _DefaultCLSType;
            HTSDescription = _HTSDescription;
            WatchesRows = _WatchesRows;
            HtsColor = _HtsColor;
            RulingId = _RulingId;
            Notes = _Notes;
            CLSApprove = _CLSApprove;
        }

        public object Clone()
        {
            return new CountrySettingsBO(this.RowNumber, this.CntyName, this.CNTY, this.HTS, this.CTGSKUID, this.IsActive, this.ClSTYPE, this.STATUS, this.Duplicate, this.SeqNo
            , this.IsProfile, this.ProfileName, this.Attribute1, this.Attribute2, this.FirstDot, this.SecondDot, this.MinimumLength, this.MaximumLength, this.RegExp, this.GPPMHDRID,
            this.NumOfCount, this.DefaultCLSType, this.HTSDescription, this.WatchesRows, this.HtsColor,this.RulingId,this.Notes,this.CLSApprove);
        }

        public string RowNumber { get; set; }
        public string CntyName { get; set; }
        public string CNTY { get; set; }
        public string HTS { get; set; }
        public string CTGSKUID { get; set; }
        public string IsActive { get; set; }
        public string ClSTYPE { get; set; }
        public string STATUS { get; set; }
        public string Duplicate { get; set; }
        public string SeqNo { get; set; }

        public string IsProfile { get; set; }
        public string ProfileName { get; set; }
        public string Attribute1 { get; set; }
        public string Attribute2 { get; set; }

        public string FirstDot { get; set; }
        public string SecondDot { get; set; }
        public string MinimumLength { get; set; }
        public string MaximumLength { get; set; }
        public string RegExp { get; set; }
        public string GPPMHDRID { get; set; }
        public string NumOfCount { get; set; }
        public string DefaultCLSType { get; set; }
        public string HTSDescription { get; set; }
        public string WatchesRows { get; set; }
        public string HtsColor { get; set; }
        public string RulingId { get; set; }
        public string Notes { get; set; }
        public string CLSApprove { get; set; }
        public string ParentNode
        {
            get { return "CountrySettings"; }
        }
        public string ChildNode
        {
            get { return "CountrySetting"; }
        }




        public CountrySettingsBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<CountrySettingsBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CountrySettingsBO>(dtDetails);
        }
        public void RemoveDetails(ref CountrySettingsBO type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<CountrySettingsBO> liValues)
        {
            return PrepareXML.GetXml<CountrySettingsBO>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class GPMTxnPartRuling : IGTK<GPMTxnPartRuling>,ICloneable
    {
        public GPMTxnPartRuling(string _PrId, string _PrtId, string _SeqNo, string _CNTY, string _RulId, string _RulingNo, string _CtgSkuId, string
              _RulingRef, string _ParamValues, string _Status,string _SKU,string _Duplicate)
        {
            PrId = _PrId;
            PrtId = _PrtId;
            SeqNo = _SeqNo;
            CNTY = _CNTY;
            RulId = _RulId;
            RulingNo = _RulingNo;
            CtgSkuId = _CtgSkuId;
            RulingRef = _RulingRef;
            ParamValues = _ParamValues;
            Status = _Status;
            SKU = _SKU;
            Duplicate = _Duplicate;
        }



        public object Clone()
        {
            return new GPMTxnPartRuling(this.PrId, this.PrtId, this.SeqNo, this.CNTY, this.RulId, this.RulingNo, this.CtgSkuId, 
                this.RulingRef, this.ParamValues, this.Status,this.SKU,this.Duplicate);
        }
        public GPMTxnPartRuling()
        {
            PrId = this.PrId;
            PrtId = this.PrtId;
            SeqNo = this.SeqNo;
            CNTY = this.CNTY;
            RulId = this.RulId;
            RulingNo = this.RulingNo;
            CtgSkuId = this.CtgSkuId;
            RulingRef = this.RulingRef;
            ParamValues = this.ParamValues;
            Status = this.Status;
            SKU = this.SKU;
            Duplicate = this.Duplicate;
        }

        public string PrId { get; set; }
        public string PrtId { get; set; }
        public string SeqNo { get; set; }
        public string CNTY { get; set; }
        public string RulId { get; set; }
        public string RulingNo { get; set; }
        public string CtgSkuId { get; set; }
        public string RulingRef { get; set; }
        public string ParamValues { get; set; }
        public string Status { get; set; }
        public string SKU { get; set; }
        public string Duplicate { get; set; }

        public string ParentNode
        {
            get { return "RulingIds"; }
        }
        public string ChildNode
        {
            get { return "RulingId"; }
        }

        public GPMTxnPartRuling GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPMTxnPartRuling> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPMTxnPartRuling>(dtDetails);
        }
        public void RemoveDetails(ref GPMTxnPartRuling type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<GPMTxnPartRuling> liValues)
        {
            return PrepareXML.GetXml<GPMTxnPartRuling>(liValues, ParentNode, ChildNode);
        }

    }
    [Serializable]
    public class SuggestHTS : IGTK<SuggestHTS>
    {

        public string HTSCode { get; set; }
        public string Descr { get; set; }
        public string CntyCode { get; set; }
        public string PKColumn { get; set; }
        public string CmpCD{ get; set; }



        public string ParentNode
        {
            get { return "SuggestHtss"; }
        }
        public string ChildNode
        {
            get { return "SuggestHts"; }
        }

        public SuggestHTS GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<SuggestHTS> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<SuggestHTS>(dtDetails);
        }
        public void RemoveDetails(ref SuggestHTS type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<SuggestHTS> liValues)
        {
            return PrepareXML.GetXml<SuggestHTS>(liValues, ParentNode, ChildNode);
        }

    }
    [Serializable]
    public class HeaderAttributes : IGTK<HeaderAttributes>
    {
        public string AttrName { get; set; }
        public string DT { get; set; }
        public string CAPTION { get; set; }
        public string GPM_ATTBTID { get; set; }
        public string AttbtValue { get; set; }
        public string STATUS { get; set; }
        public string SIZE { get; set; }
        public string LISTVAL { get; set; }
        public string HDRAttbtDesc { get; set; }
        public string FLEXID { get; set; }
        public string LISTID { get; set; }
        public string CTGYADTL { get; set; }
        public string IsMandatory { get; set; }
        public string Color { get; set; }
        public string ISLOV { get; set; }
        public string ISREADONLY { get; set; }
        public string ParentNode
        {
            get { return "HdrAttributes"; }
        }
        public string ChildNode
        {
            get { return "HdrAttribute"; }
        }

        public HeaderAttributes GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<HeaderAttributes> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<HeaderAttributes>(dtDetails);
        }
        public void RemoveDetails(ref HeaderAttributes type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<HeaderAttributes> liValues)
        {
            return PrepareXML.GetXml<HeaderAttributes>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class CommentAttributes : IGTK<CommentAttributes>
    {


        public string AttrName { get; set; }
        public string DT { get; set; }
        public string CAPTION { get; set; }
        public string GPM_ATTBTID { get; set; }
        public string AttbtValue { get; set; }
        public string STATUS { get; set; }
        public string SIZE { get; set; }
        public string LISTVAL { get; set; }
        public string HDRAttbtDesc { get; set; }
        public string FLEXID { get; set; }
        public string LISTID { get; set; }
        public string CTGYADTL { get; set; }
        public string IsMandatory { get; set; }
        public string ISREADONLY { get; set; }
        public string ParentNode
        {
            get { return "CommentAttributes"; }
        }
        public string ChildNode
        {
            get { return "CommentAttribute"; }
        }

        public CommentAttributes GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<CommentAttributes> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CommentAttributes>(dtDetails);
        }
        public void RemoveDetails(ref CommentAttributes type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<CommentAttributes> liValues)
        {
            return PrepareXML.GetXml<CommentAttributes>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class CategoryAttributes : IGTK<CategoryAttributes>, ICloneable
    {

        public CategoryAttributes()
        {
            AttrName = this.AttrName;
            DT = this.DT;
            CAPTION = this.CAPTION;
            GPM_ATTBTID = this.GPM_ATTBTID;
            AttbtValue = this.AttbtValue;
            STATUS = this.STATUS;
            SIZE = this.SIZE;
            LISTVAL = this.LISTVAL;
            HDRAttbtDesc = this.HDRAttbtDesc;
            FLEXID = this.FLEXID;
            LISTID = this.LISTID;
            CTGYADTL = this.CTGYADTL;
            IsMandatory = this.IsMandatory;
            CMPNYADTL = this.CMPNYADTL;
            ISLOV = this.ISLOV;
            ISREADONLY = this.ISREADONLY;
            SKUID = this.SKUID;
            ISSETREADONLY = this.ISSETREADONLY;
        }
        public CategoryAttributes(string _AttrName, string _DT, string _CAPTION, string _GPM_ATTBTID, string _AttbtValue, string _STATUS,
                string _SIZE, string _LISTVAL, string _HDRAttbtDesc, string _FLEXID
            , string _LISTID, string _CTGYADTL, string _IsMandatory, string _CMPNYADTL, string _ISLOV, string _ISREADONLY, string _SKUID, string _ISSETREADONLY)
        {
            AttrName = _AttrName;
            DT = _DT;
            CAPTION = _CAPTION;
            GPM_ATTBTID = _GPM_ATTBTID;
            AttbtValue = _AttbtValue;
            STATUS = _STATUS;
            SIZE = _SIZE;
            LISTVAL = _LISTVAL;
            HDRAttbtDesc = _HDRAttbtDesc;
            FLEXID = _FLEXID;
            LISTID = _LISTID;
            CTGYADTL = _CTGYADTL;
            IsMandatory = _IsMandatory;
            CMPNYADTL = _CMPNYADTL;
            ISLOV = _ISLOV;
            ISREADONLY = _ISREADONLY;
            SKUID = _SKUID;
            ISSETREADONLY = _ISSETREADONLY;
        }
        public object Clone()
        {
            return new CategoryAttributes(this.AttrName, this.DT, this.CAPTION, this.GPM_ATTBTID, this.AttbtValue, this.STATUS,
                this.SIZE, this.LISTVAL, this.HDRAttbtDesc, this.FLEXID
            , this.LISTID, this.CTGYADTL, this.IsMandatory, this.CMPNYADTL, this.ISLOV, this.ISREADONLY, this.SKUID, this.ISSETREADONLY);
        }

        public string AttrName { get; set; }
        public string DT { get; set; }
        public string CAPTION { get; set; }
        public string GPM_ATTBTID { get; set; }
        public string AttbtValue { get; set; }
        public string STATUS { get; set; }
        public string SIZE { get; set; }
        public string LISTVAL { get; set; }
        public string HDRAttbtDesc { get; set; }
        public string FLEXID { get; set; }
        public string LISTID { get; set; }
        public string CTGYADTL { get; set; }
        public string IsMandatory { get; set; }
        public string CMPNYADTL { get; set; }
        public string ISLOV { get; set; }
        public string ISREADONLY { get; set; }
        public string SKUID { get; set; }
        public string ISSETREADONLY { get; set; }
        public string ParentNode
        {
            get { return "CategoryAttributes"; }
        }
        public string ChildNode
        {
            get { return "CategoryAttribute"; }
        }
        public CategoryAttributes GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<CategoryAttributes> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CategoryAttributes>(dtDetails);
        }
        public void RemoveDetails(ref CategoryAttributes type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<CategoryAttributes> liValues)
        {
            return PrepareXML.GetXml<CategoryAttributes>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class CountryAttributes : IGTK<CountryAttributes>
    {
        public string GPM_ATTRNAME { get; set; }
        public string GPM_CODE_ID { get; set; }
        public string cty_code { get; set; }
        public string DT { get; set; }
        public string cty_name { get; set; }
        public string CTGYADTL { get; set; }
        public string GPM_ATTBTID { get; set; }
        public string Status { get; set; }
        public string SIZE { get; set; }
        public string IsMandatory { get; set; }
        public string ParentNode
        {
            get { return "CountryAttributes"; }
        }
        public string ChildNode
        {
            get { return "CountryAttribute"; }
        }

        public CountryAttributes GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<CountryAttributes> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CountryAttributes>(dtDetails);
        }
        public void RemoveDetails(ref CountryAttributes type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<CountryAttributes> liValues)
        {
            return PrepareXML.GetXml<CountryAttributes>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class Profile : IGTK<Profile>
    {
        public string ProfileID { get; set; }
        public string ProfileName { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string IsActive { get; set; }
        public string CTGSKUID { get; set; }
        public string Status { get; set; }
        public string SeqNo { get; set; }
        public string KeyWords { get; set; }
        public string DisplayValue { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string CmpCD { get; set; }

        public string ParentNode
        {
            get { return "Profiles"; }
        }
        public string ChildNode
        {
            get { return "Profile"; }
        }

        public Profile GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<Profile> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<Profile>(dtDetails);
        }
        public void RemoveDetails(ref Profile type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<Profile> liValues)
        {
            return PrepareXML.GetXml<Profile>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class GPProfileDtls : IGTK<GPProfileDtls>
    {
        //ProfileDtlId,ProfileID,CNTY,SeqNo,CLSTYPE,HTS

        public string ProfileDtlId { get; set; }
        public string ProfileID { get; set; }
        public string CNTY { get; set; }
        public string SeqNo { get; set; }
        public string CLSTYPE { get; set; }
        public string HTS { get; set; }
        public string ProfileName { get; set; }
        public string AttrId { get; set; }
        public string AttrValue { get; set; }
        public string HTSNotes { get; set; }
        public string Status { get; set; }
        

        
        public string ParentNode
        {
            get { return "GPProfileDtls"; }
        }
        public string ChildNode
        {
            get { return "GPProfileDtl"; }
        }
        public GPProfileDtls GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<GPProfileDtls> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPProfileDtls>(dtDetails);
        }
        public void RemoveDetails(ref GPProfileDtls type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<GPProfileDtls> liValues)
        {
            return PrepareXML.GetXml<GPProfileDtls>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class CompanyAttributes : IGTK<CompanyAttributes>
    {
        public string AttrName { get; set; }
        public string FLEXID { get; set; }
        public string LISTID { get; set; }
        public string STATUS { get; set; }
        public string SIZE { get; set; }
        public string DT { get; set; }
        public string IsMandatory { get; set; }
        public string CAPTION { get; set; }
        public string ParentNode
        {
            get { return "CompanyDtls"; }
        }
        public string ChildNode
        {
            get { return "CompanyDtl"; }
        }
        public CompanyAttributes GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<CompanyAttributes> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CompanyAttributes>(dtDetails);
        }
        public void RemoveDetails(ref CompanyAttributes type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<CompanyAttributes> liValues)
        {
            return PrepareXML.GetXml<CompanyAttributes>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class MidDetails : IGTK<MidDetails>
    {
        public string PK1 { get; set; }
        public string PK2 { get; set; }
        public string FlexCol1 { get; set; }

        public string ParentNode
        {
            get { return "MODetails"; }
        }
        public string ChildNode
        {
            get { return "M0Detail"; }
        }
        public MidDetails GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<MidDetails> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<MidDetails>(dtDetails);
        }
        public void RemoveDetails(ref MidDetails type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<MidDetails> liValues)
        {
            return PrepareXML.GetXml<MidDetails>(liValues, ParentNode, ChildNode);
        }
    }


    static class Extensions
    {
        public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }

    [Serializable]
    public class DropDownData : IGTK<DropDownData>
    {

        public string StoredValue { get; set; }
        public string DisplayValue { get; set; }
        public string ListCode { get; set; }
        public string ATTRNAME { get; set; }

        public string ParentNode
        {
            get { return "DropDownData"; }
        }
        public string ChildNode
        {
            get { return "DropDownData"; }
        }
        public DropDownData GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<DropDownData> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<DropDownData>(dtDetails);
        }

        public string PrepareSaveXml(List<DropDownData> liValues)
        {
            return PrepareXML.GetXml<DropDownData>(liValues, ParentNode, ChildNode);
        }
        public void RemoveDetails(ref DropDownData type)
        {
            throw new NotImplementedException();
        }

    }
    #region CITES
    [Serializable]
    public class GPPARTCITES : IGTK<GPPARTCITES>
    {
        public GPPARTCITES()
        {
            Id = this.Id;
            PRTID = this.PRTID;
            SeqNo = this.SeqNo;
            CommonName = this.CommonName;
            ScientificName = this.ScientificName;
            COO = this.COO;
            Source = this.Source;
            Status = this.Status;
            RowNumber = this.RowNumber;
            COOName = this.COOName;
            SKUID = this.SKUID;
            CITES = this.CITES;
        }
        public GPPARTCITES(string _Id, string _PRTID, string _SeqNo, string _CommonName, string _ScientificName, string _COO,
                string _Source, string _Status, string _RowNumber, string _COOName
            , string _SKUID, string _CITES)
        {
            Id = _Id;
            PRTID = _PRTID;
            SeqNo = _SeqNo;
            CommonName = _CommonName;
            ScientificName = _ScientificName;
            COO = _COO;
            Source = _Source;
            Status = _Status;
            RowNumber = _RowNumber;
            COOName = _COOName;
            SKUID = _SKUID;
            CITES = _CITES;
        }
        public object Clone()
        {
            return new GPPARTCITES(this.Id, this.PRTID, this.SeqNo, this.CommonName, this.ScientificName, this.COO,
                this.Source, this.Status, this.RowNumber, this.COOName
            , this.SKUID, this.CITES);
        }
        public string Id { get; set; }
        public string PRTID { get; set; }
        public string SeqNo { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string COO { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string RowNumber { get; set; }
        public string COOName { get; set; }
        public string SKUID { get; set; }
        public string CITES { get; set; }

        public string ParentNode
        {
            get { return "GPPARTCITES"; }
        }
        public string ChildNode
        {
            get { return "GPPARTCITE"; }
        }
        public GPPARTCITES GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<GPPARTCITES> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPPARTCITES>(dtDetails);
        }
        public void RemoveDetails(ref GPPARTCITES type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<GPPARTCITES> liValues)
        {
            return PrepareXML.GetXml<GPPARTCITES>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class GPPARTCOMPDTL : IGTK<GPPARTCOMPDTL>
    {
        public string Id { get; set; }
        public string PRTID { get; set; }
        public string PackSize { get; set; }
        public string Style { get; set; }
        public string SKU { get; set; }
        public string StyleDesc { get; set; }
        public string Vendor { get; set; }
        public string BandNo { get; set; }
        public string ProdDesc { get; set; }
        public string QTY { get; set; }
        public string CostAmount { get; set; }
        public string CostPer { get; set; }
        public string CmpntTotalCost { get; set; }
        public string FDACODE { get; set; }
        public string NDC { get; set; }
        public string SPFLevel { get; set; }
        public string AlcoholPer { get; set; }
        public string NoofComponents { get; set; }
        public string Status { get; set; }
        public string NCV { get; set; }
        public string RemCost { get; set; }
        public string CitesFlag { get; set; }
        public string FWFlag { get; set; }

        public string ParentNode
        {
            get { return "GPPARTCOMPDTLS"; }
        }
        public string ChildNode
        {
            get { return "GPPARTCOMPDTL"; }
        }
        public GPPARTCOMPDTL GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<GPPARTCOMPDTL> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPPARTCOMPDTL>(dtDetails);
        }
        public void RemoveDetails(ref GPPARTCOMPDTL type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<GPPARTCOMPDTL> liValues)
        {
            return PrepareXML.GetXml<GPPARTCOMPDTL>(liValues, ParentNode, ChildNode);
        }
    }
    [Serializable]
    public class GPPARTCTGDTL : IGTK<GPPARTCTGDTL>
    {
        public string Id { get; set; }
        public string PRTID { get; set; }
        public string SeqNo { get; set; }
        public string CTGCD { get; set; }
        public string SKUDesc { get; set; }
        public string CostAmount { get; set; }
        public string CostPer { get; set; }
        public string CTGTotalCost { get; set; }
        public string SKU { get; set; }
        public string Status { get; set; }
        public string ISLOV { get; set; }
        public string CTGSKUID { get; set; }
        public string NoOfCount { get; set; }
         
        public string ParentNode
        {
            get { return "GPPARTCTGDTLS"; }
        }
        public string ChildNode
        {
            get { return "GPPARTCTGDTL"; }
        }
        public GPPARTCTGDTL GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<GPPARTCTGDTL> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPPARTCTGDTL>(dtDetails);
        }
        public void RemoveDetails(ref GPPARTCTGDTL type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<GPPARTCTGDTL> liValues)
        {
            return PrepareXML.GetXml<GPPARTCTGDTL>(liValues, ParentNode, ChildNode);
        }
    }

    [Serializable]
    public class GPPARTCOMPDTLBTY : IGTK<GPPARTCOMPDTLBTY>
    {
        public string Id { get; set; }
        public string PRTID { get; set; }
        public string NDC { get; set; }
        public string SPFLevel { get; set; }
        public string ItemStyle { get; set; }
        public string Status { get; set; }
        public string RowNumber { get; set; }
        public string ParentNode
        {
            get { return "GPPARTCOMPDTLBTYS"; }
        }
        public string ChildNode
        {
            get { return "GPPARTCOMPDTLBTY"; }
        }
        public GPPARTCOMPDTLBTY GetNewRow()
        {
            throw new NotImplementedException();
        }
        public List<GPPARTCOMPDTLBTY> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPPARTCOMPDTLBTY>(dtDetails);
        }
        public void RemoveDetails(ref GPPARTCOMPDTLBTY type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<GPPARTCOMPDTLBTY> liValues)
        {
            return PrepareXML.GetXml<GPPARTCOMPDTLBTY>(liValues, ParentNode, ChildNode);
        }
    }
    #endregion

    [Serializable]
    public class GPMTxnPartNotes : IGTK<GPMTxnPartNotes>
    {
        public string NotesId { get; set; }
        public string Notes { get; set; }
        public string SeqNo { get; set; }
        public string CNTY { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string NSeqno { get; set; }
        public string CtgSkuId { get; set; }

        public string ParentNode
        {
            get { return "Notes"; }
        }
        public string ChildNode
        {
            get { return "Note"; }
        }

        public GPMTxnPartNotes GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPMTxnPartNotes> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPMTxnPartNotes>(dtDetails);
        }
        public void RemoveDetails(ref GPMTxnPartNotes type)
        {
            throw new NotImplementedException();
        }
        public string PrepareSaveXml(List<GPMTxnPartNotes> liValues)
        {
            return PrepareXML.GetXml<GPMTxnPartNotes>(liValues, ParentNode, ChildNode);
        }

    }

    [Serializable]
    public class ECCNClassification : IGTK<ECCNClassification>
    {
        public string RowNumber { get; set; }
        public string CntyName { get; set; }
        public string CNTY { get; set; }
        public string ECCNCd { get; set; }
        public string ECCnCtg { get; set; }
        public string Serial { get; set; }
        public string CTGSKUID { get; set; }
        public string SeqNo { get; set; }
        public string IsApproved { get; set; }
        public string Notes { get; set; }
        public string VldtnReq { get; set; }
        public string ECCNDescr { get; set; }
        public string ExportHTS { get; set; }
        public string ExportHTSDescr { get; set; }
        public string ExportIsManual { get; set; }

        #region IGTK<Classification> Members

        public string ParentNode
        {
            get { return "ECCNClasfs"; }
        }

        public string ChildNode
        {
            get { return "ECCNClasf"; }
        }

        public ECCNClassification GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ECCNClassification> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ECCNClassification>(dtDetails);
        }

        public void RemoveDetails(ref ECCNClassification type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ECCNClassification> liValues)
        {
            return PrepareXML.GetXml<ECCNClassification>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }
}
