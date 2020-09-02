using System;
using System.Collections.Generic;

namespace car_dealership.Models
{
    public class Manager
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<SalesContract> SalesContract { get; set; }
    }
}