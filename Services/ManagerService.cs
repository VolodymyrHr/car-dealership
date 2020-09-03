using System.Collections.Generic;
using System.Linq;
using car_dealership.Data;
using car_dealership.Models;

namespace car_dealership.Services{
    public class ManagerService
    {
        SalesContext _context;

        public ManagerService(SalesContext context){
            this._context = context;
        }

        public List<Manager> getListManagers(){
            return _context.Manager.ToList();
        }
    }
}