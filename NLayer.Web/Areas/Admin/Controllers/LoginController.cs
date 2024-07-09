using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Services;
using System.Security.Claims;
using NLayer.Service.Services;
using NLayer.Core.Model;
using NLayer.Core.DTOs;

namespace NLayer.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IUserSerivce _userSerivce;
        private readonly IMapper _mapper;

        public LoginController(IUserSerivce userSerivce)
        {
            _userSerivce = userSerivce;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> Index(UserDto model)
        {
            var userLogin = await _userSerivce.GetUserAsync(model.Name,model.Password);

            if (userLogin.Data != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Name)
                    //new Claim(ClaimTypes.Role, "Admin")
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    // Oturum ayarları
                };

                 await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return Redirect("/Admin");
            }

            ModelState.AddModelError(string.Empty, "Kullanıcı Adı veya Şifre yanlış!");
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Admin/Login");
        }
    }


}
