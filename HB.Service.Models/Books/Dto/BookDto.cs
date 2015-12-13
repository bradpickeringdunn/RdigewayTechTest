using HB.Services.Models.Products.Dto;
using System.Runtime.Serialization;

namespace HB.Services.Models.Books.Dto
{
    /// <summary>
    /// Represents a book.
    /// </summary>
    [DataContract]
    public class BookDto : ProductDto
    {
        /// <summary>
        /// Gets and sets the ISBN number.
        /// </summary>
        [DataMember]
        public string ISBN{ get; set; }

        /// <summary>
        /// Gets and sets the author.
        /// </summary>
        [DataMember]
        public string Author { get; set;}

        /// <summary>
        /// Gets and sets the title.
        /// </summary>
        [DataMember]
        public string Title { get; set; }
    }
}
