using Csla;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface IArtist
        : IReadOnlyBase
    {
        /// <summary>
        /// Gets or sets the artist identifier.
        /// </summary>
        /// <value>
        /// The artist identifier.
        /// </value>
        int ArtistId { get; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [MaxLength(128)]
        [Display(ResourceType = typeof(AppResources), Name = "Artist_Name")]
        string Name { get; }
    }
}
