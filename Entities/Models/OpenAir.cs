using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OpenAir: Type
    {
        public string HeadLiner { get; set; } = null!;
        public string DrivingDirections { get; set; } = null!;
    }
}
