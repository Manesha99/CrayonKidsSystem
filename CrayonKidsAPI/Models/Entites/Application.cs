using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public int? ParentGuardianId { get; set; }
        public int? StudentId { get; set; }
        public int? ApplicationStatusId { get; set; }
        public DateTime? ApplicationDate { get; set; }

        public virtual ApplicationStatus ApplicationStatus { get; set; }
        public virtual ParentGuardian ParentGuardian { get; set; }
        public virtual Student Student { get; set; }
    }
}
