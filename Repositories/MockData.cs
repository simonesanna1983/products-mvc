using entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositories
{
    public static class MockData
    {
        public static EntityContext Context { get; set; }

        static MockData()
        {
            var dbConnection = Effort.DbConnectionFactory.CreateTransient();
            Context = new EntityContext(dbConnection);
            //var dbConnection = Effort.DbConnectionFactory.CreateTransient();
            //context = new EntityContext(dbConnection);

            var productList = new List<Product>();


            for (var i = 0; i < 10; i++)
            {
                productList.Add(new Product() { Code = $"Pcode{i + 1}", Description = $"Pdescription{i + 1}" });
            }


            var catalogList = new List<Catalog>();

            for (var i = 0; i < 3; i++)
            {
                var catalog = new Catalog() { Code = $"Ccode{i + 1}", Description = $"Cdescription{i + 1}" };
                if (i == 0)
                {
                    catalog.Products = new List<Product>();
                    catalog.Products.Add(productList[0]);
                    catalog.Products.Add(productList[1]);
                }

                if (i == 1)
                {
                    catalog.Products = new List<Product>();
                    catalog.Products.Add(productList[0]);
                }

                catalogList.Add(catalog);


            }


            Context.Catalogs.AddRange(catalogList);


            Context.Products.AddRange(productList);
            Context.SaveChanges();

        }

    }
}
