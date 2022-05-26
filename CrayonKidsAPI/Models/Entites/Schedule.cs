using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            SchoolTerms = new HashSet<SchoolTerm>();
        }

        public int ScheduleId { get; set; }
        public int? SchoolId { get; set; }
        public string ScheduleDetails { get; set; }
        public DateTime? EventDate { get; set; }

        public virtual School School { get; set; }
        public virtual ICollection<SchoolTerm> SchoolTerms { get; set; }
    }
}
