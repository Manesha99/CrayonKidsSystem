using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class ParentGuardian
    {
        public ParentGuardian()
        {
            Applications = new HashSet<Application>();
            SchoolFeesStatuses = new HashSet<SchoolFeesStatus>();
            Students = new HashSet<Student>();
        }

        public int ParentGuardianId { get; set; }
        public string ParentName { get; set; }
        public string ParentSurname { get; set; }
        public string ParentContactNo { get; set; }
        public string ParentEmailAddress { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<SchoolFeesStatus> SchoolFeesStatuses { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
