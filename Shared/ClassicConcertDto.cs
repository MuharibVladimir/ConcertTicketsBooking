using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public record ClassicConcertDto: ConcertDto
    {
        public string? CompositionName { get; init; }
        public string? Composer { get; init; }
        public string? VoiceType { get; init; }
    }
}
