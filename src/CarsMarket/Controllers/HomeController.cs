using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsMarket.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsMarket.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            Car car = new Car ("Ford","Focus","Diesel","Sedan",15000);

            return View(car);
        }
    }
}
