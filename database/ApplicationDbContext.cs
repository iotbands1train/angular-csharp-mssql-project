using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OtherModel> OtherModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the model
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<OtherModel>().ToTable("OtherModels");
            // Add other configurations as needed
        }
    }
}
