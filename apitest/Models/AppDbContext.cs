using Microsoft.EntityFrameworkCore;
using apitest.Models;

namespace apitest.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "ApiTestDB");
        }

        public DbSet<Whish> Whishes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships
            modelBuilder.Entity<Whish>()
                .HasOne(w => w.Owner)
                .WithMany(p => p.Whishes)
                .HasForeignKey(w => w.Owner.Id);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Members)
                .WithMany(p => p.Groups);

            modelBuilder.Entity<Whish>()
                .HasMany(w => w.Buyers)
                .WithMany();
        }
    }
}