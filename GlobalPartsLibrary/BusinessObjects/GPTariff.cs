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
    public class GPTariff : IGTK<GPTariff>
    {
        public string TARIFFID { get; set; } //0
        public string CTYCODE { get; set; } //1
        public string TARIFF { get; set; } //2
        public string DESCR { get; set; } //3

        public string LEVEL { get; set; } //4
        public string PARENT { get; set; } //5
        public string COMMTARIFF { get; set; } //6
        public string TARIFFREFNO { get; set; } //7
        public string ISACTIVE { get; set; } //8

        public string StoredValue { get; set; }
        public string DisplayValue { get; set; }
        public string HTS { get; set; }
        public string TypeofLvl { get; set; }        
        public string ProcessId { get; set; }
        public string StepId { get; set; }

        #region IGTK<GPTariff> Members

        public string ParentNode
        {
            get { return "GPTariffs"; }
        }

        public string ChildNode
        {
            get { return "GPTariff"; }
        }

        public GPTariff GetNewRow()
        {
            throw new NotImplementedException();
        }

        public List<GPTariff> GetDetails(System.Data.DataTable dtDetails)
        {
            return GTKLINQ.ConvertToList<GPTariff>(dtDetails);
        }

        public void RemoveDetails(ref GPTariff type)
        {
            throw new NotImplementedException();
        }

        public string PrepareSaveXml(List<GPTariff> liValues)
        {
            return PrepareXML.GetXml<GPTariff>(liValues, ParentNode, ChildNode);
        }

        #endregion
    }
}
