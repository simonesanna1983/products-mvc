using entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories
{
    public class EntityContext : DbContext
    {
        public EntityContext(DbConnection connection) : base(connection, false)
        {

        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // configures one-to-many relationship
        //    modelBuilder.Entity<Product>()
        //        .HasRequired<Catalog>(s => s.CurentCatalog)
        //        .WithMany(g => g.Products)
        //        .HasForeignKey<int>(s => s.CurrentCatalogId);
        //}
        public DbSet<Product> Products { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }

    }
}
