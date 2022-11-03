using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228HomeWork.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ModelId { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public double Engine { get; set; }
        public string FuelType { get; set; }
    }
}
