﻿using Clean_Restaurants.Domain.Entities.Common;

namespace Clean_Restaurants.Domain.Entities
{
    public class Restaurant: BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool HasDelivery { get; set; }

        public string? Email { get; set; }
        public string? ContactNumber { get; set; }

        public Address? Address { get; set; }
        public List<Dish>? Dishes { get; set; } = new();
    }
}
