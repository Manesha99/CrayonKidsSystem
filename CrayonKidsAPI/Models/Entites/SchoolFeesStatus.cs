using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class SchoolFeesStatus
    {
        public int SchoolFeesStatusId { get; set; }
        public string SchoolFeesStatusDescription { get; set; }
        public int? ParentGuardianId { get; set; }

        public virtual ParentGuardian ParentGuardian { get; set; }
    }
}
