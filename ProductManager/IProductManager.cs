using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    public interface IProductManager
    {

        IEnumerable<Product> GetProducts();

        int AddProduct();

        void DeleteProduct(int id);
    }
}
