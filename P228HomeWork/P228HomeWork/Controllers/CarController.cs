using Microsoft.AspNetCore.Mvc;
using P228HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P228HomeWork.Controllers
{
    public class CarController : Controller
    {
        private readonly List<Car> _cars;
        public CarController()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, ModelId = 1, Name = "Car-Name-1",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 2, ModelId = 1, Name = "Car-Name-2",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 3, ModelId = 2, Name = "Car-Name-3",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 4, ModelId = 2, Name = "Car-Name-4",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 5, ModelId = 3, Name = "Car-Name-5",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 6, ModelId = 3, Name = "Car-Name-6",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 7, ModelId = 4, Name = "Car-Name-7",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 8, ModelId = 5, Name = "Car-Name-8",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 9, ModelId = 5, Name = "Car-Name-9",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 10, ModelId = 6, Name = "Car-Name-10",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 11, ModelId = 6, Name = "Car-Name-11",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 12, ModelId = 7, Name = "Car-Name-12",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 13, ModelId = 8, Name = "Car-Name-13",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
                new Car{Id = 14, ModelId = 9, Name = "Car-Name-14",Engine = 1.1,FuelType = "Fuel Type -1",Price = 55,Year = 1900},
            };
        }

        public IActionResult Index(int? id)
        {
            //List<Car> mayCars = null;

            //if (id == null)
            //{
            //    mayCars = _cars;
            //}
            //else
            //{
            //    mayCars = _cars.FindAll(c => c.ModelId == id);
            //}

            return View(id == null ? _cars : _cars.FindAll(c => c.ModelId == id));
        }

        public IActionResult Detail(int? id)
        {
            Car car = null;

            if (id != null)
            {
                car = _cars.Find(c => c.Id == id);
            }
            else
            {
                return Content("Id Null Ola Bilmez");
            }

            if (car == null)
            {
                return Content("Gonderilen Id Sehfdir");
            }

            return View(car);
        }
    }
}
