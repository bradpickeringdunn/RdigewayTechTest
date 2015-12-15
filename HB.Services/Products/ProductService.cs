using Backbone.Logging;
using Backbone.Repository;
using HB.Services.Api.Products;
using HB.Services.Models.Books.Dto;
using HB.Services.Models.Books.Result;
using HB.Services.Models.Movies.Dto;
using HB.Services.Models.Movies.Result;
using HB.Services.Models.Products.Dto;
using HB.Services.Models.Products.Requests;
using HB.Services.Models.Products.Results;
using System.Collections.Generic;
using System.Linq;

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

        public LoadMoviesResult LoadMovies()
        {
            return Execute<LoadMoviesResult>((result) =>
            {
                var movies = Repository.FindAll<MovieDto>().ToList();
                result.Movies = movies;
            });
        }

        public LoadBooksResult LoadBooks()
        {
            return Execute<LoadBooksResult>((result) =>
            {
                var books = Repository.FindAll<BookDto>().ToList();
                result.Books = books;
            });
        }

        public LoadProductsResult LoadProductsBy(LoadProductsRequest request)
        {
            return Execute<LoadProductsResult>((result) =>
            {
                var products = Repository.FindAll<ProductDto>(request.AsPredicate()).ToList();

                var sresult = new List<ProductDto>();

                foreach(var product in products)
                {
                    sresult.Add(new ProductDto()
                    {
                        Name = product.Name,
                        Description = product.Description,
                        Price = product.Price
                    });
                }

                result.Products = sresult;
            });
        }


    }
}
