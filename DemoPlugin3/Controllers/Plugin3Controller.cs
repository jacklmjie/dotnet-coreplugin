﻿using DemoPluginModel;
using Microsoft.AspNetCore.Mvc;


namespace DemoPlugin1.Controllers
{
    [Area("DemoPlugin3")]
    public class Plugin3Controller : Controller
    {
        public IActionResult HelloWorld()
        {
            var content = new Demo().SayHello();
            ViewBag.Content = content;
            return View();
        }
    }
}
