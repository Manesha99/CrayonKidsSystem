using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string CityDetails { get; set; }
        public int? ProvinceId { get; set; }

        public virtual Province Province { get; set; }
    }
}
