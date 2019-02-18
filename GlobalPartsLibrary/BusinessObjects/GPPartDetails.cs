using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTKUtilites.InterfaceLayer;
using GTKUtilites.Extensions;

namespace GlobalPartsLibrary.BusinessObjects
{
    public class GPPartDetails : IGTK<GPPartDetails>
    {
        public string PDID { get; set; } //0
        public string PID { get; set; } //1
        public string VENDNAME { get; set; } //2
        public string COONAME { get; set; } //3

        public string MFGNAME { get; set; } //4

        #region IGTK<GPPartDetails> Members

        public string ParentNode
        {
            get { return "GPPartDetails"; }
        }

        public string ChildNode
        {
            get { return "GPPartDetailss"; }
        }

        public GPPartDetails GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPPartDetails> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPPartDetails>(dtDetails);
        }

        public void RemoveDetails(ref GPPartDetails type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPPartDetails> liValues)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
