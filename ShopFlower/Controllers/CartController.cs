using Microsoft.AspNetCore.Mvc;

namespace ShopFlower.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
