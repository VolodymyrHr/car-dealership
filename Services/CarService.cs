using System.Collections.Generic;
using System.Linq;
using car_dealership.Data;
using car_dealership.Models;

namespace car_dealership.Services{
    public class CarService
    {
        SalesContext _context;

        public CarService(SalesContext context){
            this._context = context;
        }

        public List<Car> getListCars(){
            return _context.Car.ToList();
        }
    }
}