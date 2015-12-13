using Backbone.Services.Results;
using HB.Services.Models.Products.Dto;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HB.Services.Models.Products.Results
{
    [DataContract]
    public class LoadProductCategoriesResult : GenericServiceResult
    {
        [DataMember]
        public IList<ProductCategoryDto> Categories {get;set;}
    }
}
