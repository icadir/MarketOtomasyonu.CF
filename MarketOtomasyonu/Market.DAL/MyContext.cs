﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using Market.Models.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .HasPrecision(7,0);
        }

    }
}
