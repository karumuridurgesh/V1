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
    public class AttributeSetupBO : IGTK<AttributeSetupBO>
    {
        public string GPM_ATTRNAME { get; set; }
        public string GPM_CAPTION { get; set; }
        public string GPM_DATATYPE { get; set; }
        public string GPM_SIZE { get; set; }
        public string GPM_DESCR { get; set; }
        public string GPM_ISACTIVE { get; set; }
        public string GPM_SEQNO { get; set; }
        public string GPM_LISTVAL { get; set; }
        public string GPM_LEVEL { get; set; }
        public string GPM_FLEXID { get; set; }
        public string GPM_ATTBTID { get; set; }
        public string GPM_LISTID { get; set; }
        public string GPM_CREATEDBY { get; set; }
        public string GPM_CREATEDDATE { get; set; }
        public string GPM_MODIFIEDBY { get; set; }
        public string GPM_MODIFIEDDATE { get; set; }
        public string GPM_STATUS { get; set; }
        public string GPM_ISUSED { get; set; }
        public string IsMandatory { get; set; }
        public string Show { get; set; }
        public string ISREADONLY { get; set; }
        public string isSetReadOnly { get; set; }
      
        
        #region IGTK<AttributeSetupBO> Members

        public string ParentNode
        {
            get { return "AttributeSetupBO"; }
        }

        public string ChildNode
        {
            get { return "AttributeSetupBO"; }
        }

        public AttributeSetupBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<AttributeSetupBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<AttributeSetupBO>(dtDetails);
        }

        public void RemoveDetails(ref AttributeSetupBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<AttributeSetupBO> liValues)
        {
            return PrepareXML.GetXml<AttributeSetupBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

    [Serializable]
    public class LVLDTL : IGTK<LVLDTL>
    {

        public string GPM_CODE { get; set; }
        public string GPM_DESC { get; set; }
        public string GPM_ATTBTID { get; set; }
        public string GPM_ATTBTDTLID { get; set; }
        public string GPM_STATUS { get; set; }
        public string IsActive { get; set; }
        //public string Cmpcd { get; set; }
        public string Show { get; set; }

        public string Cmpcd { get; set; }
        #region IGTK<LVLDTL> Members

        public string ParentNode
        {
            get { return "LVLDTL"; }
        }

        public string ChildNode
        {
            get { return "LVLDTL"; }
        }

        public LVLDTL GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<LVLDTL> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<LVLDTL>(dtDetails);
        }

        public void RemoveDetails(ref LVLDTL type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<LVLDTL> liValues)
        {
            return PrepareXML.GetXml<LVLDTL>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }


    [Serializable]
    public class CTGLVLBO : IGTK<CTGLVLBO>
    {

        public string GPM_ATTRNAME { get; set; }
        public string GPM_CAPTION { get; set; }
        public string GPM_DATATYPE { get; set; }

        #region IGTK<CTGLVLBO> Members

        public string ParentNode
        {
            get { return "CTGLVLBO"; }
        }

        public string ChildNode
        {
            get { return "CTGLVLBO"; }
        }

        public CTGLVLBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<CTGLVLBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CTGLVLBO>(dtDetails);
        }

        public void RemoveDetails(ref CTGLVLBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<CTGLVLBO> liValues)
        {
            return PrepareXML.GetXml<CTGLVLBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

    [Serializable]
    public class CMPNYLVLBO : IGTK<CMPNYLVLBO>
    {

        public string GPM_ATTRNAME { get; set; }
        public string GPM_CAPTION { get; set; }
        public string GPM_DATATYPE { get; set; }

        #region IGTK<CMPNYLVLBO> Members

        public string ParentNode
        {
            get { return "CMPNYLVLBO"; }
        }

        public string ChildNode
        {
            get { return "CMPNYLVLBO"; }
        }

        public CMPNYLVLBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<CMPNYLVLBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CMPNYLVLBO>(dtDetails);
        }

        public void RemoveDetails(ref CMPNYLVLBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<CMPNYLVLBO> liValues)
        {
            return PrepareXML.GetXml<CMPNYLVLBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

    [Serializable]
    public class CTYLVLBO : IGTK<CTYLVLBO>
    {

        public string GPM_ATTRNAME { get; set; }
        public string GPM_CAPTION { get; set; }
        public string GPM_DATATYPE { get; set; }

        #region IGTK<CTYLVLBO> Members

        public string ParentNode
        {
            get { return "CTYLVLBO"; }
        }

        public string ChildNode
        {
            get { return "CTYLVLBO"; }
        }

        public CTYLVLBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<CTYLVLBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<CTYLVLBO>(dtDetails);
        }

        public void RemoveDetails(ref CTYLVLBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<CTYLVLBO> liValues)
        {
            return PrepareXML.GetXml<CTYLVLBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

    [Serializable]
    public class HDRLVLBO : IGTK<HDRLVLBO>
    {

        public string GPM_ATTRNAME { get; set; }
        public string GPM_CAPTION { get; set; }
        public string GPM_DATATYPE { get; set; }

        #region IGTK<HDRLVLBO> Members

        public string ParentNode
        {
            get { return "HDRLVLBO"; }
        }

        public string ChildNode
        {
            get { return "HDRLVLBO"; }
        }

        public HDRLVLBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<HDRLVLBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<HDRLVLBO>(dtDetails);
        }

        public void RemoveDetails(ref HDRLVLBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<HDRLVLBO> liValues)
        {
            return PrepareXML.GetXml<HDRLVLBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }

    [Serializable]
    public class HDRBO : IGTK<HDRBO>
    {

        public string GPM_ATTRNAME { get; set; }
        public string GPM_CAPTION { get; set; }
        public string GPM_DATATYPE { get; set; }


        #region IGTK<HDRBO> Members

        public string ParentNode
        {
            get { return "HDRBO"; }
        }

        public string ChildNode
        {
            get { return "HDRBO"; }
        }

        public HDRBO GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<HDRBO> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<HDRBO>(dtDetails);
        }

        public void RemoveDetails(ref HDRBO type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<HDRBO> liValues)
        {
            return PrepareXML.GetXml<HDRBO>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
