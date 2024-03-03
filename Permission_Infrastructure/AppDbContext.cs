using Microsoft.EntityFrameworkCore;
using Permission_Domen.Entityes;
using VehicleManagement_Domen.Entityes;

namespace Permission_Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Transport> Transports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
