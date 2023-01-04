using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public int TicketsNumber { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public int PlaceId { get; set; }
        public Place? Place { get; set; }
        public ICollection<Artist>? Artists { get; set; }
        public ICollection<ArtistConcert>? ArtistConcerts { get; set; }
        public int TypeId { get; set; }
        public Type? Type { get; set; }
    }
}
