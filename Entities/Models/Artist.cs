using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Artist
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Concert>? Concerts { get; set; }
    }
}
