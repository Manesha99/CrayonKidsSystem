using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrayonKidsAPI.ViewModels
{
    public class AssessmentViewModel
    {
        public int AssessmentId { get; set; }
        public int? ReportCardTemplateId { get; set; }
        public string AssessmentDetails { get; set; }
    }
}
