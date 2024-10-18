using Microsoft.EntityFrameworkCore;
using apitest.Models;

namespace apitest.Models
{
    public class EnigmaDbContext : DbContext
    {
        public EnigmaDbContext(DbContextOptions<EnigmaDbContext> options) : base(options) { }      

        public DbSet<Whish> Whishes { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships
            modelBuilder.Entity<Whish>()
                .HasOne(w => w.Owner)
                .WithMany(p => p.Whishes)
                .HasForeignKey(w => w.OwnerId);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Members)
                .WithMany(p => p.Groups);

            modelBuilder.Entity<Whish>()
                .HasMany(w => w.Buyers)
                .WithMany();
        }
    }
}