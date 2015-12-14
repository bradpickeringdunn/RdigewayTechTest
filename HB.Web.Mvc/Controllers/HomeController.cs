using Backbone.Logging;
using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HB.Web.Mvc.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ILogger logger, IProductServiceContract productService)
            :base(logger, productService)
        {

        }
        public ActionResult Index()
        {
            return new HB.Web.Shared.Actions.Products.LoadProductCategoriesAction<dynamic>(Logger, ProductService)
            {
                OnSuccess = (m) =>  View(m) 
            }.Execute();
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