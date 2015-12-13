using System.Runtime.Serialization;

namespace HB.Services.Models.Products.Dto
{
    [DataContract]
    public class ProductCategoryDto : BaseDto
    {
        [DataMember]
        public string Name { get; set; }
    }
}
