using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HB.Services.Models.Products.Dto
{
    public class ProductFilterDto
    {
        public ProductFilterDto()
        {
            this.ProductIds = new List<int>();
        }

        public int? CategoryId { get; set; }

        public IList<int> ProductIds { get; set; }
    }
    
}
