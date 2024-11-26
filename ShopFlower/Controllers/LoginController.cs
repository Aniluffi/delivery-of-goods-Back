using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using ShopFlower.Data.Models;
using ShopFlower.IService.ServiceUser;
using ShopFlower.Models;
using System.Security.Claims;

namespace ShopFlower.Controllers
{
    public class LoginController : Controller
    {
        private IServiceUser _serviceUser;

        public LoginController(IServiceUser serviceUser)
        {
            _serviceUser = serviceUser;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Login([FromBody] LoginViewModel model)
        //{
        //    if(ModelState.IsValid)
        //        return Ok(model);
        //    var errors = ModelState.Values.SelectMany(x => x.Errors)
        //        .Select(e => e.ErrorMessage)
        //        .ToList();
        //    return BadRequest(errors);
        //}

        [HttpPost]
        public async Task<IActionResult> Registr(LoginRegistrView models)
        {

            var model = models.registr;
            var result = await _serviceUser.AddUser(new User { Email = model.Email, Login = model.Login, Password = model.Password });

            if (model != null && result != null)
            {

                return View("Index", new LoginRegistrView
                {
                    registr = new Registr
                    {
                        error = result as List<Exception>
                    }
                });
            }

            return View(models);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRegistrView models)
        {
            User user = new User();
            try
            {
                //if (ModelState.IsValid)
                //{

                //    return View("Index", new LoginRegistrView
                //    {
                //        login = models.login
                //    });
                //}

                var loginDate = models.login;

                user = await _serviceUser.GetUser(loginDate.Email, loginDate.Password);

                if (string.IsNullOrEmpty(user.Email) && string.IsNullOrEmpty(user.Password))
                {

                    return View("Index", new LoginRegistrView
                    {
                        login = models.login
                    });
                }
            } 
            catch (Exception ex)
            {
                return View("Index", new LoginRegistrView
                {
                    login = new Login
                    {

                        error = new List<Exception> { ex }
                    }
                });
            }

            await AutheticateAsync(user);
            // Перенаправляем на главную страницу
            return RedirectToAction("Index", "Home");
        }

        public async Task AutheticateAsync(User user)
        {
            var claims = new List<Claim>
            {
                new Claim("UserId",user.Id.ToString()),
                new Claim("UserEmail",user.Email),
                new Claim("UserLogin",user.Login),
            };

            var id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultRoleClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View("Index");
        }
    }
}
