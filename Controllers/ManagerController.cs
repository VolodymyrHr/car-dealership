using car_dealership.Services;
using car_dealership.Models;
using car_dealership.ClientObjects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace car_dealership.Controllers
{
    [ApiController]
    [Route("api/managers")]
    public class ManagerController : Controller
    {
        ManagerService _managerService;

        public ManagerController(ManagerService managerService)
        {
            this._managerService = managerService;
        }

        [HttpGet]
        public List<Manager> GetManagers(){
            return _managerService.getListManagers();
        }

        [HttpGet("best")]
        public ManagerInTime GetBestManager([FromBody] ManagerInTime managerInTime){

            return _managerService.GetBestManagerInTime(managerInTime);
        }
    }
}