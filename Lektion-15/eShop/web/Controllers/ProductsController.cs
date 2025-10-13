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

    public ActionResult AddToCart(string itemNumber)
    {
        /* Skriv logik som sparar ner kund, produkt och antalet produkter i Cart.json */
        var cartList = JsonData<Cart>.Get($"{_root}/Data/Cart.json");
        var customers = JsonData<Customer>.Get($"{_root}/Data/Customers.json");
        var products = JsonData<Product>.Get($"{_root}/Data/Products.json");

        // Spara undan produkter i kundvagnen...
        var productsInCart = cartList[0].Products;

        // Quick and Dirty lösning...
        // Skapa en tom array av typen List<Cart> och skriv ner den
        // innan vi går vidare...
        cartList = [];
        // Skriv ner cartList till filen Cart.json...
        JsonData<Cart>.Save($"{_root}/Data/Cart.json", cartList);

        Product product = new();

        foreach (var p in products)
        {
            if (p.ItemNumber == itemNumber)
            {
                product = p;
            }
        }

        Console.WriteLine(product);

        Cart cart = new Cart();

        foreach (var c in customers)
        {
            if (c.Id == cart.Customer.Id)
            {
                cart.Customer = c;
            }
        }

        productsInCart.Add(product);
        cart.Products = productsInCart;
        cart.Quantity = cart.Products.Count;

        // Lägg till en ny kundvagn till inläst lista av kundvagnar...
        cartList.Add(cart);

        // Skriv ner cartList till filen Cart.json...
        JsonData<Cart>.Save($"{_root}/Data/Cart.json", cartList);

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

