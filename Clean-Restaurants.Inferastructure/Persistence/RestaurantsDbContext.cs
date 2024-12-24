using Clean_Restaurants.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Restaurants.Inferastructure.Persistence
{
    public class RestaurantsDbContext: DbContext
    {
        public RestaurantsDbContext(DbContextOptions<RestaurantsDbContext> dbContextOptions): base(dbContextOptions) { }
        
        internal DbSet<Restaurant> Restaurants {  get; set; }
        internal DbSet<Dish> Dishes { get; set; }

    }
}
