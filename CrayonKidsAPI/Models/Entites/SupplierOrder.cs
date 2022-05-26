using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class SupplierOrder
    {
        public int SupplierOrderId { get; set; }
        public int? SchoolId { get; set; }
        public int? EmployeeId { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierOrderDetails { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual School School { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
