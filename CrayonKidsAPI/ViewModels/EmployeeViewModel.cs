using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrayonKidsAPI.ViewModels
{
    public class EmployeeViewModel
    {
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

    }
}
