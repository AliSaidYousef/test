using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class WSDVDetailObject
    {
        public int WSDVDetailObjectID { get; set; }
        public string DVDOName { get; set; }
        public int DVDOSerialNumber { get; set; }
        public WSDetailView DVDODetailView { get; set; }
        public int DVDODetailViewID { get; set; }
        public bool DVDOExecutionIdentifier { get; set; }
        public string DVDODataType { get; set; }
        public string DVDOControlType { get; set; }
        public bool DVDOAllowNull { get; set; }
        public string DVDODefaultValue { get; set; }
        public bool DVDOIsEditingByUserAllowed { get; set; }
        public bool DVDOIsCalculated { get; set; }
        public string DVDOCalculationFormula { get; set; }
        public int DVDOTabOrder { get; set; }
        public bool DVDOIsUnique { get; set; }
        public bool DVDOIsActive { get; set; }
    }
}
