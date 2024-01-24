using ExampleAPI.Core;

namespace ExampleAPI.Entities
{
    public class Order:Entity<Guid>
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }

        public Order()
        {
            Stocks = new HashSet<Stock>();
        }
    }
}
