using Clean_Restaurants.Domain.Entities.Common;

namespace Clean_Restaurants.Domain.Entities
{
    public class Dish: BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Guid RestaurantId { get; set; }
    }
}
