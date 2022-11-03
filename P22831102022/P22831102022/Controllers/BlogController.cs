using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P22831102022.Models;

namespace P22831102022.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            Blog blog = new Blog
            {
                Name = "Layout-Model",
                Title = "Model Nece Calisir",
                Content = "Videoya Bax"
            };

            return View(blog);
        }
    }
}
