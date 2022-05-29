using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrayonKidsAPI.ViewModels
{
    public class AllergyViewModel
    {
        public int AllergyId { get; set; }
        public string AllergyDetails { get; set; }
        public DateTime? AllergyDate { get; set; }
    }
}
