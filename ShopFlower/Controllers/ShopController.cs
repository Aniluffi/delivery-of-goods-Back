﻿using Microsoft.AspNetCore.Mvc;

namespace ShopFlower.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
