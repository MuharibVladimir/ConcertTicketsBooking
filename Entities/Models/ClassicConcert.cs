using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ClassicConcert: Concert
    {
        public VoiceType VoiceType { get; set; } 
        public string? CompositionName { get; set; }
        public string? Composer { get; set; }
    }
}
