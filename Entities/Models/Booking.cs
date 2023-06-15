using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Booking
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public  User? User { get; set; }
        public Guid ConcertId { get; set; }
        public Concert? Concert { get; set; }
        public DateTime BookingTime { get; set; }
    }
}
