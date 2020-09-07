using System;
using car_dealership.Models;

namespace car_dealership.ClientObjects
{
    public class ManagerInTime
    {
        public DateTime Beginning {get; set;}
        public DateTime TheEnd {get; set;}
        public int ManagerId  {get; set;}
        public int salesQuantity  {get; set;}
    }
}