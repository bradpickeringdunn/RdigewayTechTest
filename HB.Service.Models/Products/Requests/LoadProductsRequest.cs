using Backbone.Utilities;
using HB.Services.Models.Products.Dto;
using System;
using System.Linq;
using System.Linq.Expressions;
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

        public Expression<Func<ProductDto, bool>> AsPredicate()
        {
            Expression<Func<ProductDto, bool>> predicate = PredicateBuilder.False<ProductDto>();

            if (ProductFilter.ProductIds.Any())
            {
                foreach (var id in ProductFilter.ProductIds)
                {
                    predicate = predicate.Or<ProductDto>(p => p.Id == id);
                }
                return predicate;
            }

            if (ProductFilter.CategoryId.HasValue)
            {
                predicate = predicate.Or<ProductDto>(p => p.CategoryId == ProductFilter.CategoryId);
                return predicate;
            }

            return predicate;
        }
        
    }
}
