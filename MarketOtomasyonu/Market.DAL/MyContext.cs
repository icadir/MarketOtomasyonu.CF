using Market.Models.Entities;
using System.Data.Entity;

namespace Market.DAL
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("name=MarketCon")
        {

        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<MultiProduct> MultiProducts { get; set; }
        public virtual DbSet<Acceptance> Acceptances { get; set; }
        public virtual DbSet<AcceptanceDetail> AcceptanceDetails { get; set; }
        public virtual DbSet<Sales> Saleses { get; set; }
        public virtual DbSet<Sales_Detail> SalesDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                   .Property(k => k.KDV)
                   .HasPrecision(4, 2);
            modelBuilder.Entity<Product>()
                .Property(p => p.UBPrice)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Product>()
                .Property(x => x.Stock)
                .HasPrecision(7, 0);
            modelBuilder.Entity<MultiProduct>()
                .Property(p => p.MPPiece)
                .HasPrecision(6, 0);
            modelBuilder.Entity<MultiProduct>()
                .Property(x => x.MPPrice)
                .HasPrecision(8, 2);
            modelBuilder.Entity<AcceptanceDetail>()
                .Property(x => x.Numberofpieces)
                .HasPrecision(4, 0);
            modelBuilder.Entity<AcceptanceDetail>()
              .Property(x => x.Numberofpieces)
              .HasPrecision(10, 2);
        }

    }
}
