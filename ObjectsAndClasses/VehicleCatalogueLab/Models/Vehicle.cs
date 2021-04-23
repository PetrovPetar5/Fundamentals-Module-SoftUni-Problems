namespace VehicleCatalogueLab.Models
{
    public abstract class Vehicle
    {
        public Vehicle(string model, string brand)
        {
            this.Model = model;
            this.Brand = brand;
        }

        public string Model { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            var result = $"{this.Brand}: {this.Model} - ";
            return result;
        }
    }
}
