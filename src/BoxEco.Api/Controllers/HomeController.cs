﻿using Microsoft.AspNetCore.Mvc;

namespace BoxEco.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
