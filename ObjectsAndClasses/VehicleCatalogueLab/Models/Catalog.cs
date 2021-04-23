namespace VehicleCatalogueLab.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class Catalog
    {
        private ICollection<Car> cars;
        private ICollection<Truck> trucks;

        public Catalog()
        {
            this.cars = new List<Car>();
            this.trucks = new List<Truck>();
        }

        public IReadOnlyCollection<Car> Cars => (IReadOnlyCollection<Car>)this.cars;
        public IReadOnlyCollection<Truck> Trucks => (IReadOnlyCollection<Truck>)this.trucks;

        public void AddCar(Car car)
        {
            this.cars.Add(car);
        }
        public void AddTruck(Truck truck)
        {
            this.trucks.Add(truck);
        }
    }
}
