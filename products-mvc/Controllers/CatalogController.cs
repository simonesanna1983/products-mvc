using System.Web.Mvc;
using service;

namespace products_mvc.Controllers
{
    public class CatalogController : Controller
    {
        private ICatalogManager _catalogManager { get; set; }
        public CatalogController(ICatalogManager productManager)
        {
            _catalogManager = productManager;

        }

        public ActionResult Index()
        {
            var products = _catalogManager.GetCatalog();
            ViewData["catalogs"] = products;
            return View();
        }


        public ActionResult Details(int id)
        {
            ViewBag.Id = id;
            return PartialView("Details");
        }

        public ActionResult Create()
        {
            _catalogManager.AddCatalog();
            var products = _catalogManager.GetCatalog();
            ViewData["catalogs"] = products;

            return PartialView("Index");
        }

        public ActionResult Delete(int id)
        {
            _catalogManager.DeleteCatalog(id);

            var products = _catalogManager.GetCatalog();
            ViewData["catalogs"] = products;
            return PartialView("Index");
        }


    }
}