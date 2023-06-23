using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OpenAirConcert: Concert
    {
        [Required]
        public string? HeadLiner { get; set; }
        [Required]
        public string? DrivingDirections { get; set; }
    }
}
