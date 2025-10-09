using domain;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ProductsController(IWebHostEnvironment environment) : Controller
    {
        private readonly IWebHostEnvironment _environment = environment;

        // GET: ProductsController
        public ActionResult Index()
        {
            var wwwroot = _environment.WebRootPath;
            var products = Storage.ReadProductsJson($"{wwwroot}/Data/Products.json");
            return View(products);
        }

        public ActionResult Add()
        {
            return View();
        }

    }
}
