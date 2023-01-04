using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int? SeatNumber { get; set; }
        public string District { get; set; } = null!;
    }
}
