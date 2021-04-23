namespace VehicleCatalogueLab
{
    using System;
    using System.Linq;
    using System.Text;
    using VehicleCatalogueLab.Models;

    class Program
    {
        static void Main(string[] args)
        {
            var endCommand = "end";
            var curCommand = String.Empty;
            var catalog = new Catalog();
            while ((curCommand = Console.ReadLine()) != endCommand)
            {
                var vehicleArgs = curCommand.Split('/', StringSplitOptions.RemoveEmptyEntries);
                var type = vehicleArgs[0];
                var brand = vehicleArgs[1];
                var model = vehicleArgs[2];
                var hpOrWeight = int.Parse(vehicleArgs[3]);

                if (type.ToLower() == "car")
                {
                    var curCar = new Car(model, brand, hpOrWeight);
                    catalog.AddCar(curCar);
                }
                else if (type.ToLower() == "truck")
                {
                    var curTruck = new Truck(model, brand, hpOrWeight);
                    catalog.AddTruck(curTruck);
                }
            }

            var cars = catalog.Cars.OrderBy(x => x.Brand);
            var trucks = catalog.Trucks.OrderBy(x => x.Brand);

            if (cars.Any())
            {
                PrintsCars(cars);
            }

            if (trucks.Any())
            {
                PrintsTrucks(trucks);
            }
        }

        private static void PrintsTrucks(IOrderedEnumerable<Truck> trucks)
        {
            Console.WriteLine("Trucks:");
            foreach (var truck in trucks)
            {
                Console.WriteLine(truck);
            }
        }

        private static void PrintsCars(IOrderedEnumerable<Car> cars)
        {
            Console.WriteLine("Cars:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
