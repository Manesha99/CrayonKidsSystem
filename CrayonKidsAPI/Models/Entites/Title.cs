using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Title
    {
        public Title()
        {
            Employees = new HashSet<Employee>();
        }

        public int TitleId { get; set; }
        public string Mr { get; set; }
        public string Mrs { get; set; }
        public string Ms { get; set; }
        public string Dr { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
