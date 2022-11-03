using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 6;
            return View();
        }
    }
}
