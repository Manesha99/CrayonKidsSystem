using System;
using System.Collections.Generic;

#nullable disable

namespace CrayonKidsAPI.Models
{
    public partial class BookingStatus
    {
        public BookingStatus()
        {
            AppointmentBookings = new HashSet<AppointmentBooking>();
        }

        public int BookingStatusId { get; set; }
        public string Accepted { get; set; }
        public string Rejected { get; set; }
        public string Pending { get; set; }

        public virtual ICollection<AppointmentBooking> AppointmentBookings { get; set; }
    }
}
