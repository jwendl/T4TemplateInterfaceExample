using Csla;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISongEdit
        : IBusinessBase
    {
        /// <summary>
        /// Gets or sets the song identifier.
        /// </summary>
        /// <value>
        /// The song identifier.
        /// </value>
        int SongId { get; set; }

        /// <summary>
        /// Gets or sets the album identifier.
        /// </summary>
        /// <value>
        /// The album identifier.
        /// </value>
        [Display(ResourceType = typeof(AppResources), Name = "Song_Album")]
        int AlbumId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [MaxLength(128)]
        [Display(ResourceType = typeof(AppResources), Name = "Song_Name")]
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        [MaxLength(10)]
        [Display(ResourceType = typeof(AppResources), Name = "Song_Length")]
        string Length { get; set; }

        /// <summary>
        /// Gets or sets the tiny song URL.
        /// </summary>
        /// <value>
        /// The tiny song URL.
        /// </value>
        [MaxLength(256)]
        [Display(ResourceType = typeof(AppResources), Name = "Song_TinySongUrl")]
        string TinySongUrl { get; set; }
    }
}
