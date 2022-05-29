using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class UserTbl
    {
        public int UserTblId { get; set; }
        public int? UserTypeId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual UserType UserType { get; set; }
    }
}
