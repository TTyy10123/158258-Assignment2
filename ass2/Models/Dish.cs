using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ass2.Models
{
    public class Dish
    {
        [Key]

        public int ID { get; set; }
        public string Taste { get; set; }
        public decimal Price {  get; set; }
        public string Name { get; set; }
        public decimal Score { get; set; }
        public virtual Cuisine Cuisine { get; set; }
    }
}