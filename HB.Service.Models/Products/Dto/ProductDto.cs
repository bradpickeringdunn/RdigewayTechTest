using System.Runtime.Serialization;

namespace HB.Services.Models.Products.Dto
{
    /// <summary>
    /// Represents a base product
    /// </summary>
    [DataContract]
    public class ProductDto : BaseDto
    {
        /// <summary>
        /// Gets and sets product name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets and sets a product price.
        /// </summary>
        [DataMember]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets and sets a product description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
