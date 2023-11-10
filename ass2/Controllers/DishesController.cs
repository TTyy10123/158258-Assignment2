using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using ass2.Data;
using ass2.Models;
using ass2.ViewModels;
using PagedList;
namespace ass2.Controllers
{
    public class DishesController : Controller
    {
        private ass2Context db = new ass2Context();

        // GET: Dishes
        public ActionResult Index(string cuisine, string search, int? page)
        {
            //instantiate a new view model
            DishesIndexViewModel viewModel = new DishesIndexViewModel();
            var dishes = db.Dishes.Include(p => p.Cuisine);
            //find the dishes where either the product name field contains search,the product 
            //description contains search, or the product's category name contains search
            if (!String.IsNullOrEmpty(search))
            {
                dishes = dishes.Where(p => p.Name.Contains(search) ||
                p.Taste.Contains(search) ||
                p.Name.Contains(search)||
                p.Score.ToString().Contains(search)||
                p.Price.ToString().Contains(search)||
                p.Cuisine.Cuisines.Contains(search));
                // ViewBag.Search = search;
                viewModel.Search = search;
            }
            //group search results into categories and count how many items in each category
            viewModel.CuisineWithCount = from matchingDishes in dishes
                                      where
                                      matchingDishes.Cuisine != null
                                      group matchingDishes by
                                      matchingDishes.Cuisine.Cuisines into
                                      CuisineGroup
                                      select new CuisineWithCount()
                                      {
                                          CuisineName = CuisineGroup.Key,
                                          DishCount = CuisineGroup.Count()
                                      };
//var categories = dishes.OrderBy(p => p.Category.Name).Select(p => p.Category.Name).Distinct();
            if (!String.IsNullOrEmpty(cuisine))
            {
                dishes = dishes.Where(p => p.Cuisine.Cuisines == cuisine);
                viewModel.Cuisine = cuisine;
            }
            dishes = dishes.OrderBy(p => p.Name);
            const int PageItems = 4;
            int currentPage = (page ?? 1);
            viewModel.Dishes = dishes.ToPagedList(currentPage, PageItems);

            //ViewBag.Category = new SelectList(categories);   
            /*viewModel.Dishes = dishes;*/
            // return View(dishes.ToList());
            return View(viewModel);
        }
    }
}
