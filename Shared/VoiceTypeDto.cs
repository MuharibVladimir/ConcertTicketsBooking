﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public record VoiceTypeDto
    {
        public int Id { get; init; }
        public string? Name { get; init; }
    }
}
