using System;
using System.Collections.Generic;

namespace car_dealership.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public float Cost { get; set; }

        public ICollection<SalesContract> SalesContract { get; set; }
    }
}