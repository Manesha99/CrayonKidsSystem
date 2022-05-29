using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class ApplicationStatus
    {
        public ApplicationStatus()
        {
            Applications = new HashSet<Application>();
        }

        public int ApplicationStatusId { get; set; }
        public int? ApplicationId { get; set; }
        public string Accepted { get; set; }
        public string Rejected { get; set; }
        public string Pending { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
