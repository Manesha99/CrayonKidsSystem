using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class OrderLine
    {
        public int SupplierOrderId { get; set; }
        public int OrderTypeId { get; set; }
        public int StationeryId { get; set; }
        public int CleaningMaterialItemId { get; set; }
        public int EquipmentId { get; set; }
        public string OrderLineItem { get; set; }
    }
}
