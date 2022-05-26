using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Employee
    {
        public Employee()
        {
            SupplierOrders = new HashSet<SupplierOrder>();
        }

        public int EmployeeId { get; set; }
        public int? EmployeeTypeId { get; set; }
        public int? SchoolId { get; set; }
        public int? TitleId { get; set; }
        public int? EmploymentStatusId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public int? ContactNo { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }

        public virtual EmployeeType EmployeeType { get; set; }
        public virtual EmploymentStatus EmploymentStatus { get; set; }
        public virtual School School { get; set; }
        public virtual Title Title { get; set; }
        public virtual ICollection<SupplierOrder> SupplierOrders { get; set; }

       
    }
}
