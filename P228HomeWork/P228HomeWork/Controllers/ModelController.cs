using Microsoft.AspNetCore.Mvc;
using P228HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228HomeWork.Controllers
{
    public class ModelController : Controller
    {
        public IActionResult Index(int? id)
        {
            List<Model> models = new List<Model>
            {
                new Model{Id = 1, MarkaId = 1, Name="330"},
                new Model{Id = 2, MarkaId = 1, Name="428"},
                new Model{Id = 3, MarkaId = 1, Name="228"},
                new Model{Id = 4, MarkaId = 1, Name="324"},
                new Model{Id = 5, MarkaId = 2, Name="A140"},
                new Model{Id = 6, MarkaId = 2, Name="A150"},
                new Model{Id = 7, MarkaId = 2, Name="A160"},
                new Model{Id = 8, MarkaId = 3, Name="A4"},
                new Model{Id = 9, MarkaId = 3, Name="A5"},
                new Model{Id = 10, MarkaId = 3, Name="A6"},
                new Model{Id = 11, MarkaId = 3, Name="A7"}
            };

            List<Model> myModels = null;

            if (id == null)
            {
                myModels = models;
            }
            else
            {
                myModels = models.FindAll(m => m.MarkaId == id);
            }

            return View(myModels);
        }
    }
}
