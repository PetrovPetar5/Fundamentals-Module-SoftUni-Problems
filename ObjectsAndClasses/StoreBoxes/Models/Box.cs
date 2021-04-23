namespace StoreBoxes.Models
{
    using System.Text;
    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal Price => this.ItemQuantity * this.Item.Price;

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{ this.SerialNumber}");
            sb.AppendLine($"-- { this.Item.Name} – ${ this.Item.Price:F2}: { this.ItemQuantity}");
            sb.AppendLine($"-- ${ (Price):F2}");

            return sb.ToString().TrimEnd();
        }
    }
}

