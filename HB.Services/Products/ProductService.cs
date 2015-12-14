using System;
using System.Linq;
using HB.Services.Api.Products;
using HB.Services.Models.Products.Requests;
using HB.Services.Models.Products.Results;
using Backbone.Logging;
using Backbone.Repository;
using HB.Services.Models.Products.Dto;

namespace HB.Services.Products
{
    public class ProductService : ServiceBase, IProductServiceContract
    {
        public ProductService(ILogger logger, IRepository repository)
            :base(logger, repository)
        {}

        public LoadProductCategoriesResult LoadProductCategories()
        {
            return Execute<LoadProductCategoriesResult>((result) =>
           {
               var categories = Repository.FindAll<ProductCategoryDto>();

               result.Categories = categories.ToList();
               
           });
        }

        public LoadProductsResult LoadProductsBy(LoadProductsRequest request)
        {
            return Execute<LoadProductsResult>((result) =>
            {
                var products = Repository.FindAll<ProductDto>(request.AsPredicate()).ToList();
                result.Products = products;
            });
        }
        
    }
}
