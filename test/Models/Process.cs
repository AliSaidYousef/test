using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Process
    {
        public int ProcessID { get; set; }
        public string ProcessName { get; set; }
        public int ProcessSerialNumber { get; set; }
        public Department ProcessDepartment { get; set; }
        public int DepartmentID { get; set; }
        public bool ProcessIsActive { get; set; }
        public List<WorkStep> ProcessSteps { get; set; }

        public Process()
        {
            ProcessSteps = new List<WorkStep>();
        }
    }
}
