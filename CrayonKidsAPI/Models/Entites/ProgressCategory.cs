using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class ProgressCategory
    {
        public ProgressCategory()
        {
            Subcategories = new HashSet<Subcategory>();
        }

        public int ProgressCategoryId { get; set; }
        public int? MarkingScaleId { get; set; }
        public string ProgressCategoryDetails { get; set; }

        public virtual MarkingScale MarkingScale { get; set; }
        public virtual ICollection<Subcategory> Subcategories { get; set; }
    }
}
