using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OpenAir: ConcertType
    {
        public string HeadLiner { get; set; } = null!;
        public string DrivingDirections { get; set; } = null!;
    }
}
