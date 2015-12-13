using HB.Services.Models.Products.Dto;
using System.Runtime.Serialization;

namespace HB.Services.Models.Products.Requests
{
    [DataContract]
    public class LoadProductsRequest
    {
        public LoadProductsRequest(ProductFilterDto filter)
        {
            this.ProductFilter = filter;
        }

        [DataMember]
        public ProductFilterDto ProductFilter { get; set; }
    }
}
