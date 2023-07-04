using AspIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro.Controllers
{
    public class ProductController : Controller
    {
        private List<Product> _products;
        public ProductController()
        {
            _products = new()
            {
                new(){Id=1,Name="Telefon"},
                new(){Id=2,Name="Qabyuyan"},
                new(){Id=3,Name="Paltaryuyan"},
            };
        }
        public IActionResult Index()
        {
            ViewBag.Products= _products;
            return View();
        }
        public IActionResult Detail(int id)
        {
            var item=_products.Find(x => x.Id == id);
            ViewBag.Data= item;
            return View();
        }
    }
}
