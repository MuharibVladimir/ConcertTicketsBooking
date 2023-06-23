using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public abstract class Concert
    {
        public int Id { get; set; }    
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public int TicketsNumber { get; set; }
        public int ConcertPlaceId { get; set; }
        public ConcertPlace? ConcertPlace { get; set; }
        public string? Artist { get; set; }
    }
}
