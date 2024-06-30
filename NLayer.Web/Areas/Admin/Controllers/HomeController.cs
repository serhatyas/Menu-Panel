using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    //[Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Error(ErrorViewModel errorViewModel)
        {
            return View(errorViewModel);
        }
    }
}
