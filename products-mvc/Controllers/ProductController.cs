using System.Web.Mvc;
using service;

namespace products_mvc.Controllers
{
    public class ProductController : Controller
    {
        private IProductManager _productManager { get; set; }
        public ProductController(IProductManager productManager)
        {
            _productManager = productManager;

        }

        public ActionResult Index()
        {
            var products = _productManager.GetProducts();
            ViewData["products"] = products;
            return View();
        }


        public ActionResult Details(int id)
        {
            ViewBag.Id = id;
            return PartialView("Details");
        }

        public ActionResult Edit(int id, string code, string description)
        {
            ViewBag.Id = id;
            ViewBag.Code = code;
            ViewBag.Description = description;
            return PartialView("Edit");
        }

        public ActionResult Create()
        {
            _productManager.AddProduct();
            var products = _productManager.GetProducts();
            ViewData["products"] = products;

            return PartialView("Index");
        }

        public ActionResult Delete(int id)
        {
            _productManager.DeleteProduct(id);

            var products = _productManager.GetProducts();
            ViewData["products"] = products;
            return PartialView("Index");
        }


    }
}