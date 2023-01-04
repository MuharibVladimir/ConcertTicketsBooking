﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Concert>? Concerts { get; set; }
        public ICollection<ArtistConcert>? ArtistConcerts { get; set; }
    }
}
