using Backbone.Logging;
using HB.Web.Mvc.Views;
using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HB.Web.Mvc.Controllers
{
    
    public class ProductsController : BaseController
    {
        public ProductsController(ILogger logger, IProductServiceContract productService)
        :base(logger, productService){ }

        public ActionResult Index()
        {
            return new HB.Web.Shared.Actions.Products.LoadProductCategoriesAction<dynamic>(Logger, ProductService)
            {
                OnSuccess = (m) => View(ViewPath.Products.ProductCategories, m)
            }.Execute();
        }

        public ActionResult LoadProducts(int categoryId)
        {
            return new Shared.Actions.Products.LoadProductsByCategoryAction<ActionResult>(Logger, ProductService)
            {
                OnSuccess = (m) => View(ViewPath.Products.DisplayProducts, m)
            }.Execute(categoryId);
        }

        
    }
}