using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lossAnalytics.Models
{
    public class Meal
    {
        public string MealName { get; set; }
        public DateTime MealTime { get; set; }
        public int MealCalories { get; set; }
        public List<string> FoodTypes { get; set; }
        public string dynamicHtml { get; set; }
    }
}