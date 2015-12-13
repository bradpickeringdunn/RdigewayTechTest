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
        LoadProductsResult LoadProductsBy(LoadProductsRequest request);
    }
}
