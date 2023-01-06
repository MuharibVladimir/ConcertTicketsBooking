using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Configuration
{
    public class ConcertTypeConfiguration : IEntityTypeConfiguration<ConcertType>
    {
        public void Configure(EntityTypeBuilder<ConcertType> builder)
        {

        }
    }
}
