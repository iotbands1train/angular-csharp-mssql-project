using Microsoft.EntityFrameworkCore;

using backend.Models;

namespace database
{
    // Represents a session with the database and provides access to database entities
    public class ApplicationDbContext : DbContext
    {
        // Constructor to initialize the DbContext with options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet property to represent the "Users" table in the database
        public DbSet<User> Users { get; set; }

        // Method to configure the database context options
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configure the database connection string
                optionsBuilder.UseSqlServer("YourConnectionString");
            }
        }

        // Method to configure the database model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity mappings, relationships, and constraints here
        }
    }
}
