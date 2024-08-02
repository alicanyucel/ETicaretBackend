

using ETicaret.Domain.Entities.Common;

namespace ETicaret.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
        
    }
}
