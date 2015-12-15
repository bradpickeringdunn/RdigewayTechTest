using Backbone.Logging;
using Backbone.Utilities;
using HB.Services.Models.Books.Dto;
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
    public class LoadBooksAction<T> where T : class
    {
        private readonly IProductServiceContract productService;
        private readonly ILogger logger;

        public Func<BaseViewModel<IList<BookDto>>, T> OnSuccess { get; set; }

        public LoadBooksAction(ILogger logger, IProductServiceContract productService)
        {
            Guardian.ArgumentNotNull(logger, "logger");
            Guardian.ArgumentNotNull(productService, "productService");

            this.logger = logger;
            this.productService = productService;
        }

        public T Execute()
        {
            var productResult = productService.LoadBooks();

            if (productResult.IsNull())
            {
                logger.Error("");
                productResult.Notifications.Add(""); 
            }

            var model = new BaseViewModel<IList<BookDto>>()
            {
                Notifications = productResult.Notifications,
                Payload = productResult.Books
            };

            return OnSuccess(model);

        }

    }
}
