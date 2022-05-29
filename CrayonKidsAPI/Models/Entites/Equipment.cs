using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Equipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentItemName { get; set; }
        public DateTime? EquipmentPurchaseDate { get; set; }
        public int? EquipmentTypeId { get; set; }

        public virtual EquipmentType EquipmentType { get; set; }
    }
}
