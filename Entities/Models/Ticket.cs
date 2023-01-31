using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public int? SeatNumber { get; set; }
        public string District { get; set; } = null!;
        public int ConcertId { get; set; }
        public Concert? Concert { get; set; }
        public int BookingId { get; set; }
        public Booking? Booking { get; set; }
    }
}
