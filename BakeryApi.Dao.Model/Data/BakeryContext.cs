using Microsoft.EntityFrameworkCore;

namespace BakeryApi.Dao.Model.Data
{
    public class BakeryContext : DbContext
    {
        public BakeryContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BreadDao> Breads { get; set; }
        public DbSet<OrderDao> Orders { get; set; }
        public DbSet<OrderBreadDao> OrderBreads { get; set; }
        public DbSet<BakeryDao> Bakerys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BakeryJoaquinDB");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderBreadDao>().HasOne(b => b.BreadDao)
                .WithMany(ba => ba.BreadDaoList)
                .HasForeignKey(fo => fo.BreadDaoId);

            modelBuilder.Entity<OrderBreadDao>().HasOne(b => b.OrderDao)
                .WithMany(ba => ba.BreadDaoList)
                .HasForeignKey(fo => fo.OrderDaoId);
        }
    }
}
