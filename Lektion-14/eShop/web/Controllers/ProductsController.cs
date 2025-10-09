using domain;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class ProductsController(IWebHostEnvironment environment) : Controller
    {
        private readonly IWebHostEnvironment _environment = environment;

        public ActionResult Index()
        {
            return View(GetProducts());
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            // 1.            
            var products = GetProducts();
            // 2.
            products.Add(product);
            // 3.            
            SaveProducts(products);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            foreach (var product in GetProducts())
            {
                if (product.ItemNumber == id)
                {
                    return View("Edit", product);
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            List<Product> list = [];

            foreach (var p in GetProducts())
            {
                if (p.ItemNumber != product.ItemNumber)
                {
                    list.Add(p);
                }
            }

            list.Add(product);
            SaveProducts(list);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(string id)
        {
            List<Product> list = [];

            foreach (var p in GetProducts())
            {
                if (p.ItemNumber != id)
                {
                    list.Add(p);
                }
            }

            SaveProducts(list);

            return RedirectToAction("Index");
        }

        private List<Product> GetProducts()
        {
            var wwwroot = _environment.WebRootPath;
            var products = Storage<Product>.ReadJson($"{wwwroot}/Data/Products.json");
            return products;
        }

        private void SaveProducts(List<Product> products)
        {
            var wwwroot = _environment.WebRootPath;
            Storage<Product>.WriteJson($"{wwwroot}/Data/products.json", products);
        }
    }
}
