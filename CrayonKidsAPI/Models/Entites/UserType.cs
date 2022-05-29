using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class UserType
    {
        public UserType()
        {
            UserTbls = new HashSet<UserTbl>();
        }

        public int UserTypeId { get; set; }
        public string UserType1 { get; set; }

        public virtual ICollection<UserTbl> UserTbls { get; set; }
    }
}
