using Microsoft.AspNetCore.Mvc;
using P228HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228HomeWork.Controllers
{
    public class MarkaController : Controller
    {
        public IActionResult Index()
        {
            List<Marka> markas = new List<Marka>
            {
                new Marka{Id = 1, Name = "BMW"},
                new Marka{Id = 2, Name = "Mercedes"},
                new Marka{Id = 3, Name = "Audi"},
                new Marka{Id = 4, Name = "Ferrari"},
            };

            return View(markas);
        }
    }
}
