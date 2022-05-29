using CrayonKidsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrayonKidsAPI.ViewModels
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public int? ParentGuardianId { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public int? StudentGrade { get; set; }

       
    }
}
