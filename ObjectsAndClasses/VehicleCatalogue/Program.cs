namespace VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var trucks = new List<Truck>();
            var cars = new List<Car>();
            var curVehicleInput = String.Empty;
            var inputEndCommand = "End";
            while ((curVehicleInput = Console.ReadLine()) != inputEndCommand)
            {
                var curVehicleArgs = curVehicleInput.Split();
                var type = curVehicleArgs[0];
                var model = curVehicleArgs[1];
                var color = curVehicleArgs[2];
                var horsePower = int.Parse(curVehicleArgs[3]);

                if (type == "truck")
                {
                    var curTruck = new Truck(model, color, horsePower);
                    trucks.Add(curTruck);
                }
                else if (type == "car")
                {
                    var curCar = new Car(model, color, horsePower);
                    cars.Add(curCar);
                }
            }

            var modelEndComand = "Close the Catalogue";
            var modelCommand = String.Empty;
            while ((modelCommand = Console.ReadLine()) != modelEndComand)
            {
                if (trucks.Any(x => x.Model == modelCommand))
                {
                    var curTruck = trucks.First(x => x.Model == modelCommand);
                    Console.WriteLine(curTruck);
                }
                else
                {
                    var curCar = cars.First(x => x.Model == modelCommand);
                    Console.WriteLine(curCar);
                }
            }

            Console.WriteLine($"Cars have average horsepower of: {cars.Average(x => x.HorsePower):F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucks.Average(x => x.HorsePower):F2}.");
        }
    }
}
