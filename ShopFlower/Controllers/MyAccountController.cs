using Microsoft.AspNetCore.Mvc;

namespace ShopFlower.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
