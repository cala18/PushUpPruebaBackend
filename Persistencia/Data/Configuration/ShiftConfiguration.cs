using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistencia.Entities;

namespace Persistencia.Data.Configuration
{
    public class ShiftConfiguration : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("shifts");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.EndTime).HasColumnType("time");
            builder.Property(e => e.Name).HasMaxLength(255);
            builder.Property(e => e.StartTime).HasColumnType("time");
        }
    }
}