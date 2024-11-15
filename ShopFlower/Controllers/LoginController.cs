using Microsoft.AspNetCore.Mvc;
using ShopFlower.Domain.ViewModels.LoginAndRegistration;

namespace ShopFlower.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginViewModel model)
        {
            if(ModelState.IsValid)
                return Ok(model);
            var errors = ModelState.Values.SelectMany(x => x.Errors)
                .Select(e => e.ErrorMessage)
                .ToList();
            return BadRequest(errors);
        }
    }
}
