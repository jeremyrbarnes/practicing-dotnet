using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConferenceAttendees.Api.Data.Models;

namespace ConferenceAttendees.Api.Data.Configurations
{
    public class ReferralSourceConfiguration : IEntityTypeConfiguration<ReferralSource>
    {
        public void Configure(EntityTypeBuilder<ReferralSource> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasIndex(g => g.Name)
                   .IsUnique();

            // Seed data
            builder.HasData(
                new ReferralSource
                {
                    Id = Guid.Parse("45ed833d-6954-4b54-b6c0-8e5b3817ac8f"),
                    Name = "Internet Advertisement"
                },
                new ReferralSource
                {
                    Id = Guid.Parse("5d951b9e-d7cd-4914-b7fd-5f44b42dfe9f"),
                    Name = "Television"
                },
                new ReferralSource
                {
                    Id = Guid.Parse("a9bc3e61-de20-44bf-b834-e21e035ae706"),
                    Name = "Newspaper Article"
                }
            );
        }
    }
}