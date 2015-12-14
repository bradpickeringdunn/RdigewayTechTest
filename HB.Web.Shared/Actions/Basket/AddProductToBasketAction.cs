using Backbone.Logging;
using Backbone.Utilities;
using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HB.Web.Shared.ViewModels;
using System.Web;
using Backbone.ErrorHandling;

namespace HB.Web.Shared.Actions.Basket
{
    public class AddProductToBasketAction<T> : BaseAction<T> where T : class
    {
        private readonly IProductServiceContract productService;

        public Func<T>OnSuccess{get;set;}

        public Func<NotificationCollection, T> OnFailed { get; set; }

        public AddProductToBasketAction(ILogger logger, IProductServiceContract productService)
            : base(logger)
        {
            Guardian.ArgumentNotNull(productService, "productService");
            this.productService = productService;
        }

        public T Execute(int productId,  HttpSessionStateBase session)
        {
            Guardian.ArgumentNotNull(session, "session");
                var notifications = new NotificationCollection();

            string basketSessionKey = "basket";

            try {

                var basket = session[basketSessionKey] as List<int>;

                if (basket.IsNull())
                {
                    basket = new List<int>();
                }

                basket.Add(productId);

                session[basketSessionKey] = basket;
            }
            catch(Exception ex)
            {
                Logger.Exception(ex);
                notifications.Add("There was a problem adding the product to your shopping basket.");
            }

            return notifications.HasErrors ? OnFailed(notifications) : OnSuccess();
        }
    }
}
