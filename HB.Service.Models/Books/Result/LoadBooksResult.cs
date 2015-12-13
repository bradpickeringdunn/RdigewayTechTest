using HB.Services.Models.Books.Dto;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HB.Services.Models.Books.Result
{
    /// <summary>
    /// Result to load books.
    /// </summary>
    [DataContract]
    public class LoadBooksResult
    {
        [DataMember]
        public IList<BookDto> Books { get; set; }
    }
}
