namespace VehicleCatalogueLab.Models
{
    public class Car : Vehicle
    {
        public Car(string model, string brand, int horsePower) : base(model, brand)
        {
            this.HorsePower = horsePower;
        }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            var result = base.ToString() + $"{this.HorsePower}hp";
            return result;
        }
    }
}
