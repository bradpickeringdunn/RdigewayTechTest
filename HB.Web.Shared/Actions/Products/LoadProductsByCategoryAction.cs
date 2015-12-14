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

namespace HB.Web.Shared.Actions.Products
{
    public class LoadProductsByCategoryAction<T> where T : class
    {
        private readonly IProductServiceContract productService;
        private readonly ILogger logger;

        public Func<BaseViewModel<IList<ProductDto>>, T> OnSuccess { get; set; }

        public LoadProductsByCategoryAction(ILogger logger, IProductServiceContract productService)
        {
            Guardian.ArgumentNotNull(logger, "logger");
            Guardian.ArgumentNotNull(productService, "productService");

            this.logger = logger;
            this.productService = productService;
        }

        public T Execute(int categoryId)
        {
            var productResult = productService.LoadProductsBy(new LoadProductsRequest(new ProductFilterDto()
            {
                CategoryId = categoryId
            }));

            if (productResult.IsNull())
            {
                logger.Error("");
                productResult.Notifications.Add(""); 
            }

            var model = new BaseViewModel<IList<ProductDto>>()
            {
                Notifications = productResult.Notifications,
                Payload = productResult.Products
            };

            return OnSuccess(model);

        }

    }
}
