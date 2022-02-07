using entities;
using repositories;
using System.Collections.Generic;

namespace service
{
    public class CatalogManager : ICatalogManager
    {
        private IRepository _repository { get; set; }
        public CatalogManager(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Catalog> GetCatalog()
        {
            return _repository.GetCatalog();
        }

        public int AddCatalog()
        {
            return _repository.AddCatalog();

        }

        public void DeleteCatalog(int id)
        {
            _repository.DeleteCatalog(id);
        }



        public IList<Product> GetProductsByCatalogId(int id)
        {
            return _repository.GetProductsByCatalogId(id);
        }
    }
}
