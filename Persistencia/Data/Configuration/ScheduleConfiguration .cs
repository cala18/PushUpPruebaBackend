using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistencia.Entities;

namespace Persistencia.Data.Configuration
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("schedule");

            builder.HasIndex(e => e.ContractId, "ContractId");

            builder.HasIndex(e => e.EmployeeId, "EmployeeId");

            builder.HasIndex(e => e.ShiftId, "ShiftId");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.Contract).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.ContractId)
                .HasConstraintName("schedule_ibfk_1");

            builder.HasOne(d => d.Employee).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("schedule_ibfk_3");

            builder.HasOne(d => d.Shift).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.ShiftId)
                .HasConstraintName("schedule_ibfk_2");
        }
    }
}