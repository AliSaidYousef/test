using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool DepartmentIsActive { get; set; }
        public Institution Institution { get; set; }
        public int InstitutionID { get; set; }
        public List<Process> Processes { get; set; }

        public Department()
        {
            Processes = new List<Process>();
        }
    }
}
