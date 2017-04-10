using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace CarsMarket.Models
{
    public class MotorBike:Vehicle
    {
        private int CubicCapacity;
        private string Type;

        public MotorBike(string brand, string model, int capacity, string type,decimal price)
        {
            this.Id = Guid.NewGuid();
            this.Brand = brand;
            this.Model = model;
            this.CubicCapacity = capacity;
            this.Type = type;
            this.Price = price;
        }
    }
}
