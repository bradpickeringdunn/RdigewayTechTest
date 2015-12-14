using HB.Web.Shared.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HB.Services.Models.Products.Requests;
using HB.Services.Models.Products.Results;

namespace HB.Web.Shared.Facades
{
    public class ProductServiceFacade : IProductServiceContract
    {
        private readonly IProductServiceContract productService;

        public ProductServiceFacade()
        {
            this.productService = new ProductServiceContractClient();
        }

        public LoadProductCategoriesResult LoadProductCategories()
        {
            return productService.LoadProductCategories();
        }

        public Task<LoadProductCategoriesResult> LoadProductCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public LoadProductsResult LoadProductsBy(LoadProductsRequest request)
        {
            return productService.LoadProductsBy(request);
        }
        public Task<LoadProductsResult> LoadProductsByAsync(LoadProductsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
