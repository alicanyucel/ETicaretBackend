using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Order:BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        // n to n
        public ICollection<Product> Products { get; set; }
        // 1 to n
        public Customer Customer { get; set; }
    }
}
