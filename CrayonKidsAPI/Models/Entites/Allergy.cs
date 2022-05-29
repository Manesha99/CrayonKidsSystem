using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Allergy
    {
        public int AllergyId { get; set; }
        public string AllergyDetails { get; set; }
        public DateTime? AllergyDate { get; set; }
    }
}
