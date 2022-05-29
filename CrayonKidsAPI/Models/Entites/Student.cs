using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Student
    {
        public Student()
        {
            Applications = new HashSet<Application>();
            ReportCards = new HashSet<ReportCard>();
            SchoolTerms = new HashSet<SchoolTerm>();
        }

        public int StudentId { get; set; }
        public int? ParentGuardianId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int? StudentGrade { get; set; }

        public virtual ParentGuardian ParentGuardian { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<ReportCard> ReportCards { get; set; }
        public virtual ICollection<SchoolTerm> SchoolTerms { get; set; }
    }
}
