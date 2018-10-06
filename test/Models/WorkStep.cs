using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class WorkStep
    {
        public int WorkStepID { get; set; }
        public string WorkStepName { get; set; }
        public int WorkStepSerialNumber { get; set; }
        public Process WorkStepProcess { get; set; }
        public int ProcessID { get; set; }
        public bool WorkStepIsActive { get; set; }
        public List<WSHeaderObject> WSHeaderObjects { get; set; }
        public List<WSDetailView> WSDetailViews { get; set; }
        public List<ApprovalStep> ApprovalSteps { get; set; }

        public WorkStep()
        {
            WSHeaderObjects = new List<WSHeaderObject>();
            WSDetailViews = new List<WSDetailView>();
            ApprovalSteps = new List<ApprovalStep>();
        }
    }
}
