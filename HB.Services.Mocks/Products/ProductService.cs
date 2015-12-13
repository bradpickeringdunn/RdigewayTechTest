using HB.Services.Api.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HB.Services.Models.Products.Requests;
using HB.Services.Models.Products.Results;
using HB.Services.Models.Products.Dto;

namespace HB.Services.Mocks.Products
{
    public class ProductService : IProductServiceContract
    {
        public LoadProductCategoriesResult LoadProductCategories()
        {
            return new LoadProductCategoriesResult()
            {
                Categories = new List<ProductCategoryDto>()
                {
                    new ProductCategoryDto {Id=22, Name = "Books" },
                    new ProductCategoryDto {Id=33, Name = "Movies" }
                }
            };
        }

        public LoadProductsResult LoadProductsBy(LoadProductsRequest request)
        {
            return new LoadProductsResult()
            {
                Products = new List<ProductDto>()
                {
                    new ProductDto()
                    {
                        Id = 1,
                        Name = "Some book",
                        Description = "Bogus book",
                        Price = 500m
                    },
                    new ProductDto()
                    {
                        Id = 2,
                        Name = "Some other book",
                        Description = "Bogus book 2",
                        Price = 300m
                    }
                }
            };
        }
    }
}
