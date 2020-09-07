using System;
using System.Collections.Generic;
using System.Linq;
using car_dealership.Data;
using car_dealership.Models;

namespace car_dealership.Services{
    public class DealService
    {
        SalesContext _context;

        public DealService(SalesContext context){
            this._context = context;
        }

        public List<Deal> getListDeals(){




            return _context.Deal.ToList();
        }

        public Deal addDeal(Deal deal)
        {
            deal.Time = DateTime.Now;
            _context.Deal.Add(deal);
            _context.SaveChanges();
            return deal;
        }
    }
}