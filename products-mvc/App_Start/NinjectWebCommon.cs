//using Microsoft.Web.Infrastructure.DynamicModuleHelper;
//using Ninject;
//using Ninject.Web.Common;
//using Ninject.Web.Common.WebHost;
//using service;
//using Service;
//using System;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Routing;

//[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(products_mvc.App_Start.NinjectWebCommon), "Start")]
//[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(products_mvc.App_Start.NinjectWebCommon), "Stop")]
//namespace products_mvc.App_Start
//{
//    public static class NinjectWebCommon
//    {
//        public static readonly Bootstrapper bootstrapper = new Bootstrapper();

//        /// <summary>
//        /// Starts the application
//        /// </summary>
//        public static void Start()
//        {
//            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
//            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
//            bootstrapper.Initialize(CreateKernel);
//        }

//        /// <summary>
//        /// Stops the application.
//        /// </summary>
//        public static void Stop()
//        {
//            bootstrapper.ShutDown();
//        }

//        /// <summary>
//        /// Creates the kernel that will manage your application.
//        /// </summary>
//        /// <returns>The created kernel.</returns>
//        private static IKernel CreateKernel()
//        {
//            var kernel = new StandardKernel();
//            try
//            {
//                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
//                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

//                kernel.Bind<IProductManager>().To<ProductManager>();

//                RegisterServices(kernel);
//                return kernel;
//            }
//            catch
//            {
//                kernel.Dispose();
//                throw;
//            }
//        }

//        /// <summary>
//        /// Load your modules or register your services here!
//        /// </summary>
//        /// <param name="kernel">The kernel.</param>
//        private static void RegisterServices(IKernel kernel)
//        {
//        }
//    }

//    public interface IKernelResolver
//    {
//        T Get<T>();
//    }

//    public class KernelResolver : IKernelResolver
//    {
//        public T Get<T>()
//        {
//            return NinjectWebCommon.bootstrapper.Kernel.Get<T>();
//        }
//    }


//}
