using Backbone.Logging;
using HB.Web.Mvc.Views;
using HB.Web.Shared.Actions.Basket;
using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HB.Web.Mvc.Controllers
{
    public class ShoppingBasketController : BaseController
    {
        public ShoppingBasketController(ILogger logger, IProductServiceContract productService)
            :base(logger,productService)
        {                
        }

        // GET: ShoppingBasket
        public ActionResult LoadShoppingBasket()
        {
            return new LoadProductsFromBasketAction<ActionResult>(Logger, ProductService)
            {
                OnSuccess = (m) => View(ViewPath.ShoppingBasket.ViewMyBasket, m)
            }.Execute(Session);
        }

        public ActionResult AddToProductBasket(int productId)
        {
            return new Shared.Actions.Basket.AddProductToBasketAction<ActionResult>(Logger, ProductService)
            {
                OnSuccess = () => RedirectToAction("LoadShoppingBasket")
            }.Execute(productId, Session);
        }

        public ActionResult RemoveProductFromBasket(int productId)
        {
            return View();
        }
    }
}