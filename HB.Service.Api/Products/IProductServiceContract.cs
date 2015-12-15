using HB.Services.Models.Books.Result;
using HB.Services.Models.Movies.Result;
using HB.Services.Models.Products.Requests;
using HB.Services.Models.Products.Results;
using System.ServiceModel;

namespace HB.Services.Api.Products
{
    [ServiceContract]
    public interface IProductServiceContract
    {
        [OperationContract]
        LoadProductCategoriesResult LoadProductCategories();

        [OperationContract]
        LoadBooksResult LoadBooks();

        [OperationContract]
        LoadMoviesResult LoadMovies();

        [OperationContract]
        LoadProductsResult LoadProductsBy(LoadProductsRequest request);
    }
}
