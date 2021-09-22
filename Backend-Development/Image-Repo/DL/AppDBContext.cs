using Microsoft.EntityFrameworkCore;
using Models;

namespace DL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base() {}
        public AppDBContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .Property(user => user.Id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Image>()
            .Property(image => image.Id)
            .ValueGeneratedOnAdd();
        }
    }
}
