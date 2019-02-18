using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.Extensions;
using GTKUtilites.HelpMethods;

namespace GlobalPartsLibrary.BusinessObjects
{
    #region HTSTreeView 
    [Serializable]
    public class HTSTreeView : IGTK<HTSTreeView>
    {
        public string HTSCodeNew { get; set; }
        public string DisplayText { get; set; }
        public string TID { get; set; }
        public string TCtyID { get; set; }
        public string Parent { get; set; }
        public string level { get; set; }
        public string CtyCode { get; set; }
        public string HTSCode { get; set; }
        public string Descr { get; set; }
        public string IsActive { get; set; }
        public string childcnt { get; set; }
        public string DescrNew { get; set; }
        #region IGTK<Classification> Members

        public string ParentNode
        {
            get { return "TreeviewHTSs"; }
        }

        public string ChildNode
        {
            get { return "TreeviewHTS"; }
        }

        public HTSTreeView GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<HTSTreeView> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<HTSTreeView>(dtDetails);
        }

        public void RemoveDetails(ref HTSTreeView type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<HTSTreeView> liValues)
        {
            return PrepareXML.GetXml<HTSTreeView>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }
    [Serializable]
    public class ECCNTreeView : IGTK<ECCNTreeView>
    {
        public string HTSCodeNew { get; set; }
        public string DisplayText { get; set; }
        public string TID { get; set; }
        public string TCtyID { get; set; }
        public string Parent { get; set; }
        public string level { get; set; }
        public string CtyCode { get; set; }
        public string HTSCode { get; set; }
        public string Descr { get; set; }
        public string IsActive { get; set; }
        public string childcnt { get; set; }
        public string DescrNew { get; set; }
        public string ECCNCode { get; set; }
        #region IGTK<Classification> Members

        public string ParentNode
        {
            get { return "TreeviewECCNs"; }
        }

        public string ChildNode
        {
            get { return "TreeviewECCN"; }
        }

        public ECCNTreeView GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<ECCNTreeView> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<ECCNTreeView>(dtDetails);
        }

        public void RemoveDetails(ref ECCNTreeView type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<ECCNTreeView> liValues)
        {
            return PrepareXML.GetXml<ECCNTreeView>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }
    #endregion
    [Serializable]
    public class Classification : IGTK<Classification>
    {
        public string ctycode { get; set; }
        public string tariff { get; set; }
        public string TariffID { get; set; }
        public string STATUS { get; set; }
        public string Descr { get; set; }
        #region IGTK<Classification> Members

        public string ParentNode
        {
            get { return "SelectedHTSs"; }
        }

        public string ChildNode
        {
            get { return "SelectedHTS"; }
        }

        public Classification GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<Classification> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<Classification>(dtDetails);
        }

        public void RemoveDetails(ref Classification type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<Classification> liValues)
        {
            return PrepareXML.GetXml<Classification>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }
    [Serializable]
    public class GP_BookMark : IGTK<GP_BookMark>
    {
        public string ID { get; set; }
        public string HTSNo { get; set; }
        public string Descr { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string STATUS { get; set; }
        public string IsActive { get; set; }
        public string Comment { get; set; }

        #region IGTK<Classification> Members

        public string ParentNode
        {
            get { return "BMs"; }
        }

        public string ChildNode
        {
            get { return "BM"; }
        }

        public GP_BookMark GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GP_BookMark> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GP_BookMark>(dtDetails);
        }

        public void RemoveDetails(ref GP_BookMark type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GP_BookMark> liValues)
        {
            return PrepareXML.GetXml<GP_BookMark>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }

    [Serializable]
    public class GPRuling : IGTK<GPRuling> 
    {
        public string RulingId { get; set; }
        public string RulingNo { get; set; }
        public string RulingRef { get; set; }
        public string RuleDescr { get; set; }
        public string Ruleyear { get; set; }
        public string RuleMonth { get; set; }
        public string Notes { get; set; }
        public string CountryCode { get; set; }
        public string IsActive { get; set; }
        public string category { get; set; }
        public string HTSCode { get; set; }
        public string Date { get; set; }
        public string RelatedRuling { get; set; }
        public string Status { get; set; }
        public string ctycode { get; set; }
        public string RulDescrId { get; set; }
        public string RelRulId { get; set; }

       
        #region IGTK<Classification> Members

        public string ParentNode
        {
            get { return "Rulings"; }
        }

        public string ChildNode
        {
            get { return "Ruling"; }
        }

        public GPRuling GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPRuling> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPRuling>(dtDetails);
        }

        public void RemoveDetails(ref GPRuling type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPRuling> liValues)
        {
            return PrepareXML.GetXml<GPRuling>(liValues, ParentNode, ChildNode);
        }
        #endregion
    }
}

