using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class EmploymentStatus
    {
        public EmploymentStatus()
        {
            Employees = new HashSet<Employee>();
        }

        public int EmploymentStatusId { get; set; }
        public string Active { get; set; }
        public string Inactive { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
