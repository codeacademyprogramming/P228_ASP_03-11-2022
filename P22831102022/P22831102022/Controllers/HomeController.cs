using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P22831102022.Models;
using P22831102022.ViewModels.Home;

namespace P22831102022.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Group> _grops;
        public HomeController()
        {
            _grops = new List<Group>
            {
                new Group
                {
                    Id = 1,
                    Limit = 16, 
                    Name = "P228",
                    Students = new List<Student>
                    {
                        new Student
                        {
                            Name = "Adil",
                            SurName = "Suleymanov",
                            Age = 22
                        },
                        new Student
                        {
                            Name = "Faiq",
                            SurName = "Aliyev",
                            Age = 27
                        },
                        new Student
                        {
                            Name = "Rufet",
                            SurName = "Quluzade",
                            Age = 27
                        },
                        new Student
                        {
                            Name = "Raqif",
                            SurName = "Mursalov",
                            Age = 20
                        },
                        new Student
                        {
                            Name = "Nurlan",
                            SurName = "Rahimli",
                            Age = 15
                        },
                        new Student
                        {
                            Name = "Namiq",
                            SurName = "Memmedov",
                            Age = 20
                        },
                        new Student
                        {
                            Name = "Xeyrulla",
                            SurName = "Xelil",
                            Age = 26
                        }
                    }
                },
                new Group{Id = 2,Limit = 14, Name = "P115"},
                new Group{Id = 3,Limit = 18, Name = "P229"},
            };
        }

        public IActionResult Index()
        {
            Student student = new Student
            {
                Name = "Hamid",
                SurName = "Mammadov",
                Age = 32
            };

            Blog blog = new Blog
            {
                Name = "Layout-Model",
                Title = "Model Nece Calisir",
                Content = "Videoya Bax"
            };

            HomeVM homeVM = new HomeVM
            {
                Student = student,
                Blog = blog,
                Groups = _grops
            };
            //ViewBag.Student = student;

            return View(homeVM);
        }

        public IActionResult Detail(int? id)
        {
            //Group group = null;

            //foreach (Group item in _grops)
            //{
            //    if (item.Id == id)
            //    {
            //        group = item;
            //    }
            //}

            Group group = _grops.Find(g => g.Id == id);

            return View(group);
        }
    }
}
