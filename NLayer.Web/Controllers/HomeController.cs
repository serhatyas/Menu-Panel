using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Services;
using System.Diagnostics;

namespace NLayer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public HomeController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index(string culture)
        {
            var categories = await _categoryService.GetAllAsync();
            var categoriesDtos = _mapper.Map<List<CategoryDto>>(categories.ToList());

            if (culture == "en")
            {
                foreach (var category in categoriesDtos)
                {
                    category.Name = category.NameEN;
                }
            }

            ViewBag.Culture = culture;
            return View(categoriesDtos);
        }

        public async Task<IActionResult> Detail(int id, string culture)
        {
            var productWCategory = await _categoryService.GetSingleCategoryByIdWithProductAsync(id);
            var product = productWCategory.Data.Products.ToList();

            if (culture=="en")
            {
                foreach (var item in product)
                {
                    item.Name = item.NameEN;
                }

                ViewData["CategoryName"] = productWCategory.Data.NameEN;
                return View(product);
            }
            
            ViewData["CategoryName"] = productWCategory.Data.Name;
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
