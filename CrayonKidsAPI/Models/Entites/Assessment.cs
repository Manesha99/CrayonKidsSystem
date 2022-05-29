using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Assessment
    {
        public int AssessmentId { get; set; }
        public int? ReportCardTemplateId { get; set; }
        public string AssessmentDetails { get; set; }

        public virtual ReportCardTemplate ReportCardTemplate { get; set; }
    }
}
