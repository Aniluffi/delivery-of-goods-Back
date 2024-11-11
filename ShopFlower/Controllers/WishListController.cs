using Microsoft.AspNetCore.Mvc;

namespace ShopFlower.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
