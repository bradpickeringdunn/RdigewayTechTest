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
        /// Gets and sets a movies length.
        /// </summary>
        [DataMember]
        public string Length { get; set; }

        /// <summary>
        /// Gets and sets a movies age limit.
        /// </summary>
        [DataMember]
        public int AgeLimit { get; set; }

        /// <summary>
        /// Gets and sets a movies genre.
        /// </summary>
        [DataMember]
        public string Genre { get; set; }
        
    }
}
