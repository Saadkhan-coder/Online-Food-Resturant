using Microsoft.AspNetCore.Mvc;
using OnlineFood.Models;
using System.Diagnostics;
using OnlineFood.DataDB;

namespace OnlineFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OnlineFoodContext _context;

        public HomeController(ILogger<HomeController> logger, OnlineFoodContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult menu()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult order()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Order(Orderfood model)
        {
            if (ModelState.IsValid)
            {
                _context.Orderfoods.Add(model);
                _context.SaveChanges();
                TempData["SuccessMessage"] = "Order placed successfully!";
                return RedirectToAction("Order");
            }

            TempData["ErrorMessage"] = "There was a problem placing your order. Please try again.";
            return View(model);
        }

        public IActionResult TraceOrder()
        {
            var orders = _context.Orderfoods.ToList();
            return View(orders);
        }

        public IActionResult AdminLogin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
