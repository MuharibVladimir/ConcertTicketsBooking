using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public record ConcertForCreationDto
    {
        public string? Name { get; init; }
        public DateTime Date { get; init; }
        public int TicketsNumber { get; init; }
        public int ConcertPlaceId { get; init; }
        public string? Artist { get; init; }
    }
}
