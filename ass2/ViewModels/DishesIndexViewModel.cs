using ass2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace ass2.ViewModels
{
    public class DishesIndexViewModel
    {
        /*public IQueryable<Dish> Dishes { get; set; }*/
        public IPagedList<Dish> Dishes { get; set; }


        public string Search { get; set; }
        public IEnumerable<CuisineWithCount> CuisineWithCount { get; set; }
        public string Cuisine { get; set; }
        public IEnumerable<SelectListItem> CuisineFilterItems
        {
            get
            {
                var allCuisines = CuisineWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CuisineName,
                    Text = cc.CuisineNameWithCount
                });
                return allCuisines;
            }
        }
    }
    public class CuisineWithCount
    {
        public int DishCount { get; set; }
        public string CuisineName { get; set; }
        public string CuisineNameWithCount
        {
            get
            {
                return CuisineName + " (" + DishCount.ToString() + ")";
            }
        }
    }
}