using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public record ClassicConcertForCreationDto: ConcertForCreationDto
    {
        public string? CompositionName { get; init; }
        public string? Composer { get; init; }
        public int VoiceTypeId { get; init; }
    }
}
