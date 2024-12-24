using Clean_Restaurants.Domain.Entities.Common;

namespace Clean_Restaurants.Domain.Entities
{
    public class Address: BaseEntity<Guid>
    {
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? PostalCode { get; set; }
    }
}
