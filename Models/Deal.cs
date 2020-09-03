using System;
using System.Collections.Generic;

namespace car_dealership.Models
{
    public class Deal
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public int CarID { get; set; }
        public int ManagerID { get; set; }
        public int CustomerID { get; set; }
    }
}