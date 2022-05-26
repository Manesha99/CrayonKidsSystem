using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class TimeslotScheduleDate
    {
        public int TimeSlotId { get; set; }
        public int ScheduleId { get; set; }
        public int DateId { get; set; }
    }
}
