using domain;
using Microsoft.AspNetCore.Mvc;
using web;

namespace MyApp.Namespace
{
    public class CartController(IWebHostEnvironment environment) : Controller
    {
        private readonly string _root = environment.WebRootPath;

        public ActionResult Index()
        {
            Cart cart = JsonData<Cart>.Get($"{_root}/Data/Cart.json")[0];
            ViewData["CustomerName"] = $"{cart.Customer.FirstName} {cart.Customer.LastName}";
            ViewData["Erbjudande"] = "Tigersåg ifrån Bosch till kanonpris";

            return View(cart);
        }

    }
}
