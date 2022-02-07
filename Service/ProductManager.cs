using entities;
using repositories;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductManager : IProductManager
    {
        private IRepository _repository { get; set; }
        public ProductManager(IRepository repository)
        {
            _repository = repository;
        }


        public IEnumerable<Product> GetProducts()
        {
            return _repository.GetProducts();
        }

        public int AddProduct()
        {
            return _repository.AddProduct();

        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
        }

    }
}
