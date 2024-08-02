using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }
        // n to n
        public ICollection<Order> Orders { get; set;}
    }
}
