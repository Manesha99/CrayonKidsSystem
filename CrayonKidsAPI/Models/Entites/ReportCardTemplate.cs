using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class ReportCardTemplate
    {
        public ReportCardTemplate()
        {
            Assessments = new HashSet<Assessment>();
            Homeworks = new HashSet<Homework>();
            MarkingScales = new HashSet<MarkingScale>();
            Tests = new HashSet<Test>();
        }

        public int ReportCardTemplateId { get; set; }
        public int? ReportCardId { get; set; }
        public int? ReportCardGrade { get; set; }

        public virtual ReportCard ReportCard { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }
        public virtual ICollection<MarkingScale> MarkingScales { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
