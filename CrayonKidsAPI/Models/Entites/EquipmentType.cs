using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class EquipmentType
    {
        public EquipmentType()
        {
            Equipment = new HashSet<Equipment>();
        }

        public int EquipmentTypeId { get; set; }
        public string EquipmentTypeDescription { get; set; }

        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
