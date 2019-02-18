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
    public class Notes : IGTK<Notes>
    {
        public string NOTES { get; set; }
        public string USERID { get; set; }
        public string UPDATEDATE { get; set; }
        public string CTYCODE { get; set; }
        public string NOTESID { get; set; }
        public string Status { get; set; }
        public string PartId { get; set; }
        

        #region IGTK<Notes> Members

        public string ParentNode
        {
            get { return "NOTES"; }
        }

        public string ChildNode
        {
            get { return "NOTE"; }
        }

        public Notes GetNewRow()
        {
            Notes clsNotes = new Notes();
            clsNotes = new Notes()
            {
                NOTES=string.Empty,
                USERID="Netwin",
                UPDATEDATE=System.DateTime.Now.ToString(),
                CTYCODE=string.Empty,
                NOTESID = "0",
                Status="N",
                PartId=string.Empty
                

            };
            return clsNotes;
        }

        public List<Notes> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<Notes>(dtDetails);
        }

        public void RemoveDetails(ref Notes type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<Notes> liValues)
        {
            return PrepareXML.GetXml<Notes>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
