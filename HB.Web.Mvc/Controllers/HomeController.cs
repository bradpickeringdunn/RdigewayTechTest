using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HB.Web.Mvc.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var productService = new Web.Shared.ProductService.ProductServiceContractClient();
            var logger = new Backbone.Logging.DebugLogger();

            var a = new HB.Web.Shared.Actions.Products.LoadProductCategoriesAction<dynamic>(logger, productService)
            {
                OnSuccess = (m) => { return m; }
            }.Execute();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}