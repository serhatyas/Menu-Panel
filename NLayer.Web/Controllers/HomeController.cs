using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;
using NLayer.Web.Models;
using System.Diagnostics;

namespace NLayer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _services;

        public HomeController(IProductService services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _services.GetProductsWithCategory());
        }

        public IActionResult Privacy()
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
