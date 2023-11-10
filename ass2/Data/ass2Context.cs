using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ass2.Data
{
    public class ass2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ass2Context() : base("name=ass2Context")
        {
        }

        public System.Data.Entity.DbSet<ass2.Models.Dish> Dishes { get; set; }

        public System.Data.Entity.DbSet<ass2.Models.Cuisine> Cuisines { get; set; }
    }
}
