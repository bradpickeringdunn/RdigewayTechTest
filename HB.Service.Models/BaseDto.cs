using System.Runtime.Serialization;

namespace HB.Services.Models
{
    /// <summary>
    /// Base class for all products.
    /// </summary>
    [DataContract]
    public abstract class BaseDto
    {
        /// <summary>
        /// Gets and sets unique product id.
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        

    }
}
