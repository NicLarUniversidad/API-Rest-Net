using System;
using System.Collections.Generic;
using System.Linq;
using APIRest.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace APIRest.Repositories.Database.Metadata
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
