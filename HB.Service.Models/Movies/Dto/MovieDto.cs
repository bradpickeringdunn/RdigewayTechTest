using HB.Services.Models.Products.Dto;
using System.Runtime.Serialization;

namespace HB.Services.Models.Movies.Dto
{
    /// <summary>
    /// Represent a movie.
    /// </summary>
    [DataContract]
    public class MovieDto : ProductDto
    {
        /// <summary>
        /// Gets and sets a movies category.
        /// </summary>
        [DataMember]
        public string Category { get; set; }
    }
}
