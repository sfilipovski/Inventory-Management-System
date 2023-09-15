using IMS.Domain.DomainModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Domain.DbContext
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InventoryProducts> InventoryProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<InventoryProducts>()
                .HasKey(key => new {key.InventoryId, key.ProductId});

            builder.Entity<InventoryProducts>()
                .HasOne(x => x.Inventory)
                .WithMany(x => x.InventoryProducts)
                .HasForeignKey(x => x.InventoryId);

            builder.Entity<InventoryProducts>()
                .HasOne(x => x.Product)
                .WithMany(x => x.InventoryProducts)
                .HasForeignKey(x => x.ProductId);

            base.OnModelCreating(builder);
        }
    }
}
