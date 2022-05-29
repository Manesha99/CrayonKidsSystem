using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class MarkingScale
    {
        public MarkingScale()
        {
            ProgressCategories = new HashSet<ProgressCategory>();
        }

        public int MarkingScaleId { get; set; }
        public int? ReportCardTemplateId { get; set; }
        public string MarkingScaleDetails { get; set; }

        public virtual ReportCardTemplate ReportCardTemplate { get; set; }
        public virtual ICollection<ProgressCategory> ProgressCategories { get; set; }
    }
}
