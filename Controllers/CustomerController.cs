using car_dealership.Services;
using car_dealership.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace car_dealership.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : Controller
    {
        CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            this._customerService = customerService;
        }

        [HttpGet]
        public List<Customer> GetCustomers(){
            return _customerService.getListCustomers();
        }
    }
}