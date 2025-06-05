using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavedenie
{
    public class DishContext:DbContext
    {
        public DishContext():base("DishContext")
        {
            
        }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DishType> DishesType { get; set; }
    }
}
