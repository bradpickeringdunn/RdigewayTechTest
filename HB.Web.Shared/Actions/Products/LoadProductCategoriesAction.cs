using Backbone.Logging;
using Backbone.Utilities;
using HB.Services.Models.Products.Dto;
using HB.Web.Shared.ProductService;
using HB.Web.Shared.ViewModels;
using System;
using System.Collections.Generic;

namespace HB.Web.Shared.Actions.Products
{
    public class LoadProductCategoriesAction<T> where T : class
    {
        public Func<BaseViewModel<IList<ProductCategoryDto>>, T> OnSuccess { get; set; }

        private readonly IProductServiceContract productService;
        private readonly ILogger logger;

        public LoadProductCategoriesAction(ILogger logger, IProductServiceContract productService)
        {
            Guardian.ArgumentNotNull(logger, "logger");
            Guardian.ArgumentNotNull(productService, "ProductService");

            this.logger = logger;
            this.productService = productService;
        }

        public T Execute()
        {
            var products = productService.LoadProductCategories();

            var model = new BaseViewModel<IList<ProductCategoryDto>>()
            {
                Payload = products.Categories
            };

            return OnSuccess(model);
        }
    }
}
