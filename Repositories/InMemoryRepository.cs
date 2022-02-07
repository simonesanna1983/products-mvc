using entities;
using repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class InMemoryRepository : IRepository
    {
        private EntityContext context { get; set; }
        public InMemoryRepository()
        {
            context = MockData.Context;
        }


        public IEnumerable<Product> GetProducts()
        {
            var products = context.Products.ToList();
            return products;
        }

        public Product GetProductById(int id)
        {
            return context.Products.Where(x => x.Id == id).FirstOrDefault();

        }

        public int AddProduct()
        {
            var count = context.Products.Count();
            var newProduct = new Product() { Code = $"Pcode{count + 1}", Description = $"Pdescription{count + 1}" };
            context.Products.Add(newProduct);
            context.SaveChanges();

            return newProduct.Id;
        }


        public void DeleteProduct(int id)
        {
            var productToBeRemoved = context.Products.Where(x => x.Id == id).FirstOrDefault();

            context.Products.Remove(productToBeRemoved);
            context.SaveChanges();
        }




        public IEnumerable<Catalog> GetCatalog()
        {
            var catalog = context.Catalogs.ToList();
            return catalog;
        }

        public Catalog GetCatalogById(int id)
        {
            return context.Catalogs.Where(x => x.Id == id).FirstOrDefault();

        }

        public int AddCatalog()
        {
            var count = context.Catalogs.Count();
            var newCatalog = new Catalog() { Code = $"Ccode{count + 1}", Description = $"Cdescription{count + 1}" };
            context.Catalogs.Add(newCatalog);
            context.SaveChanges();

            return newCatalog.Id;
        }


        public void DeleteCatalog(int id)
        {
            var productToBeRemoved = context.Catalogs.Where(x => x.Id == id).FirstOrDefault();

            context.Catalogs.Remove(productToBeRemoved);
            context.SaveChanges();
        }


        public IList<Product> GetProductsByCatalogId(int id)
        {
            var catalog = context.Catalogs.Where(x => x.Id == id).FirstOrDefault(); //().Select(y => y.Products).ToList();

            if (catalog == null)
            {
                throw new Exception("Catalog not found.");
            }

            return catalog.Products;
        }

    }
}
