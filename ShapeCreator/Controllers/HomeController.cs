using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShapeCreator.Controllers
{
    public class HomeController : Controller
    {
        private HomeService homeService;

        public HomeController()
        {
            homeService = new HomeService();
        }
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult Generate(string input)
        {

            var model = homeService.GetShape(input);
            if(model == null) //this is unexpected behaviour..show fatal error
            {
                return Json(new { Error = "An unexpted error occured in the system." }, JsonRequestBehavior.AllowGet);
            }

            if (string.IsNullOrEmpty(model.ErrorMessage))
                return PartialView(model.ShapeTypeEnum.ToString(), model);
            else
                return Json(new { Error = model.ErrorMessage }, JsonRequestBehavior.AllowGet);
        }
    }
}