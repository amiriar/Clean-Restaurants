using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Restaurants.Domain.Entities.Common
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
        public Guid? DeletedBy { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
