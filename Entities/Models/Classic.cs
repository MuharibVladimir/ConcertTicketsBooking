using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Classic: Concert
    {
        public string VoiceType { get; set; } = null!;
        public string CompositionName { get; set; } = null!;
        public string Composer { get; set; } = null!;
    }
}
