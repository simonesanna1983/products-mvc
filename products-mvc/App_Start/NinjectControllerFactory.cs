using Ninject;
using repositories;
using Repositories;
using service;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace products_mvc.App_Start
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                       ? null
                       : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IProductManager>().To<ProductManager>();
            ninjectKernel.Bind<ICatalogManager>().To<CatalogManager>();
            ninjectKernel.Bind<IRepository>().To<InMemoryRepository>();

            
        }
    }
}