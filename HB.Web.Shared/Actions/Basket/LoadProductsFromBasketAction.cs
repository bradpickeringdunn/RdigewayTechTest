using Backbone.ErrorHandling;
using Backbone.Logging;
using Backbone.Utilities;
using HB.Services.Models.Products.Dto;
using HB.Services.Models.Products.Requests;
using HB.Web.Shared.ProductService;
using HB.Web.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HB.Web.Shared.Actions.Basket
{
    public class LoadProductsFromBasketAction<T> : BaseAction<T> where T :class
    {
        private readonly IProductServiceContract productService;
        public LoadProductsFromBasketAction(ILogger logger, IProductServiceContract productService)
            :base(logger)
        {
            Guardian.ArgumentNotNull(productService, "productService");
            this.productService = productService;
        }

        public Func<BaseViewModel<IList<ProductDto>>,T> OnSuccess { get; set; }

        public Func<NotificationCollection, T> OnFailed { get; set; }


        public T Execute(HttpSessionStateBase session)
        {
            Guardian.ArgumentNotNull(session, "session");
            var notifications = new NotificationCollection();

            string basketSessionKey = "basket";
            var products = new BaseViewModel<IList<ProductDto>>();

            try
            {
                var basket = session[basketSessionKey] as List<int>;
                
                if (basket.IsNull())
                {
                    notifications.Add("There are no products in your basket.");
                }

                var productResult = productService.LoadProductsBy(new LoadProductsRequest(new ProductFilterDto()
                {
                    ProductIds = basket
                }));

                if (productResult.IsNull() || !productResult.Products.Any())
                {
                    notifications.Add("There are no products in your shopping basket.");
                }

                if (!notifications.HasErrors)
                {
                    products.Payload = productResult.Products;
                }

                products.Notifications = notifications;

            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
                notifications.Add("There was a problem adding the product to your shopping basket.");
            }

            return OnSuccess(products);
        }
    }
}
