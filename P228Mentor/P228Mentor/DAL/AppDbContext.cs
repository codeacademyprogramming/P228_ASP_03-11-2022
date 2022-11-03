using Microsoft.EntityFrameworkCore;
using P228Mentor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228Mentor.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<PricingServices> PricingServices { get; set; }
    }
}
