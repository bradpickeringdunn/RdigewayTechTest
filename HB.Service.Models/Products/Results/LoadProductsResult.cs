using Backbone.Services.Results;
using HB.Services.Models.Products.Dto;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HB.Services.Models.Products.Results
{
    [DataContract]
    public class LoadProductsResult : GenericServiceResult
    {
        [DataMember]
        public IList<ProductDto> Products { get; set; }
    }
}
