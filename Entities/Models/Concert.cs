﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public abstract class Concert
    {
        public Guid Id { get; set; }    
        public string Name { get; set; } = null!;
        public DateTime Date { get; set; }
        public int TicketsNumber { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
        public int PlaceId { get; set; }
        public Place? Place { get; set; }
        public string Artist { get; set; } = string.Empty!;
        public ConcertTypes ConcertType { get; set; }
        //public int ConcertTypeId { get; set; }
        //public ConcertType? ConcertType { get; set; }
    }
}
