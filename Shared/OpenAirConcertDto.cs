using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public record OpenAirConcertDto: ConcertDto
    {
        public string? HeadLiner { get; init; }
        public string? DrivingDirections { get; init; }
    }
}
