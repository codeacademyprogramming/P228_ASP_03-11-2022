using Microsoft.AspNetCore.Mvc;
using P228Mentor.DAL;
using P228Mentor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Active = 4;

            List<Event> events = _context.Events.ToList();

            return View(events);
        }
    }
}
