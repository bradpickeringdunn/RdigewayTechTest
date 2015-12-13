using Backbone.Services.Results;
using HB.Services.Models.Movies.Dto;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HB.Services.Models.Movies.Result
{
    /// <summary>
    /// Result for loading movies.
    /// </summary>
    [DataContract]
    public class LoadMoviesResult : GenericServiceResult
    {
        /// <summary>
        /// Gets and sets movies.
        /// </summary>
        [DataMember]
        public IList<MovieDto> Movies { get; set; }
    }
}
