using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class WSDetailView
    {
        public int WSDetailViewID { get; set; }
        public string WSDetailViewName { get; set; }
        public int WSDVSerialNumber { get; set; }
        public WorkStep WSDVWorkStep { get; set; }
        public int WSDVWorkStepID { get; set; }
        public bool wSDVIsActive { get; set; }
        public List<WSDVDetailObject> WSDVDetailObjects { get; set; }

        public WSDetailView()
        {
            WSDVDetailObjects = new List<WSDVDetailObject>();
        }
    }
}
