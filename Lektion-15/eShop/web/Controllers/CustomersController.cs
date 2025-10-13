using domain;
using Microsoft.AspNetCore.Mvc;

namespace web.Controllers;

public class CustomersController(IWebHostEnvironment environment) : Controller
{
    private readonly string _root = environment.WebRootPath;

    public ActionResult Index()
    {
        // var customers = JsonData<Customer>.Get($"{_root}/Data/Customers.json");
        // return View(customers);
        return View(JsonData<Customer>.Get($"{_root}/Data/Customers.json"));
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Add(Customer customer)
    {
        var customers = JsonData<Customer>.Get($"{_root}/Data/Customers.json");

        customer.Addresses[0].AddressType = AddressTypeEnum.Delivery;
        customer.Addresses[1].AddressType = AddressTypeEnum.Invoice;
        customer.OrderHistories = [];

        customers.Add(customer);

        JsonData<Customer>.Save($"{_root}/Data/Customers.json", customers);

        return RedirectToAction("Index");
    }

    public ActionResult Edit(string id)
    {
        var customers = JsonData<Customer>.Get($"{_root}/Data/Customers.json");

        Customer customer = new();

        foreach (var c in customers)
        {
            if (c.Id == id)
            {
                customer = c;
            }
        }

        if (customer.Addresses.Count == 1)
        {
            customer.Addresses.Add(new());
        }

        return View(customer);
    }

    [HttpPost]
    public ActionResult Edit(Customer customer)
    {
        List<Customer> customers = [];

        foreach (var c in JsonData<Customer>.Get($"{_root}/Data/Customers.json"))
        {
            if (c.Id != customer.Id)
            {
                customers.Add(c);
            }
        }

        customer.Addresses[0].AddressType = AddressTypeEnum.Delivery;
        customer.Addresses[1].AddressType = AddressTypeEnum.Invoice;
        customer.OrderHistories = [];

        customers.Add(customer);

        JsonData<Customer>.Save($"{_root}/Data/Customers.json", customers);

        return RedirectToAction("Index");
    }

    public ActionResult Details(string id)
    {
        Customer customer = new();

        foreach (var c in JsonData<Customer>.Get($"{_root}/Data/Customers.json"))
        {
            if (c.Id == id)
            {
                customer = c;
            }
        }

        if (customer.Addresses.Count == 1)
        {
            customer.Addresses.Add(new());
        }

        return View(customer);
    }
    public ActionResult Delete(string id)
    {
        List<Customer> customers = [];

        foreach (var c in JsonData<Customer>.Get($"{_root}/Data/Customers.json"))
        {
            if (c.Id != id)
            {
                customers.Add(c);
            }
        }

        JsonData<Customer>.Save($"{_root}/Data/Customers.json", customers);

        return RedirectToAction("Index");
    }

}

