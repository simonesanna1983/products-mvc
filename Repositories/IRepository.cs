using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories
{
    public interface IRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        int AddProduct();

        void DeleteProduct(int id);


        IEnumerable<Catalog> GetCatalog();
        Catalog GetCatalogById(int id);
        int AddCatalog();

        void DeleteCatalog(int id);

        IList<Product> GetProductsByCatalogId(int id);

    }
}
