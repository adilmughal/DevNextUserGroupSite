using System.Data.Entity;

namespace DevNext.Web.Models
{
    public class DevNextDbContext : DbContext
    {
        static DevNextDbContext()
        {
            Database.SetInitializer(new DevNextDbContextCreateDatabaseIntializer());
            Database.SetInitializer(new DevNextDbContextDropAndCreateDatabaseIfModelChangesIntializer());
        }

        public DevNextDbContext()
            : base("DefaultConnection")
        {
            Database.Initialize(false);
        }

        public DbSet<UserGroupEvent> Events { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<TechnicalContent> TechnicalContents { get; set; }
    }
}