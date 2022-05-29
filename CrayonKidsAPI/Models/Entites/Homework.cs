using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Homework
    {
        public int HomeworkId { get; set; }
        public int? ReportCardTemplateId { get; set; }
        public string HomeworkDetails { get; set; }

        public virtual ReportCardTemplate ReportCardTemplate { get; set; }
    }
}
