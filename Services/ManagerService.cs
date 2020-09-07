using System;
using System.Collections.Generic;
using System.Linq;
using car_dealership.ClientObjects;
using car_dealership.Data;
using car_dealership.Models;

namespace car_dealership.Services
{
    public class ManagerService
    {
        SalesContext _context;

        public ManagerService(SalesContext context)
        {
            this._context = context;
        }

        public List<Manager> getListManagers()
        {
            return _context.Manager.ToList();
        }

        internal ManagerInTime GetBestManagerInTime(ManagerInTime managerInTime)//reportQuery or Params dealsReportParams
        {

            // SELECT MAX(counted) FROM
            // (
            //     SELECT COUNT(*) AS counted
            //     FROM Deals
            //     WHERE Beginning < Time AND Time <= TheEnd 
            //     GROUP BY ManagerID
            // ) AS counts;

            Dictionary<int, int> salesQuantity = new Dictionary<int, int>();

            _context.Deal.Where(e => managerInTime.Beginning < e.Time && e.Time <= managerInTime.TheEnd).ToList().ForEach(item => {
                if(!salesQuantity.TryAdd(item.ManagerID, 1)){
                    salesQuantity[item.ManagerID] += 1;
                }
            });

            managerInTime.ManagerId = salesQuantity.First(item => item.Value == salesQuantity.Values.Max()).Key;

            int bestQuantity;
            salesQuantity.TryGetValue(managerInTime.ManagerId, out bestQuantity);

            managerInTime.salesQuantity = bestQuantity;

            return managerInTime;
        }

        internal List<FavoriteBrand> GetFavoriteBrandForManager()
        {

            return new List<FavoriteBrand>();
        }
    }
}