using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lossAnalytics.Controllers
{
    public class MealController : Controller
    {
        // GET: Meal
        [HttpGet]
        public ActionResult MealView()
        {
            var foodTypes = new List<string> { "Dessert", "Lunch", "Breakfast", "Dinner", "Snack", "Midnight Snack"};
            var meal = new Models.Meal()
            {
                MealName = "Breakfast",
                MealTime = new DateTime(2016, 12, 14, 9, 10, 22),
                MealCalories = 300,
                FoodTypes = foodTypes,
                dynamicHtml = "<h1>HELLO DYNAMIC HTML HERE</h1>",
            }  ;
            return View(meal);
        }

        [HttpPost]
        public ActionResult MealView(string Meal, string Meal2)
        {
            var foodTypes = new List<string> { "Dessert", "Lunch", "Breakfast", "Dinner", "Snack", "Midnight Snack" };
            var meal = new Models.Meal()
            {
                MealName = "Breakfast",
                MealTime = new DateTime(2016, 12, 14, 9, 10, 22),
                MealCalories = 300,
                FoodTypes = foodTypes,
                dynamicHtml = Meal + " add " + Meal2,
            };
            return View(meal);
        }
    }
}