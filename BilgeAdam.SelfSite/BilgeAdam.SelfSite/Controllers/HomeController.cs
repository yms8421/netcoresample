﻿using Microsoft.AspNetCore.Mvc;

namespace BilgeAdam.SelfSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}