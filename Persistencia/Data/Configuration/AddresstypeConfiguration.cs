using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistencia.Entities;

namespace Persistencia.Data.Configuration
{
    public class AddresstypeConfiguration : IEntityTypeConfiguration<Addresstype>
    {
        public void Configure(EntityTypeBuilder<Addresstype> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("addresstype");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Description).HasMaxLength(255);
        }
    }
}