using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class School
    {
        public School()
        {
            Employees = new HashSet<Employee>();
            Schedules = new HashSet<Schedule>();
            SupplierOrders = new HashSet<SupplierOrder>();
        }

        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolLocation { get; set; }
        public string SchoolInfoDetails { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<SupplierOrder> SupplierOrders { get; set; }
    }
}
