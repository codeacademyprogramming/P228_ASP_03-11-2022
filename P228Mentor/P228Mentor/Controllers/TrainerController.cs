using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P228Mentor.DAL;
using P228Mentor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.Controllers
{
    public class TrainerController : Controller
    {
        private readonly AppDbContext _context;

        public TrainerController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Active = 7;

            List<Trainer> trainers = _context.Trainers.Include(t=>t.Position).ToList();

            return View(trainers);
        }
    }
}
