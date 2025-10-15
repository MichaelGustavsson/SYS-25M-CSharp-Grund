using domain;
using Microsoft.AspNetCore.Mvc;
using web;

namespace MyApp.Namespace
{
    public class ConfirmationsController(IWebHostEnvironment environment) : Controller
    {
        private readonly string _root = environment.WebRootPath;
        public ActionResult Index()
        {
            Order order = JsonData<Order>.Get($"{_root}/Data/Orders.json").First();
            return View(order);
        }
    }
}
