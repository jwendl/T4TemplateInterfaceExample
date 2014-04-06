using System.ComponentModel.DataAnnotations;

namespace Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAlbumEdit
    {
        /// <summary>
        /// Gets or sets the album identifier.
        /// </summary>
        /// <value>
        /// The album identifier.
        /// </value>
        int AlbumId { get; set; }

        /// <summary>
        /// Gets or sets the artist identifier.
        /// </summary>
        /// <value>
        /// The artist identifier.
        /// </value>
        [Display(ResourceType = typeof(AppResources), Name = "Album_Artist")]
        int ArtistId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [MaxLength(128)]
        [Display(ResourceType = typeof(AppResources), Name = "Album_Name")]
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>
        /// The image URL.
        /// </value>
        [MaxLength(256)]
        [Display(ResourceType = typeof(AppResources), Name = "Album_ImageUrl")]
        string ImageUrl { get; set; }
    }
}
