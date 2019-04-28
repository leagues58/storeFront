using Microsoft.AspNetCore.Mvc;
using StoreFront.Models;
using StoreFront.ViewModels;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StoreFront.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel()
            {
                Title = "Product Overview",
                Products = productRepository.GetAllProducts().OrderBy(p => p.Name).ToList()
            };

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var product = this.productRepository.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
