using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public record OpenAirConcertForCreationDto: ConcertForCreationDto
    {
        public string? HeadLiner { get; init; }
        public string? DrivingDirections { get; init; }
    }
}
