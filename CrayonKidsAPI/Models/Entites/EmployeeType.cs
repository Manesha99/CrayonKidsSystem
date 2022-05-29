using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        public int EmployeeTypeId { get; set; }
        public string Teacher { get; set; }
        public string Cook { get; set; }
        public string Gardener { get; set; }
        public string Administrator { get; set; }
        public string Principal { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
