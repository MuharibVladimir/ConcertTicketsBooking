using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public record PartyConcertForCreationDto: ConcertForCreationDto
    {
        public int MinAge { get; init; }
    }
}
