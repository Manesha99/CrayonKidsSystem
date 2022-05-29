using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class ParentFeedback
    {
        public int ParentFeedbackId { get; set; }
        public int? ParentGuardianId { get; set; }
        public string ParentFeedbackDetails { get; set; }

        public virtual ParentGuardian ParentGuardian { get; set; }
    }
}
