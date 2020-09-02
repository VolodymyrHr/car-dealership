using car_dealership.Models;
using System;
using System.Linq;

namespace car_dealership.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SalesContext context)
        {
            context.Database.EnsureCreated();

            if (context.Car.Any())
            {
                return;
            }

            var cars = new Car[]{
            new Car{Brand="Jaguar",Model="E-PACE",Cost=1302511},
            new Car{Brand="Jaguar",Model="F-PACE",Cost=144511},
            new Car{Brand="Jaguar",Model="I-PACE",Cost=2642511},
            new Car{Brand="Jaguar",Model="E-TYPE",Cost=3305611},
            new Car{Brand="Jaguar",Model="XE",Cost=2303551},
            new Car{Brand="Land Rover",Model="RANGE ROVER",Cost=3793551},
            new Car{Brand="Land Rover",Model="RANGE ROVER SPORT",Cost=2651551},
            new Car{Brand="Land Rover",Model="RANGE ROVER VELAR",Cost=1871551},
            new Car{Brand="Land Rover",Model="RANGE ROVER EVOQUE",Cost=1211551}
            };
            foreach (Car s in cars)
            {
                context.Car.Add(s);
            }
            context.SaveChanges();

            var managers = new Manager[]
            {
            new Manager{Name="Jon"},
            new Manager{Name="Tom"},
            new Manager{Name="Bob"},
            new Manager{Name="Jack"}
            };
            foreach (Manager c in managers)
            {
                context.Manager.Add(c);
            }
            context.SaveChanges();

            var customers = new Customer[]
            {
            new Customer{Name="Josian"},
            new Customer{Name="Clara"},
            new Customer{Name="Stella"},
            new Customer{Name="Lily"}
            };
            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }
            context.SaveChanges();
        }
    }
}