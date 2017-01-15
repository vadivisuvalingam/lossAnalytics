using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lossAnalytics.Service;

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
            var db = new DBService();
            db.openConnection();
            db.runQuery($"insert into 'MealType' ('MealTypeName', 'Order') values ('{mealType.Name}', {mealType.Order})");
            return View();
        }
    }
}