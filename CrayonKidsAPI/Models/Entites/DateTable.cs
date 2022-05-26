using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class DateTable
    {
        public int DateId { get; set; }
        public string DateDetails { get; set; }
        public DateTime? Year { get; set; }
        public DateTime? Month { get; set; }
    }
}
