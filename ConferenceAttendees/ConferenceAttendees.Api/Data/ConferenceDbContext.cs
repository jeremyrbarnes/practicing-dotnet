using Microsoft.EntityFrameworkCore;
using ConferenceAttendees.Api.Data.Models;

namespace ConferenceAttendees.Api.Data
{
    public class ConferenceDbContext : DbContext
    {
        public ConferenceDbContext(DbContextOptions<ConferenceDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConferenceDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<JobRole> JobRoles { get; set; }
        public DbSet<ReferralSource> ReferralSources { get; set; }
    }
}