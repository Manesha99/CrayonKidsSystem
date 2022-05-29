using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class SchoolTerm
    {
        public int SchoolTermId { get; set; }
        public int? ScheduleId { get; set; }
        public int? StudentId { get; set; }
        public int? ReportCardId { get; set; }
        public string TermDetails { get; set; }

        public virtual ReportCard ReportCard { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual Student Student { get; set; }
    }
}
