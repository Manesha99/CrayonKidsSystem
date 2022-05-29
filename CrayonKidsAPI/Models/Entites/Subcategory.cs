using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class Subcategory
    {
        public int SubcategoryId { get; set; }
        public int? ProgressCategoryId { get; set; }
        public string SubcategoryDetails { get; set; }

        public virtual ProgressCategory ProgressCategory { get; set; }
    }
}
