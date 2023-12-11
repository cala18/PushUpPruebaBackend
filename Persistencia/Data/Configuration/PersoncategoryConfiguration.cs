using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistencia.Entities;

namespace Persistencia.Data.Configuration
{
    public class PersoncategoryConfiguration : IEntityTypeConfiguration<Personcategory>
    {
        public void Configure(EntityTypeBuilder<Personcategory> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("personcategory");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Name).HasMaxLength(255);
        }
    }
}