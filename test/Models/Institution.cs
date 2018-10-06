using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test.Models
{
    public class Institution
    {
        public int InstitutionID { get; set; }
        public string InstitutionName { get; set; }
        public bool InstitutionIsActive { get; set; }
        public IList<Department> Departments { get; set; }

        public Institution()
        {
            Departments = new List<Department>();
        }
    }
}
