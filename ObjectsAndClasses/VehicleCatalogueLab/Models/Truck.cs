namespace VehicleCatalogueLab.Models
{
    public class Truck : Vehicle
    {
        public Truck(string model, string brand, int weight) : base(model, brand)
        {
            this.Weight = weight;
        }

        public int Weight { get; set; }

        public override string ToString()
        {
            var result = base.ToString() + $"{this.Weight}kg";
            return result;
        }
    }
}
