using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 2;
            return View();
        }
    }
}
