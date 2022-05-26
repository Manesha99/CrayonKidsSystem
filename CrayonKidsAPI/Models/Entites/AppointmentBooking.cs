using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class AppointmentBooking
    {
        public int AppointmentBookingId { get; set; }
        public string AppointmentBookingDetails { get; set; }
        public int? BookingStatusId { get; set; }
        public DateTime? AppointmentBookingDate { get; set; }

        public virtual BookingStatus BookingStatus { get; set; }
    }
}
