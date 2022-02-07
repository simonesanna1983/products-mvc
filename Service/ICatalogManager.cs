using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public interface ICatalogManager
    {
        IEnumerable<Catalog> GetCatalog();

        int AddCatalog();

        void DeleteCatalog(int id);


        IList<Product> GetProductsByCatalogId(int id);
    }
}
