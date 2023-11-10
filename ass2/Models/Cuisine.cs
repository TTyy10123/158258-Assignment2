using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ass2.Models
{
    public class Cuisine
    {
        [Key]
        public int Id { get; set; }
        public string Cuisines { get; set;}
        public string CuisinesId { get; set; }
        public virtual ICollection<Dish> Dishes {  get; set; }


    }
}