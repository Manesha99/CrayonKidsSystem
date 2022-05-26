using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            SupplierOrders = new HashSet<SupplierOrder>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmailAddress { get; set; }
        public string SupplierContactNo { get; set; }
        public string SupplierAddress { get; set; }

        public virtual ICollection<SupplierOrder> SupplierOrders { get; set; }
    }
}
