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
    public class GPComposition : IGTK<GPComposition>
    {

        public GPComposition()
        {
            RowNumber = this.RowNumber;
            CTGSKUID = this.CTGSKUID;
            PARTTYPE = this.PARTTYPE;
            PRODPART = this.PRODPART;
            METERIAL = this.METERIAL;
            PERCENTAGE = this.PERCENTAGE;
            CID = this.CID;
            STATUS = this.STATUS;
            PTCode = this.PTCode;
            PPCode = this.PPCode;
            MACode = this.MACode;
        }
        public GPComposition(string _RowNumber, string _CTGSKUID, string _PARTTYPE, string _PRODPART, string _METERIAL, string _PERCENTAGE,
                string _CID, string _STATUS, string _PTCode, string _PPCode, string _MACode)
        {
            RowNumber = _RowNumber;
            CTGSKUID = _CTGSKUID;
            PARTTYPE = _PARTTYPE;
            PRODPART = _PRODPART;
            METERIAL = _METERIAL;
            PERCENTAGE = _PERCENTAGE;
            CID = _CID;
            STATUS = _STATUS;
            PTCode = _PTCode;
            PPCode = _PPCode;
            MACode = _MACode;
        }
        public object Clone()
        {
            return new GPComposition(this.RowNumber, this.CTGSKUID, this.PARTTYPE, this.PRODPART, this.METERIAL, this.PERCENTAGE,
                this.CID, this.STATUS,this.PTCode,this.PPCode,this.MACode);
        }

        public string RowNumber { set; get; }
        public string CTGSKUID { set; get; }
        public string PARTTYPE { set; get; }
        public string PRODPART { set; get; }
        public string METERIAL { set; get; }
        public string PERCENTAGE { set; get; }
        public string CID { set; get; }
        //public string CPYCD { set; get; }
        //public string PARTNO { set; get; }
        public string STATUS { set; get; }
        public string PTCode { set; get; }
        public string PPCode { set; get; }
        public string MACode { set; get; }


        #region IGTK<GPComposition> Members

        public string ChildNode
        {
            get { return ("GPComposition"); }
        }

        public List<GPComposition> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPComposition>(dtDetails);
        }

        public GPComposition GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return ("GPComposition"); }
        }

        public string PrepareSaveXml(List<GPComposition> liValues)
        {
            return PrepareXML.GetXml<GPComposition>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref GPComposition type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }


    [Serializable]
    public class GPAssociation : IGTK<GPAssociation>
    {
        public string PRODUCT { set; get; }
        public string QTY { set; get; }
        public string UOM { set; get; }
        public string ASTYPE { set; get; }
        public string AID { set; get; }
        //public string CPYCD { set; get; }
        //public string PARTNO { set; get; }
        public string STATUS { set; get; }


        #region IGTK<GPAssociation> Members

        public string ChildNode
        {
            get { return ("GPAssociation"); }
        }

        public List<GPAssociation> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPAssociation>(dtDetails);
        }

        public GPAssociation GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return ("GPAssociation"); }
        }

        public string PrepareSaveXml(List<GPAssociation> liValues)
        {
            return PrepareXML.GetXml<GPAssociation>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref GPAssociation type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    [Serializable]
    public class GPTradeData : IGTK<GPTradeData>
    {

        public GPTradeData()
        {
            GP_VENDNAME = this.GP_VENDNAME;
            GP_CONAME = this.GP_CONAME;
            GP_MFGNAME = this.GP_MFGNAME;
            GP_VENDCD = this.GP_VENDCD;
            GP_COCD = this.GP_COCD;
            GP_MFGCD = this.GP_MFGCD;
            GP_VEND_FDA_REGNO = this.GP_VEND_FDA_REGNO;
            GP_MFG_FDA_REGNO = this.GP_MFG_FDA_REGNO;
            GP_STATUS = this.GP_STATUS;
            GP_TDID = this.GP_TDID;
            GP_BUYERNAME = this.GP_BUYERNAME;
            GP_BUYERCODE = this.GP_BUYERCODE;
            GP_MID = this.GP_MID;
            PK1 = this.PK1;
            PK2 = this.PK2;
            FlexCol1 = this.FlexCol1;
            Address = this.Address;
            City = this.City;
            Country = this.Country;
            Status = this.Status;
            RowNumber = this.RowNumber;
            IsDefault = this.IsDefault;
            SKUID = this.SKUID;

        }
        public GPTradeData(string _GP_VENDNAME, string _GP_CONAME, string _GP_MFGNAME, string _GP_VENDCD, string _GP_COCD, string _GP_MFGCD,
             string _GP_VEND_FDA_REGNO, string _GP_MFG_FDA_REGNO, string _GP_STATUS, string _GP_TDID, string _GP_BUYERNAME, string _GP_BUYERCODE, string _GP_MID, string _PK1,
             string _PK2, string _FlexCol1, string _Address, string _City, string _Country, string _Status,
             string _RowNumber, string _IsDefault, string _SKUID)
        {
            GP_VENDNAME = _GP_VENDNAME;
            GP_CONAME = _GP_CONAME;
            GP_MFGNAME = _GP_MFGNAME;
            GP_VENDCD = _GP_VENDCD;
            GP_COCD = _GP_COCD;
            GP_MFGCD = _GP_MFGCD;
            GP_VEND_FDA_REGNO = _GP_VEND_FDA_REGNO;
            GP_MFG_FDA_REGNO = _GP_MFG_FDA_REGNO;
            GP_STATUS = _GP_STATUS;
            GP_TDID = _GP_TDID;
            GP_BUYERNAME = _GP_BUYERNAME;
            GP_BUYERCODE = _GP_BUYERCODE;
            GP_MID = _GP_MID;
            PK1 = _PK1;
            PK2 = _PK2;
            FlexCol1 = _FlexCol1;
            Address = _Address;
            City = _City;
            Country = _Country;
            Status = _Status;
            RowNumber = _RowNumber;
            IsDefault = _IsDefault;
            SKUID = _SKUID;
        }
        public object Clone()
        {
            return new GPTradeData(this.GP_VENDNAME, this.GP_CONAME, this.GP_MFGNAME, this.GP_VENDCD, this.GP_COCD, this.GP_MFGCD,
                this.GP_VEND_FDA_REGNO, this.GP_MFG_FDA_REGNO, this.GP_STATUS, this.GP_TDID, this.GP_BUYERNAME, this.GP_BUYERCODE, this.GP_MID, this.PK1,
                this.PK2, this.FlexCol1, this.Address, this.City, this.Country, this.Status,
                this.RowNumber, this.IsDefault, this.SKUID);
        }
        public string GP_VENDNAME { set; get; }
        public string GP_CONAME { set; get; }
        public string GP_MFGNAME { set; get; }
        public string GP_VENDCD { set; get; }
        public string GP_COCD { set; get; }
        public string GP_MFGCD { set; get; }
        public string GP_VEND_FDA_REGNO { set; get; }
        public string GP_MFG_FDA_REGNO { set; get; }
        public string GP_STATUS { set; get; }
        public string GP_TDID { set; get; }
        public string GP_BUYERNAME { set; get; }
        public string GP_BUYERCODE { set; get; }
        public string GP_MID { set; get; }
        public string PK1 { get; set; }
        public string PK2 { get; set; }
        public string FlexCol1 { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string RowNumber { get; set; }
        public string IsDefault { get; set; }
        public string SKUID { get; set; }

        #region IGTK<GPTradeData> Members

        public string ChildNode
        {
            get { return ("GPTradeData"); }
        }

        public List<GPTradeData> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPTradeData>(dtDetails);
        }

        public GPTradeData GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return ("GPTradeData"); }
        }

        public string PrepareSaveXml(List<GPTradeData> liValues)
        {
            return PrepareXML.GetXml<GPTradeData>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref GPTradeData type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    [Serializable]
    public class GPCMPNYATTRIBPROP : IGTK<GPCMPNYATTRIBPROP>
    {
        public string ATTRNAME { set; get; }
        public string CAPTION { set; get; }
        public string DESCR { set; get; }
        public string DATATYPE { set; get; }
        public string SIZE { set; get; }
        public string SHOW { set; get; }
        public string LISTVAL { set; get; }
        public string SEQNO { set; get; }
        public string LISTID { set; get; }
        public string FLEXID { set; get; }
        public string PK { set; get; }
        public string STATUS { set; get; }
        public string ISENABLED { set; get; }



        #region IGTK<GPCMPNYATTRIBPROP> Members

        public string ChildNode
        {
            get { return ("GPCMPNYATTRIBPROPERTICE"); }
        }

        public List<GPCMPNYATTRIBPROP> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPCMPNYATTRIBPROP>(dtDetails);
        }

        public GPCMPNYATTRIBPROP GetNewRow()
        {
            throw new NotImplementedException();
        }

        public string ParentNode
        {
            get { return ("GPCMPNYATTRIBPROP"); }
        }

        public string PrepareSaveXml(List<GPCMPNYATTRIBPROP> liValues)
        {
            return PrepareXML.GetXml<GPCMPNYATTRIBPROP>(liValues, ParentNode, ChildNode);
        }

        public void RemoveDetails(ref GPCMPNYATTRIBPROP type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
