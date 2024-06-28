using Microsoft.AspNetCore.Mvc;
using ScarpeDue.Data;


namespace ScarpeDue.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductR.GetAllProducts();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = ProductR.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
