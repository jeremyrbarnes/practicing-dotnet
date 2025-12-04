using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConferenceAttendees.Api.Data.Models;

namespace ConferenceAttendees.Api.Data.Configurations
{
    public class GenderConfiguration : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(g => g.Name)
                   .IsUnique();

            // Seed data
            builder.HasData(
                new Gender
                {
                    Id = Guid.Parse("995dd6e5-6a17-4f7d-9e61-7563ce443317"),
                    Name = "Male"
                },
                new Gender
                {
                    Id = Guid.Parse("bef000a6-0b2e-4ae9-9202-4afadc772b68"),
                    Name = "Female"
                }
            );
        }
    }
}