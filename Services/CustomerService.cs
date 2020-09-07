using System.Collections.Generic;
using System.Linq;
using car_dealership.Data;
using car_dealership.Models;

namespace car_dealership.Services{
    public class CustomerService
    {
        SalesContext _context;

        public CustomerService(SalesContext context){
            this._context = context;
        }

        public List<Customer> getListCustomers(){
            return _context.Customer.ToList();
        }
    }
}