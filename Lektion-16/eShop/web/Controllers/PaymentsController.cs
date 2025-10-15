using domain;
using Microsoft.AspNetCore.Mvc;
using web;

namespace MyApp.Namespace
{
    public class PaymentsController(IWebHostEnvironment environment) : Controller
    {
        private readonly string _root = environment.WebRootPath;

        public ActionResult Index()
        {
            Cart cart = JsonData<Cart>.Get($"{_root}/Data/Cart.json").First();
            Customer? customer = JsonData<Customer>.Get($"{_root}/Data/Customers.json")
                .FirstOrDefault(c => c.Id == cart.Customer.Id);

            List<OrderItem> orderItems = [];

            foreach (var product in cart.Products)
            {
                orderItems.Add(new OrderItem() { Product = product, Quantity = product.Quantity, Discount = 0 });
            }

            Order order = new()
            {
                Customer = cart.Customer,
                OrderItems = orderItems
            };

            // Detta bör ligga i någon annan controller...
            // Skriv ner ordern till fil...
            List<Order> orders = [order];
            JsonData<Order>.Save($"{_root}/Data/Orders.json", orders);

            // Uppdatera kundens orderhistorik...
            if (customer is not null)
            {
                OrderHistory history = new()
                {
                    OrderDate = order.OrderDate,
                    OrderNumber = order.OrderNumber,
                    Status = OrderStatus.Mottagen,
                    OrderItems = order.OrderItems
                };

                customer.OrderHistories.Add(history);

                List<Customer> customers = [];
                customers.Add(customer);

                JsonData<Customer>.Save($"{_root}/Data/Customers.json", customers);
            }

            // Töm kundkorgen...
            JsonData<Cart>.Save($"{_root}/Data/Cart.json", []);

            return View(order);
        }

    }
}
