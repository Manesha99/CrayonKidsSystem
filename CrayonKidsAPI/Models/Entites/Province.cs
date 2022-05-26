using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Province
    {
        public Province()
        {
            Cities = new HashSet<City>();
        }

        public int ProvinceId { get; set; }
        public string ProvinceDetails { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
