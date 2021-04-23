namespace VehicleCatalogue
{
    using System.Text;
    public abstract class Vehicle
    {
        public Vehicle(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Color { get; set; }

        public int HorsePower { get; set; }

        public string Model { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Horsepower: {this.HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}
