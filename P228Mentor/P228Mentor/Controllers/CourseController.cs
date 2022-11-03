using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Active = 3;
            return View();
        }
    }
}
