using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class ReportCard
    {
        public ReportCard()
        {
            ReportCardTemplates = new HashSet<ReportCardTemplate>();
            SchoolTerms = new HashSet<SchoolTerm>();
        }

        public int ReportCardId { get; set; }
        public string ReportCardDetails { get; set; }
        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<ReportCardTemplate> ReportCardTemplates { get; set; }
        public virtual ICollection<SchoolTerm> SchoolTerms { get; set; }
    }
}
