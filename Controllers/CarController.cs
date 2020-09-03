using car_dealership.Services;
using car_dealership.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace car_dealership.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : Controller
    {
        CarService _carService;

        public CarController(CarService carService)
        {
            this._carService = carService;
        }

        [HttpGet]
        public List<Car> getAll(){
            return _carService.getListCars();
        }
    }
}