using car_dealership.Services;
using car_dealership.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace car_dealership.Controllers
{
    [ApiController]
    [Route("api/deals")]
    public class DealController : Controller
    {
        DealService _dealService;

        public DealController(DealService dealService)
        {
            this._dealService = dealService;
        }

        [HttpGet]
        public List<Deal> GetDeals(){
            return _dealService.getListDeals();
        }

        [HttpPost]
        public Deal PostDeal([FromBody] Deal deal){
            return _dealService.addDeal(deal);
        }
    }
}