using domain;
using Microsoft.AspNetCore.Http.Features;
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

        // Steg 1. skapa ett kundvagns objekt...
        Cart cart = new();

        // Steg 2. Hämta ut kunden som äger kundvagnen...
        // Vi använder ett Lamdba uttryck => (pil funktioner/arrow functions)
        Customer? customer = customers.FirstOrDefault(c => c.Id == cart.Customer.Id);
        // cart.Customer = customer!;
        // Steg 2.1 Lägg till kunden till kundvagnen
        if (customer != null)
        {
            cart.Customer = customer;
        }
        else
        {
            // Skicka tillbaka användaren till inloggningssidan...
        }

        // Steg 3. Hämta ut vald produkt ur produktsortimentet...
        Product? selectedProduct = products.FirstOrDefault(c => c.ItemNumber == itemNumber);

        // Steg 3.1 Flytta produkter som redan finns i kundvagnen till vårt nya kundvagnsobjekt...
        // Samma sak som cartList[0].Products
        // Vi måste se till att ett grundobjekt av typen Cart finns i listan...
        if (cartList.Count == 0) cartList.Add(new Cart());

        cart.Products = cartList.First().Products;

        // Steg 3.2 Kontrollera om vi redan har produkten i kundvagnen...
        Product? product = cart.Products.FirstOrDefault(c => c.ItemNumber == itemNumber);

        // Steg 3.3 Kontrollera om produkten existerade...
        if (product != null)
        {
            cart.Products.Remove(product);
            product.Quantity += 1;
            cart.Products.Add(product);
        }
        // Annars är det ny produkt som ska läggas till i kundvagnen...
        else
        {
            selectedProduct!.Quantity = 1;
            cart.Products.Add(selectedProduct);
        }

        // Step 4. Uppdatera total antal produkter i kundvagnen...
        cart.Quantity = cart.Products.Sum(c => c.Quantity);

        // Steg 5. Radera hela Cart.json filen...
        JsonData<Cart>.Save($"{_root}/Data/Cart.json", []);

        // Steg 6. Flytta vårt cart objekt in i cartList objektet
        cartList = [cart];

        // Steg 7. Slutligen skriv ner kundvagnen till filen Cart.json...
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

