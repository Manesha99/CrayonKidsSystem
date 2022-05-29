using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Emergency
    {
        public int EmergencyId { get; set; }
        public string EmergencyDetails { get; set; }
        public DateTime? EmergencyDate { get; set; }
    }
}
