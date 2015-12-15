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
        private static IDictionary<int, ActionResult> ProductActions;

        public ProductsController(ILogger logger, IProductServiceContract productService)
        :base(logger, productService)
        {
            InitializeProductActions();
        }

        

        public ActionResult Index()
        {
            return new HB.Web.Shared.Actions.Products.LoadProductCategoriesAction<dynamic>(Logger, ProductService)
            {
                OnSuccess = (m) => View(ViewPath.Products.ProductCategories, m)
            }.Execute();
        }

        public ActionResult LoadProductByCategoryId(int categoryId)
        {
            return RedirectToProduct(categoryId);
        }

        public ActionResult LoadBooks()
        {
            return new Shared.Actions.Products.LoadBooksAction<ActionResult>(Logger, ProductService)
            {
                OnSuccess = (m) => View(ViewPath.Products.Books, m)
            }.Execute();
        }

        public ActionResult LoadMovies()
        {
            return new Shared.Actions.Products.LoadMoviesAction<ActionResult>(Logger, ProductService)
            {
                OnSuccess = (m) => View(ViewPath.Products.Movies, m)
            }.Execute();
        }

        private ActionResult RedirectToProduct(int categoryId)
        {
            if (ProductActions.ContainsKey(categoryId))
            {
                return ProductActions[categoryId];
            }

            return View();
        }

        private void InitializeProductActions()
        {
            if (ProductActions.IsNull())
            {
                var productActions = new Dictionary<int, ActionResult>();
                productActions.Add(1, RedirectToAction("LoadBooks"));
                productActions.Add(2, RedirectToAction("LoadMovies"));

                ProductActions = productActions;
            }
        }
    }
}