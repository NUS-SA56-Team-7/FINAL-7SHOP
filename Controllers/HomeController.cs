using ASP.NET_CA_SEVEN_SHOP.Data;
using ASP.NET_CA_SEVEN_SHOP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace ASP.NET_CA_SEVEN_SHOP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}