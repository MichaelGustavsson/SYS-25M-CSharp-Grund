using domain;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

public class ProductsController(IWebHostEnvironment environment) : Controller
{
    private readonly string _root = environment.WebRootPath;

    public ActionResult Index()
    {
        return View(JsonData<Product>.Get($"{_root}/Data/Products.json"));
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(Product product)
    {
        var products = JsonData<Product>.Get($"{_root}/Data/Products.json");
        products.Add(product);
        JsonData<Product>.Save($"{_root}/Data/Products.json", products);

        return RedirectToAction("Index");
    }

    public ActionResult Edit(string id)
    {
        foreach (var product in JsonData<Product>.Get($"{_root}/Data/Products.json"))
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
        List<Product> products = [];

        foreach (var p in JsonData<Product>.Get($"{_root}/Data/Products.json"))
        {
            if (p.ItemNumber != product.ItemNumber)
            {
                products.Add(p);
            }
        }

        products.Add(product);
        JsonData<Product>.Save($"{_root}/Data/Products.json", products);

        return RedirectToAction("Index");
    }

    public ActionResult Delete(string id)
    {
        List<Product> products = [];

        foreach (var p in JsonData<Product>.Get($"{_root}/Data/Products.json"))
        {
            if (p.ItemNumber != id)
            {
                products.Add(p);
            }
        }

        JsonData<Product>.Save($"{_root}/Data/Products.json", products);

        return RedirectToAction("Index");
    }

    public ActionResult Details(string id)
    {
        Product product = new();

        foreach (var p in JsonData<Product>.Get($"{_root}/Data/Products.json"))
        {
            if (p.ItemNumber == id)
            {
                product = p;
            }
        }

        return View(product);
    }
}

