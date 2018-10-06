using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class WSHeaderObject
    {
        public int WSHeaderObjectID { get; set; }
        public string WSHObjectName { get; set; }
        public int WSHHOSerialNumber { get; set; }
        public WorkStep WSHOWorkStep { get; set; }
        public int WSHOWorkStepID { get; set; }
        public int wSHOExecutionIdentifier { get; set; }
        public string wSHODataType { get; set; }
        public string wSHOControlType { get; set; }
        public bool wSHOAllowNull { get; set; }
        public string wSHODefaultValue { get; set; }
        public bool wSHOIsEditingByUserAllowed { get; set; }
        public bool wSHOIsCalculated { get; set; }
        public string wSHOCalculationFormula { get; set; }
        public int wSHOTabOrder { get; set; }
        public bool wSHOIsUnique { get; set; }
        public bool wSHOIsActive { get; set; }
    }
}
