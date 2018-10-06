using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class ApprovalStep
    {
        public int ApprovalStepID { get; set; }
        public string ApprovalStepName { get; set; }
        public bool ApprovalStepIsActive { get; set; }
        public WorkStep WorkStep { get; set; }
        public int WorkStepID { get; set; }
    }
}
