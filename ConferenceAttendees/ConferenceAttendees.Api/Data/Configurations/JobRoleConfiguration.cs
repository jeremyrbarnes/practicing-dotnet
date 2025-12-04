using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConferenceAttendees.Api.Data.Models;

namespace ConferenceAttendees.Api.Data.Configurations
{
    public class JobRoleConfiguration : IEntityTypeConfiguration<JobRole>
    {
        public void Configure(EntityTypeBuilder<JobRole> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(g => g.Name)
                   .IsUnique();

            // Seed data
            builder.HasData(
                new JobRole
                {
                    Id = Guid.Parse("bdf05908-cb76-4bfc-870f-0b549d2ee80e"),
                    Name = "Manager"
                },
                new JobRole
                {
                    Id = Guid.Parse("b441ab89-404a-406e-8915-04ef7e1a2ab4"),
                    Name = "Supervisor"
                },
                new JobRole
                {
                    Id = Guid.Parse("e950a843-bfd2-4c0c-bf27-a5d338600b3c"),
                    Name = "Employee"
                }
            );
        }
    }
}