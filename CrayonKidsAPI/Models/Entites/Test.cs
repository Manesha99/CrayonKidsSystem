using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Test
    {
        public int TestId { get; set; }
        public int? ReportCardTemplateId { get; set; }
        public string TestDetails { get; set; }

        public virtual ReportCardTemplate ReportCardTemplate { get; set; }
    }
}
