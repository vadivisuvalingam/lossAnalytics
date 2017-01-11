using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lossAnalytics.Controllers
{
    public class MealTypeController : Controller
    {
        // GET: MealType
        [HttpGet]
        public ActionResult MealTypeView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MealTypeView(string Name, string Order)
        {
            var mealType = new Models.MealType() { Name = Name, Order = Order };
            return View();
        }
    }
}