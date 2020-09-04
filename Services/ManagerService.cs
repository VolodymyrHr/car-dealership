using System;
using System.Collections.Generic;
using System.Linq;
using car_dealership.ClientObjects;
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

        internal ManagerInTime GetBestManagerInTime(ManagerInTime managerInTime)
        {
            List<int> managersId = new List<int>();
            Dictionary<int, int> salesQuantity = new Dictionary<int, int>();

            foreach (Manager item in _context.Manager.ToList())
            {
                managersId.Add(item.ID);
            }

            foreach (int id in managersId)
            {
                salesQuantity.Add(id, _context.Deal.ToList().FindAll(e => e.ManagerID == id && managerInTime.Beginning <= e.Time && e.Time <= managerInTime.TheEnd).Count());
            }

            managerInTime.ManagerId = salesQuantity.First(item => item.Value == salesQuantity.Values.Max()).Key;

            int bestQuantity;
            salesQuantity.TryGetValue(managerInTime.ManagerId, out bestQuantity);

            managerInTime.salesQuantity = bestQuantity;

            return managerInTime;
        }
    }
}